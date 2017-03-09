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




namespace Bibo_Verwaltung
{
    public partial class w_s_buecher : Form
    {
        public bool IsNumeric(string s)
        {
            float output;
            return float.TryParse(s, out output);
        }

        public w_s_buecher()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Neupreis_Validated(object sender, EventArgs e)
        {
            if (IsNumeric(tb_Neupreis.Text) == false)
            {
                MessageBox.Show("Bitte nur Zahlen eingeben!");
                tb_Neupreis.Text = "";
            }
        }

        private void load_buecher(object sender, EventArgs e)
        {
            Buch b = new Buch(tb_ISBN.Text);

            Buch b1 = new Buch("978-3608938289");
            Buch b2 = new Buch("978-3423715669");

            tb_ISBN.Text = b.ISBN;
            tb_Titel.Text = b.Titel;
            cb_Autor.Text = b.Autor;
            cb_Verlag.Text = b.Verlag;
            cb_Sprache.Text = b.Sprache;
            tb_Auflage.Text = b.Auflage;
            tb_Neupreis.Text = b.Neupreis.ToString();
            dTP_Erscheinungsdatum.Value = b.Er_datum;
            cb_Genre.Text = b.Genre;
        }

        private void load_kunden(object sender, EventArgs e)
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

        private void load_verlag(object sender, EventArgs e)
        {
            Verlag v = new Verlag(tb_VerlagID.Text);

            Verlag v1 = new Verlag("1");
            Verlag v2 = new Verlag("2");

            tb_VerlagID.Text = v.VerlagID;
            tb_Verlagname.Text = v.Verlagname;
        }

        private void load_autor(object sender, EventArgs e)
        {
            Autor a = new Autor(tb_AutorID.Text);

            Autor a1 = new Autor("1");

            tb_AutorID.Text = a.AutorID;
            tb_Autorname.Text = a.Autorname;
        }



        //-----------------------------------------
        

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //-----------------------------------------


    }

}
