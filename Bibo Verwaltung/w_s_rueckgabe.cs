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
    public partial class w_s_rueckgabe : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        string currentUser;
        public w_s_rueckgabe(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            zustand.FillCombobox(ref cb_Zustand, -1);
        }
        #endregion

        Rueckgabe rueckgabe = new Rueckgabe();
        Zustand zustand = new Zustand();
        Kunde kunde = new Kunde();
        DataTable rueckListe = new DataTable();

        bool buch_verfuegbar = false;
        string rueckgabe_ExemplarID = "";
        string zustand_AusleihStart = "";
        string zustand_AusleihEnde = "";

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
        /// Setzt das Fenster auf den Ausgangszustand zurück (alles leer)
        /// </summary>
        private void Reset_Window()
        {
            llb_BuchTitel.Enabled = false;
            llb_BuchTitel.Text = "keine Treffer";
            llb_Kunde.Enabled = false;
            llb_Kunde.Text = "nicht verliehen";
            lb_AusleihStart.Enabled = false;
            lb_AusleihStart.Text = "nicht verfügbar";
            lb_AusleihEnde.Enabled = false;
            lb_AusleihEnde.Text = "nicht verfügbar";
            cb_Zustand.Enabled = false;
            bt_Zu_aendern.Text = "Buchzustand ändern";
            cb_Zustand.SelectedValue = -1;
            lb_AusleihEnde.ForeColor = Color.Black;
            picBox_Buchcover.Image = null;
            gv_Verlauf.DataSource = null;
            gv_Verlauf.Update();
            bt_Zu_aendern.Enabled = false;
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
        /// Setzt den Auswahl-Slider anhand der Elemente der Rückgabeliste
        /// </summary>
        private void SetSlider()
        {
            if (rueckListe.Rows.Count == 0)
            {
                rueckList_Slider.Enabled = false;
                rueckList_Slider.Minimum = 0;
                rueckList_Slider.Maximum = 0;
            }
            else
            {
                rueckList_Slider.Enabled = true;
                rueckList_Slider.Minimum = 1;
                rueckList_Slider.Maximum = rueckListe.Rows.Count;
                rueckList_Slider.Value = rueckList_Slider.Maximum;
            }
            tb_listVon.Text = rueckList_Slider.Value.ToString();
            tb_listBis.Text = rueckList_Slider.Maximum.ToString();
        }

        /// <summary>
        /// Prüft die Buchrückgabeliste auf das Vorhandensein der angegebenen Exemlar ID 
        /// </summary>
        private bool CheckRueckList(string ExemlarID)
        {
            bool result = false;
            for (int i = 0; i <= rueckListe.Rows.Count - 1; i++)
            {
                if (rueckListe.Rows[i][0].ToString() == ExemlarID)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Baut einen Dialogstring abhängig von der Buchrückgabe-Anzahl
        /// </summary>
        private String GetRueckgabeList()
        {
            Exemplar exemplar;
            Buch exemplar_info;
            string resultString = "Möchten Sie ";
            if (rueckListe.Rows.Count == 1)
            {
                exemplar = new Exemplar(rueckListe.Rows[0][0].ToString());
                exemplar_info = new Buch(exemplar.ISBN);
                resultString = resultString + "das Buch: " + Environment.NewLine + Environment.NewLine + exemplar_info.Titel + ", " + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                resultString = resultString + "die Bücher: " + Environment.NewLine + Environment.NewLine;
                foreach (DataRow row in rueckListe.Rows)
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
        /// Zeigt die Suchergebnisse an
        /// </summary>
        private void ShowBuchResults()
        {
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
                if (CheckRueckList(tb_BuchCode.Text))
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
                        rueckgabe_ExemplarID = buch_exemplar.ExemplarID;
                        cb_Zustand.SelectedValue = buch_exemplar.Zustand.ZustandID;
                        zustand_AusleihStart = buch_exemplar.Zustand.Zustandname;
                        zustand_AusleihEnde = buch_exemplar.Zustand.Zustandname;
                        Verlauf verlauf = new Verlauf(rueckgabe_ExemplarID);
                        verlauf.FillGrid(ref gv_Verlauf);

                        if (!buch_verfuegbar)
                        {
                            rueckgabe.Load_Info(tb_BuchCode.Text);
                            kunde = new Kunde(rueckgabe.KID);
                            llb_Kunde.Enabled = true;
                            lb_AusleihStart.Enabled = true;
                            lb_AusleihEnde.Enabled = true;
                            bt_Zu_aendern.Enabled = true;
                            llb_Kunde.Text = TrimText(kunde.Vorname + ", " + kunde.Nachname);
                            lb_AusleihStart.Text = rueckgabe.Leihdatum.Date.ToShortDateString();
                            lb_AusleihEnde.Text = rueckgabe.Rueckgabedatum.Date.ToShortDateString();
                            if (rueckgabe.Rueckgabedatum.Date < DateTime.Now.Date)
                            {
                                lb_AusleihEnde.ForeColor = Color.Red;
                                lb_AusleihEnde.Text = lb_AusleihEnde.Text + " (überfällig)";
                            }
                        }
                        else
                        {
                            llb_Kunde.Enabled = false;
                            lb_AusleihStart.Enabled = false;
                            lb_AusleihEnde.Enabled = false;
                            bt_Zu_aendern.Enabled = false;
                            llb_Kunde.Text = "nicht verliehen";
                            lb_AusleihStart.Text = "nicht verfügbar";
                            lb_AusleihEnde.Text = "nicht verfügbar";
                            lb_AusleihEnde.ForeColor = Color.Black;
                        }
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
        /// Führt die Buchrückgabe aus
        /// </summary>
        private void Buchrueckgabe()
        {
            DialogResult dialogResult = MessageBox.Show(GetRueckgabeList() + "ausgeliehen von: '" + TrimText(kunde.Vorname + " " + kunde.Nachname) + "' wirklich als zurückgegeben markieren?", "Achtung",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    foreach (DataRow row in rueckListe.Rows)
                    {
                        rueckgabe.Load_Info(row[0].ToString());
                        rueckgabe.Execute_Rueckgabe(row[0].ToString(), rueckgabe.KID, row[1].ToString(), zustand.GetID(row[1].ToString()), row[2].ToString(), rueckgabe.Leihdatum.ToShortDateString(), DateTime.Now.Date.ToShortDateString());
                        //rueckgabe.Save_Transaction(); In Bearbeitung!!!
                    }
                    MessageBox.Show("Die Buchrückgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Die Buchrückgabe konnte nicht abgeschlossen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                rueckListe.Clear();
                SetSlider();
                tb_BuchCode.Text = "";
                tb_BuchCode.Focus();
            }
        }

        /// <summary>
        /// Fügt einen Eintrag zur Buchrückgabe-Liste hinzu
        /// </summary>
        private void AddToRueckgabeList()
        {
            try
            {
                DataRow relation;
                string[] exemlarDetails = new string[3];

                exemlarDetails[0] = rueckgabe_ExemplarID;
                exemlarDetails[1] = zustand_AusleihStart;
                exemlarDetails[2] = zustand_AusleihEnde;
                if (rueckListe.Columns.Count != 4)
                {
                    rueckListe.Columns.Add();
                    rueckListe.Columns.Add();
                    rueckListe.Columns.Add();
                    rueckListe.Columns.Add();
                }
                relation = rueckListe.NewRow();
                relation.ItemArray = exemlarDetails;
                rueckListe.Rows.Add(relation);

                SetSlider();
                tb_BuchCode.Focus();
                tb_BuchCode.SelectAll();
                bt_AddBuch.Text = "-";
            }
            catch
            {
                MessageBox.Show("Beim Hinzufügen dieses Buches zur Buchrückgabeliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Buchrückgabe-Liste
        /// </summary>
        private void RemoveFromRueckgabeList()
        {
            try
            {
                for (int i = rueckListe.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = rueckListe.Rows[i];
                    if (row[0].ToString() == tb_BuchCode.Text)
                        row.Delete();
                }
                rueckListe.AcceptChanges();

                if (rueckList_Slider.Maximum > 1)
                {
                    rueckList_Slider.Maximum = rueckList_Slider.Maximum - 1;
                    rueckList_Slider.Value = rueckList_Slider.Maximum;
                tb_listVon.Text = rueckList_Slider.Value.ToString();
                tb_listBis.Text = rueckList_Slider.Maximum.ToString();
                }
                else
                {
                    tb_listVon.Text = "-";
                    tb_listBis.Text = "-";
                }              
                bt_AddBuch.Text = "+";
            }
            catch
            {
                MessageBox.Show("Beim Entfernen dieses Buches von der Buchrückgabeliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Componenten-Aktionen
        private void tb_BuchCode_TextChanged(object sender, EventArgs e)
        {
            ShowBuchResults();
        }

        private void llb_Buch_LinkClicked(object sender, EventArgs e)
        {
            Form Info = new w_s_information(1, rueckgabe_ExemplarID, currentUser);
            Info.ShowDialog();
        }

        private void llb_Kunde_LinkClicked(object sender, EventArgs e)
        {
            Form Info = new w_s_information(2, kunde.KundenID, currentUser);
            Info.ShowDialog();
        }

        private void bt_Rueckgabe_Click(object sender, EventArgs e)
        {
            if (rueckListe.Rows.Count == 0)
            {
                if (!buch_verfuegbar)
                {
                    if (bt_Zu_aendern.Text == "Übernehmen")
                    {
                        DialogResult dr = MessageBox.Show("Möchten Sie die Zustandsänderung übernehmen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            zustand_AusleihEnde = cb_Zustand.Text;
                            cb_Zustand.Enabled = false;
                            bt_Zu_aendern.Text = "Buchzustand ändern";
                        }
                        else
                        {
                            zustand_AusleihEnde = zustand_AusleihStart;
                            cb_Zustand.Enabled = false;
                            bt_Zu_aendern.Text = "Buchzustand ändern";
                        }
                    }
                    AddToRueckgabeList();
                }
                else
                {
                    MessageBox.Show("Dieses Buch wurde nicht verliehen. Es kann nicht zur Buchrückgabeliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (rueckListe.Rows.Count != 0)
            {
                Buchrueckgabe();
            }
        }

        private void bt_Zu_aendern_Click(object sender, EventArgs e)
        {
            if (cb_Zustand.Enabled == false)
            {
                cb_Zustand.Enabled = true;
                bt_Zu_aendern.Text = "Übernehmen";
            }
            else
            {
                zustand_AusleihEnde = cb_Zustand.Text;
                cb_Zustand.Enabled = false;
                bt_Zu_aendern.Text = "Buchzustand ändern";
            }
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            Form Zustand = new w_s_zustand();
            Zustand.ShowDialog(this);
            zustand.FillCombobox(ref cb_Zustand, -1);
        }

        private void bt_AddBuch_Click(object sender, EventArgs e)
        {
            if (tb_BuchCode.Text != "")
            {
                if (!buch_verfuegbar)
                {
                    if (!CheckRueckList(tb_BuchCode.Text))
                    {
                        if (bt_Zu_aendern.Text == "Übernehmen")
                        {
                            DialogResult dr = MessageBox.Show("Möchten Sie die Zustandsänderung übernehmen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (dr == DialogResult.Yes)
                            {
                                zustand_AusleihEnde = cb_Zustand.Text;
                                cb_Zustand.Enabled = false;
                                bt_Zu_aendern.Text = "Buchzustand ändern";
                            }
                            else
                            {
                                zustand_AusleihEnde = zustand_AusleihStart;
                                cb_Zustand.Enabled = false;
                                bt_Zu_aendern.Text = "Buchzustand ändern";
                            }
                        }
                        AddToRueckgabeList();
                    }
                    else
                    {
                        RemoveFromRueckgabeList();
                    }
                }
                else
                {
                    MessageBox.Show("Dieses Buch wurde nicht verliehen. Es kann nicht zur Buchrückgabeliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                tb_BuchCode.Focus();
                tb_BuchCode.SelectAll();

                if (rueckListe.Rows.Count > 0)
                {
                    rueckList_Slider.Enabled = true;
                }
                else
                {
                    rueckList_Slider.Enabled = false;
                }
            }
        }

        private void hScrollBar(object sender, ScrollEventArgs e)
        {
            tb_listVon.Text = rueckList_Slider.Value.ToString();
            tb_listBis.Text = rueckList_Slider.Maximum.ToString();
            tb_BuchCode.Text = rueckListe.Rows[rueckList_Slider.Value - 1][0].ToString();
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }     

        private void tb_BuchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                AddToRueckgabeList();
            }
        }
        #endregion
    }
}
