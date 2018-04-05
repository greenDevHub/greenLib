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
    public partial class w_s_selfmade_dialog : Form
    {
        public w_s_selfmade_dialog(string Caption, string Message, string ButtonCapion1, string ButtonCapion2)
        {
            InitializeComponent();
            Text = Caption;
            lb_Message.Text = Message;
            bt_Choice1.Text = ButtonCapion1;
            bt_Choice2.Text = ButtonCapion2;
        }
    }
}
