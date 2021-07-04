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
    class SchoolClass
    {
        #region attributes
        int schoolClassId;
        /// <summary>
        /// get/set the id of a class
        /// </summary>
        public int SchoolClassId { get { return schoolClassId; } set { schoolClassId = value; } }

        string schoolClassName;
        /// <summary>
        /// get/set the name of a class
        /// </summary>
        public string SchoolClassName { get { return schoolClassName; } set { schoolClassName = value; } }
        #endregion

        #region variables
        Command c = new Command(Command.Table.schoolClass);
        #endregion
        #region constructor
        /// <summary>
        /// creates an empty class object
        /// </summary>
        public SchoolClass()
        {

        }
        /// <summary>
        /// creates a class object with all the class data
        /// </summary>
        /// <param name="schoolClassId"></param>
        public SchoolClass(int schoolClassId)
        {
            LoadSchoolClass();
        }
        #endregion

        /// <summary>
        /// loads the information of the school class
        /// </summary>
        public void LoadSchoolClass()
        {
            c.LoadSmallEntity(ref schoolClassId, ref schoolClassName);
        }

        /// <summary>
        /// adds a school class to database if not exists
        /// </summary>
        public void Add()
        {
            c.AddSmallEntityIfNotExists(SchoolClassName);
        }
    }
}
