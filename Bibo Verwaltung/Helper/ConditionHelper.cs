using Bibo_Verwaltung.Database;
using MetroFramework.Controls;
using System.Data;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class ConditionHelper
    {
        Command c;
        DataTable table;

        public ConditionHelper()
        {
            c = new Command(Command.Table.condition);
            table = new DataTable();
        }

        /// <summary>
        /// searches for a condition entity by its name
        /// </summary>
        /// <param name="conditionName"></param>
        /// <returns>returns the id of the condition</returns>
        public int FindIdByName(string conditionName)
        {
            return c.FindOneByName(conditionName);
        }

        /// <summary>
        /// checks whether a condition already exists in the datatable or not
        /// </summary>
        /// <param name="conditionName"></param>
        /// <returns></returns>
        public bool AlreadyContains(string conditionName)
        {
            return c.TableAlreadyContains(ref table, conditionName);
        }


        /// <summary>
        /// fills a combobox with all the condition data
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="value"></param>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            c.FillCombobox(ref cb, value, ref table);
        }

        /// <summary>
        /// fills a datagridview with all the condition data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            c.FillGrid(ref grid, value, "Bezeichnung", ref table);
        }

        /// <summary>
        /// gets the changes from the gridview
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>true: if something was changed; false: if there are no changes</returns>
        public bool GridViewHasChanges(ref MetroGrid grid)
        {
            return c.GridViewHasChanges(ref grid, ref table);
        }

        /// <summary>
        /// saves the changes of the gridview to database
        /// </summary>
        /// <param name="grid"></param>
        public void SaveChangesToDatabase(ref MetroGrid grid)
        {
            c.SaveGridChangesToDataBase(ref grid, ref table);
        }

        /// <summary>
        /// fills a datagridviewcombobox with all the condition data
        /// </summary>
        /// <returns></returns>
        public DataGridViewComboBoxColumn FillDataGridViewComboBox()
        {
            DataGridViewComboBoxColumn cb = new DataGridViewComboBoxColumn();
            table = new DataTable();
            if (table == null) return cb;
            DataRow relation;
            string[] defaultValue = new string[2];

            defaultValue[0] = "0";
            defaultValue[1] = "--auswählen--";
            if (table.Columns.Count != 2)
            {
                table.Columns.Add();
            }
            relation = table.NewRow();
            relation.ItemArray = defaultValue;
            table.Rows.Add(relation);
            table = c.FillObject();
            cb.HeaderText = "Zustand";
            cb.Name = "cbzustand";
            cb.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            cb.Width = 1500;
            cb.SortMode = DataGridViewColumnSortMode.NotSortable;
            cb.DataSource = table;
            cb.ValueMember = c.FieldId;
            cb.DisplayMember = c.FieldName;
            return cb;
        }
    }
}
