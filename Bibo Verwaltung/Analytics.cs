using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bibo_Verwaltung
{
    class Analytics
    {
        #region Objekt Analytics
        /// <summary>
        /// Erschaft das Objekt Analytics.
        /// </summary>
        public Analytics()
        {

        }
        #endregion

        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        public void Markierung(ref DataGridView grid, object value = null)
        {
            int i = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (i == 1)
                {
                    row.DefaultCellStyle.BackColor = Color.Blue;
                    row.DefaultCellStyle.ForeColor = Color.White;
                    i = 0;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                    i = 1;
                }
            }
        }

        #region MAX-Preisanstieg
        private DataSet ResultMaxPreisanstieg = new DataSet();
        /// <summary>
        /// Gibt den hoechsten Preisanstieg jedes Buchtitels zurück (in % oder als Betrag in €).
        /// </summary>
        public void showMaxPreisanstieg(ref DataGridView grid, ref Chart chart, object value = null)
        {
            getMaxPreisanstieg();
            grid.DataSource = ResultMaxPreisanstieg.Tables[0];

            chart.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Preisanstiege der Buchtitel",
                Color = System.Drawing.Color.Green,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Bar
            };

            chart.Series.Add(series);

            chart.Series[0].XValueMember = grid.Columns[0].DataPropertyName;
            chart.Series[0].YValueMembers = grid.Columns[1].DataPropertyName;

            chart.DataSource = grid.DataSource;

            chart.Invalidate();
        }

        private DataSet getMaxPreisanstieg()
        {
            ResultMaxPreisanstieg.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return null;
            string RawCommand = "";
            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            //adapter.SelectCommand.Parameters.AddWithValue("@0", table);
            adapter.Fill(ResultMaxPreisanstieg);
            con.Close();


            return ResultMaxPreisanstieg;
        }
        #endregion

        #region Preisanstieg
        private DataSet ResultPreisanstieg = new DataSet();
        /// <summary>
        /// Gibt die Preisentwicklung eines Buchtitels zurück (in % und als Betrag in €).
        /// </summary>
        public void showPreisanstieg(string ISBN, ref DataGridView grid, ref Chart chart, object value = null)
        {
            grid.DataSource = getPreisanstieg(ISBN).Tables[0];

            chart.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Preisanstieg des Buchtitels",
                Color = System.Drawing.Color.Blue,
                BorderColor = System.Drawing.Color.Blue,
                BorderWidth = 2,
                IsValueShownAsLabel = true, 
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            chart.Series.Add(series);

            chart.Series[0].XValueMember = grid.Columns[0].DataPropertyName;
            chart.Series[0].YValueMembers = grid.Columns[1].DataPropertyName;

            chart.DataSource = grid.DataSource;
            
            chart.Invalidate();
        }

        private DataSet getPreisanstieg(string isbn)
        {
            ResultPreisanstieg.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return null;
            string RawCommand = "SELECT [p_datum] AS 'Datum', [p_preis] AS 'Preis in €' FROM [dbo].[t_s_preis] WHERE [b_isbn] = @isbn order by [p_datum] ASC";
            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@isbn", isbn);
            adapter.Fill(ResultPreisanstieg);
            con.Close();

            return ResultPreisanstieg;
        }
        #endregion

        #region Preisentwicklung
        private DataSet ResultPreisentwicklung = new DataSet();
        private DataSet ResultISBNs = new DataSet();
        /// <summary>
        /// Gibt die Preisentwicklung aller Buchtitel eines Verlages zurück (in % oder als Betrag in €).
        /// </summary>
        public void showPreisschwankungVerlag(ref DataGridView grid, object value = null)
        {
            grid.DataSource = getPreisschwankungVerlag().Tables[0];
        }

        private DataSet getPreisschwankungVerlag()
        {
            ResultPreisentwicklung.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return null;
            string RawCommand = "";
            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            //adapter.SelectCommand.Parameters.AddWithValue("@0", table);
            adapter.Fill(ResultPreisentwicklung);
            con.Close();

            return ResultPreisentwicklung;
        }

        public void showISBNs(ref DataGridView grid, object value = null)
        {
            grid.DataSource = getISBNs().Tables[0];
        }

        private DataSet getISBNs()
        {
            ResultISBNs.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return null;
            string RawCommand = "SELECT [buch_verlag_id] as 'VerlagID', [ver_name] as 'Verlag', [buch_isbn] as 'ISBN' FROM [dbo].[t_s_buecher] left join [t_s_verlag] on [buch_verlag_id] = [ver_id]";
            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            //adapter.SelectCommand.Parameters.AddWithValue("@0", table);
            adapter.Fill(ResultISBNs);
            con.Close();

            return ResultISBNs;
        }


        #endregion

        ///// <summary>
        ///// Gibt den belibtesten Buchtitel/Autor/Verlag/Genre zurück.
        ///// </summary>
        //public void getBest(something)
        //{

        //}

        ///// <summary>
        ///// Gibt die Zerstörungrate eines Benutzers zurück (in %)
        ///// </summary>
        //public void getZerstörungsQuote(byUser)
        //{

        //}

        ///// <summary>
        ///// Gibt den Buecherzuwachs in der Bibliothek zurück (in % oder in Zahlen)
        ///// </summary>
        //public void getBuecherzuwachs()
        //{

        //}

        ///// <summary>
        ///// Gibt die Ausleihquote aller Buchtitel seit der Aufnahme in die Bibliothek zurück (in % oder in Tagen)
        ///// </summary>
        //public void getAusleihQuote()
        //{

        //}

        ///// <summary>
        ///// Gibt die Arbeitsbeteiligung des Personals zurück (in % oder in Zahlen)
        ///// </summary>
        //public void getPersonalQuote()
        //{

        //}

        /////// <summary>
        /////// Gibt die Arbeitsbeteiligung des Personals zurück (in % oder in Zahlen)
        /////// </summary>
        ////public void getAusleihdauer(by Verlag/Autor/Genre)
        ////{

        ////}

        private DataSet ResultAbzutzung = new DataSet();
        public void showAbzutzung(string ISBN, ref DataGridView grid, ref Chart chart, object value = null)
        {
            grid.DataSource = getAbnutzung(ISBN).Tables[0];

            chart.Series.Clear();
            var series = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Abnutzung des Buchtitels",
                Color = System.Drawing.Color.Blue,
                BorderColor = System.Drawing.Color.Blue,
                BorderWidth = 2,
                IsValueShownAsLabel = true,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Line
            };

            chart.Series.Add(series);

            chart.Series[0].XValueMember = grid.Columns[0].DataPropertyName;
            chart.Series[0].YValueMembers = grid.Columns[1].DataPropertyName;

            chart.DataSource = grid.DataSource;

            chart.Invalidate();
        }

        private DataSet getAbnutzung(string isbn)
        {
            ResultAbzutzung.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return null;
            string RawCommand = "SELECT [id_buch], [zu_vor], [zu_nach], [aus_geliehen], [aus_ruckgabe] FROM [dbo].[t_s_verlauf]";
            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            //adapter.SelectCommand.Parameters.AddWithValue("@0", table);
            adapter.Fill(ResultAbzutzung);
            con.Close();


            return ResultAbzutzung;
        }
    }
}
