using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bibo_Verwaltung
{
    public partial class w_s_einstellungen : Form
    {
        Einstellung set = new Einstellung();

        public w_s_einstellungen()
        {
            InitializeComponent();
            Load();
        }

        private bool File_Exists()
        {
            if (File.Exists(set.path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region FileHandling
        private void Save(object sender, EventArgs e)
        {

        }

        private void Load()
        {
            set.Load();
            tb_Server.Text = set.Server;
            tb_Database.Text = set.Database;
            cb_Security.Text = set.Security;
            tb_Benutzername.Text = set.Name;
            tb_Passwort.Text = set.Pw;
        }
        #endregion

        private void ErrorHandling()
        {
            if (tb_Server.Text == "") tb_Server.BackColor = Color.Red;
            if (tb_Database.Text == "") tb_Database.BackColor = Color.Red;
            if (cb_Security.Text == "") cb_Security.BackColor = Color.Red;
            if (tb_Benutzername.Text == "") tb_Benutzername.BackColor = Color.Red;
            if (tb_Passwort.Text == "") tb_Passwort.BackColor = Color.Red;
            MessageBox.Show("Bitte füllen Sie alle Felder aus");
        }

        #region Buttons
        private void Reset(object sender, EventArgs e)
        {
            tb_Server.Text = "";
            tb_Database.Text = "";
            cb_Security.Text = "";
            tb_Benutzername.Text = "";
            tb_Passwort.Text = "";
        }

        private void tb_White(object sender, EventArgs e)
        {
            tb_Database.BackColor = Color.White;
            tb_Server.BackColor = Color.White;
            tb_Benutzername.BackColor = Color.White;
            tb_Passwort.BackColor = Color.White;
            cb_Security.BackColor = Color.White;
        }

        private void Visibility(object sender, EventArgs e)
        {
            if (cb_Security.Text == "Windows Authentifizierung")
            {
                tb_Benutzername.Visible = false;
                lb_Benutzername.Visible = false;
                tb_Passwort.Visible = false;
                lb_Passwort.Visible = false;
                bt_save.Location = new Point(258, 214);
                bt_Laden.Location = new Point(486, 214);
                bt_Schließen.Location = new Point(258, 288);
                button1.Location = new Point(436, 288);
                ClientSize = new Size(764, 428);
                groupBox1.Size = new Size(716, 381);
            }
            else if (cb_Security.Text == "SQL Authentifizierung")
            {
                tb_Benutzername.Visible = true;
                lb_Benutzername.Visible = true;
                tb_Passwort.Visible = true;
                lb_Passwort.Visible = true;
                bt_save.Location = new Point(258, 337);
                bt_Laden.Location = new Point(486, 337);
                bt_Schließen.Location = new Point(258, 411);
                button1.Location = new Point(436, 411);
                ClientSize = new Size(764, 564);
                groupBox1.Size = new Size(716, 517);
            }
        }

        private void bt_Load(object sender, EventArgs e)
        {
            Load();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            bool auth;
            if (set.Security == "SQL Authentifizierung") auth = false;
            else auth = true;
            SQL_Verbindung con = new SQL_Verbindung(set.Server, set.Database, auth, set.Name, set.Pw);
            if (con.ConnectError())
            {
                MessageBox.Show("Verbindung zum Server " + set.Server + " fehlgeschlagen");
            }
            else
            {
                MessageBox.Show("Verbindung hergestellt");
            }
        }
    }
}