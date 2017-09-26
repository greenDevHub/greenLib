using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace Bibo_Verwaltung
{
    public partial class w_s_barcode : Form
    {
        Barcode bar;

        public w_s_barcode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bar = new Barcode(textBox1.Text, textBox1.Text, textBox1.Text);
            bar.FillPictureBox(ref pb_Barcode);
        }
    }
}
