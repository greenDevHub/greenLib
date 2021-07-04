using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace Bibo_Verwaltung
{
    class ExcelExport
    {
        Protokoll log = new Protokoll();
        CustomSqlConnection con = new CustomSqlConnection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        /// <summary>
        /// Exportiert ein DataGridView-Objekt in eine CSV-Datei
        /// </summary>
        public void ExportDataGridViewAsCSV(DataGridView grid)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV|*.csv";
            dialog.Title = "Als Tabelle abspeichern";
            dialog.FileName = "export.csv";
            dialog.ShowDialog();
            if (dialog.FileName != "")
            {
                try
                {
                    StreamWriter csvFileWriter = new StreamWriter(dialog.FileName, false);
                    //ColumnHeader schreiben
                    string columnHeaderText = "";
                    int countColumn = grid.ColumnCount - 1;
                    if (countColumn >= 0)
                    {
                        columnHeaderText = grid.Columns[0].HeaderText;
                    }
                    for (int i = 1; i <= countColumn; i++)
                    {
                        columnHeaderText = columnHeaderText + ';' + grid.Columns[i].HeaderText;
                    }
                    csvFileWriter.WriteLine(columnHeaderText);
                    //Rows schreiben
                    foreach (DataGridViewRow row in grid.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string dataFromGrid = "";
                            dataFromGrid = row.Cells[0].Value.ToString();
                            for (int i = 1; i <= countColumn; i++)
                            {
                                dataFromGrid = dataFromGrid + ';' + row.Cells[i].Value.ToString();
                            }
                            csvFileWriter.WriteLine(dataFromGrid);
                        }
                    }
                    csvFileWriter.Flush();
                    csvFileWriter.Close();
                }
                catch (Exception exceptionObject)
                {
                    log.CreateReport(exceptionObject);
                }
            }
        }

        /// <summary>
        /// Exportiert ein DataSet-Objekt in eine CSV-Datei
        /// </summary>
        private void ExportDataSetAsCSV()
        {
            int table = 0;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV|*.csv";
            dialog.Title = "Als Tabelle(n) abspeichern";
            dialog.FileName = "Tabelle.csv";
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string FileNames = dialog.FileName.Replace(".csv", "");
                foreach (DataTable tb in ds.Tables)
                {
                    if (FileNames == "Tabelle")
                    {
                        FileNames = "Tabelle" + table.ToString() + ".csv";
                    }
                    else
                    {
                        FileNames = dialog.FileName.Replace(".csv", "") + table.ToString() + ".csv";
                    }
                    try
                    {
                        int h = 1;
                        while (File.Exists(FileNames))
                        {
                            FileNames = FileNames.Replace(".csv", "") + " (" + (table + h).ToString() + ")" + ".csv";
                            h++;
                        }
                        StreamWriter csvFileWriter = new StreamWriter(FileNames, false);
                        //ColumnHeader schreiben
                        string columnHeaderText = "";
                        int countColumn = ds.Tables[table].Columns.Count - 1;
                        if (countColumn >= 0)
                        {
                            columnHeaderText = ds.Tables[table].Columns[0].ColumnName;
                        }
                        for (int i = 1; i <= countColumn; i++)
                        {
                            columnHeaderText = columnHeaderText + ';' + ds.Tables[table].Columns[i].ColumnName;
                        }
                        csvFileWriter.WriteLine(columnHeaderText);
                        //Rows schreiben
                        foreach (DataRow row in ds.Tables[table].Rows)
                        {
                            string dataFromGrid = "";
                            dataFromGrid = row[0].ToString();
                            for (int i = 1; i <= countColumn; i++)
                            {
                                dataFromGrid = dataFromGrid + ';' + row[i].ToString();
                            }
                            csvFileWriter.WriteLine(dataFromGrid);
                        }
                        csvFileWriter.Flush();
                        csvFileWriter.Close();
                    }
                    catch (Exception exceptionObject)
                    {
                        log.CreateReport(exceptionObject);
                        throw new Exception("Beim Exportvorgang ist ein Fehler aufgetreten.");
                    }
                    table++;
                }

            }
            else
            {
                throw new Exception("Der Exportvorgang wurde abgebrochen.");
            }
        }

        /// <summary>
        /// Füllt ein DataSet-Objekt mit Daten der zu exportierenden Tabellen der Datenbank
        /// </summary>
        private void FillDataSet(string[] source)
        {
            try
            {
                ds.Clear();
                ds.Tables.Clear();
                int i = 0;
                foreach (string s in source)
                {
                    ds.Tables.Add(i.ToString());
                    if (con.ConnectError()) return;
                    string RawCommand = "SELECT * FROM @source";
                    RawCommand = RawCommand.Replace("@source", source[i].ToString());
                    adapter = new SqlDataAdapter(RawCommand, con.Con);
                    Console.WriteLine(RawCommand);
                    adapter.Fill(ds.Tables[i]);
                    i++;
                }
                con.Close();
            }
            catch (Exception exceptionObject)
            {
                log.CreateReport(exceptionObject);
            }
        }

        /// <summary>
        /// Exportiert Daten aus der Datenbank in eine CSV-Datei
        /// </summary>
        public void ExportAsCSV(string[] source)
        {
            FillDataSet(source);
            ExportDataSetAsCSV();
        }
    }
}


