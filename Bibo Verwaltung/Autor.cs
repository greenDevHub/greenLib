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
    class Autor
    {
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        SQL_Verbindung con = new SQL_Verbindung();

        #region Autor Eigenschafen
        string autorid;
        /// <summary>
        /// ID des Autors
        /// </summary>
        public string AutorID { get { return autorid; } set { autorid = value; } }

        string autorname;
        /// <summary>
        /// Autorname eines Autors
        /// </summary>
        public string Autorname { get { return autorname; } set { autorname = value; } }
        #endregion

        #region Objekt Autor
        /// <summary>
        /// Erschaft das Objekt Autor
        /// </summary>
        public Autor()
        {
            FillObject();
        }
        public Autor(string autorid)
        {
            this.autorid = autorid;
            LoadAutor();
            FillObject();
        }
        #endregion

        /// <summary>
        /// Lädt Autordaten anhand der Autor ID in ein Autor-Ojekt 
        /// </summary>
        private void LoadAutor()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_autor] WHERE au_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, autorid);
            while (dr.Read())
            {
                AutorID = dr["au_id"].ToString();
                Autorname = dr["au_autor"].ToString();
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Fügt einen Autor der Datenbank hinzu 
        /// </summary>
        public void AddAutor(List<string> autors)
        {
            if (con.ConnectError()) return;
            for (int i = 0; i < autors.Count;)
            {
                if (!IfContains(autors[i]))
                {
                    string RawCommand = "INSERT INTO [dbo].[t_s_autor] (au_autor) VALUES (@0)";
                    SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                    cmd.Parameters.AddWithValue("@0", autors[i]);
                    cmd.ExecuteNonQuery();
                    
                }
                i++;

            }
            con.Close();
        }

        /// <summary>
        /// Gibt die Autoren ID zurück 
        /// </summary>
        public string GetAutorID(string autor)
        {
            string id = "";
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT au_id FROM [dbo].[t_s_autor] WHERE au_autor = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, autor);
            while (dr.Read())
            {
                id = dr["au_id"].ToString();
            }
            dr.Close();
            con.Close();
            return id;
        }

        public bool IfContains(string value)
        {
            bool contains = dt.AsEnumerable().Any(row => value == row.Field<String>("au_autor"));
            return contains;
        }

        /// <summary>
        /// Füllt ein DataSet mit Autordaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_autor]";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            con.Close();
        }

        /// <summary>
        /// Füllt ein ComboBox-Objekt mit den Autordaten 
        /// </summary>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            ClearDataSource();
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "au_id";
            cb.DisplayMember = "au_autor";
            cb.SelectedValue = value;
        }

        /// <summary>
        /// Füllt ein ListBox-Objekt mit den Autordaten 
        /// </summary>
        public void FillList(ref AdvancedCheckedListBox clb)
        {
            ClearDataSource();
            FillObject();
            ((ListBox)clb).DataSource = dt;
            ((ListBox)clb).DisplayMember = "au_autor";
            ((ListBox)clb).ValueMember = "au_id";
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Autordaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["au_autor"].HeaderText = "Bezeichnung";
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

        


        //TODO
        private DataSet CleanUp(DataSet set)
        {
            DataRow currentChangeRow;
            int i = 0;
            string currentChangeRowString = "#";
            string currentDTRowString = "#";

            //Tabelle Changes durchgehen
            for (int changeRowIndex = set.Tables[0].Rows.Count - 1; changeRowIndex >= 0; changeRowIndex--)
            {
                //Row setzten
                currentChangeRow = set.Tables[0].Rows[changeRowIndex];
                try
                {
                    //Vergleichsstring aus Changes bauen
                    currentChangeRowString = "#";
                    for (int changeColIndex = 1; changeColIndex <= set.Tables[0].Columns.Count - 1; changeColIndex++) //row in string (an Col 1)
                    {
                        currentChangeRowString = currentChangeRowString + currentChangeRow[changeColIndex].ToString();
                    }
                }
                catch { }
                //Vergleichen
                foreach (DataRow setRow in set.Tables[0].Rows)
                {
                    try
                    {
                        //Vergleichsstring aus dt bauen
                        currentDTRowString = "#";
                        for (int dtColIndex = 1; dtColIndex <= set.Tables[0].Columns.Count - 1; dtColIndex++) //row in string (an Col 1)
                        {
                            currentDTRowString = currentDTRowString + setRow[dtColIndex].ToString();
                        }
                    }
                    catch { }
                }
                if (currentChangeRowString == currentDTRowString && currentChangeRowString != "#")
                {
                    i++;
                }
                if (i > 1)
                {
                    currentChangeRow.Delete();
                }
                i = 0;
            }
            return set;
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
        public void SaveGrid() //bool userDeletedRows
        {
            DataRow currentChangeRow;
            comb = new SqlCommandBuilder(adapter);
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                changes = noDuplicates(changes);
                //CleanUp(changes);
                ////Tabelle Changes durchgehen
                //for (int changeRowIndex = changes.Tables[0].Rows.Count - 1; changeRowIndex >= 0; changeRowIndex--)
                //{
                //    try
                //    {
                //        //Row setzten
                //        currentChangeRow = changes.Tables[0].Rows[changeRowIndex];
                //        //Vergleichsstring aus Changes bauen
                //        string currentChangeRowString = "#";
                //        for (int changeColIndex = 1; changeColIndex <= changes.Tables[0].Columns.Count - 1; changeColIndex++) //row in string (an Col 1)
                //        {
                //            currentChangeRowString = currentChangeRowString + currentChangeRow[changeColIndex].ToString();
                //        }
                //        //Vergleichen
                //        foreach (DataRow dtRow in dt.Rows)
                //        {
                //            //Vergleichsstring aus dt bauen
                //            string currentDTRowString = "#";
                //            for (int dtColIndex = 1; dtColIndex <= dt.Columns.Count - 1; dtColIndex++) //row in string (an Col 1)
                //            {
                //                currentDTRowString = currentDTRowString + dtRow[dtColIndex].ToString();
                //                if (currentChangeRowString == currentDTRowString)
                //                {
                //                    currentChangeRow.Delete();
                //                }
                //            }
                //        }
                //    }
                //    catch { }
                //}
                ////Änderungen in Datenbank übernehmen
                adapter.Update(changes);
            }
        }
    }
}
