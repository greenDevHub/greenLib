using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Klassenstufe
    {
        #region Constructor
        string stufe;
        public string Stufe { get { return stufe; } set { stufe = value; } }

        public Klassenstufe()
        {
            FillObject();
        }
        #endregion

        #region Methoden
        #region Fill Object
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            dt.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT k_stufe as 'Klassenstufe' FROM [dbo].[t_s_klassenstufe]";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(dt);

            con.Close();

        }

        public void FillCombobox(ref ComboBox cb, object value)
        {
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "Klassenstufe";
            cb.DisplayMember = "Klassenstufe";
            cb.SelectedValue = value;
        }

        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            grid.DataSource = dt;
        }
        #endregion
        #region Speichern Grid
        public void SaveGrid(ref MetroGrid grid)
        {
            comb = new SqlCommandBuilder(adapter);
            DataTable changes = dt.GetChanges();
            if (changes != null)
            {
                adapter.Update(changes);
            }
        }
        #endregion
        #endregion
    }
}
