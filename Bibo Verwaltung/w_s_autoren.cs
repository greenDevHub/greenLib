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
    public partial class w_s_autoren : Form
    {
        public w_s_autoren()
        {
            InitializeComponent();
        }

        Autor autor = new Autor();

        private void Fill_All(object sender, EventArgs e)
        {
            autor.FillCombobox(ref cb_Autoren, -1);
        }

        #region New/Update/Drop Autor
        private void bt_Neu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie den Autor wirklich speichern?", "Achtung",
                  MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    autor.Autorname = tb_Autorname.Text;
                    autor.NewAutor();
                    MessageBox.Show("Der Autor wurde gespeichert!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Autorname.Text = "";
                }
                catch (SqlException)
                {
                    tb_Autorname.Text = "";
                    MessageBox.Show("Der Autor konnte nicht gespeichert werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_Bearbeiten_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie den Autor wirklich umbennenen?", "Achtung",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    autor.AutorID = cb_Autoren.SelectedValue.ToString();
                    autor.Autorname = tb_Autorname.Text;
                    autor.UpdateAutor();
                    MessageBox.Show("Der Autor wurde umbenannt!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Autor konnte nicht umbenannt werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie den Autor wirklich löschen?", "Achtung",
                           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    autor.AutorID = cb_Autoren.SelectedValue.ToString();
                    autor.DropAutor();
                    MessageBox.Show("Der Autor wurde gelöscht!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Der Autor konnte nicht gelöscht werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
