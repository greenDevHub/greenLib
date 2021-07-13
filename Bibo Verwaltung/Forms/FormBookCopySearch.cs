using Bibo_Verwaltung.Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormBookCopySearch : MetroFramework.Forms.MetroForm
    {
        BookHelper bookHelper = new BookHelper();
        CopyHelper copyHelper = new CopyHelper();

        string exemplarID;
        public string ExemplarID { get { return exemplarID; } set { exemplarID = value; } }

        int currentstufe;
        public int CurrentStufe { get { return currentstufe; } set { currentstufe = value; } }

        Color fc = Color.Black;
        Color bc = Color.White;

        #region Constructor
        public FormBookCopySearch(int stufe)
        {
            InitializeComponent();
            LoadTheme();
            this.currentstufe = stufe;
            this.Text = Text + AuthInfo.FormInfo();
            bookHelper.FillComboboxSearch(ref a_cb_Buecher, CurrentStufe, 0);
            a_cb_Buecher.SelectedIndex = 0;
        }
        #endregion
        private void LoadTheme()
        {
            this.StyleManager = styleManagerCopySearch;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.AutoBorrowStyle;
            a_cb_Buecher.ForeColor = ThemeInfo.ForeColor;
            a_cb_Buecher.BackColor = ThemeInfo.BackColor;

        }

        private void AdvancedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a_cb_Buecher.SelectedItem != null)
            {
                gv_Exemplare.DataSource = copyHelper.FillObjectSearch(CurrentStufe, a_cb_Buecher.SelectedValue.ToString());
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
