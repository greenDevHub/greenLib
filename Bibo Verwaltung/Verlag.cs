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
    class Verlag
    {
        #region Verlag Eigenschafen
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
            string strSQL = "SELECT * FROM t_s_verlag WHERE ver_id = @verlagid";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@verlagid", verlagid);

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
        
        #region Fill Combobox
        private DataTable GetDataSource()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_verlag";

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
            cb.ValueMember = "ver_id";
            cb.DisplayMember = "ver_name";
            cb.SelectedValue = value;
        }
        #endregion

        #region New/Update/Drop Sprache
        public void NewVerlag()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "INSERT INTO [dbo].[t_s_verlag] (ver_name) VALUES (@verlag)";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@verlag", Verlagname);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        public void UpdateVerlag()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "UPDATE [dbo].[t_s_verlag] set ver_name = @v_name WHERE ver_id = @v_id";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@v_name", Verlagname);
            cmd.Parameters.AddWithValue("@v_id", VerlagID);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        public void DropVerlag()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "DELETE FROM [dbo].[t_s_verlag] WHERE ver_id =  @v_id";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@v_id", VerlagID);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
        #endregion
    }
}
