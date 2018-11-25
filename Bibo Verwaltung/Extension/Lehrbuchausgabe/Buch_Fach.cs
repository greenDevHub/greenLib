using Bibo_Verwaltung.Extension.Lehrbuchausgabe;
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
    class Buch_Fach
    {
        #region Eigenschaften
        string zuordnungid;
        public string ZuordnungID { get { return zuordnungid; } set { zuordnungid = value; } }

        Faecher fach = new Faecher();
        public Faecher Fach { get { return fach; } set { fach = value; } }

        IsbnListe isbnListe = new IsbnListe();
        public IsbnListe IsbnListe { get { return isbnListe; } set { isbnListe = value; } }

        string klassenstufe;
        public string Klassenstufe { get { return klassenstufe; }set { klassenstufe = value; } }
        #endregion

        #region Objekt
        public Buch_Fach()
        {
            FillObject();
        }
        public Buch_Fach(string id)
        {
            this.zuordnungid = id;
            Load();
            FillObject();
        }
        #endregion

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "Select * FROM [dbo].[t_bd_buch_fach] WHERE bf_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, ZuordnungID);
            while (dr.Read())
            {
                ZuordnungID = dr["bf_id"].ToString();
                Fach = new Faecher(dr["bf_fachid"].ToString());
                IsbnListe = new IsbnListe(dr["bf_isbnlisteid"].ToString());
                Klassenstufe = dr["bf_klassenstufe"].ToString();
            }
            dr.Close();
            con.Close();
        }
        #endregion

        #region GetIsbnListeID
        public string GetIsbnID(string buchfachid)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            string id = "";
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT bf_isbnlisteid FROM [dbo].[t_bd_buch_fach] WHERE bf_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, buchfachid);
            while (dr.Read())
            {
                id = dr["bf_isbnlisteid"].ToString();
            }
            return id;
        }
        #endregion

        #region Add
        public void Add()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            //SQL-Verbindung pruefen
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_bd_buch_fach] (bf_fachid, bf_isbnlisteid, bf_klassenstufe) VALUES (@fachid, @isbn, @klassenstufe)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            IsbnListe.Add();
            cmd.Parameters.AddWithValue("@isbn", IsbnListe.IsbnListeID);
            cmd.Parameters.AddWithValue("@fachid", Fach.FachID);
            cmd.Parameters.AddWithValue("@klassenstufe", Klassenstufe);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion
        

        #region Save
        public void Save()
        {
            //SQL_Verbindung con = new SQL_Verbindung();
            //string RawCommand = "UPDATE t_bd_buch_fach set WHERE bf_fachid = @fachid and bf_klassenstufe = @klassenstufe";
            //if (con.ConnectError()) return;
            //SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            ////cmd.Parameters.AddWithValue("@id", ZuordnungID);
            IsbnListe.Update();
            //cmd.Parameters.AddWithValue("@fachid", Fach.FachID);
            //cmd.Parameters.AddWithValue("@klassenstufe", Klassenstufe);
            //// Verbindung öffnen 
            //cmd.ExecuteNonQuery();
            ////Verbindung schließen
            //con.Close();
        }
        #endregion

        #region Delete
        public void Delete()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            string RawCommand = "DELETE FROM [dbo].[t_bd_buch_fach] WHERE bf_id = @id";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@id", ZuordnungID);
            cmd.ExecuteNonQuery();
            con.Close();
            IsbnListe.Delete();
        }
        #endregion

        #region GetID
        public string GetID(string fachid, string klassenstufe)
        {
            string id = "";
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT bf_id from t_bd_buch_fach  where bf_fachid = @0 AND bf_klassenstufe = @1";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, fachid, klassenstufe);
            while (dr.Read())
            {
                id = dr["bf_id"].ToString();
            }
            dr.Close();
            con.Close();
            return id;
        }
        #endregion

        #region Fill Object
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            dt.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bf_isbnlisteid as IsbnListeID, f_kurzform as Kurzform, f_langform as Langform, bf_klassenstufe as Klassenstufe FROM [dbo].[t_bd_buch_fach] left join [dbo].[t_s_faecher] on bf_fachid = f_id left join [dbo].[t_s_isbnliste] on bf_isbnlisteid = bl_id";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            if (ds.Tables[0].Columns.Contains("ISBN"))
            {
                ds.Tables[0].Columns.RemoveAt(ds.Tables[0].Columns.IndexOf("ISBN"));
            }
            ds.Tables[0].Columns.Add("ISBN", typeof(System.String));
            foreach(DataRow row in ds.Tables[0].Rows)
            {
                string text = "";
                foreach(string s in IsbnListe.GetNames(row["IsbnListeID"].ToString()))
                {
                    if(s != null && !s.Equals(""))
                    {
                        text = text + s + ", ";
                    }
                }
                if(text.Length > 2)
                {
                    text = text.Substring(0, text.Length - 2);
                }
                row["ISBN"] = text;
            }
            ds.Tables[0].Columns["ISBN"].SetOrdinal(1);

            con.Close();
        }

        public string ISBNs()
        {
            string text = "";
            foreach (string s in IsbnListe.GetNames(GetIsbnID(ZuordnungID).ToString()))
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
        //public void FillCombobox(ref ComboBox cb, object value)
        //{
        //    FillObject();
        //    cb.DataSource = dt;
        //    cb.ValueMember = "au_id";
        //    cb.DisplayMember = "au_autor";
        //    cb.SelectedValue = value;
        //}
        //public void FillList(ref CheckedListBox clb)
        //{
        //    FillObject();
        //    ((ListBox)clb).DataSource = dt;
        //    ((ListBox)clb).DisplayMember = "au_autor";
        //    ((ListBox)clb).ValueMember = "au_id";
        //}
        #region DataSet zuruecksetzen
        private void ClearDS()
        {
            ds.Tables[0].Rows.Clear();
        }
        #endregion
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            ClearDS();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns[ds.Tables[0].Columns.IndexOf("IsbnListeID")].Visible = false;
            //grid.Columns[0].Visible = false;
            //grid.Columns["bf_id"].HeaderText = "ID";
            //grid.Columns["bf_fachid"].HeaderText = "FACHID";
            //grid.Columns["bf_isbn"].HeaderText = "ISBN";
            //grid.Columns["bf_klassenstufe"].HeaderText = "KLASSENSTUFE";

        }
        #endregion
    }
}
