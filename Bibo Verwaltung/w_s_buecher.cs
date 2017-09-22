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
using System.Windows;
using Microsoft.Win32;
using System.Text.RegularExpressions;


namespace Bibo_Verwaltung
{
    public partial class w_s_buecher : Form
    {
        Buch b = new Buch();
        Sprache s = new Sprache();

        #region Zeichenabfrage (IsNumeric)
        public bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }
        #endregion

        #region Isbn Prüfung (IsIsbn)
        public bool IsIsbn(string s)
        {
            if (Regex.IsMatch(s, "^[-0-9]*$"))
            {
                if (s.Contains("--"))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ToIsbn
        public string ToIsbn(string s)
        {
            string output = "";
            Regex pattern = new Regex("[^-0-9]");
            output = pattern.Replace(s, "");

            for (int i = 1; i <= s.Length; i++)
            {
                if (s.Contains("--"))
                {
                    output = output.Replace("--", "-");
                }
            }
            return output;
        }
        #endregion

        public w_s_buecher()
        {
            InitializeComponent();
            b.FillGridBuch(ref Grid_Buch);
        }

        #region Prüfung Numeric & ISBN
        private void tb_Neupreis_Validated(object sender, EventArgs e)
        {
            if (IsNumeric(tb_Neupreis.Text) == false)
            {
                MessageBox.Show("Bitte nur Zahlen eingeben!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Neupreis.Text = "";
            }

        }

        private void tb_ISBN_inputOk(object sender, EventArgs e)
        {
            if (IsIsbn(tb_ISBN.Text) == false)
            {
                MessageBox.Show("Bitte keine Buchstaben eingeben!", "Achtung",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //nicht erlaubte Zeichen entfernen
                tb_ISBN.Text = ToIsbn(tb_ISBN.Text);
            }
        }
        #endregion

        #region Search
        private void bt_Verlag_s_Click(object sender, EventArgs e)
        {
            Form Verlag = new w_s_verlage();
            Verlag.ShowDialog(this);
        }

        private void bt_Autor_s_Click(object sender, EventArgs e)
        {
            Form Autor = new w_s_autoren();
            Autor.ShowDialog(this);
        }
        private void bt_Genre_s_Click(object sender, EventArgs e)
        {
            Form Genres = new w_s_genres();
            Genres.ShowDialog(this);
        }
        private void bt_Sprache_s_Click_1(object sender, EventArgs e)
        {
            Form Sprache = new w_s_sprachen();
            Sprache.ShowDialog(this);
        }
        #endregion

        #region Save Buch
        private void Save_Buecher(object sender, EventArgs e)
        {
            if (rb_Edit.Checked
                && !tb_ISBN.Text.Equals("")
                && !tb_Titel.Text.Equals("")
                && !cb_Autor.Text.Equals("")
                && !cb_Verlag.Text.Equals("")
                && !cb_Genre.Text.Equals("")
                && !cb_Sprache.Text.Equals("")
                && !tb_Auflage.Text.Equals("")
                && !tb_Neupreis.Text.Equals(""))
            {
                try
                {
                    b.ISBN = tb_ISBN.Text;
                    b.Titel = tb_Titel.Text;
                    b.Autor.AutorID = cb_Autor.SelectedValue.ToString();
                    b.Verlag.VerlagID = cb_Verlag.SelectedValue.ToString();
                    b.Auflage = tb_Auflage.Text;
                    b.Genre.GenreID = cb_Genre.SelectedValue.ToString();
                    b.Sprache.SpracheID = cb_Sprache.SelectedValue.ToString();
                    b.Neupreis = Convert.ToDecimal(tb_Neupreis.Text);
                    b.Er_datum = dTP_Erscheinungsdatum.Value;
                    b.Save();
                    b.ClearDSBuch();
                    b.FillObjectBuch();
                    b.FillGridBuch(ref Grid_Buch);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht gespeichert werden!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rb_Delete.Checked
                && !tb_ISBN.Text.Equals(""))
            {
                try
                {
                    b.ISBN = tb_ISBN.Text;
                    b.Delete();
                    b.ClearDSBuch();
                    b.FillObjectBuch();
                    b.FillGridBuch(ref Grid_Buch);
                }
                catch(SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht gelöscht werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rb_Neubuch.Checked
                && !tb_ISBN.Text.Equals("")
                && !tb_Titel.Text.Equals("")
                && !cb_Autor.Text.Equals("")
                && !cb_Verlag.Text.Equals("")
                && !cb_Genre.Text.Equals("")
                && !cb_Sprache.Text.Equals("")
                && !tb_Auflage.Text.Equals("")
                && !tb_Neupreis.Text.Equals(""))
            {
                try
                {
                    b.ISBN = tb_ISBN.Text;
                    b.Titel = tb_Titel.Text;
                    b.Autor.AutorID = cb_Autor.SelectedValue.ToString();
                    b.Verlag.VerlagID = cb_Verlag.SelectedValue.ToString();
                    b.Auflage = tb_Auflage.Text;
                    b.Genre.GenreID = cb_Genre.SelectedValue.ToString();
                    b.Sprache.SpracheID = cb_Sprache.SelectedValue.ToString();
                    b.Neupreis = Convert.ToDecimal(tb_Neupreis.Text);
                    b.Er_datum = dTP_Erscheinungsdatum.Value;
                    b.Add();
                    b.ClearDSBuch();
                    b.FillObjectBuch();
                    b.FillGridBuch(ref Grid_Buch);
                    Form Buchid = new w_s_buchid();
                    Buchid.ShowDialog(this);
                    Clear();
                }
                catch(SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht hinzugefügt werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rb_Edit.Checked)
            {
                MessageBox.Show("Füllen Sie die markierten Felder aus, um ein Buch zu speichern!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if(rb_Delete.Checked)
            {
                MessageBox.Show("Füllen Sie die markierten Felder aus, um ein Buch zu löschen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_ISBN.Text.Equals(""))
                {
                    tb_ISBN.BackColor = Color.Red;
                }
                else
                {
                    tb_ISBN.BackColor = Color.White;
                }
            }
            else if (rb_Neubuch.Checked)
            {
                MessageBox.Show("Füllen Sie die markierten Felder aus, um ein Buch hinzuzufügen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_ISBN.Text.Equals(""))
                {
                    tb_ISBN.BackColor = Color.Red;
                }
                else
                {
                    tb_ISBN.BackColor = Color.White;
                }
                IsOK();
            }
        }
        #endregion

        #region Clear Buch
        private void bt_clear_buecher_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            tb_ISBN.Text = "";
            tb_Titel.Text = "";
            cb_Autor.Text = "";
            cb_Verlag.Text = "";
            cb_Genre.Text = "";
            cb_Sprache.Text = "";
            tb_Auflage.Text = "";
            tb_Neupreis.Text = "";
            tb_ISBN.BackColor = Color.White;
            tb_Titel.BackColor = Color.White;
            cb_Autor.BackColor = Color.White;
            cb_Verlag.BackColor = Color.White;
            cb_Genre.BackColor = Color.White;
            cb_Sprache.BackColor = Color.White;
            tb_Auflage.BackColor = Color.White;
            tb_Neupreis.BackColor = Color.White;
        }
        #endregion

        #region Textboxfarbe
        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {
            (Grid_Buch.DataSource as DataTable).DefaultView.RowFilter = string.Format("ISBN LIKE '{0}%'", tb_ISBN.Text);
            tb_ISBN.BackColor = Color.White;
        }

        private void tb_Titel_TextChanged(object sender, EventArgs e)
        {
            tb_Titel.BackColor = Color.White;
        }
        #endregion

        #region Modus
        private void Modus()
        {
            if(rb_Neubuch.Checked)
            {
                tb_ISBN.Enabled = true;
                tb_Titel.Enabled = true;
                cb_Autor.Enabled = true;
                cb_Verlag.Enabled = true;
                cb_Sprache.Enabled = true;
                cb_Genre.Enabled = true;
                tb_Auflage.Enabled = true;
                tb_Neupreis.Enabled = true;
                dTP_Erscheinungsdatum.Enabled = true;
                bt_speichern_buecher.Enabled = true;
                bt_speichern_buecher.Text = "Hinzufügen";
            }
            if(rb_Edit.Checked)
            {
                tb_ISBN.Enabled = false;
                tb_Titel.Enabled = true;
                cb_Autor.Enabled = true;
                cb_Verlag.Enabled = true;
                cb_Sprache.Enabled = true;
                cb_Genre.Enabled = true;
                tb_Auflage.Enabled = true;
                tb_Neupreis.Enabled = true;
                dTP_Erscheinungsdatum.Enabled = true;
                bt_speichern_buecher.Enabled = true;
                bt_speichern_buecher.Text = "Speichern";
            }
            if(rb_Delete.Checked)
            {
                tb_ISBN.Enabled = true;
                tb_Titel.Enabled = false;
                cb_Autor.Enabled = false;
                cb_Verlag.Enabled = false;
                cb_Sprache.Enabled = false;
                cb_Genre.Enabled = false;
                tb_Auflage.Enabled = false;
                tb_Neupreis.Enabled = false;
                dTP_Erscheinungsdatum.Enabled = false;
                bt_speichern_buecher.Enabled = true;
                bt_speichern_buecher.Text = "Löschen";
            }
        }
        #endregion

        #region White
        private void White()
        {
            tb_ISBN.BackColor = Color.White;
            tb_Titel.BackColor = Color.White;
            cb_Autor.BackColor = Color.White;
            cb_Verlag.BackColor = Color.White;
            cb_Genre.BackColor = Color.White;
            cb_Sprache.BackColor = Color.White;
            tb_Auflage.BackColor = Color.White;
            tb_Neupreis.BackColor = Color.White;
            dTP_Erscheinungsdatum.BackColor = Color.White;
        }
        #endregion

        #region CheckedChanged
        private void rb_Neubuch_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }

        private void rb_Edit_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }

        private void rb_Delete_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }

        private void w_s_buecher_Activated(object sender, EventArgs e)
        {
            Modus();
            b.Autor.FillCombobox(ref cb_Autor,1);
            b.Verlag.FillCombobox(ref cb_Verlag, 1);
            b.Genre.FillCombobox(ref cb_Genre, 1);
            b.Sprache.FillCombobox(ref cb_Sprache, 1);
            cb_Autor.Text = "";
            cb_Verlag.Text = "";
            cb_Genre.Text = "";
            cb_Sprache.Text = "";
        }
        #endregion

        #region Grid_Laden
        private void Grid_Buch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_Buch.Rows[e.RowIndex];
                tb_ISBN.Text = row.Cells["ISBN"].Value.ToString();
                Buch b = new Buch(tb_ISBN.Text);
                tb_Titel.Text = b.Titel;
                cb_Autor.Text = b.Autor.Autorname;
                cb_Verlag.Text = b.Verlag.Verlagname;
                cb_Sprache.Text = b.Sprache.Sprachename;
                tb_Auflage.Text = b.Auflage;
                tb_Neupreis.Text = b.Neupreis.ToString();
                dTP_Erscheinungsdatum.Value = b.Er_datum;
                cb_Genre.Text = b.Genre.Genrename;
                b.Autor.FillCombobox(ref cb_Autor, b.Autor.AutorID);
                b.Verlag.FillCombobox(ref cb_Verlag, b.Verlag.VerlagID);
                b.Genre.FillCombobox(ref cb_Genre, b.Genre.GenreID);
                b.Sprache.FillCombobox(ref cb_Sprache, b.Sprache.SpracheID);
            }
        }
        #endregion

        #region IsOK
        private void IsOK()
        {
            if (tb_Titel.Text.Equals(""))
            {
                tb_Titel.BackColor = Color.Red;
            }
            else
            {
                tb_Titel.BackColor = Color.White;
            }

            if (cb_Autor.Text.Equals(""))
            {
                cb_Autor.BackColor = Color.Red;
            }
            else
            {
                cb_Autor.BackColor = Color.White;
            }

            if (cb_Verlag.Text.Equals(""))
            {
                cb_Verlag.BackColor = Color.Red;
            }
            else
            {
                cb_Verlag.BackColor = Color.White;
            }

            if (cb_Genre.Text.Equals(""))
            {
                cb_Genre.BackColor = Color.Red;
            }
            else
            {
                cb_Genre.BackColor = Color.White;
            }

            if (cb_Sprache.Text.Equals(""))
            {
                cb_Sprache.BackColor = Color.Red;
            }
            else
            {
                cb_Sprache.BackColor = Color.White;
            }

            if (tb_Auflage.Text.Equals(""))
            {
                tb_Auflage.BackColor = Color.Red;
            }
            else
            {
                tb_Auflage.BackColor = Color.White;
            }

            if (tb_Neupreis.Text.Equals(""))
            {
                tb_Neupreis.BackColor = Color.Red;
            }
            else
            {
                tb_Neupreis.BackColor = Color.White;
            }

            if (dTP_Erscheinungsdatum.Text.Equals(""))
            {
                dTP_Erscheinungsdatum.BackColor = Color.Red;
            }
            else
            {
                dTP_Erscheinungsdatum.BackColor = Color.White;
            }
        }
        #endregion

        private void Grid_Buch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string isbnAktuell;
            if(e.Button == MouseButtons.Right)
            {
                if(e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.Grid_Buch.Rows[e.RowIndex];
                    isbnAktuell = row.Cells["ISBN"].Value.ToString();
                    tb_ISBN.Text = isbnAktuell;
                    Form Buchid = new w_s_buchid();
                    Buchid.ShowDialog(this);
                    tb_ISBN.Text = "";
                }
            }
        }

        private void bt_Excel_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();

            export.ToExcel(Grid_Buch, "Bibo_Buecherliste", "Buecherliste");

        }
    }
}
