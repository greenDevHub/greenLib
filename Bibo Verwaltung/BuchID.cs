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
    class BuchID
    {
        SQL_Verbindung con = new SQL_Verbindung();

        #region BuchID Eigenschaften
        string id;
        public string ID { get { return id; } set { id = value; } }

        string isbn;
        public string ISBN { get { return isbn; } set { isbn = value; } }

        string titel;
        public string Titel { get { return titel; } set { titel = value; } }

        Zustand zustand = new Zustand();
        public Zustand Zustand { get { return zustand; } set { zustand = value; } }

        DateTime aufnahmedatum;
        public DateTime Aufnahmedatum { get { return aufnahmedatum; } set { aufnahmedatum = value; } }
        #endregion

        #region Objekt BuchID
        public BuchID()
        {
            FillObject();
        }
        public BuchID(string id)
        {
            this.id = id;
            Load();
            FillObject();
        }
        #endregion

        #region Load
        private void Load()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bu_id, bu_isbn, buch_titel, bu_zustandsid, isnull(bu_aufnahmedatum, '01.01.1990') as 'verified_aufnahmedatum' from t_s_buchid left join t_s_zustand on bu_zustandsid = zu_id left join t_s_buecher on bu_isbn = buch_isbn where bu_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                ID = dr["bu_id"].ToString();
                ISBN = dr["bu_isbn"].ToString();
                Titel = dr["buch_titel"].ToString();
                Zustand = new Zustand(dr["bu_zustandsid"].ToString());
                Aufnahmedatum = (DateTime)dr["verified_aufnahmedatum"];
            }
            dr.Close();
            con.Close();
        }
        #endregion

        #region Add
        public void Add()
        {
            string RawCommand = "Insert INTO t_s_buchid (bu_isbn, bu_zustandsid, bu_aufnahmedatum) VALUES (@isbn, @zustandsid, @aufnahmedatum)";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", ISBN);
            cmd.Parameters.AddWithValue("@zustandsid", Zustand.ZustandID);
            cmd.Parameters.AddWithValue("@aufnahmedatum", Aufnahmedatum);
            // Verbindung öffnen
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();

        }
        #endregion

        #region Save
        public void Save()
        {
            string RawCommand = "UPDATE t_s_buchid set bu_zustandsid = @zustandsid, bu_aufnahmedatum = @datum WHERE bu_id = @id";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@zustandsid", Zustand.ZustandID);
            cmd.Parameters.AddWithValue("@datum", Aufnahmedatum);
            cmd.Parameters.AddWithValue("@id", ID);
            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
        #endregion

        #region Delete
        public void Delete()
        {
            string RawCommand = "DELETE FROM [dbo].[t_s_buchid] WHERE bu_id = @id";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@id", ID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteWhereISBN(string isbn)
        {
            string RawCommand = "DELETE FROM [dbo].[t_s_buchid] WHERE bu_isbn = @isbn";
            con.ConnectError();
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@isbn", isbn);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region FillObject
        SqlDataAdapter adapter2 = new SqlDataAdapter();
        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable();
        SqlCommandBuilder comb2 = new SqlCommandBuilder();
        SQL_Verbindung con2 = new SQL_Verbindung();
        public void FillObject()
        {
            if (con2.ConnectError()) return;
            string RawCommand = "SELECT bu_id as BuchID, bu_isbn as ISBN, buch_titel as Titel, bu_aufnahmedatum as Aufnahmedatum, zu_zustand as Zustand from t_s_buchid left join t_s_zustand on bu_zustandsid = zu_id left join t_s_buecher on bu_isbn = buch_isbn where bu_isbn = @isbn";
            //string RawCommand = "SELECT bu_id as 'BuchID', buch_isbn as 'ISBN', buch_titel as 'Titel', zu_zustand 'Zustand', zu_verleihfähig as 'Verleihbar', bu_aufnahmedatum as 'Aufnahmedatum' from t_s_buchid left join t_s_zustand on bu_zustand_id left join t_s_buecher on bu_isbn = buch_isbn";
            adapter2 = new SqlDataAdapter(RawCommand, con2.Con);
            if (ISBN == null)
            {
                System.Windows.Forms.Form f = System.Windows.Forms.Application.OpenForms["w_s_buecher"];
                ISBN = ((w_s_buecher)f).tb_ISBN.Text;
                
            }
            adapter2.SelectCommand.Parameters.AddWithValue("@isbn",ISBN);
            adapter2.Fill(ds2);
            adapter2.Fill(dt2);
            con2.Close();
        }
        #endregion

        #region FillGrid
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds2.Tables[0];
        }
        #endregion

        #region ClearDS
        public void ClearDS()
        {
            ds2.Tables[0].Rows.Clear();
        }
        #endregion

    }
}