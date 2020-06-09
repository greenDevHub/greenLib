using MetroFramework;
using MetroFramework.Components;
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
    public partial class w_s_exemplarSuche : MetroFramework.Forms.MetroForm
    {
        Buch buch = new Buch();

        string exemplarID;
        public string ExemplarID { get { return exemplarID; } set { exemplarID = value; } }

        int currentstufe;
        public int CurrentStufe { get { return currentstufe; } set { currentstufe = value; } }

        Color fc = Color.Black;
        Color bc = Color.White;

        #region Constructor
        string currentUser;
        public w_s_exemplarSuche(string userName, int stufe, MetroStyleManager msm)
        {
            InitializeComponent();
            msm_exemplarsuche = msm;
            this.StyleManager = msm;
            this.StyleManager.Style = MetroColorStyle.Yellow;
            if (this.StyleManager.Theme == MetroThemeStyle.Dark)
            {
                fc = Color.White;
                bc = System.Drawing.ColorTranslator.FromHtml("#111111");
                a_cb_Buecher.ForeColor = fc;
                a_cb_Buecher.BackColor = bc;

            }
            this.currentUser = userName;
            this.currentstufe = stufe;
            this.Text = Text + " - Angemeldet als: " + userName;
            buch.FillComboSuche(ref a_cb_Buecher, CurrentStufe, 0);
            a_cb_Buecher.SelectedIndex = 0;
        }
        #endregion

        private void AdvancedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a_cb_Buecher.SelectedItem != null)
            {
                gv_Exemplare.DataSource = new Exemplar().GetBuchSucheExemplare(CurrentStufe, a_cb_Buecher.SelectedValue.ToString());
                gv_Exemplare.Refresh();
            }
        }

        private void Mbt_OK_Click(object sender, EventArgs e)
        {
            if (gv_Exemplare.CurrentRow != null)
            {
                this.ExemplarID = gv_Exemplare.Rows[gv_Exemplare.CurrentRow.Index].Cells["ExemplarID"].Value.ToString();
            }
            else
            {
                this.ExemplarID = "0";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Gv_Exemplare_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gv_Exemplare.CurrentRow != null)
            {
                this.ExemplarID = gv_Exemplare.Rows[gv_Exemplare.CurrentRow.Index].Cells["ExemplarID"].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.ExemplarID = "0";
            }
        }
    }
}
