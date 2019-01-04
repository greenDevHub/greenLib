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
    class Ausleihe
    {
        SQL_Verbindung con = new SQL_Verbindung();

        #region Buch Eigenschaften
        string kid;
        /// <summary>
        /// Kunden Nummer eines Buches
        /// </summary>
        public string KID { get { return kid; } set { kid = value; } }

        string exemplarID;
        /// <summary>
        /// Leihdatum eines Buches
        /// </summary>
        public string ExemplarID { get { return exemplarID; } set { exemplarID = value; } }

        DateTime rueckgabedatum;
        /// <summary>
        /// Rueckgabedatum eines Buches
        /// </summary>
        public DateTime Rueckgabedatum { get { return rueckgabedatum; } set { rueckgabedatum = value; } }
        #endregion

        #region Fill Object
        ////SqlDataAdapter adapter = new SqlDataAdapter();
        ////DataSet ds = new DataSet();
        ////DataTable dt = new DataTable();
        ////SqlCommandBuilder comb = new SqlCommandBuilder();
        ////private void FillObject()
        ////{
        ////    SQL_Verbindung con = new SQL_Verbindung();
        ////    if (con.ConnectError()) return;
        ////    string RawCommand = "SELECT bu_id as 'Buch-ID', bu_isbn as 'ISBN', buch_titel as 'Titel', "
        ////        + "zu_zustand as 'Zustand', bu_aufnahmedatum as 'Aufnahmedatum', "
        ////        + "ger_name as 'Genre', ver_name as 'Verlag', sprach_name as 'Sprache', a_id as 'AutorlisteID', aus_rückgabedatum as 'Rückgabedatum', aus_leihnummer as 'Leihnummer', "
        ////        + "kunde_id as 'Kunden ID', kunde_vorname as 'Vorname', kunde_Nachname as 'Nachname', kunde_klasse as 'Klasse' FROM t_s_buchid "
        ////        + "left join t_s_buecher on bu_isbn = buch_isbn "
        ////        + "left join t_s_genre on buch_genre_id = ger_id "
        ////        + "left join t_s_autorliste on buch_autor_id = a_id "
        ////        + "left join t_s_verlag on buch_verlag_id = ver_id "
        ////        + "left join t_s_sprache on buch_sprache_id = sprach_id "
        ////        + "left join t_s_zustand on bu_zustandsid = zu_id "
        ////        + "left join t_bd_ausgeliehen on aus_buchid = bu_id "
        ////        + "left join t_s_kunden on kunde_ID = aus_kundenid WHERE bu_activated = 1";

        ////    SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
        ////    adapter = new SqlDataAdapter(RawCommand, con.Con);
        ////    adapter.Fill(ds);
        ////    adapter.Fill(dt);
        ////    if (ds.Tables[0].Columns.Contains("Autor"))
        ////    {
        ////        ds.Tables[0].Columns.RemoveAt(ds.Tables[0].Columns.IndexOf("Autor"));
        ////    }
        ////    ds.Tables[0].Columns.Add("Autor", typeof(System.String));
        ////    foreach (DataRow row in ds.Tables[0].Rows)
        ////    {
        ////        string text = "";
        ////        AutorListe AutorListe = new AutorListe();
        ////        foreach (string s in AutorListe.GetNames(row["AutorlisteID"].ToString()))
        ////        {
        ////            if (s != null && !s.Equals(""))
        ////            {
        ////                text = text + s + ", ";
        ////            }
        ////        }
        ////        if (text.Length > 2)
        ////        {
        ////            text = text.Substring(0, text.Length - 2);
        ////        }
        ////        row["Autor"] = text;
        ////    }
        ////    con.Close();
        ////}

        
        #endregion

        /// <summary>
        /// Buchaugabe eines Buches
        /// </summary>
        public void Execute_Ausleihe(int buch_id, string aus_datum, string rueck_datum, int kunde)
        {
            if (con.ConnectError()) return;
            string RawCommand = "INSERT into [dbo].[t_bd_ausgeliehen] (aus_buchid, aus_leihdatum, aus_rückgabedatum, aus_kundenid) VALUES(@buchid, @ausdatum, @rückdatum, @kunde)";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@buchid", buch_id);
            cmd.Parameters.AddWithValue("@ausdatum", aus_datum);
            cmd.Parameters.AddWithValue("@rückdatum", rueck_datum);
            cmd.Parameters.AddWithValue("@kunde", kunde);

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
