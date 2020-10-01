using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Benutzer
    {
        string benutzername;
        public string BenutzerName { get { return benutzername; } set { benutzername = value; } }

        string benutzerpw;
        public string BenutzerPW { get { return benutzerpw; } set { benutzerpw = value; } }

        string rechte;
        public string Rechte { get { return rechte; } set { rechte = value; } }

        private string rechteid;
        public string Rechteid { get { return rechteid; } set { rechteid = value; } }


        #region Constructor
        public Benutzer()
        {
        }
        public Benutzer(bool b)
        {
            FillObject();
        }
        public Benutzer(string name)
        {
            this.benutzername = name;
            LoadUser();
            FillObject();
        }
        #endregion

        SQL_Verbindung con = new SQL_Verbindung();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();

        /// <summary>
        /// Lädt die Daten eines Benutzers
        /// </summary>
        private void LoadUser()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_benutzer] WHERE b_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, benutzername);
            while (dr.Read())
            {
                BenutzerName = dr["b_name"].ToString();
                BenutzerPW = dr["b_password"].ToString();
                Rechteid = dr["b_rechte"].ToString();
                Rechte = GetRechte(rechteid);
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Gibt die Rechte eines Benutzers zurück (in Worten)
        /// </summary>
        private string GetRechte(string rechteID)
        {
            if (rechteID.Equals("0"))
            {
                rechteID = "Gast";
                return rechteID;
            }
            else if (rechteID.Equals("1"))
            {
                rechteID = "Benutzer";
                return rechteID;
            }
            else if (rechteID.Equals("2"))
            {
                rechteID = "Admin";
                return rechteID;
            }
            else
            {
                return "unbekannt";
            }
        }

        /// <summary>
        /// Prüft die Anmeldedaten und meldet einen Benutzer an
        /// </summary>
        public bool LoginUser(string pw, string name)
        {
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM [dbo].[t_s_benutzer] WHERE b_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, name);
            while (dr.Read())
            {
                benutzername = dr["b_name"].ToString();
                byte[] binaryString = (byte[])dr["b_password"];
                benutzerpw = Encoding.UTF8.GetString(binaryString);
            }
            dr.Close();
            con.Close();

            if (BenutzerName != null && !BenutzerName.Equals(""))
            {
                try
                {
                    /* Fetch the stored value */
                    string savedPasswordHash = benutzerpw;
                    /* Extract the bytes */
                    byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                    /* Get the salt */
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    /* Compute the hash on the password the user entered */
                    var pbkdf2 = new Rfc2898DeriveBytes(pw, salt, 100000);
                    byte[] hash = pbkdf2.GetBytes(20);
                    /* Compare the results */
                    /* Compare the results */
                    for (int i = 0; i < 20; i++)
                        if (hashBytes[i + 16] != hash[i])
                            throw new UnauthorizedAccessException();
                    return true;
                }
                catch(UnauthorizedAccessException)
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Fügt einen Benutzer der Datenbank hinzu
        /// </summary>
        public void AddUser(string name, string pw, string rechte)
        {
            byte[] newPW = Encoding.UTF8.GetBytes(pw);
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_benutzer] (b_name, b_password, b_rechte) VALUES (@0, @1, @2)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", name);
            cmd.Parameters.AddWithValue("@1", newPW);
            cmd.Parameters.AddWithValue("@2", rechte);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Entfernt einen Benutzer aus der Datenbank
        /// </summary>
        public void DeleteUser(string name)
        {
            if (con.ConnectError()) return;
            string RawCommand = "DELETE FROM [dbo].[t_s_benutzer] WHERE b_name = @name";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Aktualisiert einen Benutzer in der Datenbank
        /// </summary>
        public void UpdateUser(string name, string pw, string rechte)
        {
            byte[] newPW = Encoding.UTF8.GetBytes(pw);
            string RawCommand = "UPDATE t_s_benutzer set b_password = @pw, b_rechte = @rechteid WHERE b_name = @name";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@pw", newPW);
            cmd.Parameters.AddWithValue("@rechteid", rechte);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// Füllt ein DataSet mit Benutzerdaten
        /// </summary>
        private void FillObject()
        {
            if (con.ConnectError()) return;
            string RawCommand = "SELECT b_name as 'Name', b_rechte as 'RechteID' FROM [dbo].[t_s_benutzer]";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            con.Close();
            if (!ds.Tables[0].Columns.Contains("Rechte"))
            {
                ds.Tables[0].Columns.Add("Rechte");
            }
                foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string rechteID = "";
                rechteID = dr["RechteID"].ToString();
                dr["Rechte"] = GetRechte(rechteID);
            }
        }

        /// <summary>
        /// Entfernt den gesamten Inhalt im DataSet 
        /// </summary>
        private void ClearDataSource()
        {
            try
            {
                ds.Tables[0].Rows.Clear();
            }
            catch { }
        }

        /// <summary>
        /// Füllt ein DataGridView-Objekt mit Benutzerdaten
        /// </summary>
        public void FillGrid(ref MetroGrid grid, object value = null)
        {
            ClearDataSource();
            FillObject();
            grid.DataSource = ds.Tables[0];
            grid.Columns["RechteID"].Visible = false;
        }
    }
}