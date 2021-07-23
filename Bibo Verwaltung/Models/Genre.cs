using Bibo_Verwaltung.Database;

namespace Bibo_Verwaltung
{
    class Genre
    {
        #region attributes
        int genreId;
        /// <summary>
        /// get/set the id of a genre
        /// </summary>
        public int GenreId { get { return genreId; } set { genreId = value; } }

        string genreName;
        /// <summary>
        /// get/set the name of a genre
        /// </summary>
        public string GenreName { get { return genreName; } set { genreName = value; } }
        #endregion

        #region variables
        Command c = new Command(Command.Table.genre);

        #endregion

        #region constructor
        /// <summary>
        /// creates an empty genre objet
        /// </summary>
        public Genre()
        {

        }
        /// <summary>
        /// creates a genre object with all the data
        /// </summary>
        /// <param name="genreId"></param>
        public Genre(int genreId)
        {
            GenreId = genreId;
            LoadGenre();
        }
        #endregion

        /// <summary>
        /// loads the information of the genre
        /// </summary>
        public void LoadGenre()
        {
            c.LoadSmallEntity(ref genreId, ref genreName);
        }

        /// <summary>
        /// adds a genre to database if not exists
        /// </summary>
        public void Add()
        {
            c.AddSmallEntityIfNotExists(GenreName);
        }
    }
}
