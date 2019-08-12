﻿using MetroFramework.Controls;
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
        /// Erschaft das Objekt Buchsuche
        /// </summary>
        public Buchsuche()
        {

        }
        #endregion

        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        Protokoll log = new Protokoll();

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
            string RawCommand = "SELECT bu_isbn as 'ISBN', aus_rückgabedatum as 'Rückgabedatum', buch_titel as 'Titel', CONVERT(nvarchar, bu_id) as 'ExemplarID', kunde_id as 'Kunden ID', kunde_vorname as 'Vorname', kunde_Nachname as 'Nachname', kunde_klasse as 'Klasse', ger_name as 'Genre', ver_name as 'Verlag', sprach_name as 'Sprache', zu_zustand as 'Zustand', aus_leihnummer as 'Leihnummer' FROM t_s_buchid left join t_s_buecher on bu_isbn = buch_isbn left join t_s_genre on buch_genre_id = ger_id left join t_s_verlag on buch_verlag_id = ver_id left join t_s_sprache on buch_sprache_id = sprach_id left join t_s_zustand on bu_zustandsid = zu_id left join t_bd_ausgeliehen on aus_buchid = bu_id left join t_s_kunden on kunde_ID = aus_kundenid WHERE bu_activated = 1";
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
                ds.Reset();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit den Buchdaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            //grid.Columns["Kunden ID"].Visible = false;
            //grid.Columns["Leihnummer"].Visible = false;
            Hide_KundenDetails(ref grid);
        }

        /// <summary>
        /// Setzt die Farbe eines DataGridView-Rows anhand der Rückgabestatus 
        /// </summary>
        public void Set_StatusMark(ref MetroGrid grid, List<string> blackList)
        {
            try
            {
                now = DateTime.Today;
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    DataGridViewRow row = grid.Rows[i];
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Gray;
                    if (row.Cells["Leihnummer"].Value.ToString() != "")
                    {
                        string s = row.Cells["Rückgabedatum"].Value.ToString();
                        dt = DateTime.Parse(s);
                        dt.ToShortDateString();

                        if (dt < now)
                        {
                            row.DefaultCellStyle.BackColor = Color.Red;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else if (dt == now)
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            row.DefaultCellStyle.BackColor = Color.LimeGreen;
                            row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    if (blackList.Contains(row.Cells["ExemplarID"].Value.ToString()))
                    {
                        row.DefaultCellStyle.ForeColor = Color.White;
                        row.DefaultCellStyle.BackColor = Color.Black;
                    }
                }
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }
        public void Set_StatusMarkNew(ref MetroGrid grid, ref List<int> BackRedForeBlack, ref List<int> BackYellowForeBlack, ref List<int> BackLimeForeBlack, ref List<int> BackBlackForeWhite, List<string> blackList)
        {
            try
            {
                now = DateTime.Today;

                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    //DataTable dataTable = new DataTable();
                    //dataTable = (DataTable)grid.DataSource;
                    //DataRow row = dataTable.Rows[i];

                    if (ds.Tables[0].Rows[i]["Leihnummer"].ToString() != "")
                    {
                        dt = DateTime.Parse(ds.Tables[0].Rows[i]["Rückgabedatum"].ToString());
                        dt.ToShortDateString();

                        if (dt < now)
                        {
                            BackRedForeBlack.Add(i);
                            //row.DefaultCellStyle.BackColor = Color.Red;
                            //row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else if (dt == now)
                        {
                            BackYellowForeBlack.Add(i);
                            //row.DefaultCellStyle.BackColor = Color.Yellow;
                            //row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                        else
                        {
                            BackLimeForeBlack.Add(i);
                            //row.DefaultCellStyle.BackColor = Color.LimeGreen;
                            //row.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    if (blackList.Contains(ds.Tables[0].Rows[i]["ExemplarID"].ToString()))
                    {
                        BackBlackForeWhite.Add(i);
                        //row.DefaultCellStyle.ForeColor = Color.White;
                        //row.DefaultCellStyle.BackColor = Color.Black;
                    }
                }
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
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
                grid.Columns["Klasse"].Visible = true;
                grid.Columns["Kunden ID"].Visible = false;
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
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
                grid.Columns["Klasse"].Visible = false;
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// Zeigt nur nicht überfällige Exemplare 
        /// </summary>
        public void Show_GreenExemplare(ref MetroGrid grid)
        {
            try
            {
                ds.Tables[0].DefaultView.RowFilter = string.Format("Rückgabedatum > '{0}'", DateTime.Now.Date.ToShortDateString());
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// Zeigt nur überfällige Exemplare 
        /// </summary>
        public void Show_RedExemplare(ref MetroGrid grid)
        {
            try
            {
                ds.Tables[0].DefaultView.RowFilter = string.Format("Rückgabedatum < '{0}'", DateTime.Now.Date.ToShortDateString());
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// Zeigt nur heute überfällige Exemplare 
        /// </summary>
        public void Show_YellowExemplare(ref MetroGrid grid)
        {
            try
            {
                ds.Tables[0].DefaultView.RowFilter = string.Format("Rückgabedatum = '{0}'", DateTime.Now.Date.ToShortDateString());
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
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
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
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
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
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
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// Sucht einen Kunden
        /// </summary>
        public void Execute_KundenSearch(ref MetroGrid grid, string vorname, string nachname, string klasse)
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
                if (klasse == "Klassenstufe")
                {
                    klasse = "";
                }
                ds.Tables[0].DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%' AND Nachname LIKE '{1}%' AND Klasse LIKE '{2}%'", vorname, nachname, klasse);
                grid.Refresh();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }
    }
}
