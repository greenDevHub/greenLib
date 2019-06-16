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
        bool loaded = false;
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
            cb_KundeAnz.Checked = false;
            rb_Default.Checked = true;
            buchsuche.Show_AlleExemplare(ref gv_buchsuche);
            if (leihListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
            }
            else if (rueckListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe);
            }
            else
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
            }
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
                (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter = string.Format("Leihnummer IS NULL");
                if (leihListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
                }
                else if (rueckListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe);
                }
                else
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
                }

                //buchsuche.Show_VerfuegbareExemplare(ref gv_buchsuche);
            }
            else
            {
                (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter = string.Format("ExemplarID IS NOT NULL");
                //buchsuche.Show_AlleExemplare(ref gv_buchsuche);
                if (leihListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
                }
                else if (rueckListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe);
                }
                else
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
                }
            }
        }

        private void Ausleihvorgang(object sender, EventArgs e)
        {
            if(leihListe.Count != 0)
            {
                Form Ausleihe = new w_s_ausleihe(currentUser,leihListe.ToArray());
                Ausleihe.ShowDialog(this);
                leihListe.Clear();
                rueckgabelisteToolStripMenuItem.Enabled = true;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                Form Ausleihe = new w_s_ausleihe(currentUser);
                Ausleihe.ShowDialog(this);
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
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
            if (leihListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
            }
            else if (rueckListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe);
            }
            else
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
            }

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
        List<string> leihListe = new List<string>();
        List<string> rueckListe = new List<string>();
        //TODO
        private void addToLeihList_Click(object sender, EventArgs e)
        {
            try
            {
                leihListe.Add(gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString());
                lb_liste.Text = "";
                foreach (string s in leihListe)
                {
                    lb_liste.Text = lb_liste.Text + s + "; ";
                }
                lb_liste.Text = lb_liste.Text.Trim().TrimEnd(';');
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.White;
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = Color.Black;
                ausleihenToolStripMenuItem.Enabled = true;
                entfernenToolStripMenuItem.Enabled = true;
                rueckgabelisteToolStripMenuItem.Enabled = false;
            }
            catch
            {

            }
        }

        private void removeFromLeihList_Click(object sender, EventArgs e)
        {
            try
            {
                leihListe.Remove(gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString());
                lb_liste.Text = "";
                foreach (string s in leihListe)
                {
                    lb_liste.Text = lb_liste.Text + s + "; ";
                }
                lb_liste.Text = lb_liste.Text.Trim().TrimEnd(';');
                if (leihListe.Count == 0)
                {
                    ausleihenToolStripMenuItem.Enabled = false;
                    entfernenToolStripMenuItem.Enabled = false;

                    rueckgabelisteToolStripMenuItem.Enabled = true;
                }
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Gray;
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
            }
            catch
            {

            }
        }

        private void ausleihen_Click(object sender, EventArgs e)
        {
            leih = new string[1];
            leih[0]= gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString();
            Form Ausleihe = new w_s_ausleihe(currentUser, leih);
            Ausleihe.ShowDialog(this);
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void gv_buchsuche_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(gv_buchsuche.HitTest(e.X, e.Y).RowIndex >= 0))
            {
                gv_buchsuche.ClearSelection();
                hinzufügenToolStripMenuItem.Visible = false;
                entfernenToolStripMenuItem.Visible = false;
                ausleihen.Visible = false;
                ausleihenToolStripMenuItem.Visible = false;
                exemplarZurückgebenToolStripMenuItem.Visible = false;
                ausleihlisteToolStripMenuItem.Visible = false;
                rueckgabelisteToolStripMenuItem.Visible = false;
                hinzufügenToolStripMenuItem1.Visible = false;
                entfernenToolStripMenuItem1.Visible = false;
                zurueckgebenToolStripMenuItem.Visible = false;
            }
            else
            {
                hinzufügenToolStripMenuItem.Visible = true;
                entfernenToolStripMenuItem.Visible = true;
                ausleihen.Visible = true;
                ausleihenToolStripMenuItem.Visible = true;
                exemplarZurückgebenToolStripMenuItem.Visible = true;
                ausleihlisteToolStripMenuItem.Visible = true;
                rueckgabelisteToolStripMenuItem.Visible = true;
                hinzufügenToolStripMenuItem1.Visible = true;
                entfernenToolStripMenuItem1.Visible = true;
                zurueckgebenToolStripMenuItem.Visible = true;
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
                if (rueckListe.Count != 0)
                {
                    zurueckgebenToolStripMenuItem.Enabled = true;

                }
                else
                {
                    zurueckgebenToolStripMenuItem.Enabled = false;
                }
                if (leihListe.Count != 0)
                {
                    ausleihenToolStripMenuItem.Enabled = true;

                }
                else
                {
                    ausleihenToolStripMenuItem.Enabled = false;

                }
                if (gv_buchsuche.SelectedRows[0].Cells["Rückgabedatum"].Value.ToString().Equals(""))
                {
                    entfernenToolStripMenuItem1.Enabled = false;
                    hinzufügenToolStripMenuItem1.Enabled = false;
                    if (leihListe.Contains(gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString()))
                    {
                        hinzufügenToolStripMenuItem.Enabled = false;
                        entfernenToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        hinzufügenToolStripMenuItem.Enabled = true;
                        entfernenToolStripMenuItem.Enabled = false;
                    }
                    ausleihen.Enabled = true;
                    exemplarZurückgebenToolStripMenuItem.Enabled = false;
                }
                else
                {
                    entfernenToolStripMenuItem.Enabled = false;
                    hinzufügenToolStripMenuItem.Enabled = false;
                    ausleihen.Enabled = false;
                    exemplarZurückgebenToolStripMenuItem.Enabled = true;
                    if (rueckListe.Contains(gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString()))
                    {
                        hinzufügenToolStripMenuItem1.Enabled = false;
                        entfernenToolStripMenuItem1.Enabled = true;
                    }
                    else
                    {
                        hinzufügenToolStripMenuItem1.Enabled = true;
                        entfernenToolStripMenuItem1.Enabled = false;
                    }
                    
                }
                        
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
                if(leihListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
                }
                else if(rueckListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe);
                }
                else
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe);
                }
            }
        }
        #endregion

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BeginInvoke((Action)delegate ()
                {
                    metroProgressSpinner1.Visible = true;
                    metroProgressSpinner2.Visible = true;
                    gv_buchsuche.DataSource = null;
                    cb_Autor.DataSource = null;
                    cb_Genre.DataSource = null;
                    cb_Verlag.DataSource = null;
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
                List<int> LimeBlack = new List<int>();
                List<int> BlackWhite = new List<int>();
                buchsuche.FillComboBoxes(ref cbAutor, ref cbVerlag, ref cbGenre);
                buchsuche.FillGrid(ref mgBuSu);
                if(rueckListe.Count != 0)
                {
                    buchsuche.Set_StatusMarkNew(ref mgBuSu, ref RedBlack, ref YellowBlack, ref LimeBlack, ref BlackWhite,rueckListe);
                }
                else
                {
                    buchsuche.Set_StatusMarkNew(ref mgBuSu, ref RedBlack, ref YellowBlack, ref LimeBlack, ref BlackWhite, leihListe);
                }
                var dtBuSu = mgBuSu.DataSource;
                while (loaded == false)
                {

                }
                BeginInvoke((Action)delegate
                {
                    gv_buchsuche.DataSource = dtBuSu;
                    gv_buchsuche.Columns["Kunden ID"].Visible = false;
                    gv_buchsuche.Columns["Leihnummer"].Visible = false;
                    gv_buchsuche.Columns["Kunden ID"].Visible = false;
                    gv_buchsuche.Columns["Vorname"].Visible = false;
                    gv_buchsuche.Columns["Nachname"].Visible = false;
                    gv_buchsuche.Columns["Klasse"].Visible = false;

                    cb_Autor.DataSource = cbAutor.DataSource;
                    cb_Autor.ValueMember = "au_id";
                    cb_Autor.DisplayMember = "au_autor";
                    cb_Autor.SelectedIndex = -1;
                    cb_Verlag.DataSource = cbVerlag.DataSource;
                    cb_Verlag.ValueMember = "ver_id";
                    cb_Verlag.DisplayMember = "ver_name";
                    cb_Verlag.SelectedIndex = -1;
                    cb_Genre.DataSource = cbGenre.DataSource;
                    cb_Genre.ValueMember = "ger_id";
                    cb_Genre.DisplayMember = "ger_name";
                    cb_Genre.SelectedIndex = -1;
                    if (cb_Autor.Text == "")
                    {
                        cb_Autor.Text = "Autor";
                    }
                    if (cb_Verlag.Text == "")
                    {
                        cb_Verlag.Text = "Verlag";
                    }
                    if (cb_Genre.Text == "")
                    {
                        cb_Genre.Text = "Genre";
                    }
                    metroProgressSpinner1.Visible = false;
                    metroProgressSpinner2.Visible = false;
                    gv_buchsuche.Visible = true;
                    cb_Autor.Visible = true;
                    cb_Genre.Visible = true;
                    cb_Verlag.Visible = true;
                    //buchsuche.FillGrid(ref gv_buchsuche);
                    //buchsuche.Set_StatusMark(ref gv_buchsuche);

                    foreach (int i in RedBlack)
                    {
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        gv_buchsuche.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    foreach (int i in YellowBlack)
                    {
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        gv_buchsuche.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    foreach (int i in LimeBlack)
                    {
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
                        gv_buchsuche.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    foreach (int i in BlackWhite)
                    {
                        gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = Color.Black;
                        gv_buchsuche.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }
                    gv_buchsuche.Refresh();
                });
            }
            catch { }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            loaded = true;
            timer1.Stop();
        }

        private void LeihlisteAusleihenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leih = leihListe.ToArray();
            Form Ausleihe = new w_s_ausleihe(currentUser, leih);
            Ausleihe.ShowDialog(this);
            leihListe.Clear();
            rueckgabelisteToolStripMenuItem.Enabled = true;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void ExemplarZurückgebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] rueck = new string[1];
            rueck[0] = gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString();
            Form Rueckgabe = new w_s_rueckgabe(currentUser, rueck);
            Rueckgabe.ShowDialog(this);
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Bt_rueckgabe_Click(object sender, EventArgs e)
        {
            if (rueckListe.Count != 0)
            {
                Form Rueckgabe = new w_s_rueckgabe(currentUser, rueckListe.ToArray());
                Rueckgabe.ShowDialog(this);
                rueckListe.Clear();
                ausleihlisteToolStripMenuItem.Enabled = true;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                Form Rueckgabe = new w_s_rueckgabe(currentUser);
                Rueckgabe.ShowDialog(this);
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
        }

        private void HinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                rueckListe.Add(gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString());
                lb_liste.Text = "";
                foreach (string s in rueckListe)
                {
                    lb_liste.Text = lb_liste.Text + s + "; ";
                }
                lb_liste.Text = lb_liste.Text.Trim().TrimEnd(';');
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.White;
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = Color.Black;
                zurueckgebenToolStripMenuItem.Enabled = true;
                entfernenToolStripMenuItem1.Enabled = true;
                ausleihlisteToolStripMenuItem.Enabled = false;
            }
            catch
            {

            }
        }

        private void EntfernenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                rueckListe.Remove(gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString());
                lb_liste.Text = "";
                foreach (string s in rueckListe)
                {
                    lb_liste.Text = lb_liste.Text + s + "; ";
                }
                lb_liste.Text = lb_liste.Text.Trim().TrimEnd(';');
                if (rueckListe.Count == 0)
                {
                    zurueckgebenToolStripMenuItem.Enabled = false;
                    entfernenToolStripMenuItem1.Enabled = false;
                    ausleihlisteToolStripMenuItem.Enabled = true;

                }
                DateTime now = DateTime.Today;
                DateTime dt = new DateTime();
                dt = DateTime.Parse(gv_buchsuche.SelectedRows[0].Cells["Rückgabedatum"].Value.ToString());
                if (dt < now)
                {
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = Color.Red;
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dt == now)
                {
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = Color.Yellow;
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = Color.LimeGreen;
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch
            {

            }
        }

        private void ZurueckgebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Rueckgabe = new w_s_rueckgabe(currentUser, rueckListe.ToArray());
            Rueckgabe.ShowDialog(this);
            rueckListe.Clear();
            ausleihlisteToolStripMenuItem.Enabled = true;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Bt_reset_Click(object sender, EventArgs e)
        {
            rueckListe.Clear();
            leihListe.Clear();
            lb_liste.Text = "";
            buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe);
            rueckgabelisteToolStripMenuItem.Enabled = true;
            ausleihlisteToolStripMenuItem.Enabled = true;
        }
    }
}