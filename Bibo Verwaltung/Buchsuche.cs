using MetroFramework.Controls;
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

        }
        #endregion

        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        DateTime dt = new DateTime();
        DateTime now = new DateTime();

        Autor buchautor = new Autor();
        Verlag buchverlag = new Verlag();
        Genre buchgenre = new Genre();

        /// <summary>
        /// Füllt das DataSet 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT bu_isbn as 'ISBN', aus_rückgabedatum as 'Rückgabedatum', buch_titel as 'Titel', CONVERT(nvarchar, bu_id) as 'ExemplarID', kunde_id as 'Kunden ID', kunde_vorname as 'Vorname', kunde_Nachname as 'Nachname', kunde_klassenstufe as 'Klassenstufe', ger_name as 'Genre', ver_name as 'Verlag', sprach_name as 'Sprache', zu_zustand as 'Zustand', aus_leihnummer as 'Leihnummer' FROM t_s_buchid left join t_s_buecher on bu_isbn = buch_isbn left join t_s_genre on buch_genre_id = ger_id left join t_s_verlag on buch_verlag_id = ver_id left join t_s_sprache on buch_sprache_id = sprach_id left join t_s_zustand on bu_zustandsid = zu_id left join t_bd_ausgeliehen on aus_buchid = bu_id left join t_s_kunden on kunde_ID = aus_kundenid WHERE bu_activated = 1";
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

        //public void ClearObject()
        //{
        //    ClearDataSource();
        //}

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Buchdaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns["Kunden ID"].Visible = false;
            grid.Columns["Leihnummer"].Visible = false;
            Hide_KundenDetails(ref grid);
        }

        /// <summary>
        /// Setzt die Farbe eines DataGridView-Rows anhand der Rückgabestatus 
        /// </summary>
        public void Set_StatusMark(ref MetroGrid grid)
        {
            try
            {
                now = DateTime.Today;

                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    DataGridViewRow row = grid.Rows[i];

                    if (ds.Tables[0].Rows[i]["Leihnummer"].ToString() != "")
                    {
                        dt = DateTime.Parse(ds.Tables[0].Rows[i]["Rückgabedatum"].ToString());
                        dt.ToShortDateString();

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
            }
            catch { }





            //try
            //{

            //    now = DateTime.Today;
            //    for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
            //    {
            //        //foreach (DataGridViewRow row in grid.Rows) { 
            //        //grid.Rows[i].DefaultCellStyle.BackColor = Color.White;

            //        if (ds.Tables[0].Rows[i]["Leihnummer"].ToString() != "")
            //        //if (row.Cells["Leihnummer"].Value.ToString() != "")
            //        {

            //            //dt = DateTime.Parse(date);
            //            dt = DateTime.Parse(ds.Tables[0].Rows[i]["Rückgabedatum"].ToString());
            //            //dt = DateTime.Parse(row.Cells["Rückgabedatum"].Value.ToString());
            //            dt.ToShortDateString();


            //            if (dt < now)
            //            {
            //                grid.Rows[i].DefaultCellStyle.BackColor = Color.Red;
            //                //row.DefaultCellStyle.BackColor = Color.Red;
            //            }
            //            else if (dt == now)
            //            {
            //                grid.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
            //                //grid.RowsDefaultCellStyle.BackColor = Color.Yellow;
            //                //row.DefaultCellStyle.BackColor = Color.Yellow;
            //            }
            //            else
            //            {
            //                grid.Rows[i].DefaultCellStyle.BackColor = Color.LimeGreen;
            //                //row.DefaultCellStyle.BackColor = Color.LimeGreen;
            //            }
            //        }
            //        else
            //        {
            //            grid.Rows[i].DefaultCellStyle.BackColor = Color.White;
            //        }
            //    }
            //    //grid.Refresh();
            //}
            //catch { }
        }

        /// <summary>
        /// Füllt die ComboBoxen Autor, Verlag und Genre
        /// </summary>
        public void FillComboBoxes(ref AdvancedComboBox autor, ref AdvancedComboBox verlag, ref AdvancedComboBox genre)
        {
            buchautor.FillCombobox(ref autor, -1);
            buchverlag.FillCombobox(ref verlag, -1);
            buchgenre.FillCombobox(ref genre, -1);
            if (autor.Text == "")
            {
                autor.Text = "Autor";
            }
            if (verlag.Text == "")
            {
                verlag.Text = "Verlag";
            }
            if (genre.Text == "")
            {
                genre.Text = "Genre";
            }
        }

        /// <summary>
        /// Blendet die Kundeninformationen ein 
        /// </summary>
        public void Show_KundenDetails(ref MetroGrid grid)
        {
            try
            {
                grid.Columns["Vorname"].Visible = true;
                grid.Columns["Nachname"].Visible = true;
                grid.Columns["Klassenstufe"].Visible = true;
                grid.Columns["Kunden ID"].Visible = false;
            }
            catch { }
        }

        /// <summary>
        /// Blendet die Kundeninformationen aus 
        /// </summary>
        public void Hide_KundenDetails(ref MetroGrid grid)
        {
            try
            {
                grid.Columns["Kunden ID"].Visible = false;
                grid.Columns["Vorname"].Visible = false;
                grid.Columns["Nachname"].Visible = false;
                grid.Columns["Klassenstufe"].Visible = false;
            }
            catch { }
        }

        /// <summary>
        /// Zeigt nur verfügbare Exemplare 
        /// </summary>
        public void Show_VerfuegbareExemplare(ref MetroGrid grid)
        {
            try
            {
                ds.Tables[0].DefaultView.RowFilter = string.Format("Leihnummer IS NULL");
                grid.Refresh();
            }
            catch { }
        }

        /// <summary>
        /// Zeigt alle Exemplare 
        /// </summary>
        public void Show_AlleExemplare(ref MetroGrid grid)
        {
            try
            {
                ds.Tables[0].DefaultView.RowFilter = string.Format("ExemplarID IS NOT NULL");
                grid.Refresh();
            }
            catch { }
        }

        /// <summary>
        /// Sucht ein Buch zur Auswahl
        /// </summary>
        public void Execute_BuchSearch(ref MetroGrid grid, string ExemplarID, string ISBN, string Titel, string Autor, string Verlag, string Genre)
        {
            try
            {
                if (ExemplarID == "ExemplarID")
                {
                    ExemplarID = "";
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
                    Verlag = "";
                }
                if (Genre == "Genre")
                {
                    Genre = "";
                }
                //ds.Tables[0].DefaultView.RowFilter = string.Format("ExemplarID LIKE '{0}%' AND ISBN LIKE '{1}%' AND Titel LIKE '{2}%' AND Verlag LIKE '{3}%' AND Genre LIKE '{4}%' AND Autor LIKE '{5}%'", ExemplarID, ISBN, Titel, Verlag, Genre, Autor);
                ds.Tables[0].DefaultView.RowFilter = string.Format("ExemplarID LIKE '{0}%' AND ISBN LIKE '{1}%' AND Titel LIKE '{2}%' AND Verlag LIKE '{3}%' AND Genre LIKE '{4}%'", ExemplarID, ISBN, Titel, Verlag, Genre);
                grid.Refresh();
            }
            catch { }
        }

        /// <summary>
        /// Sucht einen Kunden
        /// </summary>
        public void Execute_KundenSearch(ref MetroGrid grid, string vorname, string nachname, string klassenstufe)
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
                if (klassenstufe == "Klassenstufe")
                {
                    klassenstufe = "";
                }
                ds.Tables[0].DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%' AND Nachname LIKE '{1}%' AND Klassenstufe LIKE '{2}%'", vorname, nachname, klassenstufe);
                grid.Refresh();
            }
            catch { }
        }
    }
}
