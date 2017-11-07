using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.ComponentModel;
using System.IO;

namespace Bibo_Verwaltung
{
    class Buch
    {
        #region Datenbank-Verbinding bereitstellen
        SQL_Verbindung con = new SQL_Verbindung();
        #endregion

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

        Genre genre = new Genre();
        /// <summary>
        /// Genre eines Buches
        /// </summary>
        public Genre Genre { get { return genre; } set { genre = value; } }

        Verlag verlag = new Verlag();
        /// <summary>
        /// Verlag des Buches
        /// </summary>
        public Verlag Verlag { get { return verlag; } set { verlag = value; } }

        AutorListe autorliste = new AutorListe();
        /// <summary>
        /// Autor eines Buches
        /// </summary>
        public AutorListe AutorListe { get { return autorliste; } set { autorliste = value; } }

        Sprache sprache = new Sprache();
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

        string bildPfad;
        /// <summary>
        /// Bild eines Buches
        /// </summary>
        public string BildPfad { get { return bildPfad; } set { bildPfad = value; } }

        DateTime bildDate;
        public DateTime BildDate { get { return bildDate; } set { bildDate = value; } }

        int anzahl;
        /// <summary>
        /// Anzahl der Exemplare
        /// </summary>
        public int Anzahl { get { return anzahl; } set { anzahl = value; } }

        byte[] image;
        public byte[] Image { get { return image; } set { image = value; } }

        DateTime imageDate;
        public DateTime ImageDate { get { return imageDate; } set { imageDate = value; } }

        #endregion

        #region Objekt Buch
        /// <summary>
        /// Erschaft das Objekt Buch
        /// </summary>
        public Buch()
        {
            FillObjectBuch();
            FillObject_All();
        }
        //public Buch()
        //{
        //    //FillObject();
        //    FillObjectLeihen();
        //}
        public Buch(string isbn)
        {
            this.isbn = isbn;
            Load_Buch();
            //FillObject();
            FillObject_All();
        }
        #endregion

        #region Buch per ISBN laden
        private void Load_Buch()
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "SELECT *, isnull(buch_erscheinungsdatum, '01.01.1990') as 'verified_erscheinungsdatum' FROM [dbo].[t_s_buecher] left join [dbo].[t_s_genre] on buch_genre_id = ger_id left join [dbo].[t_s_autor] on buch_autor_id = au_id left join [dbo].[t_s_verlag] on buch_verlag_id = ver_id left join [dbo].[t_s_sprache] on buch_sprache_id = sprach_id WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            // Einlesen der Datenzeilen 
            while (dr.Read())
            {
                ISBN = dr["buch_isbn"].ToString();
                Titel = dr["buch_titel"].ToString();
                Genre = new Genre(dr["buch_genre_id"].ToString());
                AutorListe = new AutorListe(dr["buch_autor_id"].ToString());
                Verlag = new Verlag(dr["buch_verlag_id"].ToString());
                Er_datum = (DateTime)dr["verified_erscheinungsdatum"];
                Sprache = new Sprache(dr["buch_sprache_id"].ToString());
                Auflage = dr["buch_auflage"].ToString();
                string price = dr["buch_neupreis"].ToString().Replace(".", ",");
                BildPfad = dr["buch_bild"].ToString();
                Anzahl = int.Parse(dr["buch_anzahl"].ToString());
                if(BildPfad != null && BildPfad != "" && File.Exists(BildPfad))
                {
                    BildDate = DateTime.Parse(File.GetCreationTimeUtc(BildPfad).ToShortTimeString());
                }
                if(dr["buch_imageDate"] != null && dr["buch_imageDate"].ToString() != "")
                {
                    ImageDate = (DateTime)dr["buch_imageDate"];
                }
                if (ImageDate >= BildDate && ImageDate != null && BildDate != null && ImageDate.ToString() != "01.01.1753 00:00:00" && BildDate.ToString() != "01.01.0001 00:00:00" && BildPfad != null && BildPfad != "" && File.Exists(BildPfad))
                {
                    Image = null;
                }
                else
                {
                    if (dr["buch_image"] != null && dr["buch_image"].ToString() != "")
                    {
                        Image = (Byte[])(dr["buch_image"]);
                    }
                }
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
        }
        #endregion

