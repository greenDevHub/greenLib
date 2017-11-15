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
        int originalHeight = 0;
        float originalRowHeight = 0;

        public w_s_einstellungen()
        {
            InitializeComponent();
            originalHeight = ClientSize.Height;
            originalRowHeight = tLP_Top.RowStyles[3].Height;
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
            set.Server = tb_Server.Text;
            set.Security = cb_Security.Text;
            set.Name = tb_Benutzername.Text;
            set.Pw = tb_Passwort.Text;
            set.Database = tb_Database.Text;
            set.Save(true);
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
            MessageBox.Show("Bitte füllen Sie alle Felder aus", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                tb_Benutzername.Text = "";
                tb_Passwort.Text = "";
                tLP_Top.RowStyles[3].Height = 0;
                tLP_Top.RowStyles[4].Height = 0;
                this.ClientSize = new System.Drawing.Size(ClientSize.Width, (originalHeight*72)/100);
            }
            else if (cb_Security.Text == "SQL Authentifizierung")
            {
                tb_Benutzername.Visible = true;
                lb_Benutzername.Visible = true;
                tb_Passwort.Visible = true;
                lb_Passwort.Visible = true;
                tLP_Top.RowStyles[3].Height = originalRowHeight;
                tLP_Top.RowStyles[4].Height = originalRowHeight;
                this.ClientSize = new System.Drawing.Size(ClientSize.Width, originalHeight);
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            set.Server = tb_Server.Text;
            set.Security = cb_Security.Text;
            set.Name = tb_Benutzername.Text;
            set.Pw = tb_Passwort.Text;
            set.Database = tb_Database.Text;
            set.Save(false);
            SQL_Verbindung con = new SQL_Verbindung();
            if (!con.ConnectError())
            {
                MessageBox.Show("Verbindung hergestellt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}