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
    class FachStufe
    {
        #region Constructor
        string zuordnungid;
        public string ZuordnungID { get { return zuordnungid; } set { zuordnungid = value; } }

        Faecher fach = new Faecher();
        public Faecher Fach { get { return fach; } set { fach = value; } }

        List<string> fachListe = new List<string>();
        public List<string> FachListe { get { return fachListe; } set { fachListe = value; } }

        Klassenstufe klassenstufe = new Klassenstufe();
        public Klassenstufe Klassenstufe { get { return klassenstufe; } set { klassenstufe = value; } }

        public FachStufe()
        {

        }
        public FachStufe(string stufe)
        {
            this.Klassenstufe.Stufe = stufe;
            Load();
        }
        #endregion

        #region Methoden

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "Select * FROM [dbo].[t_s_fach_stufe] WHERE fs_stufe = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, Klassenstufe.Stufe);
            fachListe.Clear();
            while (dr.Read())
            {
                //ZuordnungID = dr["fs_id"].ToString();
                Fach = new Faecher(dr["fs_fachid"].ToString());
                fachListe.Add(Fach.FachKurz);
                //Klassenstufe = new Klassenstufe(dr["fs_stufe"].ToString());
            }
            dr.Close();
            con.Close();
        }
        #endregion

        #region Add
        public void Add()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_fach_stufe] (fs_fachid, fs_stufe) VALUES (@fachid, @klassenstufe)";
            foreach(string s in FachListe)
            {
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                cmd.Parameters.AddWithValue("@fachid", Fach.GetID(s));
                cmd.Parameters.AddWithValue("@klassenstufe", Klassenstufe.Stufe);
                cmd.ExecuteNonQuery();
            }

            con.Close();
        }
        #endregion

        #region Update
        public void Update()
        {
            Delete();
            Add();
        }
        #endregion

        #region Delete
        public void Delete()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            string RawCommand = "DELETE FROM [dbo].[t_s_fach_stufe] WHERE fs_stufe=@stufe";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@stufe", Klassenstufe.Stufe);

            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
        #endregion

        #region Fill Object
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            dt.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT fs_id as 'ID', fs_fachid as 'Kurzform', f_kurzform as 'Fach', k_stufe as 'Klassenstufe' FROM [dbo].[t_s_fach_stufe] left join [dbo].[t_s_faecher] on fs_fachid = f_id left join [dbo].[t_s_klassenstufe] on fs_stufe = k_stufe";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(dt);
            con.Close();
        }
        #endregion

        #region DataSet zuruecksetzen
        private void ClearDS()
        {
            dt.Clear();
        }
        #endregion

        #region FillGrid
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            ClearDS();
            FillObject();
            DataTable data = new DataTable();
            //data.Columns.Add("ID");
            data.Columns.Add("Klassenstufe");
            data.Columns.Add("Fach");
            foreach (DataRow row in dt.Rows)
            {
                //ZuordnungID = row[dt.Columns.IndexOf("ID")].ToString();
                Klassenstufe.Stufe = row[dt.Columns.IndexOf("Klassenstufe")].ToString();
                DataRow dataRow = data.NewRow();
                //dataRow["ID"] = ZuordnungID;
                dataRow["Klassenstufe"] = Klassenstufe.Stufe;
                dataRow["Fach"] = Fach.FachKurz;
                Load();
                string fach = "";
                foreach (string s in fachListe)
                {
                    fach = fach + s + ", ";
                }
                fach = fach.Substring(0, fach.Length - 2);
                dataRow["Fach"] = fach;
                data.Rows.Add(dataRow);

            }
            //data = dtEmp.DefaultView.ToTable(true);
            DataTable distinctTable = data.DefaultView.ToTable(true);
            grid.DataSource = distinctTable;

        }
        #endregion

        #region Exists?
        public bool AlreadyExists()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM [dbo].[t_s_fach_stufe] WHERE fs_stufe = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, Klassenstufe.Stufe);
            while (dr.Read())
            {
                ZuordnungID = dr["fs_id"].ToString();
            }
            dr.Close();
            con.Close();
            if (ZuordnungID == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #endregion
    }
}