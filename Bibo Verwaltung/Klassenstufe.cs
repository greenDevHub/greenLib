using MetroFramework.Controls;
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
    class Klassenstufe
    {
        SQL_Verbindung con = new SQL_Verbindung();
        Klasse klasse = new Klasse();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region Constructor
        string stufe;
        public string Stufe { get { return stufe; } set { stufe = value; } }

        public Klassenstufe()
        {
            FillObject();
        }
        #endregion





        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Klassenstufen-Klasse-Zuordnungsdatendaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT ks_klassenstufe as 'Klassenstufe', ks_klasse, k_bezeichnung as 'Klasse' FROM [dbo].[t_s_klasse_stufe] left join [dbo].[t_s_klassen] on k_id = ks_klasse order by ks_klasse";
            //SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
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
        /// Markiert die zugeordneten Klassen
        /// </summary>
        private void Set_Mark(ref MetroFramework.Controls.MetroGrid grid, string stufe, object value = null)
        {
            try
            {
                for (int j = 0; j <= grid.Rows.Count - 1; j++)
                {
                    DataGridViewRow row = grid.Rows[j];

                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        if (row.Cells["KlassenID"].Value.ToString() == ds.Tables[0].Rows[i]["ks_klasse"].ToString())
                        {
                            if (ds.Tables[0].Rows[i]["Klassenstufe"].ToString() == stufe)
                            {
                                row.Cells["Klasse"].Value = "*" + row.Cells["Klasse"].Value.ToString();
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
        /// Füllt ein DataGridView-Objekt mit den Klassendaten 
        /// </summary>
        public void Show_AllKlassen(ref MetroFramework.Controls.MetroGrid grid, string Stufe, object value = null)
        {
            ClearDataSource();
            FillObject();
            klasse.FillGrid(ref grid);
            Set_Mark(ref grid, Stufe);
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Buch-Klassenstufen-Zuordnungsdatendaten  
        /// </summary>
        public void Show_StufenKlassen(ref MetroFramework.Controls.MetroGrid grid, string stufe, object value = null)
        {
            ClearDataSource();
            FillObject();
            ds.Tables[0].DefaultView.RowFilter = string.Format("Klassenstufe LIKE '{0}'", stufe);
            grid.DataSource = ds.Tables[0];
            grid.Columns["Klassenstufe"].Visible = false;
        }

        /// <summary>
        /// Überschreibt und speichert die Zuordnungsdatendaten einer Klassenstufe mit vorhandenen Klassen in der Datenbank 
        /// </summary>
        public void Save_Zuordnung(DataTable zuordnung, string stufe)
        {
            if (con.ConnectError()) return;
            string RawCommand1 = "DELETE FROM [dbo].[t_s_klasse_stufe] WHERE ks_klassenstufe = @stufe";
            con.ConnectError();
            SqlCommand cmd1 = new SqlCommand(RawCommand1, con.Con);
            cmd1.Parameters.AddWithValue("@stufe", stufe);
            cmd1.ExecuteNonQuery();

            string RawCommand2 = "INSERT INTO [dbo].[t_s_klasse_stufe] (ks_klasse, ks_klassenstufe) VALUES (@klasse, @klassenstufe)";
            foreach (DataRow row in zuordnung.Rows)
            {
                SqlCommand cmd2 = new SqlCommand(RawCommand2, con.Con);
                cmd2.Parameters.AddWithValue("@klasse", row[0].ToString());
                cmd2.Parameters.AddWithValue("@klassenstufe", stufe);
                cmd2.ExecuteNonQuery();
            }
            con.Close();
        }



















        //#region Methoden
        //#region Fill Object
        //SqlDataAdapter adapter = new SqlDataAdapter();
        //DataTable dt = new DataTable();
        //SqlCommandBuilder comb = new SqlCommandBuilder();
        //private void FillObject()
        //{
        //    //dt.Clear();
        //    //SQL_Verbindung con = new SQL_Verbindung();
        //    //if (con.ConnectError()) return;
        //    //string RawCommand = "SELECT k_stufe as 'Klassenstufe' FROM [dbo].[t_s_klassenstufe]";

        //    //// Verbindung öffnen 
        //    //adapter = new SqlDataAdapter(RawCommand, con.Con);
        //    //adapter.Fill(dt);

        //    //con.Close();

        //}

        //public void FillCombobox(ref ComboBox cb, object value)
        //{
        //    //FillObject();
        //    //cb.DataSource = dt;
        //    //cb.ValueMember = "Klassenstufe";
        //    //cb.DisplayMember = "Klassenstufe";
        //    //cb.SelectedValue = value;
        //}

        //public void FillGrid(ref MetroGrid grid, object value = null)
        //{
        //    grid.DataSource = dt;
        //}
        //#endregion
        //#region Speichern Grid
        //public void SaveGrid(ref MetroGrid grid)
        //{
        //    comb = new SqlCommandBuilder(adapter);
        //    DataTable changes = dt.GetChanges();
        //    if (changes != null)
        //    {
        //        adapter.Update(changes);
        //    }
        //}
        //#endregion
        //#endregion
    }
}
