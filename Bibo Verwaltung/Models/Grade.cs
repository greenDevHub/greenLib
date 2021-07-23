using Bibo_Verwaltung.Helper;

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
