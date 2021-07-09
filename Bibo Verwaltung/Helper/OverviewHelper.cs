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
    class OverviewHelper
    {

        #region constructor
        /// <summary>
        /// creates an instance of the overviewHelper
        /// </summary>
        public OverviewHelper()
        {
            table = FillObject();
        }
        #endregion

        AuthorHelper authorHelper = new AuthorHelper();
        PublisherHelper publisherHelper = new PublisherHelper();
        GenreHelper genreHelper = new GenreHelper();

        DataTable table = new DataTable();

        Protokoll log = new Protokoll();

        DateTime dt = new DateTime();
        DateTime now = new DateTime();

        /// <summary>
        /// fills a datatable with all necessary information
        /// </summary>
        /// <returns></returns>
        private DataTable FillObject()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            DataTable table = new DataTable();
            if (con.ConnectError()) return table;
            string RawCommand = "SELECT bu_id as 'ExemplarID', bu_isbn as 'ISBN', aus_rückgabedatum as 'Rückgabedatum', " +
                "buch_titel as 'Titel', kunde_id as 'Kunden ID', kunde_vorname as 'Vorname', kunde_Nachname as 'Nachname', " +
                "k_Bezeichnung as 'Klasse', stuff(( SELECT distinct ', '+ cast(au_autor as varchar(512)) FROM t_s_buch_autor " +
                "left join t_s_autor on au_id = ba_autorid where ba_isbn = buch_isbn FOR XML PATH('')),1,1,'') as 'Autor', ger_name as 'Genre', " +
                "ver_name as 'Verlag', sprach_name as 'Sprache', zu_zustand as 'Zustand', aus_leihnummer as 'Leihnummer' FROM t_s_buchid " +
                "left join t_s_buecher on bu_isbn = buch_isbn left join t_s_genre on buch_genre_id = ger_id left join t_s_verlag on " +
                "buch_verlag_id = ver_id left join t_s_sprache on buch_sprache_id = sprach_id left join t_s_zustand on bu_zustandsid = zu_id " +
                "left join t_bd_ausgeliehen on aus_buchid = bu_id left join t_s_kunden on kunde_ID = aus_kundenid left join t_s_klassen on " +
                "kunde_klasse = k_id WHERE bu_activated = 1";
            SqlDataAdapter adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        
        /// <summary>
        /// fills a gridview with the necessary data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            table.DefaultView.Sort = "Rückgabedatum desc";
            grid.DataSource = table;
            HideCostumerInformation(ref grid);
        }

        /// <summary>
        /// Füllt die ComboBoxen Autor, Verlag und Genre
        /// </summary>
        public void FillComboBoxes(ref AdvancedComboBox cbAuthor, ref AdvancedComboBox cbPublisher, ref AdvancedComboBox cbGenre)
        {
            authorHelper.FillCombobox(ref cbAuthor, -1);
            publisherHelper.FillCombobox(ref cbPublisher, -1);
            genreHelper.FillCombobox(ref cbGenre, -1);
            if (cbAuthor.Text == "")
            {
                cbAuthor.Text = "Autor";
            }
            if (cbPublisher.Text == "")
            {
                cbPublisher.Text = "Verlag";
            }
            if (cbGenre.Text == "")
            {
                cbGenre.Text = "Genre";
            }
        }

        /// <summary>
        /// shows the information of the costumers
        /// </summary>
        /// <param name="grid"></param>
        public void ShowCostumerInformation(ref MetroGrid grid)
        {
            try
            {
                grid.Columns["Vorname"].Visible = true;
                grid.Columns["Nachname"].Visible = true;
                grid.Columns["Klasse"].Visible = true;
                grid.Columns["Kunden ID"].Visible = false;
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// hides the information of the costumers
        /// </summary>
        /// <param name="grid"></param>
        public void HideCostumerInformation(ref MetroGrid grid)
        {
            try
            {
                if (grid.Columns.Count==0) return;
                grid.Columns["Kunden ID"].Visible = false;
                grid.Columns["Vorname"].Visible = false;
                grid.Columns["Nachname"].Visible = false;
                grid.Columns["Klasse"].Visible = false;
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// only shows not overdue copies
        /// </summary>
        /// <param name="grid"></param>
        public void ShowGreenCopies(ref MetroGrid grid)
        {
            try
            {
                table.DefaultView.RowFilter = table.DefaultView.RowFilter + string.Format(" AND Rückgabedatum > '#{0}#'", DateTime.Now.Date);
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// only shows copies that are overdue
        /// </summary>
        /// <param name="grid"></param>
        public void ShowRedCopies(ref MetroGrid grid)
        {
            try
            {
                table.DefaultView.RowFilter = table.DefaultView.RowFilter + string.Format(" AND Rückgabedatum < '#{0}#' AND Rückgabedatum <> '#{1}#'", DateTime.Now.Date, DateTime.MinValue.Date);
                grid.Refresh();
                //dataTable.DefaultView.RowFilter = "ExemplarID LIKE '%' AND ISBN LIKE '%' AND Titel LIKE '%%' AND Verlag LIKE '%%' AND Genre LIKE '%%' AND Autor LIKE '%%' AND ExemplarID IS NOT NULL";
                //dataTable.DefaultView.RowFilter = dataTable.DefaultView.RowFilter + string.Format(" AND Rückgabedatum < #{0}#",DateTime.Now.Date);
                //grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// only shows copies that are due today
        /// </summary>
        /// <param name="grid"></param>
        public void ShowYellowCopies(ref MetroGrid grid)
        {
            try
            {
                table.DefaultView.RowFilter = table.DefaultView.RowFilter+string.Format(" AND Rückgabedatum = '#{0}#'", DateTime.Now.Date);
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// only shows copies that are currently not borrowed
        /// </summary>
        /// <param name="grid"></param>
        public void ShowAvailableCopies(ref MetroGrid grid)
        {
            try
            {
                table.DefaultView.RowFilter = string.Format("Leihnummer IS NULL");
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }
        
        /// <summary>
        /// shows all borrowed copies
        /// </summary>
        /// <param name="grid"></param>
        public void ShowBorrowedCopies(ref MetroGrid grid)
        {
            try
            {
                table.DefaultView.RowFilter = table.DefaultView.RowFilter + string.Format(" AND Rückgabedatum IS NOT NULL");
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// shows all copies
        /// </summary>
        /// <param name="grid"></param>
        public void ShowAllCopies(ref MetroGrid grid)
        {
            try
            {
                table.DefaultView.RowFilter = string.Format("ExemplarID IS NOT NULL");
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }
        
        /// <summary>
        /// searches costumer and book
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="copyId"></param>
        /// <param name="isbn"></param>
        /// <param name="title"></param>
        /// <param name="authorName"></param>
        /// <param name="publisherName"></param>
        /// <param name="genreName"></param>
        /// <param name="firstName"></param>
        /// <param name="surname"></param>
        /// <param name="schoolClass"></param>
        public void ExecuteSearch(ref MetroGrid grid, string copyId, string isbn, string title, string authorName, string publisherName, 
            string genreName, string firstName, string surname, string schoolClass)
        {
            try
            {
                if (copyId == "ExemplarID")
                {
                    copyId = "";
                }
                if (isbn == "ISBN")
                {
                    isbn = "";
                }
                if (title == "Titel")
                {
                    title = "";
                }
                if (authorName == "Autor")
                {
                    authorName = "";
                }
                if (publisherName == "Verlag")
                {
                    publisherName = "";
                }
                if (genreName == "Genre")
                {
                    genreName = "";
                }

                string rawFilter = string.Format("Convert([ExemplarID], System.String) LIKE '{0}%' AND ISBN LIKE '{1}%' AND Titel LIKE '%{2}%' AND Verlag LIKE '%{3}%' AND Genre LIKE '%{4}%' AND Autor LIKE '%{5}%'", copyId, isbn, title, publisherName, genreName, authorName);
                if (firstName == "Vorname" || firstName == "")
                {
                    firstName = "";
                }
                else
                {
                    rawFilter = rawFilter + string.Format(" AND Vorname LIKE '%{0}%'",firstName);
                }
                if (surname == "Nachname" || surname == "")
                {
                    surname = "";
                }
                else
                {
                    rawFilter = rawFilter + string.Format(" AND Nachname LIKE '%{0}%'", surname);
                }
                if (schoolClass == "Klasse" || schoolClass == "")
                {
                    schoolClass = "";
                }
                else
                {
                    rawFilter = rawFilter + string.Format(" AND Klasse LIKE '%{0}%'", schoolClass);
                }

                table.DefaultView.RowFilter = rawFilter;
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }
    }
}
