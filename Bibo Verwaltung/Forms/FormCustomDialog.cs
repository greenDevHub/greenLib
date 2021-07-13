using Bibo_Verwaltung.Helper;

namespace Bibo_Verwaltung
{
    public partial class CustomDialog : MetroFramework.Forms.MetroForm
    {
        public CustomDialog(string caption, string message, string buttonCaption1, string buttonCaption2)
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
