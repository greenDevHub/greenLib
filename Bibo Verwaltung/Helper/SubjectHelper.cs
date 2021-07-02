using MetroFramework.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung.Helper
{
    class SubjectHelper
    {
        DataTable table;
        public SubjectHelper()
        {
            table = new DataTable();
        }
        /// <summary>
        /// checks whether a subject with the given short name already exists or not
        /// </summary>
        /// <returns></returns>
        /// <param name="subjectNameShort">the short name of a subject</param>
        public bool SubjectExists(string subjectNameShort)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            int subjectId = -1;
            if (con.ConnectError()) return true;
            string RawCommand = "SELECT f_id FROM t_s_faecher WHERE f_kurzform = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, subjectNameShort);
            while (dr.Read())
            {
                subjectId = int.Parse(dr["f_id"].ToString());
            }
            dr.Close();
            con.Close();
            return subjectId > -1 ? true : false;
        }

        /// <summary>
        /// returns the id of a subject by its short name
        /// </summary>
        /// <param name="subjectNameShort"></param>
        /// <returns>returns -1 if no subject was found; returns >=0 if a subject was found</returns>
        public int GetIdBySubjectShortName(string subjectNameShort)
        {
            int subjectId = -1;
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return subjectId;
            string command = "SELECT f_id FROM [dbo].[t_s_faecher] WHERE f_kurzform = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, subjectNameShort);
            while (dr.Read())
            {
                subjectId = int.Parse(dr["f_id"].ToString());
            }
            dr.Close();
            con.Close();
            return subjectId;
        }

        /// <summary>
        /// fills a datatable with information
        /// </summary>
        private DataTable FillObject()
        {
            table = new DataTable();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return table;
            string command = "SELECT f_id as 'ID', f_kurzform as 'Kürzel', f_langform as 'Langbezeichnung' FROM t_s_faecher";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// returns a datatable with all the data
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable()
        {
            return FillObject();
        }

        /// <summary>
        /// fills a datagridview with the subject data
        /// </summary>
        /// <param name="grid">the refering gridview</param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroFramework.Controls.MetroGrid grid, object value = null)
        {
            table = FillObject();
            grid.DataSource = table;
            grid.Columns["ID"].Visible = false;
        }

        /// <summary>
        /// fills a combobox with the subject data
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="value"></param>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            table = FillObject();
            cb.DataSource = table;
            cb.ValueMember = "ID";
            cb.DisplayMember = "Kürzel";
            cb.SelectedValue = value;
        }

        /// <summary>
        /// checks whether the gridview has changes or not
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        public bool GridViewHasChanges(ref MetroGrid grid)
        {
            DataTable changes = table.GetChanges();
            return changes != null;
        }

        /// <summary>
        /// removes duplicates of a datatable
        /// </summary>
        /// <param name="changes"></param>
        /// <returns></returns>
        private DataTable noDuplicates(DataTable changes)
        {
            try
            {
                Hashtable hTable = new Hashtable();
                ArrayList duplicateList = new ArrayList();

                //1. Die Changes-Tabelle auf duplikate überprüfen (mehrfache eingabe des selben Wertes)
                foreach (DataRow drow in changes.Rows)
                {
                    if (hTable.Contains(drow[1]))
                    {
                        duplicateList.Add(drow);
                    }
                    else
                    {
                        hTable.Add(drow[1], string.Empty);
                    }
                }
                //Entfernen der Duplikate von 1.
                foreach (DataRow dRow in duplicateList)
                {
                    changes.Rows.Remove(dRow);
                }

                //2. Die Ausgangsdaten auf die Werte überprüfen, die in den Changes sind
                duplicateList.Clear();
                var s = table.Rows;
                for (int i = 0; i < changes.Rows.Count; i++)
                {
                    string str = changes.Rows[i][1].ToString();
                    bool contains = table.AsEnumerable().Any(row => row.RowState == DataRowState.Unchanged && str.Equals(row.Field<String>(1), StringComparison.InvariantCultureIgnoreCase));
                    if (contains)
                    {
                        duplicateList.Add(changes.Rows[i]);
                    }
                }
                //Entfernen der Duplikate von 2.
                foreach (DataRow dRow in duplicateList)
                {
                    changes.Rows.Remove(dRow);
                }
                return changes;
            }
            catch (Exception ex)
            {
                return changes;
            }
        }

        /// <summary>
        /// saves the changes of a grid to database
        /// </summary>
        /// <param name="grid"></param>
        public void SaveGridChangesToDatabase(ref MetroFramework.Controls.MetroGrid grid)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            DataTable changes = table.GetChanges();

            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand($"SELECT * FROM t_s_faecher", con.Con);

            SqlCommand insertCmd = new SqlCommand($"INSERT INTO t_s_faecher (f_kurzform, f_langform) VALUES (@subjectNameShort, @subjectNameLong)", con.Con);
            insertCmd.Parameters.Add("@subjectNameShort", SqlDbType.NVarChar, 64, "Kürzel");
            insertCmd.Parameters.Add("@subjectNameLong", SqlDbType.NVarChar, 256, "Langbezeichnung");

            adapter.InsertCommand = insertCmd;

            SqlCommand deleteCmd = new SqlCommand($"DELETE FROM t_s_faecher WHERE f_kurzform = @subjectNameShort", con.Con);
            deleteCmd.Parameters.Add("@subjectNameShort", SqlDbType.NVarChar, 64, "Kürzel");
            adapter.DeleteCommand = deleteCmd;

            SqlCommand updateCmd = new SqlCommand($"UPDATE t_s_faecher SET f_kurzform = @subjectNameShort, f_langform = @subjectNameLong WHERE f_id = @subjectId", con.Con);
            updateCmd.Parameters.Add("@subjectNameShort", SqlDbType.NVarChar, 64, "Kürzel");
            updateCmd.Parameters.Add("@subjectNameLong", SqlDbType.NVarChar, 256, "Langbezeichnung");
            updateCmd.Parameters.Add("@subjectId", SqlDbType.Int, 32, "ID");
            adapter.UpdateCommand = updateCmd;

            if (changes != null)
            {
                changes = noDuplicates(changes);
                adapter.Update(changes);
            }
        }
    }
}
