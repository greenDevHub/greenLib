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
            linkLabel1.Text = rows_1.ToString();

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

            // Comboboxen füllen
            Genre genre = new Genre();
            genre.FillCombobox(ref cb_Genre, -1);

            Autor autor = new Autor();
            autor.FillCombobox(ref cb_Autor, -1);

            Verlag verlag = new Verlag();
            verlag.FillCombobox(ref cb_Verlag, -1);

            con.Close();
        }
            #endregion

        #region Formulare aufrufen
            private void bt_Kunden_Click(object sender, EventArgs e)
            {
                Form Kunden = new w_s_kunden();
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
            #endregion

        #region Buch-Suche
            public void Suchtyp(object sender, EventArgs e)
            {
                if (rb_SuchAutor.Checked)
                {
                    cb_Autor.Enabled = true;
                    cb_Genre.Enabled = false;
                    cb_Verlag.Enabled = false;
                    tb_Titel.Enabled = false;
                } else if (rb_SuchGenre.Checked)
                {
                    cb_Autor.Enabled = false;
                    cb_Genre.Enabled = true;
                    cb_Verlag.Enabled = false;
                    tb_Titel.Enabled = false;
                } else if (rb_SuchTitel.Checked)
                {
                    cb_Autor.Enabled = false;
                    cb_Genre.Enabled = false;
                    cb_Verlag.Enabled = false;
                    tb_Titel.Enabled = true;
                } else if (rb_SuchVerlag.Checked)
                {
                    cb_Autor.Enabled = false;
                    cb_Genre.Enabled = false;
                    cb_Verlag.Enabled = true;
                    tb_Titel.Enabled = false;
                }
            }

            public void Suchen(object sender, EventArgs e)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
                string strSQL = "SELECT *, isnull(buch_erscheinungsdatum, '01.01.1990') as 'verified_erscheinungsdatum' FROM t_s_buecher "
                    + "left join t_s_genre on buch_genre_id = ger_id "
                    + "left join t_s_autor on buch_autor_id = au_id "
                    + "left join t_s_verlag on buch_verlag_id = ver_id "
                    + "left join t_s_sprache on buch_sprache_id = sprach_id "
                    + "WHERE @buch_value = @value";

                SqlCommand cmd = new SqlCommand(strSQL, con);
                Console.WriteLine("Los");
                if (rb_SuchAutor.Checked)
                {
                    cmd.Parameters.AddWithValue("@buch_value", "buch_autor_id");
                    cmd.Parameters.AddWithValue("@value", cb_Autor.SelectedValue.ToString());
                }
                else if (rb_SuchGenre.Checked)
                {
                    cmd.Parameters.AddWithValue("@buch_value", "buch_genre_id");
                    cmd.Parameters.AddWithValue("@value", cb_Genre.SelectedValue.ToString());
                }
                else if (rb_SuchTitel.Checked)
                {
                    cmd.Parameters.AddWithValue("@buch_value", "buch_titel");
                    cmd.Parameters.AddWithValue("@value", tb_Titel.Text);
                    // Verbindung öffnen 
                    con.Open();
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    // Einlesen der Datenzeilen und Ausgabe an der Konsole 
                    while (dr1.Read())
                    {
                        Buch b = new Buch(dr1["buch_isbn"].ToString());
                        string[] row = { "Hallo", "djhf", "Hallo", "djhf", "Hallo" };// dr["buch_titel"].ToString(), dr["buch_titel"].ToString(), dr["buch_titel"].ToString(), dr["buch_titel"].ToString(), dr["buch_titel"].ToString() };
                        var listViewItem = new ListViewItem(row);

                        listView1.Items.Add(listViewItem);
                        listView1.Show();
                        Console.WriteLine("Jdjsadsadsadasd");
                    }

                    // DataReader schließen 
                    dr1.Close();
                    // Verbindung schließen 
                    con.Close();
                }
                else if (rb_SuchVerlag.Checked)
                {
                    cmd.Parameters.AddWithValue("@buch_value", "buch_verlag_id");
                    cmd.Parameters.AddWithValue("@value", cb_Verlag.SelectedValue.ToString());
                }
                Console.WriteLine("weiter");
                // Verbindung öffnen 
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ///Einlesen der Datenzeilen und Ausgabe an der Konsole 
                while (dr.Read())
                {
                Buch b = new Buch(dr["buch_isbn"].ToString());
                    string[] row = { "Hallo", "djhf", "Hallo", "djhf", "Hallo" };// dr["buch_titel"].ToString(), dr["buch_titel"].ToString(), dr["buch_titel"].ToString(), dr["buch_titel"].ToString(), dr["buch_titel"].ToString() };
                    var listViewItem = new ListViewItem(row);

                    listView1.Items.Add(listViewItem);
                    listView1.Show();
                    Console.WriteLine("Jdjsadsadsadasd");
                }

                //// DataReader schließen 
                dr.Close();
                //// Verbindung schließen 
                con.Close();
            }
            #endregion

            private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            {
                Form Details = new w_s_details();
                Details.ShowDialog(this);
            }
        }
    }
