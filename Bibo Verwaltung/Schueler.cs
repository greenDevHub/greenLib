using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using System.Globalization;

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

        DateTime gd;
        /// <summary>
        /// Wohnort des Kunden
        /// </summary>
        public DateTime Gd { get { return gd; } set { gd = value; } }

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

        Fach fach = new Fach();
        /// <summary>
        /// Strasse auf der der Kunde wohnt
        /// </summary>
        public Fach Fach { get { return fach; } set { fach = value; } }

        List<string> faecher = new List<string>();
        public List<string> Faecher { get { return faecher; } set { faecher = value; } }
        #endregion

        #region Objekt Schueler
        /// <summary>
        /// Erschaft das Objekt Kunde
        /// </summary>
        public Schueler()
        {
            FillObject();
        }
        public Schueler(bool a)
        {

        }
        public Schueler(string id)
        {
            this.SchuelerID = id;
            loadSchueler();
            loadFaecher();
        }
        #endregion

        #region Load
        private void loadSchueler()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT sch_vorname, sch_nachname, sch_klasse, sch_stufe, isnull(sch_datum, '01.01.1990') as 'verified_datum' FROM [dbo].[t_s_schueler] WHERE  sch_id=@0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, SchuelerID);
            while (dr.Read())
            {
                Vorname = dr["sch_vorname"].ToString();
                Nachname = dr["sch_nachname"].ToString();
                Klasse = dr["sch_klasse"].ToString();
                Klassenstufe = dr["sch_stufe"].ToString();
                Gd = (DateTime)dr["verified_datum"];
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }

        private void loadFaecher()
        {
            Faecher.Clear();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_fach_schueler] WHERE  fs_schuelerid = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, SchuelerID);
            while (dr.Read())
            {
                Fach = new Fach(dr["fs_fachid"].ToString());
                Faecher.Add(Fach.FachKurz);
            }
            dr.Close();
        }
        #endregion

        #region GetSchuelerID
        public void LoadSchuelerID()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT sch_id FROM [dbo].[t_s_schueler] WHERE sch_vorname = @0 and sch_nachname = @1 and sch_datum = @2";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, Vorname, Nachname, Gd.Date);
            while (dr.Read())
            {
                SchuelerID = dr["sch_id"].ToString();
            }
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
            //string RawCommand = "select sch_id as 'Schueler-ID', sch_vorname as 'Vorname', sch_nachname as 'Nachname',sch_datum as 'Geburtsdatum', sch_klasse as 'Klasse', sch_stufe as 'Klassenstufe', f_id as 'FachID' FROM [dbo].[t_s_schueler] left join t_s_faecher on sch_fach = f_id";
            string RawCommand = "select sch_id as 'Schüler-ID', sch_vorname as 'Vorname', sch_nachname as 'Nachname',sch_datum as 'Geburtsdatum', sch_klasse as 'Klasse', sch_stufe as 'Klassenstufe' FROM [dbo].[t_s_schueler]";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            //if (ds.Tables[0].Columns.Contains("Fächer"))
            //{
            //    ds.Tables[0].Columns.RemoveAt(ds.Tables[0].Columns.IndexOf("Fächer"));
            //}
            //ds.Tables[0].Columns.Add("Fächer", typeof(System.String));
            //foreach(DataRow row in ds.Tables[0].Rows)
            //{
            //    string text = "";
            //    foreach (string s in FachListe.GetNames(row["FachListeID"].ToString()))
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
            //    row["Fächer"] = text;
            //}
            con.Close();
        }

        private void clearDataSource()
        {
            ds.Tables[0].Clear();
        }
        //private List<string> FachIDs(string vn, string nn, string gd)
        //{
        //    List<string> fachids = new List<string>();
        //    if (con.ConnectError()) return fachids;
        //    string RawCommand = "SELECT sch_fach FROM [dbo].[t_s_schueler] WHERE  sch_vorname = @0 and sch_nachname = @1 and sch_datum = @2";
        //    SqlDataReader dr = con.ExcecuteCommand(RawCommand, vn, nn, gd);
        //    while (dr.Read())
        //    {
        //        Fach = new Faecher(dr["sch_fach"].ToString());
        //        fachids.Add(Fach.FachID);
        //    }
        //    // DataReader schließen 
        //    dr.Close();
        //    // Verbindung schließen 
        //    con.Close();
        //    return fachids;
        //}
        public void FillGrid(bool loadAll, ref DataGridView grid, object value = null)
        {
            clearDataSource();
            FillObject();
            //List<string> all = new List<string>();
            //List<string> vNames = new List<string>();
            //List<string> nNames = new List<string>();
            //List<string> gDatum = new List<string>();
            //int vn = ds.Tables[0].Columns.IndexOf("Vorname");
            //int nn = ds.Tables[0].Columns.IndexOf("Nachname");
            //int gd = ds.Tables[0].Columns.IndexOf("Geburtsdatum");
            //Faecher f = new Faecher();
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    DataRow row = ds.Tables[0].Rows[i];
            //    //vNames.Add(row[vn].ToString());
            //    //nNames.Add(row[nn].ToString());
            //    //gDatum.Add(row[gd].ToString());
            //    all.Add(row[vn].ToString() + ';' + row[nn].ToString() + ';' + row[gd].ToString());
                
            //}
            //all = all.Distinct().ToList();
            //foreach (string s in all)
            //{
            //    string[] splitted = s.Split(';');
            //    vNames.Add(splitted[0]);
            //    nNames.Add(splitted[1]);
            //    gDatum.Add(splitted[2]);
            //}
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Vorname");
            dt.Columns.Add("Nachname");
            dt.Columns.Add("Geburtsdatum");
            dt.Columns.Add("Klasse");
            dt.Columns.Add("Klassenstufe");
            dt.Columns.Add("Fächer");
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                SchuelerID = row[ds.Tables[0].Columns.IndexOf("Schüler-ID")].ToString();
                Vorname = row[ds.Tables[0].Columns.IndexOf("Vorname")].ToString();
                Nachname = row[ds.Tables[0].Columns.IndexOf("Nachname")].ToString();
                Gd = (DateTime)row[ds.Tables[0].Columns.IndexOf("Geburtsdatum")];
                Klasse = row[ds.Tables[0].Columns.IndexOf("Klasse")].ToString();
                Klassenstufe = row[ds.Tables[0].Columns.IndexOf("Klassenstufe")].ToString();
                loadFaecher();
                DataRow dataRow = dt.NewRow();
                dataRow["ID"] = SchuelerID;
                dataRow["Vorname"] = Vorname;
                dataRow["Nachname"] = Nachname;
                dataRow["Geburtsdatum"] = Gd.ToShortDateString();
                dataRow["Klasse"] = Klasse;
                dataRow["Klassenstufe"] = Klassenstufe;
                string fach = "";
                foreach (string s in Faecher)
                {
                    fach = fach + s + ", ";
                }
                try
                {
                    fach = fach.Substring(0, fach.Length - 2);
                }
                catch
                {
                    fach = "";
                }
                dataRow["Fächer"] = fach;
                dt.Rows.Add(dataRow);
            }
            //for (int i = 0; i < vNames.Count; i++)
            //{
            //    DataRow dataRow = dt.NewRow();

            //    Vorname = vNames[i];
            //    Nachname = nNames[i];
            //    Gd = gDatum[i];
            //    //loadSchueler();
            //    dataRow["Vorname"] = Vorname;
            //    dataRow["Nachname"] = Nachname;
            //    dataRow["Geburtsdatum"] = Gd;
            //    dataRow["Klasse"] = Klasse;
            //    dataRow["Klassenstufe"] = Klassenstufe;
            //    string fach = "";
            //    foreach (string s in Faecher)
            //    {
            //        fach = fach + s + ", ";
            //    }
            //    fach = fach.Substring(0, fach.Length - 2);
            //    dataRow["Fächer"] = fach;
            //    dt.Rows.Add(dataRow);

            //}
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
            grid.DataSource = dt;
            //grid.Columns[ds.Tables[0].Columns.IndexOf("FachListeID")].Visible = false;
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
        public void addSchueler()
        {
            //string RawCommand = "INSERT INTO [dbo].[t_s_schueler] (sch_vorname, sch_nachname, sch_datum, sch_klasse, sch_stufe, sch_fach) VALUES (@vorname, @nachname,@datum, @klasse, @stufe, @fachid)";
            //con.ConnectError();
            //foreach(string s in Faecher)
            //{
            //    SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            //    cmd.Parameters.AddWithValue("@vorname", Vorname);
            //    cmd.Parameters.AddWithValue("@nachname", Nachname);
            //    cmd.Parameters.AddWithValue("@datum", Gd);
            //    cmd.Parameters.AddWithValue("@stufe", Klassenstufe);
            //    cmd.Parameters.AddWithValue("@klasse", Klasse);
            //    cmd.Parameters.AddWithValue("@fachid", Fach.GetID(s));

            //    // Verbindung öffnen 
            //    cmd.ExecuteNonQuery();
            //}
            ////Verbindung schließen
            //con.Close();
            string RawCommand = "INSERT INTO [dbo].[t_s_schueler] (sch_vorname, sch_nachname, sch_datum, sch_klasse, sch_stufe) VALUES (@vorname, @nachname,@datum, @klasse, @stufe)";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@vorname", Vorname);
            cmd.Parameters.AddWithValue("@nachname", Nachname);
            cmd.Parameters.AddWithValue("@datum", Gd);
            cmd.Parameters.AddWithValue("@stufe", Klassenstufe);
            cmd.Parameters.AddWithValue("@klasse", Klasse);

                // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            LoadSchuelerID();
            AddFaecher();
            //Verbindung schließen
            con.Close();

        }
        private void AddFaecher()
        {
            con.ConnectError();
            string RawCommand = "INSERT INTO [dbo].[t_s_fach_schueler] (fs_schuelerid, fs_fachid) VALUES (@schuelerid, @fachid)";
            foreach(string s in Faecher)
            {
                Fach.FachKurz = s;
                Fach.FachLang = "";
                if (!Fach.FachExists())
                {
                    Fach.AddFach();
                }
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                cmd.Parameters.AddWithValue("@schuelerid", SchuelerID);
                cmd.Parameters.AddWithValue("@fachid", Fach.GetIDByShortform(s));
                cmd.ExecuteNonQuery();
            }
        }
        #endregion

        #region Exists?
        public bool AlreadyExists()
        {
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM [dbo].[t_s_schueler] WHERE sch_vorname = @0 and sch_nachname = @1 and sch_datum = @2";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, Vorname, Nachname, Gd.Date);
            while (dr.Read())
            {
                SchuelerID = dr["sch_id"].ToString();
            }
            dr.Close();
            con.Close();
            if(SchuelerID == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region Save
        public void Update()
        {
            string RawCommand = "UPDATE [dbo].[t_s_schueler] SET sch_klasse = @klasse, sch_stufe = @stufe WHERE sch_id = @id";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@id", SchuelerID);
            cmd.Parameters.AddWithValue("@stufe", Klassenstufe);
            cmd.Parameters.AddWithValue("@klasse", Klasse);

            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            DeleteFaecher();
            AddFaecher();
            //Verbindung schließen
            con.Close();
        }
        private void DeleteFaecher()
        {
            string RawCommand = "DELETE FROM [dbo].[t_s_fach_schueler] WHERE fs_schuelerid = @id";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@id", SchuelerID);
            cmd.ExecuteNonQuery();
        }
        #endregion

        #region Delete
        public void DeleteSchueler()
        {
            DeleteFaecher();
            string RawCommand = "DELETE FROM [dbo].[t_s_schueler] WHERE sch_id=@id";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@id", SchuelerID);

            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
            //string RawCommand = "DELETE FROM [dbo].[t_s_schueler] WHERE sch_id = @id";
            //con.ConnectError();
            //SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            //cmd.Parameters.AddWithValue("@id", SchuelerID);

            //// Verbindung öffnen 
            //cmd.ExecuteNonQuery();
            ////Verbindung schließen
            //con.Close();
        }
        #endregion
    }
}

