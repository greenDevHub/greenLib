using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;

namespace Bibo_Verwaltung
{
    class Buch
    {
        SQL_Verbindung con = new SQL_Verbindung();
        #region Buch Eigenschaften
        string isbn;
        /// <summary>
        /// Isbn Nummer eines Buches
        /// </summary>
        public string ISBN { get { return isbn; } set { isbn = value; } }

        string titel;
        /// <summary>
        /// Titel eines Buches
        /// </summary>
        public string Titel { get { return titel; } set { titel = value; } }

        Genre genre;
        /// <summary>
        /// Genre eines Buches
        /// </summary>
        public Genre Genre { get { return genre; } set { genre = value; } }

        Verlag verlag;
        /// <summary>
        /// Verlag des Buches
        /// </summary>
        public Verlag Verlag { get { return verlag; } set { verlag = value; } }

        Autor autor;
        /// <summary>
        /// Autor eines Buches
        /// </summary>
        public Autor Autor { get { return autor; } set { autor = value; } }

        Sprache sprache;
        /// <summary>
        /// Sprache des Buches
        /// </summary>
        public Sprache Sprache { get { return sprache; } set { sprache = value; } }

        string auflage;
        /// <summary>
        /// Auflage eines Buches
        /// </summary>
        public string Auflage { get { return auflage; } set { auflage = value; } }

        DateTime er_datum;
        /// <summary>
        /// Erscheinungsdatum eines Buches
        /// </summary>
        public DateTime Er_datum { get { return er_datum; } set { er_datum = value; } }

        decimal neupreis;
        /// <summary>
        /// Neupreis eines Buches
        /// </summary>
        public decimal Neupreis { get { return neupreis; } set { neupreis = value; } }
        #endregion

        #region Objekt Buch
        /// <summary>
        /// Erschaft das Objekt Buch
        /// </summary>
        public Buch()
        {
            FillObject();
        }
        public Buch(string isbn)
        {
            this.isbn = isbn;
            Load();
            FillObject();
        }
        #endregion

        #region Load
        private void Load()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT *, isnull(buch_erscheinungsdatum, '01.01.1990') as 'verified_erscheinungsdatum' FROM t_s_buecher left join t_s_genre on buch_genre_id = ger_id left join t_s_autor on buch_autor_id = au_id left join t_s_verlag on buch_verlag_id = ver_id left join t_s_sprache on buch_sprache_id = sprach_id WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                ISBN = dr["buch_isbn"].ToString();
                Titel = dr["buch_titel"].ToString();
                Genre = new Genre(dr["buch_genre_id"].ToString());
                Autor = new Autor(dr["buch_autor_id"].ToString());
                //Autor = dr["au_autor"].ToString();
                Verlag = new Verlag(dr["buch_verlag_id"].ToString());
                //Verlag = dr["ver_name"].ToString();
                Er_datum = (DateTime)dr["verified_erscheinungsdatum"];
                Sprache = new Sprache(dr["buch_sprache_id"].ToString());
                Auflage = dr["buch_auflage"].ToString();
                string price = dr["buch_neupreis"].ToString().Replace(".", ",");

                try
                {
                    Neupreis = Convert.ToDecimal(price);
                }

                catch (FormatException)
                {
                    Neupreis = 0;
                    MessageBox.Show("Bitte nur Zahlen eingeben!");
                }
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();

