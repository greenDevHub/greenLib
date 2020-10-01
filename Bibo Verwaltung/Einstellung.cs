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
using System.Security.Cryptography;

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

        public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\greenLib\\Einstellungen\\ConnectionSettings.txt";

        private string homePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\greenLib\\Einstellungen";
        public string HomePath { get { return homePath; } set { homePath = value; } }

        public double scale;
        public double Scale { get { return scale; } set { scale = value; } }
        #endregion

        public Einstellung()
        {
            LoadSettings();
            LoadScale();
        }
        #region Methoden: File_Exists(), IsFileReadOnly(), SaveSettings(), LoadSettings()
        private void LoadScale()
        {
            try
            {
                if (!File_Exists(homePath+"\\Scale.txt"))
                {
                    File.WriteAllText(homePath + "\\Scale.txt", "1,00");
                }
                //alle Zeilen lesen
                scale = float.Parse(File.ReadAllText(homePath + "\\Scale.txt"));
                
            }
            catch
            {
                
            }

        }
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

        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        private string Decrypt(string cipherText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }
        public int SaveSettings(bool message)
        {
            int i = 0;
            if (!IsFileReadOnly(path))
            {
                File.WriteAllText(path, Server + "\r\n" + Database + "\r\n" + Security + "\r\n" + Encrypt(Name) + "\r\n" + Encrypt(Pw));
                if (message)
                {
                    i = 0;
                    //MessageBox.Show("Datenbankserver-Verbindung erfolgreich gespeichert!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (message)
                {
                    i = 1;
                    //MessageBox.Show("Speichern fehlgeschlagen. Die Konfigurationsdatei ist schreibgeschützt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    i = 2;
                    //MessageBox.Show("Die Änderungen konnten nicht übernommen werden. Die Konfigurationsdatei ist schreibgeschützt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            return i;
        }

        public int LoadSettings()
        {
            int i = 0;
            try
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
                Pw = Decrypt(Pw);
                Name = Decrypt(Name);
                if (zeilen.Count() >= 3)
                {
                    if (zeilen.Skip(2).First() == "Windows Authentifizierung")
                    {
                        i = 0;
                        Security = "Windows Authentifizierung";
                    }
                    else if (zeilen.Skip(2).First() == "SQL Authentifizierung")
                    {
                        i = 1;
                        Security = "SQL Authentifizierung";
                    }
                    else if (zeilen.Skip(2).First() != "")
                    {
                        i = 2;
                        //MessageBox.Show("Unbekannte Authentifizierungsart. Windows Authentifizierung wurde ausgewählt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Security = "Windows Authentifizierung";
                        SaveSettings(true);
                    }
                }
            }
            catch (Exception)
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\greenLib\\Einstellungen");
            }
            return i;
            #endregion
        }
    }
}
