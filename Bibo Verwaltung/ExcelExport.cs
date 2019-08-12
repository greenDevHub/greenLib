using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data;
using System.IO;

namespace Bibo_Verwaltung
{
    class ExcelExport
    {
        Protokoll log = new Protokoll();

        public void ExportAsCSV(DataGridView grid)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV|*.csv";
            dialog.Title = "Als Tabelle abspeichern";
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
    }
}


