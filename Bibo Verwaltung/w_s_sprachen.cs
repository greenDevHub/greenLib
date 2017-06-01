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
    }
}
