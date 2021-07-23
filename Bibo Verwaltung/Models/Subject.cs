using System.Data.SqlClient;

namespace Bibo_Verwaltung
{
    class Subject
    {
        #region attributes
        int subjectId;
        /// <summary>
        /// get/set the id of a subject
        /// </summary>
        public int SubjectId { get { return subjectId; } set { subjectId = value; } }

        string subjectNameLong;
        /// <summary>
        /// get/set the long name of a subject
        /// </summary>
        public string SubjectNameLong { get { return subjectNameLong; } set { subjectNameLong = value; } }

        string subjectNameShort;
        /// <summary>
        /// get/set the short name of a subject
        /// </summary>
        public string SubjectNameShort { get { return subjectNameShort; } set { subjectNameShort = value; } }
        #endregion

        #region constructor
        /// <summary>
        /// creates an empty subject object
        /// </summary>
        public Subject()
        {

        }

        /// <summary>
        /// creates a subject object with all the information
        /// </summary>
        public Subject(int subjectId)
        {
            SubjectId = subjectId;
            LoadSubject();
        }
        #endregion

        /// <summary>
        /// loads the information of the subject
        /// </summary>
        private void LoadSubject()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM t_s_faecher WHERE f_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, SubjectId);
            while (dr.Read())
            {
                SubjectId = int.Parse(dr["f_id"].ToString());
                SubjectNameShort = dr["f_kurzform"].ToString();
                SubjectNameLong = dr["f_langform"].ToString();
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// adds a subject to database
        /// </summary>
        public void AddSubjectIfNotExists()
        {
            string command = $"begin if not exists (select f_kurzform from t_s_faecher where f_kurzform=@0) begin insert into t_s_faecher (f_kurzform, f_langform) values (@1, @2) end end";
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@0", SubjectNameShort);
            cmd.Parameters.AddWithValue("@1", SubjectNameShort);
            cmd.Parameters.AddWithValue("@2", SubjectNameLong);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}