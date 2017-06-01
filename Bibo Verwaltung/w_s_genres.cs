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
    }
}
