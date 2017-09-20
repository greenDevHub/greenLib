using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_details : Form
    {
        public w_s_details()
        {
            InitializeComponent();
            b.FillGrid(ref gv_Details);
            b.Autor.FillCombobox(ref combo_Autor, -1);
            b.Verlag.FillCombobox(ref combo_Verlag, -1);
            b.Genre.FillCombobox(ref combo_Genre, -1);
            Kunden_Einblenden();
            V_Einblenden();
        }

        Details details = new Details();
        Buch b = new Buch();

        #region Buchsuche
        private void Buch_Suchen()
        {
            Zeige_Alle_Rows();

            if (cb_s_Titel.Checked == true)
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = tb_s_Titel.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[5].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (cb_s_Autor.Checked == true)
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = combo_Autor.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[16].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (cb_s_Genre.Checked == true)
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = combo_Genre.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[14].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
                    }
                }
            }

            if (cb_s_Verlag.Checked == true)
            {
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string suche = combo_Verlag.Text;
                    string ergebnis = gv_Details.Rows[i].Cells[18].Value.ToString();
                    if (ergebnis.Contains(suche) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
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

        private void cb_s_Titel_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_s_Titel.Checked == true)
            {
                tb_s_Titel.Enabled = true;
            }
            else
            {
                tb_s_Titel.Enabled = false;
            }
        }

        private void cb_s_Autor_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_s_Autor.Checked == true)
            {
                combo_Autor.Enabled = true;
            }
            else
            {
                combo_Autor.Enabled = false;
            }
        }

        private void cb_s_Genre_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_s_Genre.Checked == true)
            {
                combo_Genre.Enabled = true;
            }
            else
            {
                combo_Genre.Enabled = false;
            }
        }

        private void cb_s_Verlag_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_s_Verlag.Checked == true)
            {
                combo_Verlag.Enabled = true;
            }
            else
            {
                combo_Verlag.Enabled = false;
            }
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
        private void Grid_Buecher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Details.Rows[e.RowIndex];

                tb_BuchID.Text = row.Cells[0].Value.ToString();
                tb_Buch.Text = row.Cells[5].Value.ToString();
                tb_Kunde.Text = row.Cells[30].Value.ToString() + " " + row.Cells[31].Value.ToString();
                tb_KID.Text = row.Cells[29].Value.ToString();
                //Kunde k = new Kunde(tb_KundenID.Text);
                //tb_Vorname.Text = k.Vorname;
                //tb_Nachname.Text = k.Nachname;
                //tb_Strasse.Text = k.Strasse;
                //tb_Hausnummer.Text = k.Hausnummer;
                //tb_Postleitzahl.Text = k.Postleitzahl;
                //tb_Ort.Text = k.Ort;
                //tb_Klasse.Text = k.Klasse;
                //tb_Mail.Text = k.Mail;
                //tb_Telefonnummer.Text = k.Telefonnummer;
                //cb_Vertrauenswuerdigkeit.Text = k.Vertrauenswuerdigkeit;

            }
        }
        #endregion

        #region Ein- und Ausblenden von Verfügbarkeit und Kundeninformationen
        private void V_Einblenden()
        {
            if (cb_Ferfügbark_Anz.Checked == true)
            {
                cb_KundeAnz.Checked = false;
                for (int i = 0; i < gv_Details.RowCount; i++)
                {
                    string vergleich = "";
                    if (vergleich.Equals(gv_Details.Rows[i].Cells[24].Value.ToString()) == false)
                    {
                        CurrencyManager cuma = (CurrencyManager)gv_Details.BindingContext[gv_Details.DataSource];
                        cuma.SuspendBinding();
                        gv_Details.Rows[i].Visible = false;
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
                gv_Details.Columns[29].Visible = true;
                gv_Details.Columns[30].Visible = true;
                gv_Details.Columns[31].Visible = true;
                gv_Details.Columns[32].Visible = true;
                gv_Details.Columns[33].Visible = true;
                gv_Details.Columns[34].Visible = true;
                gv_Details.Columns[35].Visible = true;
                gv_Details.Columns[36].Visible = true;
                gv_Details.Columns[37].Visible = true;
                gv_Details.Columns[38].Visible = true;
                gv_Details.Columns[39].Visible = true;
            }
            else if (cb_KundeAnz.Checked == false)
            {
                gv_Details.Columns[29].Visible = false;
                gv_Details.Columns[30].Visible = false;
                gv_Details.Columns[31].Visible = false;
                gv_Details.Columns[32].Visible = false;
                gv_Details.Columns[33].Visible = false;
                gv_Details.Columns[34].Visible = false;
                gv_Details.Columns[35].Visible = false;
                gv_Details.Columns[36].Visible = false;
                gv_Details.Columns[37].Visible = false;
                gv_Details.Columns[38].Visible = false;
                gv_Details.Columns[39].Visible = false;
            }
        }

        private void cb_KundeAnz_CheckedChanged(object sender, EventArgs e)
        {
            Kunden_Einblenden();
        }

        private void cb_Ferfügbark_Anz_CheckedChanged(object sender, EventArgs e)
        {
            V_Einblenden();
        }
        #endregion

        #region Buch ausleihen
        private void Ausleihvorgang(object sender, EventArgs e)
        {
            tb_BuchID.Text = "";
            tb_KID.Text = "";
            tb_Buch.Text = "";
            tb_Kunde.Text = "";
            tb_Zustand.Text = "";
            tb_verleihfaehig.Text = "";
            dateTimePickerAusleihen.ResetText();
            bt_Abschliessen.Enabled = false;

            int row_index = gv_Details.CurrentRow.Index;
            if (row_index >= 0 && row_index <= gv_Details.RowCount)
            {
                DataGridViewRow row = this.gv_Details.CurrentRow;
                try
                {
                    string buch_id = row.Cells[0].Value.ToString();
                    string buch_titel = row.Cells[5].Value.ToString();
                    string buch_verleihfaehig = row.Cells[21].Value.ToString();
                    string buch_zustand = row.Cells[22].Value.ToString();

                    using (var kunden = new w_s_Aus_Kunde())
                    {
                        var result = kunden.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            string k_id = kunden.KundenID;
                            string k_vmane = kunden.KundenVName;
                            string k_nname = kunden.KundenNName;

                            this.tb_Kunde.Text = k_vmane + " " + k_nname;
                            this.tb_KID.Text = k_id;
                        }
                    }
                    tb_BuchID.Text = buch_id;
                    tb_Buch.Text = buch_titel;
                    tb_verleihfaehig.Text = buch_verleihfaehig;
                    tb_Zustand.Text = buch_zustand;
                    bt_Abschliessen.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Der Auslehvorgang konnte nicht gestartet werden!", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Ausleihen_Bestaetigen(object sender, EventArgs e)
        {
            if (tb_BuchID.Text != "" && tb_Kunde.Text != "")
            {
                try
                {
                    int buch_id = Convert.ToInt32(tb_BuchID.Text);

                    if (b.Pruefe_Ausgeliehen(buch_id.ToString()) == false)
                    {
                        string aus_datum = DateTime.Today.ToString();
                        string rück_datum = dateTimePickerAusleihen.Value.ToString();
                        int kunden_id = Convert.ToInt32(tb_KID.Text);

                        b.Ausleihen(buch_id, aus_datum, rück_datum, kunden_id);
                        MessageBox.Show("Das Buch wurde erfolgreich an: '"+tb_Kunde.Text+"' ausgeliehen!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_BuchID.Text = "";
                        tb_KID.Text = "";
                        tb_Buch.Text = "";
                        tb_Kunde.Text = "";
                        tb_Zustand.Text = "";
                        tb_verleihfaehig.Text = "";
                        dateTimePickerAusleihen.ResetText();
                        bt_Abschliessen.Enabled = false;   
                    }
                    else
                    {
                        MessageBox.Show("Das Buch wurde bereits ausgeliehen!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception w)
                {
                    MessageBox.Show("Das Buch konnte nicht ausgeliehen werden! " + w, "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Es wurde kein Buch bzw. Kunde ausgewählt!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Buch-Rückgabe
        private void bt_Rueckgabe_Click(object sender, EventArgs e)
        {
            if (tb_BuchID.Text != "") //&& gv_Details.CurrentRow.Cells[29].Value.ToString() != ""
            {
                int row_index = gv_Details.CurrentRow.Index;
                if (row_index >= 0 && row_index <= gv_Details.RowCount)
                {
                    DataGridViewRow row = this.gv_Details.CurrentRow;

                    string buch_titel = row.Cells[5].Value.ToString();
                    string kunde = row.Cells[30].Value.ToString() + " " + row.Cells[31].Value.ToString();

                    DialogResult dialogResult = MessageBox.Show("Möchten Sie das Buch: '" + buch_titel
                        + "', ausgeliehen von: '" + kunde + "' wirklich als zurückgegeben markieren?", "Achtung",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.OK)
                    {
                        try
                        {
                            b.Buch_Rueckgabe(tb_BuchID.Text);
                            MessageBox.Show("Das Buch wurde erfolgreich zurückgeben!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Es ist ein Fehler aufgetreten. Das Buch konnte nicht zurückgeben werden!", "Fehler",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                string buch_id = gv_Details.CurrentRow.Cells[0].Value.ToString();
                tb_BuchID.Text = buch_id;
                bt_Rueckgabe_Click(bt_Rueckgabe, e);
                //MessageBox.Show("Wählen Sie ein Buch zur Rückgabe aus!", "Information",
                //    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
