using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bibo_Verwaltung
{
    public partial class w_s_sprache : Form
    {
        Buch g;
        public w_s_sprache()
        {
            InitializeComponent();
        }
        #region Load
        private DataTable GetDataSource()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_sprache";

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
        private void FillCombobox(ref ComboBox cb)
        {
            cb.DataSource = GetDataSource();
            cb.ValueMember = "sprach_id";
            cb.DisplayMember = "sprach_name";
        }
        private void Laden(object sender, EventArgs e)
        {
            g = new Buch(cb_sprache.Text);
            FillCombobox(ref cb_sprache);
        }
        #endregion
        #region Insert
        private void bt_add_sprache_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;
            connetionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "insert into t_s_sprache ([sprach_name]) values(@sprach_name)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@sprach_name", cb_sprache.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Daten hinzugefügt!");
                }
            }
        }
        #endregion
        #region delete
        private void bt_del_sprache_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = Bibo_Verwaltung; Integrated Security = sspi");
            SqlCommand sqlComm = new SqlCommand();
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"DELETE FROM t_s_sprache WHERE sprach_name=@sprach_id";
            sqlComm.Parameters.Add("@sprach_id", SqlDbType.VarChar);
            sqlComm.Parameters["@sprach_id"].Value = cb_sprache.Text;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            MessageBox.Show("Ausgewählter Eintrag gelöscht!");
        }
        #endregion
    }
}
