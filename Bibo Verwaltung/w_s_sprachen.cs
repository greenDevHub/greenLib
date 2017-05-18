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
            sprache.FillGrid(ref grid);
        }

        Sprache sprache = new Sprache();

        private void Fill_All(object sender, EventArgs e)
        {
            //sprache.FillCombobox(ref cb_Sprachen, -1);
        }

        #region New/Update/Drop Sprache
        private void bt_Neu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie die Sprache wirklich speichern?", "Achtung",
                              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    sprache.NewSprache();
                    MessageBox.Show("Die Sprache wurde gespeichert!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Sprache.Text = "";
                }
                catch (SqlException)
                {
                    tb_Sprache.Text = "";
                    MessageBox.Show("Die Sprache konnte nicht gespeichert werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_Bearbeiten_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie die Sprache wirklich umbenennen?", "Achtung",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    sprache.SpracheID = cb_Sprachen.SelectedValue.ToString();
                    sprache.Sprachename = cb_Sprachen.Text;
                    sprache.UpdateSprache();
                    MessageBox.Show("Die Sprache wurde umbenannt!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Die Sprache konnte nicht umbenannt werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie die Sprache wirklich löschen?", "Achtung",
                          MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    sprache.SpracheID = cb_Sprachen.SelectedValue.ToString();
                    sprache.DropSprache();
                    MessageBox.Show("Die Sprache wurde geöscht!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Die Sprache konnte nicht gelöscht werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        private void w_s_sprachen_FormClosing(object sender, FormClosingEventArgs e)
        {
            sprache.SaveGrid(ref grid);
        }
    }
}
