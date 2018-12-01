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

Analytics al = new Analytics();

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 1)
            {
                al.showPreisanstieg("978-3423715669", ref gv_ResultGrid, ref chart1);
                al.Markierung(ref gv_ResultGrid);
            }else if (comboBox1.SelectedIndex == 2)
            {
                al.showMaxPreisanstieg(ref gv_ResultGrid, ref chart1);
                al.Markierung(ref gv_ResultGrid);
            }
            //chart1.DataSource = gv_ResultGrid.DataSource;
            //chart1.Show();
        }

        private void gv_ResultGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            al.Markierung(ref gv_ResultGrid);
        }

        private void bt_BAbNutz_Click(object sender, EventArgs e)
        {
            al.showAbzutzung("978-3423715669", ref gv_ResultGrid, ref chart1);
        }
    }
}
