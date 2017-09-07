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

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // DataTable dt = new DataTable();
            //string g = dr["kunde_vertrauenswürdigkeit"].ToString();

            //string[] cbItems = { "vertrauenswürdig", "nicht vertrauenswürdig", "noch nicht bestimmt" };


            cb.ValueMember = dr["kunde_vertrauenswürdigkeit"].ToString();
            cb.DisplayMember = dr["kunde_vertrauenswürdigkeit"].ToString();
            cb.SelectedValue = dr["kunde_vertrauenswürdigkeit"].ToString();
        }
        #endregion

        #region Load Kunde
        private void Load_Kunde(object sender, EventArgs e)
        {
            if (!tb_KundenID.Text.Equals(""))
            {
                try
                {
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
                    if (tb_Vorname.Text == ""
                        && tb_Nachname.Text == ""
                        && tb_Strasse.Text == ""
                        && tb_Hausnummer.Text == ""
                        && tb_Postleitzahl.Text == ""
                        && tb_Ort.Text == ""
                        && tb_Klasse.Text == ""
                        && tb_Mail.Text == ""
                        && tb_Telefonnummer.Text == ""
                        && cb_Vertrauenswuerdigkeit.Text == "")
                    {
                        MessageBox.Show("Ein Kunde mit dieser ID existiert nicht!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Clear();
                    }


                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Kunde konnte nicht geladen werden!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                }
            else
            {
                MessageBox.Show("Füllen Sie nur die markierten Felder aus, um einen Kunden zu laden!", "Achtung",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Clear();
                tb_KundenID.BackColor = Color.Red;
            }
        }


        #endregion

        #region Save Kunde
        private void Save_Kunde(object sender, EventArgs e)
        {
            if (rb_KundeBearbeiten.Checked
                && !tb_Vorname.Text.Equals("")
                && !tb_Nachname.Text.Equals("")
                && !tb_Strasse.Text.Equals("")
                && !tb_Hausnummer.Text.Equals("")
                && !tb_Postleitzahl.Text.Equals("")
                && !tb_Ort.Text.Equals("")
                && !cb_Vertrauenswuerdigkeit.Text.Equals("")
                && !tb_Klasse.Text.Equals("")
                && !tb_Mail.Text.Equals("")
                && !tb_Telefonnummer.Text.Equals(""))
            {
                try
                {
                    lb_kunde_save.Visible = false;
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
                    lb_kunde_save.Visible = true;
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Kunde konnte nicht gespeichert werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_KundeLoeschen.Checked
                && !tb_Vorname.Text.Equals("")
                && !tb_Nachname.Text.Equals("")
                && !tb_KundenID.Text.Equals(""))
            {
                try
                {
                    lb_kunde_delete.Visible = false;
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
                    lb_kunde_delete.Visible = true;
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
              && !cb_Vertrauenswuerdigkeit.Text.Equals("")
              && !tb_Klasse.Text.Equals("")
              && !tb_Mail.Text.Equals("")
              && !tb_Telefonnummer.Text.Equals(""))
            {
                try
                {
                    lb_kunde_add.Visible = false;
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
                    lb_kunde_add.Visible = true;
                    

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
            }
            else if (rb_KundeLoeschen.Checked)
            {
                MessageBox.Show("Füllen Sie alle Felder aus, um einen Kunden zu löschen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            lb_kunde_save.Visible = false;
            lb_kunde_delete.Visible = false;
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
            if (rb_Laden.Checked)
            {
                Clear();
                bt_laden_kunden.Text = "Laden";
                bt_save_kunde.Enabled = false;
                bt_save_kunde.Text = "";
                bt_laden_kunden.Enabled = true;
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
            }
            else if (rb_KundeBearbeiten.Checked)
            {
                bt_laden_kunden.Text = "";
                bt_save_kunde.Enabled = true;
                bt_save_kunde.Text = "Speichern";
                bt_laden_kunden.Enabled = false;
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

            }
            else if (rb_Neukunde.Checked)
            {
                Clear();
                bt_laden_kunden.Text = "";
                bt_save_kunde.Text = "Speichern";
                bt_laden_kunden.Enabled = false;
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

            }
            else if (rb_KundeLoeschen.Checked)
            {
                bt_save_kunde.Enabled = true;
                bt_laden_kunden.Text = "";
                bt_save_kunde.Text = "Löschen";
                bt_laden_kunden.Enabled = false;
                tb_KundenID.Enabled = true;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                tb_Strasse.Enabled = false;
                tb_Hausnummer.Enabled = false;
                tb_Postleitzahl.Enabled = false;
                tb_Ort.Enabled = false;
                cb_Vertrauenswuerdigkeit.Enabled = false;
                tb_Klasse.Enabled = false;
                tb_Mail.Enabled = false;
                tb_Telefonnummer.Enabled = false;
            }
        }
        #endregion

        #region IsOK
        private void IsOK()
        {
            if (tb_KundenID.Text.Equals(""))
            {
                tb_KundenID.BackColor = Color.Red;
            }
            else
            {
                tb_KundenID.BackColor = Color.White;
            }

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

            if (tb_Klasse.Text.Equals(""))
            {
                tb_Klasse.BackColor = Color.Red;
            }
            else
            {
                tb_Klasse.BackColor = Color.White;
            }

            if (tb_Mail.Text.Equals(""))
            {
                tb_Mail.BackColor = Color.Red;
            }
            else
            {
                tb_Mail.BackColor = Color.White;
            }

            if (tb_Telefonnummer.Text.Equals(""))
            {
                tb_Telefonnummer.BackColor = Color.Red;
            }
            else
            {
                tb_Telefonnummer.BackColor = Color.White;
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
        }

        private void tb_Nachname_TextChanged(object sender, EventArgs e)
        {
            tb_Nachname.BackColor = Color.White;
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
        #endregion

        #region Kundenbearbeitung
        private void rb_KundeBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_KundeLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_Neukunde_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_laden_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void w_s_kunden_Activated(object sender, EventArgs e)
        {
            Modus();
        }
        #endregion

    }
}
