using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_importAssist : MetroFramework.Forms.MetroForm
    {
        Import import = new Import();
        DataTable typ = new DataTable();

        public w_s_importAssist(string targetDBTable)
        {
            InitializeComponent();
            import.Zieltabelle = targetDBTable;
        }

        private void LoadDataTyp(ref MetroGrid grid, object value = null)
        {
            gv_DataTyp.DataSource = null;
            typ.Clear();
            if (typ.Columns.Count < 1)
            {
                typ.Columns.Add("Feldname");
            }
            foreach (DataGridViewColumn col in gv_Vorschau.Columns)
            {
                DataRow relation;
                string[] rowData = new string[1];
                rowData[0] = gv_Vorschau.Columns[col.Index].Name;
                relation = typ.NewRow();
                relation.ItemArray = rowData;
                typ.Rows.Add(relation);
            }
            gv_DataTyp.DataSource = typ;
            gv_DataTyp.Columns["Feldname"].SortMode = DataGridViewColumnSortMode.NotSortable;

            if (!gv_DataTyp.Columns.Contains("Feld ist Primärschlüssel"))
            {
                DataGridViewCheckBoxColumn checkbox1 = new DataGridViewCheckBoxColumn();
                checkbox1.HeaderText = "Feld ist Primärschlüssel";
                checkbox1.Name = "Primärschlüssel";
                checkbox1.FlatStyle = FlatStyle.System;
                checkbox1.ThreeState = false;
                gv_DataTyp.Columns.Add(checkbox1);
                gv_DataTyp.Columns["Primärschlüssel"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (!gv_DataTyp.Columns.Contains("Feld nicht importieren (überspringen)"))
            {
                DataGridViewCheckBoxColumn checkbox2 = new DataGridViewCheckBoxColumn();
                checkbox2.HeaderText = "Feld nicht importieren (überspringen)";
                checkbox2.Name = "überspringen";
                checkbox2.FlatStyle = FlatStyle.System;
                checkbox2.ThreeState = false;
                gv_DataTyp.Columns.Add(checkbox2);
                gv_DataTyp.Columns["überspringen"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (!gv_DataTyp.Columns.Contains("Datentyp"))
            {
                DataGridViewComboBoxColumn combobox1 = new DataGridViewComboBoxColumn();
                combobox1.HeaderText = "Datentyp";
                combobox1.Name = "Datentyp";
                combobox1.MaxDropDownItems = 8;
                combobox1.Items.Add("Ja/Nein (Boolean)");
                combobox1.Items.Add("Byte");
                combobox1.Items.Add("Integer");
                combobox1.Items.Add("Währung");
                combobox1.Items.Add("Single");
                combobox1.Items.Add("Double");
                combobox1.Items.Add("Datum mit Uhrzeit");
                combobox1.Items.Add("Text (String)");
                combobox1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                combobox1.Width = 1000;
                gv_DataTyp.Columns.Add(combobox1);
                gv_DataTyp.Columns["Datentyp"].SortMode = DataGridViewColumnSortMode.NotSortable;
                for (int i = 0; i < gv_DataTyp.RowCount; i++)
                {
                    DataGridViewComboBoxCell comboValue = (DataGridViewComboBoxCell)(gv_DataTyp.Rows[i].Cells["Datentyp"]);
                    comboValue.Value = combobox1.Items[0];
                }
            }
            gv_DataTyp.Columns["Feldname"].DisplayIndex = 0;
            gv_DataTyp.Columns["Datentyp"].DisplayIndex = 1;
            gv_DataTyp.Columns["Primärschlüssel"].DisplayIndex = 2;
            gv_DataTyp.Columns["überspringen"].DisplayIndex = 3;
        }

        private void FileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wählen Sie eine Datei für den Datenimport";
            openFileDialog.Filter = "Text Files|*.txt; *.csv";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog.FileName.Contains(".txt") || openFileDialog.FileName.Contains(".csv"))
                {
                    import.FilePath = openFileDialog.FileName;
                    mtb_Filename.Text = openFileDialog.FileName;
                }
                else
                {
                    mtb_Filename.Text = "";
                    MetroMessageBox.Show(this, "Der angegebene Dateiname ist ungültig. Bitte verwenden sie nur Dateien mit der Endung \'.txt\' oder \'.csv\'!");
                    FileDialog();
                }
            }

        }

        private void Mbt_Suche_Click(object sender, EventArgs e)
        {
            FileDialog();
            rtb_Vorschau.Text = import.ReadFile();
        }

        private void Mbt_Advanced_Click(object sender, EventArgs e)
        {
            Form advanced = new w_s_import_export();
            advanced.ShowDialog(this);
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
            import.ExecuteImport();
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
                    MetroMessageBox.Show(this, "Der Pfad: " + mtb_Filename.Text + " ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mtb_Filename.Focus();
                    mtb_Filename.SelectAll();
                }
            }
        }

        private void Mbt_back2_Click(object sender, EventArgs e)
        {
            tc_ImportAssist.SelectTab(0);
        }

        private void Mbt_next2_Click(object sender, EventArgs e)
        {
            tc_ImportAssist.SelectTab(2);
            LoadDataTyp(ref gv_DataTyp);
        }

        private void Mbt_back3_Click(object sender, EventArgs e)
        {
            tc_ImportAssist.SelectTab(1);
        }

        private void Acb_FeldTrenn_SelectedIndexChanged(object sender, EventArgs e)
        {
            char sep;
            if (acb_FeldTrenn.SelectedItem.ToString() == "{Leerzeichen}")
            {
                sep = Convert.ToChar(" ");
            }
            else if (acb_FeldTrenn.SelectedItem.ToString() == "{Tabulator}")
            {
                sep = '\t';
            }
            else
            {
                sep = Convert.ToChar(acb_FeldTrenn.SelectedItem.ToString());
            }
            import.Separator = sep;
            import.FillGridView_Preview(ref gv_Vorschau);
        }

        private void Mcb_ColHeader_CheckedChanged(object sender, EventArgs e)
        {
            import.UseFirstRowAsColumnHeader = mcb_ColHeader.Checked;
            import.FillGridView_Preview(ref gv_Vorschau);
        }

        private void Acb_TextQuali_SelectedIndexChanged(object sender, EventArgs e)
        {
            import.Textqualifizierer = Convert.ToChar(acb_TextQuali.SelectedItem.ToString());
            import.FillGridView_Preview(ref gv_Vorschau);
        }

        private void Acb_DatFolge_SelectedIndexChanged(object sender, EventArgs e)
        {
            import.Datumsfolge = acb_DatFolge.SelectedItem.ToString();
            import.FillGridView_Preview(ref gv_Vorschau);
        }

        private void Mtb_DatTrenn_TextChanged(object sender, EventArgs e)
        {
            if (mtb_DatTrenn.Text.Length == 1)
            {
                char dattrenn = Convert.ToChar(mtb_DatTrenn.Text);
                if (dattrenn == '.' | dattrenn == '-' | dattrenn == '/')
                {
                    import.Datumstrennzeichen = dattrenn;
                    import.FillGridView_Preview(ref gv_Vorschau);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Das Datumstrennzeichen ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mtb_ZeitTrenn_TextChanged(object sender, EventArgs e)
        {
            if (mtb_ZeitTrenn.Text.Length == 1)
            {
                char zeittrenn = Convert.ToChar(mtb_ZeitTrenn.Text);
                if (zeittrenn == ':' | zeittrenn == '-' | zeittrenn == '/')
                {
                    import.Zeittrennzeichen = zeittrenn;
                    import.FillGridView_Preview(ref gv_Vorschau);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Das Zeittrennzeichen ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mch_4stelligeJahre_CheckedChanged(object sender, EventArgs e)
        {
            import.IsVierstelligeJahre = mch_4stelligeJahre.Checked;
            import.FillGridView_Preview(ref gv_Vorschau);
        }

        private void Mch_DatNullen_CheckedChanged(object sender, EventArgs e)
        {
            import.IsFuehrendeDatumsNull = mch_DatNullen.Checked;
            import.FillGridView_Preview(ref gv_Vorschau);
        }

        private void Mtb_DezSym_TextChanged(object sender, EventArgs e)
        {
            if (mtb_DezSym.Text.Length == 1)
            {
                char dezsym = Convert.ToChar(mtb_DezSym.Text);
                if (dezsym == ',' | dezsym == '.')
                {
                    import.Dezimaltrennzeichen = dezsym;
                    import.FillGridView_Preview(ref gv_Vorschau);
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Das Dezimalsymbol ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gv_DataTyp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mtb_FeldName.Text = gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Feldname"].Value.ToString();
            acb_DataTyp.SelectedItem= gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Datentyp"].Value.ToString();
            mcb_Primary.Checked= Convert.ToBoolean(gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["Primärschlüssel"].Value);
            mcb_Selected.Checked = Convert.ToBoolean(gv_DataTyp.Rows[gv_DataTyp.CurrentRow.Index].Cells["überspringen"].Value);
        }

        private void Mtb_FeldName_TextChanged(object sender, EventArgs e)
        {
            if (gv_DataTyp.CurrentRow != null)
            {
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
            tc_ImportAssist.SelectTab(3);
            //            BindingSource bs = (BindingSource)gv_DataTyp.DataSource; 
            //userDataTypes = (DataTable)bs.DataSource;
            import.UserDataTypes = (gv_DataTyp.DataSource as DataTable);
            gv_DB.DataSource = import.GetSchemaOfSQLTable();
        }

        private void Mbt_back4_Click(object sender, EventArgs e)
        {
            tc_ImportAssist.SelectTab(2);
        }
    }
}
