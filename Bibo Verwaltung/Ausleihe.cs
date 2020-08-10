using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Ausleihe
    {
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        #region Ausleihe Eigenschaften
        string kid;
        /// <summary>
        /// Kunden Nummer eines Exemplars
        /// </summary>
        public string KID { get { return kid; } set { kid = value; } }

        string exemplarID;
        /// <summary>
        /// Leihdatum eines Exemplars
        /// </summary>
        public string ExemplarID { get { return exemplarID; } set { exemplarID = value; } }

        DateTime rueckgabedatum;
        /// <summary>
        /// Rueckgabedatum eines Exemplars
        /// </summary>
        public DateTime Rueckgabedatum { get { return rueckgabedatum; } set { rueckgabedatum = value; } }

        DataTable leihListe = new DataTable();
        /// <summary>
        /// Liste der zur Ausleihe ausgewaehlten Exemplare 
        /// </summary>
        public DataTable LeihListe { get { return leihListe; } set { leihListe = value; } }

        bool verfuegbar;
        /// <summary>
        /// Status des Exemplars
        /// </summary>
        public bool Verfuegbar { get { return verfuegbar; } set { verfuegbar = value; } }
        #endregion

        /// <summary>
        /// Prüft die Buchausleihliste auf das Vorhandensein der aktuellen Exemlar ID 
        /// </summary>
        public bool CheckLeihList()
        {
            bool result = false;
            for (int i = 0; i <= LeihListe.Rows.Count - 1; i++)
            {
                if (LeihListe.Rows[i][0].ToString() == ExemplarID)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Übernimmt eine vorgefertigte Liste in die Buchausleihliste 
        /// </summary>
        public void FillAusleihListe(string[] inputList)
        {
            try
            {
                ClearLeihList();
                DataRow relation;
                string[] exemlarDetails = new string[2];

                if (LeihListe.Columns.Count != 2)
                {
                    LeihListe.Columns.Add();
                    LeihListe.Columns.Add();
                }

                for (int i = 0; i <= inputList.Length - 1; i++)
                {
                    exemlarDetails[0] = inputList[i];
                    exemlarDetails[1] = DateTime.Now.Date.ToShortDateString();
                    relation = LeihListe.NewRow();
                    relation.ItemArray = exemlarDetails;
                    LeihListe.Rows.Add(relation);
                }
            }
            catch
            {
                MessageBox.Show("Beim Laden der Liste in die Buchausleihliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gibt den Row-Index der ExemplarID in der Buchausleihliste wieder
        /// </summary>
        public int GetIndexInLeihliste()
        {
            int result = -1;
            for (int i = 0; i <= LeihListe.Rows.Count - 1; i++)
            {
                if (LeihListe.Rows[i][0].ToString() == ExemplarID)
                {
                    result = i;
                }
            }
            return result;
        }

        /// <summary>
        /// Baut einen Dialogstring abhängig von der Buchausleih-Anzahl
        /// </summary>
        public String GetListInfo()
        {
            Buch exemplar;
            StringBuilder sb = new StringBuilder();
            sb.Append("Derzeit sind folgende Titel in der Auswahlliste: ");
            sb.AppendLine();
            sb.AppendLine();

            if (LeihListe.Rows.Count > 0)
            {
                for (int i = 0; i < LeihListe.Rows.Count; i++)
                {
                    exemplar = new Buch(new Exemplar(LeihListe.Rows[i][0].ToString()).ISBN);
                    sb.Append("-  ");
                    sb.Append(TrimText(exemplar.Titel, 30));
                    if (i < LeihListe.Rows.Count)
                    {
                        sb.Append(", ");
                    }
                    sb.AppendLine();
                }
            }
            else
            {
                sb.Append("keine Einträge");
            }
            sb.AppendLine();
            return sb.ToString();
        }

        /// <summary>
        /// Zeigt das Buchcoder eines Exemplars in einer PictureBox
        /// </summary>
        public void ShowBuchCover(ref PictureBox picBox_Buchcover)
        {
            try
            {
                Buch buchCover = new Buch(new Exemplar(ExemplarID).ISBN);
                if (buchCover.Image != null)
                {
                    MemoryStream mem = new MemoryStream(buchCover.Image);
                    picBox_Buchcover.Image = Image.FromStream(mem);
                }
                else
                {
                    picBox_Buchcover.Image = null;
                }
            }
            catch
            {
            }
        }

        /// <summary>
        /// Baut einen Dialogstring abhängig von der Buchausleih-Anzahl
        /// </summary>
        public String GetAusleihList()
        {
            Buch exemplar;
            StringBuilder sb = new StringBuilder();
            sb.Append("Möchten Sie ");

            if (LeihListe.Rows.Count == 1)
            {
                exemplar = new Buch(new Exemplar(LeihListe.Rows[0][0].ToString()).ISBN);
                sb.Append("das Buch: ");
                sb.AppendLine();
                sb.AppendLine();
                sb.Append(TrimText(exemplar.Titel, 30));
                sb.Append(", ");
                sb.AppendLine();
                sb.AppendLine();
            }
            else
            {
                sb.Append("die Bücher: ");
                sb.AppendLine();
                sb.AppendLine();
                for (int i = 0; i < LeihListe.Rows.Count; i++)
                {
                    exemplar = new Buch(new Exemplar(LeihListe.Rows[i][0].ToString()).ISBN);
                    sb.Append("-  ");
                    sb.Append(TrimText(exemplar.Titel, 30));
                    sb.Append(", ");
                    sb.AppendLine();
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        /// <summary>
        /// Schneidet einen String auf eine bestimmte Länge von Zeichen
        /// </summary>
        public String TrimText(string inputText, int maxLength)
        {
            string outputText = "";
            if (inputText.Length > maxLength)
            {
                outputText = inputText.Substring(0, maxLength) + "...";
            }
            else
            {
                outputText = inputText;
            }
            return outputText.Trim();
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt der Ausleihliste 
        /// </summary>
        public void ClearLeihList()
        {
            try
            {
                LeihListe.Rows.Clear();
            }
            catch { }
        }

        /// <summary>
        /// Setzt den Auswahl-Slider anhand der Elemente der Ausleihliste
        /// </summary>
        public void SetSlider(ref HScrollBar leihList_Slider, ref MetroFramework.Controls.MetroTextBox tb_listVon, ref MetroFramework.Controls.MetroTextBox tb_listBis)
        {
            if (LeihListe.Rows.Count == 0)
            {
                leihList_Slider.Enabled = false;
                leihList_Slider.Minimum = 0;
                leihList_Slider.Maximum = 0;
            }
            else
            {
                leihList_Slider.Enabled = true;
                leihList_Slider.Minimum = 1;
                leihList_Slider.Maximum = LeihListe.Rows.Count;
                leihList_Slider.Value = leihList_Slider.Maximum;
            }
            tb_listVon.Text = leihList_Slider.Value.ToString();
            tb_listBis.Text = leihList_Slider.Maximum.ToString();
        }

        /// <summary>
        /// Fügt einen Eintrag zur Buchausleih-Liste hinzu
        /// </summary>
        public void AddToAusleihList()
        {
            try
            {
                DataRow relation;
                string[] exemlarDetails = new string[2];

                exemlarDetails[0] = ExemplarID;
                exemlarDetails[1] = Rueckgabedatum.ToShortDateString();

                if (LeihListe.Columns.Count != 2)
                {
                    LeihListe.Columns.Add();
                    LeihListe.Columns.Add();
                }
                relation = LeihListe.NewRow();
                relation.ItemArray = exemlarDetails;
                LeihListe.Rows.Add(relation);
            }
            catch
            {
                MessageBox.Show("Beim Hinzufügen dieses Buches zur Buchausleihliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Buchausleih-Liste
        /// </summary>
        public void RemoveFromAusleihList()
        {
            try
            {
                for (int i = LeihListe.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = LeihListe.Rows[i];
                    if (row[0].ToString() == ExemplarID)
                        row.Delete();
                }
                LeihListe.AcceptChanges();
            }
            catch
            {
                MessageBox.Show("Beim Entfernen dieses Buches von der Buchausleihliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Buchaugabe eines Buches
        /// </summary>
        public void Execute_Ausleihe(int buch_id, string aus_datum, string rueck_datum, int kunde)
        {
            if (con.ConnectError()) return;
            string RawCommand = "INSERT into [dbo].[t_bd_ausgeliehen] (aus_buchid, aus_leihdatum, aus_rückgabedatum, aus_kundenid) VALUES(@buchid, @ausdatum, @rückdatum, @kunde)";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);

            cmd.Parameters.AddWithValue("@buchid", buch_id);
            cmd.Parameters.AddWithValue("@ausdatum", aus_datum);
            cmd.Parameters.AddWithValue("@rückdatum", rueck_datum);
            cmd.Parameters.AddWithValue("@kunde", kunde);

            cmd.ExecuteNonQuery();
            con.Close();
        }

        //################################## speziell für Auto_Ausleihen ##################################

        /// <summary>
        /// Sucht die Klassenstufe des Schülers
        /// </summary>
        private String GetKlassenstufe()
        {
            string Klasse = "";
            string Klassenstufe = "";
            if (con.ConnectError()) return "";
            string RawCommand1 = "SELECT kunde_klasse FROM [dbo].t_s_kunden WHERE kunde_ID = @0";
            SqlDataReader dr1 = con.ExcecuteCommand(RawCommand1, KID);
            while (dr1.Read())
            {
                if (dr1.HasRows)
                {
                    Klasse = dr1["kunde_klasse"].ToString();
                }
                else
                {
                    Klasse = "";
                }
            }
            dr1.Close();
            con.Close();

            if (Klasse != "")
            {
                if (con.ConnectError()) return "";
                string RawCommand2 = "SELECT ks_klassenstufe FROM [dbo].t_s_klasse_stufe WHERE ks_klasse = @0";
                SqlDataReader dr2 = con.ExcecuteCommand(RawCommand2, Klasse);
                while (dr2.Read())
                {
                    if (dr2.HasRows)
                    {
                        Klassenstufe = dr2["ks_klassenstufe"].ToString();
                    }
                    else
                    {
                        Klassenstufe = "";
                    }
                }
                dr2.Close();
                con.Close();
            }
            return Klassenstufe;
        }

        /// <summary>
        /// Sucht die Fächer des Schülers
        /// </summary>
        private void GetFaecher()
        {
            try
            {
                if (!ds.Tables.Contains("FaecherListe"))
                {
                    ds.Tables.Add("FaecherListe");
                }
                ds.Tables["FaecherListe"].Rows.Clear();

                if (con.ConnectError()) return;
                string RawCommand = "SELECT fs_fachid, fs_lk FROM [dbo].[t_s_fach_kunde] WHERE fs_kundenid = @0";
                adapter = new SqlDataAdapter(RawCommand, con.Con);
                adapter.SelectCommand.Parameters.AddWithValue("@0", KID);
                adapter.Fill(ds.Tables["FaecherListe"]);
                con.Close();
            }
            catch { }
        }

        /// <summary>
        /// Schlägt Bücher zur Schulbuchausgabe vor
        /// </summary>
        private void SuggestBuecher(string Klassenstufe)
        {
            try
            {
                GetFaecher();

                if (!ds.Tables.Contains("BuecherListe"))
                {
                    ds.Tables.Add("BuecherListe");
                }
                ds.Tables["BuecherListe"].Rows.Clear();

                if (con.ConnectError()) return;
                string RawCommand = "SELECT f_kurzform as 'Fach', bf_isbn as 'ISBN', buch_titel as 'Titel', bf_fachid FROM [dbo].[t_s_buch_fach] left join t_s_buecher on buch_isbn = bf_isbn left join t_s_faecher on f_id = bf_fachid left join t_s_buch_stufe on bs_isbn = bf_isbn WHERE bf_fachid = @0 AND bs_klassenstufe = @1 AND bf_lk = @2";
                for (int i = 0; i < ds.Tables["FaecherListe"].Rows.Count; i++)
                {
                    adapter = new SqlDataAdapter(RawCommand, con.Con);
                    adapter.SelectCommand.Parameters.AddWithValue("@0", ds.Tables["FaecherListe"].Rows[i][0]);
                    adapter.SelectCommand.Parameters.AddWithValue("@1", Klassenstufe);
                    adapter.SelectCommand.Parameters.AddWithValue("@2", ds.Tables["FaecherListe"].Rows[i][1].ToString());
                    adapter.Fill(ds.Tables["BuecherListe"]);
                    con.Close();
                }
                con.Close();
            }
            catch { }
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
        /// Füllt ein DataGridView-Objekt mit den Schulbüchern 
        /// </summary>
        public void FillSuggestGrid(ref MetroFramework.Controls.MetroGrid grid, string KundenID, object value = null)
        {
            KID = KundenID;
            string stufe = GetKlassenstufe();
            SuggestBuecher(stufe);
            grid.DataSource = ds.Tables["BuecherListe"];
            grid.Columns["bf_fachid"].Visible = false;
        }

        public List<string> SuggestedBooks(string kundenid)
        {
            KID = kundenid;
            SuggestBuecher(GetKlassenstufe());
            List<string> suggestedBooks = new List<string>();
            for(int i = 0; i < ds.Tables[1].Rows.Count; i++)
            {
                string isbn = ds.Tables[1].Rows[i][1].ToString();
                suggestedBooks.Add(isbn);
            }
            return suggestedBooks;
        }
    }
}
