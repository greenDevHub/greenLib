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
    public partial class w_s_kunden : Form
    {
        Kunde k = new Kunde();

        public w_s_kunden()
        {
            InitializeComponent();
        }

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

        private void bt_laden_kunden_Click(object sender, EventArgs e)
        {
            if (tb_KundenID.Text.Equals("") == false)
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
                   // cb_Vertrauenswuerdigkeit.Text = 
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Kunde könnte nicht geladen werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else
            {
                MessageBox.Show("Füllen Sie das markierte Feld, um einen Kunden zu laden!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_KundenID.BackColor = Color.Red;
                tb_KundenID.Text = "";
            }
           
        }

        private void bt_save_kunde_Click(object sender, EventArgs e)
        {
            if (tb_KundenID.Text.Equals("") 
                && tb_Vorname.Text.Equals("") 
                && tb_Nachname.Text.Equals("")
                && tb_Strasse.Text.Equals("")
                && tb_Hausnummer.Text.Equals("") 
                && tb_Postleitzahl.Text.Equals("")
                && tb_Ort.Text.Equals("")
                && cb_Vertrauenswuerdigkeit.Text.Equals("")
                && tb_Klasse.Text.Equals("")
                && tb_Mail.Text.Equals("")
                && tb_Telefonnummer.Text.Equals("") == false)
            {
                try
                {                   
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
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Kunde könnte nicht gespeichert werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Füllen Sie die markierten Felder, um einen Kunden zu speichern!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                IsOK();
            }
        }

        private void Modus()
        {
            if (rb_KundeBearbeiten.Checked)
            {
                bt_laden_kunden.Enabled = true;
                tb_KundenID.Enabled = true;

            } else if (rb_Neukunde.Checked)
            {
                bt_laden_kunden.Enabled = false;
                tb_KundenID.Enabled = false;

            } else if (rb_KundeLoeschen.Checked)
            {
                bt_laden_kunden.Enabled = false;
                tb_KundenID.Enabled = true;
            }
        }

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

        private void w_s_kunden_Activated(object sender, EventArgs e)
        {
            Modus();
        }
    }
}
