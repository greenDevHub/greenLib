using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Bibo_Verwaltung
{
    class Einstellung
    {
        #region Eigenschaften
        private string server;
        public string Server { get { return server; } set { server = value; } }

        private string database;
        public string Database { get { return database; } set { database = value; } }

        private string security;
        public string Security { get { return security; } set { security = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        private string pw;
        public string Pw { get { return pw; } set { pw = value; } }

        private string path = Environment.ExpandEnvironmentVariables(@"C:/Users/%USERNAME%/Documents/Einstellungen.txt");

        #endregion

        #region Methoden
        private bool File_Exists(string path)
        {
            if (File.Exists(path))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsFileReadOnly(string path)
        {
            // Create a new FileInfo object.
            FileInfo fInfo = new FileInfo(path);
            // Return the IsReadOnly property value.
            return fInfo.IsReadOnly;
        }

        public void Save()
        {
            if (!IsFileReadOnly(path))
            {
                File.WriteAllText(path, Server + "\r\n" + Database + "\r\n" + Security + "\r\n" + Name + "\r\n" + Pw);
                MessageBox.Show("Speichern erfolgreich!");
            }
            else
            {
                MessageBox.Show("Speichern nicht erfolgreich! Die Datei ist schreibgeschützt!");
            }
        }

        public void Load()
        {

            if (!File_Exists(path))
            {
                File.WriteAllText(path, "\r\n\r\n\r\n\r\n\r\n");
            }
            //alle Zeilen lesen
            var zeilen = File.ReadLines(path);
            //Zeichen in die Textboxen füllen
            if (zeilen.Count() >= 1) Server = zeilen.First();
            if (zeilen.Count() >= 2) Database = zeilen.Skip(1).First();
            if (zeilen.Count() >= 4) Name = zeilen.Skip(3).First();
            if (zeilen.Count() >= 5) Pw = zeilen.Skip(4).First();

            if (zeilen.Count() >= 3)
            {
                if (zeilen.Skip(2).First() == "Windows Authentifizierung")
                {
                    Security = "Windows Authentifizierung";
                }
                else if (zeilen.Skip(2).First() == "SQL Authentifizierung")
                {
                    Security = "SQL Authentifizierung";
                }
                else if (zeilen.Skip(2).First() != "")
                {
                    MessageBox.Show("Unbekannte Authentifizierungsart. Windows Authentifizierung wurde ausgewählt");
                    Security = "Windows Authentifizierung";
                }
            }
            #endregion
        }
    }
}
