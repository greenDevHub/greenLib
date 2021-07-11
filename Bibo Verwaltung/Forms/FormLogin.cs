using Bibo_Verwaltung.EasterEgg;
using Bibo_Verwaltung.Helper;
using MetroFramework;
using System;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormLogin : MetroFramework.Forms.MetroForm
    {
        public FormLogin()
        {
            InitializeComponent();
            LoadTheme();
            animationTimer.Start();
            tb_Password.Focus();
            tb_User.Focus();
        }

        private void LoadTheme()
        {
            ThemeInfo.Init();
            this.StyleManager = styleManagerLogin;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
        }

        private void Login()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError())
            {
                MetroMessageBox.Show(this, "Die Verbindung zum SQL-Server konnte nicht hergestellt werden. " +
                    "Bitte überprüfen Sie die Verbindungseinstellungen.", "Keine Verbindung.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                w_s_einstellungen formSettings = new w_s_einstellungen();
                formSettings.ShowDialog(this);
                formSettings.Dispose();
                return;
            }


            User user = new User(tb_User.Text);
            string userPassword = tb_Password.Text;
            if (user.CanLogin(userPassword))
            {
                AuthInfo.CurrentUser = user;
                this.Hide();
                FormMain formMain = new FormMain();
                formMain.Closed += (s, args) => this.Close();
                formMain.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Die Anmeldedaten sind falsch. Bitte versuchen Sie es erneut!", "Fehler!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Password.Clear();
            }
        }

        private void btLoginClicked(object sender, EventArgs e)
        {
            Login();
            animationTimer.Stop();
        }

        private void tbPasswordKeydown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void IconCLick(object sender, EventArgs e)
        {
            if (tb_User.Text.Equals("Snake", StringComparison.InvariantCultureIgnoreCase))
            {
                form_snake snake = new form_snake();
                snake.ShowDialog();
                snake.Dispose();
                tb_User.Text = "";
            }
        }
    }
}
