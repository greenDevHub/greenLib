﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Import
    {
        DataTable dt = new DataTable();

        #region Eigenschaften
        string path;
        /// <summary>
        /// Filepath
        /// </summary>
        public string Path { get { return path; } set { path = value; } }

        char separator;
        /// <summary>
        /// Separator
        /// </summary>
        public char Separator { get { return separator; } set { separator = value; } }

        char textqualifizierer;
        /// <summary>
        /// Textqualifizierer
        /// </summary>
        public char Textqualifizierer { get { return textqualifizierer; } set { textqualifizierer = value; } }

        string datfolge;
        /// <summary>
        /// Datumsfolge
        /// </summary>
        public string Datumsfolge { get { return datfolge; } set { datfolge = value; } }

        char dattrenn;
        /// <summary>
        /// Datumstrennzeichen
        /// </summary>
        public char Datumstrennzeichen { get { return dattrenn; } set { dattrenn = value; } }

        char zeittrenn;
        /// <summary>
        /// Zeittrennzeichen
        /// </summary>
        public char Zeittrennzeichen { get { return zeittrenn; } set { zeittrenn = value; } }

        bool vierstelligejahre;
        /// <summary>
        /// Vierstelligejahre
        /// </summary>
        public bool Vierstelligejahre { get { return vierstelligejahre; } set { vierstelligejahre = value; } }

        bool fuehrendenull;
        /// <summary>
        /// FuehrendeDatumsnull
        /// </summary>
        public bool FuehrendeDatumsnull { get { return fuehrendenull; } set { fuehrendenull = value; } }

        char deztrenn;
        /// <summary>
        /// Dezimaltrennzeichen
        /// </summary>
        public char Dezimaltrennzeichen { get { return deztrenn; } set { deztrenn = value; } }

        bool colheader;
        /// <summary>
        /// ColumnHeader
        /// </summary>
        public bool ColumnHeader { get { return colheader; } set { colheader = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschaft das Objekt Genre
        /// </summary>
        public Import(string path, char separator, char textqualifizierer, string datfolge, char dattrenn, char zeittrenn, bool vierstelligejahre, bool fuehrendenull, char deztrenn, bool colheader)
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
            LeseCSV();
        }
        #endregion

        #region CSV-Dateien einlesen
        public void FillGridViewRows(ref DataGridView grid, object value = null)
        {
            grid.DataSource = dt;
        }

        private void LeseCSV()
        {
            FileInfo f = new FileInfo(path);
            long filelength = f.Length;

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line = file.ReadLine();

            if (filelength > 0)
            {
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
                }
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split(separator);
                    dt.Rows.Add(parts);
                }
            }
            else
            {
                MessageBox.Show("Diese Datei enthält keine Daten!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            file.Close();
        }
        #endregion

        public DataTable table()
        {
            return dt;
        }

        enum dataType
        {
            System_Boolean = 0,
            System_Int32 = 1,
            System_Int64 = 2,
            System_Double = 3,
            System_DateTime = 4,
            System_String = 5
        }

        private dataType getDataType(string str)
        {
            bool boolValue;
            Int32 intValue;
            Int64 bigintValue;
            double doubleValue;
            DateTime dateValue;

            // Place checks higher in if-else statement to give higher priority to type.

            if (bool.TryParse(str, out boolValue))
                return dataType.System_Boolean;
            else if (Int32.TryParse(str, out intValue))
                return dataType.System_Int32;
            else if (Int64.TryParse(str, out bigintValue))
                return dataType.System_Int64;
            else if (double.TryParse(str, out doubleValue))
                return dataType.System_Double;
            else if (DateTime.TryParse(str, out dateValue))
                return dataType.System_DateTime;
            else return dataType.System_String;
        }

        public void executeKundenImport()
        {
            //foreach (DataRow row in dt.Rows)
            //{
            //    Kunde kunde = new Kunde();
            //    kunde.Vorname = tb_Vorname.Text;
            //    kunde.Nachname = tb_Nachname.Text;
            //    kunde.Strasse = tb_Strasse.Text;
            //    kunde.Hausnummer = tb_Hausnummer.Text;
            //    kunde.Postleitzahl = tb_Postleitzahl.Text;
            //    kunde.Ort = tb_Ort.Text;
            //    kunde.Vertrauenswuerdigkeit = cb_Vertrauenswuerdigkeit.Text;
            //    kunde.Klasse = tb_Klasse.Text;
            //    kunde.Mail = tb_Mail.Text;
            //    kunde.Telefonnummer = tb_Telefonnummer.Text;
            //}
            //MessageBox.Show("Wählen Sie die richtige Zieltabelle der Bibliotheks-Datenbank.", "Achtung", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            //string[] data = { "" };
            //int i = 0;
            //int j = 0;

                //foreach (DataColumn col in dt.Columns)
                //{
                //    foreach (DataRow row in dt.Rows)
                //    {
                //        //typ1 = getDataType(dt.Columns[i].Table.Rows[j].ToString());
                //        //string ob = dt.Columns[i].Table.Rows[j].ToString();
                //        string abc = dt.Rows[i][col].ToString();
                //        //Type typ = dt.Columns[i].DataType;
                //        i++;
                //        Console.Write(abc);
                //        Console.WriteLine(getDataType(abc));

                //    }
                //    Console.WriteLine("------------------");
                //    i = 0;
                //    //DataTable.
                //    //string t = dt.Columns[i].Table.Rows[j].ToString();
                //    //j++;
                //    ////
                //    //foreach (DataRow row in dt.Rows)
                //    //{
                //    //    string t = row[col].ToString();
                //    //    //Console.WriteLine(t);
                //    //    data[i] = getDataType(t).ToString();

                //    //Console.WriteLine("-------------------------------------------------------------------------");
                //    //Console.WriteLine(typ1);
                //    //}
                //}




                //foreach (string s in data)
                //{
                //    Console.WriteLine(s);
                //}

        }

    }
}
