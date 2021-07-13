using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung.Helper
{
    class CostumerHelper
    {
        public CostumerHelper()
        {

        }

        /// <summary>
        /// removes the subjects of all deactivated costumers
        /// </summary>
        private void DeleteSubjectsOfDeactivatedCostumers()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "DELETE FROM t_s_fach_kunde WHERE fs_kundenid in (SELECT kunde_id FROM t_s_kunden WHERE kunde_activated = 0)";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// deactivates all existing students
        /// </summary>
        public void DeactivateAllStudents()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "UPDATE t_s_kunden set kunde_activated = 0, kunde_klasse = null from t_s_kunden " +
                "left join t_bd_ausgeliehen on kunde_ID=aus_kundenid WHERE kunde_klasse !='' AND kunde_klasse IS NOT NULL and aus_leihnummer is NULL";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            DeleteSubjectsOfDeactivatedCostumers();
            cmd.ExecuteNonQuery();
            con.Close();
        }


        /// <summary>
        /// returns a datatable with costumer data
        /// </summary>
        /// <returns></returns>
        private DataTable FillObject()
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string command = "use greenLib SELECT kunde_ID as 'Kunden-ID', kunde_vorname as 'Vorname',  kunde_nachname as 'Nachname', kunde_geburtsdatum as 'Geburtsdatum', " +
                "k_bezeichnung as 'Klasse',CONCAT(stuff(( SELECT distinct ', '+ cast(f_kurzform as varchar(10)) FROM t_s_fach_kunde fk LEFT JOIN t_s_faecher f on fk.fs_fachid=f.f_id " +
                "WHERE fk.fs_kundenid=k.kunde_ID AND fk.fs_lk=1 FOR XML PATH('')),1,1,'')+',',stuff(( SELECT distinct ', '+ cast(f_kurzform as varchar(10)) FROM t_s_fach_kunde fk " +
                "LEFT JOIN t_s_faecher f on fk.fs_fachid=f.f_id WHERE fk.fs_kundenid=k.kunde_ID AND fk.fs_lk=0 FOR XML PATH('')),1,1,'')) as 'Fächer', kunde_strasse as 'Straße', " +
                "kunde_hausnummer as 'Hausnummer', kunde_postleitzahl as 'Postleitzahl', kunde_ort as 'Wohnort', kunde_mail as 'Mail', kunde_telefonnummer as 'Telefonnummer' " +
                "FROM t_s_kunden k JOIN t_s_klassen kl on k.kunde_klasse=kl.k_id";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// fills a gridview with costumer data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="value"></param>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            grid.DataSource = FillObject();
        }

        /// <summary>
        /// fills a datatable with costumer data
        /// </summary>
        /// <param name="showCostumerClass"></param>
        /// <param name="classId"></param>
        private DataTable FillCostumerDataTable(bool showCostumerClass, int classId)
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string command = showCostumerClass ? "SELECT kunde_ID, kunde_vorname as 'Vorname', kunde_nachname as 'Nachname', " +
                    "kunde_klasse, k_bezeichnung as 'Klasse', ks_klassenstufe as 'Klassenstufe' FROM [dbo].[t_s_kunden] " +
                    "left join [dbo].[t_s_klassen] on k_id = kunde_klasse left join [dbo].[t_s_klasse_stufe] on ks_klasse = kunde_klasse " +
                    "WHERE kunde_activated = 1 AND ks_klassenstufe = @classId" : 
                    "SELECT kunde_ID, kunde_vorname as 'Vorname', kunde_nachname as 'Nachname', kunde_klasse, k_bezeichnung as 'Klasse', " +
                    "ks_klassenstufe as 'Klassenstufe' FROM [dbo].[t_s_kunden] left join [dbo].[t_s_klassen] on k_id = kunde_klasse " +
                    "left join [dbo].[t_s_klasse_stufe] on ks_klasse = kunde_klasse WHERE kunde_activated = 1 AND kunde_klasse = @classId " +
                    "order by Klasse";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@classId", classId);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// fills a gridview with data
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="showCostumerClass"></param>
        /// <param name="classId"></param>
        /// <param name="value"></param>
        public void FillCostumerGrid(ref MetroGrid grid, bool showCostumerClass, int classId, object value = null)
        {
            DataTable table = FillCostumerDataTable(showCostumerClass, classId);
            grid.DataSource = table;
            grid.Columns["kunde_ID"].Visible = false;
            grid.Columns["kunde_klasse"].Visible = false;
            grid.Columns["Klassenstufe"].Visible = false;
            grid.Columns["Vorname"].SortMode = DataGridViewColumnSortMode.NotSortable;
            grid.Columns["Nachname"].SortMode = DataGridViewColumnSortMode.NotSortable;
            if (!showCostumerClass)
            {
                grid.Columns["Klasse"].Visible = false;
            }
            else
            {
                grid.Columns["Klasse"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


    }
}
