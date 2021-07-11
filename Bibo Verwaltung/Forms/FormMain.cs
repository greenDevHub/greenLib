using Bibo_Verwaltung.Helper;
using MetroFramework;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormMain : MetroFramework.Forms.MetroForm
    {
        #region constructor
        public FormMain()
        {
            InitializeComponent();

            this.Text = "     greenLib" + AuthInfo.FormInfo();

            LoadTheme();
            SetPermissions();
            CreateWorkingDirectory();

            animationTimer.Start();
        }
        #endregion

        private bool IsConnected()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError())
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void LoadTheme()
        {
            ThemeInfo.Init();
            this.StyleManager = styleManagerMain;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.MainStyle;
        }
        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId.Equals("0") || AuthInfo.CurrentUser.PermissionId.Equals("1"))
            {
                mT_Benutzerverwaltung.Enabled = false;
                mT_Einstellungen.Enabled = false;
            }
            else if (AuthInfo.CurrentUser.PermissionId == 2)
            {
                mT_Benutzerverwaltung.Enabled = true;
                mT_Einstellungen.Enabled = true;
            }
        }
        private void CreateWorkingDirectory()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.Directory.CreateDirectory(path + "\\greenLib");
            System.IO.Directory.CreateDirectory(path + "\\greenLib\\Bilder");
            System.IO.Directory.CreateDirectory(path + "\\greenLib\\Einstellungen");
            System.IO.Directory.CreateDirectory(path + "\\greenLib\\Downloads");
            string strFilePath = path + "\\greenLib\\Einstellungen\\BarcodePreset.lbx";
            if (!File.Exists(strFilePath)) File.Delete(strFilePath);
            File.WriteAllBytes(strFilePath, Properties.Resources.BarcodePreset);
        }

        #region open new forms
        private void btCostumerClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            FormCostumer formCostumer = new FormCostumer();
            formCostumer.ShowDialog(this);
            formCostumer.Dispose();
        }

        private void btGenreClick(object sender, EventArgs e)
        {
            ShowFormAttribute("Genre");
        }

        private void btLanguageClick(object sender, EventArgs e)
        {
            ShowFormAttribute("Sprache");
        }

        private void btAuthorClick(object sender, EventArgs e)
        {
            ShowFormAttribute("Autor");
        }

        private void btClassClick(object sender, EventArgs e)
        {
            ShowFormAttribute("Klasse");
        }


        private void btPublisherClick(object sender, EventArgs e)
        {
            ShowFormAttribute("Verlag");
        }
        private void ShowFormAttribute(string name)
        {
            if (!IsConnected()) return;
            FormAttribute formAttribute = new FormAttribute(name);
            formAttribute.ShowDialog(this);
            formAttribute.Dispose();
        }
        private void btBooksClick(object sender, EventArgs e)
        {
            //TODO
            if (!IsConnected()) return;
            Form_Books formBooks = new Form_Books(true);
            formBooks.ShowDialog();
            formBooks.Dispose();
        }

        private void btSettingsClick(object sender, EventArgs e)
        {
            w_s_einstellungen formSettings = new w_s_einstellungen();
            formSettings.ShowDialog(this);
            formSettings.Dispose();
        }

        private void btConditionClick(object sender, EventArgs e)
        {
            ShowFormAttribute("Zustand");
        }

        private void btOverviewClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            FormOverview formOverview = new FormOverview();
            formOverview.ShowDialog(this);
            formOverview.Dispose();
        }

        private void btUserClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            FormUser formUser = new FormUser();
            formUser.ShowDialog(this);
            formUser.Dispose();
        }

        private void btSubjectClick(object sender, EventArgs e)
        {
            ShowFormAttribute("Fach");
        }

        private void btLogoutClick(object sender, EventArgs e)
        {
            AuthInfo.CurrentUser = null;
            Application.Restart();
        }

        private void animationTimerTick(object sender, EventArgs e)
        {
            if (metroProgressBar.Value == 100)
            {
                animationTimer.Stop();
            }
            metroProgressBar.Invoke((Action)delegate ()
            {
                metroProgressBar.PerformStep();
            });
        }

        private void btBorrowingClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            w_s_ausleihe formBorrowing = new w_s_ausleihe();
            formBorrowing.ShowDialog(this);
            formBorrowing.Dispose();
        }

        private void btReturnClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            w_s_rueckgabe formReturn = new w_s_rueckgabe();
            formReturn.ShowDialog(this);
            formReturn.Dispose();
        }

        #region EasterEgg
        int counter = 0;
        int secondCounter = 0;
        private void image_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter == 5)
            {
                secondCounter++;
                if (secondCounter == 3)
                {
                    MetroMessageBox.Show(this, "Geben Sie im Login-Fenster als Benutzername 'Snake' ein und klicken Sie auf das Schloss-Symbol!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    secondCounter = 0;
                    counter = 0;
                }
                else
                {
                    MetroMessageBox.Show(this, "Herzlichen Glückwunsch! Sie haben Langeweile!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    counter = 0;
                }

            }

        }
        #endregion

        private void btAssignmentClick(object sender, EventArgs e)
        {
            w_s_zuordnungen formAssignment = new w_s_zuordnungen();
            formAssignment.ShowDialog(this);
            formAssignment.Dispose();
        }
        private void btAutoReturnClick(object sender, EventArgs e)
        {
            if (!IsConnected()) return;
            w_s_selfmade_dialog formDialog = new w_s_selfmade_dialog("Modusauswahl", "Wählen Sie den Ausleih- oder den Rückgabe-Modus!",
                "Ausleih-Modus", "Rückgabe-Modus");
            formDialog.ShowDialog(this);
            if (formDialog.DialogResult == DialogResult.Yes)
            {
                w_s_automatic formAutoBorrow = new w_s_automatic();
                formAutoBorrow.ShowDialog(this);
                formAutoBorrow.Dispose();
            }
            else if (formDialog.DialogResult == DialogResult.No)
            {
                w_s_autorueck formAutoReturn = new w_s_autorueck();
                formAutoReturn.ShowDialog(this);
                formAutoReturn.Dispose();
            }
        }

        private void btChangeThemeClick(object sender, EventArgs e)
        {
            ThemeInfo.Change();
            LoadTheme();
        }

        private void btHelpClick(object sender, EventArgs e)
        {
            try
            {
                string openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\greenLib\greenLib Handbuch.pdf";
                File.WriteAllBytes(openPDFFile, global::Bibo_Verwaltung.Properties.Resources.Handbuch);
                Process.Start(openPDFFile);
            }
            catch
            {
                MetroMessageBox.Show(this, "Es ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    #endregion
}