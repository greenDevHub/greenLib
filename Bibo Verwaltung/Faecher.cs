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
    class Faecher
    {
        #region Eigenschaften
        string fach;
        public string Fach { get { return fach; } set { fach = value; } }

        string fachid;
        public string FachID { get { return fachid; } set { fachid = value; } }

        string fachkurz;
        public string FachKurz { get { return fachkurz; } set { fachkurz = value; } }
        #endregion

        #region Objekt
        public Faecher()
        {
            FillObject();
        }
        public Faecher(string fachid)
        {
            this.fachid = fachid;
            Load();
            FillObject();
        }
        #endregion

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_faecher] WHERE f_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, FachID);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                FachID = dr["f_id"].ToString();
                FachKurz = dr["f_kurzform"].ToString();
                Fach = dr["f_langform"].ToString();

            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion
        #region Exists?
        public bool AlreadyExists()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT f_id FROM [dbo].[t_s_faecher] WHERE f_kurzform = @0 and f_langform = @1";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, FachKurz, Fach);
            while (dr.Read())
            {
                FachID = dr["f_id"].ToString();
            }
            dr.Close();
            con.Close();
            if (FachID == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
        #region Add
        public void Add()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_faecher] (f_kurzform, f_langform) VALUES (@0, @1)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", FachKurz);
            cmd.Parameters.AddWithValue("@1", Fach);
            cmd.ExecuteNonQuery();
            con.Close();
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
            string RawCommand = "SELECT * FROM [dbo].[t_s_faecher]";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            con.Close();
            //foreach(DataRow row in dt.Rows)
            //{
            //    row["f_kurzform"] = row["f_kurzform"] + " (" + row["f_langform"] +")";
            //}
        }
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["f_kurzform"].HeaderText = "Kurzform";
            grid.Columns["f_langform"].HeaderText = "Langform";
        }
        public void FillList(ref CheckedListBox clb)
        {
            FillObject();
            ((ListBox)clb).DataSource = dt;
            ((ListBox)clb).DisplayMember = "f_kurzform";
            ((ListBox)clb).ValueMember = "f_id";

            foreach(var test in clb.Items)
            {
                dt = dt;
            }
        }
        public void FillCombobox(ref ComboBox cb, object value)
        {
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "f_id";
            cb.DisplayMember = "f_kurzform";
            cb.SelectedValue = value;
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

        #region GetID
        public string GetID(string kurz)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT f_id FROM [dbo].[t_s_faecher] WHERE f_kurzform = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, kurz);
            while (dr.Read())
            {
                FachID = dr["f_id"].ToString();
            }
            dr.Close();
            con.Close();
            return FachID;
        }
        #endregion

        public string GetFullName(string id)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT f_langform, f_kurzform FROM [dbo].[t_s_faecher] WHERE f_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                FachKurz = dr["f_kurzform"].ToString();
                Fach = dr["f_langform"].ToString();
            }
            dr.Close();
            con.Close();
            return Fach;
        }

    }
}
