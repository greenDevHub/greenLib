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
    public partial class w_s_verlage : Form
    {
        public w_s_verlage()
        {
            InitializeComponent();
        }

        Verlag verlag = new Verlag();

        private void Fill_All(object sender, EventArgs e)
        {
            verlag.FillCombobox(ref cb_Verlage, -1);
        }

        #region New/Update/Drop Verlag
        private void bt_Neu_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Möchten Sie den Verlag wirklich speichern?", "Achtung",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    verlag.NewVerlag();
                    MessageBox.Show("Der Verlag wurde gespeichert!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Verlagsname.Text = "";
                }
                catch (SqlException)
                {
                    tb_Verlagsname.Text = "";
                    MessageBox.Show("Der Verlag konnte nicht gespeichert werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bt_Bearbeiten_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie den Verlag wirklich umbenennen?", "Achtung",
                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    verlag.VerlagID = cb_Verlage.SelectedValue.ToString();
                    verlag.Verlagname = cb_Verlage.Text;
                    verlag.UpdateVerlag();
                    MessageBox.Show("Der Verlag wurde umbenannt!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Verlag konnte nicht umbenannt werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie den Verlag wirklich löschen?", "Achtung",
                                     MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    verlag.VerlagID = cb_Verlage.SelectedValue.ToString();
                    verlag.DropVerlag();
                    MessageBox.Show("Der Verlag wurde geöscht!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Verlag konnte nicht gelöscht werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
