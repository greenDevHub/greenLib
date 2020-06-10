using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using Bibo_Verwaltung.EasterEgg;

namespace Bibo_Verwaltung
{
    public partial class w_s_login : MetroFramework.Forms.MetroForm
    {
        public w_s_login()
        {
            InitializeComponent();
            this.StyleManager = msm_login;
            RefreshTheme();
            timer1.Start();
            tb_Password.Focus();
            tb_User.Focus();
        }

        private void RefreshTheme()
        {
            ConfigurationManager.RefreshSection("appSettings");
            string darkmode = ConfigurationManager.AppSettings["darkmode"];
            if (darkmode == "true")
            {
                this.StyleManager.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                this.StyleManager.Theme = MetroThemeStyle.Light;
            }
        }
        // private bool error = false;

        private void Anmelden()
        {
            //this.Hide();
            //Form Main = new w_s_main("test");
            //Main.Closed += (s, args) => this.Close();
            //Main.Show();
            SQL_Verbindung con = new SQL_Verbindung();
            //string test = con.ConnectionString;
            if (con.ConnectError())
            {
                //error = true;
                w_s_einstellungen Einstellungen = new w_s_einstellungen(this.StyleManager);
                this.StyleManager.Clone(Einstellungen);
                Einstellungen.ShowDialog(this);
                Einstellungen.Dispose();
                return;
            }
            //else
            //{
            //    error = false;
            //}

            Benutzer user = new Benutzer();
            string name = tb_User.Text;
            string pw = tb_Password.Text;
            if (user.LoginUser(pw, name) == true)
            {
                this.Hide();
                w_s_main Main = new w_s_main(name, this.StyleManager);
                this.StyleManager.Clone(Main);
                Main.Closed += (s, args) => this.Close();
                Main.Show();
            }
            else
            {
                //MetroMessageBox.Show(this,"Die Anmeldedaten sind falsch. Bitte versuchen Sie es erneut!", "Falsche Daten!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MetroMessageBox.Show(this, "Die Anmeldedaten sind falsch. Bitte versuchen Sie es erneut!", "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Password.Clear();

            }
        }

        private void bt_Login_Click(object sender, EventArgs e)
        {
            Anmelden();
            timer1.Stop();
        }

        private void tb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Anmelden();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            if (tb_User.Text == "Snake")
            {
                form_snake snake = new form_snake(this.StyleManager);
                this.StyleManager.Clone(snake);
                snake.ShowDialog();
                snake.Dispose();
            }

        }

        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    //if (metroProgressBar1.Value == 100)
        //    //{
        //    //    metroProgressBar1.Value = 0;
        //    //}
        //    //metroProgressBar1.Invoke((Action)delegate ()
        //    //{
        //    //    metroProgressBar1.PerformStep();
        //    //});
        //}
    }
}
