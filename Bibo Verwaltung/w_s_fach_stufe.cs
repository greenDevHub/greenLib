using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_fach_stufe : Form
    {
        public w_s_fach_stufe()
        {
            InitializeComponent();
            fs.Klassenstufe.FillCombobox(ref cb_stufe, 0);
            fs.FillGrid(ref gv_fs);
            fs.Fach.FillList(ref cLB_faecher);
            Modus();
        }
        FachStufe fs = new FachStufe();

        private void bt_save_Click(object sender, EventArgs e)
        {
            var t = new Timer();
            t.Interval = 3000;
            t.Tick += (s, a) =>
            {
                lb.Hide();
                t.Stop();
            };
            Save();
            fs.FillGrid(ref gv_fs);
            lb.Visible = true;
            t.Start();
        }
        private void Save()
        {
            FachStufe fast = new FachStufe();
            fast.Klassenstufe.Stufe = cb_stufe.SelectedValue.ToString();
            foreach (var item in cLB_faecher.CheckedItems)
            {
                DataRowView castedItem = item as DataRowView;
                string namestring = castedItem["f_kurzform"].ToString();
                string idstring = castedItem["f_id"].ToString();
                fast.FachListe.Add(namestring);
            }
            if (bt_save.Text.Equals("Hinzufügen"))
            {
                if (!fast.AlreadyExists())
                {
                    fast.Add();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Diese Klassenstufe ist bereits vorhanden. Soll der entsprechende Datensatz stattdessen aktualisiert werden?", "Eintrag bereits vorhanden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        fast.Update();
                    }
                }
            }
            else if (bt_save.Text.Equals("Speichern"))
            {
                fast.Update();
            }
            else if (bt_save.Text.Equals("Löschen"))
            {
                fast.Delete();
                Clear();
            }
        }
        #region Modus
        private void Modus()
        {
            if (rb_add.Checked)
            {
                lb.Text = "Der Eintrag wurde hinzugefügt!";
                bt_save.Text = "Hinzufügen";
                cLB_faecher.Enabled = true;
                lb_faecher.Text = "Fächer:*";
                lb_faecher.Enabled = true;
                lb_klassenstufe.Text = "Klassenstufe:*";
            }
            else if (rb_del.Checked)
            {
                lb.Text = "Der Eintrag wurde gelöscht!";
                bt_save.Text = "Löschen";
                cLB_faecher.Enabled = false;
                lb_faecher.Text = "Fächer:";
                lb_faecher.Enabled = false;
                lb_klassenstufe.Text = "Klassenstufe:*";
            }
            else if (rb_edit.Checked)
            {
                lb.Text = "Der Eintrag wurde gespeichert!";
                bt_save.Text = "Speichern";
                cLB_faecher.Enabled = true;
                lb_faecher.Text = "Fächer:*";
                lb_faecher.Enabled = true;
                lb_klassenstufe.Text = "Klassenstufe:*";
            }
            lb.Visible = false;
        }
        #endregion

        private void rb_add_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_fs.Rows[e.RowIndex];
                cb_stufe.SelectedValue = row.Cells[GetColumnIndexByName(gv_fs, "Klassenstufe")].Value.ToString();
                LoadFS();
            }
        }
        private void LoadFS()
        {
            FachStufe fast = new FachStufe(cb_stufe.SelectedValue.ToString());
            if(fast.FachListe.Count > 0)
            {
                List<int> index = new List<int>();
                foreach (object value in cLB_faecher.Items)
                {
                    DataRowView castedItem = value as DataRowView;
                    string newString = castedItem["f_kurzform"].ToString();
                    if (fast.FachListe.Contains(newString))
                    {
                        int test = cLB_faecher.Items.IndexOf(value);
                        index.Add(test);
                    }
                }
                foreach(int i in index)
                {
                    cLB_faecher.SetItemChecked(i, true);
                }
            }
            
        }
        private void ClearCLB()
        {
            var items = cLB_faecher.CheckedItems;
            List<int> checkedItems = new List<int>();
            foreach (object elem in items)
            {
                checkedItems.Add(cLB_faecher.Items.IndexOf(elem));

            }
            foreach (int i in checkedItems)
            {
                cLB_faecher.SetItemChecked(i, false);
            }
            gv_fs.ClearSelection();

        }
        private void Clear()
        {
            ClearCLB();
            tb_search.Clear();
            cb_stufe.SelectedIndex = -1;
        }
        private int GetColumnIndexByName(DataGridView grid, string name)
        {
            for (int i = 0; i < grid.Columns.Count; i++)
            {
                if (grid.Columns[i].HeaderText.ToLower().Trim() == name.ToLower().Trim())
                {
                    return i;
                }
            }

            return -1;
        }

        private void cb_stufe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_stufe.Text != "")
            {
                string searchValue = cb_stufe.Text;
                gv_fs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach(DataGridViewRow row in gv_fs.Rows)
                    {
                        if(row.Cells[GetColumnIndexByName(gv_fs, "Klassenstufe")].Value.ToString().Equals(searchValue))
                        {
                            gv_fs.ClearSelection();
                            row.Selected = true;
                            LoadFS();
                            rb_edit.Checked = true;
                            break;
                        }
                        else
                        {
                            ClearCLB();
                            rb_add.Checked = true;
                        }
                    }
                }
                catch(Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string name = tb_search.Text.ToLower();
            //if(name.Length == 1)
            //{
            //    foreach (var item in cLB_faecher.Items)
            //    {
            //        DataRowView castedItem = item as DataRowView;
            //        string namestring = castedItem["f_kurzform"].ToString().Substring(0, 1);
            //        string idstring = castedItem["f_id"].ToString();
            //        if (namestring.Equals(name))
            //        {
            //            cLB_faecher.SelectedItem = item;
            //            break;
            //        }
            //    }
            //}
            //if (name.Length == 2)
            //{
            //    foreach (var item in cLB_faecher.Items)
            //    {
            //        DataRowView castedItem = item as DataRowView;
            //        string namestring = castedItem["f_kurzform"].ToString().Substring(0, 2);
            //        string idstring = castedItem["f_id"].ToString();
            //        if (namestring[0].Equals(name))
            //        {
            //            cLB_faecher.SelectedItem = item;
            //            break;
            //        }
            //    }
            //}
            if(name != "")
            {
                int i = name.Length;
                foreach (var item in cLB_faecher.Items)
                {
                    DataRowView castedItem = item as DataRowView;
                    string namestring = castedItem["f_kurzform"].ToString().ToLower();
                    string idstring = castedItem["f_id"].ToString();
                    if (namestring.Length >= i)
                    {
                        namestring = namestring.Substring(0, i);
                        if (namestring.Equals(name))
                        {
                            cLB_faecher.SelectedItem = item;
                            break;
                        }
                    }
                    
                }
            }
            else
            {
                cLB_faecher.ClearSelected();
            }

        }
        //private int GetItemIndex(string item)
        //{
        //    int index = 0;

        //    foreach (object o in cLB_faecher.Items)
        //    {
        //        if (item == o.ToString())
        //        {
        //            return index;
        //        }

        //        index++;
        //    }

        //    return -1;
        //}
        //private void SetItemChecked(string item)
        //{
        //    int index = GetItemIndex(item);

        //    if (index < 0) return;

        //    cLB_faecher.SetItemChecked(index, true);
        //}

    }
}
