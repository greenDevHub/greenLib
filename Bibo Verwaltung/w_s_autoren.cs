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
    }
}
