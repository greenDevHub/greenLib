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
    class Zustand
    {
        #region Zustand Eigenschaften
        string zustandid;
        /// <summary>
        /// ID des Zustands
        /// </summary>
        public string ZustandID { get { return zustandid; } set { zustandid = value; } }

        string zustandname;
        /// <summary>
        /// Name des Zustands
        /// </summary>
        public string Zustandname { get { return zustandname; } set { zustandname = value; } }
        #endregion

        public Zustand()
        {
            FillObject();
        }
        public Zustand(string zustandid)
        {
            this.zustandid = zustandid;
            Load();
            FillObject();
        }
        #region Load
        public void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_zustand] WHERE zu_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, zustandid);
            // Einlesen der Datenzeilen 
            while (dr.Read())
            {
                ZustandID = dr["zu_id"].ToString();
                Zustandname = dr["zu_zustand"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion

        #region Fill Object
        public DataGridViewComboBoxColumn FillDataGridViewComboBox()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            FillObject();
            cb.HeaderText = "Zustand";
            cb.Name = "cb";
            cb.DataSource = dt;
            cb.ValueMember = "zu_id";
            cb.DisplayMember = "zu_zustand";
            //cb.SelectedValue = value;
            return cb;
        }

        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "zu_id";
            cb.DisplayMember = "zu_zustand";
            cb.SelectedValue = value;
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            dt.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_zustand]";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);

            con.Close();
        }
        #endregion

        #region FillGrid
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["zu_zustand"].HeaderText = "Zustand";
        }
        #endregion

        #region Speichern Grid
        public void SaveGrid(ref MetroGrid grid)
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
        public void Add(string zustand)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_zustand] (zu_zustand) VALUES (@0)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", zustand);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region GetID
        public string GetID(string zustand)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT zu_id FROM [dbo].[t_s_zustand] WHERE zu_zustand = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, zustand);
            while (dr.Read())
            {
                ZustandID = dr["zu_id"].ToString();
            }
            dr.Close();
            con.Close();
            return ZustandID;
        }
        #endregion

        public bool IfContains(string value)
        {
            bool contains = dt.AsEnumerable().Any(row => value.Equals(row.Field<String>("zu_zustand"), StringComparison.InvariantCultureIgnoreCase));
            return contains;
        }
    }
}
