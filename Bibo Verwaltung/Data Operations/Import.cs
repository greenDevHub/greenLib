using MetroFramework;
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
    class Import
    {
        CustomSqlConnection con = new CustomSqlConnection();
        DataTable CSVData_File = new DataTable();
        public DataTable CSVData_ToServer = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable schemaOfSQLTable = new DataTable();
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
        public string Zieltabellen { get { return target; } set { target = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschafft ein Objekt zum importieren/exportieren von CSV-Dateien.
        /// </summary>
        public Import(IWin32Window owner, string path, char separator, char textqualifizierer, string datfolge, char dattrenn, char zeittrenn, bool vierstelligejahre, bool fuehrendenull, char deztrenn, bool colheader, bool preview)
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
            ReadCSV(owner, preview);
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
        public void FillGridView_Preview(IWin32Window owner, ref MetroGrid grid, object value = null)
        {
            ClearInputTable();
            ReadCSV(owner, true);
            grid.DataSource = CSVData_File;
        }

        /// <summary>
        /// Erstellt eine Zuordnungstabelle für die Zuordnung von Spalten aus der Datei und der DB.
        /// </summary>
        public void FillGridView_SpaltenZuordnung(IWin32Window owner, ref MetroGrid grid, object value = null)
        {
            //Schema aus DB holen und in die DataGridView setzten
            //GetSchemaOfSQLTable();
            grid.DataSource = schemaOfSQLTable;
            grid.Columns[0].Name = "DestinationColumn";
            grid.Columns[0].HeaderText = "Spalten in der Datenbank";

            //Spalte "Zuordnung der Spalten aus der CSV-Datei" zur DataGridView hinzufügen
            #region Zuordnung-Spalte           
            if (grid.Columns.Contains("SourceColumn"))
            {
                grid.Columns.Remove("SourceColumn");
            }
            DataGridViewComboBoxColumn combobox = new DataGridViewComboBoxColumn();
            combobox.HeaderText = "Zuordnung der Spalten aus der CSV-Datei";
            combobox.Name = "SourceColumn";
            combobox.MaxDropDownItems = 8;
            combobox.Items.Add("--keine--");
            for (int i = 0; i < CSVData_ToServer.Columns.Count; i++)
            {
                combobox.Items.Add(CSVData_ToServer.Columns[i].ColumnName);
            }
            combobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            combobox.Width = 1000;
            grid.Columns.Add(combobox);
            grid.Columns["SourceColumn"].SortMode = DataGridViewColumnSortMode.NotSortable;
            for (int i = 0; i < grid.RowCount; i++)
            {
                DataGridViewComboBoxCell comboValue = (DataGridViewComboBoxCell)(grid.Rows[i].Cells["SourceColumn"]);
                comboValue.Value = combobox.Items[0];
            }
            #endregion
        }

        /// <summary>
        /// Lädt die Datentyp-Auswahl-DataGridView für den "Schritt 3"
        /// </summary>
        public void LoadDatatypAssignment(ref MetroGrid grid, object value = null)
        {
            grid.DataSource = null;
            grid.Columns.Clear();
            //Spalte "Feldname" zur DataGridView hinzufügen
            #region Feldname-Spalte
            if (!grid.Columns.Contains("Feldname"))
            {
                DataGridViewTextBoxColumn textbox = new DataGridViewTextBoxColumn();
                textbox.HeaderText = "Feldname";
                textbox.Name = "Feldname";
                textbox.MaxInputLength = 15;
                grid.Columns.Add(textbox);
                foreach (DataColumn col in CSVData_File.Columns)
                {
                    string[] rowData = new string[1];
                    rowData[0] = col.ColumnName;
                    grid.Rows.Add(rowData);
                }
                grid.Columns["Feldname"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion

            //Spalte "Feld ist Primärschlüssel" zur DataGridView hinzufügen
            #region Primärschlüssel-Spalte
            if (!grid.Columns.Contains("Feld ist Primärschlüssel"))
            {
                DataGridViewCheckBoxColumn checkbox1 = new DataGridViewCheckBoxColumn();
                checkbox1.HeaderText = "Feld ist Primärschlüssel";
                checkbox1.Name = "Primärschlüssel";
                checkbox1.FlatStyle = FlatStyle.System;
                checkbox1.ThreeState = false;
                grid.Columns.Add(checkbox1);
                grid.Columns["Primärschlüssel"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion

            //Spalte "Feld nicht importieren (überspringen)" zur DataGridView hinzufügen
            #region Überspringen-Spalte
            if (!grid.Columns.Contains("Feld nicht importieren (überspringen)"))
            {
                DataGridViewCheckBoxColumn checkbox2 = new DataGridViewCheckBoxColumn();
                checkbox2.HeaderText = "Feld nicht importieren (überspringen)";
                checkbox2.Name = "überspringen";
                checkbox2.FlatStyle = FlatStyle.System;
                checkbox2.ThreeState = false;
                grid.Columns.Add(checkbox2);
                grid.Columns["überspringen"].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion

            //Spalte "Datentyp" zur DataGridView hinzufügen
            #region Datentyp-Spalte
            if (!grid.Columns.Contains("Datentyp"))
            {
                DataGridViewComboBoxColumn combobox1 = new DataGridViewComboBoxColumn();
                combobox1.HeaderText = "Datentyp";
                combobox1.Name = "Datentyp";
                combobox1.MaxDropDownItems = 8;
                combobox1.Items.Add("Ja/Nein (Boolean)");
                combobox1.Items.Add("Byte");
                combobox1.Items.Add("Integer");
                combobox1.Items.Add("Währung");
                combobox1.Items.Add("Single");
                combobox1.Items.Add("Double");
                combobox1.Items.Add("Datum mit Uhrzeit");
                combobox1.Items.Add("Text (String)");
                combobox1.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
                combobox1.Width = 1000;
                grid.Columns.Add(combobox1);
                grid.Columns["Datentyp"].SortMode = DataGridViewColumnSortMode.NotSortable;
                //Auswahl der Comboboxen initialisieren und auf erstes Value setzten
                for (int i = 0; i < grid.RowCount; i++)
                {
                    DataGridViewComboBoxCell comboValue = (DataGridViewComboBoxCell)(grid.Rows[i].Cells["Datentyp"]);
                    comboValue.Value = combobox1.Items[0];
                }
            }
            #endregion

            //Spaltenanordnung setzten
            grid.Columns["Feldname"].DisplayIndex = 0;
            grid.Columns["Datentyp"].DisplayIndex = 1;
            grid.Columns["Primärschlüssel"].DisplayIndex = 2;
            grid.Columns["überspringen"].DisplayIndex = 3;
        }

        /// <summary>
        /// Öffnet einen OpenFileDialog und setzt den "FilePath" auf den angeben Pfad
        /// </summary>
        public DialogResult ShowFileDialog(IWin32Window owner, ref MetroTextBox textBox)
        {
            DialogResult result = new DialogResult();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wählen Sie eine Datei für den Datenimport";
            openFileDialog.Filter = "Text Files|*.txt; *.csv";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog.FileName.EndsWith(".txt") || openFileDialog.FileName.EndsWith(".csv"))
                {
                    FilePath = openFileDialog.FileName;
                    textBox.Text = openFileDialog.FileName;
                    result = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    textBox.Text = "";
                    MetroMessageBox.Show(owner, "Der angegebene Dateiname ist ungültig. Bitte verwenden sie nur Dateien mit der Endung \'.txt\' oder \'.csv\'!", "Error in Dateiname", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = System.Windows.Forms.DialogResult.Retry;
                    ShowFileDialog(owner, ref textBox);
                }
            }
            else
            {
                result = System.Windows.Forms.DialogResult.Cancel;
            }
            return result;
        }

        /// <summary>
        /// Prüft eine MetroTextBox auf ein gültiges Dezimalsymbol und setzt dieses (gibt TRUE bei korrektem Zeichen zurück)  
        /// </summary>
        public bool Set_DezSym(IWin32Window owner, ref MetroTextBox textBox)
        {
            bool correct = false;
            if (textBox.Text.Length == 1)
            {
                char dezsym = Convert.ToChar(textBox.Text);
                if (dezsym == ',' || dezsym == '.')
                {
                    Dezimaltrennzeichen = dezsym;
                    correct = true;
                }
                else
                {
                    MetroMessageBox.Show(owner, "Das eingegebene Dezimalsymbol ist ungülig! Gülige Zeichen sind ausschießlich ',' und '.' !", "Error bei Dezimalsymbol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correct = false;
                    textBox.Focus();
                    textBox.SelectAll();
                }
            }
            else
            {
                if (textBox.Text.Length != 0)
                {
                    textBox.Text = textBox.Text.Substring(0, 1);
                    Set_DezSym(owner, ref textBox);
                }
            }
            return correct;
        }

        /// <summary>
        /// Prüft eine MetroTextBox auf ein gültiges Zeittrennzeichen und setzt dieses (gibt TRUE bei korrektem Zeichen zurück)  
        /// </summary>
        public bool Set_ZeitTrenn(IWin32Window owner, ref MetroTextBox textBox)
        {
            bool correct = false;
            if (textBox.Text.Length == 1)
            {
                char zeittrenn = Convert.ToChar(textBox.Text);
                if (zeittrenn == ':' || zeittrenn == '-' || zeittrenn == '/')
                {
                    Zeittrennzeichen = zeittrenn;
                    correct = true;
                }
                else
                {
                    MetroMessageBox.Show(owner, "Das eingegebene Zeittrennzeichen ist ungülig! Gülige Zeichen sind ausschießlich ':', '-' und '/' !", "Error bei Zeittrennzeichen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correct = false;
                    textBox.Focus();
                    textBox.SelectAll();
                }
            }
            else
            {
                if (textBox.Text.Length != 0)
                {
                    textBox.Text = textBox.Text.Substring(0, 1);
                    Set_ZeitTrenn(owner, ref textBox);
                }
            }
            return correct;
        }

        /// <summary>
        /// Prüft eine MetroTextBox auf ein gültiges Datumstrennzeichen und setzt dieses (gibt TRUE bei korrektem Zeichen zurück)  
        /// </summary>
        public bool Set_DatTrenn(IWin32Window owner, ref MetroTextBox textBox)
        {
            bool correct = false;
            if (textBox.Text.Length == 1)
            {
                char dattrenn = Convert.ToChar(textBox.Text);
                if (dattrenn == '.' || dattrenn == '-' || dattrenn == '/')
                {
                    Datumstrennzeichen = dattrenn;
                    correct = true;
                }
                else
                {
                    MetroMessageBox.Show(owner, "Das eingegebene Datumstrennzeichen ist ungülig! Gülige Zeichen sind ausschießlich '.', '-' und '/' !", "Error bei Datumstrennzeichen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correct = false;
                    textBox.Focus();
                    textBox.SelectAll();
                }
            }
            else
            {
                if (textBox.Text.Length != 0)
                {
                    textBox.Text = textBox.Text.Substring(0, 1);
                    Set_DatTrenn(owner, ref textBox);
                }
            }
            return correct;
        }

        /// <summary>
        /// Setzt und prüft ob in eine MetroTextBox ein gültiges Feldtrennzeichen (gibt TRUE bei korrektem Zeichen zurück)  
        /// </summary>
        public bool Set_Seperator(IWin32Window owner, ref AdvancedComboBox aComboBox)
        {
            bool correct = false;
            if (aComboBox.Text.Length != 0)
            {
                if (aComboBox.Text == "{Leerzeichen}")
                {
                    Separator = ' ';
                    correct = true;
                }
                else if (aComboBox.Text == "{Tabulator}")
                {
                    Separator = '\t';
                    correct = true;
                }
                else
                {
                    if (aComboBox.Text.Length == 1)
                    {
                        Separator = Convert.ToChar(aComboBox.Text);
                        correct = true;
                    }
                    else
                    {
                        aComboBox.Text = aComboBox.Text.Substring(0, 1);
                        Separator = Convert.ToChar(aComboBox.Text);
                        correct = true;
                    }
                }
            }
            return correct;
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
            file.Close();
            return sb.ToString();
        }

        /// <summary>
        /// Liest eine CSV-Datei und erstellt eine Datatable.
        /// </summary>
        private List<int> ReadCSV(IWin32Window owner, bool preview)
        {
            List<int> errorInLine = new List<int>();
            System.IO.StreamReader file = new System.IO.StreamReader(FilePath);

            if (new FileInfo(FilePath).Length > 1)
            {
                string line = file.ReadLine();
                //Erste Zeile der Datei (ist Columnheader?)
                #region Columnheader setzten         
                string[] firstline = line.Split(Separator);
                if (UseFirstRowAsColumnHeader)
                {
                    foreach (string s in firstline)
                    {
                        CSVData_File.Columns.Add(s.Replace(Textqualifizierer.ToString(), "").Trim());
                    }
                }
                else
                {
                    int i = 0;
                    foreach (string s in firstline)
                    {
                        CSVData_File.Columns.Add("Feld" + Convert.ToString(i + 1));
                        i++;
                    }
                    CSVData_File.Rows.Add(firstline);
                }
                #endregion

                //Daten in den Zeilen der Datei lesen           
                if (preview)
                {
                    //Vorschau von 10 Zeilen
                    #region Vorschau einlesen
                    for (int j = 0; j < 9; j++)
                    {
                        if ((line = file.ReadLine()) != null)
                        {
                            string[] parts = line.Split(Separator);
                            int curr = 0;
                            try
                            {
                                //Textqualifizierer und evtl enthaltene Leerzeichen entfernen
                                foreach (string s in parts)
                                {
                                    string value = s.Replace(Textqualifizierer.ToString(), "");
                                    if (value.Contains(',') && value.Contains('.'))
                                    {
                                        if (Dezimaltrennzeichen == ',')
                                        {
                                            value = value.Replace(".", "");
                                        }
                                        else if (Dezimaltrennzeichen == '.')
                                        {
                                            value = value.Replace(",", "");
                                        }
                                    }
                                    parts[curr] = value.Trim();
                                    curr++;
                                }
                                //Zeile in Tabelle einlesen
                                CSVData_File.Rows.Add(parts);
                            }
                            catch
                            {
                                errorInLine.Add(j + 2);
                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    //Vollständigen Datei-Inhalt einlesen
                    #region Daten vollständig einlesen
                    int currLine = 2;
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(Separator);
                        int curr = 0;
                        try
                        {
                            //Textqualifizierer und evtl enthaltene Leerzeichen entfernen + störende ',' bzw '.' entfernen
                            foreach (string s in parts)
                            {
                                string value = s.Replace(Textqualifizierer.ToString(), "");
                                if (value.Contains(',') && value.Contains('.'))
                                {
                                    if (Dezimaltrennzeichen == ',')
                                    {
                                        value = value.Replace(".", "");
                                    }
                                    else if (Dezimaltrennzeichen == '.')
                                    {
                                        value = value.Replace(",", "");
                                    }
                                }
                                parts[curr] = value.Trim();
                                curr++;
                            }
                            CSVData_File.Rows.Add(parts);
                        }
                        catch
                        {
                            errorInLine.Add(currLine);
                        }
                        currLine++;
                    }
                    if (errorInLine.Count > 0)
                    {
                        MetroMessageBox.Show(owner, "Es konnten " + errorInLine.Count + " Zeile(n) aufgund eines Formatieringsproblems nicht gelesen werden. Bitte überprüfen Sie die Anzahl der Trennzeichen jeder Zeile und versuchen Sie es erneut!", "Error beim Einlesen der Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    #endregion
                }
            }
            else
            {
                MetroMessageBox.Show(owner, "Diese Datei enthält keine Daten!", "Error in Datei", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            file.Close();
            return errorInLine;
        }

        /// <summary>
        /// Benennt eine Spalte der Input-Tabelle um
        /// </summary>
        public void RenameColumn(string col, string newName)
        {
            if (CSVData_File.Columns.Contains(col))
            {
                CSVData_File.Columns[col].ColumnName = newName;
                CSVData_File.AcceptChanges();
            }
        }

        /// <summary>
        /// Ermittelt das Tabellen-Schema der Zieltabelle in der SQL-Datenbank.
        /// </summary>
        private DataTable GetSchemaOfSQLTable()
        {
            schemaOfSQLTable.Clear();
            schemaOfSQLTable.Columns.Clear();
            if (con.ConnectError()) return null;
            //string RawCommand = "SELECT SUBSTRING(COLUMN_NAME, CHARINDEX('_', COLUMN_NAME)+1, LEN(COLUMN_NAME)) as 'Feld', DATA_TYPE as 'Datentyp' FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @0";
            string RawCommand = "SELECT COLUMN_NAME as 'Feld', DATA_TYPE as 'Datentyp' FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = @0";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", Zieltabellen);
            adapter.Fill(schemaOfSQLTable);
            con.Close();
            return schemaOfSQLTable;
        }

        /// <summary>
        /// Prüft die Zellen der Import-Datatable auf ihre maximale Länge vor dem Übertragen in die SQL-Datenbank.
        /// </summary>
        private bool CellsOK()
        {
            bool importReady = false;
            foreach (DataRow row in CSVData_File.Rows)
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
            if (CSVData_ToServer.Columns.Count == schemaOfSQLTable.Rows.Count)
            {
                schemaOK = true;
            }
            else
            {
                schemaOK = false;
            }
            return schemaOK;
        }

        private void PrintTable(DataTable table)
        {
            Console.WriteLine("BEGIN_TABLE");
            foreach (DataColumn column in table.Columns)
            {
                Console.Write(column.ColumnName);
                Console.Write("|");
            }
            Console.WriteLine();
            if (table.Rows.Count != 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (DataColumn column in table.Columns)
                    {
                        if (row[column].ToString() != "")
                        {
                            Console.Write(row[column]);
                        }
                        else
                        {
                            Console.Write("_");
                        }
                        Console.Write("|");
                    }
                    Console.WriteLine(";");
                    Console.WriteLine("####################################################################################################");
                }
            }
            else
            {
                Console.WriteLine("kein Inhalt...");
            }
            Console.WriteLine("END_TABLE");
        }

        /// <summary>
        /// Leert die Input-DataTable (CSVData)
        /// </summary>
        private void ClearInputTable()
        {
            CSVData_File.Clear();
            CSVData_File.Columns.Clear();
        }

        /// <summary>
        /// Erstellt eine Datatable für den Daten-Import in die SQL-Datenbank.
        /// </summary>
        public void CreateImportTable(ref MetroGrid grid, object value = null)
        {
            //CSVData_ToServer-Tabelle für neuen Vorgang leeren
            CSVData_ToServer.Clear();
            CSVData_ToServer.Columns.Clear();
            //Input-Daten prüfen und Zielschema aus Datenbank holen
            CellsOK();
            GetSchemaOfSQLTable();

            #region Columns mit dem entsprechenden Datentyp in CSVData_ToServer-Tabelle anlegen
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!Convert.ToBoolean(grid.Rows[row.Index].Cells["überspringen"].Value))
                {
                    switch (grid.Rows[row.Index].Cells["Datentyp"].Value.ToString())
                    {
                        case "Ja/Nein (Boolean)":
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(Boolean));
                            break;
                        case "Byte":
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(Byte));
                            break;
                        case "Integer":
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(Int32));
                            break;
                        case "Währung":
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(Decimal));
                            break;
                        case "Single":
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(Single));
                            break;
                        case "Double":
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(Double));
                            break;
                        case "Datum mit Uhrzeit":
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(DateTime));
                            break;
                        case "Text (String)":
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(String));
                            break;
                        default:
                            CSVData_ToServer.Columns.Add(row.Cells[0].Value.ToString(), typeof(String));
                            break;
                    }
                }
            }
            #endregion

            //Differenz der der Spalten (Columns) in der Datei und den tatsächlich zu importierenden Spalten brechnen (da Spalten überprungen werden können) 
            int div = CSVData_File.Columns.Count - CSVData_ToServer.Columns.Count;
            #region Daten der Input-Tabelle ("CSVData_File") aufbereiten und in "CSVData_ToServer" übernehmen 
            for (int c = 1; c < CSVData_File.Columns.Count; c++)////gsjghasdjhrajeghajdfghd
            {
                if (CSVData_ToServer.Columns.Contains(CSVData_File.Columns[c].ColumnName))
                {
                    for (int r = 0; r < CSVData_File.Rows.Count; r++)
                    {
                        //Neues Row in "CSVData_ToServer" anlegen 
                        if (CSVData_ToServer.Rows.Count < CSVData_File.Rows.Count)
                        {
                            DataRow row = CSVData_ToServer.NewRow();
                            CSVData_ToServer.Rows.Add(row);
                        }
                        //Daten in richtigen Datentyp konvertieren und in "CSVData_ToServer" schreiben
                        switch (CSVData_ToServer.Columns[c - div].DataType)
                        {
                            case Type boolType when boolType == typeof(Boolean):
                                CSVData_ToServer.Rows[r][c - div] = Convert.ToBoolean(CSVData_File.Rows[r][c]);
                                break;
                            case Type byteType when byteType == typeof(Byte):
                                CSVData_ToServer.Rows[r][c - div] = Convert.ToByte(CSVData_File.Rows[r][c]);
                                break;
                            case Type intType when intType == typeof(Int32):
                                CSVData_ToServer.Rows[r][c - div] = Convert.ToInt32(CSVData_File.Rows[r][c]);
                                break;
                            case Type decType when decType == typeof(Decimal):
                                CSVData_ToServer.Rows[r][c - div] = Convert.ToDecimal(CSVData_File.Rows[r][c]);
                                break;
                            case Type singleType when singleType == typeof(Single):
                                CSVData_ToServer.Rows[r][c - div] = Convert.ToSingle(CSVData_File.Rows[r][c]);
                                break;
                            case Type doubleType when doubleType == typeof(Double):
                                CSVData_ToServer.Rows[r][c - div] = Convert.ToDouble(CSVData_File.Rows[r][c]);
                                break;
                            case Type dtType when dtType == typeof(DateTime):
                                CSVData_ToServer.Rows[r][c - div] = Convert.ToDateTime(CSVData_File.Rows[r][c]);
                                break;
                            case Type stringType when stringType == typeof(String):
                                CSVData_ToServer.Rows[r][c - div] = Convert.ToString(CSVData_File.Rows[r][c]);
                                break;
                        }
                    }
                }
            }
            #endregion

            //Rename wie zuordnung

            //Testzwecke -> raus machen!
            PrintTable(CSVData_ToServer);
        }

        /// <summary>
        /// Überträgt eine Datatable in eine SQL-Datenbank.
        /// </summary>
        private void TransferDataTable(ref MetroGrid grid, object value = null)
        {

            if (con.ConnectError()) return;
            using (var bulkCopy = new SqlBulkCopy(con.Con))
            {
                foreach (DataColumn col in CSVData_ToServer.Columns)
                {
                    bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                }
                bulkCopy.BulkCopyTimeout = 600;
                bulkCopy.DestinationTableName = Zieltabellen;
                bulkCopy.WriteToServer(CSVData_ToServer);
            }






            //try
            //{
            if (con.ConnectError()) return;
            //using (var bulkCopy = new SqlBulkCopy(con.Con))
            //{


            //    for (int i = 0; i < grid.Rows.Count; i++)
            //    {
            //        //    ComboBox box = new ComboBox();
            //        //    box.SelectedItem = grid.Rows[i].Cells["SourceColumn"].Value.ToString();
            //        //Console.WriteLine(box.SelectedItem);

            //        //Console.WriteLine(grid.Rows[i].Cells["DestinationColumn"].Value.ToString());

            //        //if (grid.Rows[i].Cells["SourceColumn"].Value.ToString() == "" || grid.Rows[i].Cells["SourceColumn"].Value.ToString() == null)
            //        //{
            //        //}
            //        //else
            //        //{ 
            //        //Console.WriteLine(grid.Rows[i].Cells["SourceColumn"].Value.ToString() + " " + grid.Rows[i].Cells["DestinationColumn"].Value.ToString());
            //        //bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
            //        //bulkCopy.ColumnMappings.Add(grid.Rows[i].Cells["SourceColumn"].ToString(), grid.Rows[i].Cells["DestinationColumn"].ToString()); ggod
            //        //}
            //        bulkCopy.ColumnMappings.Add("au_id", "au_id");
            //        bulkCopy.ColumnMappings.Add("au_autor", "au_autor");
            //    }
            //    bulkCopy.BulkCopyTimeout = 600;
            //    bulkCopy.DestinationTableName = Zieltabelle;
            //    try
            //    {
            //        bulkCopy.WriteToServer(CSVData);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //}
            //catch
            //{
            //    MessageBox.Show("Diese Datei enthält eine inkorrekte Daten-Struktur! Die Datei kann nicht eingelesen werden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        /// <summary>
        /// Importiert eine CSV-Datei in eine SQL-Datenbank.
        /// </summary>
        public void ExecuteImport(IWin32Window owner, ref MetroGrid dataTypes, ref MetroGrid zuordnungen, object value = null)
        {
            //Input-Table leeren
            ClearInputTable();

            //CSV-Datei einlesen (Preview -> false)
            ReadCSV(owner, false);

            //Eingelesene Daten für BulkCopy vorbereiten
            CreateImportTable(ref dataTypes);

            //Schema-Abgleich
            //if (CheckSchema())
            //{
            //BulkCopy ausführen
            TransferDataTable(ref zuordnungen);
            //}
        }
    }
}
