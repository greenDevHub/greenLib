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
    public partial class w_s_analytics : Form
    {
        public w_s_analytics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Analytics al = new Analytics();
            al.showPreisanstieg("978-3423715669", ref gv_ResultGrid, ref chart1);
            //chart1.DataSource = gv_ResultGrid.DataSource;
            //chart1.Show();
        }
    }
}
