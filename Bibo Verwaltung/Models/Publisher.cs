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
    class Publisher
    {
        #region attributes
        int publisherId;
        /// <summary>
        /// get/set the id of the publisher
        /// </summary>
        public int PublisherId { get { return publisherId; } set { publisherId = value; } }

        string publisherName;
        /// <summary>
        /// get/set the name of the publisher
        /// </summary>
        public string PublisherName { get { return publisherName; } set { publisherName = value; } }
        #endregion

        #region variables
        Command c = new Command(Command.Table.publisher);
        #endregion

        #region constructor
        /// <summary>
        /// creates an empty publisher object
        /// </summary>
        public Publisher()
        {

        }
        /// <summary>
        /// creates a publisher object with all the data
        /// </summary>
        /// <param name="publisherId"></param>
        public Publisher(int publisherId)
        {
            PublisherId = publisherId;
            LoadPublisher();
        }
        #endregion

        /// <summary>
        /// loads the information of the publisher
        /// </summary>
        private void LoadPublisher()
        {
            c.LoadSmallEntity(ref publisherId, ref publisherName);
        }

        /// <summary>
        /// adds a publisher to database if not exists
        /// </summary>
        public void Add()
        {
            c.AddSmallEntityIfNotExists(PublisherName);
        }
    }
}
