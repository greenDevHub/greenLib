﻿using System;
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
        public void ToExcel(DataGridView dGV, string filename, string tabellenname)
        {
            /*
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            var dt = new DataTable();
            foreach (DataGridViewColumn column in dGV.Columns)
            {
                if (column.Visible)
                {
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dGV.Columns.Count];
            foreach (DataGridViewRow row in dGV.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            ds.WriteXml(path);
            */

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
            app.Quit(); 
        }

        #endregion
    }
}
