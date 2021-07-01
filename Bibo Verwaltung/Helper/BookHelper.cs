using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung.Helper
{
    class BookHelper
    {
        public BookHelper()
        {

        }

        /// <summary>
        /// fills a datagridview with book data
        /// </summary>
        /// <param name="grid">refering gridview</param>
        /// <param name="shortLoad">true: only title will be loaded; false: everything will be loaded</param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroGrid grid, bool shortLoad, object value = null)
        {
            DataTable table = FillObject(shortLoad);
            if (table == null) return;
            grid.DataSource = table;
        }

        /// <summary>
        /// fills a normal combobox with book titles and isbn
        /// </summary>
        /// <param name="cb">refering combobox</param>
        /// <param name="value">selected value</param>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            DataTable table = FillObject(true);
            if (table == null) return;
            cb.DataSource = table;
            cb.ValueMember = "ISBN";
            cb.DisplayMember = "Titel";
            cb.SelectedValue = value;
        }

        /// <summary>
        /// fills a datatable with short book data
        /// </summary>
        /// <returns>a datatable</returns>
        /// <param name="shortLoad">true: only title will be loaded; false: everything will be loaded</param>
        private DataTable FillObject(bool shortLoad)
        {
            DataTable table = new DataTable();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return table;
            string command = shortLoad ? "SELECT buch_isbn as 'ISBN', buch_titel as 'Titel' " +
                "from t_s_buecher WHERE buch_activated = 1" :
                "SELECT buch_isbn as 'ISBN',"
                + "buch_titel as 'Titel',"
                + "ger_name as 'Genre',"
                + "ver_name as 'Verlag',"
                + "stuff(( SELECT distinct ', '+ cast(au_autor as varchar(512)) FROM t_s_buch_autor left join t_s_autor on au_id = ba_autorid where ba_isbn = buch_isbn FOR XML PATH('')),1,1,'') as 'Autor',"
                + "buch_erscheinungsdatum as 'Erscheinungsdatum',"
                + "sprach_name as 'Sprache',"
                + "buch_auflage as 'Auflage',"
                + "buch_neupreis as 'Neupreis' from t_s_buecher "
                + "left join t_s_genre on buch_genre_id = ger_id "
                + "left join t_s_verlag on buch_verlag_id = ver_id "
                + "left join t_s_sprache on buch_sprache_id = sprach_id WHERE buch_activated = 1";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// fills the combobox of book search with data
        /// </summary>
        /// <param name="cb">refering combobox</param>
        /// <param name="klassenstufe"></param>
        /// <param name="value"></param>
        public void FillComboboxSearch(ref AdvancedComboBox cb, int grade, object value)
        {
            DataTable table = FillObjectSearch(grade);
            if (table == null) return;
            cb.DataSource = table;
            cb.ValueMember = "ISBN";
            cb.DisplayMember = "Titel";
            cb.SelectedValue = value;
        }

        /// <summary>
        /// fills a datatable with necessary data for book search formular
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        private DataTable FillObjectSearch(int grade)
        {
            DataTable table = new DataTable();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return table;
            string command = "SELECT buch_isbn as 'ISBN', buch_titel as 'Titel' FROM t_s_buchid " +
                "left join t_s_buecher on buch_isbn = bu_isbn left join t_s_buch_stufe on bs_isbn = bu_isbn " +
                "WHERE bs_klassenstufe = @grade AND bu_activated = 1 AND bu_id NOT IN (SELECT aus_buchid FROM t_bd_ausgeliehen) " +
                "group by buch_isbn, buch_titel";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@grade", grade);
            adapter.Fill(table);
            con.Close();
            return table;
        }
    }
}
