﻿using MetroFramework;
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
    public partial class w_s_zustand : MetroFramework.Forms.MetroForm
    {
        
        public w_s_zustand()
        {
            InitializeComponent();
            zustand.FillGrid(ref gv_Zustand);
            originalHeightLabel = tLP_Sprachen.RowStyles[0].Height;
            originalHeightText = tLP_Sprachen.RowStyles[1].Height;
            tLP_Sprachen.RowStyles[0].Height = 0;
            tLP_Sprachen.RowStyles[1].Height = 0;
        }

        #region globale Variablen
        float originalHeightLabel = 0;
        float originalHeightText = 0;
        Zustand zustand = new Zustand();
        bool suchmodus = false;
        bool aenderungungen = false;
        #endregion

        #region Schliessen-Aktion
        private void w_s_zustand_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (aenderungungen == true)
            {
                gv_Zustand.EndEdit();
                DialogResult dr = MetroMessageBox.Show(this,"Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        bt_Uebernehmen.Focus();
                        zustand.SaveGrid(ref gv_Zustand);
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
                zustand.SaveGrid(ref gv_Zustand);
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
            (gv_Zustand.DataSource as DataTable).DefaultView.RowFilter = string.Format("zu_zustand LIKE '{0}%'", tb_Suchen.Text);
        }
        #endregion

        #region Aenderungen an GridView erkennen
        private void gv_zustand_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            aenderungungen = true;
        }

        private void gv_zustand_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            aenderungungen = true;
        }
        #endregion

        private void gv_Zustand_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string s = gv_Zustand.Rows[e.RowIndex].Cells[1].Value.ToString();
            for (int i = 0; i < gv_Zustand.Rows.Count - 2; i++)
            {
                if (s.Equals(gv_Zustand.Rows[i].Cells[1].Value.ToString(), StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this,"Dieser Eintrag ist bereits vorhanden!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gv_Zustand.Rows.RemoveAt(e.RowIndex);
                    return;
                }
            }
        }
    }
}
