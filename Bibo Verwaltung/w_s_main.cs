using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_main : Form
    {
        bool error = false;
        public w_s_main()
        {
            InitializeComponent();
        }
        #region Load Stats
        private void Load_All(object sender, EventArgs e)
        {
            if (error == true) return;
            // Gesamtübersicht laden
            SQL_Verbindung con = new SQL_Verbindung();
            con.ConnectError();

            string strSQL1 = "SELECT * FROM t_s_buecher";
            string strSQL2 = "SELECT * FROM t_bd_ausgeliehen";

            SqlDataAdapter adapter_1 = new SqlDataAdapter(strSQL1, con.Con);
            DataTable tbl_1 = new DataTable();
            adapter_1.Fill(tbl_1);

            int rows_1 = 0;
            for (int i = 0; i < tbl_1.Rows.Count; i++)
            {
                rows_1 = rows_1 + 1;
            }
            tbl_1.Reset();
            lb_Bestandzahl.Text = rows_1.ToString();
            //linkLabel1.Text = rows_1.ToString();

            SqlDataAdapter adapter_2 = new SqlDataAdapter(strSQL2, con.Con);
            DataTable tbl_2 = new DataTable();
            adapter_2.Fill(tbl_2);

            int rows_2 = 0;
            for (int i = 0; i < tbl_2.Rows.Count; i++)
            {
                rows_2 = rows_2 + 1;
            }
            lb_Ausleihzahl.Text = rows_2.ToString();
            tbl_2.Reset();

            lb_Lagerzahl.Text = (rows_1 - rows_2).ToString();

            con.Close();
        }
        #endregion

        #region Formulare aufrufen
        private void bt_Kunden_Click(object sender, EventArgs e)
        {
            Form Kunden = new w_s_Kunden();
            Kunden.ShowDialog(this);
        }

        private void bt_Genres_Click(object sender, EventArgs e)
        {
            Form Genres = new w_s_genres();
            Genres.ShowDialog(this);
        }

        private void bt_Sprachen_Click(object sender, EventArgs e)
        {
            Form Sprachen = new w_s_sprachen();
            Sprachen.ShowDialog(this);
        }

        private void bt_Autoren_Click(object sender, EventArgs e)
        {
            Form Autoren = new w_s_autoren();
            Autoren.ShowDialog(this);
        }

        private void bt_Verlage_Click(object sender, EventArgs e)
        {
            Form Verlage = new w_s_verlage();
            Verlage.ShowDialog(this);
        }

        private void bt_Buecher_Click(object sender, EventArgs e)
        {
            Form Buecher = new w_s_buecher();
            Buecher.ShowDialog(this);
        }
        private void bt_Einstellungen_Click(object sender, EventArgs e)
        {
            Form Einstellungen = new w_s_Einstellungen();
            Einstellungen.ShowDialog(this);
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Details = new w_s_details();
            Details.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form Details = new w_s_details();
            Details.ShowDialog(this);
        }

        private void bt_Zustand_Click(object sender, EventArgs e)
        {
            Form Zustand = new w_s_zustand();
            Zustand.ShowDialog(this);
        }
    }
}
