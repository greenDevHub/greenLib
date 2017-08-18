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
    public partial class w_s_autor : Form
    {
        Buch g;
        public w_s_autor()
        {
            InitializeComponent();
        }
        #region Load
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
        private void FillCombobox(ref ComboBox cb)
        {
            cb.DataSource = GetDataSource();
            cb.ValueMember = "au_id";
            cb.DisplayMember = "au_autor";
        }
        private void Laden(object sender, EventArgs e)
        {
            g = new Buch(cb_autor.Text);
            FillCombobox(ref cb_autor);
        }
        #endregion

        #region Insert
        private void bt_add_autor_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;
            connetionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            using (SqlConnection cnn = new SqlConnection(connetionString))
            {
                sql = "insert into t_s_autor ([au_autor]) values(@autor_name)";
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.AddWithValue("@autor_name", cb_autor.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Daten hinzugefügt!");
                }
            }
        }
        #endregion
        #region delete
        private void bt_del_autor_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConn = new SqlConnection("Data Source =.\\SQLEXPRESS; Initial Catalog = Bibo_Verwaltung; Integrated Security = sspi");
            SqlCommand sqlComm = new SqlCommand();
            sqlComm = sqlConn.CreateCommand();
            sqlComm.CommandText = @"DELETE FROM t_s_autor WHERE au_autor=@au_id";
            sqlComm.Parameters.Add("@au_id", SqlDbType.VarChar);
            sqlComm.Parameters["@au_id"].Value = cb_autor.Text;
            sqlConn.Open();
            sqlComm.ExecuteNonQuery();
            sqlConn.Close();
            MessageBox.Show("Ausgewählter Eintrag gelöscht!");
        }
        #endregion
    }
}
