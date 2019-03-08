using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Bibo_Verwaltung
{
    class Kunde
    {
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region Kunden-Eigenschaften
        string kundenid;
        /// <summary>
        /// ID des Kunden
        /// </summary>
        public string KundenID { get { return kundenid; } set { kundenid = value; } }

        string vorname;
        /// <summary>
        /// Vorname des Kunden
        /// </summary>
        public string Vorname { get { return vorname; } set { vorname = value; } }

        string nachname;
        /// <summary>
        /// Nachname des Kunden
        /// </summary>
        public string Nachname { get { return nachname; } set { nachname = value; } }

        DateTime gd;
        /// <summary>
        /// Geburtsdatum des Kunden
        /// </summary>
        public DateTime Gd { get { return gd; } set { gd = value; } }

        string ort;
        /// <summary>
        /// Wohnort des Kunden
        /// </summary>
        public string Ort { get { return ort; } set { ort = value; } }

        string postleitzahl;
        /// <summary>
        /// Postleitzahl des Wohnorts des Kunden
        /// </summary>
        public string Postleitzahl { get { return postleitzahl; } set { postleitzahl = value; } }

        string strasse;
        /// <summary>
        /// Strasse auf der der Kunde wohnt
        /// </summary>
        public string Strasse { get { return strasse; } set { strasse = value; } }

        string telefonnummer;
        /// <summary>
        /// Telefonnummer des Kunden
        /// </summary>
        public string Telefonnummer { get { return telefonnummer; } set { telefonnummer = value; } }

        string hausnummer;
        /// <summary>
        /// Hausnummer des Kunden
        /// </summary>
        public string Hausnummer { get { return hausnummer; } set { hausnummer = value; } }

        string mail;
        /// <summary>
        /// E-Mail Adresse des Kunden
        /// </summary>
        public string Mail { get { return mail; } set { mail = value; } }

        string klassenstufe;
        /// <summary>
        /// Klasse des Kunden
        /// </summary>
        public string Klassenstufe { get { return klassenstufe; } set { klassenstufe = value; } }

        bool activated;
        /// <summary>
        /// Status des Kunden
        /// </summary>
        public bool Activated { get { return activated; } set { activated = value; } }
        #endregion

        #region Objekt-Constructor
        /// <summary>
        /// Erschaft das Objekt Kunde
        /// </summary>
        public Kunde()
        {
            FillObject();
        }

        /// <summary>
        /// Erschaft einen Kunden
        /// </summary>
        public Kunde(string kundenid)
        {
            this.kundenid = kundenid;
            LoadKunde();
            FillObject();
        }
        #endregion

        /// <summary>
        /// Lädt alle Kundendaten und speichert diese in das Kunden-Objekt
        /// </summary>
        private void LoadKunde()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_kunden] WHERE  kunde_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, kundenid);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                KundenID = dr["kunde_ID"].ToString();
                Vorname = dr["kunde_vorname"].ToString();
                Nachname = dr["kunde_nachname"].ToString();
                Gd = (DateTime)dr["kunde_geburtsdatum"];
                Ort = dr["kunde_ort"].ToString();
                Postleitzahl = dr["kunde_postleitzahl"].ToString();
                Strasse = dr["kunde_strasse"].ToString();
                Telefonnummer = dr["kunde_telefonnummer"].ToString();
                Hausnummer = dr["kunde_hausnummer"].ToString();
                Mail = dr["kunde_mail"].ToString();
                Klassenstufe = dr["kunde_klasse"].ToString();
                if (dr["kunde_activated"].ToString().Equals("1"))
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

        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Kundendaten 
        /// </summary>
        private void FillObject()
        {
            try
            {
                if (con.ConnectError()) return;
                string RawCommand = "SELECT kunde_ID as 'Kunden-ID', kunde_vorname as 'Vorname', kunde_nachname as 'Nachname', kunde_geburtsdatum as 'Geburtsdatum', kunde_strasse as 'Straße', kunde_hausnummer as 'Hausnummer', kunde_postleitzahl as 'Postleitzahl', kunde_ort as 'Wohnort', kunde_klasse as 'Klasse', kunde_mail as 'Mail', kunde_telefonnummer as 'Telefonnummer' FROM [dbo].[t_s_kunden] WHERE kunde_activated = 1";
                // Verbindung öffnen 
                adapter = new SqlDataAdapter(RawCommand, con.Con);
                adapter.Fill(ds);
                con.Close();
            }
            catch { }
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt im DataSet 
        /// </summary>
        private void ClearDataSource()
        {
            try
            {
                ds.Tables[0].Rows.Clear();
            }
            catch { }
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Kundendaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// Speichert den Inhalt eines DataGridView-Objekts in die Datenbank 
        /// </summary>
        public void SaveGrid(ref DataGridView grid)
        {
            comb = new SqlCommandBuilder(adapter);
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                adapter.Update(changes);
            }
        }
        /// <summary>
        /// Prüft, ob ein Kunde bereits existiert
        /// </summary>
        /// <returns></returns>
        public bool AlreadyExists()
        {
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM [dbo].[t_s_kunden] WHERE kunde_vorname = @0 and kunde_nachname = @1 and kunde_geburtsdatum = @2";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, Vorname, Nachname, Gd.Date);
            while (dr.Read())
            {
                KundenID = dr["kunde_id"].ToString();
            }
            dr.Close();
            con.Close();
            if (KundenID == null || KundenID == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// Fügt einen Kunden der Datenbank hinzu 
        /// </summary>
        public void AddKunde()
        {
            {
                string RawCommand = "INSERT INTO [dbo].[t_s_kunden] (kunde_vorname, kunde_nachname, kunde_geburtsdatum, kunde_ort, kunde_postleitzahl, kunde_strasse, kunde_telefonnummer, kunde_hausnummer, kunde_mail, kunde_klasse, kunde_activated) VALUES (@vorname, @nachname, @gd, @ort, @postleitzahl, @strasse, @telefonnummer, @hausnummer, @mail, @klasse, 1)";
                con.ConnectError();
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                cmd.Parameters.AddWithValue("@vorname", Vorname);
                cmd.Parameters.AddWithValue("@nachname", Nachname);
                cmd.Parameters.AddWithValue("@gd", Gd.Date);
                cmd.Parameters.AddWithValue("@ort", Ort);
                cmd.Parameters.AddWithValue("@postleitzahl", Postleitzahl);
                cmd.Parameters.AddWithValue("@strasse", Strasse);
                cmd.Parameters.AddWithValue("@telefonnummer", Telefonnummer);
                cmd.Parameters.AddWithValue("@hausnummer", Hausnummer);
                cmd.Parameters.AddWithValue("@mail", Mail);
                cmd.Parameters.AddWithValue("@klasse", Klassenstufe);
                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                //Verbindung schließen
                con.Close();
            }
        }

        /// <summary>
        /// Aktualisiert die Kundendaten eines vorhandenen Kunden in der Datenbank 
        /// </summary>
        public void UpdateKunde()
        {
            {
                string RawCommand = "UPDATE [dbo].[t_s_kunden] SET kunde_ort = @ort, kunde_postleitzahl = @postleitzahl, kunde_strasse = @strasse, kunde_telefonnummer = @telefonnummer, kunde_hausnummer = @hausnummer, kunde_mail = @mail, kunde_klasse = @klasse WHERE kunde_ID = @k_ID";
                con.ConnectError();
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                cmd.Parameters.AddWithValue("@ort", Ort);
                cmd.Parameters.AddWithValue("@postleitzahl", Postleitzahl);
                cmd.Parameters.AddWithValue("@strasse", Strasse);
                cmd.Parameters.AddWithValue("@telefonnummer", Telefonnummer);
                cmd.Parameters.AddWithValue("@hausnummer", Hausnummer);
                cmd.Parameters.AddWithValue("@mail", Mail);
                cmd.Parameters.AddWithValue("@klasse", Klassenstufe);
                cmd.Parameters.AddWithValue("@k_ID", KundenID);
                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                //Verbindung schließen
                con.Close();
            }
        }

        /// <summary>
        /// Deaktiviert einen Kunden in der Datenbank 
        /// </summary>
        public void Deactivate()
        {
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_kunden] set kunde_activated = 0 WHERE kunde_ID = @k_ID";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@k_ID", KundenID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Aktiviert einen Kunden in der Datenbank 
        /// </summary>
        public void Activate()
        {
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_kunden] set kunde_activated = 1 WHERE kunde_ID = @k_ID";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@k_ID", KundenID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Löscht einen Kunden aus der Datenbank 
        /// </summary>
        //public void DeleteKunde()
        //{
        //    {
        //        string RawCommand = "DELETE FROM [dbo].[t_s_kunden] WHERE kunde_id = @id";
        //        con.ConnectError();
        //        SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

        //        cmd.Parameters.AddWithValue("@id", KundenID);

        //        // Verbindung öffnen 
        //        cmd.ExecuteNonQuery();
        //        //Verbindung schließen
        //        con.Close();
        //    }
        //}
    }
}

