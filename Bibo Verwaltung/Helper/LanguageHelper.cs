using Bibo_Verwaltung.Database;
using MetroFramework.Controls;
using System.Data;

namespace Bibo_Verwaltung
{
    class LanguageHelper
    {
        Command c;
        DataTable table;
        public LanguageHelper()
        {
            c = new Command(Command.Table.language);
            table = new DataTable();
        }

        /// <summary>
        /// returns the id of the language
        /// </summary>
        /// <param name="name"></param>
        /// <returns>the id of the language; -1 if no language was found; 0 or greater if one was found</returns>
        public int FindIdByName(string languageName)
        {
            return c.FindOneByName(languageName);
        }

        /// <summary>
        /// checks whether a language already exists in the datatable or not
        /// </summary>
        /// <param name="languageName"></param>
        /// <returns></returns>
        public bool AlreadyContains(string languageName)
        {
            return c.TableAlreadyContains(ref table, languageName);
        }

        /// <summary>
        /// fills a combobox with data
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="value"></param>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            c.FillCombobox(ref cb, value, ref table);
        }

        /// <summary>
        /// fills a datagridview with all the language data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            c.FillGrid(ref grid, value, "Bezeichnung", ref table);
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
        /// gets the changes from the gridview
        /// </summary>
        /// <param name="grid"></param>
        /// <returns>true: if something was changed; false: if there are no changes</returns>
        public bool GridViewHasChanges(ref MetroGrid grid)
        {
            return c.GridViewHasChanges(ref grid, ref table);
        }
    }
}
