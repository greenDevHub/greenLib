using MetroFramework.Controls;
using System.Data;
using System.Data.SqlClient;

namespace Bibo_Verwaltung
{
    class HistoryHelper
    {
        int copyId;
        public HistoryHelper(int id)
        {
            copyId = id;
        }

        #region FillObject
        private DataTable FillObject()
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string command = "SELECT ver_id, id_buch, k_id, kunde_vorname, kunde_nachname, zu_vor, zu_nach, aus_geliehen, aus_ruckgabe " +
                "FROM [dbo].[t_s_verlauf]  left join t_s_kunden on kunde_id = k_id WHERE id_buch = @0";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", copyId);
            adapter.Fill(table);
            con.Close();
            return table;
        }
        #endregion

        #region Fillgrid
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            grid.DataSource = FillObject();
            grid.Columns[0].Visible = false;
            grid.Columns[1].Visible = false;
            grid.Columns[2].Visible = false;
            grid.Columns["zu_vor"].HeaderText = "Zustand vor der Verleihung:";
            grid.Columns["zu_nach"].HeaderText = "Zustand nach der Verleihung:";
            grid.Columns["aus_geliehen"].HeaderText = "Ausleihdatum:";
            grid.Columns["aus_ruckgabe"].HeaderText = "Rückgabedatum:";
            grid.Columns["kunde_vorname"].HeaderText = "Vorname:";
            grid.Columns["kunde_nachname"].HeaderText = "Nachname:";
        }
        #endregion
    }
}
