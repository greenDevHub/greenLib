using Bibo_Verwaltung.Database;
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
    class AuthorHelper
    {
        Command c;
        DataTable table;
        SqlDataAdapter adapter;
        public AuthorHelper()
        {
            c = new Command(Command.Table.author);
            table = new DataTable();
        }

        /// <summary>
        /// returns the id of the author
        /// </summary>
        /// <param name="name"></param>
        /// <returns>the id of the author; -1 if no author was found; 0 or greater if one was found</returns>
        public int FindIdByName(string authorName)
        {
            return c.FindOneByName(authorName);
        }

        /// <summary>
        /// checks whether a author already exists in the datatable or not
        /// </summary>
        /// <param name="authorName"></param>
        /// <returns></returns>
        public bool AlreadyContains(string authorName)
        {
            return c.TableAlreadyContains(ref table, authorName);
        }

        /// <summary>
        /// fills a combobox with data
        /// </summary>
        /// <param name="cb"></param>
        /// <param name="value"></param>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            c.FillCombobox(ref cb, value, ref adapter, ref table);
        }

        /// <summary>
        /// fills a datagridview with all the author data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            c.FillGrid(ref grid, value, "Name", ref adapter, ref table);
        }

        /// <summary>
        /// saves the changes of the gridview to database
        /// </summary>
        /// <param name="grid"></param>
        public void SaveChangesToDatabase(ref MetroGrid grid)
        {
            c.SaveGridChangesToDataBase(ref grid, ref table, ref adapter);
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
        /// fills a listbox with author data
        /// </summary>
        /// <param name="clb"></param>
        public void FillList(ref AdvancedCheckedListBox clb)
        {
            DataTable table = c.FillObject(ref adapter);
            ((ListBox)clb).DataSource = table;
            ((ListBox)clb).DisplayMember = c.FieldName;
            ((ListBox)clb).ValueMember = c.FieldId;
        }

        /// <summary>
        /// adds a list of authors to database
        /// </summary>
        /// <param name="authors"></param>
        public void AddMultipleAuthors(List<Author> authors)
        {
            foreach(Author author in authors)
            {
                author.Add();
            }
        }
    }
}
