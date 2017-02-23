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

        private void load(object sender, EventArgs e)
        {
            Buch b = new Buch(tb_ISBN.Text);

            Buch b1 = new Buch("978-3608938289");
            Buch b2 = new Buch("978-3423715669");

            tb_ISBN.Text = b.Isbn;
            tb_Titel.Text = b.Titel;
            //cb_Autor.Text = autor;
            //cb_Verlag.Text = verlag;
            //cb_Sprache.Text = sprache;
            //tb_Auflage.Text = auflage;
            //tb_Neupreis.Text = neupreis;
            cb_Genre.Text = b.Genre;
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
        //-----------------------------------------


    }

}
