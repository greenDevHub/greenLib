using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace Bibo_Verwaltung
{
    class Sprache
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        SQL_Verbindung con = new SQL_Verbindung();

        #region Sprache Eigenschaften
        string spracheid;
        /// <summary>
        /// ID der Sprache
        /// </summary>
        public string SpracheID { get { return spracheid; } set { spracheid = value; } }

        string sprachename;
        /// <summary>
        /// Name der Sprache
        /// </summary>
        public string Sprachename { get { return sprachename; } set { sprachename = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschaft das Objekt Sprache
        /// </summary>
        public Sprache()
        {
            FillObject();
        }
        public Sprache(string spracheid)
        {
            this.spracheid = spracheid;
            LoadSprache();
            FillObject();
        }
        #endregion

        /// <summary>
        /// Lädt die Spachdaten einer Sprache
        /// </summary>
        private void LoadSprache()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_sprache] WHERE sprach_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, spracheid);
            while (dr.Read())
            {
                SpracheID = dr["sprach_id"].ToString();
                Sprachename = dr["sprach_name"].ToString();
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Füllt ein DataSet mit Sprachdaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_sprache]";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            con.Close();
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
        /// Füllt eine ComoBox mit Sprachdaten 
        /// </summary>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            ClearDataSource();
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "sprach_id";
            cb.DisplayMember = "sprach_name";
            cb.SelectedValue = value;
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit Sprachdaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["sprach_name"].HeaderText = "Bezeichnung";
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
        /// Fügt eine Sprache der Datenbank hinzu 
        /// </summary>
        public void AddSprache(string sprache)
        {
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_sprache] (sprach_name) VALUES (@0)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", sprache);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Gibt die ID einer Sprache zurück
        /// </summary>
        public string GetSprachID(string sprache)
        {
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT sprach_id FROM [dbo].[t_s_sprache] WHERE sprach_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, sprache);
            while (dr.Read())
            {
                SpracheID = dr["sprach_id"].ToString();
            }
            dr.Close();
            con.Close();
            return SpracheID;
        }

        public bool IfContains(string value)
        {
            bool contains = dt.AsEnumerable().Any(row => value == row.Field<String>("sprach_name"));
            return contains;
        }
    }
}

