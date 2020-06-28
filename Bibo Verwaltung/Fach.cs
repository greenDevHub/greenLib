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
    class Fach
    {
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region Eigenschaften eine Faches
        string fachid;
        /// <summary>
        /// ID des Faches
        /// </summary>
        public string FachID { get { return fachid; } set { fachid = value; } }

        string fach;
        /// <summary>
        /// Bezeichnung des Faches (Langform)
        /// </summary>
        public string FachLang { get { return fach; } set { fach = value; } }

        string fachkurz;
        /// <summary>
        /// Bezeichnung des Faches (Kurzform)
        /// </summary>
        public string FachKurz { get { return fachkurz; } set { fachkurz = value; } }
        #endregion

        #region Objekt-Constructor
        /// <summary>
        /// Erschaft das Objekt Fach
        /// </summary>
        public Fach()
        {
            FillObject();
        }
        /// <summary>
        /// Erschaft ein Objekt Fach und füllt es mit Werten
        /// </summary>
        public Fach(string fachid)
        {
            this.fachid = fachid;
            LoadFach();
            FillObject();
        }
        #endregion

        /// <summary>
        /// Lädt alle Fachdaten und speichert diese in das Fach-Objekt
        /// </summary>
        private void LoadFach()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_faecher] WHERE f_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, FachID);
            while (dr.Read())
            {
                FachID = dr["f_id"].ToString();
                FachKurz = dr["f_kurzform"].ToString();
                FachLang = dr["f_langform"].ToString();
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Prüft anhand der Kurzbezeichnung ob die Fachdaten in der Datenbank bereits vohanden sind
        /// </summary>
        public bool FachExists()
        {
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT f_id FROM [dbo].[t_s_faecher] WHERE f_kurzform = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, FachKurz);
            while (dr.Read())
            {
                FachID = dr["f_id"].ToString();
            }
            dr.Close();
            con.Close();
            if (FachID == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Fügt ein Fach der Datenbank hinzu 
        /// </summary>
        public void AddFach()
        {
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_faecher] (f_kurzform, f_langform) VALUES (@0, @1)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", FachKurz);
            cmd.Parameters.AddWithValue("@1", FachLang);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Fachdaten 
        /// </summary>
        private void FillObject()
        {
            try
            {
                dt.Clear();
                if (con.ConnectError()) return;
                string RawCommand = "SELECT f_id as 'ID', f_kurzform as 'Kürzel', f_langform as 'Langbezeichnung' FROM [dbo].[t_s_faecher]";
                adapter = new SqlDataAdapter(RawCommand, con.Con);
                adapter.Fill(ds);
                adapter.Fill(dt);
                con.Close();
            }
            catch { }
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Fachdaten 
        /// </summary>
        public void FillGrid(ref MetroFramework.Controls.MetroGrid grid, object value = null)
        {
            ds.Tables[0].Clear();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns["ID"].Visible = false;
        }

        public void FillDT(ref DataTable dt, object value = null)
        {
            ds.Tables[0].Clear();
            FillObject();
            dt = ds.Tables[0];
        }

        /// <summary>
        /// Füllt ein ComboBox-Objekt mit den Fachdaten 
        /// </summary>
        public void FillCombobox(ref AdvancedComboBox cb, object value)
        {
            ds.Tables[0].Clear();
            FillObject();
            cb.DataSource = ds.Tables[0];
            cb.ValueMember = "ID";
            cb.DisplayMember = "Kürzel";
            cb.SelectedValue = value;
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
                foreach (DataRow drow in changes.Tables[0].Rows)
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
                foreach (DataRow dRow in duplicateList)
                {
                    changes.Tables[0].Rows.Remove(dRow);
                }

                //2. Die Ausgangsdaten auf die Werte überprüfen, die in den Changes sind
                duplicateList.Clear();
                var s = dt.Rows;
                for (int i = 0; i < changes.Tables[0].Rows.Count; i++)
                {
                    string str = changes.Tables[0].Rows[i][1].ToString();
                    bool contains = dt.AsEnumerable().Any(row => str.Equals(row.Field<String>(1),StringComparison.InvariantCultureIgnoreCase));
                    string id1 = changes.Tables[0].Rows[i][0].ToString();
                    if(id1 != "")
                    {
                        string str2 = dt.Select("ID = " + id1)[0][1].ToString();
                        if (contains && !str.Equals(str2, StringComparison.InvariantCultureIgnoreCase))
                        {
                            duplicateList.Add(changes.Tables[0].Rows[i]);
                        }
                    }
                    else
                    {
                        if (contains)
                        {
                            duplicateList.Add(changes.Tables[0].Rows[i]);
                        }
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
        /// Speichert ein DataGridView-Objekt in die Datenbank 
        /// </summary>
        public void SaveGrid(ref MetroFramework.Controls.MetroGrid grid)
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
        /// Gibt die Fach-ID anhand der Kurzbezeichnung des Faches zurück 
        /// </summary>
        public string GetIDByShortform(string kurzBezeichnung)
        {
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT f_id FROM [dbo].[t_s_faecher] WHERE f_kurzform = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, kurzBezeichnung);
            while (dr.Read())
            {
                FachID = dr["f_id"].ToString();
            }
            dr.Close();
            con.Close();
            return FachID;
        }

        /// <summary>
        /// Gibt die Kurz- und Langbezeichnung anhand der Fach-ID des Faches zurück 
        /// </summary>
        public string GetLongformByID(string id)
        {
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT f_langform FROM [dbo].[t_s_faecher] WHERE f_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                FachLang = dr["f_langform"].ToString();
            }
            dr.Close();
            con.Close();
            return FachLang;
        }

        /// <summary>
        /// Prüft ob die Kurzbezeichnung des Faches in der DB vorhanden ist 
        /// </summary>
        public bool AlreadyExists()
        {
            string id = "";
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT f_id FROM [dbo].[t_s_faecher] WHERE f_kurzform = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, FachKurz);
            while (dr.Read())
            {
                id = dr["f_id"].ToString();
            }
            dr.Close();
            con.Close();
            if (id == "")
            {
                return false;
            }
            else
            {
                FachID = id;
                return true;
            }
        }
    }
}