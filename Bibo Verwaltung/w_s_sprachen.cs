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
    public partial class w_s_sprachen : Form
    {
        public w_s_sprachen()
        {
            InitializeComponent();
            sprache.FillGrid(ref gv_Sprachen);
            originalWidth = gv_Sprachen.Width;
            originalHeight = gv_Sprachen.Height;
            originalPointX = gv_Sprachen.Location.X;
            originalPointY = gv_Sprachen.Location.Y;
        }

        #region globale Variablen
        Sprache sprache = new Sprache();
        bool suchmodus = false;
        bool aenderungungen = false;
        int originalWidth = 0;
        int originalHeight = 0;
        int originalPointX = 0;
        int originalPointY = 0;
        #endregion

        #region Schliessen-Aktion
        private void w_s_sprachen_FormClosing(object sender, FormClosingEventArgs e)
        {           
            if (aenderungungen == true)
            {
                gv_Sprachen.EndEdit();
                BindingContext[gv_Sprachen.DataSource].EndCurrentEdit();
                DialogResult dr = MessageBox.Show("Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {    
                        sprache.SaveGrid(ref gv_Sprachen);
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

        private void bt_Uebernehmen_Click(object sender, EventArgs e)
        {
            try
            {
                sprache.SaveGrid(ref gv_Sprachen);
                aenderungungen = false;
            }
            catch
            {
                MessageBox.Show("Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                bt_Suchen.Text = "Suche AUS";
                gv_Sprachen.Size = new Size(originalWidth, originalHeight - 26); //192,370
                gv_Sprachen.Location = new Point(originalPointX, originalPointY + 26);
                lb_Sprache.Visible = true;
                tb_Suchen.Visible = true;
                tb_Suchen.Enabled = true;
                tb_Suchen.Focus();
            }
            else
            {
                suchmodus = false;
                bt_Suchen.Text = "Suche AN";
                lb_Sprache.Visible = false;
                tb_Suchen.Visible = false;
                tb_Suchen.Enabled = false;
                tb_Suchen.Text = "";
                gv_Sprachen.Size = new Size(originalWidth, originalHeight); //192,396
                gv_Sprachen.Location = new Point(originalPointX, originalPointY);
            }
        }

        private void tb_Suchen_TextChanged(object sender, EventArgs e)
        {
            (gv_Sprachen.DataSource as DataTable).DefaultView.RowFilter = string.Format("sprach_name LIKE '{0}%'", tb_Suchen.Text);
        }
        #endregion

        #region Aenderungen an GridView erkennen
        private void gv_Sprachen_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            aenderungungen = true;
        }

        private void gv_Sprachen_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            aenderungungen = true;
        }
        #endregion       
    }
}
