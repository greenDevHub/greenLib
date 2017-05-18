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
    class Autor
    {
        #region Autor Eigenschafen
        string autorid;
        /// <summary>
        /// ID des Autors
        /// </summary>
        public string AutorID { get { return autorid; } set { autorid = value; } }

        string autorname;
        /// <summary>
        /// Autorname eines Autors
        /// </summary>
        public string Autorname { get { return autorname; } set { autorname = value; } }
        #endregion

        #region Objekt Autor
        /// <summary>
        /// Erschaft das Objekt Autor
        /// </summary>
        public Autor()
        {

        }
        public Autor(string autorid)
        {
            this.autorid = autorid;
            Load();
        }
        #endregion

        #region Load
        private void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_autor WHERE au_id = @autor";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@autor", autorid);

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
        #endregion

        #region Fill Combobox
        private DataTable GetDataSource()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_autor";

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
            cb.ValueMember = "au_id";
            cb.DisplayMember = "au_autor";
            cb.SelectedValue = value;
        }
        #endregion

        #region New/Update/Drop Sprache
        public void NewAutor()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "INSERT INTO [dbo].[t_s_autor] (au_autor) VALUES (@autor)";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@autor", Autorname);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        public void UpdateAutor()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "UPDATE [dbo].[t_s_autor] set au_autor = @autorname WHERE au_id = @autorid";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@autorname", Autorname);
            cmd.Parameters.AddWithValue("@autorid", AutorID);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        public void DropAutor()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "DELETE FROM [dbo].[t_s_autor] WHERE au_id =  @autorid";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@autorid", AutorID);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
        #endregion
    }
}
