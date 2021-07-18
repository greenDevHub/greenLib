using Bibo_Verwaltung.Helper;
using MetroFramework;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormAutoReturn : MetroFramework.Forms.MetroForm
    {
        CostumerHelper costumerHelper = new CostumerHelper();
        SchoolClassHelper schoolClassHelper = new SchoolClassHelper();
        #region Constructor
        public FormAutoReturn()
        {
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            this.Text = Text + AuthInfo.FormInfo();

            a_cb_Modus.SelectedIndex = 0;
            bt_bestaetigen.Text = "Schüler laden";
            inRueckAction = false;
        }
        #endregion
        private void LoadTheme()
        {
            this.StyleManager = stylemManagerAutoReturn;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.AutoReturnStyle;
            a_cb_Klasse.ForeColor = ThemeInfo.ForeColor;
            a_cb_Klasse.BackColor = ThemeInfo.BackColor;
            a_cb_Modus.ForeColor = ThemeInfo.ForeColor;
            a_cb_Modus.BackColor = ThemeInfo.BackColor;

        }

        private void SetPermissions()
        {
            bool isNoGuest = !AuthInfo.CurrentUser.PermissionId.Equals("0");
            a_cb_Modus.TabStop = isNoGuest;
            p_modus.Visible = !isNoGuest;
            a_cb_Klasse.TabStop = isNoGuest;
            p_klasse.Visible = !isNoGuest;
            bt_bestaetigen.Enabled = isNoGuest;

        }

        ConditionHelper conditionHelper = new ConditionHelper();


        ReturnHelper returnHelper = new ReturnHelper();
        DataTable selectedBuecher = new DataTable();
        bool inRueckAction;

        #region Fenster-Methoden
        /// <summary>
        /// Exemplar-Code-Parser
        /// </summary>
        static int ParseBuchcode(String data)
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

        private void MarkSchueler()
        {
            foreach (DataGridViewRow costumerRow in gv_Schueler.Rows)
            {
                Costumer costumer = new Costumer();
                costumer.CostumerId = Convert.ToInt32(costumerRow.Cells["kunde_ID"].Value);
                if (costumer.HasBorrowedSomething())
                {
                    costumerRow.DefaultCellStyle.SelectionBackColor = default;
                    costumerRow.DefaultCellStyle.SelectionForeColor = default;
                    costumerRow.DefaultCellStyle.BackColor = default;
                    costumerRow.DefaultCellStyle.ForeColor = default;
                }
                else
                {
                    costumerRow.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
                    costumerRow.DefaultCellStyle.SelectionForeColor = Color.Black;
                    costumerRow.DefaultCellStyle.BackColor = Color.LimeGreen;
                    costumerRow.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Setzt die Form auf den Ausgangszustang zurück
        /// </summary>
        private void EndAusgabe()
        {
            inRueckAction = false;
            tb_ExemplarID.Enabled = false;
            bt_bestaetigen.Text = "Schüler laden";
            tb_ExemplarID.Text = "";
            a_cb_Modus.TabStop = true;
            p_modus.Visible = false;
            a_cb_Klasse.TabStop = true;
            p_klasse.Visible = false;
            bt_back.Enabled = false;
            bt_next.Enabled = false;
            gv_suggested.Enabled = false;
            gv_selected.Enabled = false;
            bt_abschließen.Enabled = false;
            gv_suggested.DataSource = null;
            gv_Schueler.DataSource = null;
            gv_selected.DataSource = null;
            lbProgress.Visible = false;
            gv_selected.Columns.Clear();
            returnHelper.ClearRueckList();
            selectedBuecher.Rows.Clear();
        }

       

        /// <summary>
        /// Prüft ob alle Schüler der aktuellen Auswahl ihnre Schulbücher erfolgreich erhalten haben
        /// </summary>
        private bool IsComplete(ref MetroFramework.Controls.MetroGrid grid)
        {
            bool result = true;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                if (grid.Rows[i].DefaultCellStyle.BackColor != Color.LimeGreen)
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }

        /// <summary>
        /// Prüft die aktuelle Auswahl auf Vorhandensein einiger Einträge (Anhand der BackColor)
        /// </summary>
        private bool IsNotEmpty(ref MetroFramework.Controls.MetroGrid grid)
        {
            if (grid.RowCount != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Lädt die Schulbücher für den gewählte Schüler
        /// </summary>
        private void LoadRueckBuecher()
        {
            try
            {
                if (gv_Schueler.CurrentRow != null)
                {
                    DataGridViewRow row = gv_Schueler.Rows[gv_Schueler.CurrentRow.Index];
                    returnHelper.Costumer = new Costumer(int.Parse(row.Cells["kunde_ID"].Value.ToString()));
                    returnHelper.FillGrid(ref gv_suggested);
                    gv_suggested.ClearSelection();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Laden der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gibt den Row-Index der ExemplarID in der Buchausleihliste wieder
        /// </summary>
        public int GetIndexInLeihBuecher()
        {
            int result = -1;
            for (int i = 0; i <= gv_suggested.Rows.Count - 1; i++)
            {
                if (gv_suggested.Rows[i].Cells["ID"].Value.ToString() == tb_ExemplarID.Text)
                {
                    result = i;
                }
            }
            return result;
        }

        /// <summary>
        /// Nimmt ein Exemplar in die Ausleihliste auf
        /// </summary>
        private void SelectExemplar()
        {
            try
            {
                returnHelper.AddToRueckgabeList();
                for (int i = 0; i < selectedBuecher.Rows.Count; i++)
                {
                    if (selectedBuecher.Rows[i]["ID"].ToString() == returnHelper.ReturnDataTable.Rows[returnHelper.GetIndexInRueckliste()][0].ToString())
                    {
                        i = 0;
                        UnSelectExemplar();
                    }
                }
                DataRow relation;
                string[] exemlarDetails = new string[3];
                exemlarDetails[0] = returnHelper.Copy.CopyId.ToString();
                exemlarDetails[1] = returnHelper.StartCondition.ConditionName;
                exemlarDetails[2] = returnHelper.Copy.CopyTitle;
                relation = selectedBuecher.NewRow();
                relation.ItemArray = exemlarDetails;
                selectedBuecher.Rows.Add(relation);
            }
            catch { }
        }

        /// <summary>
        /// Entfernt ein Exemplar aus der Ausleihliste
        /// </summary>
        private void UnSelectExemplar()
        {
            returnHelper.RemoveFromRueckgabeList();
            try
            {
                for (int i = selectedBuecher.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = selectedBuecher.Rows[i];
                    if (row[0].ToString() == tb_ExemplarID.Text)
                        row.Delete();
                }
                selectedBuecher.AcceptChanges();
            }
            catch { }
        }

        /// <summary>
        /// Prüft ob bei allen Exemplaren in der DataGridView der IstZustands-ComboBox-Wert gestetz wurde (False bei Default-Wert ausgewählt)
        /// </summary>
        private bool CheckIstZustaende()
        {
            bool result = true;
            for (int i = 0; i < selectedBuecher.Rows.Count; i++)
            {
                DataGridViewRow row = gv_selected.Rows[i];
                string istzustand = row.Cells["cbzustand"].Value.ToString();
                if ((istzustand == null) || (istzustand == "0"))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        #endregion

        #region Componenten-Aktionen
        private void A_cb_Modus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a_cb_Modus.SelectedIndex == 0)
            {
                a_cb_Klasse.DataSource = null;
                a_cb_Klasse.Sorted = true;
                lb_Klasse.Text = "Klasse:";
                lb_Klasse.Visible = true;
                schoolClassHelper.FillCombobox(ref a_cb_Klasse, 1, AutoCompleteSource.ListItems);
                a_cb_Klasse.Visible = true;
                a_cb_Klasse.TabStop = true;
                p_klasse.Visible = false;
            }
            else
            {
                a_cb_Klasse.Sorted = false;
                lb_Klasse.Text = "Stufe:";
                lb_Klasse.Visible = true;
                DataTable stufen = new DataTable();
                stufen.Columns.Add("Index");
                stufen.Columns.Add("Klassenstufe");
                for (int i = 1; i <= 13; i++)
                {
                    stufen.Rows.Add();
                    stufen.Rows[i - 1][0] = i.ToString();
                    stufen.Rows[i - 1][1] = "Klassenstufe " + i.ToString();
                }
                a_cb_Klasse.DataSource = stufen;
                a_cb_Klasse.ValueMember = "Index";
                a_cb_Klasse.DisplayMember = "Klassenstufe";
                a_cb_Klasse.SelectedItem = 0;
                a_cb_Klasse.Visible = true;
                a_cb_Klasse.TabStop = true;
                p_klasse.Visible = false;
            }
        }

        private void Bt_bestaetigen_Click(object sender, EventArgs e)
        {
            if (!inRueckAction)
            {
                if (a_cb_Modus.SelectedIndex != -1 && a_cb_Klasse.SelectedIndex != -1)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    inRueckAction = true;
                    bt_bestaetigen.Text = "Rückgabe beenden";
                    a_cb_Modus.TabStop = false;
                    p_modus.Visible = true;
                    a_cb_Klasse.TabStop = false;
                    p_klasse.Visible = true;
                    bt_back.Enabled = true;
                    bt_next.Enabled = true;
                    //gv_suggested.Enabled = true;
                    gv_selected.Enabled = true;
                    bt_abschließen.Enabled = true;
                    if (a_cb_Modus.SelectedIndex == 0)
                    {
                        costumerHelper.FillCostumerGrid(ref gv_Schueler, false, schoolClassHelper.FindIdByName(a_cb_Klasse.Text));
                    }
                    else
                    {
                        costumerHelper.FillCostumerGrid(ref gv_Schueler, true, Convert.ToInt32(a_cb_Klasse.Text.Substring(13)));
                    }
                    if (gv_Schueler.Rows.Count != 0)
                    {
                        gv_Schueler.CurrentCell = gv_Schueler.Rows[0].Cells[1];
                        gv_Schueler.Rows[0].Selected = true;
                        MarkSchueler();
                        tb_ExemplarID.Enabled = true;
                        tb_ExemplarID.Focus();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Es gibt keine Schüler in dieser Klasse bzw. Klassenstufe. Die Rückgabe wird beendet!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EndAusgabe();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Wählen Sie den Rückgabe-Modus und eine Klasse bzw. eine Klassenstufe aus!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                EndAusgabe();
            }
            Cursor.Current = Cursors.Default;
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            SelectPreviousRow();
        }

        private void Bt_next_Click(object sender, EventArgs e)
        {
            SelectNextRow();
        }
        private bool HasUnsavedChanges()
        {
            if (returnHelper.ReturnDataTable.Rows.Count != 0)
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Sie haben die eingegebenen Exemplare noch nicht zurückgegeben. Wenn Sie fortfahren, werden diese Exemplare verworfen. Trotzdem fortfahren?", "Weiter?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No) return true;
            }
            return false;
        }

        private void SelectNextRow()
        {
            if (HasUnsavedChanges()) return;
            int rowIndex = gv_Schueler.CurrentCell.RowIndex;
            int colIndex = gv_Schueler.CurrentCell.ColumnIndex;
            if (IsComplete(ref gv_Schueler) || gv_Schueler.CurrentCell.RowIndex == gv_Schueler.RowCount - 1)
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Sie sind am Ende der Schülerliste angekommen. Möchten Sie die Lehrbuch-Ausgabe abschließen?", "Information",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    EndAusgabe();
                }
                else
                {
                    gv_Schueler.ClearSelection();
                }
                return;
            }
            gv_Schueler.CurrentCell = gv_Schueler.Rows[rowIndex + 1].Cells[colIndex];

        }
        private void SelectPreviousRow()
        {
            if (HasUnsavedChanges()) return;
            int rowIndex = gv_Schueler.CurrentCell.RowIndex;
            int colIndex = gv_Schueler.CurrentCell.ColumnIndex;
            if (rowIndex == 0) return;
            gv_Schueler.CurrentCell = gv_Schueler.Rows[rowIndex - 1].Cells[colIndex];
        }
        private void Bt_abschließen_Click(object sender, EventArgs e)
        {
            if (returnHelper.ReturnDataTable.Rows.Count != 0)
            {
                returnHelper.Costumer = new Costumer(int.Parse(gv_Schueler.CurrentRow.Cells["kunde_ID"].Value.ToString()));
                DialogResult dialogResult = MetroMessageBox.Show(this, returnHelper.GetRueckgabeList() + "an: '" + returnHelper.TrimText(returnHelper.Costumer.CostumerFirstName + " " + returnHelper.Costumer.CostumerSurname, 30) + "' wirklich zurücknehmen?", "Achtung",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, 211 + returnHelper.ReturnDataTable.Rows.Count * 17);
                if (dialogResult == DialogResult.OK)
                {
                    DataGridViewRow Kundenrow = gv_Schueler.CurrentRow;
                    if (CheckIstZustaende())
                    {
                        try
                        {
                            for (int i = 0; i < selectedBuecher.Rows.Count; i++)
                            {
                                returnHelper.Copy = new Copy(int.Parse(selectedBuecher.Rows[i]["ID"].ToString()));
                                returnHelper.ReturnDataTable.Rows[returnHelper.GetIndexInRueckliste()][2] = gv_selected.Rows[i].Cells["cbzustand"].Value.ToString();
                            }
                            foreach (DataRow row in returnHelper.ReturnDataTable.Rows)
                            {
                                Condition condition = new Condition(int.Parse(row[2].ToString()));
                                returnHelper.LoadInfo(int.Parse(row[0].ToString()));
                                returnHelper.Execute_Rueckgabe(int.Parse(row[0].ToString()), returnHelper.Costumer.CostumerId, new Condition(Convert.ToInt32(row[1])).ConditionName,
                                    int.Parse(row[2].ToString()), condition.ConditionName, returnHelper.BorrowDate.ToShortDateString(),
                                    DateTime.Now.Date.ToShortDateString()); //Später einbauen (das ist der fertig-funktionsfähige Befehl)
                            }
                            MetroMessageBox.Show(this, "Die Buchrückgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (IsComplete(ref gv_suggested))
                            {
                                Kundenrow.DefaultCellStyle.BackColor = Color.LimeGreen;
                                Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                            }
                            else if (IsNotEmpty(ref gv_suggested))
                            {
                                Kundenrow.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                                Kundenrow.DefaultCellStyle.SelectionForeColor = Color.Black;
                                Kundenrow.DefaultCellStyle.BackColor = Color.Gray;
                                Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
                        catch
                        {
                            MetroMessageBox.Show(this, "Die Buchrückgabe konnte nicht abgeschlossen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (IsComplete(ref gv_suggested))
                            {
                                Kundenrow.DefaultCellStyle.BackColor = Color.Red;
                                Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
                        returnHelper.ClearRueckList();
                        SelectNextRow();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Prüfen Sie die Auswahl in der 'Ist-Zustand'-Spalte!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Es befinden sich keine Bücher in der Rückgabeliste!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tb_ExemplarID.Focus();
                tb_ExemplarID.SelectAll();
            }
        }

        private void Gv_Schueler_CurrentCellChanged(object sender, EventArgs e)
        {
            StudentChanged();
            LoadRueckBuecher();
            SetProgress();
        }
        private void StudentChanged()
        {
            if (gv_Schueler.CurrentRow != null && gv_Schueler.CurrentRow.Index < gv_Schueler.Rows.Count - 1 && gv_Schueler.CurrentRow.Index >= 0)
            {
                bt_back.Enabled = (gv_Schueler.CurrentRow.Index > 0);
                bt_next.Enabled = !(gv_Schueler.CurrentRow.Index == gv_Schueler.Rows.Count - 1);
                tb_ExemplarID.Text = "";
                tb_ExemplarID.Focus();
                returnHelper.ClearRueckList();
                selectedBuecher.Rows.Clear();
                gv_selected.Refresh();
            }

        }

        private void SetProgress()
        {
            lbProgress.Visible = true;
            int totalCount = gv_Schueler.Rows != null ? gv_Schueler.Rows.Count : 0;
            int currentNumber = gv_Schueler.SelectedRows != null && gv_Schueler.SelectedRows.Count > 0 ? gv_Schueler.SelectedRows[0].Index + 1 : 0;
            lbProgress.Text = $"{currentNumber} von {totalCount}";
        }


        private void Tb_ExemplarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                #region Buchcode parsen
                if (tb_ExemplarID.Text.Length == 8)
                {
                    string seven = tb_ExemplarID.Text.Substring(0, 7);
                    string eight = tb_ExemplarID.Text.Substring(7, 1);
                    if (ParseBuchcode(seven).ToString().Equals(eight))
                    {
                        tb_ExemplarID.Text = int.Parse(seven).ToString();
                    }
                }
                #endregion

                if (tb_ExemplarID.Text != "")
                {
                    try
                    {
                        Copy copy = new Copy(int.Parse(tb_ExemplarID.Text));
                        if (copy.CopyActivated)
                        {
                            lb_selected.Text = "ausgewählte Bücher:";
                            returnHelper.Copy = copy;
                            returnHelper.StartCondition = copy.Condition;
                            returnHelper.EndCondition = copy.Condition;
                            if (selectedBuecher.Columns.Count < 2)
                            {
                                selectedBuecher.Columns.Add("ID");
                                selectedBuecher.Columns.Add("Vorheriger Zustand");
                                selectedBuecher.Columns.Add("Titel");
                            }
                            if (!copy.IsAvailable())
                            {
                                DataGridViewRow Buchrow = new DataGridViewRow();
                                if (GetIndexInLeihBuecher() != -1)
                                {
                                    Buchrow = gv_suggested.Rows[GetIndexInLeihBuecher()];
                                    if (!returnHelper.CheckRueckList())
                                    {
                                        SelectExemplar();
                                        Buchrow.DefaultCellStyle.BackColor = Color.LimeGreen;
                                        Buchrow.DefaultCellStyle.ForeColor = Color.Black;
                                    }
                                    else
                                    {
                                        UnSelectExemplar();
                                        Buchrow.DefaultCellStyle.BackColor = default;
                                        Buchrow.DefaultCellStyle.ForeColor = default;
                                    }
                                }
                                else
                                {
                                    DialogResult dialogResult = MetroMessageBox.Show(this, "Dieses Buch wurde nicht von diesem Kunden ausgeliehen!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Dieses Buch wurde nicht verliehen. Es kann nicht zur Buchrückgabeliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            gv_selected.DataSource = selectedBuecher;
                            gv_selected.Refresh();
                            if (gv_selected.Columns.Contains("cbzustand"))
                            {
                                gv_selected.Columns.Remove("cbzustand");
                            }
                            DataGridViewComboBoxColumn combobox = new DataGridViewComboBoxColumn();
                            combobox = conditionHelper.FillDataGridViewComboBox();
                            gv_selected.Columns.Add(combobox);
                            gv_selected.Columns["cbzustand"].DisplayIndex = 2;
                            gv_selected.Columns["cbzustand"].HeaderText = "aktueller Ist-Zustand";
                            for (int i = 0; i < gv_selected.RowCount; i++)
                            {
                                DataGridViewComboBoxCell comboValue = (DataGridViewComboBoxCell)(gv_selected.Rows[i].Cells["cbzustand"]);
                                //comboValue.Value = 0;
                                string valueMember = gv_selected.Rows[i].Cells[1].Value.ToString();
                                Condition condition = new Condition(conditionHelper.FindIdByName(valueMember));
                                valueMember = condition.ConditionId.ToString();
                                gv_selected.Rows[i].Cells[3].Value = int.Parse(valueMember);

                            }
                            gv_selected.ClearSelection();
                            tb_ExemplarID.Focus();
                            tb_ExemplarID.SelectAll();
                            combobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                        }
                        else
                        {
                            tb_ExemplarID.Focus();
                            tb_ExemplarID.SelectAll();
                            MetroMessageBox.Show(this, "Dieser Buchcode existiert nicht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch(Exception ex)
                    {
                        MetroMessageBox.Show(this, "Dieser Buchcode existiert nicht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion

        private void MetroToolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(e.ToolTipSize.Width + 32, e.ToolTipSize.Height);
        }
    }
}
