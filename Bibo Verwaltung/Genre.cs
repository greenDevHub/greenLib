using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Collections;

namespace Bibo_Verwaltung
{
    class Genre
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        SQL_Verbindung con = new SQL_Verbindung();

        #region Genre Eigenschaften
        string genreid;
        /// <summary>
        /// ID des Genres
        /// </summary>
        public string GenreID { get { return genreid; } set { genreid = value; } }

        string genrename;
        /// <summary>
        /// Name des Genres
        /// </summary>
        public string Genrename { get { return genrename; } set { genrename = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschaft das Objekt Genre
        /// </summary>
        public Genre()
        {
            FillObject();
        }
        public Genre(string genreid)
        {
            this.genreid = genreid;
            LoadGenre();
            FillObject();
        }
        #endregion

        /// <summary>
        /// Lädt die Genredaten eines Genres
        /// </summary>
        public void LoadGenre()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_genre] WHERE ger_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, genreid);
            while (dr.Read())
            {
                GenreID = dr["ger_id"].ToString();
                Genrename = dr["ger_name"].ToString();
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Füllt ein DataSet mit Genredaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_genre]";
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
        /// Füllt ein ComboBox-Objekt mit Genredaten 
        /// </summary>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            ClearDataSource();
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "ger_id";
            cb.DisplayMember = "ger_name";
            cb.SelectedValue = value;
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit Genredaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["ger_name"].HeaderText = "Bezeichnung";
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
                Hashtable hTable = new Hashtable();
                ArrayList duplicateList = new ArrayList();

                //1. Die Changes-Tabelle auf duplikate überprüfen (mehrfache eingabe des selben Wertes)
                foreach (DataRow drow in changes.Tables[0].Rows)
                {
                    if (hTable.Contains(drow[0]))
                    {
                        duplicateList.Add(drow);
                    }
                    else
                    {
                        hTable.Add(drow[0], string.Empty);
                    }
                }
                //Entfernen der Duplikate von 1.
                foreach (DataRow dRow in duplicateList)
                {
                    changes.Tables[0].Rows.Remove(dRow);
                }

                //2. Die Ausgangsdaten auf die Werte überprüfen, die in den Changes sind
                duplicateList.Clear();
                var s = dt.Rows;
                for (int i = 0; i < changes.Tables[0].Rows.Count; i++)
                {
                    string str = changes.Tables[0].Rows[i][1].ToString();
                    bool contains = dt.AsEnumerable().Any(row => str.Equals(row.Field<String>(1), StringComparison.InvariantCultureIgnoreCase));
                    if (contains)
                    {
                        duplicateList.Add(changes.Tables[0].Rows[i]);
                    }
                }
                //Entfernen der Duplikate von 2.
                foreach (DataRow dRow in duplicateList)
                {
                    changes.Tables[0].Rows.Remove(dRow);
                }
                return changes;
            }
            catch(Exception ex)
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
        /// Fügt eine Genre der Datenbank hinzu 
        /// </summary>
        public void AddGenre(string genre)
        {
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_genre] (ger_name) VALUES (@0)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", genre);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Gibt die Genre ID zurück 
        /// </summary>
        public string GetGenreID(string genre)
        {
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT ger_id FROM [dbo].[t_s_genre] WHERE ger_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, genre);
            while (dr.Read())
            {
                GenreID = dr["ger_id"].ToString();
            }
            dr.Close();
            con.Close();
            return GenreID;
        }

        public bool IfContains(string value)
        {
            bool contains = dt.AsEnumerable().Any(row => value == row.Field<String>("ger_name"));
            return contains;
        }
    }
}
