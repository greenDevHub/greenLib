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
    public partial class w_s_buecher : Form
    {
        public bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
        public void Load()
        {

        }

        public w_s_buecher()
        {
            InitializeComponent();
        }

        private void gb_GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if (!IsNumeric(tb_Neupreis.Text))
            {
                MessageBox.Show("Bitte nur Zahlen eingeben!");
                tb_Neupreis.Text = "";
            }
        }
    }
}
