using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Import
    {
        SQL_Verbindung con = new SQL_Verbindung();
        private DataTable CSVData = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable schema = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();

        #region Eigenschaften
        string filepath;
        /// <summary>
        /// Filepath der Import-Datei
        /// </summary>
        public string FilePath { get { return filepath; } set { filepath = value; } }

        char separator;
        /// <summary>
        /// Separator der Import-Datei
        /// </summary>
        public char Separator { get { return separator; } set { separator = value; } }

        char textqualifizierer;
        /// <summary>
        /// Textqualifizierer der Import-Datei
        /// </summary>
        public char Textqualifizierer { get { return textqualifizierer; } set { textqualifizierer = value; } }

        string datfolge;
        /// <summary>
        /// Datumsfolge der Import-Datei (z.B: ddMMyyy)
        /// </summary>
        public string Datumsfolge { get { return datfolge; } set { datfolge = value; } }

        char dattrenn;
        /// <summary>
        /// Datumstrennzeichen der Import-Datei
        /// </summary>
        public char Datumstrennzeichen { get { return dattrenn; } set { dattrenn = value; } }

        char zeittrenn;
        /// <summary>
        /// Zeittrennzeichen der Import-Datei
        /// </summary>
        public char Zeittrennzeichen { get { return zeittrenn; } set { zeittrenn = value; } }

        bool vierstelligejahre;
        /// <summary>
        /// Jahreszahl ist vierstellig
        /// </summary>
        public bool IsVierstelligeJahre { get { return vierstelligejahre; } set { vierstelligejahre = value; } }

        bool fuehrendenull;
        /// <summary>
        /// Einstelliges Datum hat führende Null
        /// </summary>
        public bool IsFuehrendeDatumsNull { get { return fuehrendenull; } set { fuehrendenull = value; } }

        char deztrenn;
        /// <summary>
        /// Dezimaltrennzeichen der Import-Datei
        /// </summary>
        public char Dezimaltrennzeichen { get { return deztrenn; } set { deztrenn = value; } }

        bool colheader;
        /// <summary>
        /// Erste Zeile enthält ColumnHeader der Import-Datei
        /// </summary>
        public bool UseFirstRowAsColumnHeader { get { return colheader; } set { colheader = value; } }

        string target;
        /// <summary>
        /// Zieltabelle in der Datenbank
        /// </summary>
        public string Zieltabelle { get { return target; } set { target = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschafft ein Objekt zum importieren/exportieren von CSV-Dateien.
        /// </summary>
        public Import(string path, char separator, char textqualifizierer, string datfolge, char dattrenn, char zeittrenn, bool vierstelligejahre, bool fuehrendenull, char deztrenn, bool colheader, bool preview)
        {
            FilePath = path;
            Separator = separator;
            Textqualifizierer = textqualifizierer;
            Datumsfolge = datfolge;
            Datumstrennzeichen = dattrenn;
            Zeittrennzeichen = zeittrenn;
            IsVierstelligeJahre = vierstelligejahre;
            IsFuehrendeDatumsNull = fuehrendenull;
            Dezimaltrennzeichen = deztrenn;
            UseFirstRowAsColumnHeader = colheader;
            ReadCSV(preview);
        }
        #endregion

        /// <summary>
        /// Erschafft eine Vorschau von 10 Datensätzen der Importdaten und stellt diese in einer GridView dar.
        /// </summary>
        public void FillGridView_Preview(ref DataGridView grid, object value = null)
        {
            ReadCSV(true);
            grid.DataSource = CSVData;
        }

        /// <summary>
        /// Liest eine CSV-Datei und erstellt eine Datatable.
        /// </summary>
        private void ReadCSV(bool preview)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
            string line = file.ReadLine();

            if (new FileInfo(FilePath).Length > 1)
            {
                //erste Zeile (Colheader)
                int i = 0;
                string[] firstline = line.Split(Separator);
                if (UseFirstRowAsColumnHeader)
                {
                    foreach (string s in firstline)
                    {
                        CSVData.Columns.Add(s);
                    }
                }
                else
                {
                    foreach (string s in firstline)
                    {
                        CSVData.Columns.Add("Column" + Convert.ToString(i));
                        i++;
                    }
                    CSVData.Rows.Add(firstline);
                }
                //Zeilen in Datei 
                int errorcount = 0;
                if (preview)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if ((line = file.ReadLine()) != null)
                        {
                            string[] parts = line.Split(Separator);
                            int curr = 0;
                            try
                            {
                                foreach (string s in parts)
                                {
                                    string value = s.Replace(Textqualifizierer.ToString(), "");
                                    parts[curr] = value.Trim();
                                    curr++;
                                }
                                CSVData.Rows.Add(parts);
                            }
                            catch
                            {
                                errorcount++;
                            }
                        }
                    }
                }
                else
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(Separator);
                        int curr = 0;
                        try
                        {
                            foreach (string s in parts)
                            {
                                string value = s.Replace(Textqualifizierer.ToString(), "");
                                parts[curr] = value.Trim();
                                curr++;
                            }
                            CSVData.Rows.Add(parts);
                        }
                        catch
                        {
                            errorcount++;
                        }
                    }
                    if (errorcount > 0)
                    {
                        MessageBox.Show("Es konnten " + errorcount + " Zeile(n) aufgund eines Formatieringsproblems nicht gelesen werden. Bitte überprüfen Sie die Anzahl der Trennzeichen jeder Zeile und versuchen Sie es erneut!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Diese Datei enthält keine Daten!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            file.Close();
        }

        /// <summary>
        /// Ermittelt das Tabellen-Schema der Zieltabelle in der SQL-Datenbank.
        /// </summary>
        private void GetSchemaOfSQLTable(string table)
        {
            schema.Clear();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @0";
            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", table);
            adapter.Fill(schema);
            con.Close();
        }

        /// <summary>
        /// Prüft die Zellen der Import-Datatable auf ihre maximale Länge vor dem Übertragen in die SQL-Datenbank.
        /// </summary>
        private bool CellsOK()
        {
            bool importReady = false;
            foreach (DataRow row in CSVData.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().Length < 128)
                    {
                        importReady = true;
                    }
                    else
                    {
                        importReady = false;
                    }
                }
            }
            return importReady;
        }

        /// <summary>
        /// Gleicht die Spaltenanzahl der Datatable aus der CSV-Datei mit der Struktur der Zieltabelle in der SQL-Datenbank ab.
        /// </summary>
        private bool checkSchema()
        {
            bool schemaOK = false;
            if (CSVData.Columns.Count == schema.Rows.Count)
            {
                schemaOK = true;
            }
            else
            {
                schemaOK = false;
            }
            return schemaOK;
        }
    }
}
