using Bibo_Verwaltung.Helper;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Grade
    {
        SchoolClassHelper schoolClassHelper = new SchoolClassHelper();


        string gradeName;
        public string GradeName { get { return gradeName; } set { gradeName = value; } }

        /// <summary>
        /// creates an empty grade object
        /// </summary>
        public Grade()
        {

        }
    }
}
