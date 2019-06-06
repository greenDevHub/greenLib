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
    class Klasse
    {
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        /// <summary>
        /// Füllt das DataSet 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT k_id as 'KlassenID', k_bezeichnung as 'Klasse' from t_s_klassen";
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
        /// Füllt ein DataGridView-Objekt mit den Klassendaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns["KlassenID"].Visible = false;
        }

        /// <summary>
        /// Gibt die ID der Klasse zurück (bei nicht gefunden Wert = 0) 
        /// </summary>
        public int GetID(string klasse)
        {
            int ID = 0;
            if (con.ConnectError()) return 0;
            string RawCommand = "SELECT k_id FROM [dbo].[t_s_klassen] WHERE k_bezeichnung = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, klasse);
            while (dr.Read())
            {
                ID = Convert.ToInt32(dr["k_id"].ToString());
            }
            dr.Close();
            con.Close();
            return ID;
        }

        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            ClearDataSource();
            FillObject();
            cb.DataSource = ds.Tables[0];
            cb.ValueMember = "KlassenID";
            cb.DisplayMember = "Klasse";
            cb.SelectedValue = value;
        }
    }
}
