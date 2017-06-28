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
    public partial class w_s_autoren : Form
    {
        public w_s_autoren()
        {
            InitializeComponent();
            autor.FillGrid(ref gv_Autoren);
        }

        Autor autor = new Autor();

        private void w_s_autoren_FormClosing(object sender, FormClosingEventArgs e)
        {
            autor.SaveGrid(ref gv_Autoren);
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                try
                {
                    var selectedCell = gv_Autoren.SelectedCells[0];
                    gv_Autoren.Rows.Remove(gv_Autoren.CurrentRow);
                }
                catch
                {
                    if (gv_Autoren.CurrentRow.Selected == true)
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
