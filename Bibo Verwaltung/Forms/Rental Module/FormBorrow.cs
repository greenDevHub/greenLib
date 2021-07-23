using Bibo_Verwaltung.Helper;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormBorrow : MetroFramework.Forms.MetroForm
    {
        CostumerHelper costumerHelper = new CostumerHelper();
        BorrowHelper borrowHelper = new BorrowHelper();

        #region constructor
        public FormBorrow()
        {
            HandleCreated += Form1_HandleCreated;
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            this.Text = Text + AuthInfo.FormInfo();
            timer_start.Start();
        }

        public FormBorrow(string[] list)
        {
            HandleCreated += Form1_HandleCreated;
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            this.Text = Text + AuthInfo.FormInfo();
            timer_start.Start();
            borrowHelper.FillAusleihListe(list);
            borrowHelper.SetSlider(ref leihList_Slider, ref tb_listVon, ref tb_listBis);

        }
        #endregion

        private void LoadTheme()
        {
            this.StyleManager = styleManagerBorrowing;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.BorrowingStyle;
        }
        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId.Equals("0"))
            {
                bt_AddBuch.Enabled = false;
                dp_RueckDatum.Enabled = false;
                bt_NeuKunde.Enabled = false;
                tb_VName.Enabled = false;
                tb_NName.Enabled = false;
                bt_Submit.Enabled = false;
            }
            else
            {
                bt_AddBuch.Enabled = true;
                dp_RueckDatum.Enabled = true;
                bt_NeuKunde.Enabled = true;
                tb_VName.Enabled = true;
                tb_NName.Enabled = true;
                bt_Submit.Enabled = true;
            }
        }


        #region Fenster-Methoden
        /// <summary>
        /// Exemplar-Code-Parser
        /// </summary>
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

        /// <summary>
        /// Setzt das Fenster auf den Ausgangszustand zurück (alles leer)
        /// </summary>
        private void Reset_Window()
        {
            if (AuthInfo.CurrentUser.PermissionId.Equals("0"))
            {
                llb_BuchTitel.Enabled = false;
                llb_BuchTitel.Text = "keine Treffer";
                lb_BuchZustand.Enabled = false;
                lb_BuchZustand.Text = "nicht verfügbar";
                lb_BuchStatus.Enabled = false;
                lb_BuchStatus.ForeColor = Color.Black;
                lb_BuchStatus.Text = "nicht verfügbar";
                picBox_Buchcover.Image = null;
                dp_RueckDatum.Value = DateTime.Now.Date;
                tb_BuchCode.Focus();
            }
            else
            {
                llb_BuchTitel.Enabled = false;
                llb_BuchTitel.Text = "keine Treffer";
                if (!worker.IsBusy)
                {
                    worker.RunWorkerAsync();
                }
                lb_BuchZustand.Enabled = false;
                lb_BuchZustand.Text = "nicht verfügbar";
                lb_BuchStatus.Enabled = false;
                lb_BuchStatus.ForeColor = Color.Black;
                lb_BuchStatus.Text = "nicht verfügbar";
                picBox_Buchcover.Image = null;
                dp_RueckDatum.Value = DateTime.Now.Date;
                tb_BuchCode.Focus();
            }
        }

        /// <summary>
        /// Zeigt die Suchergebnisse an
        /// </summary>
        private void ShowBuchResults()
        {
            #region Buchcode parsen
            if (tb_BuchCode.Text.Length == 8)
            {
                string seven = tb_BuchCode.Text.Substring(0, 7);
                string eight = tb_BuchCode.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tb_BuchCode.Text = int.Parse(seven).ToString();
                }
            }
            #endregion

            if (tb_BuchCode.Text != "")
            {
                try
                {
                    Copy copy = new Copy(int.Parse(tb_BuchCode.Text));
                    if (copy.CopyActivated)
                    {
                        borrowHelper.Copy = copy;
                        if (borrowHelper.CheckBorrowTable())
                        {
                            borrowHelper.ReturnDate = Convert.ToDateTime(borrowHelper.BorrowTable.Rows[borrowHelper.GetIndexInLeihliste()][1]);
                            bt_AddBuch.Text = "-";
                        }
                        else
                        {
                            borrowHelper.ReturnDate = DateTime.Now.Date;
                            bt_AddBuch.Text = "+";
                        }
                        borrowHelper.IsAvailable = copy.IsAvailable();
                        llb_BuchTitel.Enabled = true;
                        llb_BuchTitel.Text = borrowHelper.TrimText(copy.CopyTitle, 30);
                        lb_BuchZustand.Enabled = true;
                        lb_BuchZustand.Text = copy.Condition.ConditionName;
                        lb_BuchStatus.Enabled = true;
                        if (borrowHelper.IsAvailable)
                        {
                            lb_BuchStatus.Text = "verfügbar";
                            lb_BuchStatus.ForeColor = Color.Green;
                            borrowHelper.Costumer = null;
                        }
                        else
                        {
                            lb_BuchStatus.Text = "nicht verfügbar (verliehen)";
                            lb_BuchStatus.ForeColor = Color.Red;
                        }
                        borrowHelper.ShowBuchCover(ref picBox_Buchcover);
                    }
                    else
                    {
                        Reset_Window();
                    }
                }
                catch
                {
                    Reset_Window();
                }
            }
            else
            {
                Reset_Window();
            }
        }

        /// <summary>
        /// Sucht einen Kunden zur Auswahl
        /// </summary>
        private void SearchKunde(string vorname, string nachname)
        {
            if (vorname == "Vorname")
            {
                vorname = "";
            }
            if (nachname == "Nachname")
            {
                nachname = "";
            }
            (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%'", vorname, nachname);
        }

        /// <summary>
        /// Führt die Buchausgabe aus
        /// </summary>
        private void Buchausgabe()
        {
            Costumer costumer = borrowHelper.Costumer;
            DialogResult dialogResult = MetroMessageBox.Show(this, borrowHelper.GetAusleihList() + "an: '" + borrowHelper.TrimText(costumer.CostumerFirstName + " " + costumer.CostumerSurname, 30) + "' wirklich ausleihen?", "Achtung",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 211 + borrowHelper.BorrowTable.Rows.Count * 17);
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    foreach (DataRow row in borrowHelper.BorrowTable.Rows)
                    {
                        borrowHelper.Execute_Ausleihe(Convert.ToInt32(row[0].ToString()), DateTime.Now.Date.ToShortDateString(), dp_RueckDatum.Value.ToShortDateString(), Convert.ToInt32(costumer.CostumerId));
                        //ausleihe.Save_Transaction(); In Bearbeitung!!!
                    }
                    MetroMessageBox.Show(this, "Die Buchausgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    borrowHelper.ClearBorrowTable();
                }
                catch
                {
                    MetroMessageBox.Show(this, "Die Buchausgabe konnte nicht abgeschlossen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                borrowHelper.SetSlider(ref leihList_Slider, ref tb_listVon, ref tb_listBis);
                tb_BuchCode.Text = "";
                tb_BuchCode.Focus();
            }
        }
        #endregion
        #region Componenten-Aktionen
        private void tb_BuchCode_TextChanged(object sender, EventArgs e)
        {
            if (tb_BuchCode.Text.Length == 8 && _checksum_ean8(tb_BuchCode.Text.Substring(0, 7)).ToString().Equals(tb_BuchCode.Text.Substring(7, 1)))
            {
                tb_BuchCode.Text = int.Parse(tb_BuchCode.Text.Substring(0, 7)).ToString();
                ShowBuchResults();

            }
            else if (tb_BuchCode.Text == "")
            {
                ShowBuchResults();

            }
            else if (borrowHelper.BorrowTable.AsEnumerable().Any(row => tb_BuchCode.Text == row.Field<String>("Column1")))
            {
                ShowBuchResults();
            }
            else
            {
                timer_input.Stop();
                timer_input.Start();

            }
        }

        private void bt_AddBuch_Click(object sender, EventArgs e)
        {
            if (llb_BuchTitel.Text != "keine Treffer")
            {
                if (tb_BuchCode.Text != "")
                {
                    if (borrowHelper.IsAvailable)
                    {
                        if (!borrowHelper.CheckBorrowTable())
                        {
                            borrowHelper.AddToAusleihList();
                            bt_AddBuch.Text = "-";
                        }
                        else
                        {
                            borrowHelper.RemoveFromAusleihList();
                            bt_AddBuch.Text = "+";
                            //if (ausleihe.LeihListe.Rows.Count > 0)
                            //{
                            //    tb_BuchCode.Text = ausleihe.LeihListe.Rows[leihList_Slider.Value - 1][0].ToString();
                            //}
                            //else
                            //{
                            //    tb_BuchCode.Text = "";
                            //}
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    borrowHelper.SetSlider(ref leihList_Slider, ref tb_listVon, ref tb_listBis);
                    tb_BuchCode.Focus();
                    tb_BuchCode.SelectAll();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Der eingegebene Buchcode ist nicht vorhanden! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void leihList_Slider_Scroll(object sender, ScrollEventArgs e)
        {
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
            tb_BuchCode.Text = borrowHelper.BorrowTable.Rows[leihList_Slider.Value - 1][0].ToString();
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }

        private void bt_NeuKunde_Click(object sender, EventArgs e)
        {
            FormCostumer Kunden = new FormCostumer();
            Kunden.ShowDialog(this);
            Kunden.Dispose();
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
        }

        private void bt_Submit_Click(object sender, EventArgs e)
        {
            if (llb_BuchTitel.Text != "keine Treffer")
            {
                if (gv_Kunde.CurrentRow != null)
                {
                    borrowHelper.Costumer = new Costumer(int.Parse(gv_Kunde.CurrentRow.Cells["Kunden-ID"].Value.ToString()));
                    if (borrowHelper.BorrowTable.Rows.Count == 0)
                    {
                        if (borrowHelper.IsAvailable)
                        {
                            borrowHelper.AddToAusleihList();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    if (borrowHelper.BorrowTable.Rows.Count != 0)
                    {
                        Buchausgabe();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Bitte wählen Sie einen Kunden aus!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Der eingegebene Buchcode ist nicht vorhanden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_BuchCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!AuthInfo.CurrentUser.PermissionId.Equals("0"))
            {
                if (e.KeyChar == (char)13)
                {
                    ShowBuchResults();
                    if (llb_BuchTitel.Text.Equals("keine Treffer"))
                    {
                        MetroMessageBox.Show(this, "Der eingegebene Buchcode ist nicht vorhanden! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (tb_BuchCode.Text != "")
                        {
                            if (borrowHelper.IsAvailable)
                            {
                                if (!borrowHelper.CheckBorrowTable())
                                {
                                    borrowHelper.AddToAusleihList();
                                    bt_AddBuch.Text = "-";
                                }
                                else
                                {
                                    borrowHelper.RemoveFromAusleihList();
                                    bt_AddBuch.Text = "+";
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            borrowHelper.SetSlider(ref leihList_Slider, ref tb_listVon, ref tb_listBis);
                            tb_BuchCode.Focus();
                            tb_BuchCode.SelectAll();
                        }
                    }
                }
            }
        }

        private void llb_BuchTitel_Click(object sender, EventArgs e)
        {
            FormInformation formBookInformation = new FormInformation(1, borrowHelper.Copy.CopyId);
            formBookInformation.ShowDialog();
            formBookInformation.Dispose();
        }

        private void llb_gesListe_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, borrowHelper.GetListInfo(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, (150 + borrowHelper.BorrowTable.Rows.Count * 15));
        }

        private void leihList_Slider_ValueChanged(object sender, EventArgs e)
        {
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
            if (borrowHelper.BorrowTable.Rows.Count > 0)
            {
                tb_BuchCode.Text = borrowHelper.BorrowTable.Rows[leihList_Slider.Value - 1][0].ToString();
            }
            else
            {
                tb_BuchCode.Text = "";
            }
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }

        private void tb_VName_TextChanged(object sender, EventArgs e)
        {
            SearchKunde(tb_VName.Text, tb_NName.Text);
        }

        private void tb_NName_TextChanged(object sender, EventArgs e)
        {
            SearchKunde(tb_VName.Text, tb_NName.Text);
        }

        private void W_s_ausleihe_Shown(object sender, EventArgs e)
        {
            tb_BuchCode.Focus();
        }

        private void Tb_listBis_TextChanged(object sender, EventArgs e)
        {
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
            if (borrowHelper.BorrowTable.Rows.Count > 0)
            {
                tb_BuchCode.Text = borrowHelper.BorrowTable.Rows[leihList_Slider.Value - 1][0].ToString();
            }
            else
            {
                tb_BuchCode.Text = "";
            }
            tb_BuchCode.Focus();
            tb_BuchCode.SelectAll();
        }
        #endregion

        private void Gv_Kunde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                bt_Submit.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void MetroToolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(e.ToolTipSize.Width + 32, e.ToolTipSize.Height);
        }

        private void timer_input_Tick(object sender, EventArgs e)
        {
            ShowBuchResults();
            timer_input.Stop();
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (handleCreated)
            {
                try
                {
                    BeginInvoke((Action)delegate ()
                    {
                        spinner.Visible = true;
                        gv_Kunde.Visible = false;
                    });
                    MetroGrid mg = new MetroGrid();
                    costumerHelper.FillGrid(ref mg);
                    var ds = mg.DataSource;
                    BeginInvoke((Action)delegate ()
                    {
                        gv_Kunde.DataSource = null;
                        gv_Kunde.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                        gv_Kunde.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                        gv_Kunde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                        gv_Kunde.DataSource = ds;
                        gv_Kunde.Refresh();
                        spinner.Visible = false;
                        gv_Kunde.Visible = true;
                    });
                }
                catch (Exception ex)
                {
                    BeginInvoke((Action)delegate ()
                    {
                        MetroMessageBox.Show(this, ex.Message + "Es trat ein Fehler beim Laden der Daten auf.", "Ladefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        spinner.Visible = false;
                        gv_Kunde.Visible = true;
                    });
                }
            }



        }
        bool handleCreated = false;
        private void Form1_HandleCreated(object sender, EventArgs e)
        {
            handleCreated = true;
            //if (!worker.IsBusy)
            //{
            //    worker.RunWorkerAsync();
            //}
        }

        private void timer_start_Tick(object sender, EventArgs e)
        {
            if (!worker.IsBusy && handleCreated)
            {
                worker.RunWorkerAsync();
            }
            timer_start.Stop();
        }
    }
}
