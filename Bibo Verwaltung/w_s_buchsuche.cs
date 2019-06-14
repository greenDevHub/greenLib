using MetroFramework.Controls;
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
        }
        #endregion

        Buchsuche buchsuche = new Buchsuche();
        string[] leih;

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
            tb_ExemplarID.Text = "";
            tb_ISBN.Text = "";
            tb_Titel.Text = "";
            tb_VName.Text = "";
            tb_NName.Text = "";
            tb_Klasse.Text = "";
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
            rb_Default.Checked = true;
            buchsuche.Show_AlleExemplare(ref gv_buchsuche);
            buchsuche.Set_StatusMark(ref gv_buchsuche);
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
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            //buchsuche.FillComboBoxes(ref cb_Autor, ref cb_Verlag, ref cb_Genre);
            //buchsuche.FillGrid(ref gv_buchsuche);
            //buchsuche.Hide_KundenDetails(ref gv_buchsuche);
            //buchsuche.Set_StatusMark(ref gv_buchsuche);
        }

        private void gv_buchsuche_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            buchsuche.Set_StatusMark(ref gv_buchsuche);
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
            buchsuche.Execute_KundenSearch(ref gv_buchsuche, tb_VName.Text, tb_NName.Text, tb_Klasse.Text);
        }

        private void tb_vorname_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_KundenSearch(ref gv_buchsuche, tb_VName.Text, tb_NName.Text, tb_Klasse.Text);
        }

        private void tb_klasse_TextChanged(object sender, EventArgs e)
        {
            buchsuche.Execute_KundenSearch(ref gv_buchsuche, tb_VName.Text, tb_NName.Text, tb_Klasse.Text);
        }

        //TODO
        private void addToLeihList_Click(object sender, EventArgs e)
        {

        }

        private void removeFromLeihList_Click(object sender, EventArgs e)
        {

        }

        private void ausleihen_Click(object sender, EventArgs e)
        {
            leih = new string[1];
            leih[0]= gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString();
            this.Hide();
            Form Ausleihe = new w_s_ausleihe(currentUser, leih);
            Ausleihe.ShowDialog(this);
            this.Show();
        }

        private void gv_buchsuche_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(gv_buchsuche.HitTest(e.X, e.Y).RowIndex >= 0))
            {
                gv_buchsuche.ClearSelection();
                addToLeihList.Visible = false;
                removeFromLeihList.Visible = false;
                ausleihen.Visible = false;
            }
            else
            {
                addToLeihList.Visible = true;
                removeFromLeihList.Visible = true;
                ausleihen.Visible = true;
            }
        }

        private void gv_buchsuche_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!gv_buchsuche.Rows[e.RowIndex].Selected)
                {
                    gv_buchsuche.ClearSelection();
                    gv_buchsuche.Rows[e.RowIndex].Selected = true;
                }         
                    addToLeihList.Enabled = true;
                    removeFromLeihList.Enabled = true;
                    ausleihen.Enabled = true;            
            }
        }

        private void rb_Default_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_GREENonly.Checked)
            {
                buchsuche.Show_GreenExemplare(ref gv_buchsuche);
            }
            else if (rb_YELLOWonly.Checked)
            {
                buchsuche.Show_YellowExemplare(ref gv_buchsuche);
            }
            else if (rb_REDonly.Checked)
            {
                buchsuche.Show_RedExemplare(ref gv_buchsuche);
            }
            else
            {
                buchsuche.Show_AlleExemplare(ref gv_buchsuche);
                buchsuche.Set_StatusMark(ref gv_buchsuche);
            }
        }
        #endregion

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke((Action)delegate ()
            {
                metroProgressSpinner1.Visible = true;
                metroProgressSpinner2.Visible = true;
                gv_buchsuche.Visible = false;
                cb_Autor.Visible = false;
                cb_Genre.Visible = false;
                cb_Verlag.Visible = false;
            });
            MetroGrid mgBuSu = new MetroGrid();
            AdvancedComboBox cbAutor = new AdvancedComboBox();
            AdvancedComboBox cbVerlag = new AdvancedComboBox();
            AdvancedComboBox cbGenre = new AdvancedComboBox();
            List<int> RedBlack = new List<int>();
            List<int> YellowBlack = new List<int>();
            List<int>LimeBlack= new List<int>();
            buchsuche.FillComboBoxes(ref cbAutor, ref cbVerlag, ref cbGenre);
            buchsuche.FillGrid(ref mgBuSu);
            buchsuche.Set_StatusMarkNew(ref mgBuSu, ref RedBlack, ref YellowBlack, ref LimeBlack);
            var dtBuSu = mgBuSu.DataSource;
            try
            {
                BeginInvoke((Action)delegate
                {
                    gv_buchsuche.DataSource = dtBuSu;
                    gv_buchsuche.Columns["Kunden ID"].Visible = false;
                    gv_buchsuche.Columns["Leihnummer"].Visible = false;
                    gv_buchsuche.Columns["Kunden ID"].Visible = false;
                    gv_buchsuche.Columns["Vorname"].Visible = false;
                    gv_buchsuche.Columns["Nachname"].Visible = false;
                    gv_buchsuche.Columns["Klasse"].Visible = false;
                    foreach(int i in RedBlack)
                    {
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                    }
                    foreach (int i in YellowBlack)
                    {
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                    }
                    foreach (int i in LimeBlack)
                    {
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                    }
                    cb_Autor.DataSource = cbAutor.DataSource;
                    cb_Autor.ValueMember = "au_id";
                    cb_Autor.DisplayMember = "au_autor";
                    cb_Verlag.DataSource = cbVerlag.DataSource;
                    cb_Verlag.ValueMember = "ver_id";
                    cb_Verlag.DisplayMember = "ver_name";
                    cb_Genre.DataSource = cbGenre.DataSource;
                    cb_Genre.ValueMember = "ger_id";
                    cb_Genre.DisplayMember = "ger_name";
                    metroProgressSpinner1.Visible = false;
                    metroProgressSpinner2.Visible = false;
                    gv_buchsuche.Visible = true;
                    cb_Autor.Visible = true;
                    cb_Genre.Visible = true;
                    cb_Verlag.Visible = true;
                });
            }
            catch { }
        }
    }
}