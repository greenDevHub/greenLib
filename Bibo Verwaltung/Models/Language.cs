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
    class Language
    {
        #region attributes
        int languageId;
        /// <summary>
        /// get/set the id of a language
        /// </summary>
        public int LanguageId { get { return languageId; } set { languageId = value; } }

        string languageName;
        /// <summary>
        /// get/set the name of a language
        /// </summary>
        public string LanguageName { get { return languageName; } set { languageName = value; } }
        #endregion

        #region variables
        Command c = new Command(Command.Table.language);
        #endregion

        #region constructor

        /// <summary>
        /// creates an empty language object
        /// </summary>
        public Language()
        {

        }
        public Language(int languageId)
        {
            LanguageId = languageId;
            LoadSprache();
        }
        #endregion

        /// <summary>
        /// loads the information of the language
        /// </summary>
        private void LoadSprache()
        {
            c.LoadSmallEntity(ref languageId, ref languageName);
        }

        /// <summary>
        /// adds a language to database if not exists
        /// </summary>
        public void Add()
        {
            c.AddSmallEntityIfNotExists(LanguageName);
        }
    }
}

