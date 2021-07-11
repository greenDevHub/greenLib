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
    class UserHelper
    {
        /// <summary>
        /// returns a datatable with all the user data
        /// </summary>
        /// <returns></returns>
        private DataTable FillObject()
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string RawCommand = "SELECT b_name as 'Name', b_rechte as 'RechteID' FROM [dbo].[t_s_benutzer]";
            SqlDataAdapter adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(table);
            con.Close();
            if (!table.Columns.Contains("Rechte"))
            {
                table.Columns.Add("Rechte");
            }
            foreach (DataRow dr in table.Rows)
            {
                int rechteID = int.Parse(dr["RechteID"].ToString());
                dr["Rechte"] = (User.Permission)rechteID;
            }
            return table;
        }

        /// <summary>
        /// fills a grid with the user data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            grid.DataSource = FillObject();
            grid.Columns["RechteID"].Visible = false;
        }
    }
}
