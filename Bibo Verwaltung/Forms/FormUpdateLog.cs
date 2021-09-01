using Bibo_Verwaltung.Helper;
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
    public partial class FormUpdateLog : MetroForm
    {
        public FormUpdateLog()
        {
            InitializeComponent();
            LoadTheme();
            SetUpdateText();
            Properties.Settings.Default.startedAfterInstall = true;
            Properties.Settings.Default.Save();
        }
        private void LoadTheme()
        {
            this.StyleManager = styleManagerLog;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.DialogStyle;
        }

        private void SetUpdateText()
        {
            VersionHelper helper = new VersionHelper();
            VersionChange change = helper.GetChanges(helper.CurrentVersion);
            this.Text = $"Neuigkeiten zu Version {helper.CurrentVersion}";
            lbNews.Text = change.GetChanges();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
