using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_ausleihe : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        string currentUser;
        public w_s_ausleihe(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            kunde.FillGrid(ref gv_Kunde);
        }

        public w_s_ausleihe(string userName, string[] list)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            kunde.FillGrid(ref gv_Kunde);
            FillAusleihListe(list);
        }
        #endregion

        Ausleihe ausleihe = new Ausleihe();
        Kunde kunde = new Kunde();
        DataTable leihListe = new DataTable();

        bool buch_verfuegbar = false;

        #region Fenster-Methoden
        /// <summary>
        /// Exemplar-Code-Parser
        /// </summary>
        static int _checksum_ean8(String data)
        {
            // Test string for correct length
            if (data.Length != 7 && data.Length != 8)
                return -1;
            // Test string for being numeric
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0x30 || data[i] > 0x39)
                    return -1;
            }
            int sum = 0;
            for (int i = 6; i >= 0; i--)
            {
                int digit = data[i] - 0x30;
                if ((i & 0x01) == 1)
                    sum += digit;
                else
                    sum += digit * 3;
            }
            int mod = sum % 10;
            return mod == 0 ? 0 : 10 - mod;
        }

        /// <summary>
        /// Löscht eine Bilddatei am angegebenen Pfad
        /// </summary>
        private void Delete_picture(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        /// <summary>
        /// Prüft die Buchausleihliste auf das Vorhandensein der angegebenen Exemlar ID 
        /// </summary>
        private bool CheckLeihList(string ExemplarID)
        {
            bool result = false;
            for (int i = 0; i <= leihListe.Rows.Count - 1; i++)
            {
                if (leihListe.Rows[i][0].ToString() == ExemplarID)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Übernimmt eine vorgefertigte Liste in die Buchausleihliste 
        /// </summary>
        private void FillAusleihListe(string[] inputList)
        {
            try
            {
                DataRow relation;
                string[] exemlarDetails = new string[2];

                if (leihListe.Columns.Count != 2)
                {
                    leihListe.Columns.Add();
                    leihListe.Columns.Add();
                }

                for (int i = 0; i <= inputList.Length; i++)
                {
                    exemlarDetails[0] = inputList[i];
                    exemlarDetails[1] = DateTime.Now.Date.ToShortDateString();
                    relation = leihListe.NewRow();
                    relation.ItemArray = exemlarDetails;
                    leihListe.Rows.Add(relation);
                }
                SetSlider();
            }
            catch
            {
                MessageBox.Show("Beim Laden der Liste in die Buchausleihliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Baut einen Dialogstring abhängig von der Buchausleih-Anzahl
        /// </summary>
        private String GetAusleihList()
        {
            Exemplar exemplar;
            Buch exemplar_info;
            string resultString = "Möchten Sie ";
            if (leihListe.Rows.Count == 1)
            {
                exemplar = new Exemplar(leihListe.Rows[0][0].ToString());
                exemplar_info = new Buch(exemplar.ISBN);
                resultString = resultString + "das Buch: " + Environment.NewLine + Environment.NewLine + exemplar_info.Titel + ", " + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                resultString = resultString + "die Bücher: " + Environment.NewLine + Environment.NewLine;
                foreach (DataRow row in leihListe.Rows)
                {
                    exemplar = new Exemplar(row[0].ToString());
                    exemplar_info = new Buch(exemplar.ISBN);
                    resultString = resultString + "-  " + TrimText(exemplar_info.Titel) + ", " + Environment.NewLine;
                }
                resultString = resultString + Environment.NewLine;
            }
            return resultString;
        }

        /// <summary>
        /// Schneidet einen String auf eine Länge von 30 Zeichen
        /// </summary>
        private String TrimText(string inputText)
        {
            string outputText = "";
            if (inputText.Length > 30)
            {
                outputText = inputText.Substring(0, 30) + "...";
            }
            else
            {
                outputText = inputText;
            }
            return outputText.Trim();
        }

        /// <summary>
        /// Gibt den Row-Index der ExemplarID in der Buchausleihliste wieder
        /// </summary>
        private int GetIndexInLeihliste(string ExemplarID)
        {
            int result = -1;
            for (int i = 0; i <= leihListe.Rows.Count - 1; i++)
            {
                if (leihListe.Rows[i][0].ToString() == ExemplarID)
                {
                    result = i;
                }
            }
            return result;
        }

        /// <summary>
        /// Setzt das Fenster auf den Ausgangszustand zurück (alles leer)
        /// </summary>
        private void Reset_Window()
        {
            llb_BuchTitel.Enabled = false;
            llb_BuchTitel.Text = "keine Treffer";
            tb_VName.Text = "Vorname";
            tb_NName.Text = "Nachname";
            kunde.FillGrid(ref gv_Kunde);
            lb_BuchZustand.Enabled = false;
            lb_BuchZustand.Text = "nicht verfügbar";
            lb_BuchStatus.Enabled = false;
            lb_BuchStatus.ForeColor = Color.Black;
            lb_BuchStatus.Text = "nicht verfügbar";
            picBox_Buchcover.Image = null;
            dp_RueckDatum.Value = DateTime.Now.Date;
        }

        /// <summary>
        /// Zeigt die Suchergebnisse an
        /// </summary>
        private void ShowBuchResults()
        {
            Cursor = Cursors.WaitCursor;
            #region Buchcode parsen
            if (tb_BuchCode.Text.Length == 8)
            {
                string seven = tb_BuchCode.Text.Substring(0, 7);
                string eight = tb_BuchCode.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tb_BuchCode.Text = int.Parse(seven).ToString();
                }
            }
            #endregion

            if (tb_BuchCode.Text != "")
            {
                if (CheckLeihList(tb_BuchCode.Text))
                {
                    bt_AddBuch.Text = "-";
                }
                else
                {
                    bt_AddBuch.Text = "+";
                }

                try
                {
                    Exemplar buch_exemplar = new Exemplar(tb_BuchCode.Text);
                    buch_verfuegbar = buch_exemplar.IsSpecificAvailable();
                    if (buch_exemplar.IsActivated())
                    {
                        #region Exemplar-Details laden + anzeigen
                        Buch buch = new Buch(buch_exemplar.ISBN);
                        llb_BuchTitel.Enabled = true;
                        llb_BuchTitel.Text = TrimText(buch.Titel);
                        ausleihe.ExemplarID = buch_exemplar.ExemplarID;
                        lb_BuchZustand.Enabled = true;
                        lb_BuchZustand.Text = buch_exemplar.Zustand.Zustandname;
                        lb_BuchStatus.Enabled = true;
                        if (buch_verfuegbar)
                        {
                            lb_BuchStatus.Text = "verfügbar";
                            lb_BuchStatus.ForeColor = Color.Green;
                        }
                        else
                        {
                            lb_BuchStatus.Text = "nicht verfügbar (verliehen)";
                            lb_BuchStatus.ForeColor = Color.Red;
                        }
                        if (CheckLeihList(ausleihe.ExemplarID))
                        {
                            dp_RueckDatum.Value = Convert.ToDateTime(leihListe.Rows[GetIndexInLeihliste(ausleihe.ExemplarID)][1]);
                        }
                        else
                        {
                            dp_RueckDatum.Value = DateTime.Now.Date;
                        }
                        ausleihe.Rueckgabedatum = dp_RueckDatum.Value;
                        #endregion

                        #region Buchcover anzeigen
                        if (buch.Image != null)
                        {
                            try
                            {
                                MemoryStream mem = new MemoryStream(buch.Image);
                                picBox_Buchcover.Image = Image.FromStream(mem);
                                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bibliothek\\Bilder\\" + buch.ISBN + ".png";
                                if (!File.Exists(filePath))
                                {
                                    picBox_Buchcover.Image.Save(filePath, ImageFormat.Png);
                                    picBox_Buchcover.ImageLocation = filePath;
                                }
                                else
                                {
                                    Delete_picture(filePath);
                                    picBox_Buchcover.Image.Save(filePath, ImageFormat.Png);
                                    picBox_Buchcover.ImageLocation = filePath;
                                }
                            }
                            catch
                            {
                            }
                        }
                        else
                        {
                            if (!buch.BildPfad.Equals(""))
                            {
                                try
                                {
                                    picBox_Buchcover.ImageLocation = buch.BildPfad;
                                }
                                catch
                                {
                                    MessageBox.Show("Das Buchcover wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                picBox_Buchcover.Image = null;
                                picBox_Buchcover.ImageLocation = null;
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        Reset_Window();
                    }
                }
                catch
                {
                    Reset_Window();
                }
            }
            else
            {
                Reset_Window();
            }
            Cursor = Cursors.Default;
        }

        /// <summary>
        /// Fügt einen Eintrag zur Buchausleih-Liste hinzu
        /// </summary>
        private void AddToAusleihList()
        {
            try
            {
                DataRow relation;
                string[] exemlarDetails = new string[2];

                exemlarDetails[0] = ausleihe.ExemplarID;
                exemlarDetails[1] = dp_RueckDatum.Value.ToString();

                if (leihListe.Columns.Count != 2)
                {
                    leihListe.Columns.Add();
                    leihListe.Columns.Add();
                }
                relation = leihListe.NewRow();
                relation.ItemArray = exemlarDetails;
                leihListe.Rows.Add(relation);

                bt_AddBuch.Text = "-";
            }
            catch
            {
                MessageBox.Show("Beim Hinzufügen dieses Buches zur Buchausleihliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Buchausleih-Liste
        /// </summary>
        private void RemoveFromAusleihList()
        {
            try
            {
                for (int i = leihListe.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = leihListe.Rows[i];
                    if (row[0].ToString() == tb_BuchCode.Text)
                        row.Delete();
                }
                leihListe.AcceptChanges();

                bt_AddBuch.Text = "+";
            }
            catch
            {
                MessageBox.Show("Beim Entfernen dieses Buches von der Buchausleihliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sucht einen Kunden zur Auswahl
        /// </summary>
        private void SearchKunde(string vorname, string nachname)
        {
            if (vorname == "Vorname")
            {
                vorname = "";
            }
            if (nachname == "Nachname")
            {
                nachname = "";
            }
            (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%'", vorname, nachname);
        }

        /// <summary>
        /// Setzt den Auswahl-Slider anhand der Elemente der Ausleihliste
        /// </summary>
        private void SetSlider()
        {
            if (leihListe.Rows.Count == 0)
            {
                leihList_Slider.Enabled = false;
                leihList_Slider.Minimum = 0;
                leihList_Slider.Maximum = 0;
            }
            else
            {
                leihList_Slider.Enabled = true;
                leihList_Slider.Minimum = 1;
                leihList_Slider.Maximum = leihListe.Rows.Count;
                leihList_Slider.Value = leihList_Slider.Maximum;
            }
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
        }

        /// <summary>
        /// Führt die Buchausgabe aus
        /// </summary>
        private void Buchausgabe()
        {
            kunde = new Kunde(ausleihe.KID);
            DialogResult dialogResult = MessageBox.Show(GetAusleihList() + "an: '" + TrimText(kunde.Vorname + " " + kunde.Nachname) + "' wirklich ausleihen?", "Achtung",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    foreach (DataRow row in leihListe.Rows)
                    {
                        ausleihe.Execute_Ausleihe(Convert.ToInt32(row[0].ToString()), DateTime.Now.Date.ToShortDateString(), row[1].ToString(), Convert.ToInt32(kunde.KundenID));
                        //ausleihe.Save_Transaction(); In Bearbeitung!!!
                    }
                    MessageBox.Show("Die Buchausgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Die Buchausgabe konnte nicht abgeschlossen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                leihListe.Clear();
                SetSlider();
                tb_BuchCode.Text = "";
                tb_BuchCode.Focus();
            }
        }
        #endregion

        #region Componenten-Aktionen
        private void llb_BuchTitel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Info = new w_s_information(1, ausleihe.ExemplarID, currentUser);
            Info.ShowDialog();
        }

        private void tb_BuchCode_TextChanged(object sender, EventArgs e)
        {
            ShowBuchResults();
        }

        private void bt_AddBuch_Click(object sender, EventArgs e)
        {
            if (tb_BuchCode.Text != "")
            {
                if (buch_verfuegbar)
                {
                    if (!CheckLeihList(tb_BuchCode.Text))
                    {
                        AddToAusleihList();
                    }
                    else
                    {
                        RemoveFromAusleihList();
                    }
                }
                else
                {
                    MessageBox.Show("Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                SetSlider();
                tb_BuchCode.Focus();
                tb_BuchCode.SelectAll();
            }
        }

        private void leihList_Slider_Scroll(object sender, ScrollEventArgs e)
        {
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
            tb_BuchCode.Text = leihListe.Rows[leihList_Slider.Value - 1][0].ToString();
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }

        private void bt_NeuKunde_Click(object sender, EventArgs e)
        {
            Form Kunden = new w_s_Kunden(currentUser);
            Kunden.ShowDialog(this);
            kunde.FillGrid(ref gv_Kunde);
        }

        private void tb_VName_TextChanged(object sender, EventArgs e)
        {
            SearchKunde(tb_VName.Text, tb_NName.Text);
        }

        private void tb_NName_TextChanged(object sender, EventArgs e)
        {
            SearchKunde(tb_VName.Text, tb_NName.Text);
        }

        private void tb_VName_Enter(object sender, EventArgs e)
        {
            if (tb_VName.Text == "Vorname")
            {
                tb_VName.Text = "";
            }
            tb_VName.ForeColor = Color.Black;
        }

        private void tb_VName_Leave(object sender, EventArgs e)
        {
            if (tb_VName.Text == "")
            {
                tb_VName.Text = "Vorname";
                tb_VName.ForeColor = Color.Gray;
            }
            else
            {
                tb_VName.ForeColor = Color.Black;
            }
        }

        private void tb_NName_Enter(object sender, EventArgs e)
        {
            if (tb_NName.Text == "Nachname")
            {
                tb_NName.Text = "";
            }
            tb_NName.ForeColor = Color.Black;
        }

        private void tb_NName_Leave(object sender, EventArgs e)
        {
            if (tb_NName.Text == "")
            {
                tb_NName.Text = "Nachname";
                tb_NName.ForeColor = Color.Gray;
            }
            else
            {
                tb_NName.ForeColor = Color.Black;
            }
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            if (gv_Kunde.CurrentRow != null)
            {
                ausleihe.KID = gv_Kunde.CurrentRow.Cells["Kunden-ID"].Value.ToString();
                tb_VName.Text = gv_Kunde.CurrentRow.Cells["Vorname"].Value.ToString();
                tb_NName.Text = gv_Kunde.CurrentRow.Cells["Nachname"].Value.ToString();

                if (leihListe.Rows.Count == 0)
                {
                    if (buch_verfuegbar)
                    {
                        AddToAusleihList();
                    }
                    else
                    {
                        MessageBox.Show("Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (leihListe.Rows.Count != 0)
                {
                    Buchausgabe();
                }

            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Kunden aus! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tb_BuchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AddToAusleihList();
            }
        }
        #endregion
    }
}
