using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Exemplar
    {
        SQL_Verbindung con = new SQL_Verbindung();

        #region Exemplar Eigenschaften
        string exemplarID;
        public string ExemplarID { get { return exemplarID; } set { exemplarID = value; } }

        string isbn;
        public string ISBN { get { return isbn; } set { isbn = value; } }

        string titel;
        public string Titel { get { return titel; } set { titel = value; } }

        Zustand zustand = new Zustand();
        public Zustand Zustand { get { return zustand; } set { zustand = value; } }

        DateTime aufnahmedatum;
        public DateTime Aufnahmedatum { get { return aufnahmedatum; } set { aufnahmedatum = value; } }

        bool activated;
        public bool Activated { get { return activated; } set { activated = value; } }

        bool printed;
        public bool Printed { get { return printed; }set { printed = value; } }
        #endregion

        #region Objekt-Constructor
        /// <summary>
        /// Erschaft das Objekt Exemplar
        /// </summary>
        public Exemplar()
        {
            //FillObject();
        }
        /// <summary>
        /// Erschaft ein Exemplar-Objekt
        /// </summary>
        public Exemplar(string ID)
        {
            this.exemplarID = ID;
            Load_ExemplarData();
            FillObject();
        }
        #endregion

        List<string> liste = new List<string>();
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        /// <summary>
        /// Lädt alle Buchexemplardaten und speichert diese in das Exemplar-Objekt
        /// </summary>
        private void Load_ExemplarData()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bu_id, bu_isbn, buch_titel, bu_zustandsid, isnull(bu_aufnahmedatum, '01.01.1990') as 'verified_aufnahmedatum', bu_activated, bu_printed from t_s_buchid left join t_s_zustand on bu_zustandsid = zu_id left join t_s_buecher on bu_isbn = buch_isbn where bu_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, exemplarID);
            liste.Clear();
            while (dr.Read())
            {
                ExemplarID = dr["bu_id"].ToString();
                ISBN = dr["bu_isbn"].ToString();
                Titel = dr["buch_titel"].ToString();
                Zustand = new Zustand(dr["bu_zustandsid"].ToString());
                Aufnahmedatum = (DateTime)dr["verified_aufnahmedatum"];
                if (dr["bu_activated"].ToString().Equals(0))
                {
                    Activated = false;
                }
                else
                {
                    Activated = true;
                }
                if (dr["bu_printed"].ToString().Equals(0))
                {
                    Printed = false;
                }
                else
                {
                    Printed = true;
                }
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Fügt ein Buchexemplar der Datenbank hinzu
        /// </summary>
        public void Add_Exemplar()
        {
            string RawCommand = "Insert INTO t_s_buchid (bu_isbn, bu_zustandsid, bu_aufnahmedatum, bu_activated,bu_printed) VALUES (@isbn, @zustandsid, @aufnahmedatum, @activated, @printed)";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.Parameters.AddWithValue("@zustandsid", Zustand.ZustandID);
            cmd.Parameters.AddWithValue("@aufnahmedatum", Aufnahmedatum);
            cmd.Parameters.AddWithValue("@activated", 1);
            cmd.Parameters.AddWithValue("@printed", 0);
            // Verbindung öffnen
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        /// <summary>
        /// Aktualisiert die Exemplardaten eines vorhandenen Exemplars in der Datenbank 
        /// </summary>
        public void Update_Exemplar()
        {
            string RawCommand = "UPDATE t_s_buchid set bu_zustandsid = @zustandsid, bu_aufnahmedatum = @datum WHERE bu_id = @id";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@zustandsid", Zustand.ZustandID);
            cmd.Parameters.AddWithValue("@datum", Aufnahmedatum);
            cmd.Parameters.AddWithValue("@id", ExemplarID);
            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }

        /// <summary>
        /// Löscht ein Exemplar aus der Datenbank 
        /// </summary>
        public void Delete_Exemplar()
        {
            string RawCommand = "DELETE FROM [dbo].[t_s_buchid] WHERE bu_id = @id";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@id", ExemplarID);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Löscht alle Exemplare einer ISBN aus der Datenbank 
        /// </summary>
        public void Delete_Exemplare_WhereISBN(string isbn)
        {
            string RawCommand = "DELETE FROM [dbo].[t_s_buchid] WHERE bu_isbn = @isbn";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Deaktiviert ein Exemplar in der Datenbank 
        /// </summary>
        public void Deactivate_Exemplar()
        {
            string RawCommand = "UPDATE t_s_buchid set bu_activated = @activated WHERE bu_id = @id";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@activated", 0);
            cmd.Parameters.AddWithValue("@id", ExemplarID);
            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
            Activated = false;
        }

        /// <summary>
        /// Deaktiviert alle Exemplare einer ISBN in der Datenbank 
        /// </summary>
        public void DeactivateWhereISBN(string isbn)
        {
            string RawCommand = "UPDATE t_s_buchid set bu_activated = @activated WHERE bu_isbn = @isbn";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@activated", 0);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
            Activated = false;
        }

        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Exemplardaten 
        /// </summary>      
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bu_id as Exemplar, bu_isbn as ISBN, buch_titel as Titel, bu_aufnahmedatum as Aufnahmedatum, zu_zustand as Zustand from t_s_buchid left join t_s_zustand on bu_zustandsid = zu_id left join t_s_buecher on bu_isbn = buch_isbn where bu_isbn = @isbn AND bu_activated = 1";
            //string RawCommand = "SELECT bu_id as 'BuchID', buch_isbn as 'ISBN', buch_titel as 'Titel', zu_zustand 'Zustand', zu_verleihfähig as 'Verleihbar', bu_aufnahmedatum as 'Aufnahmedatum' from t_s_buchid left join t_s_zustand on bu_zustand_id left join t_s_buecher on bu_isbn = buch_isbn";
            adapter2 = new SqlDataAdapter(RawCommand, con.Con);
            if (ISBN == null)
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["w_s_buecher"];
                ISBN = ((w_s_buecher)f).tb_ISBN.Text;
            }
            adapter2.SelectCommand.Parameters.AddWithValue("@isbn", ISBN);
            adapter2.Fill(ds);
            con.Close();
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Exemplardaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt im DataSet 
        /// </summary>
        private void ClearDataSource()
        {
            try
            {
                //ds.Clear();
                ds.Tables[0].Rows.Clear();
            }
            catch
            {

            }
        }

        /// <summary>
        /// Lädt die Exemplar ID anhand der ISBN 
        /// </summary>
        public string GetID(string isbn)
        {
            string id = "";
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT bu_id from t_s_buchid where bu_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            while (dr.Read())
            {
                id = dr["bu_id"].ToString();
            }
            dr.Close();
            con.Close();
            return id;
        }

        /// <summary>
        /// Lädt die Exemplar Titel anhand der ID 
        /// </summary>
        public string GetTitel(string exemplarID)
        {
            string titel = "";
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT buch_titel as 'Titel' FROM t_s_buchid left join t_s_buecher on bu_isbn = buch_isbn WHERE bu_id = @0 GROUP BY buch_titel ";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, exemplarID);
            while (dr.Read())
            {
                titel = dr["Titel"].ToString();
            }
            dr.Close();
            con.Close();
            return titel;
        }

        /// <summary>
        /// Prüft ein Buchexemplar auf seine Aktivierung für Kunden
        /// </summary>
        public bool IsActivated()
        {
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT bu_activated FROM t_s_buchid where bu_id = @0";
            string activated = "";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, exemplarID);
            while (dr.Read())
            {
                activated = dr["bu_activated"].ToString();
            }
            dr.Close();
            con.Close();
            if (activated.Equals("True"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Prüft ein Buchexemplar auf seine Verfügbarkeit für Kunden
        /// </summary>
        public bool IsSpecificAvailable()
        {
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT COUNT(*) FROM t_bd_ausgeliehen where aus_buchid = @buchid";
            int count = 0;
            using (SqlCommand cmdCount = new SqlCommand(RawCommand, con.Con))
            {
                cmdCount.Parameters.AddWithValue("@buchid", ExemplarID);
                count = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            if (count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Lädt eine Liste von Buchexemplaren einer ISBN
        /// </summary>
        private void Load_ExemplarIDs(string isbn)
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bu_id from t_s_buchid where bu_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            liste.Clear();
            while (dr.Read())
            {
                ExemplarID = dr["bu_id"].ToString();
                liste.Add(ExemplarID);
            }
            dr.Close();
            con.Close();
        }

        public void SelectLastRow(string isbn)
        {
            if (con.ConnectError()) return;
            string RawCommand = "Select bu_id from t_s_buchid where bu_isbn = @0 and bu_id=(select max(bu_id) from t_s_buchid)";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            while (dr.Read())
            {
                ExemplarID = dr["bu_id"].ToString();
            }
            dr.Close();
            con.Close();
        }
        /// <summary>
        /// Prüft ein Buchexemplar auf seinen Verleihstatus
        /// </summary>
        public bool IsAvailable(string isbn)
        {
            Load_ExemplarIDs(isbn);
            if (con.ConnectError()) return false;
            List<int> counts = new List<int>();
            foreach (string s in liste)
            {
                string RawCommand = "SELECT COUNT(*) FROM t_bd_ausgeliehen where aus_buchid = @buchid";
                int count = 0;
                using (SqlCommand cmdCount = new SqlCommand(RawCommand, con.Con))
                {
                    cmdCount.Parameters.AddWithValue("@buchid", s);
                    count = (int)cmdCount.ExecuteScalar();
                    counts.Add(count);
                }
            }
            con.Close();
            int sum = 0;
            foreach (int i in counts)
            {
                sum = sum + i;
            }
            if (sum == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Legt den Printed-Bool auf true fest 
        /// </summary>
        public void Print(string id)
        {
            string RawCommand = "UPDATE t_s_buchid set bu_printed = @printed WHERE bu_id = @id";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@printed", 1);
            cmd.Parameters.AddWithValue("@id", id);
            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
            printed = true;
        }
        public int PrintedCount(string isbn)
        {
            if (con.ConnectError()) return 0;
            string RawCommand = "SELECT COUNT(*) FROM t_s_buchid where bu_isbn = @isbn and bu_printed = 1";
            int count = 0;
            using (SqlCommand cmdCount = new SqlCommand(RawCommand, con.Con))
            {
                cmdCount.Parameters.AddWithValue("@isbn", isbn);
                count = (int)cmdCount.ExecuteScalar();
                con.Close();
            }
            return count;
        }

        public List<string>UnprintedList(string isbn)
        {
            List<string> unprintedList = new List<string>();
            unprintedList.Clear();
            if (con.ConnectError()) return unprintedList;
            string RawCommand = "SELECT bu_id FROM t_s_buchid where bu_isbn = @0 and bu_printed = 0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbn);
            while (dr.Read())
            {
                unprintedList.Add(dr["bu_id"].ToString());
            }
            dr.Close();
            con.Close();
            return unprintedList;
        }
    }
}
