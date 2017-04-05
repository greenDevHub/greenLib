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
    class Sprache
    {
        #region Strings
        string spracheid;
        /// <summary>
        /// ID der Sprache
        /// </summary>
        public string SpracheID { get { return spracheid; } set { spracheid = value; } }

        string sprachename;
        /// <summary>
        /// Name der Sprache
        /// </summary>
        public string Sprachename { get { return sprachename; } set { sprachename = value; } }
        #endregion
        #region Objekt Sprache
        /// <summary>
        /// Erschaft das Objekt Sprache
        /// </summary>
        public Sprache()
        {

        }
        public Sprache(string spracheid)
        {
            this.spracheid = spracheid;
            Load();
        }
        #endregion
        #region Load
        private void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_sprache WHERE sprach_id = '" + spracheid + "'";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                SpracheID = dr["sprach_id"].ToString();
                Sprachename = dr["sprach_name"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion
    }
}