        #region
        public string GetAutorID(string isbn)
        {
            string id = "";
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT buch_autor_id FROM [dbo].[t_s_buecher] WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            while (dr.Read())
            {
                id = dr["buch_autor_id"].ToString();
            }
            return id;
        }
        #endregion

        #region Buch-Eigenschaften aendern
        public void Update_Buch()
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_buecher] set buch_titel = @titel , buch_genre_id = @genre, buch_sprache_id = @sprache, buch_verlag_id = @verlag, buch_auflage = @auflage, buch_erscheinungsdatum = @er_datum, buch_neupreis = @neupreis, buch_bild = @bild, buch_anzahl = @anzahl, buch_image = @image, buch_imageDate = @imageDate WHERE buch_isbn = @isbn";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            AutorListe.Update();
            cmd.Parameters.AddWithValue("@titel", Titel);
            cmd.Parameters.AddWithValue("@genre", Genre.GenreID);
            cmd.Parameters.AddWithValue("@sprache", Sprache.SpracheID);
            cmd.Parameters.AddWithValue("@verlag", Verlag.VerlagID);
            if(Auflage == null || Auflage.Equals(""))
            {
                cmd.Parameters.AddWithValue("@auflage", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@auflage", Auflage);
            }
            cmd.Parameters.AddWithValue("@er_datum", Er_datum);

            cmd.Parameters.AddWithValue("@neupreis", neupreis);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.Parameters.AddWithValue("@bild", bildPfad);
            cmd.Parameters.AddWithValue("@anzahl", anzahl);
            cmd.Parameters.Add("@image", SqlDbType.VarBinary, -1);
            if(image == null)
            {
                cmd.Parameters["@image"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@image"].Value = Image;
            }
            cmd.Parameters.AddWithValue("@imageDate", imageDate);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Buch hinzufuegen
        public void Add_Buch()
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_buecher] (buch_isbn, buch_titel, buch_genre_id, buch_autor_id, buch_verlag_id, buch_erscheinungsdatum, buch_sprache_id, buch_auflage, buch_neupreis, buch_bild, buch_anzahl, buch_image, buch_imageDate) VALUES (@isbn, @titel, @genreid, @autorid, @verlagid, @erscheinungsdatum, @sprachid, @auflage, @neupreis, @bild, @anzahl, @image, @imageDate)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            AutorListe.Add();
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.Parameters.AddWithValue("@titel", Titel);
            cmd.Parameters.AddWithValue("@genreid", Genre.GenreID);
            cmd.Parameters.AddWithValue("@autorid", AutorListe.AutorListeID);
            cmd.Parameters.AddWithValue("@verlagid", Verlag.VerlagID);
            cmd.Parameters.AddWithValue("@sprachid", Sprache.SpracheID);
            cmd.Parameters.AddWithValue("@erscheinungsdatum", Er_datum);

            if (Auflage == null)
            {
                cmd.Parameters.AddWithValue("@auflage", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@auflage", Auflage);
            }
            if (Neupreis.Equals(1))
            {
                cmd.Parameters.AddWithValue("@neupreis", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@neupreis", neupreis);

            }
            cmd.Parameters.AddWithValue("@bild", BildPfad);
            cmd.Parameters.AddWithValue("@anzahl", Anzahl);
            cmd.Parameters.AddWithValue("@image", Image);
            cmd.Parameters.AddWithValue("@imageDate", ImageDate);


            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Buch loeschen (per ISBN)
        public void Delete_Buch()
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "DELETE FROM [dbo].[t_s_buecher] WHERE buch_isbn = @isbn";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.ExecuteNonQuery();
            con.Close();
            AutorListe.Delete();
        }
        #endregion

        private int CountRows(string isbnAktuell)
        {
            if (con.ConnectError()) return 0;
            string RawCommand = "SELECT COUNT(*) FROM t_s_buchid where bu_isbn = @isbn";
            int count = 0;
            using (SqlCommand cmdCount = new SqlCommand(RawCommand, con.Con))
            {
                cmdCount.Parameters.AddWithValue("@isbn", isbnAktuell);
                count = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            
            return count;

        }

        private void UpdateCount(string isbnAktuell)
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_buecher] set buch_anzahl = @anzahl where buch_isbn = @isbn";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@anzahl", CountRows(isbnAktuell));
            cmd.Parameters.AddWithValue("@isbn", isbnAktuell);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        #region DataSet + DataTable fuellen (Fill Object)
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject_All()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM t_s_buchid "
                + "left join t_s_buecher on bu_isbn = buch_isbn "
                + "left join t_s_genre on buch_genre_id = ger_id "
                + "left join t_s_autor on buch_autor_id = au_id "
                + "left join t_s_verlag on buch_verlag_id = ver_id "
                + "left join t_s_sprache on buch_sprache_id = sprach_id "
                + "left join t_s_zustand on bu_zustandsid = zu_id "
                + "left join t_bd_ausgeliehen on aus_buchid = bu_id "
                + "left join t_s_kunden on kunde_ID = aus_kundenid";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            con.Close();
        }
       
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable();
        SqlCommandBuilder comb2 = new SqlCommandBuilder();
        SQL_Verbindung con2 = new SQL_Verbindung();
        private void FillObjectBuch()
        {
            dt2.Clear();
            if (con2.ConnectError()) return;
            string RawCommand = "SELECT buch_isbn as 'ISBN',"
                + "buch_titel as 'Titel',"
                + "ger_name as 'Genre',"
                + "a_id as 'AutorlisteID',"
                + "ver_name as 'Verlag',"
                + "buch_erscheinungsdatum as 'Erscheinungsdatum',"
                + "sprach_name as 'Sprache',"
                + "buch_auflage as 'Auflage',"
                + "buch_neupreis as 'Neupreis', "
                + "buch_bild as 'Bild', "
                + "buch_anzahl as 'Anzahl Exemplare' from t_s_buecher "
                + "left join t_s_genre on buch_genre_id = ger_id "
                + "left join t_s_autorListe on buch_autor_id = a_id "
                + "left join t_s_verlag on buch_verlag_id = ver_id "
                + "left join t_s_sprache on buch_sprache_id = sprach_id";
            adapter = new SqlDataAdapter(RawCommand, con2.Con);
            adapter.Fill(ds2);
            adapter.Fill(dt2);
            if (ds2.Tables[0].Columns.Contains("Autor"))
            {
                ds2.Tables[0].Columns.RemoveAt(ds2.Tables[0].Columns.IndexOf("Autor"));
            }
            ds2.Tables[0].Columns.Add("Autor", typeof(System.String));
            foreach (DataRow row in ds2.Tables[0].Rows)
            {
                string text = "";
                foreach(string s in AutorListe.GetNames(row["AutorlisteID"].ToString()))
                {
                    if(s != null && !s.Equals(""))
                    {
                        text = text + s + ", ";
                    }
                }
                if (text.Length > 2)
                {
                    text = text.Substring(0, text.Length -2);
                }
                row["Autor"] = text;
            }
            ds2.Tables[0].Columns["Autor"].SetOrdinal(3);
            
            con2.Close();
        }
        #endregion
        #region DataSet zuruecksetzen
        private void ClearDSBuch()
        {
            ds.Tables[0].Rows.Clear();
            ds2.Tables[0].Rows.Clear();
        }
        #endregion

