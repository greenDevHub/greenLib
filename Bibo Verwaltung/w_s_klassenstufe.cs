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
    public partial class w_s_klassenstufe : MetroFramework.Forms.MetroForm
    {
        public w_s_klassenstufe()
        {
            InitializeComponent();
            klassenstufe.FillGrid(ref gv_Klassenstufe);
            originalHeightLabel = tLP_Klassenstufe.RowStyles[0].Height;
            originalHeightText = tLP_Klassenstufe.RowStyles[1].Height;
            tLP_Klassenstufe.RowStyles[0].Height = 0;
            tLP_Klassenstufe.RowStyles[1].Height = 0;
        }
        #region globale Variablen
        float originalHeightLabel = 0;
        float originalHeightText = 0;
        Klassenstufe klassenstufe = new Klassenstufe();
        bool suchmodus = false;
        bool aenderungungen = false;
        #endregion

        #region Schliessen-Aktion
        private void w_s_klassenstufe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aenderungungen == true)
            {
                gv_Klassenstufe.EndEdit();
                DialogResult dr = MessageBox.Show("Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        bt_Uebernehmen.Focus();
                        klassenstufe.SaveGrid(ref gv_Klassenstufe);
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

        #endregion

        #region Zeile löschen mit Ruecktaste
        private void dataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                SendKeys.Send("{DELETE}");
            }
        }
        #endregion

        #region Suchen-Aktionen
        private void bt_Suchen_Click(object sender, EventArgs e)
        {
            if (suchmodus == false)
            {
                suchmodus = true;
                bt_Suchen.Text = "Suchen AUS";
                tLP_Klassenstufe.RowStyles[0].Height = originalHeightLabel;
                tLP_Klassenstufe.RowStyles[1].Height = originalHeightText;
                tb_Suchen.Visible = true;
                tb_Suchen.Enabled = true;
                tb_Suchen.Focus();
            }
            else
            {
                suchmodus = false;
                bt_Suchen.Text = "Suchen AN";
                tb_Suchen.Visible = false;
                tb_Suchen.Enabled = false;
                tb_Suchen.Text = "";
                tLP_Klassenstufe.RowStyles[0].Height = 0;
                tLP_Klassenstufe.RowStyles[1].Height = 0;
            }
        }
        private void tb_Suchen_TextChanged(object sender, EventArgs e)
        {
            //(gv_Klassenstufe.DataSource as DataTable).DefaultView.RowFilter = string.Format("Klassenstufe LIKE '{0}%'", tb_Suchen.Text);
        }
        #endregion

        #region Aenderungen an GridView erkennen
        private void gv_klassenstufen_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            aenderungungen = true;
        }

        private void gv_klassenstufen_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            aenderungungen = true;
        }
        #endregion

        private void gv_Klassenstufen_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string s = gv_Klassenstufe.Rows[e.RowIndex].Cells[1].Value.ToString();
            for (int i = 0; i < gv_Klassenstufe.Rows.Count - 2; i++)
            {
                if (s == gv_Klassenstufe.Rows[i].Cells[1].Value.ToString())
                {
                    MessageBox.Show("Dieser Eintrag ist bereits vorhanden!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gv_Klassenstufe.Rows.RemoveAt(e.RowIndex);
                    return;
                }
            }
        }

        private void bt_Uebernehmen_Click_1(object sender, EventArgs e)
        {
            try
            {
                klassenstufe.SaveGrid(ref gv_Klassenstufe);
                aenderungungen = false;
            }
            catch
            {
                MessageBox.Show("Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Suchen_Click(object sender, MouseEventArgs e)
        {

        }
    }
}
