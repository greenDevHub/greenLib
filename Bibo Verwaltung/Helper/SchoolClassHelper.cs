using Bibo_Verwaltung.Database;
using MetroFramework.Controls;
using System.Data;
using System.Windows.Forms;

namespace Bibo_Verwaltung.Helper
{
    class SchoolClassHelper
    {
        Command c;
        DataTable table;
        public SchoolClassHelper()
        {
            c = new Command(Command.Table.schoolClass);
            table = new DataTable();
        }

        /// <summary>
        /// returns the id of a class by its name
        /// </summary>
        /// <param name="schoolClassName"></param>
        /// <returns>returns -1 if no class was found; returns >=0 if a class was found</returns>
        public int FindIdByName(string schoolClassName)
        {
            return c.FindOneByName(schoolClassName);
        }

        /// <summary>
        /// checks whether a school class already exists in the datatable or not
        /// </summary>
        /// <param name="schoolClassName"></param>
        /// <returns></returns>
        public bool AlreadyContains(string schoolClassName)
        {
            return c.TableAlreadyContains(ref table, schoolClassName);
        }
        //private bool AlreadyExists(string klassename)
        //{
        //    if (con.ConnectError()) return false;
        //    string RawCommand = "SELECT k_id from [dbo].[t_s_klassen] where k_bezeichnung=@0";
        //    SqlDataReader dr = con.ExcecuteCommand(RawCommand, klassename);
        //    dr.Read();
        //    if (dr.HasRows)
        //    {
        //        dr.Close();
        //        con.Close();
        //        return true;
        //    }
        //    else
        //    {
        //        dr.Close();
        //        con.Close();
        //        return false;
        //    }
        //}

        /// <summary>
        /// fills a combobox with data
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="value"></param>
        public void FillCombobox(ref AdvancedComboBox cb, object value, AutoCompleteSource autoCompleteSource = AutoCompleteSource.None)
        {
            c.FillCombobox(ref cb, value, ref table, autoCompleteSource);
            cb.SelectedValue = value;
        }

        /// <summary>
        /// fills a datagridview with all the school class data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            c.FillGrid(ref grid, value, "Name", ref table);
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
        /// checks whether the gridview has changes or not
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>true: if something was changed; false: if there are no changes</returns>
        public bool GridViewHasChanges(ref MetroGrid grid)
        {
            return c.GridViewHasChanges(ref grid, ref table);
        }
    }
}
