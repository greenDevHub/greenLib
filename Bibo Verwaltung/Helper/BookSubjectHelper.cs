using Bibo_Verwaltung.Helper;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class BookSubjectHelper
    {
        BookHelper helper = new BookHelper();

        /// <summary>
        /// returns a datatable with the book subject data
        /// </summary>
        /// <param name="isAdvancedSubject"></param>
        /// <returns></returns>
        private DataTable FillObjectAdvancedSubject(bool isAdvancedSubject)
        {
            DataTable table = new DataTable();
            int lk = isAdvancedSubject ? 1 : 0;
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string RawCommand = "SELECT bf_isbn as 'ISBN', Convert(nvarchar, bf_fachid) as 'bf_fachid', buch_titel as 'Titel' FROM [dbo].[t_s_buch_fach] " +
                $"left join [dbo].[t_s_buecher] on buch_isbn = bf_isbn WHERE bf_lk = {lk} order by buch_titel";
            SqlDataAdapter adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// marks the assigned books
        /// </summary>
        /// <param name="gridBooks"></param>
        /// <param name="subjectId"></param>
        /// <param name="table"></param>
        /// <param name="value"></param>
        private void SetMark(ref MetroGrid gridBooks, int subjectId, DataTable table, object value = null)
        {
            for (int gridRowIndex = 0; gridRowIndex <= gridBooks.Rows.Count - 1; gridRowIndex++)
            {
                DataGridViewRow row = gridBooks.Rows[gridRowIndex];

                for (int tableRowIndex = 0; tableRowIndex <= table.Rows.Count - 1; tableRowIndex++)
                {
                    if (row.Cells["ISBN"].Value.ToString() == table.Rows[tableRowIndex]["ISBN"].ToString())
                    {
                        if (int.Parse(table.Rows[tableRowIndex]["bf_fachid"].ToString()) == subjectId)
                        {
                            row.Cells["ISBN"].Value = "*" + row.Cells["ISBN"].Value.ToString();
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// fills a gridview with the book data
        /// </summary>
        /// <param name="gridBooks"></param>
        /// <param name="subjectId"></param>
        /// <param name="isAdvancedSubject"></param>
        /// <param name="value"></param>
        public void FillGridAllBooks(ref MetroGrid gridBooks, int subjectId, bool isAdvancedSubject, object value = null)
        {
            DataTable table = FillObjectAdvancedSubject(isAdvancedSubject);
            helper.FillGrid(ref gridBooks, true);
            SetMark(ref gridBooks, subjectId, table);
        }

        /// <summary>
        /// fills a gridview with the book subject data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="subjectId"></param>
        /// <param name="isAdvancedSubject"></param>
        /// <param name="value"></param>
        public void FillGridBookSubject(ref MetroGrid grid, int subjectId, bool isAdvancedSubject, object value = null)
        {
            DataTable table = FillObjectAdvancedSubject(isAdvancedSubject);
            table.DefaultView.RowFilter = string.Format("bf_fachid LIKE '{0}'", subjectId);
            grid.DataSource = table;
            grid.Columns["bf_fachid"].Visible = false;
        }

        /// <summary>
        /// saves the assignment data
        /// </summary>
        /// <param name="assignmentTable"></param>
        /// <param name="subjectId"></param>
        /// <param name="isAdvancedSubject"></param>
        public void SaveAssignment(DataTable assignmentTable, int subjectId, bool isAdvancedSubject)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            int advancedSubjectInt = isAdvancedSubject ? 1 : 0;
            string command = "DELETE FROM [dbo].[t_s_buch_fach] WHERE bf_fachid = @subjectId AND bf_lk = @advancedSubjectInt";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@subjectId", subjectId);
            cmd.Parameters.AddWithValue("@advancedSubjectInt", advancedSubjectInt);
            cmd.ExecuteNonQuery();

            command = "INSERT INTO [dbo].[t_s_buch_fach] (bf_isbn, bf_fachid, bf_lk) VALUES (@isbn, @subjectId, @advancedSubjectInt)";
            foreach (DataRow row in assignmentTable.Rows)
            {
                cmd = new SqlCommand(command, con.Con);
                cmd.Parameters.AddWithValue("@isbn", row[0].ToString());
                cmd.Parameters.AddWithValue("@subjectId", subjectId);
                cmd.Parameters.AddWithValue("@advancedSubjectInt", advancedSubjectInt);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
