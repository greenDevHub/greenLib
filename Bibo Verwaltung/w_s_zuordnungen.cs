using MetroFramework;
using MetroFramework.Components;
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

namespace Bibo_Verwaltung
{
    public partial class w_s_zuordnungen : MetroForm
    {
        bool connected = false;
        string currentUser = "";
        CustomSqlConnection connection = new CustomSqlConnection();
        public w_s_zuordnungen(MetroStyleManager msm, string currentUser)
        {
            InitializeComponent();
            connected = connection.ConnectError();
            this.currentUser = currentUser;
            msm_zuordnung = msm;
            this.StyleManager = msm;
            this.StyleManager.Style = MetroColorStyle.Orange;
            //if(this.StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
            //{
            //    this.StyleManager.Style = MetroFramework.MetroColorStyle.Black;
            //}
            //else
            //{
            //    this.StyleManager.Style = MetroFramework.MetroColorStyle.White;
            //}
        }

        private void MetroTile1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MT_klassenstufebuch_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                w_s_buch_stufe buchStufe = new w_s_buch_stufe(currentUser, this.StyleManager);
                this.StyleManager.Clone(buchStufe);
                buchStufe.ShowDialog(this);
                buchStufe.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MT_fachbuch_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                w_s_buch_fach buchFach = new w_s_buch_fach(currentUser, this.StyleManager);
                this.StyleManager.Clone(buchFach);
                buchFach.ShowDialog(this);
                buchFach.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MT_klassenstufefach_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                w_s_fach_stufe fachStufe = new w_s_fach_stufe(currentUser, this.StyleManager);
                this.StyleManager.Clone(fachStufe);
                fachStufe.ShowDialog(this);
                fachStufe.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MT_Klassenstufen_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                w_s_klasse_stufe stufe = new w_s_klasse_stufe(currentUser, this.StyleManager);
                this.StyleManager.Clone(stufe);
                stufe.ShowDialog(this);
                stufe.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
