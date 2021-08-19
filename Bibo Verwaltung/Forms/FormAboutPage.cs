using Bibo_Verwaltung.Helper;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung.Forms
{
    public partial class FormAboutPage : MetroForm
    {
        VersionHelper helper;
        public FormAboutPage()
        {
            InitializeComponent();
            helper = new VersionHelper();
            LoadVersionNumber();
            LoadTheme();
        }
        private void LoadTheme()
        {
            this.StyleManager = styleManagerAbout;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.DialogStyle;
        }

        private void btCheckForVersion_Click(object sender, EventArgs e)
        {
            CheckForNewVersion();
        }

        private void LoadVersionNumber()
        {
            lbVersionNumber.Text = helper.CurrentVersion;
        }
        private void CheckForNewVersion()
        {
            if (helper.isNewVersionAvailable())
            {
                DialogResult dr = MetroMessageBox.Show(this, $"Ein Update ({helper.NewestVersion}) ist verfügbar. Sie haben aktuell die Version {helper.CurrentVersion} installiert. Möchten Sie das Update herunterladen?", "Update verfügbar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    //load update
                    helper.DownloadNewVersion();
                }
            }
            else
            {
                MetroMessageBox.Show(this, $"Sie haben bereits die neuste Version ({helper.CurrentVersion}) der Software installiert.", "Keine Neue Version gefunden", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lbNewestVersionNumber.Text = helper.NewestVersion;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btNews_Click(object sender, EventArgs e)
        {
            FormUpdateLog updateLog = new FormUpdateLog();
            updateLog.ShowDialog(this);
            updateLog.Dispose();
        }
    }
}
