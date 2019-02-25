using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class BuchFach
    {
        Buch buecher = new Buch();
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region Eigenschaften
        //string zuordnungid;
        //public string ZuordnungID { get { return zuordnungid; } set { zuordnungid = value; } }

        //Fach fach = new Fach();
        //public Fach Fach { get { return fach; } set { fach = value; } }

        //Buch buch = new Buch();
        //public Buch Buch { get { return buch; } set { buch = value; } }

        //List<string> isbnListe = new List<string>();
        //public List<string> IsbnListe { get { return isbnListe; } set { isbnListe = value; } }

        //string klassenstufe;
        //public string Klassenstufe { get { return klassenstufe; }set { klassenstufe = value; } }
        #endregion

        #region Objekt
        public BuchFach()
        {
            FillObject();
        }
        public BuchFach(string id)
        {
            //this.zuordnungid = id;
            LoadBF();
            LoadIsbnBF();
            FillObject();
        }
        #endregion

        /// <summary>
        /// Füllt ein DataSet-Objekt mit den Fach-Bücher-Zuordnungsdatendaten 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bf_isbn as 'ISBN', Convert(nvarchar, bf_fachid) as 'bf_fachid', buch_titel as 'Titel' FROM [dbo].[t_s_buch_fach] left join [dbo].[t_s_buecher] on buch_isbn = bf_isbn order by buch_titel";
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
        /// Markiert die zugeordneten Bücher
        /// </summary>
        private void Set_Mark(ref DataGridView gridBuecher, string fachID, object value = null)
        {
            try
            {
                for (int j = 0; j <= gridBuecher.Rows.Count - 1; j++)
                {
                    DataGridViewRow row = gridBuecher.Rows[j];

                    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                    {
                        if (row.Cells["ISBN"].Value.ToString() == ds.Tables[0].Rows[i]["ISBN"].ToString())
                        {
                            if (ds.Tables[0].Rows[i]["bf_fachid"].ToString() == fachID)
                            {
                                row.Cells["ISBN"].Value = "*" + row.Cells["ISBN"].Value.ToString();
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
        /// Füllt ein DataGridView-Objekt mit den Buchdaten 
        /// </summary>
        public void Show_AllBuecher(ref DataGridView gridBuecher, string fachID, object value = null)
        {
            ClearDataSource();
            FillObject();
            buecher.FillGrid_Short(ref gridBuecher);
            Set_Mark(ref gridBuecher, fachID);
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Fach-Bücher-Zuordnungsdatendaten  
        /// </summary>
        public void Show_FachBuecher(ref DataGridView grid, string fachID, object value = null)
        {
            ClearDataSource();
            FillObject();
            ds.Tables[0].DefaultView.RowFilter = string.Format("bf_fachid LIKE '{0}'", fachID);
            grid.DataSource = ds.Tables[0];
            grid.Columns["bf_fachid"].Visible = false;
        }

        /// <summary>
        /// Überschreibt und speichert die Zuordnungsdatendaten eines Faches mit vorhandenen Büchern in der Datenbank 
        /// </summary>
        public void Save_Zuordnung(DataTable zuordnung, string fachID)
        {
            if (con.ConnectError()) return;
            string RawCommand1 = "DELETE FROM [dbo].[t_s_buch_fach] WHERE bf_fachid = @fachid";
            con.ConnectError();
            SqlCommand cmd1 = new SqlCommand(RawCommand1, con.Con);
            cmd1.Parameters.AddWithValue("@fachid", fachID);
            cmd1.ExecuteNonQuery();

            string RawCommand2 = "INSERT INTO [dbo].[t_s_buch_fach] (bf_isbn, bf_fachid) VALUES (@isbn, @fachid)";
            foreach (DataRow row in zuordnung.Rows)
            {
                SqlCommand cmd2 = new SqlCommand(RawCommand2, con.Con);
                cmd2.Parameters.AddWithValue("@isbn", row[0].ToString());
                cmd2.Parameters.AddWithValue("@fachid", fachID);
                cmd2.ExecuteNonQuery();
            }
            con.Close();
        }










































































        private void LoadBF()
        {
            //SQL_Verbindung con = new SQL_Verbindung();
            //if (con.ConnectError()) return;
            //string RawCommand = "Select * FROM [dbo].[t_bd_buch_fach] WHERE bf_id = @0";
            //SqlDataReader dr = con.ExcecuteCommand(RawCommand, ZuordnungID);
            //while (dr.Read())
            //{
            //    ZuordnungID = dr["bf_id"].ToString();
            //    Fach = new Fach(dr["bf_fachid"].ToString());
            //    Klassenstufe = dr["bf_klassenstufe"].ToString();
            //}
            //dr.Close();
            //con.Close();
        }
        private void LoadIsbnBF()
        {
            //IsbnListe.Clear();
            //SQL_Verbindung con = new SQL_Verbindung();
            //if (con.ConnectError()) return;
            //string RawCommand = "Select * FROM [dbo].[t_s_isbn_buchfach] WHERE ib_bfid = @0";
            //SqlDataReader dr = con.ExcecuteCommand(RawCommand, ZuordnungID);
            //while (dr.Read())
            //{
            //    Buch = new Buch(dr["ib_isbn"].ToString());
            //    IsbnListe.Add(Buch.ISBN);
            //}
            //dr.Close();
            //con.Close();
        }


        public void LoadZuordnungID()
        {
            //SQL_Verbindung con = new SQL_Verbindung();
            //if (con.ConnectError()) return;
            //string RawCommand = "SELECT bf_id FROM [dbo].[t_bd_buch_fach] WHERE bf_fachid = @0 and bf_klassenstufe = @1";
            //SqlDataReader dr = con.ExcecuteCommand(RawCommand, Fach.FachID, Klassenstufe);
            //while (dr.Read())
            //{
            //    ZuordnungID = dr["bf_id"].ToString();
            //}
        }


        //Fügt neue Zuordnung zwischen Fach und Klassenstufe mitsamt einer ZuordnungsID hinzu
        public void AddBF()
        {
            //SQL_Verbindung con = new SQL_Verbindung();
            ////SQL-Verbindung pruefen
            //if (con.ConnectError()) return;
            //string RawCommand = "INSERT INTO [dbo].[t_bd_buch_fach] (bf_fachid, bf_klassenstufe) VALUES (@fachid, @klassenstufe)";
            //SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            //cmd.Parameters.AddWithValue("@fachid", Fach.FachID);
            //cmd.Parameters.AddWithValue("@klassenstufe", Klassenstufe);
            //cmd.ExecuteNonQuery();
            //LoadZuordnungID();
            //AddIsbnBF();
            //con.Close();
        }
        //Fügt neue Zuordnung zwischen Buch (ISBN) und obriger ZuordnungsID hinzu
        public void AddIsbnBF()
        {
            //SQL_Verbindung con = new SQL_Verbindung();
            ////SQL-Verbindung pruefen
            //if (con.ConnectError()) return;
            //string RawCommand = "INSERT INTO [dbo].[t_s_isbn_buchfach] (ib_bfid, ib_isbn) VALUES (@bfid, @isbn)";
            //foreach(string s in IsbnListe)
            //{
            //    SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            //    cmd.Parameters.AddWithValue("@bfid", ZuordnungID);
            //    cmd.Parameters.AddWithValue("@isbn", s);
            //    cmd.ExecuteNonQuery();
            //}
            //con.Close();

        }

        public void Save()
        {
            DeleteIsbnBF();
            AddIsbnBF();
        }

        public void DeleteBF()
        {
            //DeleteIsbnBF();
            //SQL_Verbindung con = new SQL_Verbindung();
            //string RawCommand = "DELETE FROM [dbo].[t_bd_buch_fach] WHERE bf_id = @id";
            //con.ConnectError();
            //SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            //cmd.Parameters.AddWithValue("@id", ZuordnungID);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }
        private void DeleteIsbnBF()
        {
            //SQL_Verbindung con = new SQL_Verbindung();
            //string RawCommand = "DELETE FROM [dbo].[t_s_isbn_buchfach] WHERE ib_bfid = @id";
            //con.ConnectError();
            //SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            //cmd.Parameters.AddWithValue("@id", ZuordnungID);
            //cmd.ExecuteNonQuery();
            //con.Close();
        }

        public string GetID(string fachid, string klassenstufe)
        {
            string id = "";
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT bf_id from t_bd_buch_fach  where bf_fachid = @0 AND bf_klassenstufe = @1";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, fachid, klassenstufe);
            while (dr.Read())
            {
                id = dr["bf_id"].ToString();
            }
            dr.Close();
            con.Close();
            return id;
        }

        //SqlDataAdapter adapter = new SqlDataAdapter();
        //DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        //SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject_alt()
        {
            dt.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            //string RawCommand = "SELECT ib_isbn as 'ISBN', f_kurzform as 'Fach', bf_klassenstufe as 'Klassenstufe', bf_id as 'ID' from [dbo].[t_s_isbn_buchfach] left join [dbo].[t_bd_buch_fach] on bf_id = ib_bfid left join [dbo].[t_s_faecher] on f_id = bf_fachid";
            string RawCommand = "SELECT bf_id as 'ID', f_kurzform as 'Kurzform', f_langform as 'Langform', bf_klassenstufe as 'Klassenstufe' FROM [dbo].[t_bd_buch_fach] left join [dbo].[t_s_faecher] on bf_fachid = f_id";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            //adapter.Fill(ds);
            adapter.Fill(dt);

            //if (ds.Tables[0].Columns.Contains("ISBN"))
            //{
            //    ds.Tables[0].Columns.RemoveAt(ds.Tables[0].Columns.IndexOf("ISBN"));
            //}
            //ds.Tables[0].Columns.Add("ISBN", typeof(System.String));
            //foreach(DataRow row in ds.Tables[0].Rows)
            //{
            //    string text = "";
            //    foreach(string s in IsbnListe.GetNames(row["IsbnListeID"].ToString()))
            //    {
            //        if(s != null && !s.Equals(""))
            //        {
            //            text = text + s + ", ";
            //        }
            //    }
            //    if(text.Length > 2)
            //    {
            //        text = text.Substring(0, text.Length - 2);
            //    }
            //    row["ISBN"] = text;
            //}
            //ds.Tables[0].Columns["ISBN"].SetOrdinal(1);

            con.Close();
        }

        //public string ISBNs()
        //{
        //    string text = "";
        //    foreach (string s in IsbnListe.GetNames(GetIsbnID(ZuordnungID).ToString()))
        //    {
        //        if (s != null && !s.Equals(""))
        //        {
        //            text = text + s + ", ";
        //        }
        //    }
        //    if (text.Length > 2)
        //    {
        //        text = text.Substring(0, text.Length - 2);
        //    }
        //    return text;
        //}


        //public void FillCombobox(ref ComboBox cb, object value)
        //{
        //    FillObject();
        //    cb.DataSource = dt;
        //    cb.ValueMember = "au_id";
        //    cb.DisplayMember = "au_autor";
        //    cb.SelectedValue = value;
        //}
        //public void FillList(ref CheckedListBox clb)
        //{
        //    FillObject();
        //    ((ListBox)clb).DataSource = dt;
        //    ((ListBox)clb).DisplayMember = "au_autor";
        //    ((ListBox)clb).ValueMember = "au_id";
        //}

        private void ClearDS()
        {
            dt.Clear();
        }
 
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            //ClearDS();
            //FillObject();
            //DataTable data = new DataTable();
            //data.Columns.Add("ID");
            //data.Columns.Add("Fach");
            //data.Columns.Add("Klassenstufe");
            //data.Columns.Add("Bücher");
            //foreach(DataRow row in dt.Rows)
            //{
            //    ZuordnungID = row[dt.Columns.IndexOf("ID")].ToString();
            //    Fach.FachKurz = row[dt.Columns.IndexOf("Kurzform")].ToString();
            //    Klassenstufe = row[dt.Columns.IndexOf("Klassenstufe")].ToString();
            //    LoadIsbnBF();
            //    DataRow dataRow = data.NewRow();
            //    dataRow["ID"] = ZuordnungID;
            //    dataRow["Fach"] = Fach.FachKurz;
            //    dataRow["Klassenstufe"] = Klassenstufe;
            //    string isbn = "";
            //    foreach(string s in IsbnListe)
            //    {
            //        isbn = isbn + s + ", ";
            //    }
            //    isbn = isbn.Substring(0, isbn.Length - 2);
            //    dataRow["Bücher"] = isbn;
            //    data.Rows.Add(dataRow);

            //}
            //grid.DataSource = data;

        }

    }
}
