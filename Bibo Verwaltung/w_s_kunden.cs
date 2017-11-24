using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_Kunden : Form
    {
        Kunde k = new Kunde();

        public w_s_Kunden()
        {
            InitializeComponent();
            Kunde k = new Kunde();
            k.FillGrid(ref Grid_Kunde);
        }

        #region Fill Combobox
        public void FillCombobox(ref ComboBox cb, object value)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_kunden WHERE kunde_id = @k_id";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@k_id", tb_KundenID);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            cb.ValueMember = dr["kunde_vertrauenswürdigkeit"].ToString();
            cb.DisplayMember = dr["kunde_vertrauenswürdigkeit"].ToString();
            cb.SelectedValue = dr["kunde_vertrauenswürdigkeit"].ToString();
        }
        #endregion

        #region Save Kunde
        private void Save_Kunde(object sender, EventArgs e)
        {
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                lb_kunde_add.Hide();
                t.Stop();
            };

            if (rb_KundeBearbeiten.Checked
                && !tb_Vorname.Text.Equals("")
                && !tb_Nachname.Text.Equals("")
                && !tb_Strasse.Text.Equals("")
                && !tb_Hausnummer.Text.Equals("")
                && !tb_Postleitzahl.Text.Equals("")
                && !tb_Ort.Text.Equals("")
                && !cb_Vertrauenswuerdigkeit.Text.Equals(""))
            {
                try
                {
                    lb_kunde_add.Visible = false;
                    lb_kunde_add.Text = "Der Kunde wurde bearbeitet!";
                    k.KundenID = tb_KundenID.Text;
                    k.Vorname = tb_Vorname.Text;
                    k.Nachname = tb_Nachname.Text;
                    k.Strasse = tb_Strasse.Text;
                    k.Hausnummer = tb_Hausnummer.Text;
                    k.Postleitzahl = tb_Postleitzahl.Text;
                    k.Ort = tb_Ort.Text;
                    k.Vertrauenswuerdigkeit = cb_Vertrauenswuerdigkeit.Text;
                    k.Klasse = tb_Klasse.Text;
                    k.Mail = tb_Mail.Text;
                    k.Telefonnummer = tb_Telefonnummer.Text;
                    k.Save();
                    lb_kunde_add.Visible = true;
                    k.FillGrid(ref Grid_Kunde);
                    t.Start();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Kunde konnte nicht gespeichert werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_KundeLoeschen.Checked
                && !tb_KundenID.Text.Equals(""))
            {
                try
                {
                    lb_kunde_add.Visible = false;
                    lb_kunde_add.Text = "Der Kunde wurde gelöscht!";
                    k.KundenID = tb_KundenID.Text;
                    k.Vorname = tb_Vorname.Text;
                    k.Nachname = tb_Nachname.Text;
                    k.Strasse = tb_Strasse.Text;
                    k.Hausnummer = tb_Hausnummer.Text;
                    k.Postleitzahl = tb_Postleitzahl.Text;
                    k.Ort = tb_Ort.Text;
                    k.Vertrauenswuerdigkeit = cb_Vertrauenswuerdigkeit.Text;
                    k.Klasse = tb_Klasse.Text;
                    k.Mail = tb_Mail.Text;
                    k.Telefonnummer = tb_Telefonnummer.Text;
                    k.Delete();
                    Clear();
                    lb_kunde_add.Visible = true;
                    k.FillGrid(ref Grid_Kunde);
                    t.Start();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Kunde konnte nicht gelöscht werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Neukunde.Checked
              && !tb_Vorname.Text.Equals("")
              && !tb_Nachname.Text.Equals("")
              && !tb_Strasse.Text.Equals("")
              && !tb_Hausnummer.Text.Equals("")
              && !tb_Postleitzahl.Text.Equals("")
              && !tb_Ort.Text.Equals("")
              && !cb_Vertrauenswuerdigkeit.Text.Equals(""))
            {
                try
                {
                    lb_kunde_add.Visible = false;
                    lb_kunde_add.Text = "Der Kunde wurde hinzugefügt!";
                    k.KundenID = tb_KundenID.Text;
                    k.Vorname = tb_Vorname.Text;
                    k.Nachname = tb_Nachname.Text;
                    k.Strasse = tb_Strasse.Text;
                    k.Hausnummer = tb_Hausnummer.Text;
                    k.Postleitzahl = tb_Postleitzahl.Text;
                    k.Ort = tb_Ort.Text;
                    k.Vertrauenswuerdigkeit = cb_Vertrauenswuerdigkeit.Text;
                    k.Klasse = tb_Klasse.Text;
                    k.Mail = tb_Mail.Text;
                    k.Telefonnummer = tb_Telefonnummer.Text;
                    k.Add();
                    Clear();
                    lb_kunde_add.Visible = true;
                    k.FillGrid(ref Grid_Kunde);
                    t.Start();

                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Kunde konnte nicht hinzugefügt werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_KundeBearbeiten.Checked)
            {
                MessageBox.Show("Füllen Sie die markierten Felder aus, um einen Kunden zu speichern!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                IsOK();
            }
            else if (rb_Neukunde.Checked)
            {
                MessageBox.Show("Füllen Sie alle Felder aus, um einen neuen Kunden hinzuzufügen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_KundeLoeschen.Checked)
            {
                MessageBox.Show("Füllen Sie alle Felder aus, um einen Kunden zu löschen!", "Achtung",
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
        #endregion

        #region Clear Kunde
        private void Clear_Kunde(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
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
            tb_KundenID.BackColor = Color.White;
            tb_Vorname.BackColor = Color.White;
            tb_Nachname.BackColor = Color.White;
            tb_Strasse.BackColor = Color.White;
            tb_Hausnummer.BackColor = Color.White;
            tb_Postleitzahl.BackColor = Color.White;
            tb_Ort.BackColor = Color.White;
            tb_Klasse.BackColor = Color.White;
            tb_Mail.BackColor = Color.White;
            tb_Telefonnummer.BackColor = Color.White;
            cb_Vertrauenswuerdigkeit.BackColor = Color.White;
        }
        #endregion

        #region Modus
        private void Modus()
        {
            if (rb_KundeBearbeiten.Checked)
            {
                bt_save_kunde.Enabled = true;
                bt_save_kunde.Text = "Speichern";
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
                bt_save_kunde.Text = "Hinzufügen";
                bt_save_kunde.Enabled = true;
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
                bt_save_kunde.Enabled = true;
                bt_save_kunde.Text = "Löschen";
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
        #endregion

        #region IsOK
        private void IsOK()
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

        #region Textboxfarbe
        private void tb_KundenID_TextChanged(object sender, EventArgs e)
        {
            tb_KundenID.BackColor = Color.White;
        }

        private void tb_Vorname_TextChanged(object sender, EventArgs e)
        {
            tb_Vorname.BackColor = Color.White;
            (Grid_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%'", tb_Vorname.Text, tb_Nachname.Text);
        }

        private void tb_Nachname_TextChanged(object sender, EventArgs e)
        {
            tb_Nachname.BackColor = Color.White;
            (Grid_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%'", tb_Vorname.Text, tb_Nachname.Text);
        }

        private void tb_Strasse_TextChanged(object sender, EventArgs e)
        {
            tb_Strasse.BackColor = Color.White;
        }

        private void tb_Hausnummer_TextChanged(object sender, EventArgs e)
        {
            tb_Hausnummer.BackColor = Color.White;
        }

        private void tb_Postleitzahl_TextChanged(object sender, EventArgs e)
        {
            tb_Postleitzahl.BackColor = Color.White;
        }

        private void tb_Ort_TextChanged(object sender, EventArgs e)
        {
            tb_Ort.BackColor = Color.White;
        }

        private void tb_Klasse_TextChanged(object sender, EventArgs e)
        {
            tb_Klasse.BackColor = Color.White;
        }

        private void tb_Mail_TextChanged(object sender, EventArgs e)
        {
            tb_Mail.BackColor = Color.White;
        }

        private void tb_Telefonnummer_TextChanged(object sender, EventArgs e)
        {
            tb_Telefonnummer.BackColor = Color.White;
        }

        private void cb_Vertrauenswuerdigkeit_TextChanged_1(object sender, EventArgs e)
        {
            cb_Vertrauenswuerdigkeit.BackColor = Color.White;
        }
        #endregion

        #region Kundenbearbeitung
        private void rb_KundeBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }

        private void rb_KundeLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }

        private void rb_Neukunde_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }

        private void w_s_kunden_Activated(object sender, EventArgs e)
        {
            Modus();
        }
        #endregion

        private void White()
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


        private void Grid_Kunde_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_Kunde.Rows[e.RowIndex];

                rb_KundeBearbeiten.Checked = true;
                tb_KundenID.Text = row.Cells["Kunden-ID"].Value.ToString();
                Kunde k = new Kunde(tb_KundenID.Text);
                tb_Vorname.Text = k.Vorname;
                tb_Nachname.Text = k.Nachname;
                tb_Strasse.Text = k.Strasse;
                tb_Hausnummer.Text = k.Hausnummer;
                tb_Postleitzahl.Text = k.Postleitzahl;
                tb_Ort.Text = k.Ort;
                tb_Klasse.Text = k.Klasse;
                tb_Mail.Text = k.Mail;
                tb_Telefonnummer.Text = k.Telefonnummer;
                cb_Vertrauenswuerdigkeit.Text = k.Vertrauenswuerdigkeit;

            }
        }

        private void bt_Excel_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();

            export.ToExcel(Grid_Kunde, "Bibo_Kundenliste.csv");
        }
    }
}
