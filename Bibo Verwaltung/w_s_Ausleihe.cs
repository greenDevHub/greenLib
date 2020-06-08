using MetroFramework;
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
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName + " (" + user.Rechte + ")";
            if (user.Rechteid.Equals("0"))
            {
                bt_AddBuch.Enabled = false;
                dp_RueckDatum.Enabled = false;
                bt_NeuKunde.Enabled = false;
                tb_VName.Enabled = false;
                tb_NName.Enabled = false;
                bt_Submit.Enabled = false;
            }
            else
            {
                bt_AddBuch.Enabled = true;
                dp_RueckDatum.Enabled = true;
                bt_NeuKunde.Enabled = true;
                tb_VName.Enabled = true;
                tb_NName.Enabled = true;
                bt_Submit.Enabled = true;
                kunde.FillGrid(ref gv_Kunde);
            }
        }

        public w_s_ausleihe(string userName, string[] list)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName + " (" + user.Rechte + ")";
            if (user.Rechteid.Equals("0"))
            {
                bt_AddBuch.Enabled = false;
                dp_RueckDatum.Enabled = false;
                bt_NeuKunde.Enabled = false;
                tb_VName.Enabled = false;
                tb_NName.Enabled = false;
                bt_Submit.Enabled = false;
            }
            else
            {
                bt_AddBuch.Enabled = true;
                dp_RueckDatum.Enabled = true;
                bt_NeuKunde.Enabled = true;
                tb_VName.Enabled = true;
                tb_NName.Enabled = true;
                bt_Submit.Enabled = true;
                kunde.FillGrid(ref gv_Kunde);
                ausleihe.FillAusleihListe(list);
                ausleihe.SetSlider(ref leihList_Slider, ref tb_listVon, ref tb_listBis);
            }
        }
        #endregion

        Ausleihe ausleihe = new Ausleihe();
        Kunde kunde = new Kunde();

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
        /// Setzt das Fenster auf den Ausgangszustand zurück (alles leer)
        /// </summary>
        private void Reset_Window()
        {
            if (new Benutzer(currentUser).Rechteid.Equals("0"))
            {
                llb_BuchTitel.Enabled = false;
                llb_BuchTitel.Text = "keine Treffer";
                lb_BuchZustand.Enabled = false;
                lb_BuchZustand.Text = "nicht verfügbar";
                lb_BuchStatus.Enabled = false;
                lb_BuchStatus.ForeColor = Color.Black;
                lb_BuchStatus.Text = "nicht verfügbar";
                picBox_Buchcover.Image = null;
                dp_RueckDatum.Value = DateTime.Now.Date;
                tb_BuchCode.Focus();
            }
            else
            {
                llb_BuchTitel.Enabled = false;
                llb_BuchTitel.Text = "keine Treffer";
                kunde.FillGrid(ref gv_Kunde);
                lb_BuchZustand.Enabled = false;
                lb_BuchZustand.Text = "nicht verfügbar";
                lb_BuchStatus.Enabled = false;
                lb_BuchStatus.ForeColor = Color.Black;
                lb_BuchStatus.Text = "nicht verfügbar";
                picBox_Buchcover.Image = null;
                dp_RueckDatum.Value = DateTime.Now.Date;
                tb_BuchCode.Focus();
            }
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
                try
                {
                    Exemplar buch_exemplar = new Exemplar(tb_BuchCode.Text);
                    if (buch_exemplar.IsActivated())
                    {
                        ausleihe.ExemplarID = buch_exemplar.ExemplarID;
                        if (ausleihe.CheckLeihList())
                        {
                            ausleihe.Rueckgabedatum = Convert.ToDateTime(ausleihe.LeihListe.Rows[ausleihe.GetIndexInLeihliste()][1]);
                            bt_AddBuch.Text = "-";
                        }
                        else
                        {
                            ausleihe.Rueckgabedatum = DateTime.Now.Date;
                            bt_AddBuch.Text = "+";
                        }
                        ausleihe.Verfuegbar = buch_exemplar.IsSpecificAvailable();
                        llb_BuchTitel.Enabled = true;
                        llb_BuchTitel.Text = ausleihe.TrimText(buch_exemplar.Titel, 30);
                        lb_BuchZustand.Enabled = true;
                        lb_BuchZustand.Text = buch_exemplar.Zustand.Zustandname;
                        lb_BuchStatus.Enabled = true;
                        if (ausleihe.Verfuegbar)
                        {
                            lb_BuchStatus.Text = "verfügbar";
                            lb_BuchStatus.ForeColor = Color.Green;
                            ausleihe.KID = null;
                        }
                        else
                        {
                            lb_BuchStatus.Text = "nicht verfügbar (verliehen)";
                            lb_BuchStatus.ForeColor = Color.Red;
                        }
                        ausleihe.ShowBuchCover(ref picBox_Buchcover);
                        #region Buchcover anzeigen
                        //Buch buchCover = new Buch(buch_exemplar.ISBN);
                        //if (buchCover.Image != null)
                        //{
                        //    try
                        //    {
                        //        MemoryStream mem = new MemoryStream(buchCover.Image);
                        //        picBox_Buchcover.Image = Image.FromStream(mem);
                        //        //string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bibliothek\\Bilder\\" + buch.ISBN + ".png";
                        //        //if (!File.Exists(filePath))
                        //        //{
                        //        //    picBox_Buchcover.Image.Save(filePath, ImageFormat.Png);
                        //        //    picBox_Buchcover.ImageLocation = filePath;
                        //        //}
                        //        //else
                        //        //{
                        //        //    Delete_picture(filePath);
                        //        //    picBox_Buchcover.Image.Save(filePath, ImageFormat.Png);
                        //        //    picBox_Buchcover.ImageLocation = filePath;
                        //        //}
                        //    }
                        //    catch
                        //    {
                        //    }
                        //}
                        //else
                        //{
                        //    //if (!buch.BildPfad.Equals(""))
                        //    //{
                        //    //    try
                        //    //    {
                        //    //        picBox_Buchcover.ImageLocation = buch.BildPfad;
                        //    //    }
                        //    //    catch
                        //    //    {
                        //    //        MetroMessageBox.Show(this,"Das Buchcover wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    //    }
                        //    //}
                        //    //else
                        //    //{
                        //    picBox_Buchcover.Image = null;
                        //    //picBox_Buchcover.ImageLocation = null;
                        //    //}
                        //}
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
        /// Führt die Buchausgabe aus
        /// </summary>
        private void Buchausgabe()
        {
            kunde = new Kunde(ausleihe.KID);
            DialogResult dialogResult = MetroMessageBox.Show(this, ausleihe.GetAusleihList() + "an: '" + ausleihe.TrimText(kunde.Vorname + " " + kunde.Nachname, 30) + "' wirklich ausleihen?", "Achtung",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 211 + ausleihe.LeihListe.Rows.Count * 17);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    foreach (DataRow row in ausleihe.LeihListe.Rows)
                    {
                        ausleihe.Execute_Ausleihe(Convert.ToInt32(row[0].ToString()), DateTime.Now.Date.ToShortDateString(),dp_RueckDatum.Value.ToShortDateString(), Convert.ToInt32(kunde.KundenID));                    
                        //ausleihe.Save_Transaction(); In Bearbeitung!!!
                    }
                    MetroMessageBox.Show(this, "Die Buchausgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ausleihe.ClearLeihList();
                }
                catch
                {
                    MetroMessageBox.Show(this, "Die Buchausgabe konnte nicht abgeschlossen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ausleihe.SetSlider(ref leihList_Slider, ref tb_listVon, ref tb_listBis);
                tb_BuchCode.Text = "";
                tb_BuchCode.Focus();
            }
        }
        #endregion

        #region Componenten-Aktionen
        private void tb_BuchCode_TextChanged(object sender, EventArgs e)
        {
                ShowBuchResults();
        }

        private void bt_AddBuch_Click(object sender, EventArgs e)
        {
            if (llb_BuchTitel.Text != "keine Treffer")
            {
                if (tb_BuchCode.Text != "")
                {
                    if (ausleihe.Verfuegbar)
                    {
                        if (!ausleihe.CheckLeihList())
                        {
                            ausleihe.AddToAusleihList();
                            bt_AddBuch.Text = "-";
                        }
                        else
                        {
                            ausleihe.RemoveFromAusleihList();
                            bt_AddBuch.Text = "+";
                            //if (ausleihe.LeihListe.Rows.Count > 0)
                            //{
                            //    tb_BuchCode.Text = ausleihe.LeihListe.Rows[leihList_Slider.Value - 1][0].ToString();
                            //}
                            //else
                            //{
                            //    tb_BuchCode.Text = "";
                            //}
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    ausleihe.SetSlider(ref leihList_Slider, ref tb_listVon, ref tb_listBis);
                    tb_BuchCode.Focus();
                    tb_BuchCode.SelectAll();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Der eingegebene Buchcode ist nicht vorhanden! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void leihList_Slider_Scroll(object sender, ScrollEventArgs e)
        {
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
            tb_BuchCode.Text = ausleihe.LeihListe.Rows[leihList_Slider.Value - 1][0].ToString();
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }

        private void bt_NeuKunde_Click(object sender, EventArgs e)
        {
            Form Kunden = new w_s_Kunden(currentUser);
            Kunden.ShowDialog(this);
            kunde.FillGrid(ref gv_Kunde);
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            if (llb_BuchTitel.Text != "keine Treffer")
            {
                if (gv_Kunde.CurrentRow != null)
                {
                    ausleihe.KID = gv_Kunde.CurrentRow.Cells["Kunden-ID"].Value.ToString();
                    if (ausleihe.LeihListe.Rows.Count == 0)
                    {
                        if (ausleihe.Verfuegbar)
                        {
                            ausleihe.AddToAusleihList();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (ausleihe.LeihListe.Rows.Count != 0)
                    {
                        Buchausgabe();                   
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Bitte wählen Sie einen Kunden aus!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Der eingegebene Buchcode ist nicht vorhanden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_BuchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!new Benutzer(currentUser).Rechteid.Equals("0"))
            {
                if (e.KeyChar == (char)13)
                {
                    ShowBuchResults();
                    if (llb_BuchTitel.Text.Equals("keine Treffer"))
                    {
                        MetroMessageBox.Show(this, "Der eingegebene Buchcode ist nicht vorhanden! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (tb_BuchCode.Text != "")
                        {
                            if (ausleihe.Verfuegbar)
                            {
                                if (!ausleihe.CheckLeihList())
                                {
                                    ausleihe.AddToAusleihList();
                                    bt_AddBuch.Text = "-";
                                }
                                else
                                {
                                    ausleihe.RemoveFromAusleihList();
                                    bt_AddBuch.Text = "+";
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            ausleihe.SetSlider(ref leihList_Slider, ref tb_listVon, ref tb_listBis);
                            tb_BuchCode.Focus();
                            tb_BuchCode.SelectAll();
                        }
                    }
                }
            }
        }

        private void llb_BuchTitel_Click(object sender, EventArgs e)
        {
            Form Info = new w_s_information(1, ausleihe.ExemplarID, currentUser);
            Info.ShowDialog();
        }

        private void llb_gesListe_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, ausleihe.GetListInfo(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, (150 + ausleihe.LeihListe.Rows.Count * 15));
        }

        private void leihList_Slider_ValueChanged(object sender, EventArgs e)
        {
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
            if (ausleihe.LeihListe.Rows.Count > 0)
            {
                tb_BuchCode.Text = ausleihe.LeihListe.Rows[leihList_Slider.Value - 1][0].ToString();
            }
            else
            {
                tb_BuchCode.Text = "";
            }
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }

        private void tb_VName_TextChanged(object sender, EventArgs e)
        {
            SearchKunde(tb_VName.Text, tb_NName.Text);
        }

        private void tb_NName_TextChanged(object sender, EventArgs e)
        {
            SearchKunde(tb_VName.Text, tb_NName.Text);
        }    

        private void W_s_ausleihe_Shown(object sender, EventArgs e)
        {
            tb_BuchCode.Focus();
        }

        private void Tb_listBis_TextChanged(object sender, EventArgs e)
        {
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
            if (ausleihe.LeihListe.Rows.Count > 0)
            {
                tb_BuchCode.Text = ausleihe.LeihListe.Rows[leihList_Slider.Value - 1][0].ToString();
            }
            else
            {
                tb_BuchCode.Text = "";
            }
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }
        #endregion

        private void Gv_Kunde_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                bt_Submit.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void MetroToolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(e.ToolTipSize.Width + 32, e.ToolTipSize.Height);
        }
    }
}
