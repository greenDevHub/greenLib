using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Kunde
    {
        SQL_Verbindung con = new SQL_Verbindung();
        #region Strings
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

        string klasse;
        /// <summary>
        /// Klasse des Kunden
        /// </summary>
        public string Klasse { get { return klasse; } set { klasse = value; } }

        string vertrauenswuerdigkeit;
        /// <summary>
        /// Vertrauenswürdigkeit des Kunden
        /// </summary>
        public string Vertrauenswuerdigkeit { get { return vertrauenswuerdigkeit; } set { vertrauenswuerdigkeit = value; } }
        #endregion

        #region Objekt Kunde
        /// <summary>
        /// Erschaft das Objekt Kunde
        /// </summary>
        public Kunde()
        {
            FillObject1();
        }
        public Kunde(string kundenid)
        {
            this.kundenid = kundenid;
            Load();
            FillObject1();
        }
        #endregion

        #region Load
        private void Load()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_kunden] WHERE kunde_vorname = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, kundenid);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                KundenID = dr["kunde_ID"].ToString();
                Vorname = dr["kunde_vorname"].ToString();
                Nachname = dr["kunde_nachname"].ToString();
                Ort = dr["kunde_ort"].ToString();
                Postleitzahl = dr["kunde_postleitzahl"].ToString();
                Strasse = dr["kunde_strasse"].ToString();
                Telefonnummer = dr["kunde_telefonnummer"].ToString();
                Hausnummer = dr["kunde_hausnummer"].ToString();
                Mail = dr["kunde_mail"].ToString();
                Klasse = dr["kunde_klasse"].ToString();
                Vertrauenswuerdigkeit = dr["kunde_vertrauenswürdigkeit"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();

            if (con.ConnectError()) return;
            string RawCommand1 = "SELECT * FROM [dbo].[t_s_kunden] WHERE kunde_ID = @0";
            SqlDataReader dr1 = con.ExcecuteCommand(RawCommand1, kundenid);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr1.Read())
            {
                KundenID = dr1["kunde_ID"].ToString();
                Vorname = dr1["kunde_vorname"].ToString();
                Nachname = dr1["kunde_nachname"].ToString();
                Ort = dr1["kunde_ort"].ToString();
                Postleitzahl = dr1["kunde_postleitzahl"].ToString();
                Strasse = dr1["kunde_strasse"].ToString();
                Telefonnummer = dr1["kunde_telefonnummer"].ToString();
                Hausnummer = dr1["kunde_hausnummer"].ToString();
                Mail = dr1["kunde_mail"].ToString();
                Klasse = dr1["kunde_klasse"].ToString();
                Vertrauenswuerdigkeit = dr1["kunde_vertrauenswürdigkeit"].ToString();
            }
            // DataReader schließen 
            dr1.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion

        #region Add
        public void Add()
        {
            {
                string RawCommand = "INSERT INTO [dbo].[t_s_kunden] (kunde_vorname, kunde_nachname, kunde_ort, kunde_postleitzahl, kunde_strasse, kunde_telefonnummer, kunde_hausnummer, kunde_mail, kunde_klasse, kunde_vertrauenswürdigkeit) VALUES (@vorname, @nachname, @ort, @postleitzahl, @strasse, @telefonnummer, @hausnummer, @mail, @klasse, @vertrauenswürdigkeit)";
                con.ConnectError();
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

                cmd.Parameters.AddWithValue("@vorname", Vorname);
                cmd.Parameters.AddWithValue("@nachname", Nachname);
                cmd.Parameters.AddWithValue("@ort", Ort);
                cmd.Parameters.AddWithValue("@postleitzahl", Postleitzahl);
                cmd.Parameters.AddWithValue("@strasse", Strasse);
                cmd.Parameters.AddWithValue("@telefonnummer", Telefonnummer);
                cmd.Parameters.AddWithValue("@hausnummer", Hausnummer);
                cmd.Parameters.AddWithValue("@mail", Mail);
                cmd.Parameters.AddWithValue("@klasse", Klasse);
                cmd.Parameters.AddWithValue("@vertrauenswürdigkeit", Vertrauenswuerdigkeit);
                cmd.Parameters.AddWithValue("@k_ID", KundenID);

                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                //Verbindung schließen
                con.Close();
            }
        }
        #endregion

        #region Save
        public void Save()
        {
            {
                string RawCommand = "UPDATE [dbo].[t_s_kunden] SET kunde_vorname = @vorname, kunde_nachname = @nachname, kunde_ort = @ort, kunde_postleitzahl = @postleitzahl, kunde_strasse = @strasse, kunde_telefonnummer = @telefonnummer, kunde_hausnummer = @hausnummer, kunde_mail = @mail, kunde_klasse = @klasse, kunde_vertrauenswürdigkeit = @vertrauenswürdigkeit WHERE kunde_ID = @k_ID";
                con.ConnectError();
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

                cmd.Parameters.AddWithValue("@vorname", Vorname);
                cmd.Parameters.AddWithValue("@nachname", Nachname);
                cmd.Parameters.AddWithValue("@ort", Ort);
                cmd.Parameters.AddWithValue("@postleitzahl", Postleitzahl);
                cmd.Parameters.AddWithValue("@strasse", Strasse);
                cmd.Parameters.AddWithValue("@telefonnummer", Telefonnummer);
                cmd.Parameters.AddWithValue("@hausnummer", Hausnummer);
                cmd.Parameters.AddWithValue("@mail", Mail);
                cmd.Parameters.AddWithValue("@klasse", Klasse);
                cmd.Parameters.AddWithValue("@vertrauenswürdigkeit", Vertrauenswuerdigkeit);
                cmd.Parameters.AddWithValue("@k_ID", KundenID);

                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                //Verbindung schließen
                con.Close();
            }
        }
        #endregion

        #region Delete
        public void Delete()
        {
            {
                string RawCommand = "DELETE FROM [dbo].[t_s_kunden] WHERE kunde_vorname = @vorname AND kunde_nachname = @nachname";
                con.ConnectError();
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

                cmd.Parameters.AddWithValue("@vorname", Vorname);
                cmd.Parameters.AddWithValue("@nachname", Nachname);

                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                //Verbindung schließen
                con.Close();
            }
        }
        #endregion
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject1()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "select kunde_ID as 'ID', kunde_vorname as 'Vorname', kunde_nachname as 'Nachname', kunde_strasse as 'Straße', kunde_hausnummer as 'Hausnummer', kunde_postleitzahl as 'Postleitzahl', kunde_ort as 'Wohnort', kunde_vertrauenswürdigkeit as 'Vertrauenwürdigkeit', kunde_klasse as 'Klasse', kunde_mail as 'Mail', kunde_telefonnummer as 'Telefonnummer'"
            + "from t_s_kunden";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);

            con.Close();

        }
        public void FillGrid1(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
        }
    }
}

