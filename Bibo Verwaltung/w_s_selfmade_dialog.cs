using Bibo_Verwaltung.Helper;
using MetroFramework.Components;
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
        public w_s_selfmade_dialog(string caption, string message, string buttonCaption1, string buttonCaption2)
        {
            InitializeComponent();
            LoadTheme();
            Text = caption;
            mlb_Message.Text = message;
            mbt_Choice1.Text = buttonCaption1;
            mbt_Choice2.Text = buttonCaption2;
        }
        private void LoadTheme()
        {
            this.StyleManager = styleManagerDialog;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.DialogStyle;
        }
    }
}
