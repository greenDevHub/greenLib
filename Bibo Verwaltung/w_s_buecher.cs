﻿using System;
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

        #region Load Buch
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
            
            //// Füllen Autor
            //tb_AutorID.Text = b.Autor.AutorID;
            //tb_Autorname.Text = b.Autor.Autorname;

            b.Autor.FillCombobox(ref cb_Autor, b.Autor.AutorID);

            //// Füllen Verlag
            //tb_VerlagID.Text = b.Verlag.VerlagID;
            //tb_Verlagname.Text = b.Verlag.Verlagname;

            b.Verlag.FillCombobox(ref cb_Verlag, b.Verlag.VerlagID);

            //// Füllen Genre
            //tb_GenreID.Text = b.Genre.GenreID;
            //tb_Genrename.Text = b.Genre.Genrename;

            b.Genre.FillCombobox(ref cb_Genre, b.Genre.GenreID);

            //// Füllen Sprache
            //cb_SpracheID.Text = b.Sprache.SpracheID;
            //tb_Sprachename.Text = b.Sprache.Sprachename;

            b.Sprache.FillCombobox(ref cb_Sprache, b.Sprache.SpracheID);
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

        #region Save Buch
        private void Save(object sender, EventArgs e)
        {
            b.Titel = tb_Titel.Text;
            b.Autor.AutorID = cb_Autor.SelectedValue.ToString();
            b.Verlag.VerlagID = cb_Verlag.SelectedValue.ToString();
            b.Auflage = tb_Auflage.Text;
            b.Genre.GenreID = cb_Genre.SelectedValue.ToString();
            b.Sprache.SpracheID = cb_Sprache.SelectedValue.ToString();
            b.Neupreis = Convert.ToDecimal(tb_Neupreis.Text);
            b.Er_datum = dTP_Erscheinungsdatum.Value;
            b.Save();
        }
        #endregion

    }
}
