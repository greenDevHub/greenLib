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
    class Details
    {
        #region Detail-Typ
        string typid;
        /// <summary>
        /// ID der Sprache
        /// </summary>
        private string DetailTyp { get { return typid; } set { typid = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschaft das Objekt Sprache
        /// </summary>
        public Details()
        {
            FillObject();
        }
        public Details(string typid)
        {
            this.typid = typid;
            //Load();
            FillObject();
           // Buch b = new Buch("978-3608938289");
        }
        #endregion

        #region Fill Object
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_buecher]";

            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);

            con.Close();
        }

        public void FillGrid(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["buch_isbn"].HeaderText = "Bezeichnung";
        }
        #endregion
    }
}
