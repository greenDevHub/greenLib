using Bibo_Verwaltung.Database;
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

namespace Bibo_Verwaltung
{
    class PublisherHelper
    {
        Command c;
        DataTable table;

        public PublisherHelper()
        {
            c = new Command(Command.Table.publisher);
            table = new DataTable();
        }

        /// <summary>
        /// returns the id of the publisher
        /// </summary>
        /// <param name="name"></param>
        /// <returns>the id of the publisher; -1 if no publisher was found; 0 or greater if one was found</returns>
        public int FindIdByName(string publisherName)
        {
            return c.FindOneByName(publisherName);
        }
        
        /// <summary>
        /// checks whether a publisher already exists in the datatable or not
        /// </summary>
        /// <param name="publisherName"></param>
        /// <returns></returns>
        public bool AlreadyContains(string publisherName)
        {
            return c.TableAlreadyContains(ref table, publisherName);
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
        /// fills a datagridview with all the publisher data
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
