using Bibo_Verwaltung.Helper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class BuchFach
    {
        BookHelper helper = new BookHelper();


        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region Constructor
        public BuchFach()
        {
            FillObject();
        }
        #endregion

        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Fach-Bücher-Zuordnungsdatendaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bf_isbn as 'ISBN', Convert(nvarchar, bf_fachid) as 'bf_fachid', buch_titel as 'Titel' FROM [dbo].[t_s_buch_fach] left join [dbo].[t_s_buecher] on buch_isbn = bf_isbn order by buch_titel";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            con.Close();
        }

        private void FillObjectLK(bool leistungskurs)
        {
            string lk = "";
            if (leistungskurs == true)
            {
                lk = "1";
            }
            else
            {
                lk = "0";
            }
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bf_isbn as 'ISBN', Convert(nvarchar, bf_fachid) as 'bf_fachid', buch_titel as 'Titel' FROM [dbo].[t_s_buch_fach] left join [dbo].[t_s_buecher] on buch_isbn = bf_isbn WHERE bf_lk = " + lk + " order by buch_titel";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
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
        private void Set_Mark(ref MetroFramework.Controls.MetroGrid gridBuecher, string fachID, object value = null)
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
                            if (ds.Tables[0].Rows[i]["bf_fachid"].ToString() == fachID)
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
        public void Show_AllBuecher(ref MetroFramework.Controls.MetroGrid gridBuecher, string fachID, bool lk, object value = null)
        {
            ClearDataSource();
            FillObjectLK(lk);
            helper.FillGrid(ref gridBuecher,true);
            Set_Mark(ref gridBuecher, fachID);
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Fach-Bücher-Zuordnungsdatendaten  
        /// </summary>
        public void Show_FachBuecher(ref MetroFramework.Controls.MetroGrid grid, string fachID, bool leistungskurs, object value = null)
        {
            ClearDataSource();
            FillObjectLK(leistungskurs);
            ds.Tables[0].DefaultView.RowFilter = string.Format("bf_fachid LIKE '{0}'", fachID);
            grid.DataSource = ds.Tables[0];
            grid.Columns["bf_fachid"].Visible = false;
        }

        /// <summary>
        /// Überschreibt und speichert die Zuordnungsdatendaten eines Faches mit vorhandenen Büchern in der Datenbank 
        /// </summary>
        public void Save_Zuordnung(DataTable zuordnung, string fachID, bool leistungskurs)
        {
            if (con.ConnectError()) return;
            string lk;
            if (leistungskurs)
            {
                lk = "1";
            }
            else
            {
                lk = "0";
            }
            string RawCommand1 = "DELETE FROM [dbo].[t_s_buch_fach] WHERE bf_fachid = @fachid AND bf_lk = @lk";
            con.ConnectError();
            SqlCommand cmd1 = new SqlCommand(RawCommand1, con.Con);
            cmd1.Parameters.AddWithValue("@fachid", fachID);
            cmd1.Parameters.AddWithValue("@lk", lk);
            cmd1.ExecuteNonQuery();

            string RawCommand2 = "INSERT INTO [dbo].[t_s_buch_fach] (bf_isbn, bf_fachid, bf_lk) VALUES (@isbn, @fachid, @lk)";
            foreach (DataRow row in zuordnung.Rows)
            {
                SqlCommand cmd2 = new SqlCommand(RawCommand2, con.Con);
                cmd2.Parameters.AddWithValue("@isbn", row[0].ToString());
                cmd2.Parameters.AddWithValue("@fachid", fachID);
                cmd2.Parameters.AddWithValue("@lk", lk);
                cmd2.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}
