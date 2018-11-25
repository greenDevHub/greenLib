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
    class ImportExport
    {
        private DataTable dt = new DataTable();

        #region Eigenschaften
        string path;
        /// <summary>
        /// Filepath der Import/Export-Datei
        /// </summary>
        public string Path { get { return path; } set { path = value; } }

        char separator;
        /// <summary>
        /// Separator der Import/Export-Datei
        /// </summary>
        public char Separator { get { return separator; } set { separator = value; } }

        char textqualifizierer;
        /// <summary>
        /// Textqualifizierer der Import/Export-Datei
        /// </summary>
        public char Textqualifizierer { get { return textqualifizierer; } set { textqualifizierer = value; } }

        string datfolge;
        /// <summary>
        /// Datumsfolge der Import/Export-Datei
        /// </summary>
        public string Datumsfolge { get { return datfolge; } set { datfolge = value; } }

        char dattrenn;
        /// <summary>
        /// Datumstrennzeichen der Import/Export-Datei
        /// </summary>
        public char Datumstrennzeichen { get { return dattrenn; } set { dattrenn = value; } }

        char zeittrenn;
        /// <summary>
        /// Zeittrennzeichen der Import/Export-Datei
        /// </summary>
        public char Zeittrennzeichen { get { return zeittrenn; } set { zeittrenn = value; } }

        bool vierstelligejahre;
        /// <summary>
        /// Vierstelligejahre der Import/Export-Datei
        /// </summary>
        public bool Vierstelligejahre { get { return vierstelligejahre; } set { vierstelligejahre = value; } }

        bool fuehrendenull;
        /// <summary>
        /// FuehrendeDatumsnull der Import/Export-Datei
        /// </summary>
        public bool FuehrendeDatumsnull { get { return fuehrendenull; } set { fuehrendenull = value; } }

        char deztrenn;
        /// <summary>
        /// Dezimaltrennzeichen der Import/Export-Datei
        /// </summary>
        public char Dezimaltrennzeichen { get { return deztrenn; } set { deztrenn = value; } }

        bool colheader;
        /// <summary>
        /// ColumnHeader der Import/Export-Datei
        /// </summary>
        public bool ColumnHeader { get { return colheader; } set { colheader = value; } }

        string target;
        /// <summary>
        /// ColumnHeader der Import/Export-Datei
        /// </summary>
        public string Zieltabelle { get { return target; } set { target = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschafft ein Objekt zum importieren/exportieren von CSV-Dateien.
        /// </summary>
        public ImportExport(string path, char separator, char textqualifizierer, string datfolge, char dattrenn, char zeittrenn, bool vierstelligejahre, bool fuehrendenull, char deztrenn, bool colheader, bool preview)
        {
            this.path = path;
            this.separator = separator;
            this.textqualifizierer = textqualifizierer;
            this.datfolge = datfolge;
            this.dattrenn = dattrenn;
            this.zeittrenn = zeittrenn;
            this.vierstelligejahre = vierstelligejahre;
            this.fuehrendenull = fuehrendenull;
            this.deztrenn = deztrenn;
            this.colheader = colheader;
            readCSV(preview);
        }
        /// <summary>
        /// Erschafft ein Objekt zum importieren/exportieren von CSV-Dateien.
        /// </summary>
        public ImportExport()
        {
        }
        #endregion

        #region zeige Vorschau in Gridview ( FillGridViewRows() )
        /// <summary>
        /// Erschafft eine Vorschau von 10 Datensätzen der Importdaten und stellt diese in einer GridView dar.
        /// </summary>
        public void FillGridViewRows(ref DataGridView grid, object value = null)
        {
            readCSV(true);
            grid.DataSource = dt;
        }
        #endregion
        //TODO
        #region CSV-Dateien einlesen
        /// <summary>
        /// Liest eine CSV-Datei und erstellt eine Datatable.
        /// </summary>
        private void readCSV(bool preview)
        {
            FileInfo f = new FileInfo(path);
            long filelength = f.Length;

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line = file.ReadLine();

            if (preview == false)
            {
                if (filelength > 1)
                {
                    //erste Zeile (Colheader)
                    int i = 0;
                    string[] firstline = line.Split(separator);
                    if (colheader)
                    {
                        foreach (string s in firstline)
                        {
                            dt.Columns.Add(s);
                        }
                    }
                    else
                    {
                        foreach (string s in firstline)
                        {
                            dt.Columns.Add("Column" + Convert.ToString(i));
                            i++;
                        }
                        dt.Rows.Add(firstline);
                    }
                    //Zeilen in Datei 
                    int errorcount = 0;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(separator);
                        int curr = 0;

                        try
                        {
                            foreach (string s in parts)
                            {
                                string value = s.Replace(textqualifizierer.ToString(), "");
                                parts[curr] = value.Trim();
                                curr++;
                            }
                            dt.Rows.Add(parts);
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
                else
                {
                    MessageBox.Show("Diese Datei enthält keine Daten!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (filelength > 0)
                {
                    //erste Zeile (Colheader)
                    int i = 0;
                    string[] firstline = line.Split(separator);
                    if (colheader)
                    {
                        foreach (string s in firstline)
                        {
                            dt.Columns.Add(s);
                        }
                    }
                    else
                    {
                        foreach (string s in firstline)
                        {
                            dt.Columns.Add("Column" + Convert.ToString(i));
                            i++;
                        }
                        dt.Rows.Add(firstline);
                    }
                    //Zeilen in Datei
                    int errorcount = 0;
                    for (int j = 0; j < 9; j++)
                    {
                        if ((line = file.ReadLine()) != null)
                        {
                            string[] parts = line.Split(separator);
                            int curr = 0;

                            try
                            {
                                foreach (string s in parts)
                                {
                                    string value = s.Replace(textqualifizierer.ToString(), "");
                                    parts[curr] = value.Trim();
                                    curr++;
                                }
                                dt.Rows.Add(parts);
                            }
                            catch
                            {
                                errorcount++;
                            }
                        }
                    }
                    if (errorcount > 0)
                    {
                        MessageBox.Show("Es konnten " + errorcount + " Zeile(n) aufgund eines Formatieringsproblems nicht gelesen werden. Bitte überprüfen Sie die Anzahl der Trennzeichen jeder Zeile und versuchen Sie es erneut!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                file.Close();
            }
        }
        #endregion

        #region Ziel-Schema ermitteln
        SqlDataAdapter adapter = new SqlDataAdapter();
        private DataTable schema = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        /// <summary>
        /// Ermittelt das Tabellen-Schema der Zieltabelle in der SQL-Datenbank.
        /// </summary>
        private void getSchemaOfSQLTable(string table)
        {
            schema.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT COLUMN_NAME, DATA_TYPE FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @0";
            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", table);
            adapter.Fill(schema);
            con.Close();
        }
        #endregion

        /// <summary>
        /// Prüft die Zellen der Import-Datatable auf ihre maximale Länge vor dem Übertragen in die SQL-Datenbank.
        /// </summary>
        private bool cellsOK()
        {
            bool importReady = false;
            foreach (DataRow row in dt.Rows)
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
        /// Gleicht die Struktur der Datatable aus der CSV-Datei mit der Struktur der Zieltabelle in der SQL-Datenbank ab.
        /// </summary>
        private bool checkSchema()
        {
            bool schemaOK = false;
            if (dt.Columns.Count == schema.Rows.Count)
            {
                schemaOK = true;
            }
            else
            {
                schemaOK = false;
            }
            return schemaOK;
        }

        DataTable import = new DataTable();
        /// <summary>
        /// Erstellt eine Datatable für den Daten-Import in die SQL-Datenbank.
        /// </summary>
        private void createImportTable()
        {
            cellsOK();

        }

        /// <summary>
        /// Überträgt eine Datatable in eine SQL-Datenbank.
        /// </summary>
        private void transferDataTable()
        {
            try
            {
                SQL_Verbindung con = new SQL_Verbindung();
                if (con.ConnectError()) return;
                using (var bulkCopy = new SqlBulkCopy(con.Con))
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                    }
                    bulkCopy.BulkCopyTimeout = 600;
                    bulkCopy.DestinationTableName = target;
                    bulkCopy.WriteToServer(dt);
                }
            }
            catch
            {
                MessageBox.Show("Diese Datei enthält eine inkorrekte Daten-Struktur! Die Datei kann nicht eingelesen werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Importiert eine CSV-Datei in eine SQL-Datenbank.
        /// </summary>
        public void executeImport()
        {
            //CSV-Datei einlesen
            readCSV(false);

            //Zielschema holen
            getSchemaOfSQLTable(target);
            foreach (DataRow row in schema.Rows)
            {
                Console.WriteLine("--- Row ---");
                foreach (var item in row.ItemArray)
                {
                    Console.Write("Item: "); // Print label.
                    Console.WriteLine(item);
                }
            }

            //Schema-Abgleich
            if (checkSchema())
            {
                transferDataTable();
            }
            else
            {
                //Open Spanten-Auswahl-Dialog
                transferDataTable();
            }
        }

        //TODO
        #region ExcelExport
        private void createExcelFile(DataGridView grid)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "CSV|*.csv";
                dialog.Title = "Als Tabelle abspeichern";
                dialog.ShowDialog();

                //Überprüfen, ob Filename vergeben wurde
                if (dialog.FileName != "")
                {
                    //Überprüfen, ob Rows vorhanden sind
                    if (grid.RowCount > 0)
                    {
                        string value = "";
                        DataGridViewRow dr = new DataGridViewRow();
                        StreamWriter sw = new StreamWriter(dialog.FileName);

                        //Head Rows schreiben
                        for (int i = 0; i <= grid.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                sw.Write(";");
                            }
                            sw.Write(grid.Columns[i].HeaderText);
                        }

                        sw.WriteLine();
                        //Rows aus grid in csv
                        for (int j = 0; j <= grid.Rows.Count - 1; j++)
                        {
                            if (j > 0)
                            {
                                sw.WriteLine();
                            }

                            dr = grid.Rows[j];

                            for (int i = 0; i <= grid.Columns.Count - 1; i++)
                            {
                                if (i > 0)
                                {
                                    sw.Write(";");
                                }

                                value = dr.Cells[i].Value.ToString();
                                //Replace
                                value = value.Replace(',', ' ');
                                value = value.Replace(Environment.NewLine, " ");

                                sw.Write(value);
                            }
                        }
                        sw.Close();
                        MessageBox.Show("Export erfolgreich abgeschlossen", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Beim Exportvorgang ist ein unbekannter Fehler aufgetreten!", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void executeExport(ref DataGridView grid)
        {
            createExcelFile(grid);
        }
        #endregion

        #region get SQL Columns
        public List<string> GetSQLColumns(string tableName)
        {
            List<string> cols = new List<string>();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return cols;
            string RawCommand = "SELECT column_name FROM information_schema.columns WHERE table_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, tableName);
            while (dr.Read())
            {
                cols.Add(dr["column_name"].ToString());
            }
            dr.Close();
            con.Close();
            return cols;
        }
        #endregion

        public void FillColGrid(ref DataGridView grid, List<string> columns, object value = null)
        {
            DataTable table = new DataTable();
            foreach(string s in columns)
            {
                table.Columns.Add(s.Substring(s.IndexOf("_")+1), typeof(System.String));
            }
            //for(int i = 0; i < columns.Count;)
            //{
            //    table.Columns.Add(columns[i], typeof(System.String));
            //}
           // table.Rows.Add(columns);
            grid.DataSource = table;
        }


    }
}
