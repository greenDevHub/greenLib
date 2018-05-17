using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung
{
    class Benutzer
    {
        string benutzername;
        public string BenutzerName { get { return benutzername; } set { benutzername = value; } }

        string benutzerpw;
        public string BenutzerPW { get { return benutzerpw; } set { benutzerpw = value; } }

        #region Constructor
        public Benutzer() { }
        public Benutzer(string name)
        {
            this.benutzername = name;
            Load();
        }

        #endregion

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_benutzer] WHERE b_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, benutzername);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                BenutzerName = dr["b_name"].ToString();
                BenutzerPW = dr["b_password"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion
        //private string GetPW()
        //{
        //    byte[] binaryString = (byte[])pw;
        //}

        public bool Login(string pw, string name)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM [dbo].[t_s_benutzer] WHERE b_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, name);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                benutzername = dr["b_name"].ToString();
                byte[] binaryString = (byte[])dr["b_password"];
                benutzerpw = Encoding.UTF8.GetString(binaryString);
                //benutzerpw = dr["b_password"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
            if(BenutzerName != null && !BenutzerName.Equals(""))
            {
                if (BenutzerPW.Equals(pw))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            


        }
    }
}
