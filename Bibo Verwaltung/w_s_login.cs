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
    public partial class w_s_login : Form
    {
        public w_s_login()
        {
            InitializeComponent();
        }
        private void anmelden()
        {
            Benutzer user = new Benutzer();
            string name = tb_User.Text;
            string pw = tb_Passw.Text;
            if (user.Login(pw, name) == true)
            {
                this.Hide();
                Form Main = new w_s_main(name);
                Main.Closed += (s, args) => this.Close();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Die Anmeldedaten sind falsch. Bitte versuchen Sie es erneut", "Falsche Daten!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Passw.Clear();
            }
        }
        private void bt_Login_Click(object sender, EventArgs e)
        {
            anmelden();
        }


        private void tb_Passw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                anmelden();
            }
        }
    }
}
