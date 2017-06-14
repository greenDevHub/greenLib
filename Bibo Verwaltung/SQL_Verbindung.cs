using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class SQL_Verbindung
    {
        private string ConnectionString;
        private static string Base_Server = "Data Source=";
        private static string Default_Server = ".\\SQLEXPRESS";
        private static string Base_Database = "Initial Catalog=";
        private static string Default_Database = "Bibo_Verwaltung";
        private static string Base_Server_Integrated_Security = "Integrated Security=";
        private static string Default_Server_Integrated_Security = "sspi";
        private static string Base_Username = "User ID=";
        private static string Base_Password = "Password=";
        private bool build = false;
        private bool error = false;
        //private static bool connected = false;

        private SqlConnection con = new SqlConnection();
        public SqlConnection Con { get { return con; } set { con = value; } }

        public SQL_Verbindung()
        {
            ConnectionString = Base_Server + Default_Server + ";" + Base_Database + Default_Database + ";" 
                + Base_Server_Integrated_Security + Default_Server_Integrated_Security + ";";
            build = true;
        }

        public SQL_Verbindung(string Server)
        {
            ConnectionString = Base_Server + Server.ToLower() + ";" + Base_Database + Default_Database + ";" 
                + Base_Server_Integrated_Security + Default_Server_Integrated_Security + ";";
            build = true;
        }
        public SQL_Verbindung(string Server, string Database)
        {
            ConnectionString = Base_Server + Server.ToLower() + ";" + Base_Database + Database.ToLower() + ";"
                + Base_Server_Integrated_Security + Default_Server_Integrated_Security + ";";
            build = true;
        }

        public SQL_Verbindung(string Server, string Database, bool Security, string Username, string Password)
        {
            if (Security == false)
            {
                ConnectionString = Base_Server + Server.ToLower() + ";" + Base_Database + Default_Database + ";" 
                    + Base_Server_Integrated_Security + "false;" + Base_Username + Username + ";" + Base_Password + Password + ";";
                build = true;
            } else
            {
                Console.WriteLine("Du hast SSPI gewählt! Benutzte bitte SQL_Verbinung(String Server) ODER SQL_Verbindung(String Server, String Database)!");
                build = false;
            }  
        }

        public bool ConnectError()
        {
            if (build == false) return true;
            con = new SqlConnection();
            con.ConnectionString = this.ConnectionString;
            try
            {
                con.Open();
                error = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Die Verbindung zu dem SQL-Server konnte nicht hergestellt werden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            return error;
        }

        public void Close()
        {
            con.Close();
        }

        public SqlDataReader ExcecuteCommand(String sqlCommand, params object [] parameter)
        {
            SqlCommand cmd = new SqlCommand(sqlCommand, con);
            for (int i = 0; i < parameter.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + i.ToString(), parameter[i]);
            }
            return cmd.ExecuteReader();
        }
    }
}
