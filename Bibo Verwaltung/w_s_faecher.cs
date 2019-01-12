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
    public partial class w_s_faecher : Form
    {
        public w_s_faecher()
        {
            InitializeComponent();
            f.FillGrid(ref gv_Verlage);
        }
        bool changes = false;
        Faecher f = new Faecher();

        #region Aenderungen an GridView erkennen
        private void gv_Verlage_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            changes = true;
        }

        private void gv_Verlage_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            changes = true;
        }
        #endregion

        private void w_s_faecher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes == true)
            {
                gv_Verlage.EndEdit();
                DialogResult dr = MessageBox.Show("Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        bt_Uebernehmen.Focus();
                        f.SaveGrid(ref gv_Verlage);
                    }
                    catch
                    {
                        MessageBox.Show("Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void bt_import_Click_1(object sender, EventArgs e)
        {
            Form Import = new w_s_schuelerimport("t_s_faecher", true);
            Import.ShowDialog(this);
            f.FillGrid(ref gv_Verlage);
        }
    }
}
