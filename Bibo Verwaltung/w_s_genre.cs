using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Bibo_Verwaltung
{
    public partial class w_s_genre : Form
    {
        Buch g;
        public w_s_genre()
        {
            InitializeComponent();
        }
        #region Load
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
        private void FillCombobox(ref ComboBox cb)
        {
            cb.DataSource = GetDataSource();
            cb.ValueMember = "ger_id";
            cb.DisplayMember = "ger_name";
        }
        private void Laden(object sender, EventArgs e)
        {
            g = new Buch(cb_genre.Text);
            FillCombobox(ref cb_genre);
        }
        #endregion
        #region Insert
        private void bt_add_g_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;
            connetionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "insert into t_s_genre ([ger_name]) values(@genre_name)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@genre_name", cb_genre.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Daten hinzugefügt!");
                }
            }
        }
        #endregion
        #region delete
        private void bt_genre_del_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = Bibo_Verwaltung; Integrated Security = sspi");
            SqlCommand sqlComm = new SqlCommand();
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"DELETE FROM t_s_genre WHERE ger_name=@ger_id";
            sqlComm.Parameters.Add("@ger_id", SqlDbType.VarChar);
            sqlComm.Parameters["@ger_id"].Value = cb_genre.Text;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            MessageBox.Show("Ausgewählter Eintrag gelöscht!");
        }
        #endregion
    }
}