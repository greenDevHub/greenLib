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
            LeseCSV(preview);
        }
        #endregion


        public void FillGridViewRows(ref DataGridView grid, object value = null)
        {
            grid.DataSource = dt;
        }

        #region CSV-Dateien einlesen
        private void LeseCSV(bool preview)
        {
            FileInfo f = new FileInfo(path);
            long filelength = f.Length;

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line = file.ReadLine();

            if (preview == false)
            {

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
                        dt.Rows.Add(firstline);
                    }
                    while ((line = file.ReadLine()) != null)
                    {
                        string[] parts = line.Split(separator);




                        int curr = 0;
                        foreach (string s in parts)
                        {
                            //if (s[1] == '"')
                            //{
                                string h = s.Replace(textqualifizierer.ToString(), "");
                                parts[curr] = h.Trim();
                            curr++;
                            //}
                        }





                        dt.Rows.Add(parts);
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
                    for (int j = 0; j < 9; j++)
                    {
                        if ((line = file.ReadLine()) != null)
                        {
                            string[] parts = line.Split(separator);
                            dt.Rows.Add(parts);
                        }
                    }
                }
                file.Close();
            }
        }
        #endregion

        public void executeImport(string target)
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

    }
}
