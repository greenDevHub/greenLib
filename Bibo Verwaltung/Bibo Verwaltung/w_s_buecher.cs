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

        public w_s_buecher()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validated(object sender, EventArgs e)
        {
            if (IsNumeric(textBox3.Text)) MessageBox.Show("Bitte nur Zahlen eingeben!");
        }
    }
}
