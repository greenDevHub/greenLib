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
    class Schueler
    {
        SQL_Verbindung con = new SQL_Verbindung();

        #region Strings
        string schuelerid;
        /// <summary>
        /// ID des Kunden
        /// </summary>
        public string SchuelerID { get { return schuelerid; } set { schuelerid = value; } }

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

        string gd;
        /// <summary>
        /// Wohnort des Kunden
        /// </summary>
        public string Gd { get { return gd; } set { gd = value; } }

        string klasse;
        /// <summary>
        /// Klasse des Kunden
        /// </summary>
        public string Klasse { get { return klasse; } set { klasse = value; } }

        string klassenstufe;
        /// <summary>
        /// Postleitzahl des Wohnorts des Kunden
        /// </summary>
        public string Klassenstufe { get { return klassenstufe; } set { klassenstufe = value; } }

        FachListe fachListe = new FachListe();
        /// <summary>
        /// Strasse auf der der Kunde wohnt
        /// </summary>
        public FachListe FachListe { get { return fachListe; } set { fachListe = value; } }
        #endregion

        #region Objekt Schueler
        /// <summary>
        /// Erschaft das Objekt Kunde
        /// </summary>
        public Schueler()
        {
            FillObject();
        }
        public Schueler(string schuelerid)
        {
            this.schuelerid = schuelerid;
            load();
        }
        #endregion

        #region Load
        private void load()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_schueler] WHERE  sch_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, schuelerid);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                SchuelerID = dr["sch_ID"].ToString();
                Vorname = dr["sch_vorname"].ToString();
                Nachname = dr["sch_nachname"].ToString();
                Gd = dr["sch_datum"].ToString();
                Klasse = dr["sch_klasse"].ToString();
                Klassenstufe = dr["sch_stufe"].ToString();
                FachListe = new FachListe(dr["sch_faecher"].ToString());
                
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion

        #region GetFachListeID
        public string GetFachID(string id)
        {
            string fachid = "";
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT sch_faecher FROM [dbo].[t_s_schueler] WHERE sch_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                fachid = dr["sch_faecher"].ToString();
            }
            return fachid;
        }
        #endregion

        #region Fill Object
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "select sch_id as 'Schueler-ID', sch_vorname as 'Vorname', sch_nachname as 'Nachname', sch_klasse as 'Klasse', sch_stufe as 'Klassenstufe', fl_id as 'FachListeID' FROM [dbo].[t_s_schueler] left join t_s_fachListe on sch_faecher = fl_id";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            if (ds.Tables[0].Columns.Contains("Fächer"))
            {
                ds.Tables[0].Columns.RemoveAt(ds.Tables[0].Columns.IndexOf("Fächer"));
            }
            ds.Tables[0].Columns.Add("Fächer", typeof(System.String));
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                string text = "";
                foreach (string s in FachListe.GetNames(row["FachListeID"].ToString()))
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
                row["Fächer"] = text;
            }
            con.Close();
        }

        private void clearDataSource()
        {
            ds.Tables[0].Rows.Clear();
        }

        public void FillGrid(bool loadAll, ref DataGridView grid, object value = null)
        {
            clearDataSource();
            FillObject();
            
            //for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    DataRow row = ds.Tables[0].Rows[i];
            //    for(int s = 1; s < 17; s++)
            //    {
            //        string name = "Fach " + s;
            //        object cell = row[ds.Tables[0].Columns.IndexOf(name)];
            //        string fachIDD = cell.ToString();
            //        Faecher fach = new Faecher(cell.ToString());
            //        row[ds.Tables[0].Columns.IndexOf(name)] = fach.Fach;
            //    }
            //}
            //ds.Tables[0].Columns[ds.Tables[0].Columns.IndexOf("sch_1")] = "";
            grid.DataSource = ds.Tables[0];
            grid.Columns[ds.Tables[0].Columns.IndexOf("FachListeID")].Visible = false;
        }
        #endregion

        #region Speichern Grid
        public void SaveGrid(ref DataGridView grid)
        {
            comb = new SqlCommandBuilder(adapter);
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                adapter.Update(changes);
            }
        }
        #endregion

        #region Add
        public void addKunde()
        {
            {
                string RawCommand = "INSERT INTO [dbo].[t_s_schueler] (sch_vorname, sch_nachname, sch_datum, sch_klasse, sch_stufe, sch_faecher) VALUES (@vorname, @nachname,@datum, @klasse, @stufe, @fachid)";
                con.ConnectError();
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

                cmd.Parameters.AddWithValue("@vorname", Vorname);
                cmd.Parameters.AddWithValue("@nachname", Nachname);
                cmd.Parameters.AddWithValue("@datum", Gd);
                cmd.Parameters.AddWithValue("@stufe", Klassenstufe);
                cmd.Parameters.AddWithValue("@klasse", Klasse);
                cmd.Parameters.AddWithValue("@fachid", FachListe.FachListeID);

                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                //Verbindung schließen
                con.Close();
            }
        }
        #endregion

        //#region Save
        //public void saveKunde()
        //{
        //    {
        //        string RawCommand = "UPDATE [dbo].[t_s_schueler] SET sch_vorname = @vorname, sch_nachname = @nachname,  sch_klasse = @klasse, sch_stufe = @stufe, sch_fach1 = @1, sch_fach2 = @2, sch_fach3 = @3, sch_fach4 = @4, sch_fach5 = @5, sch_fach6 = @6, sch_fach7 = @7, sch_fach8 = @8, sch_fach9 = @9, sch_fach10 = @10, sch_fach11 = @11, sch_fach12 = @12, sch_fach13 = @13, sch_fach14 = @14, sch_fach15 = @15, sch_fach16 = @16 WHERE kunde_ID = @k_ID";
        //        con.ConnectError();
        //        SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

        //        cmd.Parameters.AddWithValue("@vorname", Vorname);
        //        cmd.Parameters.AddWithValue("@nachname", Nachname);
        //        cmd.Parameters.AddWithValue("@ort", Gd);
        //        cmd.Parameters.AddWithValue("@stufe", Klassenstufe);
        //        cmd.Parameters.AddWithValue("@klasse", Klasse);
        //        for (int i = 1; i < 17; i++)
        //        {
        //            cmd.Parameters.AddWithValue("@" + i, fachListe[i - 1]);
        //        }
        //        cmd.Parameters.AddWithValue("@sch_ID", SchuelerID);

        //        // Verbindung öffnen 
        //        cmd.ExecuteNonQuery();
        //        //Verbindung schließen
        //        con.Close();
        //    }
        //}
        //#endregion

        //#region Delete
        //public void deleteKunde()
        //{
        //    {
        //        string RawCommand = "DELETE FROM [dbo].[t_s_schueler] WHERE sch_id = @id";
        //        con.ConnectError();
        //        SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

        //        cmd.Parameters.AddWithValue("@id", SchuelerID);

        //        // Verbindung öffnen 
        //        cmd.ExecuteNonQuery();
        //        //Verbindung schließen
        //        con.Close();
        //    }
        //}
        //#endregion
    }
}

