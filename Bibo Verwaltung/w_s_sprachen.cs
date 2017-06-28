using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_sprachen : Form
    {
        public w_s_sprachen()
        {
            InitializeComponent();
            sprache.FillGrid(ref gv_Sprachen);
        }

        Sprache sprache = new Sprache();

        private void w_s_sprachen_FormClosing(object sender, FormClosingEventArgs e)
        {
            sprache.SaveGrid(ref gv_Sprachen);
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                try { 
                    var selectedCell = gv_Sprachen.SelectedCells[0];
                    gv_Sprachen.Rows.Remove(gv_Sprachen.CurrentRow);
                }
                catch
                {
                    if (gv_Sprachen.CurrentRow.Selected == true)
                    {
                        MessageBox.Show("Diese Zeile kann nicht entfernt werden!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Markieren Sie eine Zeile!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