        #region DataGridView fuellen
        public void FillGrid_Buch(ref DataGridView grid, object value = null)
        {
            ClearDSBuch();
            FillObjectBuch();
            List<string> s = dt2.AsEnumerable().Select(x => x[0].ToString()).ToList();
            foreach(string e in s)
            {
                UpdateCount(e);
            }
            ClearDSBuch();
            FillObjectBuch();
            grid.DataSource = ds2.Tables[0];
            int i = ds2.Tables[0].Columns.IndexOf("AutorlisteID");
            grid.Columns[i].Visible = false;
        }

        public void FillGrid_Load_All(ref DataGridView grid, object value = null)
        {
            ClearDSBuch();
            FillObject_All();
            grid.DataSource = ds.Tables[0];
            grid.Columns[2].Visible = false;
            grid.Columns[4].Visible = false;
            grid.Columns[6].Visible = false;
            grid.Columns[7].Visible = false;
            grid.Columns[8].Visible = false;
            grid.Columns[10].Visible = false;
            grid.Columns[13].Visible = false;
            grid.Columns[15].Visible = false;
            grid.Columns[17].Visible = false;
            grid.Columns[19].Visible = false;
            grid.Columns[21].Visible = false;
            grid.Columns[24].Visible = false;
            grid.Columns[27].Visible = false;
            grid.Columns[29].Visible = false;
            grid.Columns[32].Visible = false;
            grid.Columns[33].Visible = false;
            grid.Columns[34].Visible = false;
            grid.Columns[35].Visible = false;
            grid.Columns[37].Visible = false;
            grid.Columns[38].Visible = false;
            grid.Columns[39].Visible = false;

            grid.Columns["bu_id"].HeaderText = "Buch-ID:";
            grid.Columns["bu_isbn"].HeaderText = "Buch-ISBN:";
            grid.Columns["bu_aufnahmedatum"].HeaderText = "aufgenommen am:";
            grid.Columns["zu_zustand"].HeaderText = "Zustand:";
            grid.Columns["buch_titel"].HeaderText = "Titel:";
            grid.Columns["buch_erscheinungsdatum"].HeaderText = "erschienen am:";
            grid.Columns["buch_auflage"].HeaderText = "Auflage:";
            grid.Columns["buch_neupreis"].HeaderText = "Neupreis:";
            grid.Columns["ger_name"].HeaderText = "Genre:";
            grid.Columns["au_autor"].HeaderText = "Autor:";
            grid.Columns["ver_name"].HeaderText = "Verlag:";
            grid.Columns["sprach_name"].HeaderText = "Sprache:";
            grid.Columns["aus_leihnummer"].HeaderText = "Ausleihnummer:";
            grid.Columns["aus_leihdatum"].HeaderText = "ausgeliehen am:";
            grid.Columns["aus_rückgabedatum"].HeaderText = "Rückgabe am:";
            grid.Columns["aus_barcode"].HeaderText = "Barcode:";
            grid.Columns["kunde_vorname"].HeaderText = "Vorname:";
            grid.Columns["kunde_nachname"].HeaderText = "Nachname:";
            grid.Columns["kunde_vertrauenswürdigkeit"].HeaderText = "Vertrauenswürdigkeit:";
        }
        #endregion

