using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Ausleihe
    {
        SQL_Verbindung con = new SQL_Verbindung();

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

        #region Fill Object
        ////SqlDataAdapter adapter = new SqlDataAdapter();
        ////DataSet ds = new DataSet();
        ////DataTable dt = new DataTable();
        ////SqlCommandBuilder comb = new SqlCommandBuilder();
        ////private void FillObject()
        ////{
        ////    SQL_Verbindung con = new SQL_Verbindung();
        ////    if (con.ConnectError()) return;
        ////    string RawCommand = "SELECT bu_id as 'Buch-ID', bu_isbn as 'ISBN', buch_titel as 'Titel', "
        ////        + "zu_zustand as 'Zustand', bu_aufnahmedatum as 'Aufnahmedatum', "
        ////        + "ger_name as 'Genre', ver_name as 'Verlag', sprach_name as 'Sprache', a_id as 'AutorlisteID', aus_rückgabedatum as 'Rückgabedatum', aus_leihnummer as 'Leihnummer', "
        ////        + "kunde_id as 'Kunden ID', kunde_vorname as 'Vorname', kunde_Nachname as 'Nachname', kunde_klasse as 'Klasse' FROM t_s_buchid "
        ////        + "left join t_s_buecher on bu_isbn = buch_isbn "
        ////        + "left join t_s_genre on buch_genre_id = ger_id "
        ////        + "left join t_s_autorliste on buch_autor_id = a_id "
        ////        + "left join t_s_verlag on buch_verlag_id = ver_id "
        ////        + "left join t_s_sprache on buch_sprache_id = sprach_id "
        ////        + "left join t_s_zustand on bu_zustandsid = zu_id "
        ////        + "left join t_bd_ausgeliehen on aus_buchid = bu_id "
        ////        + "left join t_s_kunden on kunde_ID = aus_kundenid WHERE bu_activated = 1";

        ////    SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
        ////    adapter = new SqlDataAdapter(RawCommand, con.Con);
        ////    adapter.Fill(ds);
        ////    adapter.Fill(dt);
        ////    if (ds.Tables[0].Columns.Contains("Autor"))
        ////    {
        ////        ds.Tables[0].Columns.RemoveAt(ds.Tables[0].Columns.IndexOf("Autor"));
        ////    }
        ////    ds.Tables[0].Columns.Add("Autor", typeof(System.String));
        ////    foreach (DataRow row in ds.Tables[0].Rows)
        ////    {
        ////        string text = "";
        ////        AutorListe AutorListe = new AutorListe();
        ////        foreach (string s in AutorListe.GetNames(row["AutorlisteID"].ToString()))
        ////        {
        ////            if (s != null && !s.Equals(""))
        ////            {
        ////                text = text + s + ", ";
        ////            }
        ////        }
        ////        if (text.Length > 2)
        ////        {
        ////            text = text.Substring(0, text.Length - 2);
        ////        }
        ////        row["Autor"] = text;
        ////    }
        ////    con.Close();
        ////}


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

                for (int i = 0; i <= inputList.Length-1; i++)
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
                sb.Append(exemplar.Titel);
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
    }
}
