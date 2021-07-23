using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Bibo_Verwaltung
{
    class Book
    {
        #region attributes
        string bookIsbn;
        /// <summary>
        /// get/set the isbn of a book
        /// </summary>
        public string BookIsbn { get { return bookIsbn; } set { bookIsbn = value; } }

        string bookTitle;
        /// <summary>
        /// get/set the title of a book
        /// </summary>
        public string BookTitle { get { return bookTitle; } set { bookTitle = value; } }

        Genre bookGenre = new Genre();
        /// <summary>
        /// get/set the genre of a book
        /// </summary>
        public Genre BookGenre { get { return bookGenre; } set { bookGenre = value; } }

        Publisher bookPublisher = new Publisher();
        /// <summary>
        /// get/set the publisher of a book
        /// </summary>
        public Publisher BookPublisher { get { return bookPublisher; } set { bookPublisher = value; } }

        List<Author> bookAuthors = new List<Author>();
        /// <summary>
        /// get/set the authors of a book
        /// </summary>
        public List<Author> BookAuthors { get { return bookAuthors; } set { bookAuthors = value; } }

        Language bookLanguage = new Language();
        /// <summary>
        /// get/set the language of a book
        /// </summary>
        public Language BookLanguage { get { return bookLanguage; } set { bookLanguage = value; } }

        string bookEdition;
        /// <summary>
        /// get/set the edition of a book
        /// </summary>
        public string BookEdition { get { return bookEdition; } set { bookEdition = value; } }

        DateTime bookDatePublication;
        /// <summary>
        /// get/set the publication date of a book
        /// </summary>
        public DateTime BookDatePublication { get { return bookDatePublication; } set { bookDatePublication = value; } }

        decimal bookPrice;
        /// <summary>
        /// get/set the price of a new book
        /// </summary>
        public decimal BookPrice { get { return bookPrice; } set { bookPrice = value; } }

        Image bookImage;
        /// <summary>
        /// get/set the image of a book
        /// </summary>
        public Image BookImage { get { return bookImage; } set { bookImage = value; } }

        bool bookActivated;
        /// <summary>
        /// get/set the activation status of a book
        /// </summary>
        public bool BookActivated { get { return bookActivated; } set { bookActivated = value; } }

        #endregion

        CopyHelper copyHelper = new CopyHelper();

        #region constructor
        /// <summary>
        /// create an empty book object
        /// </summary>
        public Book()
        {

        }

        /// <summary>
        /// creates a book object with either all the information or only title
        /// </summary>
        /// <param name="isbn">the isbn of a book</param>
        /// <param name="shortLoad">true: only title will be filled; false: all attributes will be filled</param>
        public Book(string bookIsbn, bool shortLoad)
        {
            this.bookIsbn = bookIsbn;
            if (shortLoad) LoadBookShort();
            else LoadBook();
        }
        #endregion

        /// <summary>
        /// only loads the title of the book
        /// </summary>
        private void LoadBookShort()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "SELECT buch_isbn, buch_titel FROM [dbo].[t_s_buecher] WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, bookIsbn);
            while (dr.Read())
            {
                BookIsbn = dr["buch_isbn"].ToString();
                BookTitle = dr["buch_titel"].ToString();
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// already exists in disabled mode
        /// </summary>
        private bool BookAlreadyExistsDisabled()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return false;
            string command = "SELECT buch_isbn, buch_titel, buch_activated FROM [dbo].[t_s_buecher] WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, BookIsbn);
            while (dr.Read())
            {
                return true;
            }
            dr.Close();
            con.Close();
            return false;
        }


        /// <summary>
        /// loads all the book information
        /// </summary>
        private void LoadBook()
        {
            LoadBookAuthors();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "SELECT *, isnull(buch_erscheinungsdatum, '01.01.1990') as 'verified_erscheinungsdatum' " +
                "FROM [dbo].[t_s_buecher] left join [dbo].[t_s_genre] on buch_genre_id = ger_id " +
                "left join [dbo].[t_s_verlag] on buch_verlag_id = ver_id left join [dbo].[t_s_sprache] on buch_sprache_id = sprach_id " +
                "WHERE buch_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, bookIsbn);
            while (dr.Read())
            {
                BookIsbn = dr["buch_isbn"].ToString();
                BookTitle = dr["buch_titel"].ToString();
                BookGenre = new Genre(int.Parse(dr["buch_genre_id"].ToString()));
                BookPublisher = new Publisher(int.Parse(dr["buch_verlag_id"].ToString()));
                BookDatePublication = (DateTime)dr["verified_erscheinungsdatum"];
                BookLanguage = new Language(int.Parse(dr["buch_sprache_id"].ToString()));
                BookEdition = dr["buch_auflage"].ToString();
                if (dr["buch_image"] != null && dr["buch_image"].ToString() != "")
                {
                    using (var ms = new MemoryStream((byte[])(dr["buch_image"])))
                    {
                        BookImage = Image.FromStream(ms);
                    }
                }
                BookPrice = Convert.ToDecimal(dr["buch_neupreis"].ToString().Replace(".", ","));
                bookActivated = dr["buch_activated"].ToString().Equals("1");
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// loads all the authors of a book
        /// </summary>
        private void LoadBookAuthors()
        {
            BookAuthors.Clear();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "SELECT * FROM [dbo].[t_s_buch_autor] WHERE  ba_isbn = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, BookIsbn);
            while (dr.Read())
            {
                Author author = new Author(int.Parse(dr["ba_autorid"].ToString()));
                BookAuthors.Add(author);
            }
            dr.Close();
        }

        /// <summary>
        /// loads the book information by a given id of one of its copies
        /// </summary>
        /// <param name="copyId"></param>
        public void LoadBookByCopyId(int copyId)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "SELECT bu_isbn FROM [dbo].[t_s_buchid] WHERE bu_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, copyId);
            while (dr.Read())
            {
                BookIsbn = dr["bu_isbn"].ToString();
            }
            LoadBook();
        }

        /// <summary>
        /// updates the book
        /// </summary>
        public void Update()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            DeleteBookAuthors();
            string command = "UPDATE [dbo].[t_s_buecher] set buch_titel = @bookTitle , buch_genre_id = @bookGenreId, " +
                "buch_sprache_id = @bookLanguageId, buch_verlag_id = @bookPublisherId, buch_auflage = @bookEdition, " +
                "buch_erscheinungsdatum = @bookDatePublication, buch_neupreis = @bookPrice, " +
                "buch_image = @bookImage WHERE buch_isbn = @bookIsbn";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@bookTitle", BookTitle);
            cmd.Parameters.AddWithValue("@bookGenreId", BookGenre.GenreId);
            cmd.Parameters.AddWithValue("@bookLanguageId", BookLanguage.LanguageId);
            cmd.Parameters.AddWithValue("@bookPublisherId", BookPublisher.PublisherId);
            if (BookEdition == null || BookEdition.Equals(""))
            {
                cmd.Parameters.AddWithValue("@bookEdition", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@bookEdition", BookEdition);
            }
            cmd.Parameters.AddWithValue("@bookDatePublication", BookDatePublication);

            cmd.Parameters.AddWithValue("@bookPrice", BookPrice);
            cmd.Parameters.Add("@bookImage", SqlDbType.VarBinary, -1);
            if (BookImage == null)
            {
                cmd.Parameters["@bookImage"].Value = DBNull.Value;
            }
            else
            {
                using (var ms = new MemoryStream())
                {
                    BookImage.Save(ms, ImageFormat.Png);
                    cmd.Parameters["@bookImage"].Value = ms.ToArray();
                }
            }
            cmd.Parameters.AddWithValue("@bookIsbn", BookIsbn);
            cmd.ExecuteNonQuery();
            AddBookAuthors();
            con.Close();
        }

        /// <summary>
        /// adds all the authors from the author list to the book
        /// </summary>
        private void AddBookAuthors()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            con.ConnectError();
            string command = "INSERT INTO [dbo].[t_s_buch_autor] (ba_isbn, ba_autorid) VALUES (@bookIsbn, @bookAuthor)";
            foreach (Author author in BookAuthors)
            {
                SqlCommand cmd = new SqlCommand(command, con.Con);
                cmd.Parameters.AddWithValue("@bookIsbn", BookIsbn);
                cmd.Parameters.AddWithValue("@bookAuthor", author.AuthorId);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// adds the book object to database
        /// </summary>
        public void Add()
        {
            if (BookAlreadyExistsDisabled())
            {
                this.Activate();
                this.Update();
                return;
            }
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "INSERT INTO [dbo].[t_s_buecher] (buch_isbn, buch_titel, buch_genre_id, " +
                "buch_verlag_id, buch_erscheinungsdatum, buch_sprache_id, buch_auflage, buch_neupreis, " +
                "buch_image, buch_activated, buch_anzahl) VALUES " +
                "(@bookIsbn, @bookTitle, @bookGenreId, @bookPublisherId, @bookDatePublication, @bookLanguageId, @bookEdition, " +
                "@bookPrice, @bookImage, 1, 0)";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@bookIsbn", BookIsbn);
            cmd.Parameters.AddWithValue("@bookTitle", BookTitle);
            cmd.Parameters.AddWithValue("@bookGenreId", BookGenre.GenreId);
            cmd.Parameters.AddWithValue("@bookPublisherId", BookPublisher.PublisherId);
            cmd.Parameters.AddWithValue("@bookLanguageId", BookLanguage.LanguageId);
            cmd.Parameters.AddWithValue("@bookDatePublication", BookDatePublication);
            if (BookEdition == null)
            {
                cmd.Parameters.AddWithValue("@bookEdition", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@bookEdition", BookEdition);
            }
            cmd.Parameters.AddWithValue("@bookPrice", BookPrice);
            cmd.Parameters.Add("@bookImage", SqlDbType.VarBinary, -1);
            if (BookImage == null)
            {
                cmd.Parameters["@bookImage"].Value = DBNull.Value;
            }
            else
            {
                using (var ms = new MemoryStream())
                {
                    BookImage.Save(ms, ImageFormat.Png);
                    cmd.Parameters["@bookImage"].Value = ms.ToArray();
                }
            }
            cmd.ExecuteNonQuery();
            AddBookAuthors();
            con.Close();
        }

        /// <summary>
        /// deletes the book from database 
        /// </summary>
        public void Delete()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            DeleteBookAuthors();
            string command = "DELETE FROM [dbo].[t_s_buecher] WHERE buch_isbn = @bookIsbn";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@bookIsbn", BookIsbn);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// deletes the authors of an book
        /// </summary>
        private void DeleteBookAuthors()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            con.ConnectError();
            string command = "DELETE FROM [dbo].[t_s_buch_autor] WHERE ba_isbn = @bookIsbn";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@bookIsbn", BookIsbn);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// deactivates the book
        /// </summary>
        public void Deactivate()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "UPDATE [dbo].[t_s_buecher] set buch_activated = 0 WHERE buch_isbn = @bookIsbn";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@bookIsbn", BookIsbn);
            cmd.ExecuteNonQuery();
            con.Close();
            DeactivateCopies();
        }

        /// <summary>
        /// activates the book
        /// </summary>
        private void Activate()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "UPDATE [dbo].[t_s_buecher] set buch_activated = 1 WHERE buch_isbn = @bookIsbn";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@bookIsbn", BookIsbn);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// checks whether the copies of the book are available to deactivate them or not
        /// </summary>
        /// <returns>true if available; false if unavailable</returns>
        public bool AreCopiesAvailable()
        {
            return copyHelper.AreCopiesAvailable(BookIsbn);
        }

        /// <summary>
        /// deactivates all the copies of the book
        /// </summary>
        private void DeactivateCopies()
        {
            copyHelper.DeactivateByBookIsbn(BookIsbn);
        }

        /// <summary>
        /// the number of copies of a book that are already printed
        /// </summary>
        /// <returns>integer</returns>
        public int NumberOfPrintedCopies()
        {
            return copyHelper.GetNumberOfPrinted(BookIsbn);
        }

        /// <summary>
        /// returns a list of unprinted copies of a book
        /// </summary>
        /// <returns></returns>
        public List<Copy> UnprintedCopies()
        {
            return copyHelper.GetUnprintedCopies(BookIsbn); ;
        }
    }
}
