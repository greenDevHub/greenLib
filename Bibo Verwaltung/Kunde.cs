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

        Klasse klasse = new Klasse();
        /// <summary>
        /// Klasse des Kunden
        /// </summary>
        public Klasse Klasse { get { return klasse; } set { klasse = value; } }

        int leistungskurse;
        /// <summary>
        /// Anzahl Leistungskurse (max 2)
        /// </summary>
        public int Leistungskurse { get { return leistungskurse; } set { leistungskurse = value; } }
        List<string> leistungskursListe = new List<string>();
        public List<string> LeistungskursListe { get { return leistungskursListe; } set { leistungskursListe = value; } }

        Fach fach = new Fach();
        /// <summary>
        /// Fach
        /// </summary>
        public Fach Fach { get { return fach; } set { fach = value; } }
        List<string> faecher = new List<string>();
        public List<string> Faecher { get { return faecher; } set { faecher = value; } }

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
            FillObjectNeu();
        }

        /// <summary>
        /// Erschaft einen Kunden
        /// </summary>
        public Kunde(string kundenid)
        {
            this.kundenid = kundenid;
            LoadKunde();
            LoadFaecherNeu();
            FillObjectNeu();
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
                Klasse.Klassename = Klasse.GetName(dr["kunde_klasse"].ToString());
                if (dr["kunde_activated"].ToString().Equals("1"))
                {
                    Activated = true;
                }
                else
                {
                    Activated = false;
                }
            }
            dr.Close();
            con.Close();
        }

        private void LoadFaecherNeu()
        {
            Faecher.Clear();
            LeistungskursListe.Clear();
            if (con.ConnectError()) return;
            string RawCommand = "use greenLib Select f_kurzform from t_s_fach_kunde left join t_s_faecher on f_id = fs_fachid WHERE fs_kundenid = @0 and fs_lk = 1";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, KundenID);
            while (dr.Read())
            {
                LeistungskursListe.Add(dr["f_kurzform"].ToString());
            }
            dr.Close();
            RawCommand = "use greenLib Select f_kurzform from t_s_fach_kunde left join t_s_faecher on f_id = fs_fachid WHERE fs_kundenid = @0";
            dr = con.ExcecuteCommand(RawCommand, KundenID);
            while (dr.Read())
            {
                Faecher.Add(dr["f_kurzform"].ToString());
            }
            for (int i = LeistungskursListe.Count; i < 2; i++)
            {
                LeistungskursListe.Add("");
            }
            dr.Close();
            con.Close();

        }
        private void LoadFaecher()
        {
            Faecher.Clear();
            LeistungskursListe.Clear();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_fach_kunde] WHERE  fs_kundenid = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, KundenID);
            while (dr.Read())
            {
                Fach = new Fach(dr["fs_fachid"].ToString());
                Faecher.Add(Fach.FachKurz);
                if (dr["fs_lk"].ToString() == "True")
                {
                    LeistungskursListe.Add(Fach.FachKurz);
                }
            }
            for (int i = LeistungskursListe.Count; i < 2; i++)
            {
                LeistungskursListe.Add("");
            }
            dr.Close();
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
                string RawCommand = "SELECT kunde_ID as 'Kunden-ID', kunde_vorname as 'Vorname', kunde_nachname as 'Nachname', kunde_geburtsdatum as 'Geburtsdatum', kunde_strasse as 'Straße', kunde_hausnummer as 'Hausnummer', kunde_postleitzahl as 'Postleitzahl', kunde_ort as 'Wohnort', k_bezeichnung as 'Klasse', kunde_mail as 'Mail', kunde_telefonnummer as 'Telefonnummer' FROM [dbo].[t_s_kunden] left join t_s_klassen on k_id=kunde_klasse WHERE kunde_activated = 1";
                // Verbindung öffnen 
                adapter = new SqlDataAdapter(RawCommand, con.Con);
                adapter.Fill(ds);
                con.Close();
            }
            catch { }
        }

        private void FillObjectNeu()
        {
            try
            {
                if (con.ConnectError()) return;
                string RawCommand = "use greenLib SELECT kunde_ID as 'Kunden-ID', kunde_vorname as 'Vorname', kunde_nachname as 'Nachname', kunde_geburtsdatum as 'Geburtsdatum', kunde_strasse as 'Straße', kunde_hausnummer as 'Hausnummer', kunde_postleitzahl as 'Postleitzahl', kunde_ort as 'Wohnort', k_bezeichnung as 'Klasse', kunde_mail as 'Mail', kunde_telefonnummer as 'Telefonnummer', stuff(( SELECT distinct ', '+ cast(f_kurzform as varchar(10)) FROM t_s_fach_kunde left join t_s_faecher on f_id = fs_fachid where fs_kundenid = kunde_id and fs_lk=1 FOR XML PATH('')),1,1,'') + ',' + stuff(( SELECT distinct ', '+ cast(f_kurzform as varchar(10)) FROM t_s_fach_kunde left join t_s_faecher on f_id = fs_fachid where fs_kundenid = kunde_id and fs_lk=0 FOR XML PATH('')),1,1,'') as 'Fächer' FROM [dbo].[t_s_kunden] left join t_s_klassen on k_id=kunde_klasse WHERE kunde_activated = 1";
                adapter = new SqlDataAdapter(RawCommand, con.Con);
                adapter.Fill(ds);
                con.Close();
            }
            catch
            {

            }
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
            FillObjectNeu();
            //FillObject();
            //DataTable dt = new DataTable();
            //dt.Columns.Add("Kunden-ID");
            //dt.Columns.Add("Vorname");
            //dt.Columns.Add("Nachname");
            //dt.Columns.Add("Geburtsdatum");
            //dt.Columns.Add("Straße");
            //dt.Columns.Add("Hausnummer");
            //dt.Columns.Add("Postleitzahl");
            //dt.Columns.Add("Wohnort");
            //dt.Columns.Add("Klasse");
            //dt.Columns.Add("Mail");
            //dt.Columns.Add("Telefonnummer");
            //dt.Columns.Add("Fächer");

            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    KundenID = row[ds.Tables[0].Columns.IndexOf("Kunden-ID")].ToString();
            //    Vorname = row[ds.Tables[0].Columns.IndexOf("Vorname")].ToString();
            //    Nachname = row[ds.Tables[0].Columns.IndexOf("Nachname")].ToString();
            //    Gd = (DateTime)row[ds.Tables[0].Columns.IndexOf("Geburtsdatum")];
            //    Strasse = row[ds.Tables[0].Columns.IndexOf("Straße")].ToString();
            //    Hausnummer = row[ds.Tables[0].Columns.IndexOf("Hausnummer")].ToString();
            //    Postleitzahl = row[ds.Tables[0].Columns.IndexOf("Postleitzahl")].ToString();
            //    Ort = row[ds.Tables[0].Columns.IndexOf("Wohnort")].ToString();
            //    Klasse.Klassename = row[ds.Tables[0].Columns.IndexOf("Klasse")].ToString();
            //    Mail = row[ds.Tables[0].Columns.IndexOf("Mail")].ToString();
            //    Telefonnummer = row[ds.Tables[0].Columns.IndexOf("Telefonnummer")].ToString();
            //    LoadFaecher();
            //    DataRow dataRow = dt.NewRow();
            //    dataRow["Kunden-ID"] = KundenID;
            //    dataRow["Vorname"] = Vorname;
            //    dataRow["Nachname"] = Nachname;
            //    dataRow["Geburtsdatum"] = Gd.ToShortDateString();
            //    dataRow["Straße"] = Strasse;
            //    dataRow["Hausnummer"] = Hausnummer;
            //    dataRow["Postleitzahl"] = Postleitzahl;
            //    dataRow["Wohnort"] = Ort;
            //    dataRow["Klasse"] = Klasse.Klassename;
            //    dataRow["Mail"] = Mail;
            //    dataRow["Telefonnummer"] = Telefonnummer;
            //    string fach = "";
            //    foreach (string s in Faecher)
            //    {
            //        fach = fach + s + ", ";
            //    }
            //    try
            //    {
            //        if (fach.Length >= 2)
            //        {
            //            fach = fach.Substring(0, fach.Length - 2);
            //        }
            //    }
            //    catch
            //    {
            //        fach = "";
            //    }
            //    dataRow["Fächer"] = fach;
            //    dt.Rows.Add(dataRow);
            //}
            //grid.DataSource = dt;
            grid.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// Prüft, ob ein Kunde bereits existiert
        /// </summary>
        public bool AlreadyExists(bool edit)
        {
            string newID = "";
            if (!edit)
            {
                KundenID = "";
            }
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM [dbo].[t_s_kunden] WHERE kunde_vorname = @0 and kunde_nachname = @1 and kunde_geburtsdatum = @2";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, Vorname, Nachname, Gd.Date);
            while (dr.Read())
            {
                newID = dr["kunde_id"].ToString();
            }
            dr.Close();
            con.Close();
            if (newID == null || newID == "")
            {
                KundenID = newID;
                return false;
            }
            else if(edit && newID == KundenID)
            {
                return false;
            }
            else
            {
                KundenID = newID;
                return true;
            }
        }
        /// <summary>
        /// Prüft, ob ein Kunde bereits existiert
        /// </summary>
        public bool IsActivated()
        {
            Activated = false;
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM [dbo].[t_s_kunden] WHERE kunde_ID = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, KundenID);
            while (dr.Read())
            {
                if (dr["kunde_activated"].ToString().Equals("True"))
                {
                    Activated = true;
                }
                else
                {
                    Activated = false;
                }
            }
            dr.Close();
            con.Close();
            return Activated;
        }
        /// <summary>
        /// Lädt die KundenID
        /// </summary>
        public void GetKundenID()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT kunde_id FROM [dbo].[t_s_kunden] WHERE kunde_vorname = @0 and kunde_nachname = @1 and kunde_geburtsdatum = @2";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, Vorname, Nachname, Gd.Date);
            while (dr.Read())
            {
                KundenID = dr["kunde_id"].ToString();
            }
        }

        /// <summary>
        /// Fügt einen Kunden der Datenbank hinzu 
        /// </summary>
        public void AddKunde()
        {

            {
                if (!Klasse.Klassename.Equals(""))
                {
                    Klasse.AddKlasse(Klasse.Klassename);
                }
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
                if (!Klasse.Klassename.Equals(""))
                {
                    cmd.Parameters.AddWithValue("@klasse", Klasse.GetID(Klasse.Klassename));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@klasse", DBNull.Value);
                }
                
                cmd.ExecuteNonQuery();
                GetKundenID();
                AddFaecherToKunde();
                con.Close();
            }
        }

        /// <summary>
        /// Fügt die Fachzuweisung hinzu
        /// </summary>
        private void AddFaecherToKunde()
        {
            con.ConnectError();
            string RawCommand = "INSERT INTO [dbo].[t_s_fach_kunde] (fs_kundenid, fs_fachid, fs_lk) VALUES (@schuelerid, @fachid, @lk)";
            foreach (string s in Faecher)
            {
                Fach.FachKurz = s;
                Fach.FachLang = "";
                if (!Fach.FachExists())
                {
                    Fach.AddFach();
                }
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                cmd.Parameters.AddWithValue("@schuelerid", KundenID);
                cmd.Parameters.AddWithValue("@fachid", Fach.GetIDByShortform(s));
                if (leistungskursListe[0] == s || leistungskursListe[1] == s)
                {
                    cmd.Parameters.AddWithValue("@lk", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@lk", false);
                }
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Aktualisiert die Kundendaten eines vorhandenen Kunden in der Datenbank 
        /// </summary>
        public void UpdateKunde()
        {
            {
                if (!Klasse.Klassename.Equals(""))
                {
                    Klasse.AddKlasse(Klasse.Klassename);
                }
                string RawCommand = "UPDATE [dbo].[t_s_kunden] SET kunde_vorname = @vorname, kunde_nachname = @nachname, kunde_geburtsdatum = @gd, kunde_ort = @ort, kunde_postleitzahl = @postleitzahl, kunde_strasse = @strasse, kunde_telefonnummer = @telefonnummer, kunde_hausnummer = @hausnummer, kunde_mail = @mail, kunde_klasse = @klasse WHERE kunde_ID = @k_ID";
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
                if (!Klasse.Klassename.Equals(""))
                {
                    cmd.Parameters.AddWithValue("@klasse", Klasse.GetID(Klasse.Klassename));
                }
                else
                {
                    cmd.Parameters.AddWithValue("@klasse", DBNull.Value);

                }
                cmd.Parameters.AddWithValue("@k_ID", KundenID);
                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                DeleteFaecherFromKunde();
                AddFaecherToKunde();
                //Verbindung schließen
                con.Close();
            }
        }

        /// <summary>
        /// Deaktiviert einen Kunden in der Datenbank 
        /// </summary>
        public void DeactivateKunde()
        {
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_kunden] set kunde_activated = 0 WHERE kunde_ID = @k_ID";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@k_ID", KundenID);
            DeleteFaecherFromKunde();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Löscht die zugewiesenen Fächer
        /// </summary>
        private void DeleteFaecherFromKunde()
        {
            string RawCommand = "DELETE FROM [dbo].[t_s_fach_kunde] WHERE fs_kundenid = @id";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@id", KundenID);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Aktiviert einen Kunden in der Datenbank 
        /// </summary>
        public void ActivateKunde()
        {
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_kunden] set kunde_activated = 1 WHERE kunde_ID = @k_ID";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@k_ID", KundenID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void DeactivateAllSchueler()
        {
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE t_s_kunden set kunde_activated = 0, kunde_klasse = null from t_s_kunden left join t_bd_ausgeliehen on kunde_ID=aus_kundenid WHERE kunde_klasse !='' and aus_leihnummer is NULL";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            DeleteFaecherFromKunde();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Prüft ob ein Kunde etwas ausgeliehen hat 
        /// </summary>
        public bool Ausgeliehen()
        {
            string anzahl = "";
            if (con.ConnectError()) return true;
            string RawCommand = "SELECT Count(aus_leihnummer) as 'Anzahl' from t_bd_ausgeliehen WHERE aus_kundenid = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, KundenID);
            while (dr.Read())
            {
                anzahl = dr["Anzahl"].ToString();
            }
            dr.Close();
            con.Close();
            if (anzahl == "0" || anzahl == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Gibt ein DataTable-Objekt mit den ausgeliehen Büchern der Kunden zurück 
        /// </summary>
        public DataTable GetAusgeliehen(string KID)
        {
            KundenID = KID;
            DataTable result = new DataTable();
            if (con.ConnectError()) return result;
            string RawCommand = "SELECT aus_buchid as 'ID', buch_isbn as 'ISBN', aus_leihdatum as 'Leihdatum', aus_rückgabedatum as 'Rückgabedatum' FROM t_bd_ausgeliehen left join t_s_buchid on bu_id = aus_buchid left join t_s_buecher on buch_isbn = bu_isbn WHERE aus_kundenid = @0";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", KID);
            adapter.Fill(result);
            con.Close();
            return result;
        }

        /// <summary>
        /// Gibt ein DataTable-Objekt mit den ausgeliehen Schul-Büchern der Kunden zurück 
        /// </summary>
        public DataTable GetSchulbuchAusgeliehen(string KID)
        {
            KundenID = KID;
            DataTable result = new DataTable();
            if (con.ConnectError()) return result;
            string RawCommand = "SELECT aus_buchid as 'ID', f_kurzform as 'Fach', buch_isbn as 'ISBN', aus_leihdatum as 'Leihdatum', aus_rückgabedatum as 'Rückgabedatum' FROM t_bd_ausgeliehen left join t_s_buchid on bu_id = aus_buchid left join t_s_buecher on buch_isbn = bu_isbn left join t_s_buch_fach on bf_isbn = buch_isbn left join t_s_faecher on f_id = bf_fachid WHERE aus_kundenid = @0 AND buch_isbn IN (SELECT bf_isbn FROM t_s_buch_fach)";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", KID);
            adapter.Fill(result);
            con.Close();
            return result;
        }

        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Kundendaten 
        /// </summary>
        private void FillKundenListe(bool showKlasse, int klasse)
        {
            try
            {
                if (!ds.Tables.Contains("KundenListe"))
                {
                    ds.Tables.Add("KundenListe");
                }
                ds.Tables["KundenListe"].Rows.Clear();
                if (con.ConnectError()) return;
                if (!showKlasse)
                {
                    //nach klasse selektieren
                    string RawCommand = "SELECT kunde_ID, kunde_vorname as 'Vorname', kunde_nachname as 'Nachname', kunde_klasse, k_bezeichnung as 'Klasse', ks_klassenstufe as 'Klassenstufe' FROM [dbo].[t_s_kunden] left join [dbo].[t_s_klassen] on k_id = kunde_klasse left join [dbo].[t_s_klasse_stufe] on ks_klasse = kunde_klasse WHERE kunde_activated = 1 AND kunde_klasse = @klasse order by Klasse";
                    adapter = new SqlDataAdapter(RawCommand, con.Con);
                    adapter.SelectCommand.Parameters.AddWithValue("@klasse", klasse);
                    adapter.Fill(ds.Tables["KundenListe"]);
                }
                else
                {
                    string RawCommand = "SELECT kunde_ID, kunde_vorname as 'Vorname', kunde_nachname as 'Nachname', kunde_klasse, k_bezeichnung as 'Klasse', ks_klassenstufe as 'Klassenstufe' FROM [dbo].[t_s_kunden] left join [dbo].[t_s_klassen] on k_id = kunde_klasse left join [dbo].[t_s_klasse_stufe] on ks_klasse = kunde_klasse WHERE kunde_activated = 1 AND ks_klassenstufe = @klasse";
                    adapter = new SqlDataAdapter(RawCommand, con.Con);
                    adapter.SelectCommand.Parameters.AddWithValue("@klasse", klasse);
                    adapter.Fill(ds.Tables["KundenListe"]);
                }
                con.Close();
            }
            catch { }
        }

        public void GetKundenList(ref MetroGrid grid, bool showKlasse, int klasse, object value = null)
        {
            FillKundenListe(showKlasse, klasse);
            grid.DataSource = ds.Tables["KundenListe"];
            grid.Columns["kunde_ID"].Visible = false;
            grid.Columns["kunde_klasse"].Visible = false;
            grid.Columns["Klassenstufe"].Visible = false;
            grid.Columns["Vorname"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grid.Columns["Nachname"].SortMode = DataGridViewColumnSortMode.NotSortable;
            if (!showKlasse)
            {
                grid.Columns["Klasse"].Visible = false;
            }
            else
            {
                grid.Columns["Klasse"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        /// <summary>
        /// Gibt ein DataTable-Objekt mit den ausgeliehen Büchern der Kunden zurück 
        /// </summary>
        public List<string> BorrowedBooks(string KID)
        {
            KundenID = KID;
            List<string> borrowedBooks = new List<string>();
            DataTable result = new DataTable();
            if (con.ConnectError()) return borrowedBooks;
            string RawCommand = "SELECT aus_buchid as 'ID', buch_isbn as 'ISBN' FROM t_bd_ausgeliehen left join t_s_buchid on bu_id = aus_buchid left join t_s_buecher on buch_isbn = bu_isbn WHERE aus_kundenid = @0";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", KID);
            adapter.Fill(result);
            con.Close();
            for(int i = 0; i < result.Rows.Count; i++)
            {
                string isbn = result.Rows[i][1].ToString();
                borrowedBooks.Add(isbn);
            }
            return borrowedBooks;
        }
    }
}

