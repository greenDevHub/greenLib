using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_details : Form
    {
        #region Objekt Constructor
        /// <summary>
        /// Erschaft die Form
        /// </summary>
        public w_s_details()
        {
            InitializeComponent();
            details.FillGrid(ref gv_Details);
            b.AutorListe.Autor.FillCombobox(ref combo_Autor, -1);
            b.Verlag.FillCombobox(ref combo_Verlag, -1);
            b.Genre.FillCombobox(ref combo_Genre, -1);
            Kunden_Einblenden();
            Verfuegbarkeit_Einblenden();
        }
        #endregion

        Details details = new Details();
        Buch b = new Buch();

        #region Buchsuche
        private void Buch_Suchen()
        {
            Zeige_Alle_Rows();
            if (!tb_ID.Text.Equals(""))
            {

                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_ID.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Buch-ID")].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Selected = false;
                        cuma.ResumeBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }
            if (!tb_ISBN.Text.Equals(""))
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_ISBN.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "ISBN")].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Selected = false;
                        cuma.ResumeBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }
            if (!tb_s_Titel.Text.Equals(""))
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_s_Titel.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Titel")].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Selected = false;
                        cuma.ResumeBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (!combo_Autor.Text.Equals(""))
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = combo_Autor.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Autor")].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Selected = false;
                        cuma.ResumeBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (!combo_Genre.Text.Equals(""))
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = combo_Genre.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Genre")].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Selected = false;
                        cuma.ResumeBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (!combo_Verlag.Text.Equals(""))
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = combo_Verlag.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Verlag")].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Selected = false;
                        cuma.ResumeBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }
            if (!tb_vorname.Text.Equals(""))
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_vorname.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Vorname")].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Selected = false;
                        cuma.ResumeBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }
            if (!tb_nachname.Text.Equals(""))
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_nachname.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Nachname")].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Selected = false;
                        cuma.ResumeBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }
        }

        private void Zeige_Alle_Rows()
        {
            for (int i = 0; i < gv_Details.RowCount; i++)
            {
                gv_Details.Rows[i].Visible = true;
            }
        }

        private void Buchsuche_ausfuehren(object sender, EventArgs e)
        {
            Buch_Suchen();
        }

        

        private void bt_Clear_Click(object sender, EventArgs e)
        {
            tb_s_Titel.Text = "";
            combo_Autor.Text = "";
            combo_Genre.Text = "";
            combo_Verlag.Text = "";
            Buch_Suchen();
        }
        #endregion


        #region Gridview-Click
        //private void Grid_Buecher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0)
        //    {
        //        DataGridViewRow row = this.gv_Details.Rows[e.RowIndex];

        //        tb_BuchID.Text = row.Cells[0].Value.ToString();
        //        tb_Buch.Text = row.Cells[5].Value.ToString();
        //        tb_Kunde.Text = row.Cells[30].Value.ToString() + " " + row.Cells[31].Value.ToString();
        //        tb_KID.Text = row.Cells[29].Value.ToString();
        //        //Kunde k = new Kunde(tb_KundenID.Text);
        //        //tb_Vorname.Text = k.Vorname;
        //        //tb_Nachname.Text = k.Nachname;
        //        //tb_Strasse.Text = k.Strasse;
        //        //tb_Hausnummer.Text = k.Hausnummer;
        //        //tb_Postleitzahl.Text = k.Postleitzahl;
        //        //tb_Ort.Text = k.Ort;
        //        //tb_Klasse.Text = k.Klasse;
        //        //tb_Mail.Text = k.Mail;
        //        //tb_Telefonnummer.Text = k.Telefonnummer;
        //        //cb_Vertrauenswuerdigkeit.Text = k.Vertrauenswuerdigkeit;

        //    }
        //}
        #endregion

        //Robert fragen
        #region Ein- und Ausblenden von Verfügbarkeit und Kundeninformationen
        private void Verfuegbarkeit_Einblenden()
        {
            if (cb_Ferfügbark_Anz.Checked == true)
            {
                cb_KundeAnz.Checked = false;
                gv_Details.ClearSelection();

                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string vergleich = "";
                    string zustand = "beschädigt";

                    if (vergleich.Equals(gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Leihnummer")].Value.ToString()) == false | zustand.Equals(gv_Details.Rows[i].Cells[details.GetColumnIndexByName(gv_Details, "Zustand")].Value.ToString()) == true)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                        cuma.ResumeBinding();
                    }
                }
            }
            else
            {
                Buch_Suchen();
            }
        }

        private void Kunden_Einblenden()
        {
            if (cb_KundeAnz.Checked == true)
            {
                gv_Details.Columns[details.GetColumnIndexByName(gv_Details,"Vorname")].Visible = true;
                gv_Details.Columns[details.GetColumnIndexByName(gv_Details, "Nachname")].Visible = true;
                gv_Details.Columns[details.GetColumnIndexByName(gv_Details, "Klasse")].Visible = true;
                gv_Details.Columns[details.GetColumnIndexByName(gv_Details, "Kunden ID")].Visible = true;
                tb_nachname.Enabled = true;
                tb_vorname.Enabled = true;
                lb_vorname.Visible = true;
                lb_nachname.Visible = true;

            }
            else if (cb_KundeAnz.Checked == false)
            {
                gv_Details.Columns[details.GetColumnIndexByName(gv_Details, "Vorname")].Visible = false;
                gv_Details.Columns[details.GetColumnIndexByName(gv_Details, "Nachname")].Visible = false;
                gv_Details.Columns[details.GetColumnIndexByName(gv_Details, "Klasse")].Visible = false;
                gv_Details.Columns[details.GetColumnIndexByName(gv_Details, "Kunden ID")].Visible = false;
                tb_nachname.Enabled = false;
                tb_vorname.Enabled = false;
                lb_vorname.Visible = false;
                lb_nachname.Visible = false;
            }
        }

        private void cb_KundeAnz_CheckedChanged(object sender, EventArgs e)
        {
            Kunden_Einblenden();
        }

        private void cb_Ferfügbark_Anz_CheckedChanged(object sender, EventArgs e)
        {
            Verfuegbarkeit_Einblenden();
        }
        #endregion 
        //Robert fragen

        #region Buch ausleihen
        private void Ausleihvorgang(object sender, EventArgs e)
        {
            if (gv_Details.SelectedRows.Count > 0)
            {
                tb_BuchIDAusleihen.Text = "";
                tb_KundenIDAusleihen.Text = "";
                tb_BuchAusleihen.Text = "";
                tb_KundeAusleihen.Text = "";
                tb_ZustandAusleihen.Text = "";
                tb_verleihfaehigAusleihen.Text = "";
                dateTimePickerAusleihen.ResetText();
                bt_Abschliessen.Enabled = false;
                bt_Ausleihen.Enabled = false;
                bt_AbbrechenAusleihen.Enabled = true;

                int row_index = this.gv_Details.CurrentRow.Index;
                if (row_index >= 0 && row_index <= this.gv_Details.RowCount)
                {
                    DataGridViewRow row = this.gv_Details.CurrentRow;
                    if(row.Cells[details.GetColumnIndexByName(gv_Details, "Leihnummer")].Value.ToString().Equals("") || row.Cells[details.GetColumnIndexByName(gv_Details, "Leihnummer")].Value.ToString() == null)
                    {
                        try
                        {
                            string buch_id = row.Cells[details.GetColumnIndexByName(gv_Details, "Buch-ID")].Value.ToString();
                            string buch_titel = row.Cells[details.GetColumnIndexByName(gv_Details, "Titel")].Value.ToString();
                            string buch_zustand = row.Cells[details.GetColumnIndexByName(gv_Details, "Zustand")].Value.ToString();

                            using (var kunden = new w_s_Aus_Kunde())
                            {
                                var result = kunden.ShowDialog();
                                if (result == DialogResult.OK)
                                {
                                    string k_id = kunden.KundenID;
                                    string k_vmane = kunden.KundenVName;
                                    string k_nname = kunden.KundenNName;

                                    this.tb_KundeAusleihen.Text = k_vmane + " " + k_nname;
                                    this.tb_KundenIDAusleihen.Text = k_id;
                                    tb_BuchIDAusleihen.Text = buch_id;
                                    tb_BuchAusleihen.Text = buch_titel;
                                    tb_ZustandAusleihen.Text = buch_zustand;
                                    bt_Abschliessen.Enabled = true;
                                    string date = DateTime.Now.ToShortDateString();
                                    Barcode bar = new Barcode(tb_BuchIDAusleihen.Text, tb_KundenIDAusleihen.Text, date);
                                }
                                else
                                {
                                    Ausleihen_Abbrechen(true);
                                }
                            }
                        }
                        catch
                        {
                            tb_BuchIDAusleihen.Text = "";
                            tb_KundenIDAusleihen.Text = "";
                            tb_BuchAusleihen.Text = "";
                            tb_KundeAusleihen.Text = "";
                            tb_ZustandAusleihen.Text = "";
                            tb_verleihfaehigAusleihen.Text = "";
                            dateTimePickerAusleihen.ResetText();
                            bt_Abschliessen.Enabled = false;
                            MessageBox.Show("Der Auslehvorgang konnte nicht gestartet werden!", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dieses Buch wurde bereits ausgeliehen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Ausleihen_Abbrechen(false);
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Es wurde kein Buch ausgewählt!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Ausleihen_Bestaetigen(object sender, EventArgs e)
        {
            //try
            //{
                int buch_id = Convert.ToInt32(tb_BuchIDAusleihen.Text);

                if (details.Pruefe_Ausgeliehen(tb_BuchIDAusleihen.Text) == false)
                {
                    string aus_datum = DateTime.Today.ToString();
                    string rück_datum = dateTimePickerAusleihen.Value.ToString();
                    int kunden_id = Convert.ToInt32(tb_KundenIDAusleihen.Text);

                    details.Ausleihen(buch_id, aus_datum, rück_datum, kunden_id);
                    //drucken

                    MessageBox.Show("Das Buch wurde erfolgreich an: '" + tb_KundeAusleihen.Text + "' ausgeliehen!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_BuchIDAusleihen.Text = "";
                    tb_KundenIDAusleihen.Text = "";
                    tb_BuchAusleihen.Text = "";
                    tb_KundeAusleihen.Text = "";
                    tb_ZustandAusleihen.Text = "";
                    tb_verleihfaehigAusleihen.Text = "";
                    dateTimePickerAusleihen.ResetText();
                    bt_Abschliessen.Enabled = false;
                    bt_Ausleihen.Enabled = true;
                    bt_AbbrechenAusleihen.Enabled = false;
                    details.FillGrid(ref gv_Details);
                }
                else
                {
                    MessageBox.Show("Das Buch wurde bereits ausgeliehen!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_BuchIDAusleihen.Text = "";
                    tb_KundenIDAusleihen.Text = "";
                    tb_BuchAusleihen.Text = "";
                    tb_KundeAusleihen.Text = "";
                    tb_ZustandAusleihen.Text = "";
                    tb_verleihfaehigAusleihen.Text = "";
                    dateTimePickerAusleihen.ResetText();
                    bt_Abschliessen.Enabled = false;
                    bt_Ausleihen.Enabled = true;
                    bt_AbbrechenAusleihen.Enabled = false;
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Das Buch konnte nicht ausgeliehen werden!", "Error",
            //               MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        #endregion

        #region Buch-Rückgabe
        private void bt_Rueckgabe_Click(object sender, EventArgs e)
        {
            Form Rueckgabe = new w_s_rueckgabe();
            Rueckgabe.ShowDialog(this);
            //if (tb_BuchIDAusleihen.Text != "") //&& gv_Details.CurrentRow.Cells[29].Value.ToString() != ""
            //{
            //    int row_index = gv_Details.CurrentRow.Index;
            //    if (row_index >= 0 && row_index <= gv_Details.RowCount)
            //    {
            //        DataGridViewRow row = this.gv_Details.CurrentRow;
            //        if (!row.Cells[details.GetColumnIndexByName(gv_Details, "Leihnummer")].Value.ToString().Equals("") && row.Cells[details.GetColumnIndexByName(gv_Details, "Leihnummer")].Value.ToString() != null)
            //        {
            //            string buch_titel = row.Cells[details.GetColumnIndexByName(gv_Details, "Titel")].Value.ToString();
            //            string kunde = row.Cells[details.GetColumnIndexByName(gv_Details, "Vorname")].Value.ToString() + " " + row.Cells[details.GetColumnIndexByName(gv_Details, "Nachname")].Value.ToString();

            //            DialogResult dialogResult = MessageBox.Show("Möchten Sie das Buch: '" + buch_titel
            //                + "', ausgeliehen von: '" + kunde + "' wirklich als zurückgegeben markieren?", "Achtung",
            //                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //            if (dialogResult == DialogResult.OK)
            //            {
            //                try
            //                {
            //                    details.Buch_Rueckgabe(tb_BuchIDAusleihen.Text);
            //                    details.FillGrid(ref gv_Details);
            //                    MessageBox.Show("Das Buch wurde erfolgreich zurückgeben!", "Information",
            //                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //                }
            //                catch
            //                {
            //                    MessageBox.Show("Es ist ein Fehler aufgetreten. Das Buch konnte nicht zurückgeben werden!", "Fehler",
            //                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                }
            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show("Dieses Buch wurde an niemanden ausgeliehen. Deshalb kann es nicht zurückgegeben werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }

                    
            //    }
            //}
            //else
            //{
            //    if(gv_Details.CurrentRow != null)
            //    {
            //        string buch_id = gv_Details.CurrentRow.Cells[details.GetColumnIndexByName(gv_Details,"Buch-ID")].Value.ToString();
            //        tb_BuchIDAusleihen.Text = buch_id;
            //        bt_Rueckgabe_Click(bt_Rueckgabe, e);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Es wurde kein Buch ausgewählt!", "Error",
            //                MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    //MessageBox.Show("Wählen Sie ein Buch zur Rückgabe aus!", "Information",
            //    //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        #endregion

        private void Ausleihen_Abbrechen(bool a)
        {
            tb_BuchIDAusleihen.Text = "";
            tb_KundenIDAusleihen.Text = "";
            tb_BuchAusleihen.Text = "";
            tb_KundeAusleihen.Text = "";
            tb_ZustandAusleihen.Text = "";
            tb_verleihfaehigAusleihen.Text = "";
            dateTimePickerAusleihen.ResetText();
            bt_Abschliessen.Enabled = false;
            bt_Ausleihen.Enabled = true;
            bt_AbbrechenAusleihen.Enabled = false;
            if (a)
            {
                MessageBox.Show("Der Ausleihvorgang wurde abbgebrochen!", "Information",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_AbbrechenAusleihen_Click(object sender, EventArgs e)
        {
            Ausleihen_Abbrechen(true);
        }

        private void tb_ZustandAusleihen_TextChanged(object sender, EventArgs e)
        {
            if (tb_ZustandAusleihen.Text.Equals("beschädigt"))
            {
                tb_verleihfaehigAusleihen.Text = "Nein (nicht Verleihfähig)";
            }
            else if (tb_ZustandAusleihen.Text.Equals(""))
            {
                tb_verleihfaehigAusleihen.Text = "";
            }
            else
            {
                tb_verleihfaehigAusleihen.Text = "Ja (verleihfähig)";
            }
        }

        private void tb_nachname_TextChanged(object sender, EventArgs e)
        {
            Buch_Suchen();
        }
        private void tb_vorname_TextChanged(object sender, EventArgs e)
        {
            Buch_Suchen();
        }

        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {
            Buch_Suchen();
        }

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



        #region Events yeaaah
        private void tb_ID_TextChanged(object sender, EventArgs e)
        {
            if(tb_ID.Text.Length == 8)
            {
                string seven = tb_ID.Text.Substring(0, 7);
                string eight = tb_ID.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tb_ID.Text = int.Parse(seven).ToString();
                }
            }
            if (!tb_ID.Text.Equals(""))
            {
                try
                {

                    tb_ID.Text = int.Parse(tb_ID.Text).ToString();
                }
                catch
                {
                    tb_ID.Text = "";
                }
            }
            Buch_Suchen();
        }
        private void tb_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void tb_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }
        private void lb_id_Click(object sender, EventArgs e)
        {
            tb_ID.Focus();
            lb_id.Visible = false;
        }

        private void lb_isbn_Click(object sender, EventArgs e)
        {
            tb_ISBN.Focus();
            lb_isbn.Visible = false;
        }

        private void tb_ID_Click(object sender, EventArgs e)
        {
            lb_id.Visible = false;
        }

        private void tb_ISBN_Click(object sender, EventArgs e)
        {
            lb_isbn.Visible = false;
        }

        private void tb_ID_Leave(object sender, EventArgs e)
        {
            if (tb_ID.Text.Equals(""))
            {
                lb_id.Visible = true;
            }
        }

        private void tb_ISBN_Leave(object sender, EventArgs e)
        {
            if (tb_ISBN.Text.Equals(""))
            {
                lb_isbn.Visible = true;
            }
        }

        private void lb_titel_Click(object sender, EventArgs e)
        {
            tb_s_Titel.Focus();
            lb_titel.Visible = false;
        }

        private void lb_autor_Click(object sender, EventArgs e)
        {
            combo_Autor.Focus();
            lb_autor.Visible = false;
        }

        private void lb_verlag_Click(object sender, EventArgs e)
        {
            combo_Verlag.Focus();
            lb_verlag.Visible = false;
        }

        private void lb_Genre_Click(object sender, EventArgs e)
        {
            combo_Genre.Focus();
            lb_Genre.Visible = false;
        }

        private void lb_vorname_Click(object sender, EventArgs e)
        {
            tb_vorname.Focus();
            lb_vorname.Visible = false;
        }

        private void lb_nachname_Click(object sender, EventArgs e)
        {
            tb_nachname.Focus();
            lb_nachname.Visible = false;
        }

        private void tb_s_Titel_Click(object sender, EventArgs e)
        {
            lb_titel.Visible = false;
        }

        private void combo_Autor_Click(object sender, EventArgs e)
        {
            lb_autor.Visible = false;
        }

        private void combo_Verlag_Click(object sender, EventArgs e)
        {
            lb_verlag.Visible = false;
        }

        private void combo_Genre_Click(object sender, EventArgs e)
        {
            lb_Genre.Visible = false;
        }

        private void tb_vorname_Click(object sender, EventArgs e)
        {
            lb_vorname.Visible = false;
        }

        private void tb_nachname_Click(object sender, EventArgs e)
        {
            lb_nachname.Visible = false;
        }

        private void tb_s_Titel_Leave(object sender, EventArgs e)
        {
            if (tb_s_Titel.Text.Equals(""))
            {
                lb_titel.Visible = true;
            }
        }

        private void combo_Autor_Leave(object sender, EventArgs e)
        {
            if (combo_Autor.Text.Equals(""))
            {
                lb_autor.Visible = true;
            }
        }

        private void combo_Verlag_Leave(object sender, EventArgs e)
        {
            if (combo_Verlag.Text.Equals(""))
            {
                lb_verlag.Visible = true;
            }
        }

        private void combo_Genre_Leave(object sender, EventArgs e)
        {
            if (combo_Genre.Text.Equals(""))
            {
                lb_Genre.Visible = true;
            }
        }

        private void tb_vorname_Leave(object sender, EventArgs e)
        {
            if (tb_vorname.Text.Equals(""))
            {
                lb_vorname.Visible = true;
            }
        }

        private void tb_nachname_Leave(object sender, EventArgs e)
        {
            if (tb_nachname.Text.Equals(""))
            {
                lb_nachname.Visible = true;
            }
        }
        #endregion
    }
}
