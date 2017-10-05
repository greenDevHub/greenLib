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
using System.Net;
using System.IO;

namespace Bibo_Verwaltung
{
    public partial class w_s_buecher : Form
    {
        public w_s_buecher()
        {
            InitializeComponent();
            b.FillGrid_Buch(ref Grid_Buch);
            Comboboxen();
        }

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
        //TODO

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
        //TODO

        #region Prüfung Numeric und Isbn
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

        #region ComboBox Button
        private void bt_Verlag_s_Click(object sender, EventArgs e)
        {
            Form Verlag = new w_s_verlage();
            Verlag.ShowDialog(this);
            b.Verlag.FillCombobox(ref cb_Verlag, 0);
        }

        private void bt_Autor_s_Click(object sender, EventArgs e)
        {
            Form Autor = new w_s_autoren();
            Autor.ShowDialog(this);
            b.Autor.FillCombobox(ref cb_Autor, 0);
        }

        private void bt_Genre_s_Click(object sender, EventArgs e)
        {
            Form Genres = new w_s_genres();
            Genres.ShowDialog(this);
            b.Genre.FillCombobox(ref cb_Genre, 0);
        }

        private void bt_Sprache_s_Click_1(object sender, EventArgs e)
        {
            Form Sprache = new w_s_sprachen();
            Sprache.ShowDialog(this);
            b.Sprache.FillCombobox(ref cb_Sprache, 0);
        }
        #endregion

        #region Save Buch
        private void Save_Buecher(object sender, EventArgs e)
        {
            if (rb_Update_Buch.Checked && !tb_ISBN.Text.Equals("") && !tb_Titel.Text.Equals("") && !cb_Autor.Text.Equals("") && !cb_Verlag.Text.Equals("")
                && !cb_Genre.Text.Equals("") && !cb_Sprache.Text.Equals("") && !tb_Auflage.Text.Equals("") && !tb_Neupreis.Text.Equals(""))
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
                    if(pictureBox1.ImageLocation == null)
                    {
                        b.BildPfad = "";
                    }
                    else
                    {
                        b.BildPfad = pictureBox1.ImageLocation;
                    }
                    b.Update_Buch();
                    b.ClearDSBuch();
                    b.FillObjectBuch();
                    b.FillGrid_Buch(ref Grid_Buch);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht gespeichert werden!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Delete_Buch.Checked && !tb_ISBN.Text.Equals(""))
            {
                try
                {
                    DialogResult dialogResult = MessageBox.Show("Sämtliche zu diesem Buch gehörende Exemplare werden auch aus der Datenbank gelöscht. Fortfahren?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        BuchID buchid = new BuchID();
                        buchid.DeleteWhereISBN(tb_ISBN.Text);
                        b.ISBN = tb_ISBN.Text;
                        b.Delete_Buch();
                        Clear_All();
                        b.ClearDSBuch();
                        b.FillObjectBuch();
                        b.FillGrid_Buch(ref Grid_Buch);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Der Löschvorgang wurde abgebrochen!","Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht gelöscht werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Add_Buch.Checked && !tb_ISBN.Text.Equals("") && !tb_Titel.Text.Equals("") && !cb_Autor.Text.Equals("") && !cb_Verlag.Text.Equals("")
                     && !cb_Genre.Text.Equals("") && !cb_Sprache.Text.Equals("") && !tb_Auflage.Text.Equals("") && !tb_Neupreis.Text.Equals(""))
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
                    if(pictureBox1.ImageLocation == null)
                    {
                        b.BildPfad = "";
                    }
                    else
                    {
                        b.BildPfad = pictureBox1.ImageLocation;
                    }
                    if (ValidateISBN())
                    {
                        b.Add_Buch();
                        b.ClearDSBuch();
                        b.FillObjectBuch();
                        b.FillGrid_Buch(ref Grid_Buch);
                        Form Buchid = new w_s_buchid();
                        Buchid.ShowDialog(this);
                        Clear_All();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Die ISBN konnte nicht Verifiziert werden. Trotzdem speichern?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if(dialogResult == DialogResult.Yes)
                        {
                            b.Add_Buch();
                            b.ClearDSBuch();
                            b.FillObjectBuch();
                            b.FillGrid_Buch(ref Grid_Buch);
                            Form Buchid = new w_s_buchid();
                            Buchid.ShowDialog(this);
                            Clear_All();
                        }
                        else if(dialogResult == DialogResult.No)
                        {
                            tb_ISBN.Focus();
                        }
                    }
                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht hinzugefügt werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Update_Buch.Checked)
            {
                MessageBox.Show("Füllen Sie die markierten Felder aus, um ein Buch zu speichern!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_Delete_Buch.Checked)
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
            else if (rb_Add_Buch.Checked)
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
        //TODO

        #region Alle Objekte leeren
        private void bt_clear_buecher_Click(object sender, EventArgs e)
        {
            Clear_All();
        }

        private void Clear_All()
        {
            tb_ISBN.Text = "";
            tb_Titel.Text = "";
            cb_Autor.Text = "";
            cb_Verlag.Text = "";
            cb_Genre.Text = "";
            cb_Sprache.Text = "";
            tb_Auflage.Text = "";
            tb_Neupreis.Text = "";
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = null;
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
        private void tb_Neupreis_TextChanged(object sender, EventArgs e)
        {
            tb_Neupreis.BackColor = Color.White;
        }

        private void tb_Auflage_TextChanged(object sender, EventArgs e)
        {
            tb_Auflage.BackColor = Color.White;
        }

        private void cb_Sprache_TextChanged(object sender, EventArgs e)
        {
            cb_Sprache.BackColor = Color.White;
        }

        private void cb_Genre_TextChanged(object sender, EventArgs e)
        {
            cb_Genre.BackColor = Color.White;
        }

        private void cb_Verlag_TextChanged(object sender, EventArgs e)
        {
            cb_Verlag.BackColor = Color.White;
        }

        private void cb_Autor_TextChanged(object sender, EventArgs e)
        {
            cb_Autor.BackColor = Color.White;
        }
        #endregion

        #region Modus nach RadioButton-Auswahl 
        private void Modus()
        {
            if (rb_Add_Buch.Checked)
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
                bt_picture.Enabled = true;
                bt_pic_delete.Enabled = true;
                pictureBox1.Enabled = true;
            }
            if (rb_Update_Buch.Checked)
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
                bt_picture.Enabled = true;
                bt_pic_delete.Enabled = true;
                pictureBox1.Enabled = true;
            }
            if (rb_Delete_Buch.Checked)
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
                bt_picture.Enabled = false;
                bt_pic_delete.Enabled = false;
                pictureBox1.Enabled = false;
            }
        }
        #endregion

        #region Backgroundfarben zuruecksetzten (Weiß)
        private void Objekt_White()
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

        #region RadioButoon CheckedChanged
        private void rb_Neubuch_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            Objekt_White();
        }

