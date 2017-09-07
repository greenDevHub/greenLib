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
    public partial class w_s_verlage : Form
    {
        public w_s_verlage()
        {
            InitializeComponent();
            verlag.FillGrid(ref gv_Verlage);
        }

        Verlag verlag = new Verlag();

        private void w_s_verlage_FormClosing(object sender, FormClosingEventArgs e)
        {
            verlag.SaveGrid(ref gv_Verlage);
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                try
                {
                    var selectedCell = gv_Verlage.SelectedCells[0];
                    gv_Verlage.Rows.Remove(gv_Verlage.CurrentRow);
                }
                catch
                {
                    if (gv_Verlage.CurrentRow.Selected == true)
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
