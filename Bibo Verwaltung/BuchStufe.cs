using Bibo_Verwaltung.Helper;
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
    class BuchStufe
    {
        BookHelper bookHelper = new BookHelper();


        Book buch = new Book();
        CustomSqlConnection con = new CustomSqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region Constructor
        /// <summary>
        /// Erschaft das Objekt BuchStufe
        /// </summary>
        public BuchStufe()
        {
            FillObject();
        }
        #endregion

        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Buch-Klassenstufen-Zuordnungsdatendaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bs_isbn as 'ISBN', bs_klassenstufe, buch_titel as 'Titel' FROM [dbo].[t_s_buch_stufe] left join [dbo].[t_s_buecher] on buch_isbn = bs_isbn order by buch_titel";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            con.Close();
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt im DataSet 
        /// </summary>
        private void ClearDataSource()
        {
            try
            {
                ds.Tables[0].Rows.Clear();
            }
            catch { }
        }

        /// <summary>
        /// Markiert die zugeordneten Bücher
        /// </summary>
        private void Set_Mark(ref MetroFramework.Controls.MetroGrid gridBuecher, string stufe, object value = null)
        {
            try
            {
                for (int j = 0; j <= gridBuecher.Rows.Count - 1; j++)
                {
                    DataGridViewRow row = gridBuecher.Rows[j];

                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        if (row.Cells["ISBN"].Value.ToString() == ds.Tables[0].Rows[i]["ISBN"].ToString())
                        {
                            if (ds.Tables[0].Rows[i]["bs_klassenstufe"].ToString() == stufe)
                            {
                                row.Cells["ISBN"].Value = "*" + row.Cells["ISBN"].Value.ToString();
                                row.DefaultCellStyle.BackColor = Color.Yellow;
                                row.DefaultCellStyle.ForeColor = Color.Black;
                            }
                        }
                    }
                }
            }
            catch { }
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Buchdaten 
        /// </summary>
        public void Show_AllBuecher(ref MetroFramework.Controls.MetroGrid Buecher, string Stufe, object value = null)
        {
            ClearDataSource();
            FillObject();
            bookHelper.FillGrid(ref Buecher,true);
            Set_Mark(ref Buecher, Stufe);
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Buch-Klassenstufen-Zuordnungsdatendaten  
        /// </summary>
        public void Show_StufenBuecher(ref MetroFramework.Controls.MetroGrid grid, string stufe, object value = null)
        {
            ClearDataSource();
            FillObject();
            ds.Tables[0].DefaultView.RowFilter = string.Format("bs_klassenstufe LIKE '{0}'", stufe);
            grid.DataSource = ds.Tables[0];
            grid.Columns["bs_klassenstufe"].Visible = false;
        }

        /// <summary>
        /// Überschreibt und speichert die Zuordnungsdatendaten einer Klassenstufe mit vorhandenen Büchern in der Datenbank 
        /// </summary>
        public void Save_Zuordnung(DataTable zuordnung, string stufe)
        {
            if (con.ConnectError()) return;
            string RawCommand1 = "DELETE FROM [dbo].[t_s_buch_stufe] WHERE bs_klassenstufe = @stufe";
            con.ConnectError();
            SqlCommand cmd1 = new SqlCommand(RawCommand1, con.Con);
            cmd1.Parameters.AddWithValue("@stufe", stufe);
            cmd1.ExecuteNonQuery();

            string RawCommand2 = "INSERT INTO [dbo].[t_s_buch_stufe] (bs_isbn, bs_klassenstufe) VALUES (@isbn, @klassenstufe)";
            foreach (DataRow row in zuordnung.Rows)
            {
                SqlCommand cmd2 = new SqlCommand(RawCommand2, con.Con);
                cmd2.Parameters.AddWithValue("@isbn", row[0].ToString());
                cmd2.Parameters.AddWithValue("@klassenstufe", stufe);
                cmd2.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
