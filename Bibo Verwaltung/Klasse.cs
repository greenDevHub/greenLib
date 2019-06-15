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
        string klasse;
        /// <summary>
        /// E-Mail Adresse des Kunden
        /// </summary>
        public string Klassename { get { return klasse; } set { klasse = value; } }
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        /// <summary>
        /// Füllt das DataSet 
        /// </summary>
        private void FillObject()
        {
            dt.Clear();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT k_id as 'KlassenID', k_bezeichnung as 'Klasse' from t_s_klassen";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
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
        public int GetID(string klassename)
        {
            int ID = 0;
            if (con.ConnectError()) return 0;
            string RawCommand = "SELECT k_id FROM [dbo].[t_s_klassen] WHERE k_bezeichnung = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, klassename);
            while (dr.Read())
            {
                ID = Convert.ToInt32(dr["k_id"].ToString());
            }
            dr.Close();
            con.Close();
            return ID;
        }

        public string GetName(string id)
        {
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT k_bezeichnung FROM [dbo].[t_s_klassen] WHERE k_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                Klassename = dr["k_bezeichnung"].ToString();
            }
            dr.Close();
            con.Close();
            return Klassename;
        }

        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            ClearDataSource();
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "KlassenID";
            cb.DisplayMember = "Klasse";
            cb.SelectedValue = value;
        }
        private bool AlreadyExists(string klassename)
        {
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT k_id from [dbo].[t_s_klassen] where k_bezeichnung=@0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, klassename);
            dr.Read();
            if (dr.HasRows)
            {
                dr.Close();
                con.Close();
                return true;
            }
            else
            {
                dr.Close();
                con.Close();
                return false;
            }
        }
        public void AddKlasse(string klassename)
        {
            if (!AlreadyExists(klassename))
            {
                if (con.ConnectError()) return;
                string RawCommand = "INSERT INTO [dbo].[t_s_klassen] (k_bezeichnung) VALUES (@klasse)";
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                cmd.Parameters.AddWithValue("@klasse", klassename);
                // Verbindung öffnen 
                cmd.ExecuteNonQuery();
                //Verbindung schließen
                con.Close();
            }

        }
    }
}
