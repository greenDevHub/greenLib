using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bibo_Verwaltung
{
    class Autor
    {
        string autorid;
        /// <summary>
        /// Isbn Nummer eines Buches
        /// </summary>
        public string AutorID { get { return autorid; } set { autorid = value; } }

        string autorname;
        /// <summary>
        /// Titel eines Buches
        /// </summary>
        public string Autorname { get { return autorname; } set { autorname = value; } }


        /// <summary>
        /// Erschaft das Objekt Buch
        /// </summary>
        public Autor()
        {

        }
        public Autor(string autorid)
        {
            this.autorid = autorid;
            Load();
        }
        private void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_autor "
                + "WHERE au_id = '" + autorid + "'";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                AutorID = dr["au_id"].ToString();
                Autorname = dr["au_autor"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
    }
}
