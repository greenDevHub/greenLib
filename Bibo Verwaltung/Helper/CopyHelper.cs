using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung
{
    class CopyHelper
    {
        public CopyHelper()
        {

        }
        /// <summary>
        /// deactivates all copy entries where copyIsbn = bookIsbn
        /// </summary>
        /// <param name="bookIsbn">the isbn of a book</param>
        public void DeactivateByBookIsbn(string bookIsbn)
        {
            SQL_Verbindung connection = new SQL_Verbindung();
            if (connection.ConnectError()) return;
            string RawCommand = "UPDATE t_s_buchid set bu_activated = @copyActivated WHERE bu_isbn = @copyIsbn";
            SqlCommand cmd = new SqlCommand(RawCommand, connection.Con);
            cmd.Parameters.AddWithValue("@copyActivated", 0);
            cmd.Parameters.AddWithValue("@copyIsbn", bookIsbn);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// searches for a copy by the isbn
        /// </summary>
        /// <param name="bookIsbn"></param>
        /// <returns>returns the last entry of the result entity</returns>
        public int FindIdByIsbn(string bookIsbn)
        {
            int id = -1;
            SQL_Verbindung connection = new SQL_Verbindung();
            if (connection.ConnectError()) return id;
            string command = "SELECT bu_id from t_s_buchid where bu_isbn = @0";
            SqlDataReader dr = connection.ExcecuteCommand(command, bookIsbn);
            while (dr.Read())
            {
                id = int.Parse(dr["bu_id"].ToString());
            }
            dr.Close();
            connection.Close();
            return id;
        }

        /// <summary>
        /// fills the datatable with necessary data of the copies for one grade
        /// </summary>
        /// <param name="grade">the students grade</param>
        /// <param name="copyIsbn">the isbn of a book</param>
        /// <returns></returns>
        public DataTable FillObjectSearch(int grade, string copyIsbn)
        {
            DataTable result = new DataTable();
            SQL_Verbindung connection = new SQL_Verbindung();
            if (connection.ConnectError()) return result;
            string command = "SELECT bu_id as 'ExemplarID', buch_isbn as 'ISBN', buch_titel as 'Titel' " +
                "FROM t_s_buchid left join t_s_buecher on buch_isbn = bu_isbn left join t_s_buch_stufe on bs_isbn = bu_isbn " +
                "WHERE bs_klassenstufe = @grade AND bu_activated = 1 AND buch_isbn = @copyIsbn AND " +
                "bu_id NOT IN (SELECT aus_buchid FROM t_bd_ausgeliehen)";
            SqlDataAdapter adapter = new SqlDataAdapter(command, connection.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@grade", grade);
            adapter.SelectCommand.Parameters.AddWithValue("@copyIsbn", copyIsbn);
            adapter.Fill(result);
            connection.Close();
            return result;
        }

        /// <summary>
        /// deletes all copy entries from database where copyIsbn = bookIsbn
        /// </summary>
        /// <param name="bookIsbn">the isbn of a book</param>
        public void DeleteByBookIsbn(string bookIsbn)
        {
            SQL_Verbindung connection = new SQL_Verbindung();
            if (connection.ConnectError()) return;
            string command = "DELETE FROM [dbo].[t_s_buchid] WHERE bu_isbn = @bookIsbn";
            SqlCommand cmd = new SqlCommand(command, connection.Con);
            cmd.Parameters.AddWithValue("@bookIsbn", bookIsbn);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
        /// <summary>
        /// fills the datatable object with all the necessary data from all activated copies with a given isbn
        /// </summary>
        /// <param name="copyIsbn"></param>
        /// <returns>returns a table object with data of copies</returns>
        private DataTable FillObject(string copyIsbn)
        {
            DataTable table = new DataTable();
            SQL_Verbindung connection = new SQL_Verbindung();
            SqlDataAdapter adapter = new SqlDataAdapter();
            if (connection.ConnectError()) return table;
            string command = "SELECT bu_id as Exemplar, bu_isbn as ISBN, buch_titel as Titel, " +
                "bu_aufnahmedatum as Aufnahmedatum, zu_zustand as Zustand " +
                "from t_s_buchid left join t_s_zustand on bu_zustandsid = zu_id " +
                "left join t_s_buecher on bu_isbn = buch_isbn where bu_isbn = @isbn AND bu_activated = 1";
            adapter = new SqlDataAdapter(command, connection.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@isbn", copyIsbn);
            adapter.Fill(table);
            connection.Close();
            return table;
        }

        /// <summary>
        /// fills a dataGridView with the necessary information
        /// </summary>
        public void FillGrid(ref MetroGrid gridView, string copyIsbn)
        {
            DataTable table = FillObject(copyIsbn);
            if (table == null) return;
            gridView.DataSource = table;
        }
    }
}
