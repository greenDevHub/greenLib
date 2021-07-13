using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class StudentSubjectImport
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

        //string datfolge;
        ///// <summary>
        ///// Datumsfolge der Import/Export-Datei
        ///// </summary>
        //public string Datumsfolge { get { return datfolge; } set { datfolge = value; } }

        //char dattrenn;
        ///// <summary>
        ///// Datumstrennzeichen der Import/Export-Datei
        ///// </summary>
        //public char Datumstrennzeichen { get { return dattrenn; } set { dattrenn = value; } }

        //char zeittrenn;
        ///// <summary>
        ///// Zeittrennzeichen der Import/Export-Datei
        ///// </summary>
        //public char Zeittrennzeichen { get { return zeittrenn; } set { zeittrenn = value; } }

        //bool vierstelligejahre;
        ///// <summary>
        ///// Vierstelligejahre der Import/Export-Datei
        ///// </summary>
        //public bool Vierstelligejahre { get { return vierstelligejahre; } set { vierstelligejahre = value; } }

        //bool fuehrendenull;
        ///// <summary>
        ///// FuehrendeDatumsnull der Import/Export-Datei
        ///// </summary>
        //public bool FuehrendeDatumsnull { get { return fuehrendenull; } set { fuehrendenull = value; } }

        //char deztrenn;
        ///// <summary>
        ///// Dezimaltrennzeichen der Import/Export-Datei
        ///// </summary>
        //public char Dezimaltrennzeichen { get { return deztrenn; } set { deztrenn = value; } }

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

        int linenum;
        public int LineNum { get { return linenum; } set { linenum = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschafft ein Objekt zum importieren/exportieren von CSV-Dateien.
        /// </summary>
        //public Schuelerimport(string path, char separator, char textqualifizierer, string datfolge, char dattrenn, char zeittrenn, bool vierstelligejahre, bool fuehrendenull, char deztrenn, bool colheader, bool preview)
        //{
        //    //this.path = path;
        //    //this.separator = separator;
        //    //this.textqualifizierer = textqualifizierer;
        //    //this.datfolge = datfolge;
        //    //this.dattrenn = dattrenn;
        //    //this.zeittrenn = zeittrenn;
        //    //this.vierstelligejahre = vierstelligejahre;
        //    //this.fuehrendenull = fuehrendenull;
        //    //this.deztrenn = deztrenn;
        //    //this.colheader = colheader;
        //    //readCSV(preview);
        //}
        /// <summary>
        /// Erschafft ein Objekt zum importieren/exportieren von CSV-Dateien.
        /// </summary>
        public StudentSubjectImport()
        {
        }
        #endregion

        #region zeige Vorschau in Gridview ( FillGridViewRows() )
        /// <summary>
        /// Erschafft eine Vorschau von 10 Datensätzen der Importdaten und stellt diese in einer GridView dar.
        /// </summary>
        public void FillGridViewRows(ref MetroGrid grid, object value = null)
        {
            //grid.DataSource = null;
            dt.Clear();
            readCSV(false);
            grid.DataSource = dt;
        }
        public void FillDataTable(ref DataTable dt)
        {
            readCSV(false);
            dt = this.dt;
        }
        #endregion
        //TODO
        #region CSV-Dateien einlesen
        /// <summary>
        /// Liest eine CSV-Datei und erstellt eine Datatable.
        /// </summary>
        private void readCSV(bool preview)
        {
            dt.Reset();
            FileInfo f = new FileInfo(path);
            long filelength = f.Length;
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(path, System.Text.Encoding.Default);
                string line = file.ReadLine();
                for (int i = 0; i < LineNum;)
                {
                    line = file.ReadLine();
                    i++;
                }

                if (preview == false)
                {
                    if (filelength > 1)
                    {
                        //erste Zeile (Colheader)
                        int i = 0;
                        string[] firstline;
                        try
                        {
                            firstline = line.Split(separator);
                            for (int number = 0; number < firstline.Length; number++)
                            {
                                firstline[number] = firstline[number].Replace(textqualifizierer.ToString(), "");
                            }
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
                                throw new Exception("Problem bei Zeile " + errorcount);
                            }
                        }
                        catch (System.NullReferenceException)
                        {
                            throw new Exception("Fehler bei Datei");
                        }

                    }
                    else
                    {
                        throw new Exception("Keine Daten");
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
            catch (IOException)
            {
                throw new Exception("failed preset");
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
            CustomSqlConnection con = new CustomSqlConnection();
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
                CustomSqlConnection con = new CustomSqlConnection();
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

        ////TODO
        //private void createExcelFile(DataGridView grid)
        //{
        //    try
        //    {
        //        SaveFileDialog dialog = new SaveFileDialog();
        //        dialog.Filter = "CSV|*.csv";
        //        dialog.Title = "Als Tabelle abspeichern";
        //        dialog.ShowDialog();

        //        //Überprüfen, ob Filename vergeben wurde
        //        if (dialog.FileName != "")
        //        {
        //            //Überprüfen, ob Rows vorhanden sind
        //            if (grid.RowCount > 0)
        //            {
        //                string value = "";
        //                DataGridViewRow dr = new DataGridViewRow();
        //                StreamWriter sw = new StreamWriter(dialog.FileName);

        //                //Head Rows schreiben
        //                for (int i = 0; i <= grid.Columns.Count - 1; i++)
        //                {
        //                    if (i > 0)
        //                    {
        //                        sw.Write(";");
        //                    }
        //                    sw.Write(grid.Columns[i].HeaderText);
        //                }

        //                sw.WriteLine();
        //                //Rows aus grid in csv
        //                for (int j = 0; j <= grid.Rows.Count - 1; j++)
        //                {
        //                    if (j > 0)
        //                    {
        //                        sw.WriteLine();
        //                    }

        //                    dr = grid.Rows[j];

        //                    for (int i = 0; i <= grid.Columns.Count - 1; i++)
        //                    {
        //                        if (i > 0)
        //                        {
        //                            sw.Write(";");
        //                        }

        //                        value = dr.Cells[i].Value.ToString();
        //                        //Replace
        //                        value = value.Replace(',', ' ');
        //                        value = value.Replace(Environment.NewLine, " ");

        //                        sw.Write(value);
        //                    }
        //                }
        //                sw.Close();
        //                MetroMessageBox.Show(this,"Export erfolgreich abgeschlossen", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        MetroMessageBox.Show(this,"Beim Exportvorgang ist ein unbekannter Fehler aufgetreten!", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }
        //}

        //public void executeExport(ref DataGridView grid)
        //{
        //    createExcelFile(grid);
        //}

        /// <summary>
        /// Ruft die Spaltennamen aus der Datenbank ab, wird aktuell nicht verwendet
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public List<string> GetSQLColumns(string tableName)
        {
            List<string> cols = new List<string>();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return cols;
            string RawCommand = "SELECT column_name FROM information_schema.columns WHERE table_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, tableName);
            while (dr.Read())
            {
                cols.Add(dr["column_name"].ToString());
            }
            cols.RemoveAt(0);
            dr.Close();
            con.Close();
            return cols;
        }

        /// <summary>
        /// Füllt das Gridview zum Vergleich der benötigten und der in der .csv vorhandenen Daten
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="target"></param>
        /// <param name="value"></param>
        public void FillColGrid(ref MetroGrid grid, string target, object value = null)
        {
            DataTable table = new DataTable();
            if (target.Equals("SEK1"))
            {
                table.Columns.Add("Vorname");
                table.Columns.Add("Nachname");
                table.Columns.Add("Geburtsdatum");
                table.Columns.Add("Klasse");
                table.Columns.Add("FS2");
                table.Columns.Add("Profil");
                table.Columns.Add("Religionsunterricht");
            }
            else if (target.Equals("SEK2"))
            {
                table.Columns.Add("Vorname");
                table.Columns.Add("Nachname");
                table.Columns.Add("Geburtsdatum");
                table.Columns.Add("Klasse");
                table.Columns.Add("LK1");
                table.Columns.Add("LK2");
                table.Columns.Add("Grundkurse");

            }
            else if (target.Equals("FAECHER"))
            {
                table.Columns.Add("Kurzform");
                table.Columns.Add("Langform");
            }
            grid.DataSource = table;
        }


    }
}
