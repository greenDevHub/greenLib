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

        #region Constructor
        string currentUser;
        public w_s_exemplarSuche(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            buch.FillCombobox(ref a_cb_Buecher, 0);
            a_cb_Buecher.SelectedIndex = 0;
        }
        #endregion

        private void AdvancedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a_cb_Buecher.SelectedItem != null)
            {
                gv_Exemplare.DataSource = new Exemplar().GetAllExemplare(a_cb_Buecher.SelectedValue.ToString());
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
