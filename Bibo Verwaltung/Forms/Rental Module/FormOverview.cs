using Bibo_Verwaltung.Helper;
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
    public partial class FormOverview : MetroFramework.Forms.MetroForm
    {
        bool loaded = false;
        Color red = Color.Tomato;
        Color yellow = Color.Gold;
        Color green = Color.LimeGreen;
        Color listfc = Color.White;
        Color listbc = Color.Black;
        public FormOverview()
        {
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            this.Text = Text + AuthInfo.FormInfo();
        }

        private void LoadTheme()
        {
            this.StyleManager = styleManagerOverview;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.OverviewStyle;
            if(ThemeInfo.StyleManager.Theme == MetroThemeStyle.Dark)
            {
                listfc = Color.Silver;
                listbc = Color.DimGray;
                red = Color.Firebrick;
                yellow = Color.Goldenrod;
                green = Color.OliveDrab;
            }
            cbAuthor.BackColor = ThemeInfo.BackColor;
            cbGenre.BackColor = ThemeInfo.BackColor;
            cbPublisher.BackColor = ThemeInfo.BackColor;

            lbLegendGreen.ForeColor = green;
            lbLegendRed.ForeColor = red;
            lbLegendYellow.ForeColor = yellow;
        }
        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId.Equals("0"))
            {
                tbCopyId.Enabled = false;
                tbCopyIsbn.Enabled = false;
                tbTitle.Enabled = false;
                cbAuthor.Enabled = false;
                cbPublisher.Enabled = false;
                cbGenre.Enabled = false;
                tbFirstName.Enabled = false;
                tbSurname.Enabled = false;
                tbClass.Enabled = false;
                checkShowCostumer.Enabled = false;
                checkShowAvailable.Enabled = false;
                radioShowRed.Enabled = false;
                radioShowYellow.Enabled = false;
                radioShowGreen.Enabled = false;
                radioShowAll.Enabled = false;
                btBorrow.Enabled = false;
                btReturn.Enabled = false;
                btResetList.Enabled = false;
                btClearFilter.Enabled = false;
                ausleihen.Enabled = false;
                exemplarZurückgebenToolStripMenuItem.Enabled = false;
                ausleihlisteToolStripMenuItem.Enabled = false;
                rueckgabelisteToolStripMenuItem.Enabled = false;
            }
            else
            {
                tbCopyId.Enabled = true;
                tbCopyIsbn.Enabled = true;
                tbTitle.Enabled = true;
                cbAuthor.Enabled = true;
                cbPublisher.Enabled = true;
                cbGenre.Enabled = true;
                tbFirstName.Enabled = true;
                tbSurname.Enabled = true;
                tbClass.Enabled = true;
                checkShowCostumer.Enabled = true;
                checkShowAvailable.Enabled = true;
                radioShowRed.Enabled = true;
                radioShowYellow.Enabled = true;
                radioShowGreen.Enabled = true;
                radioShowAll.Enabled = true;
                btBorrow.Enabled = true;
                btReturn.Enabled = true;
                btResetList.Enabled = true;
                btClearFilter.Enabled = true;
            }
        }

        OverviewHelper overviewHelper = new OverviewHelper();

        /// <summary>
        /// checks a code if its ean8 and converts it to a simple id
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
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

        #region Componenten-Aktionen
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            tbCopyId.Text = "";
            tbCopyIsbn.Text = "";
            tbTitle.Text = "";
            tbFirstName.Text = "";
            tbSurname.Text = "";
            tbClass.Text = "";
            cbAuthor.SelectedIndex = -1;
            cbAuthor.Text = "Autor";
            cbAuthor.ForeColor = Color.Gray;
            cbGenre.SelectedIndex = -1;
            cbGenre.Text = "Genre";
            cbGenre.ForeColor = Color.Gray;
            cbPublisher.SelectedIndex = -1;
            cbPublisher.Text = "Verlag";
            cbPublisher.ForeColor = Color.Gray;
            checkShowAvailable.Checked = false;
            checkShowCostumer.Checked = false;
            radioShowAll.Checked = true;
            overviewHelper.ShowAllCopies(ref gridOverview);
            filterActive = true;
        }

        private void ShowKundeDetails()
        {
            if (checkShowCostumer.Checked == true)
            {
                overviewHelper.ShowCostumerInformation(ref gridOverview);
            }
            else
            {
                overviewHelper.HideCostumerInformation(ref gridOverview);
            }
        }
        private void cb_KundeAnz_CheckedChanged(object sender, EventArgs e)
        {
            ShowKundeDetails();
        }
        private void addRowFilter()
        {
            string rowfilter = "";
            if (checkShowAvailable.Checked)
            {
                rowfilter = rowfilter + "Leihnummer = ''";
            }
            else
            {
                rowfilter = rowfilter + "ExemplarID IS NOT NULL";
            }
            if (radioShowGreen.Checked)
            {
                rowfilter = rowfilter + string.Format(" AND Rückgabedatum > #{0}#", DateTime.Now.Date);
            }
            else if (radioShowRed.Checked)
            {
                rowfilter = rowfilter + string.Format(" AND Rückgabedatum < #{0}# AND Rückgabedatum <> #{1}#", DateTime.Now.Date, DateTime.MinValue.Date);
            }
            else if (radioShowYellow.Checked)
            {
                rowfilter = rowfilter + string.Format(" AND Rückgabedatum = #{0}#", DateTime.Now.Date);
            }
            (gridOverview.DataSource as DataTable).DefaultView.RowFilter = (gridOverview.DataSource as DataTable).DefaultView.RowFilter + " AND " + rowfilter;
        }
        private void cb_Verfügbar_Anz_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowAvailable.Checked == true)
            {
                
                (gridOverview.DataSource as DataTable).DefaultView.RowFilter = (gridOverview.DataSource as DataTable).DefaultView.RowFilter.Replace("ExemplarID IS NOT NULL", string.Format("Leihnummer IS NULL"));
            }
            else
            {
                (gridOverview.DataSource as DataTable).DefaultView.RowFilter = (gridOverview.DataSource as DataTable).DefaultView.RowFilter.Replace("Leihnummer IS NULL", string.Format("ExemplarID IS NOT NULL"));
            }
        }

        private void Ausleihvorgang(object sender, EventArgs e)
        {
            if (leihListe.Count != 0)
            {
                FormBorrow formBorrowing = new FormBorrow(leihListe.ToArray());
                loadEnabled = false;
                formBorrowing.ShowDialog(this);
                loadEnabled = true;
                formBorrowing.Dispose();
                lbListElements.Text = "";
                leihListe.Clear();
                rueckgabelisteToolStripMenuItem.Enabled = true;
                if (!workerMain.IsBusy)
                {
                    workerMain.RunWorkerAsync();
                }
            }
            else
            {
                FormBorrow formBorrowing = new FormBorrow();
                loadEnabled = false;
                formBorrowing.ShowDialog(this);
                loadEnabled = true;
                formBorrowing.Dispose();
                if (!workerMain.IsBusy)
                {
                    workerMain.RunWorkerAsync();
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
            if (!workerMain.IsBusy)
            {
                workerMain.RunWorkerAsync();
            }
        }

        private void gv_buchsuche_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        bool filterActive = true;
        private void cb_Autor_Enter(object sender, EventArgs e)
        {
            if (cbAuthor.AutoCompleteSource == AutoCompleteSource.None) cbAuthor.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (cbAuthor.Text == "Autor")
            {
                filterActive = false;
                cbAuthor.Text = "";
            }
            else
            {
                filterActive = true;
            }
            cbAuthor.ForeColor = ThemeInfo.ForeColor;
        }

        private void cb_Autor_Leave(object sender, EventArgs e)
        {
            if (cbAuthor.Text == "")
            {
                filterActive = false;
                cbAuthor.Text = "Autor";
                cbAuthor.ForeColor = Color.Gray;
            }
            else
            {
                filterActive = true;
                cbAuthor.ForeColor = ThemeInfo.ForeColor;
            }
        }

        private void cb_Verlag_Enter(object sender, EventArgs e)
        {
            if (cbPublisher.AutoCompleteSource == AutoCompleteSource.None) cbPublisher.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (cbPublisher.Text == "Verlag")
            {
                filterActive = false;
                cbPublisher.Text = "";
            }
            else
            {
                filterActive = true;
            }
            cbPublisher.ForeColor = ThemeInfo.ForeColor;
        }

        private void cb_Verlag_Leave(object sender, EventArgs e)
        {
            if (cbPublisher.Text == "")
            {
                filterActive = false;
                cbPublisher.Text = "Verlag";
                cbPublisher.ForeColor = Color.Gray;
            }
            else
            {
                filterActive = true;
                cbPublisher.ForeColor = ThemeInfo.ForeColor;
            }
        }

        private void cb_Genre_Enter(object sender, EventArgs e)
        {
            if (cbGenre.AutoCompleteSource == AutoCompleteSource.None) cbGenre.AutoCompleteSource = AutoCompleteSource.ListItems;

            if (cbGenre.Text == "Genre")
            {
                filterActive = false;
                cbGenre.Text = "";
            }
            else
            {
                filterActive = true;
            }
            cbGenre.ForeColor = ThemeInfo.ForeColor;
        }

        private void cb_Genre_Leave(object sender, EventArgs e)
        {
            if (cbGenre.Text == "")
            {
                filterActive = false;
                cbGenre.Text = "Genre";
                cbGenre.ForeColor = Color.Gray;
            }
            else
            {
                filterActive = true;
                cbGenre.ForeColor = ThemeInfo.ForeColor;
            }
        }

        private void Filter()
        {
            if (filterActive)
            {
                if (searchActivated)
                {
                    overviewHelper.ExecuteSearch(ref gridOverview, tbCopyId.Text, tbCopyIsbn.Text, tbTitle.Text, cbAuthor.Text, cbPublisher.Text, cbGenre.Text, tbFirstName.Text, tbSurname.Text, tbClass.Text);

                    addRowFilter();
                    checkedChanged();
                }
            }
            

        }
        private void tb_ExemplarID_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;
            if (tbCopyId.Text.Length == 8 && _checksum_ean8(tbCopyId.Text.Substring(0, 7)).ToString().Equals(tbCopyId.Text.Substring(7, 1)))
            {
                tbCopyId.Text = int.Parse(tbCopyId.Text.Substring(0, 7)).ToString();
                ShowBuchResults();

            }
            else if (tbCopyId.Text == "")
            {
                ShowBuchResults();

            }
            else
            {
                timerKeyInput.Stop();
                timerKeyInput.Start();

            }

        }

        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;
            timerKeyInput.Stop();
            timerKeyInput.Start();
        }

        private void tb_Titel_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;

            timerKeyInput.Stop();
            timerKeyInput.Start();
        }

        private void cb_Autor_TextChanged(object sender, EventArgs e)
        {
            if(cbAuthor.Text != "Autor")
            {
                loadEnabled = false;

                timerKeyInput.Stop();
                timerKeyInput.Start();
            }
        }

        private void cb_Verlag_TextChanged(object sender, EventArgs e)
        {
            if (cbAuthor.Text != "Verlag")
            {
                loadEnabled = false;

                timerKeyInput.Stop();
                timerKeyInput.Start();
            }
        }

        private void cb_Genre_TextChanged(object sender, EventArgs e)
        {
            if (cbAuthor.Text != "Genre")
            {
                loadEnabled = false;

                timerKeyInput.Stop();
                timerKeyInput.Start();
            }
        }

        private void tb_nachname_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;

            timerKeyInput.Stop();
            timerKeyInput.Start();
        }

        private void tb_vorname_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;

            timerKeyInput.Stop();
            timerKeyInput.Start();
        }

        private void tb_klasse_TextChanged(object sender, EventArgs e)
        {
            loadEnabled = false;

            timerKeyInput.Stop();
            timerKeyInput.Start();
        }
        List<string> leihListe = new List<string>();
        List<string> rueckListe = new List<string>();
        //TODO
        private void addToLeihList_Click(object sender, EventArgs e)
        {
            try
            {
                leihListe.Add(gridOverview.SelectedRows[0].Cells["ExemplarID"].Value.ToString());
                lbListElements.Text = "";
                foreach (string s in leihListe)
                {
                    lbListElements.Text = lbListElements.Text + s + "; ";
                }
                lbListElements.Text = lbListElements.Text.Trim().TrimEnd(';');
                gridOverview.SelectedRows[0].DefaultCellStyle.ForeColor = listfc;
                gridOverview.SelectedRows[0].DefaultCellStyle.BackColor = listbc;
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
                leihListe.Remove(gridOverview.SelectedRows[0].Cells["ExemplarID"].Value.ToString());
                lbListElements.Text = "";
                foreach (string s in leihListe)
                {
                    lbListElements.Text = lbListElements.Text + s + "; ";
                }
                lbListElements.Text = lbListElements.Text.Trim().TrimEnd(';');
                if (leihListe.Count == 0)
                {
                    ausleihenToolStripMenuItem.Enabled = false;
                    entfernenToolStripMenuItem.Enabled = false;

                    rueckgabelisteToolStripMenuItem.Enabled = true;
                }
                gridOverview.SelectedRows[0].DefaultCellStyle.ForeColor = default;
                gridOverview.SelectedRows[0].DefaultCellStyle.BackColor = default;
            }
            catch
            {

            }
        }

        private void ausleihen_Click(object sender, EventArgs e)
        {
            string[] borrow = new string[1];
            borrow[0]= gridOverview.SelectedRows[0].Cells["ExemplarID"].Value.ToString();
            FormBorrow formBorrowing = new FormBorrow(borrow);
            loadEnabled = false;
            formBorrowing.ShowDialog(this);
            loadEnabled = true;
            formBorrowing.Dispose();
            if (!workerMain.IsBusy)
            {
                workerMain.RunWorkerAsync();
            }
        }

        private void gv_buchsuche_MouseDown(object sender, MouseEventArgs e)
        {
            if (AuthInfo.CurrentUser.PermissionId != 0)
            {
                if (!(gridOverview.HitTest(e.X, e.Y).RowIndex >= 0) || !(gridOverview.HitTest(e.X,e.Y).ColumnIndex >=0))
                {
                    gridOverview.ClearSelection();
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
            if (AuthInfo.CurrentUser.PermissionId != 0)
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    buchAnzeigenToolStripMenuItem.Enabled = true;
                    if (!gridOverview.Rows[e.RowIndex].Selected)
                    {
                        gridOverview.ClearSelection();
                        gridOverview.Rows[e.RowIndex].Selected = true;
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
                    if (gridOverview.SelectedRows[0].Cells["Rückgabedatum"].Value.ToString().Equals("") || gridOverview.SelectedRows[0].Cells["Rückgabedatum"].Value.ToString().Equals(DateTime.MinValue.ToString()))
                    {
                        entfernenToolStripMenuItem1.Enabled = false;
                        hinzufügenToolStripMenuItem1.Enabled = false;
                        if (leihListe.Contains(gridOverview.SelectedRows[0].Cells["ExemplarID"].Value.ToString()))
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
                        if (rueckListe.Contains(gridOverview.SelectedRows[0].Cells["ExemplarID"].Value.ToString()))
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
                    if(!gridOverview.SelectedRows[0].Cells["Kunden ID"].Value.ToString().Equals(""))
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
            string rowfilter = (gridOverview.DataSource as DataTable).DefaultView.RowFilter;
            string[] rowFilters = rowfilter.Split(new[] { " AND Rückgabedatum" }, StringSplitOptions.None);
            rowfilter = rowFilters[0];
            (gridOverview.DataSource as DataTable).DefaultView.RowFilter = rowfilter;
            if (radioShowGreen.Checked)
            {
                overviewHelper.ShowGreenCopies(ref gridOverview);
            }
            else if (radioShowYellow.Checked)
            {
                overviewHelper.ShowYellowCopies(ref gridOverview);
            }
            else if (radioShowRed.Checked)
            {
                overviewHelper.ShowRedCopies(ref gridOverview);
            }
            else if (radioShowBorrowed.Checked)
            {
                overviewHelper.ShowBorrowedCopies(ref gridOverview);
            }
            gridOverview.Refresh();
        }
        #endregion
        bool searchActivated = true;
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BeginInvoke((Action)delegate ()
                {
                    groupMain.Enabled = false;
                    groupList.Enabled = false;
                    spinnerGridView.Visible = true;
                    spinnerAttributes.Visible = true;
                    cbAuthor.DataSource = null;
                    this.cbGenre.DataSource = null;
                    cbPublisher.DataSource = null;
                    gridOverview.Visible = false;
                    if(cbAuthor.AutoCompleteSource != AutoCompleteSource.None) cbAuthor.AutoCompleteSource = AutoCompleteSource.None;
                    if (cbPublisher.AutoCompleteSource != AutoCompleteSource.None) cbPublisher.AutoCompleteSource = AutoCompleteSource.None;
                    if (this.cbGenre.AutoCompleteSource != AutoCompleteSource.None) this.cbGenre.AutoCompleteSource = AutoCompleteSource.None;
                    cbAuthor.Visible = false;
                    this.cbGenre.Visible = false;
                    cbPublisher.Visible = false;
                });
                MetroGrid mgBuSu = new MetroGrid();
                AdvancedComboBox cbAutor = new AdvancedComboBox();
                AdvancedComboBox cbVerlag = new AdvancedComboBox();
                AdvancedComboBox cbGenre = new AdvancedComboBox();
                List<int> RedBlack = new List<int>();
                List<int> YellowBlack = new List<int>();
                List<int> LimeBlack = new List<int>();
                List<int> BlackWhite = new List<int>();
                overviewHelper = new OverviewHelper();
                overviewHelper.FillComboBoxes(ref cbAutor, ref cbVerlag, ref cbGenre);
                overviewHelper.FillGrid(ref mgBuSu);
                var dtBuSu = mgBuSu.DataSource;
                while (loaded == false)
                {

                }
                BeginInvoke((Action)delegate
                {
                    gridOverview.DataSource = null;
                    gridOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    gridOverview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    gridOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    gridOverview.AllowUserToResizeColumns = true;
                    gridOverview.RowHeadersVisible = false;
                    gridOverview.DataSource = dtBuSu;

                    gridOverview.Columns["Kunden ID"].Visible = false;
                    gridOverview.Columns["Leihnummer"].Visible = false;
                    gridOverview.Columns["Kunden ID"].Visible = false;
                    gridOverview.Columns["Vorname"].Visible = false;
                    gridOverview.Columns["Nachname"].Visible = false;
                    gridOverview.Columns["Klasse"].Visible = false;
                    searchActivated = false;
                    cbAuthor.DataSource = cbAutor.DataSource;
                    cbAuthor.ValueMember = "au_id";
                    cbAuthor.DisplayMember = "au_autor";
                    cbAuthor.SelectedIndex = -1;
                    cbPublisher.DataSource = cbVerlag.DataSource;
                    cbPublisher.ValueMember = "ver_id";
                    cbPublisher.DisplayMember = "ver_name";
                    cbPublisher.SelectedIndex = -1;
                    this.cbGenre.DataSource = cbGenre.DataSource;
                    this.cbGenre.ValueMember = "ger_id";
                    this.cbGenre.DisplayMember = "ger_name";
                    this.cbGenre.SelectedIndex = -1;
                    if (cbAuthor.Text == "")
                    {
                        cbAuthor.Text = "Autor";
                    }
                    if (cbPublisher.Text == "")
                    {
                        cbPublisher.Text = "Verlag";
                    }
                    if (this.cbGenre.Text == "")
                    {
                        this.cbGenre.Text = "Genre";
                    }
                    string rawFilter = string.Format("Convert([ExemplarID], System.String) LIKE '{0}%' AND ISBN LIKE '{1}%' AND Titel LIKE '%{2}%' AND Verlag LIKE '%{3}%' AND Genre LIKE '%{4}%' AND Autor LIKE '%{5}%'", "", "", "", "", "", "");
                    (gridOverview.DataSource as DataTable).DefaultView.RowFilter = rawFilter;
                    addRowFilter();
                    gridOverview.Refresh();
                    searchActivated = true;
                    ShowKundeDetails();
                    spinnerGridView.Visible = false;
                    spinnerAttributes.Visible = false;
                    gridOverview.Visible = true;
                    cbAuthor.Visible = true;
                    this.cbGenre.Visible = true;
                    cbPublisher.Visible = true;
                    groupMain.Enabled = true;
                    groupList.Enabled = true;
                });
            }
            catch(Exception ex) {
                try
                {
                    BeginInvoke((Action)delegate
                    {
                        spinnerGridView.Visible = false;
                        spinnerAttributes.Visible = false;
                        gridOverview.Visible = true;
                        cbAuthor.Visible = true;
                        cbGenre.Visible = true;
                        cbPublisher.Visible = true;
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
            string[] borrow = leihListe.ToArray();
            FormBorrow formBorrowing = new FormBorrow(borrow);
            loadEnabled = false;
            formBorrowing.ShowDialog(this);
            loadEnabled = true;
            formBorrowing.Dispose();
            leihListe.Clear();
            lbListElements.Text = "";
            rueckgabelisteToolStripMenuItem.Enabled = true;
            if (!workerMain.IsBusy)
            {
                workerMain.RunWorkerAsync();
            }
        }

        private void ExemplarZurückgebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] rueck = new string[1];
            rueck[0] = gridOverview.SelectedRows[0].Cells["ExemplarID"].Value.ToString();
            FormReturn formReturn = new FormReturn(rueck);
            loadEnabled = false;
            formReturn.ShowDialog(this);
            loadEnabled = true;
            formReturn.Dispose();
            if (!workerMain.IsBusy)
            {
                workerMain.RunWorkerAsync();
            }
        }

        private void Bt_rueckgabe_Click(object sender, EventArgs e)
        {
            if (rueckListe.Count != 0)
            {
                FormReturn formReturn = new FormReturn(rueckListe.ToArray());
                styleManagerOverview.Clone(formReturn);
                loadEnabled = false;
                formReturn.ShowDialog(this);
                loadEnabled = true;
                formReturn.Dispose();
                lbListElements.Text = "";
                rueckListe.Clear();
                ausleihlisteToolStripMenuItem.Enabled = true;
                if (!workerMain.IsBusy)
                {
                    workerMain.RunWorkerAsync();
                }
            }
            else
            {
                FormReturn formReturn = new FormReturn();
                loadEnabled = false;
                formReturn.ShowDialog(this);
                loadEnabled = true;
                formReturn.Dispose();
                if (!workerMain.IsBusy)
                {
                    workerMain.RunWorkerAsync();
                }
            }
        }

        private void HinzufügenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                rueckListe.Add(gridOverview.SelectedRows[0].Cells["ExemplarID"].Value.ToString());
                lbListElements.Text = "";
                foreach (string s in rueckListe)
                {
                    lbListElements.Text = lbListElements.Text + s + "; ";
                }
                lbListElements.Text = lbListElements.Text.Trim().TrimEnd(';');
                gridOverview.SelectedRows[0].DefaultCellStyle.ForeColor = listfc;
                gridOverview.SelectedRows[0].DefaultCellStyle.BackColor = listbc;
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
                rueckListe.Remove(gridOverview.SelectedRows[0].Cells["ExemplarID"].Value.ToString());
                lbListElements.Text = "";
                foreach (string s in rueckListe)
                {
                    lbListElements.Text = lbListElements.Text + s + "; ";
                }
                lbListElements.Text = lbListElements.Text.Trim().TrimEnd(';');
                if (rueckListe.Count == 0)
                {
                    zurueckgebenToolStripMenuItem.Enabled = false;
                    entfernenToolStripMenuItem1.Enabled = false;
                    ausleihlisteToolStripMenuItem.Enabled = true;

                }
                DateTime now = DateTime.Today;
                DateTime dt = new DateTime();
                dt = DateTime.Parse(gridOverview.SelectedRows[0].Cells["Rückgabedatum"].Value.ToString());
                if (dt < now)
                {
                    gridOverview.SelectedRows[0].DefaultCellStyle.BackColor = red;
                    gridOverview.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (dt == now)
                {
                    gridOverview.SelectedRows[0].DefaultCellStyle.BackColor = yellow;
                    gridOverview.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    gridOverview.SelectedRows[0].DefaultCellStyle.BackColor = green;
                    gridOverview.SelectedRows[0].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch
            {

            }
        }

        private void ZurueckgebenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReturn formReturn = new FormReturn(rueckListe.ToArray());
            loadEnabled = false;
            formReturn.ShowDialog(this);
            loadEnabled = true;
            formReturn.Dispose();
            rueckListe.Clear();
            lbListElements.Text = "";
            ausleihlisteToolStripMenuItem.Enabled = true;
            if (!workerMain.IsBusy)
            {
                workerMain.RunWorkerAsync();
            }
        }

        private void Bt_reset_Click(object sender, EventArgs e)
        {
            rueckListe.Clear();
            leihListe.Clear();
            lbListElements.Text = "";
            rueckgabelisteToolStripMenuItem.Enabled = true;
            ausleihlisteToolStripMenuItem.Enabled = true;
        }

        private void Rb_REDonly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioShowRed.Checked)
            {
                checkedChanged();

            }
        }

        private void Rb_YELLOWonly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioShowYellow.Checked)
            {
                checkedChanged();

            }
        }

        private void Rb_GREENonly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioShowGreen.Checked)
            {
                checkedChanged();

            }
        }

        private void Rb_Default_CheckedChanged(object sender, EventArgs e)
        {
            if (radioShowAll.Checked)
            {
                checkedChanged();

            }
        }

        private void KundenAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formCostumer = new FormCostumer(int.Parse(gridOverview.SelectedRows[0].Cells["Kunden ID"].Value.ToString()));
            loadEnabled = false;
            formCostumer.ShowDialog(this);
            loadEnabled = true;
        }

        private void BuchAnzeigenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Buch = new Form_Books(gridOverview.SelectedRows[0].Cells["ISBN"].Value.ToString());
            loadEnabled = false;
            Buch.ShowDialog(this);
            loadEnabled = true;
        }

        private void Gv_buchsuche_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                contextMenuBorrow.Show(gridOverview.PointToScreen(gridOverview.GetCellDisplayRectangle(0, gridOverview.SelectedRows[0].Index, false).Location));
                e.SuppressKeyPress = true;
            }
            else if(e.KeyCode == Keys.Tab)
            {
                btResetList.Select();
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
            if (cbAuthor.AutoCompleteSource != AutoCompleteSource.None) cbAuthor.AutoCompleteSource = AutoCompleteSource.None;
            if (cbPublisher.AutoCompleteSource != AutoCompleteSource.None) cbPublisher.AutoCompleteSource = AutoCompleteSource.None;
            if (cbGenre.AutoCompleteSource != AutoCompleteSource.None) cbGenre.AutoCompleteSource = AutoCompleteSource.None;
        }

        private void cb_Autor_MouseEnter(object sender, EventArgs e)
        {
            if (cbAuthor.AutoCompleteSource == AutoCompleteSource.None) cbAuthor.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Verlag_MouseEnter(object sender, EventArgs e)
        {
            if (cbPublisher.AutoCompleteSource == AutoCompleteSource.None) cbPublisher.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void cb_Genre_MouseEnter(object sender, EventArgs e)
        {
            if (cbGenre.AutoCompleteSource == AutoCompleteSource.None) cbGenre.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        private void timer_input_Tick(object sender, EventArgs e)
        {
            loadEnabled = true;
            Filter();
            timerKeyInput.Stop();
        }
        private void ShowBuchResults()
        {
            #region Buchcode parsen
            if (tbCopyId.Text.Length == 8)
            {
                string seven = tbCopyId.Text.Substring(0, 7);
                string eight = tbCopyId.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tbCopyId.Text = int.Parse(seven).ToString();
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
                    DataGridViewRow row = gridOverview.Rows[rowIndex];
                    DateTime now = DateTime.Today;
                    row.DefaultCellStyle.BackColor = default;
                    row.DefaultCellStyle.ForeColor = default;
                    row.DefaultCellStyle.SelectionBackColor = default;
                    if (row.Cells["Leihnummer"].Value.ToString() != "")
                    {
                        string s = row.Cells["Rückgabedatum"].Value.ToString();
                        DateTime dt = DateTime.Parse(s);
                        dt.ToShortDateString();
                        if (dt < now)
                        {
                            row.DefaultCellStyle.BackColor = red;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.SelectionBackColor = Color.Red;

                        }
                        else if (dt == now)
                        {
                            row.DefaultCellStyle.BackColor = yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.SelectionBackColor = Color.Yellow;

                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = green;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                            row.DefaultCellStyle.SelectionBackColor = Color.Lime;

                        }
                    }
                    if (blackList.Contains(row.Cells["ExemplarID"].Value.ToString()))
                    {
                        row.DefaultCellStyle.ForeColor = listfc;
                        row.DefaultCellStyle.BackColor = listbc;
                        row.DefaultCellStyle.SelectionBackColor = Color.DimGray;
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
            if (radioShowBorrowed.Checked)
            {
                checkedChanged();

            }
        }
    }
    
}