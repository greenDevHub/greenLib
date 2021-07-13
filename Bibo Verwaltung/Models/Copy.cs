using System;
using System.Data.SqlClient;

namespace Bibo_Verwaltung
{
    class Copy
    {
        #region attributes
        int copyId;
        public int CopyId { get { return copyId; } set { copyId = value; } }

        string copyIsbn;
        public string CopyIsbn { get { return copyIsbn; } set { copyIsbn = value; } }

        string copyTitle;
        public string CopyTitle { get { return copyTitle; } set { copyTitle = value; } }

        Condition condition = new Condition();
        public Condition Condition { get { return condition; } set { condition = value; } }

        DateTime dateRegistration;
        public DateTime DateRegistration { get { return dateRegistration; } set { dateRegistration = value; } }

        bool copyActivated;
        public bool CopyActivated { get { return copyActivated; } set { copyActivated = value; } }

        bool copyPrinted;
        public bool CopyPrinted { get { return copyPrinted; } set { copyPrinted = value; } }
        #endregion

        #region constructor

        /// <summary>
        /// creates an empty copy object
        /// </summary>
        public Copy()
        {

        }

        /// <summary>
        /// creates a copy object by its Id and loads all its information from the database
        /// </summary>
        /// <param name="copyId"></param>
        public Copy(int copyId)
        {
            this.copyId = copyId;
            LoadCopy();
        }
        #endregion

        /// <summary>
        /// loads all the data for the copy object
        /// </summary>
        private void LoadCopy()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError()) return;
            string command = "SELECT bu_id, bu_isbn, buch_titel, " +
                "bu_zustandsid, isnull(bu_aufnahmedatum, '01.01.1990') as 'verified_aufnahmedatum', " +
                "bu_activated, bu_printed from t_s_buchid left join t_s_zustand on bu_zustandsid = zu_id " +
                "left join t_s_buecher on bu_isbn = buch_isbn where bu_id = @0";
            SqlDataReader dr = connection.ExcecuteCommand(command, CopyId);
            while (dr.Read())
            {
                CopyId = int.Parse(dr["bu_id"].ToString());
                CopyIsbn = dr["bu_isbn"].ToString();
                CopyTitle = dr["buch_titel"].ToString();
                Condition = new Condition(int.Parse(dr["bu_zustandsid"].ToString()));
                DateRegistration = (DateTime)dr["verified_aufnahmedatum"];
                CopyActivated = dr["bu_activated"].ToString().Equals(0) ? false : true;
                CopyPrinted = dr["bu_printed"].ToString().Equals(0) ? false : true;
            }
            dr.Close();
            connection.Close();
        }

        /// <summary>
        /// adds a copy with the given information to database
        /// </summary>
        public void Add()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError()) return;
            string command = "Insert INTO t_s_buchid (bu_isbn, bu_zustandsid, bu_aufnahmedatum, bu_activated, bu_printed) " +
                "VALUES (@isbn, @conditionId, @dateRegistration, @activated, @printed)";
            SqlCommand cmd = new SqlCommand(command, connection.Con);
            cmd.Parameters.AddWithValue("@isbn", CopyIsbn);
            cmd.Parameters.AddWithValue("@conditionId", Condition.ConditionId);
            cmd.Parameters.AddWithValue("@dateRegistration", DateRegistration);
            cmd.Parameters.AddWithValue("@activated", 1);
            cmd.Parameters.AddWithValue("@printed", 0);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// updates the information of one copy 
        /// </summary>
        public void Update()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError()) return;
            string command = "UPDATE t_s_buchid set bu_zustandsid = @conditionId, bu_aufnahmedatum = @dateRegistration " +
                "WHERE bu_id = @copyId";
            SqlCommand cmd = new SqlCommand(command, connection.Con);
            cmd.Parameters.AddWithValue("@conditionId", Condition.ConditionId);
            cmd.Parameters.AddWithValue("@dateRegistration", DateRegistration);
            cmd.Parameters.AddWithValue("@copyId", CopyId);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// deletes the copy with the given id from the database
        /// </summary>
        public void Delete()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError()) return;
            string command = "DELETE FROM [dbo].[t_s_buchid] WHERE bu_id = @copyId";
            SqlCommand cmd = new SqlCommand(command, connection.Con);
            cmd.Parameters.AddWithValue("@copyId", CopyId);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        /// <summary>
        /// deactivates the copy object 
        /// </summary>
        public void Deactivate()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError()) return;
            string command = "UPDATE t_s_buchid set bu_activated = @activated WHERE bu_id = @copyId";
            SqlCommand cmd = new SqlCommand(command, connection.Con);
            cmd.Parameters.AddWithValue("@activated", 0);
            cmd.Parameters.AddWithValue("@copyId", CopyId);
            cmd.ExecuteNonQuery();
            connection.Close();
            CopyActivated = false;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="isbn"></param>
        public void SelectLastRow()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError()) return;
            string RawCommand = "Select top(1) bu_id from t_s_buchid where bu_isbn = @0 order by bu_id desc";
            SqlDataReader dr = connection.ExcecuteCommand(RawCommand, CopyIsbn);
            while (dr.Read())
            {
                CopyId = int.Parse(dr["bu_id"].ToString());
            }
            dr.Close();
            connection.Close();
        }

        /// <summary>
        /// checks whether a copy is available and can be deactivated or not
        /// </summary>
        /// <returns>returns true if the copy is available or false if its not available</returns>
        public bool IsAvailable()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            if (connection.ConnectError()) return false;
            string command = "SELECT COUNT(*) FROM t_bd_ausgeliehen where aus_buchid = @copyId";
            int count = 0;
            using (SqlCommand cmdCount = new SqlCommand(command, connection.Con))
            {
                cmdCount.Parameters.AddWithValue("@copyId", CopyId);
                count = (int)cmdCount.ExecuteScalar();
                connection.Close();
            }
            return count == 0;
        }

        /// <summary>
        /// sets the 'printed' attribute of the copy to true
        /// </summary>
        public void Print()
        {
            CustomSqlConnection connection = new CustomSqlConnection();
            string command = "UPDATE t_s_buchid set bu_printed = @copyPrinted WHERE bu_id = @copyId";
            if (connection.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(command, connection.Con);
            cmd.Parameters.AddWithValue("@copyPrinted", 1);
            cmd.Parameters.AddWithValue("@copyId", CopyId);
            cmd.ExecuteNonQuery();
            connection.Close();
            CopyPrinted = true;
        }

    }
}
