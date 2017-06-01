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
    public partial class w_s_details : Form
    {
        public w_s_details()
        {
            InitializeComponent();
            b.FillGrid(ref gv_Details);
        }

        Details details = new Details();
        Buch b = new Buch();
    }
}
