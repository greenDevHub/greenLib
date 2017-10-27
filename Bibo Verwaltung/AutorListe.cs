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
                    i++;
                    
                }
            }
            dr.Close();
            con.Close();
        }
        #endregion

        #region FillCombobox
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            dt.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_autorListe]";
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);
            con.Close();

        }
        #endregion
    }
}
