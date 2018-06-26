using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            Load();
            FillObject();
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
                Rechteid = dr["b_rechte"].ToString();
                Rechte = GetRechte(rechteid);
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
        private string GetRechte(string s)
        {
            if (s.Equals("0"))
            {
                s = "Gast";
                return s;
            }
            else if (s.Equals("1"))
            {
                s = "Benutzer";
                return s;
            }
            else if (s.Equals("2"))
            {
                s = "Admin";
                return s;
            }
            else
            {
                return "unbekannt";
            }
        }
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

        public void Add(string name, string pw, string rechte)
        {
            byte[] newPW = Encoding.UTF8.GetBytes(pw);
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_benutzer] (b_name, b_password, b_rechte) VALUES (@0, @1, @2)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", name);
            cmd.Parameters.AddWithValue("@1", newPW);
            cmd.Parameters.AddWithValue("@2", rechte);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Delete(string name)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "DELETE FROM [dbo].[t_s_benutzer] WHERE b_name = @name";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update(string name, string pw, string rechte)
        {
            byte[] newPW = Encoding.UTF8.GetBytes(pw);
            SQL_Verbindung con = new SQL_Verbindung();
            string RawCommand = "UPDATE t_s_benutzer set b_password = @pw, b_rechte = @rechteid WHERE b_name = @name";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@pw", newPW);
            cmd.Parameters.AddWithValue("@rechteid", rechte);
            cmd.Parameters.AddWithValue("@name", name);
            // Verbindung öffnen 
            cmd.ExecuteNonQuery();
            //Verbindung schließen
            con.Close();
        }
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            //DataTable dt = new DataTable();
            //dt.Clear();
            //dt.Columns.Add("Name");
            //dt.Columns.Add("Rechte");
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT b_name as 'Name', b_rechte as 'RechteID' FROM [dbo].[t_s_benutzer]";

            // Verbindung öffnen 
            dt.Reset();
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            con.Close();
            dt.Columns.Add("Rechte");
            foreach(DataRow dr in dt.Rows)
            {
                string s = "";
                s = dr["RechteID"].ToString();
                dr["Rechte"] = GetRechte(s);
                //DataRow row = dt.NewRow();
                //row["Name"] = dr["b_name"];
                //row["Rechte"] = s;
                //dt.Rows.Add(row);
            }

        }
        public void FillGrid(ref DataGridView grid, object value = null)
        {
            dt.Clear();
            FillObject();
            grid.DataSource = dt;
            //rid.Columns["b_name"].HeaderText = "Name";
            grid.Columns["RechteID"].Visible = false;


        }
    }
}
