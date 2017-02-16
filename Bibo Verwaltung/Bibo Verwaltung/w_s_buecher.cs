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
            string isbn = "";
            string titel = "";
            string genre = "";
            string verlag = "";
            string autor = "";
            string er_datum = "";
            string sprache = "";
            string auflage = "";
            string neupreis = "";

            isbn = tb_ISBN.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_buecher "
                + "left join t_s_genre on buch_genre_id = ger_id "
                + "left join t_s_autor on buch_autor_id = au_id "
                + "left join t_s_verlag on buch_verlag_id = ver_id "
                + "left join t_s_sprache on buch_sprache_id = sprach_id "
                + "WHERE buch_isbn = '" + isbn+ "'";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
               Console.WriteLine("{0,-35}{1}",
               titel = dr["buch_titel"].ToString(),
               genre = dr["ger_name"].ToString(),
               autor = dr["au_autor"].ToString(),
               verlag = dr["ver_name"].ToString(),
               er_datum = dr["buch_erscheinungsdatum"].ToString(),
               sprache = dr["sprach_name"].ToString(),
               auflage = dr["buch_auflage"].ToString(),
               neupreis = dr["buch_neupreis"].ToString());

            tb_Titel.Text = titel;
            cb_Autor.Text = autor;
            cb_Verlag.Text = verlag;
            cb_Sprache.Text = sprache;
            tb_Auflage.Text = auflage;
            tb_Neupreis.Text = neupreis;
            cb_Genre.Text = genre;

            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
    }
    
}
