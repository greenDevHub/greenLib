﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Verlauf
    {
        public Verlauf(string id)
        {
            FillObject(id);
        }

        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region FillObject
        private void FillObject(string buchid)
        {
            dt.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT ver_id, id_buch, k_id, kunde_vorname, kunde_nachname, zu_vor, zu_nach, aus_geliehen, aus_ruckgabe FROM [dbo].[t_s_verlauf]  left join t_s_kunden on kunde_id = k_id WHERE id_buch = @0";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", buchid);
            adapter.Fill(ds);
            adapter.Fill(dt);

            con.Close();
        }
        #endregion

        #region Fillgrid
        public void FillGrid(ref MetroFramework.Controls.MetroGrid grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
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
