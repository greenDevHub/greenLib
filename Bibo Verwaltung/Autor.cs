using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class Autor
    {
        #region Autor Eigenschafen
        string autorid;
        /// <summary>
        /// ID des Autors
        /// </summary>
        public string AutorID { get { return autorid; } set { autorid = value; } }

        string autorname;
        /// <summary>
        /// Autorname eines Autors
        /// </summary>
        public string Autorname { get { return autorname; } set { autorname = value; } }
        #endregion

        #region Objekt Autor
        /// <summary>
        /// Erschaft das Objekt Autor
        /// </summary>
        public Autor()
        {
            FillObject();
        }
        public Autor(string autorid)
        {
            this.autorid = autorid;
            Load();
            FillObject();
        }
        #endregion

        #region Load
        private void Load()
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_autor] WHERE au_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, autorid);
            // Einlesen der Datenzeilen und Ausgabe an der Konsole 
            while (dr.Read())
            {
                AutorID = dr["au_id"].ToString();
                Autorname = dr["au_autor"].ToString();
            }
            // DataReader schließen 
            dr.Close();
            // Verbindung schließen 
            con.Close();
        }
        #endregion
        #region Add
        public void Add(List<string> autors)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            for (int i = 0; i < autors.Count;)
            {
                string RawCommand = "INSERT INTO [dbo].[t_s_autor] (au_autor) VALUES (@0)";
                SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
                cmd.Parameters.AddWithValue("@0", autors[i]);
                cmd.ExecuteNonQuery();
                i++;
            }
            con.Close();
            
        }
        #endregion

        #region GetID
        public string GetID(string autor)
        {
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return "";
            string RawCommand = "SELECT au_id FROM [dbo].[t_s_autor] WHERE au_autor = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand,autor);
            while (dr.Read())
            {
                AutorID = dr["au_id"].ToString();
            }
            dr.Close();
            con.Close();
            return AutorID;
        }
        #endregion

        public bool IfContains(string value)
        {
            bool contains = dt.AsEnumerable().Any(row => value == row.Field<String>("au_autor"));
            return contains;
        }

        #region Fill Object
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        SqlCommandBuilder comb = new SqlCommandBuilder();
        private void FillObject()
        {
            dt.Clear();
            SQL_Verbindung con = new SQL_Verbindung();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_autor]";

            // Verbindung öffnen 
            adapter = new SqlDataAdapter(RawCommand, con.Con);
            adapter.Fill(ds);
            adapter.Fill(dt);

            con.Close();
        }
        public void FillCombobox(ref ComboBox cb, object value)
        {
            FillObject();
            cb.DataSource = dt;
            cb.ValueMember = "au_id";
            cb.DisplayMember = "au_autor";
            cb.SelectedValue = value;
        }
        public void FillList(ref CheckedListBox clb)
        {
            FillObject();
            ((ListBox)clb).DataSource = dt;
            ((ListBox)clb).DisplayMember = "au_autor";
            ((ListBox)clb).ValueMember = "au_id";
        }

        public void FillGrid(ref DataGridView grid, object value = null)
        {
            grid.DataSource = ds.Tables[0];
            grid.Columns[0].Visible = false;
            grid.Columns["au_autor"].HeaderText = "Bezeichnung";
        }
        #endregion

        #region Speichern Grid
        public void SaveGrid(ref DataGridView grid)
        {
            comb = new SqlCommandBuilder(adapter);
            DataSet changes = ds.GetChanges();
            if (changes != null)
            {
                adapter.Update(changes);
            }
        }
        #endregion
    }
}
