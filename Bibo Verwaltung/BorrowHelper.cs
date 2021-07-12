using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class BorrowHelper
    {
        #region attributes
        Costumer costumer;
        /// <summary>
        /// get/set the costumer who is borrowing a book copy
        /// </summary>
        public Costumer Costumer { get { return costumer; } set { costumer = value; } }

        Copy copy;
        /// <summary>
        /// get/set the copy which is being borrowed
        /// </summary>
        public Copy Copy { get { return copy; } set { copy = value; } }

        DateTime returnDate;
        /// <summary>
        /// get/set the return date of a book copy
        /// </summary>
        public DateTime ReturnDate { get { return returnDate; } set { returnDate = value; } }

        DataTable borrowTable = new DataTable();
        /// <summary>
        /// get/set a table with all the borrow data
        /// </summary>
        public DataTable BorrowTable { get { return borrowTable; } set { borrowTable = value; } }

        bool isAvailable;
        /// <summary>
        /// get/set the available status of the copy
        /// </summary>
        public bool IsAvailable { get { return isAvailable; } set { isAvailable = value; } }
        #endregion

        /// <summary>
        /// Prüft die Buchausleihliste auf das Vorhandensein der aktuellen Exemlar ID 
        /// </summary>
        public bool CheckBorrowTable()
        {
            for (int i = 0; i <= BorrowTable.Rows.Count - 1; i++)
            {
                if (int.Parse(BorrowTable.Rows[i][0].ToString()) == Copy.CopyId)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt der Ausleihliste 
        /// </summary>
        public void ClearBorrowTable()
        {
            BorrowTable.Rows.Clear();
        }

        /// <summary>
        /// Übernimmt eine vorgefertigte Liste in die Buchausleihliste 
        /// </summary>
        public void FillAusleihListe(string[] inputList)
        {
            try
            {
                ClearBorrowTable();
                DataRow relation;
                string[] exemlarDetails = new string[2];
                List<string> newList = new List<string>();
                foreach (string s in inputList)
                {
                    Copy ex = new Copy(int.Parse(s));
                    if (ex.IsAvailable())
                    {
                        newList.Add(s);
                    }
                }
                inputList = newList.ToArray();
                if (BorrowTable.Columns.Count != 2)
                {
                    BorrowTable.Columns.Add();
                    BorrowTable.Columns.Add();
                }

                for (int i = 0; i <= inputList.Length - 1; i++)
                {
                    exemlarDetails[0] = inputList[i];
                    exemlarDetails[1] = DateTime.Now.Date.ToShortDateString();
                    relation = BorrowTable.NewRow();
                    relation.ItemArray = exemlarDetails;
                    BorrowTable.Rows.Add(relation);
                }
            }
            catch
            {
                MessageBox.Show("Beim Laden der Liste in die Buchausleihliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gibt den Row-Index der ExemplarID in der Buchausleihliste wieder
        /// </summary>
        public int GetIndexInLeihliste()
        {
            int result = -1;
            for (int i = 0; i <= BorrowTable.Rows.Count - 1; i++)
            {
                if (int.Parse(BorrowTable.Rows[i][0].ToString()) == Copy.CopyId)
                {
                    result = i;
                }
            }
            return result;
        }

        /// <summary>
        /// Baut einen Dialogstring abhängig von der Buchausleih-Anzahl
        /// </summary>
        public string GetListInfo()
        {
            Book book;
            StringBuilder sb = new StringBuilder();
            sb.Append("Derzeit sind folgende Titel in der Auswahlliste: ");
            sb.AppendLine();
            sb.AppendLine();

            if (BorrowTable.Rows.Count > 0)
            {
                for (int i = 0; i < BorrowTable.Rows.Count; i++)
                {
                    book = new Book(new Copy(int.Parse(BorrowTable.Rows[i][0].ToString())).CopyIsbn, true);
                    sb.Append("-  ");
                    sb.Append(TrimText(book.BookTitle, 30));
                    if (i < BorrowTable.Rows.Count)
                    {
                        sb.Append(", ");
                    }
                    sb.AppendLine();
                }
            }
            else
            {
                sb.Append("keine Einträge");
            }
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Zeigt das Buchcoder eines Exemplars in einer PictureBox
        /// </summary>
        public void ShowBuchCover(ref PictureBox picBox_Buchcover)
        {
            Book book = new Book(Copy.CopyIsbn, false);
            if (book.BookImage != null)
            {
                MemoryStream mem = new MemoryStream(book.BookImage);
                picBox_Buchcover.Image = Image.FromStream(mem);
            }
            else
            {
                picBox_Buchcover.Image = null;
            }
        }

        /// <summary>
        /// Baut einen Dialogstring abhängig von der Buchausleih-Anzahl
        /// </summary>
        public string GetAusleihList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Möchten Sie ");

            if (BorrowTable.Rows.Count == 1)
            {
                Copy copy = new Copy(int.Parse(BorrowTable.Rows[0][0].ToString()));
                string title = copy.CopyTitle;
                sb.Append("das Buch: ");
                sb.AppendLine();
                sb.AppendLine();
                sb.Append(TrimText(title, 30));
                sb.Append(", ");
                sb.AppendLine();
                sb.AppendLine();
            }
            else
            {
                sb.Append("die Bücher: ");
                sb.AppendLine();
                sb.AppendLine();
                for (int i = 0; i < BorrowTable.Rows.Count; i++)
                {
                    Copy copy = new Copy(int.Parse(BorrowTable.Rows[i][0].ToString()));
                    string title = copy.CopyTitle;
                    sb.Append("-  ");
                    sb.Append(TrimText(title, 30));
                    sb.Append(", ");
                    sb.AppendLine();
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        /// <summary>
        /// Schneidet einen String auf eine bestimmte Länge von Zeichen
        /// </summary>
        public string TrimText(string inputText, int maxLength)
        {
            string outputText;
            if (inputText.Length > maxLength)
            {
                outputText = inputText.Substring(0, maxLength) + "...";
            }
            else
            {
                outputText = inputText;
            }
            return outputText.Trim();
        }


        /// <summary>
        /// Setzt den Auswahl-Slider anhand der Elemente der Ausleihliste
        /// </summary>
        public void SetSlider(ref HScrollBar sliderBorrowList, ref MetroTextBox tbListMin, ref MetroTextBox tbListMax)
        {
            if (BorrowTable.Rows.Count == 0)
            {
                sliderBorrowList.Enabled = false;
                sliderBorrowList.Minimum = 0;
                sliderBorrowList.Maximum = 0;
            }
            else
            {
                sliderBorrowList.Enabled = true;
                sliderBorrowList.Minimum = 1;
                sliderBorrowList.Maximum = BorrowTable.Rows.Count;
                sliderBorrowList.Value = sliderBorrowList.Maximum;
            }
            tbListMin.Text = sliderBorrowList.Value.ToString();
            tbListMax.Text = sliderBorrowList.Maximum.ToString();
        }

        /// <summary>
        /// Fügt einen Eintrag zur Buchausleih-Liste hinzu
        /// </summary>
        public void AddToAusleihList()
        {
            try
            {
                DataRow relation;
                string[] exemlarDetails = new string[2];

                exemlarDetails[0] = Copy.CopyId.ToString();
                exemlarDetails[1] = ReturnDate.ToShortDateString();

                if (BorrowTable.Columns.Count != 2)
                {
                    BorrowTable.Columns.Add();
                    BorrowTable.Columns.Add();
                }
                relation = BorrowTable.NewRow();
                relation.ItemArray = exemlarDetails;
                BorrowTable.Rows.Add(relation);
            }
            catch
            {
                MessageBox.Show("Beim Hinzufügen dieses Buches zur Buchausleihliste ist ein Fehler aufgetreten.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Buchausleih-Liste
        /// </summary>
        public void RemoveFromAusleihList()
        {
            try
            {
                for (int i = BorrowTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = BorrowTable.Rows[i];
                    if (int.Parse(row[0].ToString()) == Copy.CopyId)
                        row.Delete();
                }
                BorrowTable.AcceptChanges();
            }
            catch
            {
                MessageBox.Show("Beim Entfernen dieses Buches von der Buchausleihliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Buchaugabe eines Buches
        /// </summary>
        public void Execute_Ausleihe(int copyId, string borrowDate, string returnDate, int costumerId)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "INSERT into [dbo].[t_bd_ausgeliehen] (aus_buchid, aus_leihdatum, aus_rückgabedatum, aus_kundenid) " +
                "VALUES(@copyId, @borrowDate, @returnDate, @costumerId)";
            SqlCommand cmd = new SqlCommand(command, con.Con);

            cmd.Parameters.AddWithValue("@copyId", copyId);
            cmd.Parameters.AddWithValue("@borrowDate", borrowDate);
            cmd.Parameters.AddWithValue("@returnDate", returnDate);
            cmd.Parameters.AddWithValue("@costumerId", costumerId);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Schlägt Bücher zur Schulbuchausgabe vor
        /// </summary>
        private DataTable SuggestBuecher(int schoolGrade)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            DataTable table = new DataTable();
            if (con.ConnectError()  || Costumer == null || Costumer.CostumerSubjects == null || Costumer.CostumerAdvancedSubjects == null) return table;
            string command = "SELECT f_kurzform as 'Fach', bf_isbn as 'ISBN', buch_titel as 'Titel', bf_fachid FROM [dbo].[t_s_buch_fach] " +
                "left join t_s_buecher on buch_isbn = bf_isbn left join t_s_faecher on f_id = bf_fachid left join t_s_buch_stufe on bs_isbn = bf_isbn " +
                "WHERE bf_fachid = @0 AND bs_klassenstufe = @1 AND bf_lk = @2";
            for (int i = 0; i < Costumer.CostumerSubjects.Count; i++)
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
                adapter.SelectCommand.Parameters.AddWithValue("@0", Costumer.CostumerSubjects[i]);
                adapter.SelectCommand.Parameters.AddWithValue("@1", schoolGrade);
                adapter.SelectCommand.Parameters.AddWithValue("@2", Costumer.CostumerAdvancedSubjects.Contains(Costumer.CostumerSubjects[i]) ? "1" : "0");
                adapter.Fill(table);
            }
            con.Close();
            return table;
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Schulbüchern 
        /// </summary>
        public void FillSuggestGrid(ref MetroGrid grid, object value = null)
        {
            DataTable table = SuggestBuecher(Costumer.ReturnGrade());
            grid.DataSource = table;
            grid.Columns["bf_fachid"].Visible = false;
        }

        public List<Book> SuggestedBooks()
        {
            DataTable table = SuggestBuecher(Costumer.ReturnGrade());
            List<Book> suggestedBooks = new List<Book>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                string isbn = table.Rows[i][1].ToString();
                Book book = new Book(isbn,false);
                suggestedBooks.Add(book);
            }
            return suggestedBooks;
        }
    }
}
