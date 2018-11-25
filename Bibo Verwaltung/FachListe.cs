using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung
{
    class FachListe
    {
        #region Eigenschaften

        string fachListeID;
        public string FachListeID { get { return fachListeID; } set { fachListeID = value; } }

        List<string> fachIDs = new List<string>();
        public List<string> FachIDs { get { return fachIDs; } set { fachIDs = value; } }

        List<string> fachNamen = new List<string>();
        public List<string> FachNamen { get { return fachNamen; } set { fachNamen = value; } }

        Faecher fach = new Faecher();
        public Faecher Fach { get { return fach; } set { fach = value; } }

        #endregion
        #region Objekt
        public FachListe()
        {

        }
        public FachListe(string fachListeID)
        {
            this.fachListeID = fachListeID;
            Load();
        }
        #endregion

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "Select * FROM [dbo].[t_s_fachListe] WHERE fl_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, fachListeID);
            while (dr.Read())
            {
                FachListeID = dr["fl_id"].ToString();
                for (int i = 1; i < 17;)
                {
                    string s = dr["fl_fach" + i.ToString()].ToString();
                    if (s != null && !s.Equals(""))
                    {
                        Faecher f = new Faecher(s);
                        fachNamen.Add(f.FachKurz);
                        fachIDs.Add(f.FachID);
                    }
                    else
                    {
                        FachIDs.Add(null);
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
            string RawCommand = "DELETE FROM [dbo].[t_s_fachListe] WHERE fl_id = @id";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@id", FachListeID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Update
        public void Update()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string Rawcommand = "UPDATE [dbo].[t_s_fachListe] set fl_1 = @1, fl_2 = @2, fl_3 = @3, fl_4 = @4, fl_5 = @5, fl_6 = @6, fl_7 = @7, fl_8 = @8, fl_9 = @9, fl_10 = @10, fl_11 = @11, fl_12 = @12, fl_13 = 13, fl_14 = @14, fl_15 = @15, fl_16 = @16 WHERE fl_id = @id ";
            SqlCommand cmd = new SqlCommand(Rawcommand, con.Con);
            cmd.Parameters.AddWithValue("@id", FachListeID);
            cmd.Parameters.AddWithValue("@0", FachIDs[0]);
            for (int i = 1; i < 10;)
            {
                try
                {
                    if (FachIDs[i].ToString() != null && !FachIDs[i].ToString().Equals(""))
                    {
                        cmd.Parameters.AddWithValue("@" + i, FachIDs[i]);
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
            string RawCommand = "Select fl_id FROM [dbo].[t_s_fachListe] WHERE fl_fach1 = @1 ";
            for (int i = 2; i < 17;)
            {
                RawCommand = RawCommand + "AND fl_fach" + i + " = @" + i + " or (fl_fach" + i + " is null and @" + i + " is null) ";
                i++;
            }
            List<object> args = new List<object>();
            args.Add(0);
            for (int i = 1; i < 17;)
            {
                try
                {
                    if (FachIDs[i].ToString() != null && !FachIDs[i].ToString().Equals(""))
                    {
                        args.Add(FachIDs[i]);
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
                FachListeID = dr["fl_id"].ToString();
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
            string RawCommand = "INSERT INTO [dbo].[t_s_fachListe] (fl_fach1, fl_fach2, fl_fach3, fl_fach4, fl_fach5, fl_fach6, fl_fach7, fl_fach8, fl_fach9, fl_fach10, fl_fach11, fl_fach12, fl_fach13, fl_fach14, fl_fach15, fl_fach16) VALUES (@1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14, @15, @16)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@1", FachIDs[0]);
            for (int i = 2; i < 17;)
            {
                try
                {
                    if (FachIDs[i-1].ToString() != null && !FachIDs[i-1].ToString().Equals(""))
                    {
                        cmd.Parameters.AddWithValue("@" + i, FachIDs[i-1]);
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

        #region getNameList
        public List<string> GetNames(string id)
        {
            List<string> names = new List<string>();
            string ids = "";
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return names;
            string RawCommand = "Select * FROM [dbo].[t_s_fachliste] WHERE fl_id = @0 ";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                for (int i = 1; i < 17;)
                {
                    ids = dr["fl_fach" + i].ToString();
                    if (ids != null && !ids.Equals(""))
                    {
                        Faecher a = new Faecher(ids);
                        names.Add(a.FachKurz);
                    }
                    else
                    {
                        names.Add(null);
                    }
                    i++;
                }
            }
            return names;

        }
        #endregion
    }
}
