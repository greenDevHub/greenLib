﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Drawing.Imaging;
using System.Text;
using System.Media;
using MetroFramework;
using bpac;
using MetroFramework.Controls;
using System.Threading;

namespace Bibo_Verwaltung
{
    public partial class w_s_buecher : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        string currentUser;
        bool guest = false;
        string buchIsbn = "";
        public w_s_buecher(string userName, string isbn)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            buchIsbn = isbn;

            if (user.Rechteid.Equals("0"))
            {
                guest = true;
                guestMode(guest);
            }
            else if (user.Rechteid.Equals("1"))
            {
                guest = false;
                guestMode(guest);
            }
            else if (user.Rechteid == "2")
            {
                guest = false;
                guestMode(guest);
            }
            Comboboxen();
            picBox_Gross.Visible = false;
            gb_zoom.Visible = false;
            comboBox1.Visible = false;
            comboBox1.DropDownHeight = 1;
        }
        public w_s_buecher(string userName, bool bool1)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;

            if (user.Rechteid.Equals("0"))
            {
                guest = true;
                guestMode(guest);
            }
            else if (user.Rechteid.Equals("1"))
            {
                guest = false;
                guestMode(guest);
            }
            else if (user.Rechteid == "2")
            {
                guest = false;
                guestMode(guest);
            }

            //b.FillGrid_Buch(ref Grid_Buch);
            Comboboxen();
            picBox_Gross.Visible = false;
            gb_zoom.Visible = false;
            comboBox1.Visible = false;
            comboBox1.DropDownHeight = 1;
            this.bool1 = bool1;
        }
        #endregion
        private void guestMode(bool activate)
        {
            bt_speichern_buecher.Enabled = !activate;
            bt_print.Enabled = !activate;
            bt_pic_delete.Enabled = !activate;
            bt_picture.Enabled = !activate;
            bt_Excel.Enabled = !activate;
            entfernenToolStripMenuItem.Enabled = !activate;
            if (rb_search.Checked)
            {
                bt_speichern_buecher.Enabled = false;
                bt_pic_delete.Enabled = false;
                bt_picture.Enabled = false;
            }
        }
        bool loaded = false;
        private string location = "";
        Buch b = new Buch();
        bool bool1;

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

        #region Prüfung Numeric und Isbn
        private void tb_ISBN_inputOk(object sender, EventArgs e)
        {
            if (IsIsbn(tb_ISBN.Text) == false)
            {
                MetroMessageBox.Show(this,"Bitte keine Buchstaben eingeben!", "Achtung",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //nicht erlaubte Zeichen entfernen
                tb_ISBN.Text = ToIsbn(tb_ISBN.Text);
            }
        }
        #endregion

        private void bt_Verlag_s_Click(object sender, EventArgs e)
        {
            Form Verlag = new w_s_manage(currentUser, "Verlag");
            Verlag.ShowDialog(this);
            b.Verlag.FillCombobox(ref cb_Verlag, 0);
        }

        private void bt_Autor_s_Click(object sender, EventArgs e)
        {
            Form Autor = new w_s_manage(currentUser, "Autor");
            Autor.ShowDialog(this);
            b.Autor.FillCombobox(ref cb_Autor, 0);
        }

        private void bt_Genre_s_Click(object sender, EventArgs e)
        {
            Form Genres = new w_s_manage(currentUser, "Genre");
            Genres.ShowDialog(this);
            b.Genre.FillCombobox(ref cb_Genre, 0);
        }

        private void bt_Sprache_s_Click_1(object sender, EventArgs e)
        {
            Form Sprache = new w_s_manage(currentUser, "Sprache");
            Sprache.ShowDialog(this);
            b.Sprache.FillCombobox(ref cb_Sprache, 0);
        }

        private void UpdateBuch()
        {
            b.ISBN = tb_ISBN.Text;
            b.Titel = tb_Titel.Text;
            b.Verlag.VerlagID = cb_Verlag.SelectedValue.ToString();
            b.Genre.GenreID = cb_Genre.SelectedValue.ToString();
            b.Sprache.SpracheID = cb_Sprache.SelectedValue.ToString();
            if (tb_Auflage.Text.Equals(""))
            {
                b.Auflage = null;
            }
            else
            {
                b.Auflage = tb_Auflage.Text;

            }
            if (tb_Neupreis.Text.Equals(""))
            {
                b.Neupreis = 0;
            }
            else
            {
                b.Neupreis = Convert.ToDecimal(tb_Neupreis.Text);
            }
            b.Er_datum = dTP_Erscheinungsdatum.Value;

            if (picBox_Klein.ImageLocation == null || picBox_Klein.ImageLocation.Equals(""))
            {
                b.BildPfad = "";
                Delete_picture(location);
                b.ImageDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
                b.Image = null;
            }
            else
            {
                Copy_picture();
                b.BildPfad = picBox_Klein.ImageLocation;
                b.Image = System.IO.File.ReadAllBytes(b.BildPfad);
                b.ImageDate = DateTime.Parse(DateTime.UtcNow.ToShortTimeString());
            }
            b.UpdateBuch();
            b.FillGrid_Buch(ref Grid_Buch);
        }

        private void AddBuch()
        {
            b.ISBN = tb_ISBN.Text;
            b.Titel = tb_Titel.Text;
            b.Verlag.VerlagID = b.Verlag.GetVerlagsID(cb_Verlag.Text);
            if (tb_Auflage.Text.Equals(""))
            {
                b.Auflage = null;
            }
            else
            {
                b.Auflage = tb_Auflage.Text;

            }
            b.Genre.GenreID = cb_Genre.SelectedValue.ToString();
            b.Sprache.SpracheID = cb_Sprache.SelectedValue.ToString();
            if (tb_Neupreis.Text.Equals(""))
            {
                b.Neupreis = 0;
            }
            else
            {
                b.Neupreis = Convert.ToDecimal(tb_Neupreis.Text);
            }
            b.Er_datum = dTP_Erscheinungsdatum.Value;
            b.Anzahl = 0;
            if (picBox_Klein.ImageLocation == null || picBox_Klein.ImageLocation.Equals(""))
            {
                b.BildPfad = "";
                Delete_picture(location);
                b.ImageDate = (DateTime)System.Data.SqlTypes.SqlDateTime.MinValue;
                b.Image = null;
            }
            else
            {
                Copy_picture();
                b.BildPfad = picBox_Klein.ImageLocation;
                b.Image = System.IO.File.ReadAllBytes(b.BildPfad);
                b.ImageDate = DateTime.Parse(DateTime.UtcNow.ToShortTimeString());
            }
            if (!tb_neu.Text.Equals(""))
            {
                int neuExemplar = 0;
                try
                {
                    neuExemplar = int.Parse(tb_neu.Text);
                    b.SaveBuch();
                    Exemplar exemplar = new Exemplar();
                    if (!exemplar.Zustand.IfContains("neu"))
                    {
                        exemplar.Zustand.AddZustand("neu");
                    }
                    exemplar.ISBN = b.ISBN;
                    exemplar.Aufnahmedatum = DateTime.UtcNow.Date;
                    exemplar.Zustand.ZustandID = exemplar.Zustand.GetZustandsID("neu");
                    for (int i = 0; i < neuExemplar; i++)
                    {
                        exemplar.Add_Exemplar();
                    }
                    b.FillGrid_Buch(ref Grid_Buch);
                    Clear_All();
                }
                catch
                {
                    MetroMessageBox.Show(this, "Es gab einen Fehler bei dem Hinzufügen der neuen Exemplare!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (ifDownloaded)
                {
                    b.SaveBuch();
                    Form Buchid = new w_s_exemplare(currentUser, tb_ISBN.Text);
                    Buchid.ShowDialog(this);
                    b.FillGrid_Buch(ref Grid_Buch);
                    Clear_All();
                }
                else if (!ifDownloaded && ValidateISBN())
                {
                    b.SaveBuch();
                    Form Buchid = new w_s_exemplare(currentUser, tb_ISBN.Text);
                    Buchid.ShowDialog(this);
                    b.FillGrid_Buch(ref Grid_Buch);
                    Clear_All();
                }
                else
                {
                    DialogResult dialogResult = MetroMessageBox.Show(this, "Die ISBN konnte nicht Verifiziert werden. Trotzdem speichern?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        b.SaveBuch();
                        Form Buchid = new w_s_exemplare(currentUser, tb_ISBN.Text);
                        Buchid.ShowDialog(this);
                        b.FillGrid_Buch(ref Grid_Buch);
                        Clear_All();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        tb_ISBN.Focus();
                    }
                }
            }

        }
        
        private void Save_Buecher(object sender, EventArgs e)
        {
            var t = new System.Windows.Forms.Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                mtb_Nachricht.Hide();
                t.Stop();
            };
                if (rb_Update_Buch.Checked && !checkbox_autor.Checked && !tb_ISBN.Text.Equals("") && !tb_Titel.Text.Equals("") && !cb_Autor.Text.Equals("") && !cb_Verlag.Text.Equals("")
                && !cb_Genre.Text.Equals("") && !cb_Sprache.Text.Equals(""))
            {
                try
                {
                    if (!b.Verlag.IfContains(cb_Verlag.Text))
                    {
                        b.Verlag.AddVerlag(cb_Verlag.Text);
                        b.Verlag.FillCombobox(ref cb_Verlag, int.Parse(b.Verlag.GetVerlagsID(cb_Verlag.Text)));
                    }
                    if (!b.Autor.IfContains(cb_Autor.Text))
                    {
                        List<string> autors = new List<string>();
                        autors.Add(cb_Autor.Text);
                        b.Autor.AddAutor(autors);
                        b.Autor.FillCombobox(ref cb_Autor, int.Parse(b.Autor.GetAutorID(cb_Autor.Text)));
                    }
                    if (!b.Genre.IfContains(cb_Genre.Text))
                    {
                        b.Genre.AddGenre(cb_Genre.Text);
                        b.Genre.FillCombobox(ref cb_Genre, int.Parse(b.Genre.GetGenreID(cb_Genre.Text)));
                    }
                    if (!b.Sprache.IfContains(cb_Sprache.Text))
                    {
                        b.Sprache.AddSprache(cb_Sprache.Text);
                        b.Sprache.FillCombobox(ref cb_Sprache, int.Parse(b.Sprache.GetSprachID(cb_Sprache.Text)));
                    }
                    b.Autoren.Clear();
                    b.Autoren.Add(cb_Autor.Text);
                    UpdateBuch();
                    mtb_Nachricht.Visible = true;
                    t.Start();
                }
                catch
                {
                    MetroMessageBox.Show(this,"Das Buch konnte nicht gespeichert werden!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rb_Update_Buch.Checked && checkbox_autor.Checked && !tb_ISBN.Text.Equals("") && !tb_Titel.Text.Equals("") && !cb_Autor.Text.Equals("") && !cb_Verlag.Text.Equals("")
                && !cb_Genre.Text.Equals("") && !cb_Sprache.Text.Equals(""))
            {
                try
                {
                    //for(int i = 0; i < 10;)
                    //{
                    //    try
                    //    {
                    //        if (b.AutorListe.AutorIDs[i] == null)
                    //        {
                    //        }
                    //        i++;
                    //    }
                    //    catch
                    //    {
                    //        b.AutorListe.AutorIDs.Add(null);
                    //        i++;
                    //    }
                        

                    //}
                    if (!b.Verlag.IfContains(cb_Verlag.Text))
                    {
                        b.Verlag.AddVerlag(cb_Verlag.Text);
                        b.Verlag.FillCombobox(ref cb_Verlag, int.Parse(b.Verlag.GetVerlagsID(cb_Verlag.Text)));
                    }
                    if (!b.Genre.IfContains(cb_Genre.Text))
                    {
                        b.Genre.AddGenre(cb_Genre.Text);
                        b.Genre.FillCombobox(ref cb_Genre, int.Parse(b.Genre.GetGenreID(cb_Genre.Text)));
                    }
                    if (!b.Sprache.IfContains(cb_Sprache.Text))
                    {
                        b.Sprache.AddSprache(cb_Sprache.Text);
                        b.Sprache.FillCombobox(ref cb_Sprache, int.Parse(b.Sprache.GetSprachID(cb_Sprache.Text)));
                    }
                    UpdateBuch();
                    mtb_Nachricht.Visible = true;
                    t.Start();
                }
                catch
                {
                    MetroMessageBox.Show(this,"Das Buch konnte nicht gespeichert werden!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Delete_Buch.Checked && !tb_ISBN.Text.Equals(""))
            {
                try
                {
                    DialogResult dialogResult = MetroMessageBox.Show(this,"Sämtliche zu diesem Buch gehörende Exemplare werden auch aus der Datenbank gelöscht. Fortfahren?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {

                        Exemplar buchid = new Exemplar();
                        //buchid.DeleteWhereISBN(tb_ISBN.Text);
                        if (buchid.IsAvailable(tb_ISBN.Text))
                        {
                            buchid.DeactivateWhereISBN(tb_ISBN.Text);
                            b.ISBN = tb_ISBN.Text;
                            b.DeactivateBuch();
                            Delete_picture(location);
                            Clear_All();
                            b.FillGrid_Buch(ref Grid_Buch);
                            mtb_Nachricht.Visible = true;
                            t.Start();
                        }
                        else
                        {
                            MetroMessageBox.Show(this,"Das Buch konnte nicht gelöscht werden, da eines der dazugehörigen Exemplare zur Zeit verliehen ist. Bitte melden Sie dieses zuerst als 'zurückgegeben', bevor Sie das Buch löschen!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MetroMessageBox.Show(this,"Der Löschvorgang wurde abgebrochen!","Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                catch (SqlException)
                {
                    MetroMessageBox.Show(this,"Das Buch konnte nicht gelöscht werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Add_Buch.Checked && !checkbox_autor.Checked && !tb_ISBN.Text.Equals("") && !tb_Titel.Text.Equals("") && !cb_Autor.Text.Equals("") && !cb_Verlag.Text.Equals("")
                     && !cb_Genre.Text.Equals("") && !cb_Sprache.Text.Equals(""))
            {
                try
                {
                    if (ifDownloaded)
                    {
                        if (!ifVerlagExists)
                        {
                            b.Verlag.AddVerlag(cb_Verlag.Text);
                            int test = int.Parse(b.Verlag.GetVerlagsID(cb_Verlag.Text));
                            b.Verlag.FillCombobox(ref cb_Verlag, test);
                        }
                        if (!b.Genre.IfContains(cb_Genre.Text))
                        {
                            b.Genre.AddGenre(cb_Genre.Text);
                            b.Genre.FillCombobox(ref cb_Genre, int.Parse(b.Genre.GetGenreID(cb_Genre.Text)));
                        }
                        if (!b.Sprache.IfContains(cb_Sprache.Text))
                        {
                            b.Sprache.AddSprache(cb_Sprache.Text);
                            b.Sprache.FillCombobox(ref cb_Sprache, int.Parse(b.Sprache.GetSprachID(cb_Sprache.Text)));
                        }
                        if (needAutor.Count > 0)
                        {
                            b.Autor.AddAutor(needAutor);
                        }
                        else
                        {
                            if(b.Autor.GetAutorID(cb_Autor.Text) == "" || b.Autor.GetAutorID(cb_Autor.Text) == null)
                            {
                                needAutor.Add(cb_Autor.Text);
                                b.Autor.AddAutor(needAutor);
                            }
                        }
                        b.Autoren.Clear();
                        b.Autoren.Add(cb_Autor.Text);
                        b.Autor.FillCombobox(ref cb_Autor, b.Autor.GetAutorID(b.Autoren[0]));
                        //for (int i = 1; i < 10;)
                        //{
                        //    b.AutorListe.AutorIDs.Add(null);
                        //    i++;
                        //}
                        AddBuch();
                        mtb_Nachricht.Visible = true;
                        t.Start();
                    }
                    else
                    {
                        if (!b.Verlag.IfContains(cb_Verlag.Text))
                        {
                            b.Verlag.AddVerlag(cb_Verlag.Text);
                            b.Verlag.FillCombobox(ref cb_Verlag, int.Parse(b.Verlag.GetVerlagsID(cb_Verlag.Text)));
                        }
                        if (!b.Autor.IfContains(cb_Autor.Text))
                        {
                            List <string> autors = new List<string>();
                            autors.Add(cb_Autor.Text);
                            b.Autor.AddAutor(autors);
                            b.Autor.FillCombobox(ref cb_Autor, int.Parse(b.Autor.GetAutorID(cb_Autor.Text)));
                        }
                        if (!b.Genre.IfContains(cb_Genre.Text))
                        {
                            b.Genre.AddGenre(cb_Genre.Text);
                            b.Genre.FillCombobox(ref cb_Genre, int.Parse(b.Genre.GetGenreID(cb_Genre.Text)));
                        }
                        if (!b.Sprache.IfContains(cb_Sprache.Text))
                        {
                            b.Sprache.AddSprache(cb_Sprache.Text);
                            b.Sprache.FillCombobox(ref cb_Sprache, int.Parse(b.Sprache.GetSprachID(cb_Sprache.Text)));
                        }
                        b.Autoren.Clear();
                        //b.Autoren.Add(cb_Autor.SelectedText.ToString());
                        b.Autoren.Add(cb_Autor.Text);
                        //for (int i = 1; i < 10;)
                        //{
                        //    b.AutorListe.AutorIDs.Add(null);
                        //    i++;
                        //}
                        AddBuch();
                        mtb_Nachricht.Visible = true;
                        t.Start();
                    }

                }
                catch
                {
                    MetroMessageBox.Show(this,"Das Buch konnte nicht hinzugefügt werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rb_Add_Buch.Checked && checkbox_autor.Checked && !tb_ISBN.Text.Equals("") && !tb_Titel.Text.Equals("") && !cb_Autor.Text.Equals("") && !cb_Verlag.Text.Equals("")
                     && !cb_Genre.Text.Equals("") && !cb_Sprache.Text.Equals(""))
            {
                try
                {
                    if (ifDownloaded)
                    {
                        if (!ifVerlagExists)
                        {
                            b.Verlag.AddVerlag(cb_Verlag.Text);
                            int test = int.Parse(b.Verlag.GetVerlagsID(cb_Verlag.Text));
                            b.Verlag.FillCombobox(ref cb_Verlag, test);
                        }
                        if(needAutor.Count > 0)
                        {
                            b.Autor.AddAutor(needAutor);
                        }
                        if (!b.Genre.IfContains(cb_Genre.Text))
                        {
                            b.Genre.AddGenre(cb_Genre.Text);
                            b.Genre.FillCombobox(ref cb_Genre, int.Parse(b.Genre.GetGenreID(cb_Genre.Text)));
                        }
                        if (!b.Sprache.IfContains(cb_Sprache.Text))
                        {
                            b.Sprache.AddSprache(cb_Sprache.Text);
                            b.Sprache.FillCombobox(ref cb_Sprache, int.Parse(b.Sprache.GetSprachID(cb_Sprache.Text)));
                        }
                        AddBuch();
                        mtb_Nachricht.Visible = true;
                        t.Start();
                    }
                    else
                    {
                        if (!b.Verlag.IfContains(cb_Verlag.Text))
                        {
                            b.Verlag.AddVerlag(cb_Verlag.Text);
                            b.Verlag.FillCombobox(ref cb_Verlag, int.Parse(b.Verlag.GetVerlagsID(cb_Verlag.Text)));
                        }
                        if (!b.Genre.IfContains(cb_Genre.Text))
                        {
                            b.Genre.AddGenre(cb_Genre.Text);
                            b.Genre.FillCombobox(ref cb_Genre, int.Parse(b.Genre.GetGenreID(cb_Genre.Text)));
                        }
                        if (!b.Sprache.IfContains(cb_Sprache.Text))
                        {
                            b.Sprache.AddSprache(cb_Sprache.Text);
                            b.Sprache.FillCombobox(ref cb_Sprache, int.Parse(b.Sprache.GetSprachID(cb_Sprache.Text)));
                        }
                        AddBuch();
                        mtb_Nachricht.Visible = true;
                        t.Start();
                    }
                }
                catch
                {
                    MetroMessageBox.Show(this,"Das Buch konnte nicht hinzugefügt werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_Update_Buch.Checked)
            {
                MetroMessageBox.Show(this,"Füllen Sie die markierten Felder aus, um ein Buch zu speichern!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_Delete_Buch.Checked)
            {
                MetroMessageBox.Show(this,"Füllen Sie die markierten Felder aus, um ein Buch zu löschen!", "Achtung",
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
                MetroMessageBox.Show(this,"Füllen Sie die markierten Felder aus, um ein Buch hinzuzufügen!", "Achtung",
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
            tb_ISBN.Focus();
        }

        private void bt_clear_buecher_Click(object sender, EventArgs e)
        {
            Clear_All();
            //rb_Add_Buch.Checked = true;
        }

        private void Clear_All()
        {
            dTP_Erscheinungsdatum.ResetText();
            tb_barcodePrinted.Text = "";
            tb_barcodeAdd.Text = "";
            tb_neu.Text = "";
            checkbox_autor.Checked = false;
            tb_ISBN.Text = "";
            tb_Titel.Text = "";
            cb_Autor.Text = "";
            cb_Verlag.Text = "";
            cb_Genre.Text = "";
            cb_Sprache.Text = "";
            tb_Auflage.Text = "";
            tb_Neupreis.Text = "";
            tb_anzahl.Text = "";
            picBox_Gross.Image = null;
            picBox_Gross.ImageLocation = null;
            picBox_Klein.Image = null;
            picBox_Klein.ImageLocation = null;
            tb_ISBN.BackColor = Color.White;
            tb_Titel.BackColor = Color.White;
            cb_Autor.BackColor = Color.White;
            cb_Verlag.BackColor = Color.White;
            cb_Genre.BackColor = Color.White;
            cb_Sprache.BackColor = Color.White;
            tb_Auflage.BackColor = Color.White;
            tb_Neupreis.BackColor = Color.White;
            tb_anzahl.BackColor = Color.White;
        }
        /// <summary>
        /// Sucht nach Büchern in einer GridView
        /// </summary>
        private void BuchFilter()
        {
            try
            {
                if (dTP_Erscheinungsdatum.Value.Date != DateTime.Now.Date)
                {
                    (Grid_Buch.DataSource as DataTable).DefaultView.RowFilter = string.Format("Titel LIKE '%{0}%' and ISBN LIKE '%{1}%' AND Autor LIKE '%{2}%' AND Verlag LIKE '%{3}%' AND Genre LIKE '%{4}%' AND Sprache LIKE '%{5}%' AND Erscheinungsdatum LIKE '%{6}%'", tb_Titel.Text, tb_ISBN.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text, cb_Sprache.Text, dTP_Erscheinungsdatum.Value.Date.ToShortDateString());

                }
                else
                {
                    (Grid_Buch.DataSource as DataTable).DefaultView.RowFilter = string.Format("Titel LIKE '%{0}%' and ISBN LIKE '%{1}%' AND Autor LIKE '%{2}%' AND Verlag LIKE '%{3}%' AND Genre LIKE '%{4}%' AND Sprache LIKE '%{5}%'", tb_Titel.Text, tb_ISBN.Text, cb_Autor.Text, cb_Verlag.Text, cb_Genre.Text, cb_Sprache.Text);
                }
            }
            catch
            {

            }

        }

        #region Textboxfarbe
        private void tb_ISBN_TextChanged(object sender, EventArgs e)
        {
            tb_ISBN.Text = tb_ISBN.Text.Replace(" ", "");
            BuchFilter();
            tb_ISBN.BackColor = Color.White;
        }

        private void tb_Titel_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            tb_Titel.BackColor = Color.White;
            tb_Titel.UseCustomBackColor = false;
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
            BuchFilter();
            cb_Sprache.BackColor = Color.White;
        }

        private void cb_Genre_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            cb_Genre.BackColor = Color.White;
        }

        private void cb_Verlag_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            cb_Verlag.BackColor = Color.White;
        }

        private void cb_Autor_TextChanged(object sender, EventArgs e)
        {
            BuchFilter();
            cb_Autor.BackColor = Color.White;
            if (checkbox_autor.Checked && checkedListBox1.Visible)
            {
                int index = checkedListBox1.FindString(cb_Autor.Text);
                if(index >= 0)
                {
                    checkedListBox1.SelectedIndex = index;
                }
            }
        }
        #endregion

        #region Modus nach RadioButton-Auswahl 
        private void Modus()
        {
            if (rb_Add_Buch.Checked)
            {
                bt_print.Enabled = false;
                tb_barcodeAdd.Enabled = false;
                tb_neu.Enabled = true;
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
                picBox_Klein.Enabled = true;
                mtb_Nachricht.Text = "Das Buch wurde erfolgreich hinzugefügt!";
                lb_ISBN.Text = "ISBN:*";
                lb_Titel.Text = "Titel:*";
                lb_Autor.Text = "Autor:*";
                lb_Verlag.Text = "Verlag:*";
                lb_Genre.Text = "Genre:*";
                lb_Sprache.Text = "Sprache:*";
                lb_Erscheinungsdatum.Text = "Erscheinungsdatum:*";
                checkbox_autor.Enabled = true;
                button1.Enabled = true;

            }
            if (rb_Update_Buch.Checked)
            {
                bt_print.Enabled = true;
                tb_barcodeAdd.Enabled = true;
                tb_neu.Enabled = false;
                tb_ISBN.Enabled = false;
                tb_Titel.Enabled = true;
                cb_Autor.Enabled = !checkbox_autor.Checked;
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
                picBox_Klein.Enabled = true;
                mtb_Nachricht.Text = "Das Buch wurde erfolgreich bearbeitet!";
                lb_ISBN.Text = "ISBN:";
                lb_Titel.Text = "Titel:*";
                lb_Autor.Text = "Autor:*";
                lb_Verlag.Text = "Verlag:*";
                lb_Genre.Text = "Genre:*";
                lb_Sprache.Text = "Sprache:*";
                lb_Erscheinungsdatum.Text = "Erscheinungsdatum:*";
                checkbox_autor.Enabled = true;
                button1.Enabled = true;

            }
            if (rb_Delete_Buch.Checked)
            {
                bt_print.Enabled = false;
                tb_barcodeAdd.Enabled = false;
                tb_neu.Enabled = false;
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
                picBox_Klein.Enabled = false;
                mtb_Nachricht.Text = "Das Buch wurde erfolgreich gelöscht!";
                lb_ISBN.Text = "ISBN:*";
                lb_Titel.Text = "Titel:";
                lb_Autor.Text = "Autor:";
                lb_Verlag.Text = "Verlag:";
                lb_Genre.Text = "Genre:";
                lb_Sprache.Text = "Sprache:";
                lb_Erscheinungsdatum.Text = "Erscheinungsdatum:";
                checkbox_autor.Enabled = false;
                button1.Enabled = false;
            }
            guestMode(guest);
            if (rb_search.Checked)
            {
                bt_speichern_buecher.Enabled = false;
                bt_pic_delete.Enabled = false;
                bt_picture.Enabled = false;

                bt_print.Enabled = true;
                tb_barcodeAdd.Enabled = true;
                tb_neu.Enabled = false;
                tb_ISBN.Enabled = true;
                tb_Titel.Enabled = true;
                cb_Autor.Enabled = true;
                cb_Verlag.Enabled = true;
                cb_Sprache.Enabled = true;
                cb_Genre.Enabled = true;
                tb_Auflage.Enabled = true;
                tb_Neupreis.Enabled = true;
                dTP_Erscheinungsdatum.Enabled = true;
                bt_speichern_buecher.Text = "---";
                picBox_Klein.Enabled = true;
                mtb_Nachricht.Text = "Das Buch wurde erfolgreich hinzugefügt!";
                lb_ISBN.Text = "ISBN:";
                lb_Titel.Text = "Titel:";
                lb_Autor.Text = "Autor:";
                lb_Verlag.Text = "Verlag:";
                lb_Genre.Text = "Genre:";
                lb_Sprache.Text = "Sprache:";
                lb_Erscheinungsdatum.Text = "Erscheinungsdatum:";
                checkbox_autor.Enabled = false;
                button1.Enabled = true;

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
        private void Rb_search_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            Objekt_White();
        }
        #endregion

        private void w_s_buecher_Activated(object sender, EventArgs e)
        {
            Modus();
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void LoadBuch()
        {          
            Buch b = new Buch(tb_ISBN.Text);
            tb_Titel.Text = b.Titel;
            string autortext = "";
            if (b.Autoren.Count > 1)
            {
                checkbox_autor.Checked = true;
                List<int> index = new List<int>();
                foreach (object value in checkedListBox1.Items)
                {
                    DataRowView castedItem = value as DataRowView;
                    string newString = castedItem["au_autor"].ToString();
                    if (b.Autoren.Contains(newString))
                    {
                        int test = checkedListBox1.Items.IndexOf(value);
                        index.Add(test);
                    }
                }
                foreach (int i1 in index)
                {
                    checkedListBox1.SetItemChecked(i1, true);
                }
            }
            else
            {
                checkbox_autor.Checked = false;
            }
            foreach (string s in b.Autoren)
            {
                autortext = autortext + s + ", ";
            }
            autortext = autortext.Substring(0, autortext.Length - 2);
            cb_Autor.Text = autortext;
            cb_Verlag.Text = b.Verlag.Verlagname;
            cb_Sprache.Text = b.Sprache.Sprachename;
            tb_Auflage.Text = b.Auflage;
            tb_Neupreis.Text = b.Neupreis.ToString();
            dTP_Erscheinungsdatum.Value = b.Er_datum;
            cb_Genre.Text = b.Genre.Genrename;
            tb_anzahl.Text = b.Anzahl.ToString();
            if (b.Image != null)
            {
                try
                {
                    MemoryStream mem = new MemoryStream(b.Image);
                    picBox_Klein.Image = Image.FromStream(mem);
                    string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bibliothek\\Bilder\\" + tb_ISBN.Text + ".png";
                    if (!File.Exists(filePath))
                    {
                        picBox_Klein.Image.Save(filePath, ImageFormat.Png);
                        picBox_Klein.ImageLocation = filePath;
                    }
                    else
                    {
                        Delete_picture(filePath);
                        picBox_Klein.Image.Save(filePath, ImageFormat.Png);
                        picBox_Klein.ImageLocation = filePath;
                    }
                }
                catch { }
            }
            else
            {
                if (!b.BildPfad.Equals(""))
                {
                    try
                    {
                        picBox_Klein.ImageLocation = b.BildPfad;
                    }
                    catch
                    {
                        MetroMessageBox.Show(this,"Das Bild wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    picBox_Klein.Image = null;
                    picBox_Klein.ImageLocation = null;
                }
            }
            b.Verlag.FillCombobox(ref cb_Verlag, b.Verlag.VerlagID);
            b.Genre.FillCombobox(ref cb_Genre, b.Genre.GenreID);
            b.Sprache.FillCombobox(ref cb_Sprache, b.Sprache.SpracheID);
            Exemplar ex = new Exemplar();
            tb_barcodePrinted.Text = ex.PrintedCount(tb_ISBN.Text).ToString();
            rb_Update_Buch.Focus();
        }

        private void Grid_Buch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Grid_Buch.Rows[e.RowIndex];
                tb_ISBN.Text = row.Cells[0].Value.ToString();
                if (bool1)
                {
                    LoadBuch();
                }
                else
                {
                    LoadBuch();
                    this.Hide();
                }
            }
        }

        private void IsOK()
        {
            if (tb_ISBN.Text.Equals(""))
            {
                tb_ISBN.UseCustomBackColor = true;
                tb_ISBN.BackColor = Color.Red;
            }
            else
            {
                tb_ISBN.UseCustomBackColor = false;
                tb_ISBN.BackColor = Color.White;
            }
            if (tb_Titel.Text.Equals(""))
            {
                tb_Titel.UseCustomBackColor = true;
                tb_Titel.BackColor = Color.Red;
            }
            else
            {
                tb_Titel.UseCustomBackColor = false;
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
            if (dTP_Erscheinungsdatum.Text.Equals(""))
            {
                dTP_Erscheinungsdatum.UseCustomBackColor = true;
                dTP_Erscheinungsdatum.BackColor = Color.Red;
            }
            else
            {
                dTP_Erscheinungsdatum.UseCustomBackColor = false;
                dTP_Erscheinungsdatum.BackColor = Color.White;
            }
        }

        string htmlData;
        private string GetPicture()
        {
                try
                {
                    string location = "";
                    string s1 = "<img";
                    string s2 = "src=";
                    string s3 = "width";
                    int i1 = htmlData.IndexOf(s1) + 4;
                    location = htmlData.Substring(i1);
                    int i2 = location.IndexOf(s2) + 5;
                    int i3 = location.IndexOf(s3) - 2;
                    location = location.Substring(i2, i3 - i2);
                    string bildURL = "http://www.buecher-nach-isbn.info/" + location;
                    string fileURL = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bibliothek\\Downloads\\" + tb_ISBN.Text + "_DOWNLOAD.jpg";
                    WebClient client = new WebClient();
                    client.DownloadFile(bildURL, fileURL);
                    return fileURL;
                }
                catch
                {
                    MetroMessageBox.Show(this,"Es konnte kein Bild geladen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "";
                }
            
        }

        private string GetTitle()
        {
            string title;
            try
            {
                string s1 = "\"title\">";
                string s2 = "</h1>";
                int i1 = htmlData.IndexOf(s1) + 8;
                int i2 = htmlData.IndexOf(s2);
                title = htmlData.Substring(i1, i2 - i1);
                byte[] bytes = Encoding.Default.GetBytes(title);
                title = Encoding.UTF8.GetString(bytes);
                title = System.Net.WebUtility.HtmlDecode(title);
                return title;
            }
            catch
            {
                title = "";
                return title;
            }             
        }

        private string GetVerlag()
        {
            string verlag;
            try
            {
                string s1 = "\"pubinf\">";
                string s2 = "\">";
                string s3 = "<";
                int i1 = htmlData.IndexOf(s1) + 9;
                verlag = htmlData.Substring(i1);
                int i2 = verlag.IndexOf(s2) + 2;
                verlag = verlag.Substring(i2);
                int i3 = verlag.IndexOf(s3);
                verlag = verlag.Substring(0, i3);
                byte[] bytes = Encoding.Default.GetBytes(verlag);
                verlag = Encoding.UTF8.GetString(bytes);
                verlag = System.Net.WebUtility.HtmlDecode(verlag);
                return verlag;
            }
            catch
            {
                verlag = "";
                return verlag;
            }
        }

        private List<string> GetAutor()
        {
            List<string> autoren = new List<string>();
            string autor;
            try
            {
                autor = htmlData;
                string s1 = "<h2 class";
                string s1end = "</h2>";
                string s2 = "href=";
                string s3 = ">";
                string s4 = "<";
                int i1 = htmlData.IndexOf(s1);
                autor = htmlData.Substring(i1);
                int i2 = autor.IndexOf(s1end);
                autor = autor.Substring(0,i2);
                autor = autor.Substring(autor.IndexOf(s3) + 1);
                for (int i = 0; i == 0;)
                {
                    try
                    {
                        string newautor;
                        newautor = autor.Substring(autor.IndexOf(s3) + 1);
                        newautor = newautor.Substring(newautor.IndexOf(s3) + 1);
                        int i3 = newautor.IndexOf(s4);
                        newautor = newautor.Substring(0, i3);
                        int i6 = autor.IndexOf(newautor);
                        autor = autor.Substring(i6);
                        byte[] bytes = Encoding.Default.GetBytes(newautor);
                        newautor = Encoding.UTF8.GetString(bytes);
                        newautor = System.Net.WebUtility.HtmlDecode(newautor);
                        autoren.Add(newautor);
                    }
                    catch
                    {
                        i++;
                    }
                }        
                return autoren;
            }
            catch
            {
                return autoren;
            }
        }

        private bool ValidateISBN()
        {
            WebClient client = new WebClient();
            try
            {
                htmlData = client.DownloadString("http://www.buecher-nach-isbn.info/" + tb_ISBN.Text);

                if (htmlData.Contains("<h1 class=\"title\">"))
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
                try {
                    client.UseDefaultCredentials = true;
                    client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    htmlData = client.DownloadString("http://www.buecher-nach-isbn.info/" + tb_ISBN.Text);

                    if (htmlData.Contains("<h1 class=\"title\">"))
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
        }

        private void Comboboxen()
        {
            b.Autor.FillList(ref checkedListBox1);
            b.Autor.FillCombobox(ref cb_Autor, 0);
            b.Verlag.FillCombobox(ref cb_Verlag, 0);
            b.Genre.FillCombobox(ref cb_Genre, 0);
            b.Sprache.FillCombobox(ref cb_Sprache, 0);
        }

        private void bt_picture_Click(object sender, EventArgs e)
        {
            string imgLocation = "";
            DialogResult dialogResult = MetroMessageBox.Show(this,"Soll das Bild anhand der ISBN automatisch geladen werden?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                ValidateISBN();
                imgLocation = GetPicture();
                picBox_Klein.ImageLocation = imgLocation;
            }
            if(dialogResult == DialogResult.No)
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Bilddateien(*.png, *.jpg, *.bmp, *.gif)|*.png; *.jpg; *.bmp; *.gif|Alle Dateien(*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = dialog.FileName.ToString();
                    picBox_Klein.ImageLocation = imgLocation;
                }
            }
        }

        private void bt_pic_add_Click(object sender, EventArgs e)
        {
            location = picBox_Klein.ImageLocation;
            picBox_Klein.ImageLocation = null;
            picBox_Gross.ImageLocation = null;
            b.Image = null;
        }

        private void bt_Excel_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();
            export.ExportDataGridViewAsCSV(Grid_Buch);
        }

        private void tb_ISBN_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }

        private void lb_isbn_vorlage_Click(object sender, EventArgs e)
        {
            tb_ISBN.Focus();
        }

        private void Copy_picture()
        {
            string oldLocation = picBox_Klein.ImageLocation;
            string newLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bibliothek\\Bilder\\" + tb_ISBN.Text +".png";
            if(!File.Exists(newLocation) && oldLocation != newLocation)
            {
                picBox_Klein.Image.Save(newLocation, ImageFormat.Png);
                picBox_Klein.ImageLocation = newLocation;
            }
            else if(oldLocation == newLocation) { }
            else
            {
                File.Delete(newLocation);
                Copy_picture();
            }
            if (oldLocation.Contains("_DOWNLOAD.jpg"))
            {
                File.Delete(oldLocation);
            }
        }

        private void Delete_picture(string location)
        {
            if (File.Exists(location))
            {
                File.Delete(location);
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            ZoomInOut(true);
        }

        private void ZoomInOut(bool zoom)
        {
            if(picBox_Klein.Image != null)
            {
                picBox_Gross.Image = picBox_Klein.Image;
                if (!zoom)
                {
                    picBox_Gross.Visible = false;
                    gb_zoom.Visible = false;
                }
                else
                {
                    picBox_Gross.Visible = true;
                    gb_zoom.Visible = true;
                }
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            ZoomInOut(false);
        }

        List<string> needAutor = new List<string>();
        bool ifDownloaded = false;
        bool ifVerlagExists = false;

        private void AutoLoad()
        {
            if (ValidateISBN() && !tb_ISBN.Text.Equals(""))
            {
                if (GetAutor().Count > 1)
                {
                    checkbox_autor.Checked = true;
                }
                else
                {
                    checkbox_autor.Checked = false;
                }
                string autorstring = "";
                needAutor.Clear();
                b.Autoren.Clear();
                foreach (string s in GetAutor())
                {
                    autorstring = autorstring + s + ", ";
                    
                    b.Autoren.Add(s);
                    if (!b.Autor.IfContains(s))
                    {
                        needAutor.Add(s.Replace("[", "(").Replace("]", ")"));
                    }
                }
                if (!autorstring.Equals(""))
                {
                    cb_Autor.Text = autorstring.Substring(0, autorstring.Length - 2);
                }
                if (b.Verlag.IfContains(GetVerlag()))
                {
                    cb_Verlag.Text = GetVerlag().Replace("[", "(").Replace("]", ")");
                    ifVerlagExists = true;
                }
                else
                {
                    cb_Verlag.Text = GetVerlag().Replace("[", "(").Replace("]", ")");
                    ifVerlagExists = false;
                }
                tb_Titel.Text = GetTitle().Replace("[", "(").Replace("]", ")");
                picBox_Klein.ImageLocation = GetPicture();
                ifDownloaded = true;
                MetroMessageBox.Show(this,"Das Buch \"" + tb_Titel.Text + "\" wurde erfolgreich geladen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(tb_ISBN.Text.Equals(""))
            {
                MetroMessageBox.Show(this,"Bitte geben Sie eine ISBN ein!","Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MetroMessageBox.Show(this,"Es konnten zu dieser ISBN keine Informationen gefunden werden. Bitte überprüfen Sie ihre Eingabe nach Fehlern!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutoLoad();
        }

        private void checkbox_autor_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_autor.Checked)
            {
                cb_Autor.AutoCompleteMode = AutoCompleteMode.None;
                comboBox1.Visible = true;
                cb_Autor.DataSource = null;
                cb_Autor.Enabled = false;
            }
            else
            {
                cb_Autor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                comboBox1.Visible = false;
                checkedListBox1.Visible = false;
                b.Autor.FillCombobox(ref cb_Autor, 0);
                cb_Autor.Enabled = true;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            List<string> checkedItems = new List<string>();
            b.Autoren.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                DataRowView castedItem = item as DataRowView;
                string autorstring = castedItem["au_autor"].ToString();
                string idstring = castedItem["au_id"].ToString();
                b.Autoren.Add(autorstring);
                checkedItems.Add(autorstring);
            }
            if (e.NewValue == CheckState.Checked)
            {
                DataRowView castedItem = checkedListBox1.Items[e.Index] as DataRowView;
                string autorstring = castedItem["au_autor"].ToString();
                checkedItems.Add(autorstring);
                string idstring = castedItem["au_id"].ToString();
                b.Autoren.Add(autorstring);
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                DataRowView castedItem = checkedListBox1.Items[e.Index] as DataRowView;
                string autorstring = castedItem["au_autor"].ToString();
                checkedItems.Remove(autorstring);
                string idstring = castedItem["au_id"].ToString();
                b.Autoren.Remove(autorstring);
            }
            string combobox = "";
            foreach(string s in checkedItems)
            {
                combobox = combobox + s + ", ";
            }
            if(combobox.Length > 0)
            {
                combobox = combobox.Substring(0, combobox.Length - 2);
                cb_Autor.Text = combobox;
            }
            else
            {
                cb_Autor.Text = "";
            }
        }

        private void gb_buch_Enter(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }

        private void tb_ISBN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !rb_Delete_Buch.Checked)
            {
                if (Grid_Buch.Rows.Count == 0)
                {
                    AutoLoad();
                }
                else if(Grid_Buch.Rows.Count == 1)
                {
                    LoadBuch();
                }
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            if (checkbox_autor.Checked)
            {
                cb_Autor.Enabled = false;
                comboBox1.DroppedDown = false;
                if (checkedListBox1.Visible == false)
                {
                    checkedListBox1.Visible = true;
                }
                else
                {
                    checkedListBox1.Visible = false;
                }
            }
        }

        private void tb_Titel_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }

        private void w_s_buecher_Click(object sender, EventArgs e)
        {
            checkedListBox1.Visible = false;
        }

        private void tb_Neupreis_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = Convert.ToChar(Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != a))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
            if ((e.KeyChar == a) && ((sender as MetroFramework.Controls.MetroTextBox).Text.IndexOf(a) > -1))
            {
                e.Handled = true;
            }
        }

        private void tb_Neupreis_Leave(object sender, EventArgs e)
        {
            if (tb_Neupreis.Text.Contains(","))
            {
                if (tb_Neupreis.Text.Substring(tb_Neupreis.Text.IndexOf(",") + 1).Length == 1)
                {
                    tb_Neupreis.Text = tb_Neupreis.Text + "0";
                }
                else if (tb_Neupreis.Text.Substring(tb_Neupreis.Text.IndexOf(",") + 1).Length == 0)
                {
                    tb_Neupreis.Text = tb_Neupreis.Text + "00";
                    if (tb_Neupreis.Text.Substring(0, tb_Neupreis.Text.IndexOf(",")).Length == 0)
                    {
                        tb_Neupreis.Text = 0 + tb_Neupreis.Text;
                    }
                }
                else if (tb_Neupreis.Text.Substring(tb_Neupreis.Text.IndexOf(",") + 1).Length > 2)
                {
                    tb_Neupreis.Text = tb_Neupreis.Text.Substring(0, tb_Neupreis.Text.IndexOf(",") + 3);
                }
            }
            else if (tb_Neupreis.Text.Equals(""))
            {
                tb_Neupreis.Text = "";
            }
            else
            {
                tb_Neupreis.Text = tb_Neupreis.Text + ",00";
            }
        }

        private void tb_ISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '-'))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void Grid_Buch_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!Grid_Buch.Rows[e.RowIndex].Selected)
                {
                    Grid_Buch.ClearSelection();
                    Grid_Buch.Rows[e.RowIndex].Selected = true;
                }
                if (Grid_Buch.SelectedRows.Count > 1)
                {
                    ladenToolStripMenuItem.Text = "Ausgewähltes Buch laden";
                    ladenToolStripMenuItem.Enabled = false;
                    entfernenToolStripMenuItem.Text = "Ausgewählte Bücher mit ihren Exemplaren entfernen (" + Grid_Buch.SelectedRows.Count + ")";
                    entfernenToolStripMenuItem.Enabled = true;
                    exemplareToolStripMenuItem.Text = "Alle Exemplare zu diesem Buch anzeigen";
                    exemplareToolStripMenuItem.Enabled = false;
                }
                else
                {
                    ladenToolStripMenuItem.Text = "Ausgewähltes Buch laden";
                    ladenToolStripMenuItem.Enabled = true;
                    entfernenToolStripMenuItem.Text = "Ausgewähltes Buch mit seinen Exemplaren entfernen";
                    entfernenToolStripMenuItem.Enabled = true;
                    exemplareToolStripMenuItem.Text = "Alle Exemplare zu diesem Buch anzeigen";
                    exemplareToolStripMenuItem.Enabled = true;
                }
            }
            guestMode(guest);
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_ISBN.Text = Grid_Buch.SelectedRows[0].Cells["ISBN"].Value.ToString();
            if (bool1)
            {
                LoadBuch();
            }
            else
            {
                LoadBuch();
            }
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tb_ISBN.Text = Grid_Buch.SelectedRows[0].Cells["ISBN"].Value.ToString();
            Exemplar buchid = new Exemplar();
            if (buchid.IsAvailable(tb_ISBN.Text))
            {
                buchid.DeactivateWhereISBN(tb_ISBN.Text);
                b.ISBN = tb_ISBN.Text;
                b.DeactivateBuch();
                Delete_picture(location);
                Clear_All();
                b.FillGrid_Buch(ref Grid_Buch);
            }
            else
            {
                MetroMessageBox.Show(this,"Das Buch konnte nicht gelöscht werden, da eines der dazugehörigen Exemplare zur Zeit verliehen ist. Bitte melden Sie dieses zuerst als 'zurückgegeben', bevor Sie das Buch löschen!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void exemplareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string isbnAktuell = Grid_Buch.SelectedRows[0].Cells["ISBN"].Value.ToString();
            tb_ISBN.Text = isbnAktuell;
            Form Buchid = new w_s_exemplare(currentUser, isbnAktuell);
            Buchid.ShowDialog(this);
            //b.FillGrid_Buch(ref Grid_Buch);
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            Clear_All();
        }

        private void Grid_Buch_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(Grid_Buch.HitTest(e.X, e.Y).RowIndex >=0) || !(Grid_Buch.HitTest(e.X, e.Y).ColumnIndex >= 0))
            {
                Grid_Buch.ClearSelection();
                ladenToolStripMenuItem.Visible = false;
                entfernenToolStripMenuItem.Visible = false;
                exemplareToolStripMenuItem.Visible = false;
            }
            else
            {
                ladenToolStripMenuItem.Visible = true;
                entfernenToolStripMenuItem.Visible = true;
                exemplareToolStripMenuItem.Visible = true;
            }
        }

        private void bt_Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_ISBN_Leave(object sender, EventArgs e)
        {
            tb_ISBN.Text = tb_ISBN.Text.Replace(" ", "");
        }

        private void PrintBarcodes(List<string> barcodeList)
        {
            try
            {
                IPrinter printer = new Printer();
                object[] x = printer.GetInstalledPrinters();
                string name = x[0].ToString();
                bool test = printer.IsPrinterOnline(name);
                if (test)
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string strFilePath = path + "\\Bibliothek\\Einstellungen\\BarcodePreset.lbx";
                    IDocument doc = new Document();
                    doc.Open(strFilePath);
                    int barcodeIndex = doc.GetBarcodeIndex("Barcode");
                    IObjects ob = doc.Objects;
                    int anzahlObs = ob.Count;
                    int textInd = doc.GetTextIndex("Titel");
                    int textIndex = barcodeIndex + 1;
                    doc.SetPrinter(printer.Name, true);
                    doc.StartPrint("", PrintOptionConstants.bpoDefault);
                    Exemplar ex = new Exemplar();
                    foreach (string barcodeData in barcodeList)
                    {
                        doc.SetBarcodeData(barcodeIndex, barcodeData);
                        doc.Objects[textIndex].Text = ex.GetTitel(barcodeData.TrimStart('0'));
                        doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                        ex.Print(barcodeData.TrimStart('0'));
                    }
                    doc.EndPrint();
                    doc.Close();
                    MetroMessageBox.Show(this, String.Format("Es wurden erfolgreich '{0}' Barcodes gedruckt.", barcodeList.Count), "Drucken erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_print_Click(object sender, EventArgs e)
        {
            if (!tb_barcodeAdd.Text.Equals("") && !tb_ISBN.Text.Equals(""))
            {
                List<string> notPrintedID = new List<string>();
                List<string> newPrintedID = new List<string>();
                Exemplar ex = new Exemplar();
                notPrintedID = ex.UnprintedList(tb_ISBN.Text);
                int printNumber = int.Parse(tb_barcodeAdd.Text);
                if (printNumber > notPrintedID.Count)
                {
                    printNumber = notPrintedID.Count;
                    tb_barcodeAdd.Text = printNumber.ToString();
                }
                if(notPrintedID.Count > 0)
                {
                    for(int i = 0; i < printNumber;i++)
                    {
                        string code = "";
                        code = notPrintedID[i];
                        for (int codeInt = code.Length; codeInt < 7;codeInt++)
                        {
                            code = "0" + code;
                        }
                        newPrintedID.Add(code);
                    }
                    PrintBarcodes(newPrintedID);
                    //b.FillGrid_Buch(ref Grid_Buch);
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.RunWorkerAsync();
                    }
                    Clear_All();
                }
            }
        }

        private void tb_neu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void tb_barcodeAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            try
            {
                BeginInvoke((Action)delegate ()
                {
                    metroProgressSpinner1.Visible = true;
                    Grid_Buch.Visible = false;
                    metroProgressSpinner1.BringToFront();
                });
                MetroGrid mgBuch = new MetroGrid();
                b.FillGrid_Buch(ref mgBuch);
                var dtBuch = mgBuch.DataSource;
                while(loaded == false)
                {

                }
                BeginInvoke((Action)delegate ()
                {
                    Grid_Buch.DataSource = dtBuch;
                    metroProgressSpinner1.Visible = false;
                    Grid_Buch.Visible = true;
                });
            }
            catch
            {
                //eventueller Fix vom Problem der einfrierenden Ladeanimation
                //Prüfung notwendig
                BeginInvoke((Action)delegate ()
                {
                    metroProgressSpinner1.Visible = false;
                    Grid_Buch.Visible = true;
                    MetroFramework.MetroMessageBox.Show(this, "Fehler beim Laden der Daten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                });
            }

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void Mtb_Import_Click(object sender, EventArgs e)
        {
            //Import
        }

        private void DTP_Erscheinungsdatum_ValueChanged(object sender, EventArgs e)
        {
            BuchFilter();
            dTP_Erscheinungsdatum.UseCustomBackColor = false;
            dTP_Erscheinungsdatum.BackColor = Color.White;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            BuchFilter();
            if(buchIsbn != "")
            {
                tb_ISBN.Text = buchIsbn;
                LoadBuch();
            }
        }

        private void Bt_exemplar_Click(object sender, EventArgs e)
        {
            if (Grid_Buch.SelectedRows.Count == 1)
            {
                Form Buchid = new w_s_exemplare(currentUser, Grid_Buch.SelectedRows[0].Cells[0].Value.ToString());
                Buchid.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Es wurde kein Buch ausgewählt. Bitte wählen Sie zuerst ein Buch in der Tabellenansicht aus.", "Kein Buch ausgewählt.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bt_exemplar.Enabled = false;
            }
        }

        private void Grid_Buch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Grid_Buch.SelectedRows.Count == 1)
            {
                bt_exemplar.Enabled = true;
            }
            else
            {
                bt_exemplar.Enabled = false;
            }
        }

        private void Grid_Buch_Click(object sender, EventArgs e)
        {
            if (Grid_Buch.SelectedRows.Count == 1)
            {
                bt_exemplar.Enabled = true;
            }
            else
            {
                bt_exemplar.Enabled = false;
            }
        }


    }
}
