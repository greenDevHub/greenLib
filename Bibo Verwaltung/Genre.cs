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
        #region Genre Eigenschaften
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
        public void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL1 = "SELECT * FROM [dbo].[t_s_genre] WHERE ger_id = @genreid";
            //string strSQL2 = "SELECT * FROM t_s_genre WHERE ger_name = @ger_name";

            //if (v == "1")
            //{
                SqlCommand cmd = new SqlCommand(strSQL1, con);
                cmd.Parameters.AddWithValue("@genreid", genreid);

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
               // con.Close();
            //} else if (v == "2")
            //{
            //    SqlCommand cmd = new SqlCommand(strSQL2, con);
            //    cmd.Parameters.AddWithValue("@ger_name", Genrename);

            //    // Verbindung öffnen 
            //    con.Open();
            //    SqlDataReader dr = cmd.ExecuteReader();
            //    // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            //    while (dr.Read())
            //    {
            //        GenreID = dr["ger_id"].ToString();
            //        Genrename = dr["ger_name"].ToString();
            //    }
            //    // DataReader schließen 
            //    dr.Close();
            //    // Verbindung schließen 
            //   // con.Close();
            //}
            ////SqlCommand cmd = new SqlCommand(strSQL, con);
            //cmd.Parameters.AddWithValue("@genreid", genreid);
            //cmd.Parameters.AddWithValue("@ger_name", Genrename);

            // Verbindung öffnen 
          //  con.Open();
           // SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            //while (dr.Read())
            //{
            //    GenreID = dr["ger_id"].ToString();
            //    Genrename = dr["ger_name"].ToString();
            //}
            // DataReader schließen 
         //   dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion

        #region Fill Combobox
        private DataTable GetDataSource()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_genre";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();

            return dt;
        }
        public void FillCombobox(ref ComboBox cb, object value)
        {
            cb.DataSource = GetDataSource();
            cb.ValueMember = "ger_id";
            cb.DisplayMember = "ger_name";
            cb.SelectedValue = value;
        }
        #endregion

        #region New/Update/Drop Genre-Methoden
        public void NewGenre()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "INSERT INTO [dbo].[t_s_genre] (ger_name) VALUES (@g_name)";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@g_name", Genrename);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        public void UpdateGenre()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "UPDATE [dbo].[t_s_genre] set ger_name = @ger_name WHERE ger_id = @ger_id";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@ger_name", Genrename);
            cmd.Parameters.AddWithValue("@ger_id", GenreID);
           
            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        public void DropGenre()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "DELETE FROM [dbo].[t_s_genre] WHERE ger_id =  @g_id";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@g_id", GenreID);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
        #endregion
    }
}
