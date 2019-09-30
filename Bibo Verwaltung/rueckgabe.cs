using MetroFramework.Controls;
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
    class Rueckgabe
    {
        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        #region Buch Eigenschaften
        string kid;
        /// <summary>
        /// Kunden Nummer eines Buches
        /// </summary>
        public string KID { get { return kid; } set { kid = value; } }

        string exemplarID;
        /// <summary>
        /// Leihdatum eines Exemplars
        /// </summary>
        public string ExemplarID { get { return exemplarID; } set { exemplarID = value; } }

        string zustand_AusleihStart;
        /// <summary>
        /// Leihdatum eines Exemplars
        /// </summary>
        public string ZustandStart { get { return zustand_AusleihStart; } set { zustand_AusleihStart = value; } }

        string zustand_AusleihEnde;
        /// <summary>
        /// Leihdatum eines Exemplars
        /// </summary>
        public string ZustandEnde { get { return zustand_AusleihEnde; } set { zustand_AusleihEnde = value; } }

        DateTime leihdatum;
        /// <summary>
        /// Leihdatum eines Buches
        /// </summary>
        public DateTime Leihdatum { get { return leihdatum; } set { leihdatum = value; } }

        DateTime rueckgabedatum;
        /// <summary>
        /// Rueckgabedatum eines Buches
        /// </summary>
        public DateTime Rueckgabedatum { get { return rueckgabedatum; } set { rueckgabedatum = value; } }

        DataTable rueckListe = new DataTable();
        /// <summary>
        /// Liste der zur Ausleihe ausgewaehlten Exemplare 
        /// </summary>
        public DataTable RueckListe { get { return rueckListe; } set { rueckListe = value; } }

        bool verfuegbar;
        /// <summary>
        /// Status des Exemplars
        /// </summary>
        public bool Verfuegbar { get { return verfuegbar; } set { verfuegbar = value; } }
        #endregion

        /// <summary>
        /// Laden der KundenID, und des Ausleih- und Rückgabedatums eines Buches
        /// </summary>
        public void Load_Info(string exemlarID)
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT aus_leihdatum, aus_rückgabedatum, aus_kundenid, aus_buchid FROM t_bd_ausgeliehen WHERE aus_buchid = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, exemlarID);
            while (dr.Read())
            {
                KID = dr["aus_kundenid"].ToString();
                ExemplarID = dr["aus_buchid"].ToString();
                Leihdatum = (DateTime)dr["aus_leihdatum"];
                Rueckgabedatum = (DateTime)dr["aus_rückgabedatum"];
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Gibt den Row-Index der ExemplarID in der Buchausleihliste wieder
        /// </summary>
        public int GetIndexInRueckliste()
        {
            int result = -1;
            for (int i = 0; i <= RueckListe.Rows.Count - 1; i++)
            {
                if (RueckListe.Rows[i][0].ToString() == ExemplarID)
                {
                    result = i;
                }
            }
            return result;
        }

        /// <summary>
        /// Füllt das DataSet 
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT aus_buchid as 'ID', buch_titel as 'Titel', aus_leihdatum as 'Leihdatum', aus_rückgabedatum as 'Rückgabedatum' FROM t_bd_ausgeliehen left join t_s_buchid on bu_id = aus_buchid left join t_s_buecher on buch_isbn = bu_isbn WHERE aus_kundenid = @0";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", KID);
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
        /// Füllt ein DataGridView-Objekt mit den Klassendaten 
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
        }

        ///// <summary>
        ///// Gibt ein DataTable-Objekt mit den ausgeliehen Büchern der Kunden zurück 
        ///// </summary>
        //public DataTable GetAusgeliehen(string KundenID)
        //{
        //    KID = KundenID;
        //    ClearDataSource();
        //    FillObject();
        //    return ds.Tables[0];
        //}

        /// <summary>
        /// Prüft die Buchrückgabeliste auf das Vorhandensein der angegebenen Exemlar ID 
        /// </summary>
        public bool CheckRueckList()
        {
            bool result = false;
            for (int i = 0; i <= RueckListe.Rows.Count - 1; i++)
            {
                if (RueckListe.Rows[i][0].ToString() == ExemplarID)
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Übernimmt eine vorgefertigte Liste in die Buchrückgabeliste 
        /// </summary>
        public void FillRueckListe(string[] inputList)
        {
            try
            {
                ClearRueckList();
                Load_Info(inputList[0].ToString());
                DataRow relation;
                string[] exemlarDetails = new string[3];

                if (RueckListe.Columns.Count != 3)
                {
                    RueckListe.Columns.Add();
                    RueckListe.Columns.Add();
                    RueckListe.Columns.Add();
                }

                for (int i = 0; i <= inputList.Length - 1; i++)
                {
                    exemlarDetails[0] = ExemplarID;
                    exemlarDetails[1] = ZustandStart;
                    exemlarDetails[2] = ZustandEnde;
                    relation = RueckListe.NewRow();
                    relation.ItemArray = exemlarDetails;
                    RueckListe.Rows.Add(relation);
                }
            }
            catch
            {
                MessageBox.Show("Beim Laden der Liste in die Buchrückgabeliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Baut einen Dialogstring abhängig von der Buchrückgabe-Anzahl
        /// </summary>
        public String GetListInfo()
        {
            Buch exemplar;
            StringBuilder sb = new StringBuilder();
            sb.Append("Derzeit sind folgende Titel in der Auswahlliste: ");
            sb.AppendLine();
            sb.AppendLine();

            if (RueckListe.Rows.Count > 0)
            {
                for (int i = 0; i < RueckListe.Rows.Count; i++)
                {
                    exemplar = new Buch(new Exemplar(RueckListe.Rows[i][0].ToString()).ISBN);
                    sb.Append("-  ");
                    sb.Append(TrimText(exemplar.Titel, 30));
                    if (i < RueckListe.Rows.Count)
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
            catch { }
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
        /// Baut einen Dialogstring abhängig von der Buchrückgabe-Anzahl
        /// </summary>
        public String GetRueckgabeList()
        {
            Exemplar exemplar;
            Buch exemplar_info;
            string resultString = "Möchten Sie ";
            if (RueckListe.Rows.Count == 1)
            {
                exemplar = new Exemplar(RueckListe.Rows[0][0].ToString());
                exemplar_info = new Buch(exemplar.ISBN);
                resultString = resultString + "das Buch: " + Environment.NewLine + Environment.NewLine + exemplar_info.Titel + ", " + Environment.NewLine + Environment.NewLine;
            }
            else
            {
                resultString = resultString + "die Bücher: " + Environment.NewLine + Environment.NewLine;
                foreach (DataRow row in RueckListe.Rows)
                {
                    exemplar = new Exemplar(row[0].ToString());
                    exemplar_info = new Buch(exemplar.ISBN);
                    resultString = resultString + "-  " + TrimText(exemplar_info.Titel, 30) + ", " + Environment.NewLine;
                }
                resultString = resultString + Environment.NewLine;
            }
            return resultString;
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt der Rückgabeliste 
        /// </summary>
        public void ClearRueckList()
        {
            try
            {
                RueckListe.Rows.Clear();
            }
            catch { }
        }

        /// <summary>
        /// Setzt den Auswahl-Slider anhand der Elemente der Rückgabeliste
        /// </summary>
        public void SetSlider(ref HScrollBar rueckList_Slider, ref MetroFramework.Controls.MetroTextBox tb_listVon, ref MetroFramework.Controls.MetroTextBox tb_listBis)
        {
            if (RueckListe.Rows.Count == 0)
            {
                rueckList_Slider.Enabled = false;
                rueckList_Slider.Minimum = 0;
                rueckList_Slider.Maximum = 0;
            }
            else
            {
                rueckList_Slider.Enabled = true;
                rueckList_Slider.Minimum = 1;
                rueckList_Slider.Maximum = RueckListe.Rows.Count;
                rueckList_Slider.Value = rueckList_Slider.Maximum;
            }
            tb_listVon.Text = rueckList_Slider.Value.ToString();
            tb_listBis.Text = rueckList_Slider.Maximum.ToString();
        }

        /// <summary>
        /// Fügt einen Eintrag zur Buchrückgabe-Liste hinzu
        /// </summary>
        public void AddToRueckgabeList()
        {
            try
            {
                DataRow relation;
                string[] exemlarDetails = new string[3];

                exemlarDetails[0] = ExemplarID;
                exemlarDetails[1] = ZustandStart;
                exemlarDetails[2] = ZustandEnde;
                if (RueckListe.Columns.Count != 3)
                {
                    RueckListe.Columns.Add();
                    RueckListe.Columns.Add();
                    RueckListe.Columns.Add();
                }
                relation = RueckListe.NewRow();
                relation.ItemArray = exemlarDetails;
                RueckListe.Rows.Add(relation);
            }
            catch
            {
                MessageBox.Show("Beim Hinzufügen dieses Buches zur Buchrückgabeliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Buchrückgabe-Liste
        /// </summary>
        public void RemoveFromRueckgabeList()
        {
            try
            {
                for (int i = RueckListe.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = RueckListe.Rows[i];
                    if (row[0].ToString() == ExemplarID)
                        row.Delete();
                }
                RueckListe.AcceptChanges();
            }
            catch
            {
                MessageBox.Show("Beim Entfernen dieses Buches von der Buchrückgabeliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Rückgabe eines Buches
        /// </summary>
        public void Execute_Rueckgabe(string Exemplar, string Kunde, string SollZustand, string IstZustandID, string IstZustand, string AusleihStartDatum, string AusleihEndDatum)
        {
            if (con.ConnectError()) return;
            string RawCommand1 = "DELETE FROM t_bd_ausgeliehen WHERE aus_buchid = @0";
            SqlCommand cmd = new SqlCommand(RawCommand1, con.Con);
            cmd.Parameters.AddWithValue("@0", Exemplar);
            cmd.ExecuteNonQuery();

            string RawCommand2 = "UPDATE t_s_buchid set bu_zustandsid = @zustandsid WHERE bu_id = @id";
            cmd = new SqlCommand(RawCommand2, con.Con);
            cmd.Parameters.AddWithValue("@zustandsid", IstZustandID);
            cmd.Parameters.AddWithValue("@id", Exemplar);
            cmd.ExecuteNonQuery();

            string RawCommand3 = "INSERT INTO t_s_verlauf (id_buch, k_id, zu_vor, zu_nach, aus_geliehen, aus_ruckgabe) VALUES (@buchid, @kid, @zvor, @znach, @ausgeliehen, @ruckgabe)";
            cmd = new SqlCommand(RawCommand3, con.Con);
            cmd.Parameters.AddWithValue("@buchid", Exemplar);
            cmd.Parameters.AddWithValue("@kid", Kunde);
            cmd.Parameters.AddWithValue("@zvor", SollZustand);
            cmd.Parameters.AddWithValue("@znach", IstZustand);
            cmd.Parameters.AddWithValue("@ausgeliehen", AusleihStartDatum);
            cmd.Parameters.AddWithValue("@ruckgabe", AusleihEndDatum);
            cmd.ExecuteNonQuery();

            con.Close();
        }
    }
}