        #region Buch ausleihen/zurueckgeben
        public bool Pruefe_Ausgeliehen(string buch_id)
        {
            bool ergebnis = false;
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT COUNT(*) FROM t_bd_ausgeliehen WHERE aus_buchid = @buch_id";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@buch_id", buch_id);

            int anzahl = Convert.ToInt16(cmd.ExecuteScalar());
 
            if (anzahl >= 1)
            {
                    ergebnis = true;
                }
                else
                {
                    ergebnis = false;
                }
            con.Close();
            return ergebnis;
        }

        public void Ausleihen(int buch_id, string aus_datum, string rueck_datum, int kunde, string barcode)
        {
            string RawCommand = "INSERT into [dbo].[t_bd_ausgeliehen] (aus_buchid, aus_leihdatum, aus_rückgabedatum, aus_kundenid, aus_barcode) VALUES(@buchid, @ausdatum, @rückdatum, @kunde, @barcode)";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@buchid", buch_id);
            cmd.Parameters.AddWithValue("@ausdatum", aus_datum);
            cmd.Parameters.AddWithValue("@rückdatum", rueck_datum);
            cmd.Parameters.AddWithValue("@kunde", kunde);
            cmd.Parameters.AddWithValue("@barcode", barcode);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Buch_Rueckgabe(string buch_id)
        {
            if (con.ConnectError()) return;
            string RawCommand = "DELETE FROM t_bd_ausgeliehen WHERE aus_buchid = @0";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", buch_id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
    }
}
