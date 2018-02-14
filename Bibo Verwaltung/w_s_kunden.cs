using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_Kunden : Form
    {
        Kunde kunde = new Kunde();

        public w_s_Kunden()
        {
            InitializeComponent();
            kunde.FillGrid(ref Grid_Kunde);
        }

        //Sinnlos
        #region Fill Combobox
        //public void FillCombobox(ref ComboBox cb, object value)
        //{
        //    SqlConnection con = new SqlConnection();
        //    con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
        //    string strSQL = "SELECT * FROM t_s_kunden WHERE kunde_id = @k_id";

        //    SqlCommand cmd = new SqlCommand(strSQL, con);
        //    cmd.Parameters.AddWithValue("@k_id", tb_KundenID);
        //    con.Open();
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    cb.ValueMember = dr["kunde_vertrauenswürdigkeit"].ToString();
        //    cb.DisplayMember = dr["kunde_vertrauenswürdigkeit"].ToString();
        //    cb.SelectedValue = dr["kunde_vertrauenswürdigkeit"].ToString();
        //}
        #endregion

        #region Save Kunde (Methoden: setKundenValues(), bt_confirm_click())
        private void setKundenValues()
        {
            kunde.KundenID = tb_KundenID.Text;
            kunde.Vorname = tb_Vorname.Text;
            kunde.Nachname = tb_Nachname.Text;
            kunde.Strasse = tb_Strasse.Text;
            kunde.Hausnummer = tb_Hausnummer.Text;
            kunde.Postleitzahl = tb_Postleitzahl.Text;
            kunde.Ort = tb_Ort.Text;
            kunde.Vertrauenswuerdigkeit = cb_Vertrauenswuerdigkeit.Text;
            kunde.Klasse = tb_Klasse.Text;
            kunde.Mail = tb_Mail.Text;
            kunde.Telefonnummer = tb_Telefonnummer.Text;
        }

        private void bt_confirm_click(object sender, EventArgs e)
        {
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                lb_kunde_add.Hide();
                t.Stop();
            };

            if (rb_KundeBearbeiten.Checked)
            {
                if (!tb_Vorname.Text.Equals("")
                && !tb_Nachname.Text.Equals("")
                && !tb_Strasse.Text.Equals("")
                && !tb_Hausnummer.Text.Equals("")
                && !tb_Postleitzahl.Text.Equals("")
                && !tb_Ort.Text.Equals("")
                && !cb_Vertrauenswuerdigkeit.Text.Equals(""))
                {
                    try
                    {
                        setKundenValues();
                        kunde.saveKunde();
                        clearForm();
                        kunde.FillGrid(ref Grid_Kunde);
                        lb_kunde_add.Visible = false;
                        lb_kunde_add.Text = "Der Kunde wurde bearbeitet!";
                        lb_kunde_add.Visible = true;
                        t.Start();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Der Kunde konnte nicht gespeichert werden!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Füllen Sie die markierten Felder aus, um einen Kunden zu speichern!", "Achtung",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    setBackground_Red();
                }
            }

            if (rb_KundeLoeschen.Checked)
            {
                if (!tb_KundenID.Text.Equals(""))
                {
                    try
                    {
                        setKundenValues();
                        kunde.deleteKunde();
                        clearForm();
                        kunde.FillGrid(ref Grid_Kunde);
                        lb_kunde_add.Visible = false;
                        lb_kunde_add.Text = "Der Kunde wurde gelöscht!";
                        lb_kunde_add.Visible = true;
                        t.Start();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Der Kunde konnte nicht gelöscht werden!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Füllen Sie das markierte Felder aus, um einen Kunden zu löschen!", "Achtung",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (tb_KundenID.Text.Equals(""))
                    {
                        tb_KundenID.BackColor = Color.Red;
                    }
                    else
                    {
                        tb_KundenID.BackColor = Color.White;
                    }
                }
            }

            if (rb_Neukunde.Checked)
            {
                if (!tb_Vorname.Text.Equals("")
                && !tb_Nachname.Text.Equals("")
                && !tb_Strasse.Text.Equals("")
                && !tb_Hausnummer.Text.Equals("")
                && !tb_Postleitzahl.Text.Equals("")
                && !tb_Ort.Text.Equals("")
                && !cb_Vertrauenswuerdigkeit.Text.Equals(""))
                {
                    try
                    {
                        setKundenValues();
                        kunde.addKunde();
                        clearForm();
                        kunde.FillGrid(ref Grid_Kunde);
                        lb_kunde_add.Visible = false;
                        lb_kunde_add.Text = "Der Kunde wurde hinzugefügt!";
                        lb_kunde_add.Visible = true;
                        t.Start();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Der Kunde konnte nicht hinzugefügt werden!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Füllen Sie alle Felder aus, um einen neuen Kunden hinzuzufügen!", "Achtung",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    setBackground_Red();
                }
            }
        }
        #endregion

        #region Clear Kunde (Methoden: bt_clear_Click(), clearForm(), setBackground_White())
        private void bt_clear_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            lb_kunde_add.Visible = false;
            tb_Vorname.Text = "";
            tb_Nachname.Text = "";
            tb_Strasse.Text = "";
            tb_Hausnummer.Text = "";
            tb_Postleitzahl.Text = "";
            tb_Ort.Text = "";
            tb_Klasse.Text = "";
            tb_Mail.Text = "";
            tb_Telefonnummer.Text = "";
            cb_Vertrauenswuerdigkeit.Text = "";
            tb_KundenID.Text = "";
            setBackground_White();
        }

        private void setBackground_White()
        {
            tb_Vorname.BackColor = Color.White;
            tb_Nachname.BackColor = Color.White;
            tb_KundenID.BackColor = Color.White;
            tb_Hausnummer.BackColor = Color.White;
            tb_Strasse.BackColor = Color.White;
            tb_Postleitzahl.BackColor = Color.White;
            tb_Ort.BackColor = Color.White;
            tb_Klasse.BackColor = Color.White;
            tb_Mail.BackColor = Color.White;
            tb_Telefonnummer.BackColor = Color.White;
            cb_Vertrauenswuerdigkeit.BackColor = Color.White;
        }
        #endregion

        #region Modus setzen (Methoden: setModus(), rb_CheckedChanged(), w_s_kunden_Activated())
        private void setModus()
        {
            if (rb_KundeBearbeiten.Checked)
            {
                bt_confirm.Enabled = true;
                bt_confirm.Text = "Speichern";
                tb_KundenID.Enabled = false;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                cb_Vertrauenswuerdigkeit.Enabled = true;
                tb_Klasse.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Telefonnummer.Enabled = true;
                lb_KundenID.Text = "Kunden-ID:*";
                lb_Vorname.Text = "Vorname:*";
                lb_Nachname.Text = "Nachname:*";
                lb_Strasse.Text = "Strasse:*";
                lb_Hausnummer.Text = "Hausnummer:*";
                lb_Ort.Text = "Wohnort:*";
                lb_Postleitzahl.Text = "Postleitzahl:*";
                lb_Vertrauenswuerdigkeit.Text = "Vertrauenswürdigkeit:*";
            }
            else if (rb_Neukunde.Checked)
            {
                bt_confirm.Text = "Hinzufügen";
                bt_confirm.Enabled = true;
                tb_KundenID.Enabled = false;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                cb_Vertrauenswuerdigkeit.Enabled = true;
                tb_Klasse.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Telefonnummer.Enabled = true;
                lb_KundenID.Text = "Kunden-ID:";
                lb_Vorname.Text = "Vorname:*";
                lb_Nachname.Text = "Nachname:*";
                lb_Strasse.Text = "Strasse:*";
                lb_Hausnummer.Text = "Hausnummer:*";
                lb_Ort.Text = "Wohnort:*";
                lb_Postleitzahl.Text = "Postleitzahl:*";
                lb_Vertrauenswuerdigkeit.Text = "Vertrauenswürdigkeit:*";
            }
            else if (rb_KundeLoeschen.Checked)
            {
                bt_confirm.Enabled = true;
                bt_confirm.Text = "Löschen";
                tb_KundenID.Enabled = true;
                tb_Vorname.Enabled = false;
                tb_Nachname.Enabled = false;
                tb_Strasse.Enabled = false;
                tb_Hausnummer.Enabled = false;
                tb_Postleitzahl.Enabled = false;
                tb_Ort.Enabled = false;
                cb_Vertrauenswuerdigkeit.Enabled = false;
                tb_Klasse.Enabled = false;
                tb_Mail.Enabled = false;
                tb_Telefonnummer.Enabled = false;
                lb_KundenID.Text = "Kunden-ID:*";
                lb_Vorname.Text = "Vorname:";
                lb_Nachname.Text = "Nachname:";
                lb_Strasse.Text = "Strasse:";
                lb_Ort.Text = "Wohnort:";
                lb_Hausnummer.Text = "Hausnummer:";
                lb_Postleitzahl.Text = "Postleitzahl:";
                lb_Vertrauenswuerdigkeit.Text = "Vertrauenswürdigkeit:";
            }
        }

        private void rb_KundeBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            setModus();
            setBackground_White();
        }

        private void rb_KundeLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            setModus();
            setBackground_White();
        }

        private void rb_Neukunde_CheckedChanged(object sender, EventArgs e)
        {
            setModus();
            setBackground_White();
        }

        private void w_s_kunden_Activated(object sender, EventArgs e)
        {
            setModus();
        }
        #endregion

        #region Plichtfelder markieren (Methede: setBackground_Red())
        private void setBackground_Red()
        {
            if (tb_Vorname.Text.Equals(""))
            {
                tb_Vorname.BackColor = Color.Red;
            }
            else
            {
                tb_Vorname.BackColor = Color.White;
            }

            if (tb_Nachname.Text.Equals(""))
            {
                tb_Nachname.BackColor = Color.Red;
            }
            else
            {
                tb_Nachname.BackColor = Color.White;
            }

            if (tb_Strasse.Text.Equals(""))
            {
                tb_Strasse.BackColor = Color.Red;
            }
            else
            {
                tb_Strasse.BackColor = Color.White;
            }

            if (tb_Hausnummer.Text.Equals(""))
            {
                tb_Hausnummer.BackColor = Color.Red;
            }
            else
            {
                tb_Hausnummer.BackColor = Color.White;
            }

            if (tb_Postleitzahl.Text.Equals(""))
            {
                tb_Postleitzahl.BackColor = Color.Red;
            }
            else
            {
                tb_Postleitzahl.BackColor = Color.White;
            }

            if (tb_Ort.Text.Equals(""))
            {
                tb_Ort.BackColor = Color.Red;
            }
            else
            {
                tb_Ort.BackColor = Color.White;
            }

            if (cb_Vertrauenswuerdigkeit.Text.Equals(""))
            {
                cb_Vertrauenswuerdigkeit.BackColor = Color.Red;
            }
            else
            {
                cb_Vertrauenswuerdigkeit.BackColor = Color.White;
            }
        }
        #endregion

        #region Filter (Methode: kundenFilter())
        private void kundenFilter()
        {
            (Grid_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Vertrauenswürdigkeit LIKE '{6}%' AND Klasse LIKE '{7}%' AND Mail LIKE '{8}%' AND Telefonnummer LIKE '{9}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, cb_Vertrauenswuerdigkeit.Text, tb_Klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text);
        }
        #endregion

        #region Textbox_TextChanged
        private void tb_KundenID_TextChanged(object sender, EventArgs e)
        {
            tb_KundenID.BackColor = Color.White;
        }

        private void tb_Vorname_TextChanged(object sender, EventArgs e)
        {
            tb_Vorname.BackColor = Color.White;
            kundenFilter();
        }

        private void tb_Nachname_TextChanged(object sender, EventArgs e)
        {
            tb_Nachname.BackColor = Color.White;
            kundenFilter();
        }

        private void tb_Strasse_TextChanged(object sender, EventArgs e)
        {
            tb_Strasse.BackColor = Color.White;
            kundenFilter();
        }

        private void tb_Hausnummer_TextChanged(object sender, EventArgs e)
        {
            tb_Hausnummer.BackColor = Color.White;
            kundenFilter();
        }

        private void tb_Postleitzahl_TextChanged(object sender, EventArgs e)
        {
            tb_Postleitzahl.BackColor = Color.White;
            kundenFilter();
        }

        private void tb_Ort_TextChanged(object sender, EventArgs e)
        {
            tb_Ort.BackColor = Color.White;
            kundenFilter();
        }

        private void tb_Klasse_TextChanged(object sender, EventArgs e)
        {
            tb_Klasse.BackColor = Color.White;
            kundenFilter();
        }

        private void tb_Mail_TextChanged(object sender, EventArgs e)
        {
            tb_Mail.BackColor = Color.White;
            kundenFilter();
        }

        private void tb_Telefonnummer_TextChanged(object sender, EventArgs e)
        {
            tb_Telefonnummer.BackColor = Color.White;
            kundenFilter();
        }

        private void cb_Vertrauenswuerdigkeit_TextChanged_1(object sender, EventArgs e)
        {
            cb_Vertrauenswuerdigkeit.BackColor = Color.White;
            kundenFilter();
        }
        #endregion

        #region Auswahl_Grid_Kunde_CellDoubleClick
        private void Grid_Kunde_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_Kunde.Rows[e.RowIndex];
                rb_KundeBearbeiten.Checked = true;
                tb_KundenID.Text = row.Cells["Kunden-ID"].Value.ToString();
                Kunde clickedkunde = new Kunde(tb_KundenID.Text);
                tb_Vorname.Text = clickedkunde.Vorname;
                tb_Nachname.Text = clickedkunde.Nachname;
                tb_Strasse.Text = clickedkunde.Strasse;
                tb_Hausnummer.Text = clickedkunde.Hausnummer;
                tb_Postleitzahl.Text = clickedkunde.Postleitzahl;
                tb_Ort.Text = clickedkunde.Ort;
                tb_Klasse.Text = clickedkunde.Klasse;
                tb_Mail.Text = clickedkunde.Mail;
                tb_Telefonnummer.Text = clickedkunde.Telefonnummer;
                cb_Vertrauenswuerdigkeit.Text = clickedkunde.Vertrauenswuerdigkeit;
            }
        }
        #endregion

        #region Export/Import
        private void bt_Excel_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();
            export.ToExcel(Grid_Kunde);
        }

        private void bt_import_Click(object sender, EventArgs e)
        {
            Form Import = new w_s_importDialog();
            Import.ShowDialog(this);
        }
        #endregion
    }
}
