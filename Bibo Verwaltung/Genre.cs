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

        #region Objekt Constructor
        /// <summary>
        /// Erschaft das Objekt Genre
        /// </summary>
        public Genre()
        {
            FillObject();
        }
        public Genre(string genreid)
        {
            this.genreid = genreid;
            Load();
            FillObject();
        }
        #endregion

        #region Load
        public void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL1 = "SELECT * FROM [dbo].[t_s_genre] WHERE ger_id = @genreid";
    
            SqlCommand cmd = new SqlCommand(strSQL1, con);
            cmd.Parameters.AddWithValue("@genreid", genreid);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen 
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

        #region Fill Object
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        SqlConnection con = new SqlConnection();
        private void FillObject()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM [dbo].[t_s_genre]";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            adapter = new SqlDataAdapter(strSQL, con);
            adapter.Fill(ds);
            adapter.Fill(dt);

            con.Close();

        }

        #region Fill Object
        public void FillCombobox(ref ComboBox cb, object value)
        {
            cb.DataSource = dt;
            cb.ValueMember = "ger_id";
            cb.DisplayMember = "ger_name";
            cb.SelectedValue = value;
        }
        #endregion

        public void FillGrid(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["ger_name"].HeaderText = "Bezeichnung";
        }
        #endregion

        #region Speichern Grid
        public void SaveGrid(ref DataGridView grid)
        {
            comb = new SqlCommandBuilder(adapter);
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                adapter.Update(changes);
            }
        }
        #endregion
    }
}
