using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung
{
    class Rueckgabe
    {
        SQL_Verbindung con = new SQL_Verbindung();

        #region Buch Eigenschaften
        string kid;
        /// <summary>
        /// Kunden Nummer eines Buches
        /// </summary>
        public string KID { get { return kid; } set { kid = value; } }

        DateTime leihdatum;
        /// <summary>
        /// Leihdatum eines Buches
        /// </summary>
        public DateTime Leihdatum { get { return leihdatum; } set { leihdatum = value; } }

        DateTime rueckgabedatum;
        /// <summary>
        /// Rueckgabedatum eines Buches
        /// </summary>
        public DateTime Rueckgabedatum { get { return rueckgabedatum; } set { rueckgabedatum = value; } }
        #endregion

        public void Load_Info(string exemlarID)
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT aus_leihdatum, aus_rückgabedatum, aus_kundenid FROM t_bd_ausgeliehen WHERE aus_buchid = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, exemlarID);
            // Einlesen der Datenzeilen 
            while (dr.Read())
            {
                KID = dr["aus_kundenid"].ToString();
                Leihdatum = (DateTime)dr["aus_leihdatum"];
                Rueckgabedatum = (DateTime)dr["aus_rückgabedatum"];
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }

        public void Execute_Rueckgabe(string Exemplar, string Kunde, string SollZustand, string IstZustandID, string IstZustand, string AusleihStartDatum, string AusleihEndDatum)
        {
            if (con.ConnectError()) return;
            string RawCommand1 = "DELETE FROM t_bd_ausgeliehen WHERE aus_buchid = @0";
            SqlCommand cmd = new SqlCommand(RawCommand1, con.Con);
            cmd.Parameters.AddWithValue("@0", Exemplar);
            cmd.ExecuteNonQuery();

            string RawCommand2 = "UPDATE t_s_buchid set bu_zustandsid = @zustandsid WHERE bu_id = @id";
            cmd = new SqlCommand(RawCommand2, con.Con);
            cmd.Parameters.AddWithValue("@zustandsid", IstZustandID);
            cmd.Parameters.AddWithValue("@id", Exemplar);
            cmd.ExecuteNonQuery();

            string RawCommand3 = "INSERT INTO t_s_verlauf (id_buch, k_id, zu_vor, zu_nach, aus_geliehen, aus_ruckgabe) VALUES (@buchid, @kid, @zvor, @znach, @ausgeliehen, @ruckgabe)";
            cmd = new SqlCommand(RawCommand3, con.Con);
            cmd.Parameters.AddWithValue("@buchid", Exemplar);
            cmd.Parameters.AddWithValue("@kid", Kunde);
            cmd.Parameters.AddWithValue("@zvor", SollZustand);
            cmd.Parameters.AddWithValue("@znach", IstZustand);
            cmd.Parameters.AddWithValue("@ausgeliehen", AusleihStartDatum);
            cmd.Parameters.AddWithValue("@ruckgabe", AusleihEndDatum);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
