using Bibo_Verwaltung.Helper;
using MetroFramework.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class ReturnHelper
    {
        #region attributes
        Costumer costumer;
        /// <summary>
        /// get/set the costumer
        /// </summary>
        public Costumer Costumer { get { return costumer; } set { costumer = value; } }

        Copy copy;
        /// <summary>
        /// get/set the copy
        /// </summary>
        public Copy Copy { get { return copy; } set { copy = value; } }

        Condition startCondition;
        /// <summary>
        /// get/set the start condition
        /// </summary>
        public Condition StartCondition { get { return startCondition; } set { startCondition = value; } }

        Condition endCondition;
        /// <summary>
        /// get/set the end condition
        /// </summary>
        public Condition EndCondition { get { return endCondition; } set { endCondition = value; } }

        DateTime borrowDate;
        /// <summary>
        /// get/set the borrow date
        /// </summary>
        public DateTime BorrowDate { get { return borrowDate; } set { borrowDate = value; } }

        DateTime returnDate;
        /// <summary>
        /// get/set the return date
        /// </summary>
        public DateTime ReturnDate { get { return returnDate; } set { returnDate = value; } }

        DataTable returnDataTable = new DataTable();
        /// <summary>
        /// get/set a datatable with information
        /// </summary>
        public DataTable ReturnDataTable { get { return returnDataTable; } set { returnDataTable = value; } }

        bool isAvailable;
        /// <summary>
        /// get/set the available status of the copy
        /// </summary>
        public bool IsAvailable { get { return isAvailable; } set { isAvailable = value; } }
        #endregion

        BookHelper bookHelper = new BookHelper();

        /// <summary>
        /// Laden der KundenID, und des Ausleih- und Rückgabedatums eines Buches
        /// </summary>
        public void LoadInfo(int copyId, bool loadFullCostumerInfo = false)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT aus_leihdatum, aus_rückgabedatum, aus_kundenid, aus_buchid FROM t_bd_ausgeliehen WHERE aus_buchid = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, copyId);
            while (dr.Read())
            {
                Costumer = new Costumer();
                if (loadFullCostumerInfo)
                {
                    Costumer = new Costumer(int.Parse(dr["aus_kundenid"].ToString()));
                }
                else
                {
                    Costumer.CostumerId = int.Parse(dr["aus_kundenid"].ToString());
                }
                Copy = new Copy(int.Parse(dr["aus_buchid"].ToString()));
                BorrowDate = (DateTime)dr["aus_leihdatum"];
                ReturnDate = (DateTime)dr["aus_rückgabedatum"];
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Gibt den Row-Index der ExemplarID in der Buchausleihliste wieder
        /// </summary>
        public int GetIndexInRueckliste()
        {
            int result = -1;
            for (int i = 0; i <= ReturnDataTable.Rows.Count - 1; i++)
            {
                if (int.Parse(ReturnDataTable.Rows[i][0].ToString()) == Copy.CopyId)
                {
                    result = i;
                }
            }
            return result;
        }

        /// <summary>
        /// Füllt das DataSet 
        /// </summary>
        private DataTable FillObject()
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string RawCommand = "SELECT aus_buchid as 'ID', aus_leihdatum as 'Geliehen', aus_rückgabedatum as 'Rückgabe', buch_titel as 'Titel' " +
                "FROM t_bd_ausgeliehen left join t_s_buchid on bu_id = aus_buchid left join t_s_buecher on buch_isbn = bu_isbn WHERE aus_kundenid = @0 ";
            // add following line to select command if you only want to select school books
            // "AND buch_isbn in (SELECT bf_isbn FROM t_s_buch_fach)";
            SqlDataAdapter adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", Costumer.CostumerId);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Klassendaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            grid.DataSource = FillObject();
        }

        /// <summary>
        /// Prüft die Buchrückgabeliste auf das Vorhandensein der angegebenen Exemlar ID 
        /// </summary>
        public bool CheckRueckList()
        {
            bool result = false;
            for (int i = 0; i <= ReturnDataTable.Rows.Count - 1; i++)
            {
                if (int.Parse(ReturnDataTable.Rows[i][0].ToString()) == Copy.CopyId)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Übernimmt eine vorgefertigte Liste in die Buchrückgabeliste 
        /// </summary>
        public void FillRueckListe(string[] inputList)
        {
            try
            {
                ClearRueckList();
                DataRow relation;
                string[] exemlarDetails = new string[3];

                if (ReturnDataTable.Columns.Count != 3)
                {
                    ReturnDataTable.Columns.Add();
                    ReturnDataTable.Columns.Add();
                    ReturnDataTable.Columns.Add();
                }

                for (int i = 0; i <= inputList.Length - 1; i++)
                {
                    LoadInfo(int.Parse(inputList[i].ToString()));
                    exemlarDetails[0] = Copy.CopyId.ToString();
                    exemlarDetails[1] = StartCondition != null ? StartCondition.ConditionId.ToString() : null;
                    exemlarDetails[2] = EndCondition != null ? EndCondition.ConditionId.ToString() : null;
                    relation = ReturnDataTable.NewRow();
                    relation.ItemArray = exemlarDetails;
                    ReturnDataTable.Rows.Add(relation);
                }
            }
            catch
            {
                MessageBox.Show("Beim Laden der Liste in die Buchrückgabeliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Baut einen Dialogstring abhängig von der Buchrückgabe-Anzahl
        /// </summary>
        public String GetListInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Derzeit sind folgende Titel in der Auswahlliste: ");
            sb.AppendLine();
            sb.AppendLine();

            if (ReturnDataTable.Rows.Count > 0)
            {
                for (int i = 0; i < ReturnDataTable.Rows.Count; i++)
                {
                    Copy copy = new Copy(int.Parse(ReturnDataTable.Rows[i][0].ToString()));
                    string titel = copy.CopyTitle;


                    //exemplar = new Buch(new Exemplar(RueckListe.Rows[i][0].ToString()).ISBN);
                    //titel = exemplar.Titel;
                    sb.Append("-  ");
                    sb.Append(TrimText(titel, 30));
                    if (i < ReturnDataTable.Rows.Count)
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
        public void ShowBuchCover(ref PictureBox pictureBox)
        {
            pictureBox.Image = bookHelper.GetBookImage(Copy.CopyIsbn);
        }

        /// <summary>
        /// Schneidet einen String auf eine bestimmte Länge von Zeichen
        /// </summary>
        public string TrimText(string inputText, int maxLength)
        {
            string outputText = "";
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
        /// Baut einen Dialogstring abhängig von der Buchrückgabe-Anzahl
        /// </summary>
        public string GetRueckgabeList()
        {
            string resultString = "Möchten Sie ";
            if (ReturnDataTable.Rows.Count == 1)
            {
                Copy ex = new Copy(int.Parse(ReturnDataTable.Rows[0][0].ToString()));
                string titel = ex.CopyTitle;
                resultString = resultString + "das Buch: " + Environment.NewLine + Environment.NewLine + TrimText(titel, 30) + ", " + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                resultString = resultString + "die Bücher: " + Environment.NewLine + Environment.NewLine;
                foreach (DataRow row in ReturnDataTable.Rows)
                {
                    Copy ex = new Copy(int.Parse(row[0].ToString()));
                    string titel = ex.CopyTitle;
                    resultString = resultString + "-  " + TrimText(titel, 30) + ", " + Environment.NewLine;
                }
                resultString = resultString + Environment.NewLine;
            }
            return resultString;
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt der Rückgabeliste 
        /// </summary>
        public void ClearRueckList()
        {
            ReturnDataTable.Rows.Clear();
        }

        /// <summary>
        /// Setzt den Auswahl-Slider anhand der Elemente der Rückgabeliste
        /// </summary>
        public void SetSlider(ref HScrollBar scrollBarReturn, ref MetroTextBox tbMin, ref MetroTextBox tbMax)
        {
            if (ReturnDataTable.Rows.Count == 0)
            {
                scrollBarReturn.Enabled = false;
                scrollBarReturn.Minimum = 0;
                scrollBarReturn.Maximum = 0;
            }
            else
            {
                scrollBarReturn.Enabled = true;
                scrollBarReturn.Minimum = 1;
                scrollBarReturn.Maximum = ReturnDataTable.Rows.Count;
                scrollBarReturn.Value = scrollBarReturn.Maximum;
            }
            tbMin.Text = scrollBarReturn.Value.ToString();
            tbMax.Text = scrollBarReturn.Maximum.ToString();
        }

        /// <summary>
        /// Fügt einen Eintrag zur Buchrückgabe-Liste hinzu
        /// </summary>
        public void AddToRueckgabeList()
        {
            try
            {
                DataRow relation;
                string[] exemlarDetails = new string[3];
                exemlarDetails[0] = Copy.CopyId.ToString();
                exemlarDetails[1] = StartCondition.ConditionId.ToString();
                exemlarDetails[2] = EndCondition!=null ? EndCondition.ConditionId.ToString() : StartCondition.ConditionId.ToString();
                if (ReturnDataTable.Columns.Count != 3)
                {
                    ReturnDataTable.Columns.Add();
                    ReturnDataTable.Columns.Add();
                    ReturnDataTable.Columns.Add();
                }
                relation = ReturnDataTable.NewRow();
                relation.ItemArray = exemlarDetails;
                ReturnDataTable.Rows.Add(relation);
            }
            catch
            {
                MessageBox.Show("Beim Hinzufügen dieses Buches zur Buchrückgabeliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Buchrückgabe-Liste
        /// </summary>
        public void RemoveFromRueckgabeList()
        {
            try
            {
                for (int i = ReturnDataTable.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = ReturnDataTable.Rows[i];
                    if (int.Parse(row[0].ToString()) == Copy.CopyId)
                        row.Delete();
                }
                ReturnDataTable.AcceptChanges();
            }
            catch
            {
                MessageBox.Show("Beim Entfernen dieses Buches von der Buchrückgabeliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// returning of a book copy
        /// </summary>
        /// <param name="copyId"></param>
        /// <param name="costumerId"></param>
        /// <param name="shouldConditionName"></param>
        /// <param name="isConditionId"></param>
        /// <param name="isConditionName"></param>
        /// <param name="borrowDateStart"></param>
        /// <param name="borrowDateEnd"></param>
        public void Execute_Rueckgabe(int copyId, int costumerId, string shouldConditionName, int isConditionId, string isConditionName, string borrowDateStart, string borrowDateEnd)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "DELETE FROM t_bd_ausgeliehen WHERE aus_buchid = @0";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@0", copyId);
            cmd.ExecuteNonQuery();

            command = "UPDATE t_s_buchid set bu_zustandsid = @zustandsid WHERE bu_id = @id";
            cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@zustandsid", isConditionId);
            cmd.Parameters.AddWithValue("@id", copyId);
            cmd.ExecuteNonQuery();

            command = "INSERT INTO t_s_verlauf (id_buch, k_id, zu_vor, zu_nach, aus_geliehen, aus_ruckgabe) VALUES (@buchid, @kid, @zvor, @znach, @ausgeliehen, @ruckgabe)";
            cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@buchid", copyId);
            cmd.Parameters.AddWithValue("@kid", costumerId);
            cmd.Parameters.AddWithValue("@zvor", shouldConditionName);
            cmd.Parameters.AddWithValue("@znach", isConditionName);
            cmd.Parameters.AddWithValue("@ausgeliehen", borrowDateStart);
            cmd.Parameters.AddWithValue("@ruckgabe", borrowDateEnd);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
