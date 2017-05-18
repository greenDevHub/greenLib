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
    public partial class w_s_genres : Form
    {
        public w_s_genres()
        {
            InitializeComponent();
        }

        Genre genre = new Genre();

        private void Fill_All(object sender, EventArgs e)
        {
            genre.FillCombobox(ref cb_Genres, -1);
        }

        #region New/Update/Drop Genre
        private void bt_Neu_Click(object sender, EventArgs e)
        {       
            DialogResult result = MessageBox.Show("Möchten Sie das Genre wirklich speichern?", "Achtung",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                   // genre.Load();


                    genre.Genrename = tb_Genrename.Text;
                    genre.NewGenre();
                    MessageBox.Show("Das Genre wurde gespeichert!", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Genrename.Text = "";
                    }
                    catch (SqlException)
                    {
                        tb_Genrename.Text = "";
                        MessageBox.Show("Das Genre konnte nicht gespeichert werden!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void bt_Bearbeiten_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie das Genre wirklich umbenennen?", "Achtung",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    genre.GenreID = cb_Genres.SelectedValue.ToString();
                    genre.Genrename = cb_Genres.Text;
                    genre.UpdateGenre();
                    MessageBox.Show("Das Genre wurde umbenannt!", "Information",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Genre konnte nicht umbenannt werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchten Sie das Genre wirklich löschen?", "Achtung",
               MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    genre.GenreID = cb_Genres.SelectedValue.ToString();
                    genre.DropGenre();
                    MessageBox.Show("Das Genre wurde geöscht!", "Information",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Genre konnte nicht gelöscht werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
    }
}
