using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Genre
    {
        #region Strings
        string genreid;
        /// <summary>
        /// ID des Genres
        /// </summary>
        public string GenreID { get { return genreid; } set { genreid = value; } }

        string genrename;
        /// <summary>
        /// Name des Genres
        /// </summary>
        public string Genrename { get { return genrename; } set { genrename = value; } }
        #endregion
        #region Objekt Genre
        /// <summary>
        /// Erschaft das Objekt Genre
        /// </summary>
        public Genre()
        {

        }
        public Genre(string genreid)
        {
            this.genreid = genreid;
            Load();
        }
        #endregion
        #region Load
        private void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_genre WHERE ger_id = '" + genreid + "'";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                GenreID = dr["ger_id"].ToString();
                Genrename = dr["ger_name"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion
    }
}
