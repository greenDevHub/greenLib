using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_schueler : Form
    {
        Schueler s = new Schueler();
        Fach faecher = new Fach();
        public w_s_schueler()
        {
            InitializeComponent();
            s.FillGrid(false, ref gv_Kunde);
            //faecher.FillList(ref cLB_faecher);
        }

        private void bt_ImEx_Click(object sender, EventArgs e)
        {
            Form import = new w_s_schuelerimport("t_s_schueler", true);
            import.ShowDialog(this);
            s.FillGrid(false, ref gv_Kunde);
        }

        List<string> need = new List<string>();
        private void AddS(string modus)
        {
            Schueler schueler = new Schueler();
            schueler.Vorname = tb_Vorname.Text;
            schueler.Nachname = tb_Nachname.Text;
            schueler.Gd = dtp_gd.Value;
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
                    DialogResult result = MessageBox.Show("Dieser Schüler ist bereits vorhanden. Soll der entsprechende Datensatz stattdessen aktualisiert werden?", "Eintrag bereits vorhanden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        schueler.LoadSchuelerID();
                        schueler.Update();
                    }
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
                dtp_gd.Enabled = true;
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
                dtp_gd.Enabled = true;
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
                dtp_gd.Enabled = false;
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
            if(tb_klasse.Text != "" && tb_klassenstufe.Text != "" && tb_Nachname.Text != "" && tb_Vorname.Text != "")
            {
                if (bt_confirm.Text == "Löschen")
                {
                    AddS("Delete");
                }
                else if (bt_confirm.Text == "Speichern")
                {
                    AddS("Update");
                }
                else if (bt_confirm.Text == "Hinzufügen")
                {
                    AddS("Add");
                }
                Clear();
            }
            else
            {
                MessageBox.Show("Bitte überprüfen Sie ihre Angaben.", "Fehlende Angaben", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void gv_Kunde_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Kunde.Rows[e.RowIndex];
                tb_KundenID.Text = row.Cells[GetColumnIndexByName(gv_Kunde, "ID")].Value.ToString();
                //tb_Vorname.Text = row.Cells[GetColumnIndexByName(gv_Kunde, "Vorname")].Value.ToString();
                //tb_Nachname.Text = row.Cells[GetColumnIndexByName(gv_Kunde, "Nachname")].Value.ToString();
                //dtp_gd.Value = (DateTime)row.Cells[GetColumnIndexByName(gv_Kunde, "Geburtsdatum")].Value;
                LoadSchueler();
            }
        }
        private void LoadSchueler()
        {
            Schueler schueler = new Schueler(tb_KundenID.Text);
            tb_Vorname.Text = schueler.Vorname;
            tb_Nachname.Text = schueler.Nachname;
            tb_klassenstufe.Text = schueler.Klassenstufe;
            tb_klasse.Text = schueler.Klasse;
            dtp_gd.Value = schueler.Gd;
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
            dtp_gd.Text = "";
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

            fullName = faecher.GetLongformByID((index).ToString());
            toolTip1.SetToolTip(cLB_faecher, fullName);


        }

        private void cLB_faecher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void w_s_schueler_Load(object sender, EventArgs e)
        {
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void tb_klassenstufe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void tb_KundenID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }
    }
}
