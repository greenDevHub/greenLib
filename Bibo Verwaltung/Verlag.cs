﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Verlag
    {
        #region Verlag Eigenschafen
        string verlagid;
        /// <summary>
        /// ID des Verlags
        /// </summary>
        public string VerlagID { get { return verlagid; } set { verlagid = value; } }

        string verlagname;
        /// <summary>
        /// Name des Verlags
        /// </summary>
        public string Verlagname { get { return verlagname; } set { verlagname = value; } }
        #endregion

        #region Objekt Verlag
        /// <summary>
        /// Erschaft das Objekt Verlag
        /// </summary>
        public Verlag()
        {
            FillObject();
        }
        public Verlag(string verlagid)
        {
            this.verlagid = verlagid;
            Load();
            FillObject();
        }
        #endregion

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_verlag] WHERE ver_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, verlagid);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                VerlagID = dr["ver_id"].ToString();
                Verlagname = dr["ver_name"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
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
            string RawCommand = "SELECT * FROM [dbo].[t_s_verlag]";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);

            con.Close();
        }

        public void FillCombobox(ref ComboBox cb, object value)
        {
            cb.DataSource = dt;
            cb.ValueMember = "ver_id";
            cb.DisplayMember = "ver_name";
            cb.SelectedValue = value;
        }
  
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["ver_name"].HeaderText = "Bezeichnung";
        }
        #endregion

        #region Speichern Grid
        public void SaveGrid(ref DataGridView grid)
        {
            comb = new SqlCommandBuilder(adapter);
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                adapter.Update(changes);
            }
        }
        #endregion
    }
}
