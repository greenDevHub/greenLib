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
    class FachStufe
    {
        Fach faecher = new Fach();
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region Eigenschaften des Objekts
        string zuordnungid;
        public string ZuordnungID { get { return zuordnungid; } set { zuordnungid = value; } }

        Fach fach = new Fach();
        public Fach Fach { get { return fach; } set { fach = value; } }

        List<string> fachListe = new List<string>();
        public List<string> FachListe { get { return fachListe; } set { fachListe = value; } }

        Klassenstufe klassenstufe = new Klassenstufe();
        public Klassenstufe Klassenstufe { get { return klassenstufe; } set { klassenstufe = value; } }
        #endregion

        #region Constructor
        /// <summary>
        /// Erschaft das Objekt FachStufe
        /// </summary>
        public FachStufe()
        {

        }
        /// <summary>
        /// Erschaft das Objekt FachStufe
        /// </summary>
        public FachStufe(string stufe)
        {
            this.Klassenstufe.Stufe = stufe;
            LoadZuornung();
        }
        #endregion

        /// <summary>
        /// Füllt ein Listen-Objekt mit den Fach-Klassenstufen-Zuordnungsdatendaten einer Klassenstufe
        /// </summary>
        private void LoadZuornung()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_fach_stufe] WHERE bf_klassenstufe = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, Klassenstufe.Stufe);
            while (dr.Read())
            {
                Fach = new Fach(dr["bf_fachid"].ToString());
                FachListe.Add(Fach.FachKurz);
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Fach-Klassenstufen-Zuordnungsdatendaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bf_fachid, bf_klassenstufe, f_kurzform as 'Kurzbezeichnung', f_langform as 'Langbezeichnung' FROM [dbo].[t_s_fach_stufe] left join [dbo].[t_s_faecher] on f_id = bf_fachid order by f_kurzform";
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
        /// Markiert die zugeordneten Fächer
        /// </summary>
        private void Set_Mark(ref MetroFramework.Controls.MetroGrid gridFaecher, string stufe, object value = null)
        {
            try
            {
                for (int j = 0; j <= gridFaecher.Rows.Count - 1; j++)
                {
                    DataGridViewRow row = gridFaecher.Rows[j];

                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        if (row.Cells["ID"].Value.ToString() == ds.Tables[0].Rows[i]["bf_fachid"].ToString())
                        {
                            if (ds.Tables[0].Rows[i]["bf_klassenstufe"].ToString() == stufe)
                            {
                                row.Cells["Kurzbezeichnung"].Value = "*" + row.Cells["Kurzbezeichnung"].Value.ToString();
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
        /// Füllt ein DataGridView-Objekt mit den Fachdaten 
        /// </summary>
        public void Show_AllFaecher(ref MetroFramework.Controls.MetroGrid Faecher, string Stufe, object value = null)
        {
            ClearDataSource();
            FillObject();
            faecher.FillGrid(ref Faecher);
            Set_Mark(ref Faecher, Stufe);
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Fach-Klassenstufen-Zuordnungsdatendaten  
        /// </summary>
        public void Show_StufenFaecher(ref MetroFramework.Controls.MetroGrid grid, string stufe, object value = null)
        {
            ClearDataSource();
            FillObject();
            ds.Tables[0].DefaultView.RowFilter = string.Format("bf_klassenstufe LIKE '{0}'", stufe);
            grid.DataSource = ds.Tables[0];
            grid.Columns["bf_fachid"].Visible = false;
            grid.Columns["bf_klassenstufe"].Visible = false;
        }

        /// <summary>
        /// Überschreibt und speichert die Zuordnungsdatendaten einer Klassenstufe mit vorhandenen Fächern in der Datenbank 
        /// </summary>
        public void Save_Zuordnung(DataTable zuordnung, string stufe)
        {
            if (con.ConnectError()) return;
            string RawCommand1 = "DELETE FROM [dbo].[t_s_fach_stufe] WHERE bf_klassenstufe = @stufe";
            con.ConnectError();
            SqlCommand cmd1 = new SqlCommand(RawCommand1, con.Con);
            cmd1.Parameters.AddWithValue("@stufe", stufe);
            cmd1.ExecuteNonQuery();

            string RawCommand2 = "INSERT INTO [dbo].[t_s_fach_stufe] (bf_fachid, bf_klassenstufe) VALUES (@fachid, @klassenstufe)";
            foreach (DataRow row in zuordnung.Rows)
            {
                SqlCommand cmd2 = new SqlCommand(RawCommand2, con.Con);
                cmd2.Parameters.AddWithValue("@fachid", row[0].ToString());
                cmd2.Parameters.AddWithValue("@klassenstufe", stufe);
                cmd2.ExecuteNonQuery();
            }
            con.Close();
        }
    }
}