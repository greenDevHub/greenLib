using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung.Helper
{
    class ClassHelper
    {
        DataTable table;
        public ClassHelper()
        {
            table = new DataTable();
        }

        /// <summary>
        /// returns the id of a class by its name
        /// </summary>
        /// <param name="className"></param>
        /// <returns>returns -1 if no class was found; returns >=0 if a class was found</returns>
        public int GetIdBySubjectShortName(string className)
        {
            int classId = -1;
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return classId;
            string RawCommand = "SELECT k_id FROM [dbo].[t_s_klassen] WHERE k_bezeichnung = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, className);
            while (dr.Read())
            {
                classId = Convert.ToInt32(dr["k_id"].ToString());
            }
            dr.Close();
            con.Close();
            return classId;
        }

        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            //FillObject();
            //cb.DataSource = dt;
            cb.ValueMember = "KlassenID";
            cb.DisplayMember = "Klasse";
            cb.SelectedValue = value;
        }
    }
}
