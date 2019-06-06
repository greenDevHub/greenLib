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
using MetroFramework.Controls;
using MetroFramework;

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

        Autor autor = new Autor();
        /// <summary>
        /// Autor eines Buches
        /// </summary>
        public Autor Autor { get { return autor; } set { autor = value; } }

        List<string> autoren = new List<string>();
        public List<string> Autoren { get { return autoren; } set { autoren = value; } }

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

        bool activated;
        public bool Activated { get { return activated; } set { activated = value; } }

        #endregion

        #region Objekt Buch
        /// <summary>
        /// Erschaft das Objekt Buch
        /// </summary>
        public Buch()
        {
            FillObjectBuch();
        }

        public Buch(bool noauthor)
        {
            FillObjectBuchShort();
        }

        public Buch(string isbn, bool noauthor)
        {
            this.isbn = isbn;
            LoadShort();
            FillObjectBuchShort();
        }
        public Buch(string isbn)
        {
            this.isbn = isbn;
            LoadBuch();
            LoadAutoren();
        }
        #endregion

        #region Buch per ISBN laden
        public void Load_ID(string id)
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bu_isbn FROM [dbo].[t_s_buchid] WHERE bu_id = @0";
            string isbn = "";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            // Einlesen der Datenzeilen 
            while (dr.Read())
            {
                isbn = dr["bu_isbn"].ToString();
            }
            this.isbn = isbn;
            LoadBuch();
        }

        private void LoadShort()
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "SELECT buch_isbn, buch_titel FROM [dbo].[t_s_buecher] WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            // Einlesen der Datenzeilen 
            while (dr.Read())
            {
                ISBN = dr["buch_isbn"].ToString();
                Titel = dr["buch_titel"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        private void LoadBuch()
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "SELECT *, isnull(buch_erscheinungsdatum, '01.01.1990') as 'verified_erscheinungsdatum' FROM [dbo].[t_s_buecher] left join [dbo].[t_s_genre] on buch_genre_id = ger_id left join [dbo].[t_s_verlag] on buch_verlag_id = ver_id left join [dbo].[t_s_sprache] on buch_sprache_id = sprach_id WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            // Einlesen der Datenzeilen 
            while (dr.Read())
            {
                ISBN = dr["buch_isbn"].ToString();
                Titel = dr["buch_titel"].ToString();
                Genre = new Genre(dr["buch_genre_id"].ToString());
                Verlag = new Verlag(dr["buch_verlag_id"].ToString());
                Er_datum = (DateTime)dr["verified_erscheinungsdatum"];
                Sprache = new Sprache(dr["buch_sprache_id"].ToString());
                Auflage = dr["buch_auflage"].ToString();
                string price = dr["buch_neupreis"].ToString().Replace(".", ",");
                BildPfad = dr["buch_bild"].ToString();
                Anzahl = int.Parse(dr["buch_anzahl"].ToString());
                if (BildPfad != null && BildPfad != "" && File.Exists(BildPfad))
                {
                    BildDate = DateTime.Parse(File.GetCreationTimeUtc(BildPfad).ToShortTimeString());
                }
                if (dr["buch_imageDate"] != null && dr["buch_imageDate"].ToString() != "")
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
                if (dr["buch_activated"].ToString().Equals("1"))
                {
                    Activated = true;
                }
                else
                {
                    Activated = false;
                }
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        private void LoadAutoren()
        {
            Autoren.Clear();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_buch_autor] WHERE  ba_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, ISBN);
            while (dr.Read())
            {
                Autor autor = new Autor(dr["ba_autorid"].ToString());
                Autoren.Add(autor.Autorname);
            }
            dr.Close();
        }
        #endregion

        #region GetAutorlisteID
        //public string GetAutorID(string isbn)
        //{
        //    string id = "";
        //    if (con.ConnectError()) return "";
        //    string RawCommand = "SELECT buch_autor_id FROM [dbo].[t_s_buecher] WHERE buch_isbn = @0";
        //    SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
        //    while (dr.Read())
        //    {
        //        id = dr["buch_autor_id"].ToString();
        //    }
        //    return id;
        //}
        #endregion

        #region Buch-Eigenschaften aendern
        public void UpdateBuch()
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_buecher] set buch_titel = @titel , buch_genre_id = @genre, buch_sprache_id = @sprache, buch_verlag_id = @verlag, buch_auflage = @auflage, buch_erscheinungsdatum = @er_datum, buch_neupreis = @neupreis, buch_bild = @bild, buch_anzahl = @anzahl, buch_image = @image, buch_imageDate = @imageDate WHERE buch_isbn = @isbn";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@titel", Titel);
            cmd.Parameters.AddWithValue("@genre", Genre.GenreID);
            cmd.Parameters.AddWithValue("@sprache", Sprache.SpracheID);
            cmd.Parameters.AddWithValue("@verlag", Verlag.VerlagID);
            if (Auflage == null || Auflage.Equals(""))
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
            if (image == null)
            {
                cmd.Parameters["@image"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@image"].Value = Image;
            }
            cmd.Parameters.AddWithValue("@imageDate", imageDate);
            cmd.ExecuteNonQuery();
            DeleteAutoren();
            AddAutoren();
            con.Close();
        }

        private void AddAutoren()
        {
            con.ConnectError();
            string RawCommand = "INSERT INTO [dbo].[t_s_buch_autor] (ba_isbn, ba_autorid) VALUES (@isbn, @autor)";
            foreach (string s in Autoren)
            {
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                cmd.Parameters.AddWithValue("@isbn", ISBN);
                cmd.Parameters.AddWithValue("@autor", Autor.GetID(s));
                cmd.ExecuteNonQuery();
            }
        }
        private void DeleteAutoren()
        {
            string RawCommand = "DELETE FROM [dbo].[t_s_buch_autor] WHERE ba_isbn = @isbn";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region Buch hinzufuegen
        private void Add()
        {
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_buecher] (buch_isbn, buch_titel, buch_genre_id, buch_verlag_id, buch_erscheinungsdatum, buch_sprache_id, buch_auflage, buch_neupreis, buch_bild, buch_anzahl, buch_image, buch_imageDate, buch_activated) VALUES (@isbn, @titel, @genreid, @verlagid, @erscheinungsdatum, @sprachid, @auflage, @neupreis, @bild, @anzahl, @image, @imageDate, 1)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.Parameters.AddWithValue("@titel", Titel);
            cmd.Parameters.AddWithValue("@genreid", Genre.GenreID);
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
            cmd.Parameters.Add("@image", SqlDbType.VarBinary, -1);
            if (image == null)
            {
                cmd.Parameters["@image"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@image"].Value = Image;
            }
            cmd.Parameters.AddWithValue("@imageDate", ImageDate);


            cmd.ExecuteNonQuery();
            AddAutoren();
            con.Close();
        }
        public void Add_Buch()
        {
            if (IsActivated())
            {
                Activate();
                UpdateBuch();
            }
            else
            {
                Add();
            }
        }
        #endregion

        #region Buch loeschen (per ISBN)
        public void Delete_Buch()
        {
            //SQL-Verbindung pruefen
            DeleteAutoren();
            if (con.ConnectError()) return;
            string RawCommand = "DELETE FROM [dbo].[t_s_buecher] WHERE buch_isbn = @isbn";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Deactivate()
        {
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_buecher] set buch_activated = 0 WHERE buch_isbn = @isbn";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Activate()
        {
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_buecher] set buch_activated = 1 WHERE buch_isbn = @isbn";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region RowCount
        private int CountRows(string isbnAktuell)
        {
            if (con.ConnectError()) return 0;
            string RawCommand = "SELECT COUNT(*) FROM t_s_buchid where bu_isbn = @isbn AND bu_activated = 1";
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
        #endregion

        #region DataSet + DataTable fuellen (Fill Object)
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
                + "ver_name as 'Verlag',"
                + "buch_erscheinungsdatum as 'Erscheinungsdatum',"
                + "sprach_name as 'Sprache',"
                + "buch_auflage as 'Auflage',"
                + "buch_neupreis as 'Neupreis', "
                + "buch_bild as 'Bild', "
                + "buch_anzahl as 'Anzahl Exemplare' from t_s_buecher "
                + "left join t_s_genre on buch_genre_id = ger_id "
                + "left join t_s_verlag on buch_verlag_id = ver_id "
                + "left join t_s_sprache on buch_sprache_id = sprach_id WHERE buch_activated = 1";
            adapter2 = new SqlDataAdapter(RawCommand, con2.Con);
            adapter2.Fill(ds2);
            adapter2.Fill(dt2);
            //if (ds2.Tables[0].Columns.Contains("Autor"))
            //{
            //    ds2.Tables[0].Columns.RemoveAt(ds2.Tables[0].Columns.IndexOf("Autor"));
            //}
            //ds2.Tables[0].Columns.Add("Autor", typeof(System.String));
            //foreach (DataRow row in ds2.Tables[0].Rows)
            //{
            //    string text = "";
            //    foreach (string s in AutorListe.GetNames(row["AutorlisteID"].ToString()))
            //    {
            //        if (s != null && !s.Equals(""))
            //        {
            //            text = text + s + ", ";
            //        }
            //    }
            //    if (text.Length > 2)
            //    {
            //        text = text.Substring(0, text.Length - 2);
            //    }
            //    row["Autor"] = text;
            //}
            //ds2.Tables[0].Columns["Autor"].SetOrdinal(3);

            con2.Close();
        }

        private void FillObjectBuchShort()
        {
            dt2.Clear();
            if (con2.ConnectError()) return;
            string RawCommand = "SELECT buch_isbn as 'ISBN', buch_titel as 'Titel' from t_s_buecher WHERE buch_activated = 1";
            adapter2 = new SqlDataAdapter(RawCommand, con2.Con);
            adapter2.Fill(ds2);
            adapter2.Fill(dt2);
            con2.Close();
        }
        #endregion

        public string AutorNames()
        {
            string text = "";
            foreach (string s in Autoren)
            {
                if (s != null && !s.Equals(""))
                {
                    text = text + s + ", ";
                }
            }
            if (text.Length > 2)
            {
                text = text.Substring(0, text.Length - 2);
            }
            return text;
        }


        private void ClearDSBuch()
        {
            ds2.Tables[0].Rows.Clear();
        }


        #region DataGridView fuellen
        public void FillGrid_Buch(ref MetroGrid grid, object value = null)
        {
            ClearDSBuch();
            FillObjectBuch();
            DataTable dt = new DataTable();
            dt.Columns.Add("ISBN");
            dt.Columns.Add("Titel");
            dt.Columns.Add("Genre");
            dt.Columns.Add("Autor");
            dt.Columns.Add("Verlag");
            dt.Columns.Add("Erscheinungsdatum");
            dt.Columns.Add("Sprache");
            dt.Columns.Add("Auflage");
            dt.Columns.Add("Neupreis");
            dt.Columns.Add("Bild");
            dt.Columns.Add("Anzahl Exemplare");
            List<string> s = ds2.Tables[0].AsEnumerable().Select(x => x[0].ToString()).ToList();
            foreach (string e in s)
            {
                UpdateCount(e);
            }
            foreach(DataRow row in ds2.Tables[0].Rows)
            {
                ISBN = row[ds2.Tables[0].Columns.IndexOf("ISBN")].ToString();
                Titel = row[ds2.Tables[0].Columns.IndexOf("Titel")].ToString();
                Genre.Genrename = row[ds2.Tables[0].Columns.IndexOf("Genre")].ToString();
                Verlag.Verlagname = row[ds2.Tables[0].Columns.IndexOf("Verlag")].ToString();
                Er_datum = DateTime.Parse(row[ds2.Tables[0].Columns.IndexOf("Erscheinungsdatum")].ToString());
                Sprache.Sprachename = row[ds2.Tables[0].Columns.IndexOf("Sprache")].ToString();
                Auflage = row[ds2.Tables[0].Columns.IndexOf("Auflage")].ToString();
                Neupreis = decimal.Parse(row[ds2.Tables[0].Columns.IndexOf("Neupreis")].ToString());
                BildPfad = row[ds2.Tables[0].Columns.IndexOf("ISBN")].ToString();
                Anzahl = int.Parse(row[ds2.Tables[0].Columns.IndexOf("Anzahl Exemplare")].ToString());
                LoadAutoren();
                DataRow dataRow = dt.NewRow();
                dataRow["ISBN"] = ISBN;
                dataRow["Titel"] = Titel;
                dataRow["Genre"] = Genre.Genrename;
                dataRow["Verlag"] = Verlag.Verlagname;
                dataRow["Erscheinungsdatum"] = Er_datum.ToString("dd.MM.yyyy");
                dataRow["Sprache"] = Sprache.Sprachename;
                dataRow["Auflage"] = Auflage;
                dataRow["Neupreis"] = Neupreis;
                dataRow["Bild"] = BildPfad;
                dataRow["Anzahl Exemplare"] = Anzahl;
                string autor = "";
                foreach(string a in Autoren)
                {
                    autor = autor + a + ", ";
                }
                autor = autor.Substring(0, autor.Length - 2);
                dataRow["Autor"] = autor;
                dt.Rows.Add(dataRow);
                
            }
            //ClearDSBuch();
            //FillObjectBuch();
            grid.DataSource = dt;
            //grid.Columns[ds2.Tables[0].Columns.IndexOf("Autor")].DisplayIndex = 3;
            //grid.Columns[ds2.Tables[0].Columns.IndexOf("AutorlisteID")].Visible = false;
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Buchdaten 
        /// </summary>
        public void FillGrid_Short(ref MetroGrid grid, object value = null)
        {
            ClearDSBuch();
            FillObjectBuchShort();
            grid.DataSource = ds2.Tables[0];
        }
        #endregion

        #region Combobox
        public void FillCombobox(ref ComboBox cb, object value)
        {
            ClearDSBuch();
            FillObjectBuch();
            cb.DataSource = ds2.Tables[0];
            cb.ValueMember = "ISBN";
            cb.DisplayMember = "Titel";
            cb.SelectedValue = value;
        }
        #endregion

        private bool IsActivated()
        {
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT buch_activated FROM t_s_buecher where buch_isbn = @0";
            string activated = "";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, ISBN);
            while (dr.Read())
            {
                activated = dr["buch_activated"].ToString();
            }
            dr.Close();
            con.Close();
            if (activated.Equals("False"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
