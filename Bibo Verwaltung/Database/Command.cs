using MetroFramework.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung.Database
{
    class Command
    {
        SQL_Verbindung con = new SQL_Verbindung();

        private string _tableName = "";
        /// <summary>
        /// name of the table
        /// </summary>
        public string TableName { get { return _tableName; } set { _tableName = value; } }
        private string _name = "";
        /// <summary>
        /// the name of the 'name' field
        /// </summary>
        public string FieldName { get { return _name; } set { _name = value; } }
        private string _id = "";
        /// <summary>
        /// the name of the 'id' field
        /// </summary>
        public string FieldId { get { return _id; } set { _id = value; } }
        public Command(Table table)
        {
            switch(table)
            {
                case Table.author:
                    TableName = "t_s_autor";
                    FieldName = "au_autor";
                    FieldId = "au_id";
                    break;
                case Table.genre:
                    TableName = "t_s_genre";
                    FieldName = "ger_name";
                    FieldId = "ger_id";
                    break;
                case Table.language:
                    TableName = "t_s_sprache";
                    FieldName = "sprach_name";
                    FieldId = "sprach_id";
                    break;
                case Table.publisher:
                    TableName = "t_s_verlag";
                    FieldName = "ver_name";
                    FieldId = "ver_id";
                    break;
                case Table.condition:
                    TableName = "t_s_zustand";
                    FieldName = "zu_zustand";
                    FieldId = "zu_id";
                    break;
            }
        }

        /// <summary>
        /// adds an author/genre/language/publisher/... to database if it does not exist
        /// </summary>
        public void AddSmallEntityIfNotExists(string value)
        {
            if (con.ConnectError()) return;
            string command = $"begin if not exists (select {FieldName} from {TableName} where {FieldName}={value}) begin insert into {TableName} ({FieldName}) values ({value}) end end";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@0", value);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// searches for one entity with the given name attribute
        /// </summary>
        /// <param name="name"></param>
        /// <returns>returns -1 if nothing was found or equal/greater than 0 if an entity was found</returns>
        public int FindOneByName(string name)
        {
            int id = -1;
            if (con.ConnectError()) return id;
            string command = $"select * from {TableName} where {FieldName} = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, name);
            while (dr.Read())
            {
                id = int.Parse(dr[FieldId].ToString());
            }
            dr.Close();
            con.Close();
            return id;
        }

        /// <summary>
        /// checks wheter a value already exists in a datatable
        /// </summary>
        /// <param name="table"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TableAlreadyContains(ref DataTable table, string value)
        {
            return table.AsEnumerable().Any(row => value.Equals(row.Field<String>(FieldName), StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// fills a table object with data from a small entity
        /// </summary>
        /// <returns>a datatable filled with data</returns>
        public DataTable FillObject()
        {
            DataTable table = new DataTable();
            if (con.ConnectError()) return table;
            string command = $"SELECT * FROM {TableName}";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        public void LoadSmallEntity(ref int id, ref string name)
        {
            if (con.ConnectError()) return;
            string RawCommand = $"SELECT * FROM {TableName} WHERE {FieldId} = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                id = int.Parse(dr[FieldId].ToString());
                name = dr[FieldName].ToString();
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// fills a combobox with data
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="value"></param>
        /// <param name="adapter"></param>
        /// <param name="table"></param>
        public void FillCombobox(ref AdvancedComboBox cb, object value, ref DataTable table)
        {
            if (cb.AutoCompleteSource != AutoCompleteSource.None) cb.AutoCompleteSource = AutoCompleteSource.None;
            table = FillObject();
            if (table == null) return;
            cb.DataSource = table;
            cb.ValueMember = FieldId;
            cb.DisplayMember = FieldName;
            cb.SelectedValue = value;
        }

        /// <summary>
        /// fills a gridview with data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="value"></param>
        /// <param name="headerText"></param>
        /// <param name="adapter"></param>
        /// <param name="table"></param>
        public void FillGrid(ref MetroGrid grid, object value, string headerText, ref DataTable table)
        {
            table = FillObject();
            if (table == null) return;
            grid.DataSource = table;
            grid.Columns[FieldId].Visible = false;
            grid.Columns[FieldName].HeaderText = headerText;
        }

        public void SaveGridChangesToDataBase(ref MetroGrid grid, ref DataTable table)
        {
            if (con.ConnectError()) return;
            DataTable changes = ReturnChanges(ref grid, ref table);
            SqlDataAdapter adapter = new SqlDataAdapter();

            adapter.SelectCommand = new SqlCommand($"SELECT * FROM {TableName}", con.Con);

            SqlCommand insertCmd = new SqlCommand($"INSERT INTO {TableName} ({FieldName}) VALUES (@FieldName)", con.Con);
            insertCmd.Parameters.Add("@FieldName", SqlDbType.NVarChar, 64, FieldName);
            adapter.InsertCommand = insertCmd;

            SqlCommand deleteCmd = new SqlCommand($"DELETE FROM {TableName} WHERE {FieldName} = @FieldName", con.Con);
            deleteCmd.Parameters.Add("@FieldName", SqlDbType.NVarChar, 64, FieldName);
            adapter.DeleteCommand = deleteCmd;

            SqlCommand updateCmd = new SqlCommand($"UPDATE {TableName} SET {FieldName} = @FieldName WHERE {FieldId} = @FieldId", con.Con);
            updateCmd.Parameters.Add("@FieldName", SqlDbType.NVarChar, 64, FieldName);
            updateCmd.Parameters.Add("@FieldId", SqlDbType.Int, 32, FieldId);
            adapter.UpdateCommand = updateCmd;
            if (changes == null) return;
            adapter.Update(changes);
        }

        /// <summary>
        /// returns a datatable with all the changes that will be saved to database
        /// </summary>
        /// <param name="grid"></param>
        private DataTable ReturnChanges(ref MetroGrid grid, ref DataTable table)
        {
            DataTable changes = new DataTable();
            changes = table.GetChanges();
            if (changes != null && changes.Rows.Count>0)
            {
                changes = noDuplicates(changes, table);
            }
            return changes;
        }

        /// <summary>
        /// gets the changes from the gridview
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>true: if something was changed; false: if there are no changes</returns>
        public bool GridViewHasChanges(ref MetroGrid grid, ref DataTable table)
        {
            DataTable changes = table.GetChanges();
            return changes != null;
        }

        /// <summary>
        /// removes duplicates from the changes datatable
        /// </summary>
        /// <param name="changes"></param>
        /// <returns></returns>
        private DataTable noDuplicates(DataTable changes, DataTable table)
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
            catch
            {
                return changes;
            }
        }


        /// <summary>
        /// all small entities
        /// </summary>
        public enum Table
        {
            author,
            genre,
            language,
            publisher,
            condition
        }
    }
}
