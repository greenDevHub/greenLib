﻿using System;
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
    public partial class w_s_schueler : Form
    {
        Schueler s = new Schueler();
        Faecher faecher = new Faecher();
        public w_s_schueler()
        {
            InitializeComponent();
            s.FillGrid(false, ref gv_Kunde);
            faecher.FillList(ref cLB_faecher);
        }

        private void bt_ImEx_Click(object sender, EventArgs e)
        {
            Form import = new w_s_schuelerimport(true);
            import.ShowDialog(this);
            s.FillGrid(false, ref gv_Kunde);
        }

        List<string> need = new List<string>();
        private void AddS(string modus)
        {
            Schueler schueler = new Schueler();
            schueler.Vorname = tb_Vorname.Text;
            schueler.Nachname = tb_Nachname.Text;
            schueler.Gd = tb_Gd.Text;
            schueler.Klasse = tb_klasse.Text;
            schueler.Klassenstufe = tb_klassenstufe.Text;
            
            foreach(var item in cLB_faecher.CheckedItems)
            {
                DataRowView castedItem = item as DataRowView;
                string namestring = castedItem["f_kurzform"].ToString();
                string idstring = castedItem["f_id"].ToString();
                schueler.Faecher.Add(namestring);
            }
            if (modus.Equals("Update"))
            {
                schueler.SchuelerID = tb_KundenID.Text;
                schueler.Update();

            }
            else if(modus.Equals("Add"))
            {
                if (!schueler.AlreadyExists())
                {
                    schueler.addSchueler();
                }
                else
                {
                    MessageBox.Show("Dieser Schüler existiert bereits in der Datenbank. Der bestehende Datensatz wird deshalb aktualisiert.");
                    schueler.LoadSchuelerID();
                    schueler.Update();
                }
            }
            else if (modus.Equals("Delete"))
            {
                schueler.SchuelerID = tb_KundenID.Text;
                schueler.DeleteSchueler();
            }
            schueler.FillGrid(false, ref gv_Kunde);
        }

        #region Modus nach RadioButton-Auswahl 
        private void Modus()
        {
            if (rb_Neukunde.Checked)
            {
                tb_KundenID.Enabled = false;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                tb_Gd.Enabled = true;
                tb_klasse.Enabled = true;
                tb_klassenstufe.Enabled = true;
                cLB_faecher.Enabled = true;
                bt_confirm.Enabled = true;
                bt_confirm.Text = "Hinzufügen";

            }
            if (rb_KundeBearbeiten.Checked)
            {
                tb_KundenID.Enabled = true;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                tb_Gd.Enabled = true;
                tb_klasse.Enabled = true;
                tb_klassenstufe.Enabled = true;
                cLB_faecher.Enabled = true;
                bt_confirm.Enabled = true;
                bt_confirm.Text = "Speichern";

            }
            if (rb_KundeLoeschen.Checked)
            {
                tb_KundenID.Enabled = true;
                tb_Vorname.Enabled = false;
                tb_Nachname.Enabled = false;
                tb_Gd.Enabled = false;
                tb_klasse.Enabled = false;
                tb_klassenstufe.Enabled = false;
                cLB_faecher.Enabled = false;
                bt_confirm.Enabled = true;
                bt_confirm.Text = "Löschen";
            }
        }
        #endregion

        private void rb_Neukunde_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_KundeBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_KundeLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void w_s_schueler_Activated(object sender, EventArgs e)
        {
            Modus();
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            if(bt_confirm.Text == "Löschen")
            {
                AddS("Delete");
            }
            else if(bt_confirm.Text == "Speichern")
            {
                AddS("Update");
            }
            else if(bt_confirm.Text == "Hinzufügen")
            {
                AddS("Add");
            }
        }

        private void gv_Kunde_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Kunde.Rows[e.RowIndex];
                tb_KundenID.Text = row.Cells[GetColumnIndexByName(gv_Kunde, "ID")].Value.ToString();
                tb_Vorname.Text = row.Cells[GetColumnIndexByName(gv_Kunde, "Vorname")].Value.ToString();
                tb_Nachname.Text = row.Cells[GetColumnIndexByName(gv_Kunde, "Nachname")].Value.ToString();
                tb_Gd.Text = row.Cells[GetColumnIndexByName(gv_Kunde, "Geburtsdatum")].Value.ToString();
                LoadSchueler();
            }
        }
        private void LoadSchueler()
        {
            Schueler schueler = new Schueler(tb_Vorname.Text, tb_Nachname.Text, tb_Gd.Text);
            tb_Vorname.Text = schueler.Vorname;
            tb_Nachname.Text = schueler.Nachname;
            tb_klassenstufe.Text = schueler.Klassenstufe;
            tb_klasse.Text = schueler.Klasse;
            tb_Gd.Text = schueler.Gd;
            if (schueler.Faecher.Count > 0)
            {
                List<int> index = new List<int>();
                foreach (object value in cLB_faecher.Items)
                {
                    DataRowView castedItem = value as DataRowView;
                    string newString = castedItem["f_kurzform"].ToString();
                    if (schueler.Faecher.Contains(newString))
                    {
                        int test = cLB_faecher.Items.IndexOf(value);
                        index.Add(test);
                    }
                }
                foreach (int i1 in index)
                {
                    cLB_faecher.SetItemChecked(i1, true);
                }
            }
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

        private void Clear()
        {
            var items = cLB_faecher.CheckedItems;
            List<int> checkedItems = new List<int>();
            foreach(object elem in items)
            {
                checkedItems.Add(cLB_faecher.Items.IndexOf(elem));
                
            }
            foreach(int i in checkedItems)
            {
                cLB_faecher.SetItemChecked(i, false);
            }
            tb_Vorname.Text = "";
            tb_Nachname.Text = "";
            tb_KundenID.Text = "";
            tb_klasse.Text = "";
            tb_klassenstufe.Text = "";
        }
        private void cLB_faecher_MouseHover(object sender, EventArgs e)
        {

        }
        string fullName = "";
        ToolTip toolTip1 = new ToolTip();
        private void cLB_faecher_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = cLB_faecher.PointToClient(Cursor.Position);
            int index = cLB_faecher.IndexFromPoint(point) +1;

            fullName = faecher.GetFullName((index).ToString());
            toolTip1.SetToolTip(cLB_faecher, fullName);


        }

        private void cLB_faecher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void w_s_schueler_Load(object sender, EventArgs e)
        {
        }
    }
}
