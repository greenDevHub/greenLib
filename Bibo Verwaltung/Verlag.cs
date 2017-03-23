using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bibo_Verwaltung
{
    class Verlag
    {
        #region Strings
        string verlagid;
        /// <summary>
        /// ID des Verlags
        /// </summary>
        public string VerlagID { get { return verlagid; } set { verlagid = value; } }

        string verlagname;
        /// <summary>
        /// Name des Verlags
        /// </summary>
        public string Verlagname { get { return verlagname; } set { verlagname = value; } }
        #endregion
        #region Objekt Verlag
        /// <summary>
        /// Erschaft das Objekt Verlag
        /// </summary>
        public Verlag()
        {

        }
        public Verlag(string verlagid)
        {
            this.verlagid = verlagid;
            Load();
        }
        #endregion
        #region Load
        private void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_verlag "
                + "WHERE ver_id = '" + verlagid + "'";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                VerlagID = dr["ver_id"].ToString();
                Verlagname = dr["ver_name"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion
    }
}