        private void rb_Edit_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            Objekt_White();
        }

        private void rb_Delete_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            Objekt_White();
        }
        #endregion

        #region Form Update
        private void w_s_buecher_Activated(object sender, EventArgs e)
        {
            Modus();
        }
        #endregion

        #region Clicks in DataGridViewRow
        private void Grid_Buch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_Buch.Rows[e.RowIndex];
                tb_ISBN.Text = row.Cells[0].Value.ToString();
                Buch b = new Buch(tb_ISBN.Text);
                tb_Titel.Text = b.Titel;
                cb_Autor.Text = b.Autor.Autorname;
                cb_Verlag.Text = b.Verlag.Verlagname;
                cb_Sprache.Text = b.Sprache.Sprachename;
                tb_Auflage.Text = b.Auflage;
                tb_Neupreis.Text = b.Neupreis.ToString();
                dTP_Erscheinungsdatum.Value = b.Er_datum;
                cb_Genre.Text = b.Genre.Genrename;
                if(!b.BildPfad.Equals(""))
                {
                    pictureBox1.Image = Image.FromFile(b.BildPfad);
                }
                else
                {
                    pictureBox1.Image = null;
                    pictureBox1.ImageLocation = null;
                }
                b.Autor.FillCombobox(ref cb_Autor, b.Autor.AutorID);
                b.Verlag.FillCombobox(ref cb_Verlag, b.Verlag.VerlagID);
                b.Genre.FillCombobox(ref cb_Genre, b.Genre.GenreID);
                b.Sprache.FillCombobox(ref cb_Sprache, b.Sprache.SpracheID);
                lb_isbn_vorlage.Visible = false;
            }
        }

        private void Grid_Buch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string isbnAktuell;
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.Grid_Buch.Rows[e.RowIndex];
                    isbnAktuell = row.Cells[0].Value.ToString();
                    tb_ISBN.Text = isbnAktuell;
                    Form Buchid = new w_s_buchid();
                    Buchid.ShowDialog(this);
                    Clear_All();
                }
            }
        }
        #endregion

        #region Objekt auf Inhalt pruefen und Background setzten
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

        private void bt_Excel_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();

            export.ToExcel(Grid_Buch, "Bibo_Buecherliste", "Buecherliste");
        }

        private void tb_ISBN_Click(object sender, EventArgs e)
        {
            lb_isbn_vorlage.Visible = false;
        }

        private void lb_isbn_vorlage_Click(object sender, EventArgs e)
        {
            lb_isbn_vorlage.Visible = false;
            tb_ISBN.Focus();
        }
        private bool ValidateISBN()
        {
            WebClient client = new WebClient();
            try
            {
                string test = client.DownloadString("http://www.buecher-nach-isbn.info/" + tb_ISBN.Text);
                if (test.Contains("<h1 class=\"title\">"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
                
        }
        private void Comboboxen()
        {
            b.Autor.FillCombobox(ref cb_Autor, 0);
            b.Verlag.FillCombobox(ref cb_Verlag, 0);
            b.Genre.FillCombobox(ref cb_Genre, 0);
            b.Sprache.FillCombobox(ref cb_Sprache, 0);
        }

        private void bt_picture_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void bt_pic_add_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = null;
        }
    }
}
