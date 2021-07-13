using Bibo_Verwaltung.Helper;
using MetroFramework.Controls;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class SubjectGradeHelper
    {
        SubjectHelper subjectHelper = new SubjectHelper();
        public List<Subject> SubjectList { get; set; }
        public SubjectGradeHelper()
        {

        }

        public SubjectGradeHelper(int grade)
        {
            LoadAssignment(grade);
        }
        private void LoadAssignment(int grade)
        {
            SubjectList = new List<Subject>();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "SELECT * FROM [dbo].[t_s_fach_stufe] WHERE bf_klassenstufe = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, grade);
            while (dr.Read())
            {
                Subject s = new Subject(int.Parse(dr["bf_fachid"].ToString()));
                SubjectList.Add(s);
            }
            dr.Close();
            con.Close();
        }
        /// <summary>
        /// returns a datatable with subject grade information
        /// </summary>
        /// <returns></returns>
        private DataTable FillObject()
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string command = "SELECT bf_fachid, bf_klassenstufe, f_kurzform as 'Kürzel', f_langform as 'Langbezeichnung' " +
                "FROM [dbo].[t_s_fach_stufe] left join [dbo].[t_s_faecher] on f_id = bf_fachid order by f_kurzform";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// Markiert die zugeordneten Fächer
        /// </summary>
        private void SetMark(ref MetroGrid gridSubjects, int grade, DataTable table, object value = null)
        {
            for (int j = 0; j <= gridSubjects.Rows.Count - 1; j++)
            {
                DataGridViewRow row = gridSubjects.Rows[j];

                for (int i = 0; i <= table.Rows.Count - 1; i++)
                {
                    if (row.Cells["ID"].Value.ToString() == table.Rows[i]["bf_fachid"].ToString())
                    {
                        if (int.Parse(table.Rows[i]["bf_klassenstufe"].ToString()) == grade)
                        {
                            row.Cells["Kürzel"].Value = "*" + row.Cells["Kürzel"].Value.ToString();
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// fills a grid with all the subject data
        /// </summary>
        /// <param name="gridSubjects"></param>
        /// <param name="grade"></param>
        /// <param name="value"></param>
        public void FillGridAllSubjects(ref MetroGrid gridSubjects, int grade, object value = null)
        {
            DataTable table = FillObject();
            subjectHelper.FillGrid(ref gridSubjects);
            SetMark(ref gridSubjects, grade, table);
        }

        /// <summary>
        /// fills a grid with subject grade data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="grade"></param>
        /// <param name="value"></param>
        public void FillGridSubjectGrade(ref MetroGrid grid, int grade, object value = null)
        {
            DataTable table = FillObject();
            table.DefaultView.RowFilter = string.Format("bf_klassenstufe LIKE '{0}'", grade);
            grid.DataSource = table;
            grid.Columns["bf_fachid"].Visible = false;
            grid.Columns["bf_klassenstufe"].Visible = false;
        }

        /// <summary>
        /// saves the assignment
        /// </summary>
        /// <param name="assignmentTable"></param>
        /// <param name="grade"></param>
        public void SaveAssignment(DataTable assignmentTable, int grade)
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "DELETE FROM [dbo].[t_s_fach_stufe] WHERE bf_klassenstufe = @grade";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.ExecuteNonQuery();

            command = "INSERT INTO [dbo].[t_s_fach_stufe] (bf_fachid, bf_klassenstufe) VALUES (@subjectId, @grade)";
            foreach (DataRow row in assignmentTable.Rows)
            {
                cmd = new SqlCommand(command, con.Con);
                cmd.Parameters.AddWithValue("@subjectId", row[0].ToString());
                cmd.Parameters.AddWithValue("@grade", grade);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}