using MetroFramework.Controls;
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

        DataTable userDataTypes = new DataTable();
        /// <summary>
        /// Liste der zur Ausleihe ausgewaehlten Exemplare 
        /// </summary>
        public DataTable UserDataTypes { get { return userDataTypes; } set { userDataTypes = value; } }
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

        /// <summary>
        /// Erschafft ein Objekt zum importieren/exportieren von CSV-Dateien.
        /// </summary>
        public Import()
        {
            FilePath = "C:";
            Separator = ';';
            Textqualifizierer = '"';
            Datumsfolge = datfolge;
            Datumstrennzeichen = '.';
            Zeittrennzeichen = ':';
            IsVierstelligeJahre = true;
            IsFuehrendeDatumsNull = true;
            Dezimaltrennzeichen = ',';
            UseFirstRowAsColumnHeader = false;
        }
        #endregion

        /// <summary>
        /// Erschafft eine Vorschau von 10 Datensätzen der Importdaten und stellt diese in einer GridView dar.
        /// </summary>
        public void FillGridView_Preview(ref MetroGrid grid, object value = null)
        {
            ClearInputTable();
            ReadCSV(true);
            grid.DataSource = CSVData;
        }

        /// <summary>
        /// Liest eine CSV-Datei ein und erstellt daraus einen String.
        /// </summary>
        public String ReadFile()
        {
            System.IO.StreamReader file = new System.IO.StreamReader(FilePath);
            string line = file.ReadLine();
            if (line.Contains(";"))
            {
                Separator = ';';
            }
            else if (line.Contains(" "))
            {
                Separator = ' ';
            }
            else if (line.Contains('\t'))
            {
                Separator = '\t';
            }
            else if (line.Contains(","))
            {
                Separator = ',';
            }
            else if (line.Contains('"'))
            {
                Textqualifizierer = '"';
            }
            else if (line.Contains("'"))
            {
                Textqualifizierer = '\'';
            }
            int curr = 0;
            int i = 0;
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.AppendLine(line);
            while ((line = file.ReadLine()) != null)
            {
                if (i <= 20)
                {
                    sb.AppendLine(line);
                    i++;
                }
                string[] parts = line.Split(Separator);
                if (parts.Length > curr)
                {
                    curr = parts.Length;
                }
            }
            return sb.ToString();
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
                        CSVData.Columns.Add(s.Replace(Textqualifizierer.ToString(), ""));
                    }
                }
                else
                {
                    foreach (string s in firstline)
                    {
                        CSVData.Columns.Add("Feld" + Convert.ToString(i + 1));
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
        public DataTable GetSchemaOfSQLTable()
        {
            schema.Clear();
            if (con.ConnectError()) return null;
            string RawCommand = "SELECT SUBSTRING(COLUMN_NAME, CHARINDEX('_', COLUMN_NAME)+1, LEN(COLUMN_NAME)) as 'Feld', DATA_TYPE as 'Datentyp' FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @0";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", Zieltabelle);
            adapter.Fill(schema);
            con.Close();
            return schema;
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
        private bool CheckSchema()
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

        /// <summary>
        /// Leert die Input-DataTable
        /// </summary>
        private void ClearInputTable()
        {
            CSVData.Clear();
            CSVData.Columns.Clear();
        }

        /// <summary>
        /// Erstellt eine Datatable für den Daten-Import in die SQL-Datenbank.
        /// </summary>
        private void CreateImportTable()
        {
            CellsOK();
            GetSchemaOfSQLTable();

        }

        /// <summary>
        /// Überträgt eine Datatable in eine SQL-Datenbank.
        /// </summary>
        private void TransferDataTable()
        {
            //try
            //{
                if (con.ConnectError()) return;
                using (var bulkCopy = new SqlBulkCopy(con.Con))
                {

                CSVData.Columns[0].ColumnName = "au_id";
                CSVData.Columns[1].ColumnName = "au_name";


                    for (int i=0;i<UserDataTypes.Rows.Count; i++)
                    {
                    if (Convert.ToBoolean(UserDataTypes.Rows[i]["überspringen"]) != true)
                    //bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                    bulkCopy.ColumnMappings.Add(UserDataTypes.Rows[i]["Feldname"].ToString(), Convert.ToInt32(schema.Rows[i][0].ToString().Replace("Feld",""))-1);
                }
                    bulkCopy.BulkCopyTimeout = 600;
                    bulkCopy.DestinationTableName = Zieltabelle;
                    bulkCopy.WriteToServer(CSVData);
                }
            //}
            //catch
            //{
            //    MessageBox.Show("Diese Datei enthält eine inkorrekte Daten-Struktur! Die Datei kann nicht eingelesen werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /// <summary>
        /// Importiert eine CSV-Datei in eine SQL-Datenbank.
        /// </summary>
        public void ExecuteImport()
        {
            //Input-Table leeren
            ClearInputTable();

            //CSV-Datei einlesen
            ReadCSV(false);

            //Schema-Abgleich
            if (CheckSchema())
            {
                TransferDataTable();
            }
            else
            {
                //Open Spanten-Auswahl-Dialog
                TransferDataTable();
            }
        }
    }
}
