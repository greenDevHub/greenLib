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
    public partial class Hauptfenster : Form
    {
        public Hauptfenster()
        {
            InitializeComponent();
        }
        #region Click
        private void bt_buch_a_Click(object sender, EventArgs e)
        {
            w_s_buecher f1 = new w_s_buecher();
            f1.ShowDialog(this);
        }

        private void bt_kunde_a_Click(object sender, EventArgs e)
        {
            w_s_kunden f2 = new w_s_kunden();
            f2.ShowDialog(this);
        }

        private void bt_genre_a_Click(object sender, EventArgs e)
        {
            w_s_genre f3 = new w_s_genre();
            f3.ShowDialog(this);
        }

        private void bt_autor_a_Click(object sender, EventArgs e)
        {
            w_s_autor f4 = new w_s_autor();
            f4.ShowDialog(this);
        }

        private void bt_sprache_a_Click(object sender, EventArgs e)
        {
            w_s_sprache f5 = new w_s_sprache();
            f5.ShowDialog(this);
        }

        private void bt_verlag_a_Click(object sender, EventArgs e)
        {
            w_s_verlag f6 = new w_s_verlag();
            f6.ShowDialog(this);
        }
        #endregion
        #region Load_Stats
        private void Load_All(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL1 = "SELECT * FROM t_s_buchid";
            string strSQL2 = "SELECT * FROM t_bd_ausgeliehen";

            SqlDataAdapter da1 = new SqlDataAdapter(strSQL1, con);
            DataTable tbl1 = new DataTable();
            da1.Fill(tbl1);

            int a = 0;
            for (int i = 0; i < tbl1.Rows.Count; i++)
            {
                a = a + 1;
            }
            tbl1.Reset();
            lb_soll.Text = a.ToString();
            //linkLabel1.Text = a.ToString();

            SqlDataAdapter da2 = new SqlDataAdapter(strSQL2, con);
            DataTable tbl2 = new DataTable();
            da2.Fill(tbl2);

            int b = 0;
            for (int i = 0; i < tbl2.Rows.Count; i++)
            {
                b = b + 1;
            }
            lb_Ausleihzahl.Text = b.ToString();
            tbl2.Reset();
            con.Close();

            lb_Lagerzahl.Text = (a - b).ToString();
        }
        #endregion
        }
    }

