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
using MetroFramework;
using Bibo_Verwaltung.Helper;
using MetroFramework.Components;

namespace Bibo_Verwaltung
{
    public partial class w_s_einstellungen : MetroFramework.Forms.MetroForm
    {
        Settings set = new Settings();
        int originalHeight = 0;
        float originalRowHeight = 0;
        public w_s_einstellungen()
        {
            InitializeComponent();
            LoadTheme();

            this.StartPosition = FormStartPosition.CenterScreen;
            originalHeight = ClientSize.Height;
            originalRowHeight = tLP_Top.RowStyles[3].Height;
            GetSettings();
        }
        private void LoadTheme()
        {
            this.StyleManager = styleManagerSettings;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.SettingsStyle;
            cb_Security.ForeColor = ThemeInfo.ForeColor;
            cb_Security.BackColor = ThemeInfo.BackColor;
        }

        private bool File_Exists()
        {
            if (File.Exists(set.ConnectionSettingPath))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region FileHandling: SetSettings(), GetSettings()
        private void SetSettings(object sender, EventArgs e)
        {
            if (!ErrorHandling())
            {
                SetWhite();
                set.Server = tb_Server.Text;
                set.Security = cb_Security.Text;
                set.DatabaseLoginName = tb_Benutzername.Text;
                set.DatabaseLoginPassword = tb_Passwort.Text;
                set.Database = tb_Database.Text;
                int i = set.SaveSettings(true);
                if(i == 0)
                {
                    MetroMessageBox.Show(this, "Datenbankserver-Verbindung erfolgreich gespeichert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(i == 1)
                {
                    MetroMessageBox.Show(this, "Speichern fehlgeschlagen. Die Konfigurationsdatei ist schreibgeschützt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(this,"Die Änderungen konnten nicht übernommen werden. Die Konfigurationsdatei ist schreibgeschützt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                    
                
            }
        }

        private void GetSettings()
        {
            if(set.LoadSettings() == 2)
            {
                MetroMessageBox.Show(this,"Unbekannte Authentifizierungsart. Windows Authentifizierung wurde ausgewählt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tb_Server.Text = set.Server;
            tb_Database.Text = set.Database;
            cb_Security.Text = set.Security;
            tb_Benutzername.Text = set.DatabaseLoginName;
            tb_Passwort.Text = set.DatabaseLoginPassword;
        }
        #endregion

        #region  ColorHandling: ErrorHandling(), SetWhite();
        private bool ErrorHandling()
        {
            bool error = false;
            if (cb_Security.Text == "Windows Authentifizierung")
            {
                if (tb_Server.Text == "") { tb_Server.BackColor = Color.Red; error = true; }
                if (tb_Database.Text == "") { tb_Database.BackColor = Color.Red; error = true; }
                if (cb_Security.Text == "") { cb_Security.BackColor = Color.Red; error = true; }
            }
            else if (cb_Security.Text == "SQL Authentifizierung")
            {
                if (tb_Server.Text == "") { tb_Server.BackColor = Color.Red; error = true; }
                if (tb_Database.Text == "") { tb_Database.BackColor = Color.Red; error = true; }
                if (cb_Security.Text == "") { cb_Security.BackColor = Color.Red; error = true; }
                if (tb_Benutzername.Text == "") { tb_Benutzername.BackColor = Color.Red; error = true; }
                if (tb_Passwort.Text == "") { tb_Passwort.BackColor = Color.Red; error = true; }
            }
            if (error) { MetroMessageBox.Show(this,"Bitte füllen Sie alle Felder aus!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            return error;
        }

        private void SetWhite()
        {
            tb_Database.BackColor = ThemeInfo.BackColor;
            tb_Server.BackColor = ThemeInfo.BackColor;
            tb_Benutzername.BackColor = ThemeInfo.BackColor;
            tb_Passwort.BackColor = ThemeInfo.BackColor;
            cb_Security.BackColor = ThemeInfo.BackColor;
        }
        #endregion

        #region Buttons: ClearAll(), TestConnect();
        private void ClearAll(object sender, EventArgs e)
        {
            tb_Server.Text = "";
            tb_Database.Text = "";
            cb_Security.Text = "";
            tb_Benutzername.Text = "";
            tb_Passwort.Text = "";
            SetWhite();
            tb_Server.Focus();
        }

        private void TestConnect(object sender, EventArgs e)
        {
            set.Server = tb_Server.Text;
            set.Security = cb_Security.Text;
            set.DatabaseLoginName = tb_Benutzername.Text;
            set.DatabaseLoginPassword = tb_Passwort.Text;
            set.Database = tb_Database.Text;
            set.SaveSettings(false);
            CustomSqlConnection con = new CustomSqlConnection();
            if (!con.ConnectError())
            {
                MetroMessageBox.Show(this,"Verbindung konnte erfolgreich hergestellt werden!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bt_Save.Focus();
            }
            else
            {
                MetroMessageBox.Show(this, "Die Verbindung konnte nicht hergestellt werden. Bitte überprüfen Sie Ihre Einstellungen.", "Keine Verbindung.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bt_Save.Focus();
            }
        }
        #endregion

        #region Visibility-Mode: Visibility()
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
                //this.ClientSize = new System.Drawing.Size(ClientSize.Width, (originalHeight * 72) / 100);
            }
            else if (cb_Security.Text == "SQL Authentifizierung")
            {
                tb_Benutzername.Visible = true;
                lb_Benutzername.Visible = true;
                tb_Passwort.Visible = true;
                lb_Passwort.Visible = true;
                tLP_Top.RowStyles[3].Height = originalRowHeight;
                tLP_Top.RowStyles[4].Height = originalRowHeight;
                //this.ClientSize = new System.Drawing.Size(ClientSize.Width, originalHeight);
            }
        }
        #endregion

        private void Bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}