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
    public partial class w_s_genres : Form
    {
        public w_s_genres()
        {
            InitializeComponent();
            genre.FillGrid(ref gv_Genres);
        }

        Genre genre = new Genre();

        private void w_s_genres_FormClosing(object sender, FormClosingEventArgs e)
        {
            genre.SaveGrid(ref gv_Genres);
        }

        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                try
                {
                    var selectedCell = gv_Genres.SelectedCells[0];
                    gv_Genres.Rows.Remove(gv_Genres.CurrentRow);
                }
                catch
                {
                    if (gv_Genres.CurrentRow.Selected == true)
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
