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
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();

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
            LoadZustand();
            FillObject();
        }

        /// <summary>
        /// Lädt die Zustandsdaten eines Buchzustandes
        /// </summary>
        public void LoadZustand()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_zustand] WHERE zu_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, zustandid);
            while (dr.Read())
            {
                ZustandID = dr["zu_id"].ToString();
                Zustandname = dr["zu_zustand"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public DataGridViewComboBoxColumn FillDataGridViewComboBox()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            ClearDataSource();
            DataRow relation;
            string[] defaultValue = new string[2];

            defaultValue[0] = "0";
            defaultValue[1] = "--auswählen--";
            if (dt.Columns.Count != 2)
            {
                dt.Columns.Add();
            }
            relation = dt.NewRow();
            relation.ItemArray = defaultValue;
            dt.Rows.Add(relation);
            FillObject();
            cb.HeaderText = "Zustand";
            cb.Name = "cbzustand";
            cb.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            cb.Width = 1500;
            cb.SortMode = DataGridViewColumnSortMode.NotSortable;
            cb.DataSource = dt;
            cb.ValueMember = "zu_id";
            cb.DisplayMember = "zu_zustand";
            return cb;
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt im DataSet 
        /// </summary>
        private void ClearDataSource()
        {
            try
            {
                ds.Tables[0].Rows.Clear();
                dt.Clear();
            }
            catch { }
        }

        /// <summary>
        /// Füllt eine ComoBox mit Zustandsdaten 
        /// </summary>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            ClearDataSource();
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "zu_id";
            cb.DisplayMember = "zu_zustand";
            cb.SelectedValue = value;
        }

        /// <summary>
        /// Füllt ein DataSet mit Zustandsdaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_zustand]";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            con.Close();
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit Zustandsdaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["zu_zustand"].HeaderText = "Zustand";
        }

        /// <summary>
        /// Prüft die Daten aus einen DataGridView-Objekt auf Veränderungen 
        /// </summary>
        public bool GetChangesGrid(ref MetroGrid grid)
        {
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Entfernt Duplikate aus den Changes
        /// </summary>
        /// <param name="changes"></param>
        /// <returns></returns>
        private DataSet noDuplicates(DataSet changes)
        {
            try
            {
                string a = changes.Tables[0].Rows[0][0].ToString();

                DataTable oldData = new DataTable();
                oldData.Columns.Add("id", typeof(int));
                oldData.Columns.Add("name", typeof(string));

                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    string str = dr[0].ToString();
                    if (dr[0].ToString() != "")
                    {
                        DataRow row = oldData.NewRow();
                        row[0] = int.Parse(dr[0].ToString());
                        row[1] = dr[1].ToString();
                        oldData.Rows.Add(row);
                    }
                }


                DataTable clearedChanges = changes.Tables[0].DefaultView.ToTable(true);
                DataSet cleared = new DataSet();
                List<int> removeAt = new List<int>();
                for (int i = 0; i < clearedChanges.Rows.Count; i++)
                {
                    string s = clearedChanges.Rows[i][1].ToString();
                    if (oldData.AsEnumerable().Any(row => s == row.Field<String>("name")))
                    {
                        removeAt.Add(i);
                    }
                }
                for (int i = 0; i < removeAt.Count; i++)
                {
                    clearedChanges.Rows.RemoveAt(removeAt[i] - i);
                }
                cleared.Tables.Add(clearedChanges);
                return cleared;
            }
            catch (Exception ex)
            {
                return changes;
            }
        }
        /// <summary>
        /// Speichert die Daten aus einen DataGridView-Objekt in die Datenbank 
        /// </summary>
        public void SaveGrid(ref MetroGrid grid)
        {
            comb = new SqlCommandBuilder(adapter);
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                changes = noDuplicates(changes);
                adapter.Update(changes);
            }
        }

        /// <summary>
        /// Fügt einen Buchzustand der Datenbank hinzu 
        /// </summary>
        public void AddZustand(string zustand)
        {
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_zustand] (zu_zustand) VALUES (@0)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", zustand);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Gibt die ID eines Buchzustandes zurück
        /// </summary>
        public string GetZustandsID(string zustand)
        {
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

        /// <summary>
        /// Gibt den ausgeschriebenen Buchzustand der ID zurück
        /// </summary>
        public string GetZustandsName(string id)
        {
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT zu_zustand FROM [dbo].[t_s_zustand] WHERE zu_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                Zustandname = dr["zu_zustand"].ToString();
            }
            dr.Close();
            con.Close();
            return Zustandname;
        }

        public bool IfContains(string value)
        {
            bool contains = dt.AsEnumerable().Any(row => value.Equals(row.Field<String>("zu_zustand"), StringComparison.InvariantCultureIgnoreCase));
            return contains;
        }
    }
}
