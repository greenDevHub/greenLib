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
        #region Sprache Eigenschaften
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
            FillObject();
        }
        public Sprache(string spracheid)
        {
            this.spracheid = spracheid;
            Load();
            FillObject();
        }
        #endregion

        #region Load
        private void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_sprache WHERE sprach_id = @spracheid";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@spracheid", spracheid);

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

        #region Fill Combobox
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        SqlConnection con = new SqlConnection();
        private void FillObject()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_sprache";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            // Verbindung öffnen 
            con.Open();
            adapter = new SqlDataAdapter(strSQL, con);
            adapter.Fill(ds);
            adapter.Fill(dt);

            con.Close();

        }
        public void FillCombobox(ref ComboBox cb, object value)
        {
            cb.DataSource = dt;
            cb.ValueMember = "sprach_id";
            cb.DisplayMember = "sprach_name";
            cb.SelectedValue = value;
        }
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            //FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["sprach_name"].HeaderText = "Bezeichnung";
        }
        #endregion

        #region New/Update/Drop Genre-Methoden
        public void NewSprache()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "INSERT INTO [dbo].[t_s_sprache] (sprach_name) VALUES (@sprache)";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@sprache", Sprachename);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        public void UpdateSprache()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "UPDATE [dbo].[t_s_sprache] set sprach_name = @s_name WHERE sprach_id = @s_id";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@s_name", Sprachename);
            cmd.Parameters.AddWithValue("@s_id", SpracheID);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        public void DropSprache()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "DELETE FROM [dbo].[t_s_sprache] WHERE sprach_id =  @s_id";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@s_id", SpracheID);

            // Verbindung öffnen 
            con.Open();
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
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

