using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Bibo_Verwaltung.Helper
{
    class WebHelper
    {
        public WebHelper()
        {

        }
        #region variables
        string htmlData = "";
        #endregion
        private string GetGenreNeu()
        {
            string str = "";
            try
            {
                string s = "Art des Inhalts";
                if (htmlData.Contains(s))
                {
                    int i = htmlData.IndexOf(s);
                    if (i >= 0)
                    {
                        htmlData = htmlData.Substring(i);
                        s = @"<td";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        s = @">";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        i = htmlData.IndexOf("</td>");
                        str = htmlData.Substring(0, i).Trim();
                        byte[] bytes = Encoding.Default.GetBytes(str);
                        str = Encoding.UTF8.GetString(bytes);
                        str = System.Net.WebUtility.HtmlDecode(str);
                        str = Regex.Replace(str, "<.*?>", " ").Trim();


                    }
                }
                return str;
            }
            catch
            {
                return str;
            }
        }
        private string GetTitelNeu()
        {
            string str = "";
            try
            {
                string s = "<strong>Titel</strong>";
                if (htmlData.Contains(s))
                {
                    int i = htmlData.IndexOf(s) + s.Length;
                    if (i >= 0)
                    {
                        htmlData = htmlData.Substring(i);
                        s = @"<td";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        s = @">";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        i = htmlData.IndexOf("</td>");
                        str = htmlData.Substring(0, i).Trim();
                        byte[] bytes = Encoding.Default.GetBytes(str);
                        str = Encoding.UTF8.GetString(bytes);
                        str = System.Net.WebUtility.HtmlDecode(str);
                        str = Regex.Replace(str, "<.*?>", " ").Trim();
                    }
                }

                return str;
            }
            catch
            {
                return str;
            }
        }
        private List<string> GetAutorNeu()
        {
            List<string> autoren = new List<string>();
            string autor = "";
            try
            {
                string s = "<strong>Person(en)</strong>";
                if (htmlData.Contains(s))
                {
                    int i = htmlData.IndexOf(s) + s.Length;
                    if (i >= 0)
                    {
                        htmlData = htmlData.Substring(i);
                        s = @"<td";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        s = @">";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        string autorenData = htmlData;
                        s = "</td>";
                        i = autorenData.IndexOf(s);
                        autorenData = autorenData.Substring(0, i).Trim();
                        var a = Regex.Split(autorenData, "<.*?>");
                        foreach (string au in a)
                        {
                            if (!au.Equals(""))
                            {
                                autor = au;
                                byte[] bytes = Encoding.Default.GetBytes(autor);
                                autor = Encoding.UTF8.GetString(bytes);
                                autor = System.Net.WebUtility.HtmlDecode(autor);
                                if (autor.Contains("(Verfasser)"))
                                {
                                    int i1 = autor.IndexOf("(");
                                    autor = autor.Substring(0, i1).Trim();
                                    if (autor.Contains(","))
                                    {
                                        string vorname = autor.Substring(autor.IndexOf(", ") + 2);
                                        string nachname = autor.Substring(0, autor.IndexOf(", "));
                                        autor = vorname + " " + nachname;
                                    }
                                    autoren.Add(autor.Replace("[", "(").Replace("]", ")"));
                                }
                            }
                        }
                    }
                }

                return autoren;
            }
            catch
            {
                return autoren;
            }
        }
        private string GetAusgabeNeu()
        {
            string str = "";
            try
            {
                string s = "<strong>Ausgabe</strong>";
                if (htmlData.Contains(s))
                {
                    int i = htmlData.IndexOf(s) + s.Length;
                    if (i >= 0)
                    {
                        htmlData = htmlData.Substring(i);
                        s = "<td";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        s = ">";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        i = htmlData.IndexOf("</td>");
                        str = htmlData.Substring(0, i).Trim();
                        byte[] bytes = Encoding.Default.GetBytes(str);
                        str = Encoding.UTF8.GetString(bytes);
                        str = System.Net.WebUtility.HtmlDecode(str);
                        str = Regex.Replace(str, "<.*?>", " ").Trim();
                    }
                }

                return str;
            }
            catch
            {
                return str;
            }
        }
        private string GetVerlagNeu()
        {
            string str = "";
            try
            {
                string s = "<strong>Verlag</strong>";
                if (htmlData.Contains(s))
                {
                    int i = htmlData.IndexOf(s) + s.Length;
                    if (i >= 0)
                    {
                        htmlData = htmlData.Substring(i);
                        s = "<td";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        s = ">";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        i = htmlData.IndexOf("</td>");
                        str = htmlData.Substring(0, i).Trim();
                        byte[] bytes = Encoding.Default.GetBytes(str);
                        str = Encoding.UTF8.GetString(bytes);
                        str = System.Net.WebUtility.HtmlDecode(str);
                        if (str.Contains(":"))
                        {
                            str = str.Substring(str.IndexOf(":") + 2);
                        }
                        str = Regex.Replace(str, "<.*?>", " ").Trim();

                    }
                }

                return str;
            }
            catch
            {
                return str;
            }
        }
        private string GetDatumNeu()
        {
            string str = "";
            try
            {
                string s = "<strong>Zeitliche Einordnung</strong>";
                if (htmlData.Contains(s))
                {
                    int i = htmlData.IndexOf(s) + s.Length;
                    if (i >= 0)
                    {
                        htmlData = htmlData.Substring(i);
                        s = "<td";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        s = ">";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        i = htmlData.IndexOf("</td>");
                        str = htmlData.Substring(0, i).Trim();
                        byte[] bytes = Encoding.Default.GetBytes(str);
                        str = Encoding.UTF8.GetString(bytes);
                        str = System.Net.WebUtility.HtmlDecode(str);
                        str = str.Replace("Erscheinungsdatum: ", "");
                        str = Regex.Replace(str, "<.*?>", " ").Trim();
                        str = Regex.Replace(str, "[^0-9.]", "").Trim();

                    }
                }

                return str;
            }
            catch
            {
                return str;
            }
        }
        private string GetPreisNeu()
        {
            string str = "";
            try
            {
                string s = "<strong>ISBN/Einband/Preis</strong>";
                if (htmlData.Contains(s))
                {
                    int i = htmlData.IndexOf(s) + s.Length;
                    if (i >= 0)
                    {
                        htmlData = htmlData.Substring(i);
                        s = "<td";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        s = ">";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        i = htmlData.IndexOf("</td>");
                        s = "EUR ";
                        var pattern = @"(EUR )([0-9]+.[0-9]+)( \(DE\))";
                        var pattern2 = @"(EUR )([0-9]+.[0-9]+)";

                        if (Regex.IsMatch(htmlData, pattern))
                        {
                            var matches = Regex.Matches(htmlData, pattern);
                            str = matches[0].Groups[2].Value;
                            byte[] bytes = Encoding.Default.GetBytes(str);
                            str = Encoding.UTF8.GetString(bytes);
                            str = System.Net.WebUtility.HtmlDecode(str);
                            str = Regex.Replace(str, "<.*?>", " ").Trim();
                        }
                        else if (Regex.IsMatch(htmlData, pattern2))
                        {
                            var matches = Regex.Matches(htmlData, pattern2);
                            str = matches[0].Groups[2].Value;
                            byte[] bytes = Encoding.Default.GetBytes(str);
                            str = Encoding.UTF8.GetString(bytes);
                            str = System.Net.WebUtility.HtmlDecode(str);
                            str = Regex.Replace(str, "<.*?>", " ").Trim();
                        }
                        else return str;

                    }
                }

                return str;
            }
            catch
            {
                return str;
            }
        }
        private string GetSpracheNeu()
        {
            string str = "";
            try
            {
                string s = "<strong>Sprache(n)</strong>";
                if (htmlData.Contains(s))
                {
                    int i = htmlData.IndexOf(s) + s.Length;
                    if (i >= 0)
                    {
                        htmlData = htmlData.Substring(i);
                        s = "<td";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        s = ">";
                        i = htmlData.IndexOf(s) + s.Length;
                        htmlData = htmlData.Substring(i);
                        i = htmlData.IndexOf("</td>");
                        str = htmlData.Substring(0, i).Trim();
                        byte[] bytes = Encoding.Default.GetBytes(str);
                        str = Encoding.UTF8.GetString(bytes);
                        str = System.Net.WebUtility.HtmlDecode(str);
                        if (str.Contains("(") && str.Contains(")"))
                        {
                            int i1 = str.IndexOf("(");
                            int i2 = str.IndexOf(")");
                            str = str.Substring(0, i1).Trim();
                        }
                        str = Regex.Replace(str, "<.*?>", " ").Trim();
                    }
                }

                return str;
            }
            catch
            {
                return str;
            }
        }
        public Image GetPictureNeu(string isbn)
        {

            string bildURL = $"https://portal.dnb.de/opac/mvb/cover?isbn={isbn}";
            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            client.Proxy = WebRequest.DefaultWebProxy;
            client.Credentials = CredentialCache.DefaultCredentials;
            client.Proxy.Credentials = CredentialCache.DefaultCredentials;
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
            try
            {
                byte[] imageData = client.DownloadData(bildURL);
                Image image;
                using (var ms = new MemoryStream(imageData))
                {
                    image = Image.FromStream(ms);
                }
                image = ScaleImage(image, 600, 600);
                return image;
            }
            catch
            {
                return null;
            }
        }
        private Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }

        /// <summary>
        /// loads the information of a book from an online source
        /// </summary>
        public Book AutoLoadDNB(string isbn)
        {
            Book book = new Book();
            book.BookIsbn = isbn;
            if (IsbnValidated(isbn))
            {
                htmlData = Regex.Replace(htmlData, @"\t|\n|\r", "");
                htmlData = Regex.Replace(htmlData, "<a href=.*?>", "");
                var genreName = GetGenreNeu().Replace("[", "(").Replace("]", ")");
                if (!genreName.Equals(""))
                {
                    GenreHelper helper = new GenreHelper();
                    Genre genre = new Genre();
                    if (helper.FindIdByName(genreName) < 0)
                    {
                        genre.GenreName = genreName;
                        genre.Add();
                    }
                    genre = new Genre(helper.FindIdByName(genreName));
                    book.BookGenre = genre;
                }

                var titel = GetTitelNeu().Replace("[", "(").Replace("]", ")");
                if (!titel.Equals(""))
                {
                    book.BookTitle = titel;
                }

                var authors = GetAutorNeu();
                foreach (string s in authors)
                {
                    Author author = new Author();
                    AuthorHelper helper = new AuthorHelper();
                    if (helper.FindIdByName(s) < 0)
                    {
                        author.AuthorName = s;
                        author.Add();
                    }
                    author = new Author(helper.FindIdByName(s));
                    book.BookAuthors.Add(author);
                }

                var ausgabe = GetAusgabeNeu().Replace("[", "(").Replace("]", ")");
                if (!ausgabe.Equals(""))
                {
                    book.BookEdition = ausgabe;
                }

                var publisherName = GetVerlagNeu().Replace("[", "(").Replace("]", ")");
                if (!publisherName.Equals(""))
                {
                    PublisherHelper helper = new PublisherHelper();
                    Publisher publisher = new Publisher();
                    if (helper.FindIdByName(publisherName) < 0)
                    {
                        publisher.PublisherName = publisherName;
                        publisher.Add();
                    }
                    publisher = new Publisher(helper.FindIdByName(publisherName));
                    book.BookPublisher = publisher;
                }

                var jahr = GetDatumNeu();
                if (!jahr.Equals(""))
                {
                    try
                    {
                        DateTime date = new DateTime(int.Parse(jahr), 1, 1);
                        book.BookDatePublication = date;
                    }
                    catch
                    {
                        book.BookDatePublication = DateTime.UtcNow;
                    }
                }

                var preis = GetPreisNeu().Replace('.', ',');
                if (!preis.Equals(""))
                {
                    book.BookPrice = decimal.Parse(preis);
                }

                var languageName = GetSpracheNeu().Replace("[", "(").Replace("]", ")");
                if (!languageName.Equals(""))
                {
                    LanguageHelper helper = new LanguageHelper();
                    Language language = new Language();
                    if (helper.FindIdByName(languageName) < 0)
                    {
                        language.LanguageName = languageName;
                        language.Add();
                    }
                    language = new Language(helper.FindIdByName(languageName));
                    book.BookLanguage = language;
                }

                var image = GetPictureNeu(isbn);
                if (image != null)
                {
                    book.BookImage = image;
                }
                return book;
                //MetroMessageBox.Show(this, "Das Buch \"" + tb_Titel.Text + "\" wurde erfolgreich geladen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return book;
                //AutoLoadBuecherNachISBN();
            }


        }
        /// <summary>
        /// checks whether an isbn can be validated or not with internet source
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        private bool IsbnValidated(string isbn)
        {
            Cursor.Current = Cursors.WaitCursor;
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            try
            {
                client.UseDefaultCredentials = true;
                client.Proxy = null;
                client.Credentials = CredentialCache.DefaultCredentials;
                htmlData = client.DownloadString($"https://portal.dnb.de/opac.htm?query={isbn}&method=simpleSearch");
                if (htmlData.Contains("Link zu diesem Datensatz"))
                {
                    return true;
                }
                else
                {
                    htmlData = client.DownloadString("$https://portal.dnb.de/opac.htm?method=showFullRecord&currentResultId={isbn}%26any&currentPosition=0");
                    if (htmlData.Contains("Link zu diesem Datensatz"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
