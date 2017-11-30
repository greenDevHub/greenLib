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
        #region ExcelExport
        public void ToExcel(DataGridView dGV)
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
                    if (dGV.RowCount > 0)
                    {
                        string value = "";
                        DataGridViewRow dr = new DataGridViewRow();
                        StreamWriter sw = new StreamWriter(dialog.FileName);
                        
                        //Head Rows schreiben
                        for (int i = 0; i <= dGV.Columns.Count - 1; i++)
                        {
                            if (i > 0)
                            {
                                sw.Write(";");
                            }
                            sw.Write(dGV.Columns[i].HeaderText);
                        }

                        sw.WriteLine();
                        //Rows aus dGV in csv
                        for (int j = 0; j <= dGV.Rows.Count - 1; j++)
                        {
                            if (j > 0)
                            {
                                sw.WriteLine();
                            }

                            dr = dGV.Rows[j];

                            for (int i = 0; i <= dGV.Columns.Count - 1; i++)
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
        #endregion

        #region Alter Export
        /*
        Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
        Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
        Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
        worksheet = workbook.Sheets["Tabelle1"];
        worksheet = workbook.ActiveSheet;
        worksheet.Name = tabellenname;

        for (int i = 1; i < dGV.Columns.Count + 1; i++)
        {
            worksheet.Cells[1, i] = dGV.Columns[i - 1].HeaderText;

        }

        for (int i = 0; i < dGV.Rows.Count; i++)
        {
            for (int j = 0; j < dGV.Columns.Count; j++)
            {
                worksheet.Cells[i + 2, j + 1] = dGV.Rows[i].Cells[j].Value.ToString();
            }
        }

        var SpeichernDialog = new SaveFileDialog();
        SpeichernDialog.FileName = filename;
         SpeichernDialog.DefaultExt = ".xlsx";
        if (SpeichernDialog.ShowDialog() == DialogResult.OK)
        {
            workbook.SaveAs(SpeichernDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

        }
        */

    }

        #endregion
    }

    
