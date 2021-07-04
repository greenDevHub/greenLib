using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung.Helper
{
    class GradeHelper
    {
        SchoolClassHelper schoolClassHelper = new SchoolClassHelper();
        public GradeHelper()
        {

        }

        /// <summary>
        /// returns a datatable with grades and school classes
        /// </summary>
        /// <returns></returns>
        private DataTable FillObject()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            DataTable table = new DataTable();
            if (con.ConnectError()) return table;
            string RawCommand = "SELECT ks_klassenstufe as 'Klassenstufe', ks_klasse, k_bezeichnung as 'Klasse' FROM [dbo].[t_s_klasse_stufe] " +
                "left join [dbo].[t_s_klassen] on k_id = ks_klasse order by ks_klasse";
            SqlDataAdapter adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// returns the grade of a school class
        /// </summary>
        /// <param name="schoolClassId"></param>
        /// <returns>returns >=0 if grade exists, returns -1 if no grade exists</returns>
        public int GetGradeOfSchoolClass(int schoolClassId)
        {
            int grade = -1;
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return grade;
            string RawCommand = "SELECT ks_klassenstufe FROM [dbo].[t_s_klasse_stufe] WHERE ks_klasse = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, schoolClassId);
            while (dr.Read())
            {
                grade = Convert.ToInt32(dr["ks_klassenstufe"].ToString());
            }
            dr.Close();
            con.Close();
            return grade;
        }


        /// <summary>
        /// marks all assigned classes
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="grade"></param>
        /// <param name="value"></param>
        private void MarkAssignedClasses(ref MetroFramework.Controls.MetroGrid grid, string grade, object value = null)
        {
            DataTable table = FillObject();
            for (int j = 0; j <= grid.Rows.Count - 1; j++)
            {
                DataGridViewRow row = grid.Rows[j];

                for (int i = 0; i <= table.Rows.Count - 1; i++)
                {
                    if (row.Cells["k_id"].Value.ToString() == table.Rows[i]["ks_klasse"].ToString())
                    {
                        if (table.Rows[i]["Klassenstufe"].ToString() == grade)
                        {
                            row.Cells["k_bezeichnung"].Value = "*" + row.Cells["k_bezeichnung"].Value.ToString();
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// fills a gridview with the school class data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="grade"></param>
        /// <param name="value"></param>
        public void ShowAllSchoolClasses(ref MetroFramework.Controls.MetroGrid grid, string grade, object value = null)
        {
            schoolClassHelper.FillGrid(ref grid);
            MarkAssignedClasses(ref grid, grade);
        }

        /// <summary>
        /// fills a gridview with class grade data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="grade"></param>
        /// <param name="value"></param>
        public void FillGridClassGrade(ref MetroFramework.Controls.MetroGrid grid, string grade, object value = null)
        {
            DataTable table = FillObject();
            table.DefaultView.RowFilter = string.Format("Klassenstufe LIKE '{0}'", grade);
            grid.DataSource = table;
            grid.Columns["Klassenstufe"].Visible = false;
            grid.Columns["ks_klasse"].Visible = false;
        }

        /// <summary>
        /// saves the assignment data of a school class and a grade to database
        /// </summary>
        /// <param name="assignmentTable"></param>
        /// <param name="grade"></param>
        public void SaveAssignment(DataTable assignmentTable, string grade)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string RawCommand1 = "DELETE FROM [dbo].[t_s_klasse_stufe] WHERE ks_klassenstufe = @stufe";
            con.ConnectError();
            SqlCommand cmd1 = new SqlCommand(RawCommand1, con.Con);
            cmd1.Parameters.AddWithValue("@stufe", grade);
            cmd1.ExecuteNonQuery();

            string RawCommand2 = "INSERT INTO [dbo].[t_s_klasse_stufe] (ks_klasse, ks_klassenstufe) VALUES (@klasse, @klassenstufe)";
            foreach (DataRow row in assignmentTable.Rows)
            {
                SqlCommand cmd2 = new SqlCommand(RawCommand2, con.Con);
                cmd2.Parameters.AddWithValue("@klasse", row[0].ToString());
                cmd2.Parameters.AddWithValue("@klassenstufe", grade);
                cmd2.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
