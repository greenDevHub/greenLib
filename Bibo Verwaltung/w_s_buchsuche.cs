using MetroFramework;
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
        Color red = Color.Tomato;
        Color yellow = Color.Gold;
        Color green = Color.LimeGreen;
        Color fc = Color.Black;
        Color bc = Color.White;
        Color listfc = Color.White;
        Color listbc = Color.Black;
        public w_s_buchsuche(string userName, MetroFramework.Components.MetroStyleManager msm)
        {
            InitializeComponent();
            msm_buchsuche = msm;
            this.StyleManager = msm;
            this.StyleManager.Style = MetroColorStyle.Lime;
            if (this.StyleManager.Theme == MetroThemeStyle.Dark)
            {
                listfc = Color.Silver;
                listbc = Color.DimGray;
                red = Color.Firebrick;
                yellow = Color.Goldenrod;
                green = Color.OliveDrab;
                fc = Color.White;
                bc = System.Drawing.ColorTranslator.FromHtml("#111111");
                cb_Autor.BackColor = bc;
                cb_Genre.BackColor = bc;
                cb_Verlag.BackColor = bc;
                
            }
            lb_green.ForeColor = green;
            lb_red.ForeColor = red;
            lb_yellow.ForeColor = yellow;

            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            if (user.Rechteid.Equals("0"))
            {
                tb_ExemplarID.Enabled = false;
                tb_ISBN.Enabled = false;
                tb_Titel.Enabled = false;
                cb_Autor.Enabled = false;
                cb_Verlag.Enabled = false;
                cb_Genre.Enabled = false;
                tb_VName.Enabled = false;
                tb_NName.Enabled = false;
                tb_Klasse.Enabled = false;
                cb_KundeAnz.Enabled = false;
                cb_Verfügbar_Anz.Enabled = false;
                rb_REDonly.Enabled = false;
                rb_YELLOWonly.Enabled = false;
                rb_GREENonly.Enabled = false;
                rb_Default.Enabled = false;
                bt_Ausleihen.Enabled = false;
                bt_rueckgabe.Enabled = false;
                bt_reset.Enabled = false;
                bt_Clear.Enabled = false;
                ausleihen.Enabled = false;
                exemplarZurückgebenToolStripMenuItem.Enabled = false;
                ausleihlisteToolStripMenuItem.Enabled = false;
                rueckgabelisteToolStripMenuItem.Enabled = false;
            }
            else
            {
                tb_ExemplarID.Enabled = true;
                tb_ISBN.Enabled = true;
                tb_Titel.Enabled = true;
                cb_Autor.Enabled = true;
                cb_Verlag.Enabled = true;
                cb_Genre.Enabled = true;
                tb_VName.Enabled = true;
                tb_NName.Enabled = true;
                tb_Klasse.Enabled = true;
                cb_KundeAnz.Enabled = true;
                cb_Verfügbar_Anz.Enabled = true;
                rb_REDonly.Enabled = true;
                rb_YELLOWonly.Enabled = true;
                rb_GREENonly.Enabled = true;
                rb_Default.Enabled = true;
                bt_Ausleihen.Enabled = true;
                bt_rueckgabe.Enabled = true;
                bt_reset.Enabled = true;
                bt_Clear.Enabled = true;
            }
            this.Text = Text + " - Angemeldet als: " + userName + " (" + user.Rechte + ")";
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
            filterActive = true;
            if (leihListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
            }
            else if (rueckListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe, red, yellow, green, listfc, listbc);
            }
            else
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
            }
        }

        private void ShowKundeDetails()
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
        private void cb_KundeAnz_CheckedChanged(object sender, EventArgs e)
        {
            ShowKundeDetails();
        }
        private void addRowFilter()
        {
            string rowfilter = "";
            if (cb_Verfügbar_Anz.Checked)
            {
                rowfilter = rowfilter + "Leihnummer = ''";
            }
            else
            {
                rowfilter = rowfilter + "ExemplarID IS NOT NULL";
            }
            if (rb_GREENonly.Checked)
            {
                rowfilter = rowfilter + string.Format(" AND Rückgabedatum > #{0}#", DateTime.Now.Date);
            }
            else if (rb_REDonly.Checked)
            {
                rowfilter = rowfilter + string.Format(" AND Rückgabedatum < #{0}# AND Rückgabedatum <> #{1}#", DateTime.Now.Date, DateTime.MinValue.Date);
            }
            else if (rb_YELLOWonly.Checked)
            {
                rowfilter = rowfilter + string.Format(" AND Rückgabedatum = #{0}#", DateTime.Now.Date);
            }
            (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter = (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter + " AND " + rowfilter;
        }
        private void cb_Verfügbar_Anz_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Verfügbar_Anz.Checked == true)
            {
                
                (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter = (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter.Replace("ExemplarID IS NOT NULL", string.Format("Leihnummer IS NULL"));
                if (leihListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe,red,yellow,green,listfc,listbc);
                }
                else if (rueckListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe, red, yellow, green, listfc, listbc);
                }
                else
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
                }

                //buchsuche.Show_VerfuegbareExemplare(ref gv_buchsuche);
            }
            else
            {
                (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter = (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter.Replace("Leihnummer IS NULL", string.Format("ExemplarID IS NOT NULL"));
                //buchsuche.Show_AlleExemplare(ref gv_buchsuche);
                if (leihListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
                }
                else if (rueckListe.Count != 0)
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe, red, yellow, green, listfc, listbc);
                }
                else
                {
                    buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
                }
            }
        }

        private void Ausleihvorgang(object sender, EventArgs e)
        {
            if (leihListe.Count != 0)
            {
                w_s_ausleihe Ausleihe = new w_s_ausleihe(currentUser,leihListe.ToArray(), msm_buchsuche);
                msm_buchsuche.Clone(Ausleihe);
                loadEnabled = false;
                Ausleihe.ShowDialog(this);
                loadEnabled = true;
                Ausleihe.Dispose();
                lb_liste.Text = "";
                leihListe.Clear();
                rueckgabelisteToolStripMenuItem.Enabled = true;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                w_s_ausleihe Ausleihe = new w_s_ausleihe(currentUser, msm_buchsuche);
                msm_buchsuche.Clone(Ausleihe);
                loadEnabled = false;
                Ausleihe.ShowDialog(this);
                loadEnabled = true;
                Ausleihe.Dispose();
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
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
            }
            else if (rueckListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe, red, yellow, green, listfc, listbc);
            }
            else
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
            }
        }
        bool filterActive = true;
        private void cb_Autor_Enter(object sender, EventArgs e)
        {
            if (cb_Autor.AutoCompleteSource == AutoCompleteSource.None) cb_Autor.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (cb_Autor.Text == "Autor")
            {
                filterActive = false;
                cb_Autor.Text = "";
            }
            else
            {
                filterActive = true;
            }
            cb_Autor.ForeColor = fc;
        }

        private void cb_Autor_Leave(object sender, EventArgs e)
        {
            if (cb_Autor.Text == "")
            {
                filterActive = false;
                cb_Autor.Text = "Autor";
                cb_Autor.ForeColor = Color.Gray;
            }
            else
            {
                filterActive = true;
                cb_Autor.ForeColor = fc;
            }
        }

        private void cb_Verlag_Enter(object sender, EventArgs e)
        {
            if (cb_Verlag.AutoCompleteSource == AutoCompleteSource.None) cb_Verlag.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (cb_Verlag.Text == "Verlag")
            {
                filterActive = false;
                cb_Verlag.Text = "";
            }
            else
            {
                filterActive = true;
            }
            cb_Verlag.ForeColor = fc;
        }

        private void cb_Verlag_Leave(object sender, EventArgs e)
        {
            if (cb_Verlag.Text == "")
            {
                filterActive = false;
                cb_Verlag.Text = "Verlag";
                cb_Verlag.ForeColor = Color.Gray;
            }
            else
            {
                filterActive = true;
                cb_Verlag.ForeColor = fc;
            }
        }

        private void cb_Genre_Enter(object sender, EventArgs e)
        {
            if (cb_Genre.AutoCompleteSource == AutoCompleteSource.None) cb_Genre.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (cb_Genre.Text == "Genre")
            {
                filterActive = false;
                cb_Genre.Text = "";
            }
            else
            {
                filterActive = true;
            }
            cb_Genre.ForeColor = fc;
        }

        private void cb_Genre_Leave(object sender, EventArgs e)
        {
            if (cb_Genre.Text == "")
            {
                filterActive = false;
                cb_Genre.Text = "Genre";
                cb_Genre.ForeColor = Color.Gray;
            }
            else
            {
                filterActive = true;
                cb_Genre.ForeColor = fc;
            }
        }

        private void Filter()
        {
            if (filterActive)
            {
                if (searchActivated)
                {
                    buchsuche.Execute_Search(ref gv_buchsuche, tb_ExemplarID.Text, tb_ISBN.Text, tb_Titel.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text, tb_VName.Text, tb_NName.Text, tb_Klasse.Text);

                    addRowFilter();
                    checkedChanged();
                    if (rueckListe.Count != 0)
                    {
                        buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe, red, yellow, green, listfc, listbc);
                    }
                    else
                    {
                        buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
                    }
                }
            }
            

        }
        private void tb_ExemplarID_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;
            if (tb_ExemplarID.Text.Length == 8 && _checksum_ean8(tb_ExemplarID.Text.Substring(0, 7)).ToString().Equals(tb_ExemplarID.Text.Substring(7, 1)))
            {
                tb_ExemplarID.Text = int.Parse(tb_ExemplarID.Text.Substring(0, 7)).ToString();
                ShowBuchResults();

            }
            else if (tb_ExemplarID.Text == "")
            {
                ShowBuchResults();

            }
            else
            {
                timer_input.Stop();
                timer_input.Start();

            }

        }

        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;
            timer_input.Stop();
            timer_input.Start();
        }

        private void tb_Titel_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;

            timer_input.Stop();
            timer_input.Start();
        }

        private void cb_Autor_TextChanged(object sender, EventArgs e)
        {
            if(cb_Autor.Text != "Autor")
            {
                loadEnabled = false;

                timer_input.Stop();
                timer_input.Start();
            }
        }

        private void cb_Verlag_TextChanged(object sender, EventArgs e)
        {
            if (cb_Autor.Text != "Verlag")
            {
                loadEnabled = false;

                timer_input.Stop();
                timer_input.Start();
            }
        }

        private void cb_Genre_TextChanged(object sender, EventArgs e)
        {
            if (cb_Autor.Text != "Genre")
            {
                loadEnabled = false;

                timer_input.Stop();
                timer_input.Start();
            }
        }

        private void tb_nachname_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;

            timer_input.Stop();
            timer_input.Start();
        }

        private void tb_vorname_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;

            timer_input.Stop();
            timer_input.Start();
        }

        private void tb_klasse_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;

            timer_input.Stop();
            timer_input.Start();
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
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = listfc;
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = listbc;
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
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = default;
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = default;
            }
            catch
            {

            }
        }

        private void ausleihen_Click(object sender, EventArgs e)
        {
            leih = new string[1];
            leih[0]= gv_buchsuche.SelectedRows[0].Cells["ExemplarID"].Value.ToString();
            w_s_ausleihe Ausleihe = new w_s_ausleihe(currentUser, leih, msm_buchsuche);
            msm_buchsuche.Clone(Ausleihe);
            loadEnabled = false;
            Ausleihe.ShowDialog(this);
            loadEnabled = true;
            Ausleihe.Dispose();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void gv_buchsuche_MouseDown(object sender, MouseEventArgs e)
        {
            if (new Benutzer(currentUser).Rechteid != "0")
            {
                if (!(gv_buchsuche.HitTest(e.X, e.Y).RowIndex >= 0) || !(gv_buchsuche.HitTest(e.X,e.Y).ColumnIndex >=0))
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
                    buchAnzeigenToolStripMenuItem.Visible = false;
                    kundenAnzeigenToolStripMenuItem.Visible = false;
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
                    buchAnzeigenToolStripMenuItem.Visible = true;
                    kundenAnzeigenToolStripMenuItem.Visible = true;
                }
            }
        }

        private void gv_buchsuche_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (new Benutzer(currentUser).Rechteid != "0")
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    buchAnzeigenToolStripMenuItem.Enabled = true;
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
                    if (gv_buchsuche.SelectedRows[0].Cells["Rückgabedatum"].Value.ToString().Equals("") || gv_buchsuche.SelectedRows[0].Cells["Rückgabedatum"].Value.ToString().Equals(DateTime.MinValue.ToString()))
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
                    if(!gv_buchsuche.SelectedRows[0].Cells["Kunden ID"].Value.ToString().Equals(""))
                    {
                        kundenAnzeigenToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        kundenAnzeigenToolStripMenuItem.Enabled = false;
                    }

                }
            }
        }

        private void checkedChanged()
        {
            string rowfilter = (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter;
            string[] rowFilters = rowfilter.Split(new[] { " AND Rückgabedatum" }, StringSplitOptions.None);
            rowfilter = rowFilters[0];
            (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter = rowfilter;
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
            else if (rb_allColors.Checked)
            {
                buchsuche.Show_AllColors(ref gv_buchsuche);
            }
            if (leihListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
            }
            else if (rueckListe.Count != 0)
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe, red, yellow, green, listfc, listbc);
            }
            else
            {
                buchsuche.Set_StatusMark(ref gv_buchsuche, leihListe, red, yellow, green, listfc, listbc);
            }
            gv_buchsuche.Refresh();
        }
        #endregion
        bool searchActivated = true;
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BeginInvoke((Action)delegate ()
                {
                    gb_Suche.Enabled = false;
                    gb_liste.Enabled = false;
                    metroProgressSpinner1.Visible = true;
                    metroProgressSpinner2.Visible = true;
                    try
                    {
                        //gv_buchsuche.DataSource = null;

                    }
                    catch(Exception ex)
                    {

                    }
                    cb_Autor.DataSource = null;
                    cb_Genre.DataSource = null;
                    cb_Verlag.DataSource = null;
                    gv_buchsuche.Visible = false;
                    if(cb_Autor.AutoCompleteSource != AutoCompleteSource.None) cb_Autor.AutoCompleteSource = AutoCompleteSource.None;
                    if (cb_Verlag.AutoCompleteSource != AutoCompleteSource.None) cb_Verlag.AutoCompleteSource = AutoCompleteSource.None;
                    if (cb_Genre.AutoCompleteSource != AutoCompleteSource.None) cb_Genre.AutoCompleteSource = AutoCompleteSource.None;
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
                //if (rueckListe.Count != 0)
                //{
                //    buchsuche.Set_StatusMarkNew(ref mgBuSu, ref RedBlack, ref YellowBlack, ref LimeBlack, ref BlackWhite, rueckListe);
                //}
                //else
                //{
                //    buchsuche.Set_StatusMarkNew(ref mgBuSu, ref RedBlack, ref YellowBlack, ref LimeBlack, ref BlackWhite, leihListe);
                //}
                var dtBuSu = mgBuSu.DataSource;
                while (loaded == false)
                {

                }
                BeginInvoke((Action)delegate
                {
                    gv_buchsuche.DataSource = null;
                    gv_buchsuche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    gv_buchsuche.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    gv_buchsuche.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    gv_buchsuche.AllowUserToResizeColumns = true;
                    gv_buchsuche.RowHeadersVisible = false;
                    gv_buchsuche.DataSource = dtBuSu;

                    //gv_buchsuche.Sort(gv_buchsuche.Columns[1], ListSortDirection.Descending);
                    gv_buchsuche.Columns["Kunden ID"].Visible = false;
                    gv_buchsuche.Columns["Leihnummer"].Visible = false;
                    gv_buchsuche.Columns["Kunden ID"].Visible = false;
                    gv_buchsuche.Columns["Vorname"].Visible = false;
                    gv_buchsuche.Columns["Nachname"].Visible = false;
                    gv_buchsuche.Columns["Klasse"].Visible = false;
                    searchActivated = false;
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
                    string rawFilter = string.Format("Convert([ExemplarID], System.String) LIKE '{0}%' AND ISBN LIKE '{1}%' AND Titel LIKE '%{2}%' AND Verlag LIKE '%{3}%' AND Genre LIKE '%{4}%' AND Autor LIKE '%{5}%'", "", "", "", "", "", "");
                    (gv_buchsuche.DataSource as DataTable).DefaultView.RowFilter = rawFilter;
                    addRowFilter();
                    //foreach (int i in RedBlack)
                    //{
                    //    gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = red;
                    //    gv_buchsuche.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    //}
                    //foreach (int i in YellowBlack)
                    //{
                    //    gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = yellow;
                    //    gv_buchsuche.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    //}
                    //foreach (int i in LimeBlack)
                    //{
                    //    gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = green;
                    //    gv_buchsuche.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    //}
                    //foreach (int i in BlackWhite)
                    //{
                    //    gv_buchsuche.Rows[i].DefaultCellStyle.BackColor = listbc;
                    //    gv_buchsuche.Rows[i].DefaultCellStyle.ForeColor = listfc;
                    //}
                    gv_buchsuche.Refresh();
                    searchActivated = true;
                    ShowKundeDetails();
                    metroProgressSpinner1.Visible = false;
                    metroProgressSpinner2.Visible = false;
                    gv_buchsuche.Visible = true;
                    cb_Autor.Visible = true;
                    cb_Genre.Visible = true;
                    cb_Verlag.Visible = true;
                    gb_Suche.Enabled = true;
                    gb_liste.Enabled = true;
                });
            }
            catch(Exception ex) {
                try
                {
                    BeginInvoke((Action)delegate
                    {
                        metroProgressSpinner1.Visible = false;
                        metroProgressSpinner2.Visible = false;
                        gv_buchsuche.Visible = true;
                        cb_Autor.Visible = true;
                        cb_Genre.Visible = true;
                        cb_Verlag.Visible = true;
                        MetroFramework.MetroMessageBox.Show(this, "Fehler beim Laden der Daten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
                catch
                {

                }
                }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            loaded = true;
            timer1.Stop();
        }

        private void LeihlisteAusleihenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            leih = leihListe.ToArray();
            w_s_ausleihe Ausleihe = new w_s_ausleihe(currentUser, leih, msm_buchsuche);
            StyleManager.Clone(Ausleihe);
            loadEnabled = false;
            Ausleihe.ShowDialog(this);
            loadEnabled = true;
            Ausleihe.Dispose();
            leihListe.Clear();
            lb_liste.Text = "";
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
            w_s_rueckgabe Rueckgabe = new w_s_rueckgabe(currentUser, rueck,msm_buchsuche);
            msm_buchsuche.Clone(Rueckgabe);
            loadEnabled = false;
            Rueckgabe.ShowDialog(this);
            loadEnabled = true;
            Rueckgabe.Dispose();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void Bt_rueckgabe_Click(object sender, EventArgs e)
        {
            if (rueckListe.Count != 0)
            {
                w_s_rueckgabe Rueckgabe = new w_s_rueckgabe(currentUser, rueckListe.ToArray(),msm_buchsuche);
                msm_buchsuche.Clone(Rueckgabe);
                loadEnabled = false;
                Rueckgabe.ShowDialog(this);
                loadEnabled = true;
                Rueckgabe.Dispose();
                lb_liste.Text = "";
                rueckListe.Clear();
                ausleihlisteToolStripMenuItem.Enabled = true;
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync();
                }
            }
            else
            {
                w_s_rueckgabe Rueckgabe = new w_s_rueckgabe(currentUser,msm_buchsuche);
                msm_buchsuche.Clone(Rueckgabe);
                loadEnabled = false;
                Rueckgabe.ShowDialog(this);
                loadEnabled = true;
                Rueckgabe.Dispose();
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
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = listfc;
                gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = listbc;
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
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = red;
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dt == now)
                {
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = yellow;
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.BackColor = green;
                    gv_buchsuche.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch
            {

            }
        }

        private void ZurueckgebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w_s_rueckgabe Rueckgabe = new w_s_rueckgabe(currentUser, rueckListe.ToArray(), msm_buchsuche);
            msm_buchsuche.Clone(Rueckgabe);
            loadEnabled = false;
            Rueckgabe.ShowDialog(this);
            loadEnabled = true;
            Rueckgabe.Dispose();
            rueckListe.Clear();
            lb_liste.Text = "";
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
            buchsuche.Set_StatusMark(ref gv_buchsuche, rueckListe, red, yellow, green, listfc, listbc);
            rueckgabelisteToolStripMenuItem.Enabled = true;
            ausleihlisteToolStripMenuItem.Enabled = true;
        }
        private void ClearListe()
        {

        }

        private void Rb_REDonly_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_REDonly.Checked)
            {
                checkedChanged();

            }
        }

        private void Rb_YELLOWonly_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_YELLOWonly.Checked)
            {
                checkedChanged();

            }
        }

        private void Rb_GREENonly_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_GREENonly.Checked)
            {
                checkedChanged();

            }
        }

        private void Rb_Default_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Default.Checked)
            {
                checkedChanged();

            }
        }

        private void KundenAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Kunde = new w_s_Kunden(currentUser, gv_buchsuche.SelectedRows[0].Cells["Kunden ID"].Value.ToString(), msm_buchsuche);
            loadEnabled = false;
            Kunde.ShowDialog(this);
            loadEnabled = true;
        }

        private void BuchAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Buch = new w_s_buecher(currentUser, gv_buchsuche.SelectedRows[0].Cells["ISBN"].Value.ToString(),msm_buchsuche);
            loadEnabled = false;
            Buch.ShowDialog(this);
            loadEnabled = true;
        }

        private void Gv_buchsuche_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                CM_Ausleihen.Show(gv_buchsuche.PointToScreen(gv_buchsuche.GetCellDisplayRectangle(0, gv_buchsuche.SelectedRows[0].Index, false).Location));
                e.SuppressKeyPress = true;
            }
            else if(e.KeyCode == Keys.Tab)
            {
                bt_reset.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void Cb_Autor_KeyDown(object sender, KeyEventArgs e)
        {
            filterActive = true;
    
        }

        private void Cb_Verlag_KeyDown(object sender, KeyEventArgs e)
        {
            filterActive = true;
        }

        private void Cb_Genre_KeyDown(object sender, KeyEventArgs e)
        {
            filterActive = true;
        }

        private void Cb_Autor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterActive = true;
        }

        private void Cb_Verlag_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterActive = true;
        }

        private void Cb_Genre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterActive = true;
        }

        private void MetroToolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(e.ToolTipSize.Width+32, e.ToolTipSize.Height);
        }

        private void w_s_buchsuche_Deactivate(object sender, EventArgs e)
        {
            if (cb_Autor.AutoCompleteSource != AutoCompleteSource.None) cb_Autor.AutoCompleteSource = AutoCompleteSource.None;
            if (cb_Verlag.AutoCompleteSource != AutoCompleteSource.None) cb_Verlag.AutoCompleteSource = AutoCompleteSource.None;
            if (cb_Genre.AutoCompleteSource != AutoCompleteSource.None) cb_Genre.AutoCompleteSource = AutoCompleteSource.None;
        }

        private void cb_Autor_MouseEnter(object sender, EventArgs e)
        {
            if (cb_Autor.AutoCompleteSource == AutoCompleteSource.None) cb_Autor.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Verlag_MouseEnter(object sender, EventArgs e)
        {
            if (cb_Verlag.AutoCompleteSource == AutoCompleteSource.None) cb_Verlag.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Genre_MouseEnter(object sender, EventArgs e)
        {
            if (cb_Genre.AutoCompleteSource == AutoCompleteSource.None) cb_Genre.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void timer_input_Tick(object sender, EventArgs e)
        {
            loadEnabled = true;
            Filter();
            timer_input.Stop();
        }
        private void ShowBuchResults()
        {
            #region Buchcode parsen
            if (tb_ExemplarID.Text.Length == 8)
            {
                string seven = tb_ExemplarID.Text.Substring(0, 7);
                string eight = tb_ExemplarID.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tb_ExemplarID.Text = int.Parse(seven).ToString();
                }
            }
            #endregion
            Filter();

        }
        bool loadEnabled = true;
        private void gv_buchsuche_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            SetColor(e.RowIndex);

        }
        private void SetColor(int rowIndex)
        {
            if (loadEnabled)
            {
                List<string> blackList = new List<string>();
                blackList = leihListe;
                if (leihListe.Count != 0)
                {
                    blackList = leihListe;
                }
                else if (rueckListe.Count != 0)
                {
                    blackList = rueckListe;
                }
                try
                {
                    DataGridViewRow row = gv_buchsuche.Rows[rowIndex];
                    DateTime now = DateTime.Today;
                    row.DefaultCellStyle.BackColor = default;
                    row.DefaultCellStyle.ForeColor = default;
                    if (row.Cells["Leihnummer"].Value.ToString() != "")
                    {
                        string s = row.Cells["Rückgabedatum"].Value.ToString();
                        DateTime dt = DateTime.Parse(s);
                        dt.ToShortDateString();
                        if (dt < now)
                        {
                            row.DefaultCellStyle.BackColor = red;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else if (dt == now)
                        {
                            row.DefaultCellStyle.BackColor = yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = green;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    if (blackList.Contains(row.Cells["ExemplarID"].Value.ToString()))
                    {
                        row.DefaultCellStyle.ForeColor = listfc;
                        row.DefaultCellStyle.BackColor = listbc;
                    }
                }
                catch(Exception ex)
                {

                }

            }
        }

        private void gv_buchsuche_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //SetColor(e.RowIndex);
        }

        private void rb_allColors_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_allColors.Checked)
            {
                checkedChanged();

            }
        }
    }
    
}