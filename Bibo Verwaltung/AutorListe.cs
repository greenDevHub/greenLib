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
    class AutorListe
    {
        #region Eigenschaften
        string autorListeID;
        public string AutorListeID { get { return autorListeID; } set { autorListeID = value; } }

        List<string> autorIDs = new List<string>();
        public List<string> AutorIDs { get { return autorIDs; } set { autorIDs = value; } }

        List<string> autorNamen = new List<string>();
        public List <string> AutorNamen { get { return autorNamen; } set { autorNamen = value; } }

        Autor autor = new Autor();
        public Autor Autor { get { return autor; } set { autor = value; } }
        #endregion

        #region Objekt
        public AutorListe()
        {

        }

        public AutorListe(string autorListeID)
        {
            this.autorListeID = autorListeID;
            Load();
        }

        #endregion

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "Select * FROM [dbo].[t_s_autorListe] WHERE a_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, autorListeID);
            while (dr.Read())
            {
                AutorListeID = dr["a_id"].ToString();
                for(int i = 0; i < 10;)
                {
                    string s = dr["a_" + i.ToString()].ToString();
                    if (s != null && !s.Equals(""))
                    {
                        Autor a = new Autor(s);
                        autorNamen.Add(a.Autorname);
                        AutorIDs.Add(a.AutorID);
                    }
                    else
                    {
                        autorIDs.Add(null);
                    }
                    i++;
                    
                }
            }
            dr.Close();
            con.Close();
        }
        #endregion

        #region Delete
        public void Delete()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "DELETE FROM [dbo].[t_s_autorListe] WHERE a_id = @id";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@id", AutorListeID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Update
        public void Update()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string Rawcommand = "UPDATE [dbo].[t_s_autorListe] set a_0 = @0, a_1 = @1, a_2 = @2, a_3 = @3, a_4 = @4, a_5 = @5, a_6 = @6, a_7 = @7, a_8 = @8, a_9 = @9 WHERE a_id = @id ";
            SqlCommand cmd = new SqlCommand(Rawcommand, con.Con);
            cmd.Parameters.AddWithValue("@id", AutorListeID);
            cmd.Parameters.AddWithValue("@0", AutorIDs[0]);
            for(int i = 1; i < 10;)
            {
                try
                {
                    if (AutorIDs[i].ToString() != null && !AutorIDs[i].ToString().Equals(""))
                    {
                        cmd.Parameters.AddWithValue("@" + i, AutorIDs[i]);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + i, DBNull.Value);
                    }
                    i++;
                }
                catch
                {
                    cmd.Parameters.AddWithValue("@" + i, DBNull.Value);
                    i++;
                }
                
                
            }
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region GetID
        private void GetID()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "Select a_id FROM [dbo].[t_s_autorListe] WHERE a_0 = @0 ";
            for(int i = 1; i < 10;)
            {
                RawCommand = RawCommand + "AND a_"+i+" = @"+i+" or (a_"+i+" is null and @"+i+" is null) ";
                i++;
            }
            List<object> args = new List<object>();
            for(int i = 0; i < 10;)
            {
                try
                {
                    if(AutorIDs[i].ToString() != null && !AutorIDs[i].ToString().Equals(""))
                    {
                        args.Add(AutorIDs[i]);
                    }
                    else
                    {
                        args.Add(DBNull.Value);
                    }
                    i++;

                }
                catch
                {
                    args.Add(DBNull.Value);
                    i++;
                }
            }
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, args.ToArray());
            while (dr.Read())
            {
                AutorListeID = dr["a_id"].ToString();
            }
            dr.Close();
            con.Close();
        }
        #endregion

        #region Add
        public void Add()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_autorListe] (a_0, a_1, a_2, a_3, a_4, a_5, a_6, a_7, a_8, a_9) VALUES (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", AutorIDs[0]);
            for(int i = 1; i < 10;)
            {
                try
                {
                    if (AutorIDs[i].ToString() != null && !AutorIDs[i].ToString().Equals(""))
                    {
                        cmd.Parameters.AddWithValue("@" + i, AutorIDs[i]);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@" + i, DBNull.Value);
                    }
                    i++;
                }
                catch
                {
                    cmd.Parameters.AddWithValue("@" + i, DBNull.Value);
                    i++;
                }
            }
            cmd.ExecuteNonQuery();
            con.Close();
            GetID();
        }
        #endregion
    }
}
