using MetroFramework;
using MetroFramework.Components;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormImportAssist : MetroFramework.Forms.MetroForm
    {
        Import import = new Import();
        DataTable typ = new DataTable();
        Color fc = Color.Black;
        Color bc = Color.White;
        #region Objekt-Constructor
        /// <summary>
        /// Öffnet den Import-Assist zum importieren von CSV-Dateien
        /// </summary>
        public FormImportAssist(string targetDBTable, MetroStyleManager msm)
        {
            InitializeComponent();
            msm_import = msm;
            this.StyleManager = msm;
            this.StyleManager.Style = MetroColorStyle.Silver;
            if (this.StyleManager.Theme == MetroThemeStyle.Dark)
            {
                fc = Color.White;
                bc = System.Drawing.ColorTranslator.FromHtml("#111111");
                foreach (TabPage tp in tc_ImportAssist.TabPages)
                {
                    tp.ForeColor = fc;
                    tp.BackColor = bc;
                }
                rtb_Vorschau.ForeColor = fc;
                rtb_Vorschau.BackColor = bc;
            }
            import.Zieltabellen = targetDBTable;
        }
        #endregion

        private void Mbt_Suche_Click(object sender, EventArgs e)
        {
            if (import.ShowFileDialog(this, ref mtb_Filename) == System.Windows.Forms.DialogResult.OK)
            {
                rtb_Vorschau.Text = import.ReadFile();
            }
        }

        private void Mbt_Advanced_Click(object sender, EventArgs e)
        {
            //Form advanced = new w_s_import_export();
            //advanced.ShowDialog(this);
        }

        private void Mbt_finish_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            import.FilePath = mtb_Filename.Text;
            import.Separator = Convert.ToChar(acb_FeldTrenn.SelectedItem.ToString());
            import.Textqualifizierer = Convert.ToChar(acb_TextQuali.SelectedItem.ToString());
            import.Datumsfolge = acb_DatFolge.SelectedItem.ToString();
            import.Datumstrennzeichen = Convert.ToChar(mtb_DatTrenn.Text); ;
            import.Zeittrennzeichen = Convert.ToChar(mtb_ZeitTrenn.Text); ;
            import.IsVierstelligeJahre = mch_4stelligeJahre.Checked;
            import.IsFuehrendeDatumsNull = mch_DatNullen.Checked;
            import.Dezimaltrennzeichen = Convert.ToChar(mtb_DezSym.Text); ;
            import.UseFirstRowAsColumnHeader = mcb_ColHeader.Checked;
            import.ExecuteImport(this, ref gv_DataTyp, ref gv_DB);
            Cursor.Current = Cursors.Default;
        }

        private void Mbt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mbt_next_Click(object sender, EventArgs e)
        {
            if (mtb_Filename.Text != "")
            {
                if (File.Exists(mtb_Filename.Text))
                {
                    mbt_Suche.Enabled = false;
                    mtb_Filename.Enabled = false;
                    rtb_Vorschau.Enabled = false;
                    mbt_Cancel.Enabled = false;
                    mbt_next.Enabled = false;
                    mbt_finish.Enabled = false;
                    acb_FeldTrenn.Enabled = true;
                    acb_TextQuali.Enabled = true;
                    mcb_ColHeader.Enabled = true;
                    acb_DatFolge.Enabled = true;
                    mtb_DatTrenn.Enabled = true;
                    mtb_ZeitTrenn.Enabled = true;
                    mch_4stelligeJahre.Enabled = true;
                    mch_DatNullen.Enabled = true;
                    mtb_DezSym.Enabled = true;
                    gv_Vorschau.Enabled = true;
                    mbt_Cancel2.Enabled = true;
                    mbt_next2.Enabled = true;
                    mbt_back2.Enabled = true;
                    mbt_finish2.Enabled = true;
                    tc_ImportAssist.SelectTab(1);
                    if (acb_FeldTrenn.SelectedItem == null)
                    {
                        acb_FeldTrenn.SelectedIndex = 0;
                        acb_TextQuali.SelectedIndex = 0;
                        acb_DatFolge.SelectedIndex = 0;
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Der Pfad: '" + mtb_Filename.Text + "' ist ungülig!", "Error in Dateipfad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtb_Filename.Focus();
                    mtb_Filename.SelectAll();
                }
            }
        }

        private void Mbt_back2_Click(object sender, EventArgs e)
        {
            mbt_Suche.Enabled = true;
            mtb_Filename.Enabled = true;
            rtb_Vorschau.Enabled = true;
            mbt_Cancel.Enabled = true;
            mbt_next.Enabled = true;
            mbt_finish.Enabled = true;
            tc_ImportAssist.SelectTab(0);
        }

        private void Mbt_next2_Click(object sender, EventArgs e)
        {
            acb_FeldTrenn.Enabled = false;
            acb_TextQuali.Enabled = false;
            mcb_ColHeader.Enabled = false;
            acb_DatFolge.Enabled = false;
            mtb_DatTrenn.Enabled = false;
            mtb_ZeitTrenn.Enabled = false;
            mch_4stelligeJahre.Enabled = false;
            mch_DatNullen.Enabled = false;
            mtb_DezSym.Enabled = false;
            gv_Vorschau.Enabled = false;
            mbt_Cancel2.Enabled = false;
            mbt_next2.Enabled = false;
            mbt_back2.Enabled = false;
            mbt_finish2.Enabled = false;
            mtb_FeldName.Enabled = true;
            acb_DataTyp.Enabled = true;
            mcb_Primary.Enabled = true;
            mcb_Selected.Enabled = true;
            gv_DataTyp.Enabled = true;
            mbt_Cancel3.Enabled = true;
            mbt_next3.Enabled = true;
            mbt_back3.Enabled = true;
            mbt_finish3.Enabled = true;
            tc_ImportAssist.SelectTab(2);
            import.LoadDatatypAssignment(ref gv_DataTyp);
        }

        private void Mbt_back3_Click(object sender, EventArgs e)
        {
            acb_FeldTrenn.Enabled = true;
            acb_TextQuali.Enabled = true;
            mcb_ColHeader.Enabled = true;
            acb_DatFolge.Enabled = true;
            mtb_DatTrenn.Enabled = true;
            mtb_ZeitTrenn.Enabled = true;
            mch_4stelligeJahre.Enabled = true;
            mch_DatNullen.Enabled = true;
            mtb_DezSym.Enabled = true;
            gv_Vorschau.Enabled = true;
            mbt_Cancel2.Enabled = true;
            mbt_next2.Enabled = true;
            mbt_back2.Enabled = true;
            mbt_finish2.Enabled = true;
            tc_ImportAssist.SelectTab(1);
        }

        private void Mcb_ColHeader_CheckedChanged(object sender, EventArgs e)
        {
            import.UseFirstRowAsColumnHeader = mcb_ColHeader.Checked;
            import.FillGridView_Preview(this, ref gv_Vorschau);
        }

        private void Acb_TextQuali_SelectedIndexChanged(object sender, EventArgs e)
        {
            import.Textqualifizierer = Convert.ToChar(acb_TextQuali.SelectedItem.ToString());
            import.FillGridView_Preview(this, ref gv_Vorschau);
        }

        private void Acb_DatFolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            import.Datumsfolge = acb_DatFolge.SelectedItem.ToString();
            import.FillGridView_Preview(this, ref gv_Vorschau);
        }

        private void Mtb_DatTrenn_TextChanged(object sender, EventArgs e)
        {
            if (import.Set_DatTrenn(this, ref mtb_DatTrenn))
            {
                import.FillGridView_Preview(this, ref gv_Vorschau);
            }
        }

        private void Mtb_ZeitTrenn_TextChanged(object sender, EventArgs e)
        {
            if (import.Set_ZeitTrenn(this, ref mtb_ZeitTrenn))
            {
                import.FillGridView_Preview(this, ref gv_Vorschau);
            }
        }

        private void Mch_4stelligeJahre_CheckedChanged(object sender, EventArgs e)
        {
            import.IsVierstelligeJahre = mch_4stelligeJahre.Checked;
            import.FillGridView_Preview(this, ref gv_Vorschau);
        }

        private void Mch_DatNullen_CheckedChanged(object sender, EventArgs e)
        {
            import.IsFuehrendeDatumsNull = mch_DatNullen.Checked;
            import.FillGridView_Preview(this, ref gv_Vorschau);
        }

        private void Mtb_DezSym_TextChanged(object sender, EventArgs e)
        {
            if (import.Set_DezSym(this, ref mtb_DezSym))
            {
                import.FillGridView_Preview(this, ref gv_Vorschau);
            }
        }

        private void Gv_DataTyp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtb_FeldName.Text = gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Feldname"].Value.ToString();
            acb_DataTyp.SelectedItem = gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Datentyp"].Value.ToString();
            mcb_Primary.Checked = Convert.ToBoolean(gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Primärschlüssel"].Value);
            mcb_Selected.Checked = Convert.ToBoolean(gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["überspringen"].Value);
        }

        private void Mtb_FeldName_TextChanged(object sender, EventArgs e)
        {
            if (gv_DataTyp.CurrentRow != null)
            {
                string colName = gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Feldname"].Value.ToString();
                import.RenameColumn(colName, mtb_FeldName.Text);
                gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Feldname"].Value = mtb_FeldName.Text;
            }
        }

        private void Acb_DataTyp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gv_DataTyp.CurrentRow != null)
            {
                gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Datentyp"].Value = acb_DataTyp.SelectedItem;
            }
        }

        private void Gv_DataTyp_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string colName = mtb_FeldName.Text;
            import.RenameColumn(colName, gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Feldname"].Value.ToString());
            mtb_FeldName.Text = gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Feldname"].Value.ToString();
            acb_DataTyp.SelectedItem = gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Datentyp"].Value.ToString();
            mcb_Primary.Checked = Convert.ToBoolean(gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Primärschlüssel"].Value);
            mcb_Selected.Checked = Convert.ToBoolean(gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["überspringen"].Value);
        }

        private void Mcb_Primary_CheckedChanged(object sender, EventArgs e)
        {
            gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Primärschlüssel"].Value = mcb_Primary.Checked;
        }

        private void Mcb_Selected_CheckedChanged(object sender, EventArgs e)
        {
            gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["überspringen"].Value = mcb_Selected.Checked;
        }

        private void Mbt_next3_Click(object sender, EventArgs e)
        {
            mtb_FeldName.Enabled = false;
            acb_DataTyp.Enabled = false;
            mcb_Primary.Enabled = false;
            mcb_Selected.Enabled = false;
            gv_DataTyp.Enabled = false;
            mbt_Cancel3.Enabled = false;
            mbt_next3.Enabled = false;
            mbt_back3.Enabled = false;
            mbt_finish3.Enabled = false;
            mbt_Cancel4.Enabled = true;
            mbt_next4.Enabled = true;
            mbt_back4.Enabled = true;
            mbt_finish4.Enabled = true;
            tc_ImportAssist.SelectTab(3);

            import.CreateImportTable(ref gv_DataTyp);
            import.FillGridView_SpaltenZuordnung(this, ref gv_DB);
            //gv_DB.Columns[0].Name = "DestinationColumn";
            //if (gv_DB.Columns.Contains("SourceColumn"))
            //{
            //    gv_DB.Columns.Remove("SourceColumn");
            //}
            //DataGridViewComboBoxColumn combobox1 = new DataGridViewComboBoxColumn();
            //combobox1.HeaderText = "Zuordnung der Spalten aus der CSV-Datei";
            //combobox1.Name = "SourceColumn";
            //combobox1.MaxDropDownItems = 8;
            //combobox1.Items.Add("--keine--");
            //for (int i = 0; i < import.CSVData_ToServer.Columns.Count; i++)
            //{
            //    combobox1.Items.Add(import.CSVData_ToServer.Columns[i].ColumnName);
            //}
            //combobox1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            //combobox1.Width = 1000;
            //gv_DB.Columns.Add(combobox1);
            //gv_DB.Columns["SourceColumn"].SortMode = DataGridViewColumnSortMode.NotSortable;
            //for (int i = 0; i < gv_DB.RowCount; i++)
            //{
            //    DataGridViewComboBoxCell comboValue = (DataGridViewComboBoxCell)(gv_DB.Rows[i].Cells["SourceColumn"]);
            //    comboValue.Value = combobox1.Items[0];
            //}

        }

        private void Mbt_back4_Click(object sender, EventArgs e)
        {
            mtb_FeldName.Enabled = true;
            acb_DataTyp.Enabled = true;
            mcb_Primary.Enabled = true;
            mcb_Selected.Enabled = true;
            gv_DataTyp.Enabled = true;
            mbt_Cancel3.Enabled = true;
            mbt_next3.Enabled = true;
            mbt_back3.Enabled = true;
            mbt_finish3.Enabled = true;
            tc_ImportAssist.SelectTab(2);
        }

        #region EventHandler für TextChanged, SelectedItemChanged und CheckedChanged in DataGridView 
        //Eigener EventHandler für TextChanged, SelectedItemChanged und CheckedChanged in DataGridView 
        private void gv_DataTyp_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            int colIndex;
            int rowIndex;
            var txtBox = e.Control as TextBox;
            var chBox = e.Control as CheckBox;
            var comBox = e.Control as ComboBox;
            colIndex = gv_DataTyp.CurrentCell.ColumnIndex;
            rowIndex = gv_DataTyp.CurrentCell.RowIndex;
            if (e.Control is TextBox)
            {
                if (txtBox != null)
                {
                    txtBox.TextChanged += new EventHandler(ItemTxtBox_TextChanged);
                }
            }
            else if (e.Control is ComboBox)
            {
                if (comBox != null)
                {
                    comBox.SelectedIndexChanged += new EventHandler(ItemComboBox_SelectedIndexChanged);
                }
            }
            else if (e.Control is CheckBox)
            {
                if (chBox != null)
                {
                    chBox.CheckedChanged += new EventHandler(ItemCheckedChanged_CheckedChanged);
                }
            }
        }

        //EventHandler für TextChanged
        void ItemTxtBox_TextChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text != null && (sender as TextBox).Text.Trim() != "")
            {
                string colName = mtb_FeldName.Text;
                import.RenameColumn(colName, gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Feldname"].EditedFormattedValue.ToString());
                mtb_FeldName.Text = gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Feldname"].EditedFormattedValue.ToString();
            }
        }

        //EventHandler für SelectedIndexChanged
        void ItemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null && (sender as ComboBox).SelectedIndex != -1)
            {
                acb_DataTyp.Text = gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Datentyp"].EditedFormattedValue.ToString();
            }
        }

        //EventHandler für CheckedChanged
        void ItemCheckedChanged_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Name == "mcb_Primary")
            {

                mcb_Primary.Checked = Convert.ToBoolean(gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Primärschlüssel"].Value);
            }
            else if ((sender as CheckBox).Name == "überspringen")
            {
                mcb_Selected.Checked = Convert.ToBoolean(gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Primärschlüssel"].Value);

            }
        }

        private void acb_FeldTrenn_TextChanged(object sender, EventArgs e)
        {
            if (import.Set_Seperator(this, ref acb_FeldTrenn))
            {
                import.FillGridView_Preview(this, ref gv_Vorschau);
            }
        }

        private void mtb_DatTrenn_Leave(object sender, EventArgs e)
        {
            if (mtb_DatTrenn.Text == "")
            {
                mtb_DatTrenn.Text = ".";
            }
        }

        private void mtb_ZeitTrenn_Leave(object sender, EventArgs e)
        {
            if (mtb_ZeitTrenn.Text == "")
            {
                mtb_ZeitTrenn.Text = ".";
            }
        }

        private void mtb_DezSym_Leave(object sender, EventArgs e)
        {
            if (mtb_DezSym.Text == "")
            {
                mtb_DezSym.Text = ".";
            }
        }
        #endregion
    }
}