            SQL_Verbindung con1 = new SQL_Verbindung();
            if (con1.ConnectError()) return;
            string RawCommand1 = "SELECT *, isnull(buch_erscheinungsdatum, '01.01.1990') as 'verified_erscheinungsdatum' FROM t_s_buecher left join t_s_genre on buch_genre_id = ger_id left join t_s_autor on buch_autor_id = au_id left join t_s_verlag on buch_verlag_id = ver_id left join t_s_sprache on buch_sprache_id = sprach_id WHERE buch_titel = @0";
            SqlDataReader dr1 = con1.ExcecuteCommand(RawCommand1, isbn);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr1.Read())
            {
                ISBN = dr1["buch_isbn"].ToString();
                Titel = dr1["buch_titel"].ToString();
                Genre = new Genre(dr1["buch_genre_id"].ToString());
                Autor = new Autor(dr1["buch_autor_id"].ToString());
                //Autor = dr["au_autor"].ToString();
                Verlag = new Verlag(dr1["buch_verlag_id"].ToString());
                //Verlag = dr["ver_name"].ToString();
                Er_datum = (DateTime)dr1["verified_erscheinungsdatum"];
                Sprache = new Sprache(dr1["buch_sprache_id"].ToString());
                Auflage = dr1["buch_auflage"].ToString();
                string price = dr1["buch_neupreis"].ToString().Replace(".", ",");

                try
                {
                    Neupreis = Convert.ToDecimal(price);
                }

                catch (FormatException)
                {
                    Neupreis = 0;
                    MessageBox.Show("Bitte nur Zahlen eingeben!");
                }
            }
            // DataReader schließen 
            dr1.Close();
            // Verbindung schließen 
            con1.Close();
        }
        #endregion

        #region Save
        public void Save()
        {
            string RawCommand = "UPDATE [dbo].[t_s_buecher] set buch_titel = @titel , buch_autor_id = @autor, buch_genre_id = @genre, buch_sprache_id = @sprache, buch_verlag_id = @verlag, buch_auflage = @auflage, buch_erscheinungsdatum = @er_datum, buch_neupreis = @neupreis WHERE buch_isbn = @isbn";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@titel", Titel);
            cmd.Parameters.AddWithValue("@autor", Autor.AutorID);
            cmd.Parameters.AddWithValue("@genre", Genre.GenreID);
            cmd.Parameters.AddWithValue("@sprache", Sprache.SpracheID);
            cmd.Parameters.AddWithValue("@verlag", Verlag.VerlagID);
            cmd.Parameters.AddWithValue("@auflage", Auflage);
            cmd.Parameters.AddWithValue("@er_datum", Er_datum);
            cmd.Parameters.AddWithValue("@neupreis", neupreis);
            cmd.Parameters.AddWithValue("@isbn", isbn);

            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
        #endregion

        #region Fill Object
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            //string strSQL = "SELECT *, isnull(buch_erscheinungsdatum, '01.01.1990') as 'verified_erscheinungsdatum' FROM t_s_buecher left join t_s_genre on buch_genre_id = ger_id left join t_s_autor on buch_autor_id = au_id left join t_s_verlag on buch_verlag_id = ver_id left join t_s_sprache on buch_sprache_id = sprach_id";// WHERE buch_isbn = @isbn";
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM t_s_buchid left join t_s_zustand on bu_zustandsid = zu_id left join t_bd_ausgeliehen on aus_buchid = bu_id left join t_s_kunden on kunde_ID = aus_kundenid left join t_s_buecher on bu_isbn = buch_isbn left join t_s_genre on buch_genre_id = ger_id left join t_s_autor on buch_autor_id = au_id left join t_s_verlag on buch_verlag_id = ver_id left join t_s_sprache on buch_sprache_id = sprach_id";

            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);

            con.Close();
        }

        public void FillGrid(ref DataGridView grid, object value = null)
        {
            DataGridViewLinkColumn links = new DataGridViewLinkColumn();
            links.UseColumnTextForLinkValue = true;
            links.LinkBehavior = LinkBehavior.SystemDefault;
            links.TrackVisitedState = true;

            //grid.CurrentCellAddress[1,grid.RowCount] = grid.Columns.Add(links);


            grid.DataSource = ds.Tables[0];
            grid.Columns[2].Visible = false;
            grid.Columns[4].Visible = false;
            grid.Columns[8].Visible = false;
            //grid.Columns[9].Visible = false;
            //grid.Columns[10].Visible = false;
            //grid.Columns[11].Visible = false;
            //grid.Columns[13].Visible = false;
            //grid.Columns[16].Visible = false;
            //grid.Columns[18].Visible = false;
            //grid.Columns[20].Visible = false;
            //grid.Columns[22].Visible = false;

            grid.Columns["bu_id"].HeaderText = "Buch-ID:";
            grid.Columns["bu_isbn"].HeaderText = "Buch-ISBN:";
            grid.Columns["bu_aufnahmedatum"].HeaderText = "aufgenommen am:";
            grid.Columns["zu_zustand"].HeaderText = "Zustand:";
            grid.Columns["zu_verleihfähig"].HeaderText = "verleihfähig:";
            grid.Columns["buch_titel"].HeaderText = "Titel:";
            grid.Columns["buch_erscheinungsdatum"].HeaderText = "Erscheinungsdatum:";


        }
        #endregion
    }
}
