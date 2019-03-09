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
    public partial class w_s_buchsuche : MetroFramework.Forms.MetroForm
    {
        #region Objekt Constructor
        /// <summary>
        /// Erschaft die Form
        /// </summary>
        string currentUser;
        public w_s_buchsuche(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;

            //buch.AutorListe.Autor.FillCombobox(ref cb_Autor, -1);
            //buch.Verlag.FillCombobox(ref cb_Verlag, -1);
            //buch.Genre.FillCombobox(ref cb_Genre, -1);
            //buchsuche.Hide_KundenDetails(ref gv_buchsuche);
            //buchsuche.FillGrid(ref gv_buchsuche);
        }
        #endregion

        Buchsuche buchsuche = new Buchsuche();

        #region Fenster-Methoden
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
        #endregion

        #region Componenten-Aktionen
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            tb_vorname.Text = "";
            tb_vorname.ForeColor = Color.Gray;
            tb_nachname.Text = "";
            tb_nachname.ForeColor = Color.Gray;
            tb_klasse.Text = "";
            tb_klasse.ForeColor = Color.Gray;
            tb_ExemplarID.Text = "";
            tb_ExemplarID.ForeColor = Color.Gray;
            tb_ISBN.Text = "";
            tb_ISBN.ForeColor = Color.Gray;
            tb_Titel.Text = "";
            tb_Titel.ForeColor = Color.Gray;
            cb_Autor.SelectedIndex = -1;
            cb_Autor.Text = "Autor";
            cb_Autor.ForeColor = Color.Gray;
            cb_Genre.SelectedIndex = -1;
            cb_Genre.Text = "Genre";
            cb_Genre.ForeColor = Color.Gray;
            cb_Verlag.SelectedIndex = -1;
            cb_Verlag.Text = "Verlag";
            cb_Verlag.ForeColor = Color.Gray;
            cb_Verfügbar_Anz.Checked = false;
            buchsuche.Show_AlleExemplare(ref gv_buchsuche);
        }

        private void cb_KundeAnz_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_KundeAnz.Checked == true)
            {
                buchsuche.Show_KundenDetails(ref gv_buchsuche);
            }
            else
            {
                buchsuche.Hide_KundenDetails(ref gv_buchsuche);
            }
        }

        private void cb_Verfügbar_Anz_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Verfügbar_Anz.Checked == true)
            {
                buchsuche.Show_VerfuegbareExemplare(ref gv_buchsuche);
            }
            else
            {
                buchsuche.Show_AlleExemplare(ref gv_buchsuche);
                buchsuche.Set_StatusMark(ref gv_buchsuche);
            }         
        }

        private void Ausleihvorgang(object sender, EventArgs e)
        {
            Form Ausleihe = new w_s_ausleihe(currentUser);
            Ausleihe.ShowDialog(this);
        }

        private void tb_ExemplarID_Click(object sender, EventArgs e)
        {
            if (tb_ExemplarID.Text.Length == 8)
            {
                string seven = tb_ExemplarID.Text.Substring(0, 7);
                string eight = tb_ExemplarID.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tb_ExemplarID.Text = int.Parse(seven).ToString();
                }
            }
        }

        private void tb_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void tb_ExemplarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void w_s_buchsuche_Activated(object sender, EventArgs e)
        {
            //Procesdialog start
            buchsuche.FillComboBoxes(ref cb_Autor, ref cb_Verlag, ref cb_Genre);
            buchsuche.FillGrid(ref gv_buchsuche);           
            buchsuche.Hide_KundenDetails(ref gv_buchsuche);
            buchsuche.Set_StatusMark(ref gv_buchsuche);
        }

        private void gv_buchsuche_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buchsuche.Set_StatusMark(ref gv_buchsuche);
        }

        private void tb_ExemplarID_Enter(object sender, EventArgs e)
        {
            //    if (tb_ExemplarID.Text == "ExemplarID")
            //    {
            //        tb_ExemplarID.Text = "";
            //    }
            //    tb_ExemplarID.ForeColor = Color.Black;
        }

        private void tb_ExemplarID_Leave(object sender, EventArgs e)
        {
            //    if (tb_ExemplarID.Text == "")
            //    {
            //        tb_ExemplarID.Text = "ExemplarID";
            //        tb_ExemplarID.ForeColor = Color.Gray;
            //    }
            //    else
            //    {
            //        tb_ExemplarID.ForeColor = Color.Black;
            //    }
        }

        private void tb_ISBN_Enter(object sender, EventArgs e)
        {
            //    if (tb_ISBN.Text == "ISBN")
            //    {
            //        tb_ISBN.Text = "";
            //    }
            //    tb_ISBN.ForeColor = Color.Black;
        }

    private void tb_ISBN_Leave(object sender, EventArgs e)
        {
            //    if (tb_ISBN.Text == "")
            //    {
            //        tb_ISBN.Text = "ISBN";
            //        tb_ISBN.ForeColor = Color.Gray;
            //    }
            //    else
            //    {
            //        tb_ISBN.ForeColor = Color.Black;
            //    }
        }

        private void tb_Titel_Enter(object sender, EventArgs e)
        {
            //    if (tb_Titel.Text == "Titel")
            //    {
            //        tb_Titel.Text = "";
            //    }
            //    tb_Titel.ForeColor = Color.Black;
        }

    private void tb_Titel_Leave(object sender, EventArgs e)
        {
            //    if (tb_Titel.Text == "")
            //    {
            //        tb_Titel.Text = "Titel";
            //        tb_Titel.ForeColor = Color.Gray;
            //    }
            //    else
            //    {
            //        tb_Titel.ForeColor = Color.Black;
            //    }
        }

    private void cb_Autor_Enter(object sender, EventArgs e)
        {
            if (cb_Autor.Text == "Autor")
            {
                cb_Autor.Text = "";
            }
            cb_Autor.ForeColor = Color.Black;
        }

        private void cb_Autor_Leave(object sender, EventArgs e)
        {
            if (cb_Autor.Text == "")
            {
                cb_Autor.Text = "Autor";
                cb_Autor.ForeColor = Color.Gray;
            }
            else
            {
                cb_Autor.ForeColor = Color.Black;
            }
        }

        private void cb_Verlag_Enter(object sender, EventArgs e)
        {
            if (cb_Verlag.Text == "Verlag")
            {
                cb_Verlag.Text = "";
            }
            cb_Verlag.ForeColor = Color.Black;
        }

        private void cb_Verlag_Leave(object sender, EventArgs e)
        {
            if (cb_Verlag.Text == "")
            {
                cb_Verlag.Text = "Verlag";
                cb_Verlag.ForeColor = Color.Gray;
            }
            else
            {
                cb_Verlag.ForeColor = Color.Black;
            }
        }

        private void cb_Genre_Enter(object sender, EventArgs e)
        {
            if (cb_Genre.Text == "Genre")
            {
                cb_Genre.Text = "";
            }
            cb_Genre.ForeColor = Color.Black;
        }

        private void cb_Genre_Leave(object sender, EventArgs e)
        {
            if (cb_Genre.Text == "")
            {
                cb_Genre.Text = "Genre";
                cb_Genre.ForeColor = Color.Gray;
            }
            else
            {
                cb_Genre.ForeColor = Color.Black;
            }
        }

        private void tb_ExemplarID_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_BuchSearch(ref gv_buchsuche, tb_ExemplarID.Text, tb_ISBN.Text, tb_Titel.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text);
        }

        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_BuchSearch(ref gv_buchsuche, tb_ExemplarID.Text, tb_ISBN.Text, tb_Titel.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text);
        }

        private void tb_Titel_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_BuchSearch(ref gv_buchsuche, tb_ExemplarID.Text, tb_ISBN.Text, tb_Titel.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text);
        }

        private void cb_Autor_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_BuchSearch(ref gv_buchsuche, tb_ExemplarID.Text, tb_ISBN.Text, tb_Titel.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text);
        }

        private void cb_Verlag_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_BuchSearch(ref gv_buchsuche, tb_ExemplarID.Text, tb_ISBN.Text, tb_Titel.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text);
        }

        private void cb_Genre_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_BuchSearch(ref gv_buchsuche, tb_ExemplarID.Text, tb_ISBN.Text, tb_Titel.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text);
        }

        private void tb_nachname_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_KundenSearch(ref gv_buchsuche, tb_vorname.Text, tb_nachname.Text, tb_klasse.Text);
        }

        private void tb_vorname_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_KundenSearch(ref gv_buchsuche, tb_vorname.Text, tb_nachname.Text, tb_klasse.Text);
        }

        private void tb_klasse_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_KundenSearch(ref gv_buchsuche, tb_vorname.Text, tb_nachname.Text, tb_klasse.Text);
        }

        private void tb_vorname_Enter(object sender, EventArgs e)
        {
            //if (tb_vorname.Text == "Vorname")
            //{
            //    tb_vorname.Text = "";
            //}
            //tb_vorname.ForeColor = Color.Black;
        }

        private void tb_vorname_Leave(object sender, EventArgs e)
        {
            //if (tb_vorname.Text == "")
            //{
            //    tb_vorname.Text = "Vorname";
            //    tb_vorname.ForeColor = Color.Gray;
            //}
            //else
            //{
            //    tb_vorname.ForeColor = Color.Black;
            //}
        }

        private void tb_nachname_Enter(object sender, EventArgs e)
        {
            //if (tb_nachname.Text == "Nachname")
            //{
            //    tb_nachname.Text = "";
            //}
            //tb_nachname.ForeColor = Color.Black;
        }

        private void tb_nachname_Leave(object sender, EventArgs e)
        {
            //if (tb_nachname.Text == "")
            //{
            //    tb_nachname.Text = "Nachname";
            //    tb_nachname.ForeColor = Color.Gray;
            //}
            //else
            //{
            //    tb_nachname.ForeColor = Color.Black;
            //}
        }

        private void tb_klasse_Enter(object sender, EventArgs e)
        {
            //if (tb_klasse.Text == "Klassenstufe")
            //{
            //    tb_klasse.Text = "";
            //}
            //tb_klasse.ForeColor = Color.Black;
        }

        private void tb_klasse_Leave(object sender, EventArgs e)
        {
            //if (tb_klasse.Text == "")
            //{
            //    tb_klasse.Text = "Klassenstufe";
            //    tb_klasse.ForeColor = Color.Gray;
            //}
            //else
            //{
            //    tb_klasse.ForeColor = Color.Black;
            //}
        }
        #endregion

        //private void w_s_buchsuche_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    buchsuche.ClearObject();
        //}
    }
}
