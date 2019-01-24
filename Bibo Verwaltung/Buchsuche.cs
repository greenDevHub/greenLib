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
    class Buchsuche
    {

        #region Objekt Constructor
        /// <summary>
        /// Erschaft das Objekt Sprache
        /// </summary>
        public Buchsuche()
        {
            FillObject();
        }
        #endregion

        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bu_id as 'ExemplarID', bu_isbn as 'ISBN', buch_titel as 'Titel', "
                + "zu_zustand as 'Zustand', bu_aufnahmedatum as 'Aufnahmedatum', "
                + "ger_name as 'Genre', ver_name as 'Verlag', sprach_name as 'Sprache', a_id as 'AutorlisteID', aus_rückgabedatum as 'Rückgabedatum', aus_leihnummer as 'Leihnummer', "
                + "kunde_id as 'Kunden ID', kunde_vorname as 'Vorname', kunde_Nachname as 'Nachname', kunde_klasse as 'Klasse' FROM t_s_buchid "
                + "left join t_s_buecher on bu_isbn = buch_isbn "
                + "left join t_s_genre on buch_genre_id = ger_id "
                + "left join t_s_autorliste on buch_autor_id = a_id "
                + "left join t_s_verlag on buch_verlag_id = ver_id "
                + "left join t_s_sprache on buch_sprache_id = sprach_id "
                + "left join t_s_zustand on bu_zustandsid = zu_id "
                + "left join t_bd_ausgeliehen on aus_buchid = bu_id "
                + "left join t_s_kunden on kunde_ID = aus_kundenid WHERE bu_activated = 1";

            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);

            //if (ds.Tables[0].Columns.Contains("Autor"))
            //{
            //    ds.Tables[0].Columns.RemoveAt(ds.Tables[0].Columns.IndexOf("Autor"));
            //}
            //ds.Tables[0].Columns.Add("Autor", typeof(System.String));
            //foreach (DataRow row in ds.Tables[0].Rows)
            //{
            //    string text = "";
            //    AutorListe AutorListe = new AutorListe();
            //    foreach (string s in AutorListe.GetNames(row["AutorlisteID"].ToString()))
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
            //    row["Autor"] = text;
            //}
            con.Close();
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt im DataSet 
        /// </summary>
        private void ClearDataSource()
        {
            ds.Tables[0].Rows.Clear();
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Buchdaten 
        /// </summary>
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            Set_StatusMark(ref grid);
            grid.Columns["Kunden ID"].Visible = false;
            grid.Columns["Leihnummer"].Visible = false;
            grid.Columns[ds.Tables[0].Columns.IndexOf("ISBN")].DisplayIndex = 0;
            grid.Columns[ds.Tables[0].Columns.IndexOf("Rückgabedatum")].DisplayIndex = 1;
            grid.Columns[ds.Tables[0].Columns.IndexOf("Titel")].DisplayIndex = 2;
            grid.Columns[ds.Tables[0].Columns.IndexOf("Vorname")].DisplayIndex = 3;
            grid.Columns[ds.Tables[0].Columns.IndexOf("Nachname")].DisplayIndex = 4;
            grid.Columns[ds.Tables[0].Columns.IndexOf("Klasse")].DisplayIndex = 5;
        }

        /// <summary>
        /// Setzt die Farbe eines DataGridView-Rows anhand der Rückgabestatus 
        /// </summary>
        public void Set_StatusMark(ref DataGridView grid)
        {
            try
            {
                foreach (DataGridViewRow row in grid.Rows)
                    if (row.Cells["Leihnummer"].Value.ToString() != "")
                    {
                        string date = row.Cells["Rückgabedatum"].Value.ToString();
                        DateTime dt = new DateTime();
                        dt = DateTime.Parse(date);
                        dt.ToShortDateString();
                        DateTime now = new DateTime();
                        now = DateTime.Today;
                        if (dt < now)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                        }
                        else if (dt == now)
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.LimeGreen;
                        }
                    }
            }
            catch { }
        }

        /// <summary>
        /// Blendet die Kundeninformationen ein 
        /// </summary>
        public void Show_KundenDetails(ref DataGridView grid)
        {
            try
            {
                grid.Columns["Vorname"].Visible = true;
                grid.Columns["Nachname"].Visible = true;
                grid.Columns["Klasse"].Visible = true;
                grid.Columns["Kunden ID"].Visible = false;
                Set_StatusMark(ref grid);
            }
            catch { }
        }

        /// <summary>
        /// Blendet die Kundeninformationen aus 
        /// </summary>
        public void Hide_KundenDetails(ref DataGridView grid)
        {
            try
            {
                grid.Columns["Vorname"].Visible = false;
                grid.Columns["Nachname"].Visible = false;
                grid.Columns["Klasse"].Visible = false;
                grid.Columns["Kunden ID"].Visible = false;
                Set_StatusMark(ref grid);
            }
            catch { }
        }

        /// <summary>
        /// Zeigt nur verfügbare Exemplare 
        /// </summary>
        public void Show_VerfuegbareExemplare(ref DataGridView grid, bool Status, string zustandName)
        {
            try
            {
                if (Status)
                {
                    (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Leihnummer IS NULL");
                }
                else
                {
                    (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("ISBN IS NOT NULL");
                }
                //ds.Tables[0].DefaultView.RowFilter = string.Format("Leihnummer LIKE '{0}%'AND Zustand LIKE '{1}%'", "", zustandName);
                //grid.DataSource = ds.Tables[0];

                //DataTable dt = (grid.DataSource as DataTable);
                //DataTable dtClone = dt.Clone(); //just copy structure, no data


                //for (int i = 0; i < dtClone.Columns.Count; i++)
                //{
                //    if (dtClone.Columns[i].DataType != typeof(string))
                //        dtClone.Columns[i].DataType = typeof(string);
                //}

                //foreach (DataRow dr in dt.Rows)
                //{
                //    dtClone.ImportRow(dr);
                //}

                // dtClone.DefaultView.RowFilter = string.Format("Leihnummer LIKE '{0}%'AND Zustand LIKE '{1}%'", "", zustandName);
                //(grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Leihnummer IS NULL AND Zustand LIKE '{0}%'", zustandName);
                
                //foreach (DataGridViewRow row in grid.Rows)
                //{
                //    string vergleich = "";
                //    if (vergleich.Equals(row.Cells["Leihnummer"].Value.ToString()) == false | zustandName.Equals(row.Cells["Zustand"].Value.ToString()) == true)
                //    {
                //        CurrencyManager hideRow = (CurrencyManager)grid.BindingContext[grid.DataSource];
                //        hideRow.SuspendBinding();
                //        grid.Rows[row.Index].Visible = false;
                //        hideRow.ResumeBinding();
                //    }
                //}

            }
            catch { }
        }

        /// <summary>
        /// Zeigt alle Exemplare 
        /// </summary>
        public void Show_AlleExemplare(ref DataGridView grid)
        {
            try
            {
                foreach (DataGridViewRow row in grid.Rows)
                {
                    grid.Rows[row.Index].Visible = true;
                }
            }
            catch { }
        }

        /// <summary>
        /// Sucht ein Buch zur Auswahl
        /// </summary>
        public void Execute_BuchSearch(ref DataGridView grid, string ExemplarID, string ISBN, string Titel, string Autor, string Verlag, string Genre)
        {
            if (ExemplarID == "ExemplarID")
            {
                ExemplarID = "0";
            }
            if (ISBN == "ISBN")
            {
                ISBN = "";
            }
            if (Titel == "Titel")
            {
                Titel = "";
            }
            if (Autor == "Autor")
            {
                Autor = "";
            }
            if (Verlag == "Verlag")
            {
                Verlag = "0";
            }
            if (Genre == "Genre")
            {
                Genre = "0";
            }
            //(grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("ExemplarID LIKE '{0}%'AND ISBN LIKE '{1}%'AND Titel LIKE '{2}%'AND Verlag LIKE '{3}%'AND Genre LIKE '{4}%'", Convert.ToInt32(ExemplarID), ISBN, Titel, Verlag, Genre);

            //(grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("ExemplarID LIKE '{0}%'AND ISBN LIKE '{1}%'AND Titel LIKE '{2}%'AND Autor LIKE '{3}%'AND Verlag LIKE '{4}%'AND Genre LIKE '{5}%'", Convert.ToInt32(ExemplarID), ISBN, Titel, Autor, Verlag, Genre);
            Set_StatusMark(ref grid);
        }

        /// <summary>
        /// Sucht einen Kunden
        /// </summary>
        public void Execute_KundenSearch(ref DataGridView grid, string vorname, string nachname, string klasse)
        {
            try
            {
                if (vorname == "Vorname")
                {
                    vorname = "";
                }
                if (nachname == "Nachname")
                {
                    nachname = "";
                }
                if (klasse == "Klasse")
                {
                    klasse = "";
                }
            (grid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%'AND Klasse LIKE '{2}%'", vorname, nachname, klasse);
                Set_StatusMark(ref grid);
            }
            catch { }
        }
    }
}
