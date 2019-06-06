using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_genres : MetroFramework.Forms.MetroForm
    {
        public w_s_genres()
        {
            InitializeComponent();
            genre.FillGrid(ref gv_Genres);
            originalHeightLabel = tLP_Sprachen.RowStyles[0].Height;
            originalHeightText = tLP_Sprachen.RowStyles[1].Height;
            tLP_Sprachen.RowStyles[0].Height = 0;
            tLP_Sprachen.RowStyles[1].Height = 0;
        }

        #region globale Variablen
        float originalHeightLabel = 0;
        float originalHeightText = 0;
        Genre genre = new Genre();
        bool suchmodus = false;
        bool aenderungungen = false;
        #endregion

        #region Schliessen-Aktion
        private void w_s_genres_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aenderungungen == true)
            {
                gv_Genres.EndEdit();
                DialogResult dr = MetroMessageBox.Show(this,"Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        bt_Uebernehmen.Focus();
                        genre.SaveGrid(ref gv_Genres);
                    }
                    catch
                    {
                        MetroMessageBox.Show(this,"Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void bt_Uebernehmen_Click(object sender, EventArgs e)
        {
            try
            {
                genre.SaveGrid(ref gv_Genres);
                aenderungungen = false;
            }
            catch
            {
                MetroMessageBox.Show(this,"Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                tLP_Sprachen.RowStyles[0].Height = originalHeightLabel;
                tLP_Sprachen.RowStyles[1].Height = originalHeightText;
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
                tLP_Sprachen.RowStyles[0].Height = 0;
                tLP_Sprachen.RowStyles[1].Height = 0;
            }
        }

        private void tb_Suchen_TextChanged(object sender, EventArgs e)
        {
            (gv_Genres.DataSource as DataTable).DefaultView.RowFilter = string.Format("ger_name LIKE '{0}%'", tb_Suchen.Text);
        }
        #endregion

        #region Aenderungen an GridView erkennen
        private void gv_genres_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            aenderungungen = true;
        }

        private void gv_genres_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            aenderungungen = true;
        }
        #endregion

        private void gv_Genres_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string s = gv_Genres.Rows[e.RowIndex].Cells[1].Value.ToString();
            for(int i = 0; i < gv_Genres.Rows.Count-2; i++)
            {
                if(s == gv_Genres.Rows[i].Cells[1].Value.ToString())
                {
                    MetroMessageBox.Show(this,"Dieser Eintrag ist bereits vorhanden!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gv_Genres.Rows.RemoveAt(e.RowIndex);
                    return;
                }
            }
        }
    }
}
