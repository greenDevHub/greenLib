using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_selfmade_dialog : MetroFramework.Forms.MetroForm
    {
        public w_s_selfmade_dialog(string Caption, string Message, string ButtonCapion1, string ButtonCapion2)
        {
            InitializeComponent();
            Text = Caption;
            mlb_Message.Text = Message;
            mbt_Choice1.Text = ButtonCapion1;
            mbt_Choice2.Text = ButtonCapion2;
        }
    }
}
