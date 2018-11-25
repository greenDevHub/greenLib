using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung.Extension.Lehrbuchausgabe
{
    class IsbnListe
    {

        #region Eigenschaften
        string isbnListeID;
        public string IsbnListeID { get { return isbnListeID; } set { isbnListeID = value; } }

        List<string> isbns = new List<string>();
        public List<string> ISBNs { get { return isbns; } set { isbns = value; } }

        List<string> buchTitel = new List<string>();
        public List<string> BuchTitel { get { return buchTitel; } set { buchTitel = value; } }

        Buch buch = new Buch(true);
        public Buch Buch { get { return buch; } set { buch = value; } }

        #endregion

        public IsbnListe()
        {

        }

        public IsbnListe(string isbnListeID)
        {
            this.isbnListeID = isbnListeID;
            Load();
        }

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "Select * FROM [dbo].[t_s_isbnliste] WHERE bl_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, isbnListeID);
            while (dr.Read())
            {
                IsbnListeID = dr["bl_id"].ToString();
                for (int i = 0; i < 8;)
                {
                    string s = dr["bl_" + i.ToString()].ToString();
                    if (s != null && !s.Equals(""))
                    {
                        Buch b = new Buch(s, true);
                        BuchTitel.Add(b.Titel);
                        ISBNs.Add(b.ISBN);
                    }
                    else
                    {
                        ISBNs.Add(null);
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
            string RawCommand = "DELETE FROM [dbo].[t_s_isbnliste] WHERE bl_id = @id";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@id", IsbnListeID);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        #endregion

        #region Add
        public void Add()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "INSERT INTO [dbo].[t_s_isbnliste] (bl_0, bl_1, bl_2, bl_3, bl_4, bl_5, bl_6, bl_7) VALUES (@0, @1, @2, @3, @4, @5, @6, @7)";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@0", ISBNs[0]);
            for (int i = 1; i < 8;)
            {
                try
                {
                    if (ISBNs[i].ToString() != null && !ISBNs[i].ToString().Equals(""))
                    {
                        cmd.Parameters.AddWithValue("@" + i, ISBNs[i]);
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

        #region Update
        public void Update()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string Rawcommand = "UPDATE [dbo].[t_s_isbnliste] set bl_0 = @0, bl_1 = @1, bl_2 = @2, bl_3 = @3, bl_4 = @4, bl_5 = @5, bl_6 = @6, bl_7 = @7 WHERE bl_id = @id ";
            SqlCommand cmd = new SqlCommand(Rawcommand, con.Con);
            cmd.Parameters.AddWithValue("@id", IsbnListeID);
            cmd.Parameters.AddWithValue("@0", ISBNs[0]);
            for (int i = 1; i < 8;)
            {
                try
                {
                    if (ISBNs[i].ToString() != null && !ISBNs[i].ToString().Equals(""))
                    {
                        cmd.Parameters.AddWithValue("@" + i, ISBNs[i]);
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
            string RawCommand = "Select bl_id FROM [dbo].[t_s_isbnliste] WHERE bl_0 = @0 ";
            for (int i = 1; i < 8;)
            {
                RawCommand = RawCommand + "AND bl_" + i + " = @" + i + " or (bl_" + i + " is null and @" + i + " is null) ";
                i++;
            }
            List<object> args = new List<object>();
            for (int i = 0; i < 8;)
            {
                try
                {
                    if (ISBNs[i].ToString() != null && !ISBNs[i].ToString().Equals(""))
                    {
                        args.Add(ISBNs[i]);
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
                IsbnListeID = dr["bl_id"].ToString();
            }
            dr.Close();
            con.Close();
        }
        #endregion

        #region getNameList
        public List<string> GetNames(string id)
        {
            List<string> names = new List<string>();
            string ids = "";
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return names;
            string RawCommand = "Select * FROM [dbo].[t_s_isbnliste] WHERE bl_id = @0 ";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, id);
            while (dr.Read())
            {
                for (int i = 0; i < 8;)
                {
                    ids = dr["bl_" + i].ToString();
                    if (ids != null && !ids.Equals(""))
                    {
                        Buch b = new Buch(ids, true);
                        names.Add(b.Titel);
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
