﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bibo_Verwaltung
{
    class Buch
    {
        SQL_Verbindung con = new SQL_Verbindung();
        #region Buch Eigenschaften
        string isbn;
        /// <summary>
        /// Isbn Nummer eines Buches
        /// </summary>
        public string ISBN { get { return isbn; } set { isbn = value; } }

        string titel;
        /// <summary>
        /// Titel eines Buches
        /// </summary>
        public string Titel { get { return titel; } set { titel = value; } }

        Genre genre = new Genre();
        /// <summary>
        /// Genre eines Buches
        /// </summary>
        public Genre Genre { get { return genre; } set { genre = value; } }

        Verlag verlag = new Verlag();
        /// <summary>
        /// Verlag des Buches
        /// </summary>
        public Verlag Verlag { get { return verlag; } set { verlag = value; } }

        Autor autor = new Autor();
        /// <summary>
        /// Autor eines Buches
        /// </summary>
        public Autor Autor { get { return autor; } set { autor = value; } }

        Sprache sprache = new Sprache();
        /// <summary>
        /// Sprache des Buches
        /// </summary>
        public Sprache Sprache { get { return sprache; } set { sprache = value; } }

        string auflage;
        /// <summary>
        /// Auflage eines Buches
        /// </summary>
        public string Auflage { get { return auflage; } set { auflage = value; } }

        DateTime er_datum;
        /// <summary>
        /// Erscheinungsdatum eines Buches
        /// </summary>
        public DateTime Er_datum { get { return er_datum; } set { er_datum = value; } }

        decimal neupreis;
        /// <summary>
        /// Neupreis eines Buches
        /// </summary>
        public decimal Neupreis { get { return neupreis; } set { neupreis = value; } }
        #endregion

        #region Objekt Buch
        /// <summary>
        /// Erschaft das Objekt Buch
        /// </summary>
        public Buch()
        {
            FillObjectBuch();
            FillObjectLeihen();
        }
        //public Buch()
        //{
        //    //FillObject();
        //    FillObjectLeihen();
        //}
        public Buch(string isbn)
        {
            this.isbn = isbn;
            Load();
            //FillObject();
            FillObjectLeihen();
        }
        #endregion

        #region Load
        private void Load()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT *, isnull(buch_erscheinungsdatum, '01.01.1990') as 'verified_erscheinungsdatum' FROM t_s_buecher left join t_s_genre on buch_genre_id = ger_id left join t_s_autor on buch_autor_id = au_id left join t_s_verlag on buch_verlag_id = ver_id left join t_s_sprache on buch_sprache_id = sprach_id WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                ISBN = dr["buch_isbn"].ToString();
                Titel = dr["buch_titel"].ToString();
                Genre = new Genre(dr["buch_genre_id"].ToString());
                Autor = new Autor(dr["buch_autor_id"].ToString());
                Verlag = new Verlag(dr["buch_verlag_id"].ToString());
                Er_datum = (DateTime)dr["verified_erscheinungsdatum"];
                Sprache = new Sprache(dr["buch_sprache_id"].ToString());
                Auflage = dr["buch_auflage"].ToString();
                string price = dr["buch_neupreis"].ToString().Replace(".", ",");

                try
                {
                    Neupreis = Convert.ToDecimal(price);
                }
                catch (FormatException)
                {
                    Neupreis = 0;
                    MessageBox.Show("Bitte nur Zahlen eingeben!");
                }
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }

        public bool Pruefe_Ausgeliehen(string s)
        {
            bool ergebnis = false;
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM t_bd_ausgeliehen WHERE bu_id = @0";       
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, s);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                string bu_id = dr["bu_id"].ToString();
                if (bu_id.Equals(""))
                {
                    ergebnis = true;
                }
                else
                {
                    ergebnis = false;
                }
                  
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
            return ergebnis;
        }
        #endregion

        #region Save
        public void Save()
        {
            string RawCommand = "UPDATE [dbo].[t_s_buecher] set buch_titel = @titel , buch_autor_id = @autor, buch_genre_id = @genre, buch_sprache_id = @sprache, buch_verlag_id = @verlag, buch_auflage = @auflage, buch_erscheinungsdatum = @er_datum, buch_neupreis = @neupreis WHERE buch_isbn = @isbn";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@titel", Titel);
            cmd.Parameters.AddWithValue("@autor", Autor.AutorID);
            cmd.Parameters.AddWithValue("@genre", Genre.GenreID);
            cmd.Parameters.AddWithValue("@sprache", Sprache.SpracheID);
            cmd.Parameters.AddWithValue("@verlag", Verlag.VerlagID);
            cmd.Parameters.AddWithValue("@auflage", Auflage);
            cmd.Parameters.AddWithValue("@er_datum", Er_datum);
            cmd.Parameters.AddWithValue("@neupreis", neupreis);
            cmd.Parameters.AddWithValue("@isbn", isbn);

            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
        #endregion

        #region Add
        public void Add()
        {
            {
                string RawCommand = "INSERT INTO [dbo].[t_s_buecher] (buch_isbn, buch_titel, buch_genre_id, buch_autor_id, buch_verlag_id, "
                    + "buch_erscheinungsdatum, buch_sprache_id, buch_auflage, buch_neupreis) VALUES "
                    + "(@isbn, @titel, @genreid, @autorid, @verlagid, @erscheinungsdatum, @sprachid, @auflage, @neupreis)";
                con.ConnectError();
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

                cmd.Parameters.AddWithValue("@isbn", ISBN);
                cmd.Parameters.AddWithValue("@titel", Titel);
                cmd.Parameters.AddWithValue("@genreid", Genre.GenreID);
                cmd.Parameters.AddWithValue("@autorid", Autor.AutorID);
                cmd.Parameters.AddWithValue("@verlagid", Verlag.VerlagID);
                cmd.Parameters.AddWithValue("@erscheinungsdatum", Er_datum);
                cmd.Parameters.AddWithValue("@sprachid", Sprache.SpracheID);
                cmd.Parameters.AddWithValue("@auflage", Auflage);
                cmd.Parameters.AddWithValue("@neupreis", Neupreis);

                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                //Verbindung schließen
                con.Close();
            }
        }
                #endregion

        #region Delete
                public void Delete()
        {
            string RawCommand = "DELETE FROM [dbo].[t_s_buecher] WHERE buch_isbn = @isbn";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Fill ObjectLeihen
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObjectLeihen()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM t_s_buchid " 
                +"left join t_s_buecher on bu_isbn = buch_isbn " 
                +"left join t_s_genre on buch_genre_id = ger_id " 
                +"left join t_s_autor on buch_autor_id = au_id "
                +"left join t_s_verlag on buch_verlag_id = ver_id "
                +"left join t_s_sprache on buch_sprache_id = sprach_id " 
                +"left join t_s_zustand on bu_zustandsid = zu_id " 
                +"left join t_bd_ausgeliehen on aus_buchid = bu_id " 
                +"left join t_s_kunden on kunde_ID = aus_kundenid";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            con.Close();
        }
        #endregion

        #region Fill ObjectBuch
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable();
        SqlCommandBuilder comb2 = new SqlCommandBuilder();
        SQL_Verbindung con2 = new SQL_Verbindung();
        public void FillObjectBuch()
        {
            if (con2.ConnectError()) return;
            //string RawCommand = "SELECT buch_isbn, buch_titel, buch_erscheinungsdatum, buch_auflage, buch_neupreis, ger_name, au_autor, ver_name, sprach_name FROM t_s_buecher left join t_s_genre on buch_genre_id = ger_id left join t_s_autor buch_autor_id = au_id left join t_s_verlag buch_verlag_id = ver_id left join t_s_sprache buch_sprache = sprach_id";
            string RawCommand = "SELECT buch_isbn as 'ISBN',"
                + "buch_titel as 'Titel',"
                + "ger_name as 'Genre',"
                + "au_autor as 'Autor',"
                + "ver_name as 'Verlag',"
                + "buch_erscheinungsdatum as 'Erscheinungsdatum',"
                + "sprach_name as 'Sprache',"
                + "buch_auflage as 'Auflage',"
                + "buch_neupreis as 'Neupreis' from t_s_buecher "
                + "left join t_s_genre on buch_genre_id = ger_id "
                + "left join t_s_autor on buch_autor_id = au_id "
                + "left join t_s_verlag on buch_verlag_id = ver_id "
                + "left join t_s_sprache on buch_sprache_id = sprach_id";
            adapter = new SqlDataAdapter(RawCommand, con2.Con);
            adapter.Fill(ds2);
            adapter.Fill(dt2);
            con2.Close();
        }
        #endregion

        #region ClearDS()
        public void ClearDSBuch()
        {
            ds2.Tables[0].Rows.Clear();
        }
        #endregion

        #region FillGrid
        public void FillGridBuch(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds2.Tables[0];
        }
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
            grid.Columns[2].Visible = false;
            grid.Columns[4].Visible = false;
            grid.Columns[6].Visible = false;
            grid.Columns[7].Visible = false;
            grid.Columns[8].Visible = false;
            grid.Columns[10].Visible = false;
            grid.Columns[13].Visible = false;
            grid.Columns[15].Visible = false;
            grid.Columns[17].Visible = false;
            grid.Columns[19].Visible = false;
            grid.Columns[21].Visible = false;
            grid.Columns[25].Visible = false;
            grid.Columns[28].Visible = false;

            grid.Columns["bu_id"].HeaderText = "Buch-ID:";
            grid.Columns["bu_isbn"].HeaderText = "Buch-ISBN:";
            grid.Columns["bu_aufnahmedatum"].HeaderText = "aufgenommen am:";
            grid.Columns["zu_zustand"].HeaderText = "Zustand:";
            grid.Columns["zu_verleihfähig"].HeaderText = "verleihfähig:";
            grid.Columns["buch_titel"].HeaderText = "Titel";
            grid.Columns["buch_erscheinungsdatum"].HeaderText = "erschienen am:";
            grid.Columns["buch_auflage"].HeaderText = "Auflage:";
            grid.Columns["buch_neupreis"].HeaderText = "Neupreis:";
            grid.Columns["ger_name"].HeaderText = "Genre:";
            grid.Columns["au_autor"].HeaderText = "Autor:";
            grid.Columns["ver_name"].HeaderText = "Verlag:";
            grid.Columns["sprach_name"].HeaderText = "Sprache:";
            grid.Columns["aus_leihnummer"].HeaderText = "Ausleihnummer:";
            grid.Columns["aus_leihdatum"].HeaderText = "ausgeliehen am:";
            grid.Columns["aus_rückgabedatum"].HeaderText = "Rückgabe am:";

        }
        #endregion

        public void Ausleihen(int bu_id, string aus_d, string rück_d, int kunde)
        {
            string RawCommand = "INSERT into [dbo].[t_bd_ausgeliehen] (aus_buchid, aus_leihdatum, aus_rückgabedatum, aus_kundenid) VALUES(@buchid, @ausdatum, @rückdatum, @kunde)";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@buchid", bu_id);
            cmd.Parameters.AddWithValue("@ausdatum", aus_d);
            cmd.Parameters.AddWithValue("@rückdatum", rück_d);
            cmd.Parameters.AddWithValue("@kunde", kunde);

            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
    }
}
