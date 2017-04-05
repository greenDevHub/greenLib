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
        Buch b;
        #region Zeichenabfrage
        public bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public bool IsIsbn(string s)
        {
            if (Regex.IsMatch(s, "^[-0-9]*$"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        public w_s_buecher()
        {
            InitializeComponent();
        }

        private void tb_Neupreis_Validated(object sender, EventArgs e)
        {

           // if (IsNumeric(tb_Neupreis.Text) == false)
           // {
           //     MessageBox.Show("Bitte nur Zahlen eingeben!");
           //     tb_Neupreis.Text = "";
          //  }

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
                Regex pattern = new Regex("[µ€@´`<>´+*~#'_.:°^!§$%&/\"()=?;,a-zA-ZäÄüÜöÖß ]");
                tb_ISBN.Text = pattern.Replace(tb_ISBN.Text, "");
            }
        }

        #region Load_Buecher
        private void load_buecher(object sender, EventArgs e)
        {
            b = new Buch(tb_ISBN.Text);

            Buch b1 = new Buch("978-3608938289");
            Buch b2 = new Buch("978-3423715669");

            tb_ISBN.Text = b.ISBN;
            tb_Titel.Text = b.Titel;
            cb_Autor.Text = b.Autor.Autorname;
            cb_Verlag.Text = b.Verlag.Verlagname;
            cb_Sprache.Text = b.Sprache.Sprachename;
            tb_Auflage.Text = b.Auflage;
            tb_Neupreis.Text = b.Neupreis.ToString();
            dTP_Erscheinungsdatum.Value = b.Er_datum;
            cb_Genre.Text = b.Genre.Genrename;
            
            // Füllen Autor
            tb_AutorID.Text = b.Autor.AutorID;
            tb_Autorname.Text = b.Autor.Autorname;

            // Füllen Verlag
            tb_VerlagID.Text = b.Verlag.VerlagID;
            tb_Verlagname.Text = b.Verlag.Verlagname;

            // Füllen Genre
            tb_GenreID.Text = b.Genre.GenreID;
            tb_Genrename.Text = b.Genre.Genrename;

            // Füllen Sprache
            tb_SpracheID.Text = b.Sprache.SpracheID;
            tb_Sprachename.Text = b.Sprache.Sprachename;
        }
        #endregion
        #region Load_Kunde
        private void load_kunde(object sender, EventArgs e)
        {
            Kunde k = new Kunde(tb_KundenID.Text);

            Kunde k1 = new Kunde("1");

            tb_KundenID.Text = k.KundenID;
            tb_Vorname.Text = k.Vorname;
            tb_Nachname.Text = k.Nachname;
            tb_Ort.Text = k.Ort;
            tb_Klasse.Text = k.Klasse;
            tb_Mail.Text = k.Mail;
            tb_Hausnummer.Text = k.Hausnummer;
            tb_Postleitzahl.Text = k.Postleitzahl;
            tb_Strasse.Text = k.Strasse;
            tb_Telefonnummer.Text = k.Telefonnummer;
            cb_Vertrauenswuerdigkeit.Text = k.Vertrauenswuerdigkeit;
        }
        #endregion
        #region Load_Verlag
        private void load_verlag(object sender, EventArgs e)
        {
            Verlag v = new Verlag(tb_VerlagID.Text);

            Verlag v1 = new Verlag("1");
            Verlag v2 = new Verlag("2");

            tb_VerlagID.Text = v.VerlagID;
            tb_Verlagname.Text = v.Verlagname;
        }
        #endregion
        #region Load_Autor
        private void load_autor(object sender, EventArgs e)
        {
            Autor a = new Autor(tb_AutorID.Text);

            Autor a1 = new Autor("1");

            tb_AutorID.Text = a.AutorID;
            tb_Autorname.Text = a.Autorname;
        }
        #endregion
        #region Load_Genre
        private void load_genre(object sender, EventArgs e)
        {
            Genre g = new Genre(tb_GenreID.Text);

            Genre g1 = new Genre("1");

            tb_GenreID.Text = g.GenreID;
            tb_Genrename.Text = g.Genrename;
        }
        #endregion
        #region Load_Sprache
        private void load_sprache(object sender, EventArgs e)
        {
            Sprache s = new Sprache(tb_SpracheID.Text);

            Sprache s1 = new Sprache("1");

            tb_SpracheID.Text = s.SpracheID;
            tb_Sprachename.Text = s.Sprachename;
        }
        #endregion
        #region Search
        private void search(object sender, EventArgs e)
        {
            //ComboBox-Items in Array speichern
            string[] strAutor = new string[cb_Autor.Items.Count];
            for (int i = 0; i < cb_Autor.Items.Count; i++)
            {
                strAutor[i] = cb_Autor.Items[i].ToString();
            }

            //Suche öffnen
            Combo_Search autor_dialog = new Combo_Search(strAutor);
            if (autor_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                cb_Autor.SelectedItem = autor_dialog.such_auswahl;
            }
        }
        #endregion
        #region Save
        private void Save(object sender, EventArgs e)
        {
            b.Titel = tb_Titel.Text;
            b.Autor.AutorID = tb_AutorID.Text;
            b.Verlag.VerlagID = tb_VerlagID.Text;
            b.Auflage = tb_Auflage.Text;
            b.Genre.GenreID = tb_GenreID.Text;
            b.Sprache.SpracheID = tb_SpracheID.Text;
            b.Neupreis = Convert.ToDecimal(tb_Neupreis.Text);
            b.Er_datum = dTP_Erscheinungsdatum.Value;
            b.Save();
        }
        #endregion
    }
}
