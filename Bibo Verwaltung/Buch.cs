using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Bibo_Verwaltung
{
    class Buch
    {
        string isbn;
        /// <summary>
        /// Isbn Nummer eines Buches
        /// </summary>
        public string Isbn
        {
            get { return  isbn;}
            set { isbn = value; }
        }
        string titel;
        public string Titel { get { return titel; } set { titel = value; } }
        string genre;
        public string Genre { get { return genre; } set { genre = value; } }
        string verlag;
        string autor;
        DateTime er_datum;
        string sprache;
        string auflage;
        double neupreis;

        /// <summary>
        /// Erschaft das Objekt Buch
        /// </summary>
        public Buch()
        {

        }
        public Buch (string isbn)
        {
            this.isbn = isbn;
            Load();
        }
        private void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_buecher "
                + "left join t_s_genre on buch_genre_id = ger_id "
                + "left join t_s_autor on buch_autor_id = au_id "
                + "left join t_s_verlag on buch_verlag_id = ver_id "
                + "left join t_s_sprache on buch_sprache_id = sprach_id "
                + "WHERE buch_isbn = '" + isbn + "'";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                Isbn = dr["buch_isbn"].ToString();
                Titel = dr["buch_titel"].ToString();
                Genre = dr["ger_name"].ToString();
                autor = dr["au_autor"].ToString();
                verlag = dr["ver_name"].ToString();
                //er_datum = dr["buch_erscheinungsdatum"].ToString();
                sprache = dr["sprach_name"].ToString();
                auflage = dr["buch_auflage"].ToString();
                //neupreis = dr["buch_neupreis"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
    }
}
