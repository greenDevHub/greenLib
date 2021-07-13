using Bibo_Verwaltung.Database;
using MetroFramework.Controls;
using System.Data;

namespace Bibo_Verwaltung
{
    class GenreHelper
    {
        Command c;
        DataTable table;
        public GenreHelper()
        {
            c = new Command(Command.Table.genre);
            table = new DataTable();
        }
        /// <summary>
        /// returns the id of the genre
        /// </summary>
        /// <param name="name"></param>
        /// <returns>the id of the genre; -1 if no genre was found; 0 or greater if one was found</returns>
        public int FindIdByName(string name)
        {
            return c.FindOneByName(name);
        }

        /// <summary>
        /// checks whether a genre already exists in the datatable or not
        /// </summary>
        /// <param name="genreName"></param>
        /// <returns></returns>
        public bool AlreadyContains(string genreName)
        {
            return c.TableAlreadyContains(ref table, genreName);
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
        /// fills a datagridview with all the condition data
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
