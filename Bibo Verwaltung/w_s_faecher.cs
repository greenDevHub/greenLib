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
    public partial class w_s_faecher : MetroFramework.Forms.MetroForm
    {
        string currentUser;
        float originalHeightLabel = 0;
        float originalHeightText = 0;
        bool changes = false;
        Fach f = new Fach();
        bool suchmodus = false;

        public w_s_faecher(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            f.FillGrid(ref gv_Faecher);
            originalHeightLabel = tLP_Faecher.RowStyles[0].Height;
            originalHeightText = tLP_Faecher.RowStyles[1].Height;
            tLP_Faecher.RowStyles[0].Height = 0;
            tLP_Faecher.RowStyles[1].Height = 0;
        }

        #region Componenten-Aktionen
        private void gv_Verlage_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            changes = true;
        }

        private void gv_Verlage_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            changes = true;
        }

        private void w_s_faecher_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (changes == true)
            {
                gv_Faecher.EndEdit();
                DialogResult dr = MessageBox.Show("Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        bt_Uebernehmen.Focus();
                        f.SaveGrid(ref gv_Faecher);
                    }
                    catch
                    {
                        MessageBox.Show("Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void bt_import_Click_1(object sender, EventArgs e)
        {
            Form Import = new w_s_schuelerimport("t_s_faecher", true);
            Import.ShowDialog(this);
            f.FillGrid(ref gv_Faecher);
        }

        private void bt_Suchen_Click(object sender, EventArgs e)
        {
            if (suchmodus == false)
            {
                lb_Faecher.Visible = true;
                suchmodus = true;
                bt_Suchen.Text = "Suchen AUS";
                tLP_Faecher.RowStyles[0].Height = originalHeightLabel;
                tLP_Faecher.RowStyles[1].Height = originalHeightText;
                tb_Suchen.Visible = true;
                tb_Suchen.Enabled = true;
                tb_Suchen.Focus();
            }
            else
            {
                lb_Faecher.Visible = false;
                suchmodus = false;
                bt_Suchen.Text = "Suchen AN";
                tb_Suchen.Visible = false;
                tb_Suchen.Enabled = false;
                tb_Suchen.Text = "";
                tLP_Faecher.RowStyles[0].Height = 0;
                tLP_Faecher.RowStyles[1].Height = 0;
            }
        }

        private void tb_Suchen_TextChanged(object sender, EventArgs e)
        {
            (gv_Faecher.DataSource as DataTable).DefaultView.RowFilter = string.Format("Langbezeichnung LIKE '{0}%'", tb_Suchen.Text);
        }

        private void bt_Verwaltung_Click(object sender, EventArgs e)
        {
            Form fachstufe = new w_s_fach_stufe(currentUser);
            fachstufe.ShowDialog(this);
        }
        #endregion
    }
}
