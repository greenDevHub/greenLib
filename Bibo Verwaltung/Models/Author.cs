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
using Bibo_Verwaltung.Database;

namespace Bibo_Verwaltung
{
    class Author
    {
        #region attributes
        int authorId;
        /// <summary>
        /// get/set the Id of an author
        /// </summary>
        public int AuthorId { get { return authorId; } set { authorId = value; } }

        string authorName;
        /// <summary>
        /// get/set the name of an author
        /// </summary>
        public string AuthorName { get { return authorName; } set { authorName = value; } }
        #endregion

        #region variables
        Command c = new Command(Command.Table.author);
        #endregion

        #region constructor
        /// <summary>
        /// create an empty author object
        /// </summary>
        public Author()
        {
        }
        /// <summary>
        /// create an author object with all the data
        /// </summary>
        /// <param name="authorId"></param>
        public Author(int authorId)
        {
            AuthorId = authorId;
            LoadAutor();
        }
        #endregion

        /// <summary>
        /// loads the information of the author
        /// </summary>
        private void LoadAutor()
        {
            c.LoadSmallEntity(ref authorId, ref authorName);
        }

        /// <summary>
        /// adds an author to the database
        /// </summary>
        public void Add()
        {
            c.AddSmallEntityIfNotExists(AuthorName);
        }
    }
}
