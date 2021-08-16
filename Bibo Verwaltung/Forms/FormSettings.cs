using Bibo_Verwaltung.Forms;
using Bibo_Verwaltung.Helper;
using MetroFramework;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormSettings : MetroFramework.Forms.MetroForm
    {
        Settings settings = new Settings();
        float originalRowHeight = 0;
        public FormSettings()
        {
            InitializeComponent();
            LoadTheme();

            this.StartPosition = FormStartPosition.CenterScreen;
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

        #region FileHandling: SetSettings(), GetSettings()
        private void SetSettings(object sender, EventArgs e)
        {
            if (!HasInputErrors())
            {
                SetWhite();
                settings.Server = tb_Server.Text;
                settings.Security = cb_Security.Text;
                settings.DatabaseLoginName = tb_Benutzername.Text;
                settings.DatabaseLoginPassword = tb_Passwort.Text;
                settings.Database = tb_Database.Text;
                int i = settings.SaveSettings(true);
                if (i == 0)
                {
                    MetroMessageBox.Show(this, "Datenbankserver-Verbindung erfolgreich gespeichert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (i == 1)
                {
                    MetroMessageBox.Show(this, "Speichern fehlgeschlagen. Die Konfigurationsdatei ist schreibgeschützt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(this, "Die Änderungen konnten nicht übernommen werden. Die Konfigurationsdatei ist schreibgeschützt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
        }

        private void GetSettings()
        {
            if (settings.LoadSettings() == 2)
            {
                MetroMessageBox.Show(this, "Unbekannte Authentifizierungsart. Windows Authentifizierung wurde ausgewählt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            tb_Server.Text = settings.Server;
            tb_Database.Text = settings.Database;
            cb_Security.Text = settings.Security;
            tb_Benutzername.Text = settings.DatabaseLoginName;
            tb_Passwort.Text = settings.DatabaseLoginPassword;
        }
        #endregion

        #region  ColorHandling: ErrorHandling(), SetWhite();
        private bool HasInputErrors()
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
            if (error) { MetroMessageBox.Show(this, "Bitte füllen Sie alle Felder aus!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
            settings.Server = tb_Server.Text;
            settings.Security = cb_Security.Text;
            settings.DatabaseLoginName = tb_Benutzername.Text;
            settings.DatabaseLoginPassword = tb_Passwort.Text;
            settings.Database = tb_Database.Text;
            settings.SaveSettings(false);
            CustomSqlConnection con = new CustomSqlConnection();
            if (!con.ConnectError())
            {
                MetroMessageBox.Show(this, "Verbindung konnte erfolgreich hergestellt werden!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }
        #endregion

        private void Bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAbout_Click(object sender, EventArgs e)
        {
            ShowAboutPage();
        }

        private void ShowAboutPage()
        {
            FormAboutPage aboutForm = new FormAboutPage();
            aboutForm.ShowDialog(this);
            aboutForm.Dispose();
        }
    }
}