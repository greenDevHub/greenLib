using Bibo_Verwaltung.Helper;
using MetroFramework.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class BookGradeHelper
    {
        BookHelper bookHelper = new BookHelper();

        private DataTable FillObject()
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string command = "SELECT bs_isbn as 'ISBN', bs_klassenstufe, buch_titel as 'Titel' FROM [dbo].[t_s_buch_stufe] left join [dbo].[t_s_buecher] on buch_isbn = bs_isbn order by buch_titel";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        private void SetMark(ref MetroGrid gridBooks, int grade, DataTable table, object value = null)
        {
            for (int j = 0; j <= gridBooks.Rows.Count - 1; j++)
            {
                DataGridViewRow row = gridBooks.Rows[j];

                for (int i = 0; i <= table.Rows.Count - 1; i++)
                {
                    if (row.Cells["ISBN"].Value.ToString() == table.Rows[i]["ISBN"].ToString())
                    {
                        if (int.Parse(table.Rows[i]["bs_klassenstufe"].ToString()) == grade)
                        {
                            row.Cells["ISBN"].Value = "*" + row.Cells["ISBN"].Value.ToString();
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        public void FillGridAllBooks(ref MetroGrid gridBooks, int grade, object value = null)
        {
            DataTable table = FillObject();
            bookHelper.FillGrid(ref gridBooks, true);
            SetMark(ref gridBooks, grade, table);
        }

        public void FillGridBookGrade(ref MetroGrid grid, int grade, object value = null)
        {
            DataTable table = FillObject();
            table.DefaultView.RowFilter = string.Format("bs_klassenstufe LIKE '{0}'", grade);
            grid.DataSource = table;
            grid.Columns["bs_klassenstufe"].Visible = false;
        }


        public void SaveAssignment(DataTable assignmentTable, int grade)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "DELETE FROM [dbo].[t_s_buch_stufe] WHERE bs_klassenstufe = @grade";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.ExecuteNonQuery();

            command = "INSERT INTO [dbo].[t_s_buch_stufe] (bs_isbn, bs_klassenstufe) VALUES (@isbn, @grade)";
            foreach (DataRow row in assignmentTable.Rows)
            {
                cmd = new SqlCommand(command, con.Con);
                cmd.Parameters.AddWithValue("@isbn", row[0].ToString());
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
