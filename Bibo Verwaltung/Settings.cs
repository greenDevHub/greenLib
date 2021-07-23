using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Bibo_Verwaltung
{
    class Settings
    {
        #region attributes
        private string server;
        /// <summary>
        /// get/set the name of the database server
        /// </summary>
        public string Server { get { return server; } set { server = value; } }
        /// <summary>
        /// get/set the name of the database
        /// </summary>
        private string database;
        public string Database { get { return database; } set { database = value; } }

        private string security;
        /// <summary>
        /// get/set the security type
        /// </summary>
        public string Security { get { return security; } set { security = value; } }

        private string databaseLoginName;
        /// <summary>
        /// get/set the login name for the database user
        /// </summary>
        public string DatabaseLoginName { get { return databaseLoginName; } set { databaseLoginName = value; } }

        private string databaseLoginPassword;
        /// <summary>
        /// get/set the login password for the database user
        /// </summary>
        public string DatabaseLoginPassword { get { return databaseLoginPassword; } set { databaseLoginPassword = value; } }

        private string connectionSettingPath;
        /// <summary>
        /// get the path of the connection setting file
        /// </summary>
        public string ConnectionSettingPath { get { return connectionSettingPath; } }

        private string settingsPath;
        /// <summary>
        /// get the path of the settings directory
        /// </summary>
        public string SettingsPath { get { return settingsPath; } }
        #endregion

        public Settings()
        {
            connectionSettingPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\greenLib\\Einstellungen\\ConnectionSettings.txt";
            settingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\greenLib\\Einstellungen";
            LoadSettings();
        }
        #region Methoden: File_Exists(), IsFileReadOnly(), SaveSettings(), LoadSettings()
        private bool IsFileReadOnly(string path)
        {
            // Create a new FileInfo object.
            FileInfo fInfo = new FileInfo(path);
            // Return the IsReadOnly property value.
            return fInfo.IsReadOnly;
        }

        private string Encrypt(string clearText)
        {
            string EncryptionKey = Properties.Settings.Default.secretKey;
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
            string EncryptionKey = Properties.Settings.Default.secretKey;
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
            if (!IsFileReadOnly(connectionSettingPath))
            {
                File.WriteAllText(connectionSettingPath, Server + "\r\n" + Database + "\r\n" + Security + "\r\n" + Encrypt(DatabaseLoginName) + "\r\n" + Encrypt(DatabaseLoginPassword));
                if (message)
                {
                    i = 0;
                }
            }
            else
            {
                if (message)
                {
                    i = 1;
                }
                else
                {
                    i = 2;
                }
            }

            return i;
        }

        public int LoadSettings()
        {
            int i = 0;
            try
            {
                if (!File.Exists(connectionSettingPath))
                {
                    //create empty text file
                    File.WriteAllText(connectionSettingPath, "\r\n\r\n\r\n\r\n\r\n");
                }

                //read all lines
                var lines = File.ReadLines(connectionSettingPath);
                //Zeichen in die Textboxen füllen
                if (lines.Count() >= 1) Server = lines.First();
                if (lines.Count() >= 2) Database = lines.Skip(1).First();
                if (lines.Count() >= 4) DatabaseLoginName = lines.Skip(3).First();
                if (lines.Count() >= 5) DatabaseLoginPassword = lines.Skip(4).First();
                DatabaseLoginPassword = Decrypt(DatabaseLoginPassword);
                DatabaseLoginName = Decrypt(DatabaseLoginName);
                if (lines.Count() >= 3)
                {
                    if (lines.Skip(2).First() == "Windows Authentifizierung")
                    {
                        i = 0;
                        Security = "Windows Authentifizierung";
                    }
                    else if (lines.Skip(2).First() == "SQL Authentifizierung")
                    {
                        i = 1;
                        Security = "SQL Authentifizierung";
                    }
                    else if (lines.Skip(2).First() != "")
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
