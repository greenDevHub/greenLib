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
    class Vertrauen
    {
        #region Strings
        string vertrauenid;
        /// <summary>
        /// ID der Vertrauenswürdigkeit
        /// </summary>
        public string VertrauenID { get { return vertrauenid; } set { vertrauenid = value; } }

        string vertrauenname;
        /// <summary>
        /// Name der Vertrauenswürdigkeit
        /// </summary>
        public string Vertrauenname { get { return vertrauenname; } set { vertrauenname = value; } }
        #endregion
        #region Objekt Vertrauen
        /// <summary>
        /// Erschaft das Objekt Vertrauen
        /// </summary>
        public Vertrauen()
        {

        }
        public Vertrauen(string vertrauenid)
        {
            this.vertrauenid = vertrauenid;
            Load();
        }
        #endregion
        #region Load
        private void Load()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_vertrauen WHERE v_id = @vertrauenid";

            SqlCommand cmd = new SqlCommand(strSQL, con);
            cmd.Parameters.AddWithValue("@vertrauenid", vertrauenid);

            // Verbindung öffnen 
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                VertrauenID = dr["v_id"].ToString();
                Vertrauenname = dr["v_name"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion
        #region Datatable
        private DataTable GetDataSource()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_vertrauen";

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
            cb.ValueMember = "v_id";
            cb.DisplayMember = "v_name";
            cb.SelectedValue = value;
        }
        #endregion
    }
}
