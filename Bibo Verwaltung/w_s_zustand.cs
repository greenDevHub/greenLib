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
    public partial class w_s_zustand : Form
    {
        Zustand zustand = new Zustand();
        public w_s_zustand()
        {
            InitializeComponent();
            zustand.FillGrid(ref Grid_Zustand);
        }

        private void w_s_zustand_FormClosing(object sender, FormClosingEventArgs e)
        {
            zustand.SaveGrid(ref Grid_Zustand);
        }

        private void Grid_Zustand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                try
                {
                    var selectedCell = Grid_Zustand.SelectedCells[0];
                    Grid_Zustand.Rows.Remove(Grid_Zustand.CurrentRow);
                }
                catch
                {
                    if (Grid_Zustand.CurrentRow.Selected == true)
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
