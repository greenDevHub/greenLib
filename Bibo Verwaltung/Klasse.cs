using MetroFramework.Controls;
using System;
using System.Collections;
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
        SqlCommandBuilder comb = new SqlCommandBuilder();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        string klasse;
        /// <summary>
        /// E-Mail Adresse des Kunden
        /// </summary>
        public string Klassename { get { return klasse; } set { klasse = value; } }

        #region Objekt-Constructor
        /// <summary>
        /// Erschaft das Objekt Kunde
        /// </summary>
        public Klasse()
        {
            FillObject();
        }
        #endregion

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
        /// Prüft die Daten aus einen DataGridView-Objekt auf Veränderungen 
        /// </summary>
        public bool GetChangesGrid(ref MetroGrid grid)
        {
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Entfernt Duplikate aus den Changes
        /// </summary>
        /// <param name="changes"></param>
        /// <returns></returns>
        private DataSet noDuplicates(DataSet changes)
        {
            try
            {
                Hashtable hTable = new Hashtable();
                ArrayList duplicateList = new ArrayList();

                //1. Die Changes-Tabelle auf duplikate überprüfen (mehrfache eingabe des selben Wertes)
                foreach(DataRow drow in changes.Tables[0].Rows)
                {
                    if (hTable.Contains(drow[1]))
                    {
                        duplicateList.Add(drow);
                    }
                    else
                    {
                        hTable.Add(drow[1], string.Empty);
                    }
                }
                //Entfernen der Duplikate von 1.
                foreach(DataRow dRow in duplicateList)
                {
                    changes.Tables[0].Rows.Remove(dRow);
                }

                //2. Die Ausgangsdaten auf die Werte überprüfen, die in den Changes sind
                duplicateList.Clear();
                var s = dt.Rows;
                for(int i = 0; i< changes.Tables[0].Rows.Count; i++)
                {
                    string str = changes.Tables[0].Rows[i][1].ToString();
                    bool contains = dt.AsEnumerable().Any(row => str.Equals(row.Field<String>(1),StringComparison.InvariantCultureIgnoreCase));
                    if (contains)
                    {
                        duplicateList.Add(changes.Tables[0].Rows[i]);
                    }
                }
                //Entfernen der Duplikate von 2.
                foreach (DataRow dRow in duplicateList)
                {
                    changes.Tables[0].Rows.Remove(dRow);
                }
                return changes;
            }
            catch (Exception ex)
            {
                return changes;
            }
        }
        /// <summary>
        /// Speichert die Daten aus einen DataGridView-Objekt in die Datenbank 
        /// </summary>
        public void SaveGrid(ref MetroGrid grid)
        {
            comb = new SqlCommandBuilder(adapter);
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                changes = noDuplicates(changes);
                adapter.Update(changes);
            }
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
