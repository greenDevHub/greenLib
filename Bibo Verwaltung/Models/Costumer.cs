using Bibo_Verwaltung.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Bibo_Verwaltung
{
    class Costumer
    {
        SubjectHelper subjectHelper = new SubjectHelper();
        SchoolClassHelper classHelper = new SchoolClassHelper();

        #region attributes
        int costumerId;
        /// <summary>
        /// get/set the id of a costumer
        /// </summary>
        public int CostumerId { get { return costumerId; } set { costumerId = value; } }

        string costumerFirstName;
        /// <summary>
        /// get/set the first name of a costumer
        /// </summary>
        public string CostumerFirstName { get { return costumerFirstName; } set { costumerFirstName = value; } }

        string costumerSurname;
        /// <summary>
        /// get/set the surname of a costumer
        /// </summary>
        public string CostumerSurname { get { return costumerSurname; } set { costumerSurname = value; } }

        DateTime costumerBirthDate;
        /// <summary>
        /// get/set the birthdate of a costumer
        /// </summary>
        public DateTime CostumerBirthDate { get { return costumerBirthDate; } set { costumerBirthDate = value; } }

        string costumerCity;
        /// <summary>
        /// get/set the city of a costumer
        /// </summary>
        public string CostumerCity { get { return costumerCity; } set { costumerCity = value; } }

        string costumerZipcode;
        /// <summary>
        /// get/set the zipcode of a costumer
        /// </summary>
        public string CostumerZipcode { get { return costumerZipcode; } set { costumerZipcode = value; } }

        string costumerHouseNumber;
        /// <summary>
        /// get/set the house number of a costumer
        /// </summary>
        public string CostumerHouseNumber { get { return costumerHouseNumber; } set { costumerHouseNumber = value; } }

        string costumerStreet;
        /// <summary>
        /// get/set the street of a costumer
        /// </summary>
        public string CostumerStreet { get { return costumerStreet; } set { costumerStreet = value; } }

        string costumerTelephone;
        /// <summary>
        /// get/set the telephone number of a costumer
        /// </summary>
        public string CostumerTelephone { get { return costumerTelephone; } set { costumerTelephone = value; } }


        string costumerEmail;
        /// <summary>
        /// get/set the email address of a costumer
        /// </summary>
        public string CostumerEmail { get { return costumerEmail; } set { costumerEmail = value; } }

        SchoolClass costumerSchoolClass = new SchoolClass();
        /// <summary>
        /// get/set the class of a costumer
        /// </summary>
        public SchoolClass CostumerSchoolClass { get { return costumerSchoolClass; } set { costumerSchoolClass = value; } }

        List<Subject> costumerAdvancedSubjects = new List<Subject>();
        /// <summary>
        /// get/set the advanced subjects of the costumer
        /// </summary>
        public List<Subject> CostumerAdvancedSubjects { get { return costumerAdvancedSubjects; } set { costumerAdvancedSubjects = value; } }

        List<Subject> costumerSubjects = new List<Subject>();
        /// <summary>
        /// get/set the subjects of the costumer
        /// </summary>
        public List<Subject> CostumerSubjects { get { return costumerSubjects; } set { costumerSubjects = value; } }

        bool costumerActivated;
        /// <summary>
        /// get/set the activated status of a costumer
        /// </summary>
        public bool CostumerActivated { get { return costumerActivated; } set { costumerActivated = value; } }
        #endregion

        #region constructor
        /// <summary>
        /// creates an empty costumer object
        /// </summary>
        public Costumer()
        {

        }

        /// <summary>
        /// creates a costumer object with all the loaded data
        /// </summary>
        public Costumer(int costumerId)
        {
            CostumerId = costumerId;
            LoadCostumer();
        }
        #endregion

        /// <summary>
        /// loads all the costumer data
        /// </summary>
        private void LoadCostumer()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            LoadCostumerSubjects();
            string command = "SELECT * FROM [dbo].[t_s_kunden] WHERE  kunde_id = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, costumerId);
            while (dr.Read())
            {
                CostumerId = int.Parse(dr["kunde_ID"].ToString());
                CostumerFirstName = dr["kunde_vorname"].ToString();
                CostumerSurname = dr["kunde_nachname"].ToString();
                CostumerBirthDate = (DateTime)dr["kunde_geburtsdatum"];
                CostumerCity = dr["kunde_ort"].ToString();
                CostumerZipcode = dr["kunde_postleitzahl"].ToString();
                CostumerStreet = dr["kunde_strasse"].ToString();
                CostumerTelephone = dr["kunde_telefonnummer"].ToString();
                CostumerHouseNumber = dr["kunde_hausnummer"].ToString();
                CostumerEmail = dr["kunde_mail"].ToString();
                string schoolClassId = dr["kunde_klasse"].ToString();
                if (schoolClassId == "") CostumerSchoolClass = new SchoolClass();
                else CostumerSchoolClass = new SchoolClass(int.Parse(schoolClassId));
                CostumerActivated = dr["kunde_activated"].ToString().Equals("1") ? true : false;
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// loads the subjects of the costumer
        /// </summary>
        private void LoadCostumerSubjects()
        {
            CostumerSubjects.Clear();
            CostumerAdvancedSubjects.Clear();

            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string RawCommand = "use greenLib Select f_kurzform, f_langform, f_id from t_s_fach_kunde " +
                "left join t_s_faecher on f_id = fs_fachid WHERE fs_kundenid = @0 and fs_lk = 1";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, CostumerId);
            while (dr.Read())
            {
                Subject subject = new Subject();
                subject.SubjectId = int.Parse(dr["f_id"].ToString());
                subject.SubjectNameLong = dr["f_langform"].ToString();
                subject.SubjectNameShort = dr["f_kurzform"].ToString();
                CostumerAdvancedSubjects.Add(subject);
            }
            dr.Close();
            RawCommand = "use greenLib Select f_kurzform, f_langform, f_id from t_s_fach_kunde " +
                "left join t_s_faecher on f_id = fs_fachid WHERE fs_kundenid = @0";
            dr = con.ExcecuteCommand(RawCommand, CostumerId);
            while (dr.Read())
            {
                Subject subject = new Subject();
                subject.SubjectId = int.Parse(dr["f_id"].ToString());
                subject.SubjectNameLong = dr["f_langform"].ToString();
                subject.SubjectNameShort = dr["f_kurzform"].ToString();
                CostumerSubjects.Add(subject);
            }
            for (int i = CostumerAdvancedSubjects.Count; i < 2; i++)
            {
                CostumerAdvancedSubjects.Add(new Subject());
            }
            dr.Close();
            con.Close();
        }

        /// <summary>
        /// Checks whether the current costumer already exists in database (first name, surname and birthdate).
        /// If you want to update a costumer use this method in edit mode
        /// </summary>
        /// <param name="edit"></param>
        /// <returns></returns>
        public bool AlreadyExists(bool edit)
        {
            int newID = -1;
            if (!edit)
            {
                CostumerId = -1;
            }
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return false;
            string RawCommand = "SELECT * FROM [dbo].[t_s_kunden] WHERE kunde_vorname = @0 and kunde_nachname = @1 and kunde_geburtsdatum = @2";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, CostumerFirstName, CostumerSurname, CostumerBirthDate.Date);
            while (dr.Read())
            {
                newID = int.Parse(dr["kunde_id"].ToString());
            }
            dr.Close();
            con.Close();
            if (newID == -1)
            {
                return false;
            }
            else if (edit && newID == CostumerId)
            {
                return false;
            }
            else
            {
                CostumerId = newID;
                return true;
            }
        }

        /// <summary>
        /// adds a costumer to database
        /// </summary>
        public void AddCostumer()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "INSERT INTO [dbo].[t_s_kunden] (kunde_vorname, kunde_nachname, " +
                "kunde_geburtsdatum, kunde_ort, kunde_postleitzahl, kunde_strasse, kunde_telefonnummer, kunde_hausnummer, " +
                "kunde_mail, kunde_klasse, kunde_activated) VALUES (@costumerFirstName, @costumerSurname, @costumerBirthDate, " +
                "@costumerCity, @costumerZipcode, @costumerStreet, " +
                "@costumerTelephone, @costumerHouseNumber, @costumerEmail, @costumerClass, 1)";

            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@costumerFirstName", CostumerFirstName);
            cmd.Parameters.AddWithValue("@costumerSurname", CostumerSurname);
            cmd.Parameters.AddWithValue("@costumerBirthDate", CostumerBirthDate.Date);
            cmd.Parameters.AddWithValue("@costumerCity", CostumerCity);
            cmd.Parameters.AddWithValue("@costumerZipcode", CostumerZipcode);
            cmd.Parameters.AddWithValue("@costumerStreet", CostumerStreet);
            cmd.Parameters.AddWithValue("@costumerTelephone", CostumerTelephone);
            cmd.Parameters.AddWithValue("@costumerHouseNumber", CostumerHouseNumber);
            cmd.Parameters.AddWithValue("@costumerEmail", CostumerEmail);
            if (CostumerSchoolClass != null && CostumerSchoolClass.SchoolClassName != null && CostumerSchoolClass.SchoolClassId>=0)
            {
                cmd.Parameters.AddWithValue("@costumerClass", CostumerSchoolClass.SchoolClassId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@costumerClass", DBNull.Value);
            }

            cmd.ExecuteNonQuery();
            LoadCostumerId();
            AddSubjectsToCostumer();
            con.Close();
        }
        /// <summary>
        /// loads the costumer id if firstname, surname and birth date are filled with data
        /// </summary>
        public void LoadCostumerId()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            CostumerId = -1;
            string command = "SELECT kunde_id FROM [dbo].[t_s_kunden] WHERE kunde_vorname = @0 and kunde_nachname = @1 and kunde_geburtsdatum = @2";
            SqlDataReader dr = con.ExcecuteCommand(command, CostumerFirstName, CostumerSurname, CostumerBirthDate.Date);
            while (dr.Read())
            {
                CostumerId = int.Parse(dr["kunde_id"].ToString());
            }
        }

        /// <summary>
        /// adds the subjects to the specific costumer
        /// </summary>
        private void AddSubjectsToCostumer()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "INSERT INTO [dbo].[t_s_fach_kunde] (fs_kundenid, fs_fachid, fs_lk) VALUES (@costumerId, @subjectId, @isAdvanced)";
            foreach (Subject subject in CostumerSubjects)
            {
                subject.AddSubjectIfNotExists();
                SqlCommand cmd = new SqlCommand(command, con.Con);
                cmd.Parameters.AddWithValue("@costumerId", CostumerId);
                cmd.Parameters.AddWithValue("@subjectId", subject.SubjectId);
                if (CostumerAdvancedSubjects.Contains(subject))
                {
                    cmd.Parameters.AddWithValue("@isAdvanced", true);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@isAdvanced", false);
                }
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        /// <summary>
        /// updates the costumer information 
        /// </summary>
        public void UpdateCostumer()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "UPDATE [dbo].[t_s_kunden] SET kunde_vorname = @costumerFirstName, kunde_nachname = @costumerSurname, " +
                "kunde_geburtsdatum = @costumerBirthDate, kunde_ort = @costumerCity, kunde_postleitzahl = @costumerZipcode, " +
                "kunde_strasse = @costumerStreet, kunde_telefonnummer = @costumerTelephone, kunde_hausnummer = @costumerHouseNumber, " +
                "kunde_mail = @costumerEmail, kunde_klasse = @costumerClass WHERE kunde_ID = @costumerId";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@costumerFirstName", CostumerFirstName);
            cmd.Parameters.AddWithValue("@costumerSurname", CostumerSurname);
            cmd.Parameters.AddWithValue("@costumerBirthDate", CostumerBirthDate.Date);
            cmd.Parameters.AddWithValue("@costumerCity", CostumerCity);
            cmd.Parameters.AddWithValue("@costumerZipcode", CostumerZipcode);
            cmd.Parameters.AddWithValue("@costumerStreet", CostumerStreet);
            cmd.Parameters.AddWithValue("@costumerTelephone", CostumerTelephone);
            cmd.Parameters.AddWithValue("@costumerHouseNumber", CostumerHouseNumber);
            cmd.Parameters.AddWithValue("@costumerEmail", CostumerEmail);
            if (CostumerSchoolClass != null && CostumerSchoolClass.SchoolClassId>=0)
            {
                cmd.Parameters.AddWithValue("@costumerClass", CostumerSchoolClass.SchoolClassId);
            }
            else
            {
                cmd.Parameters.AddWithValue("@costumerClass", DBNull.Value);

            }
            cmd.Parameters.AddWithValue("@costumerId", CostumerId);
            cmd.ExecuteNonQuery();

            DeleteSubjectsOfCostumer();
            AddSubjectsToCostumer();

            con.Close();
        }

        /// <summary>
        /// deletes the subjects of the costumer
        /// </summary>
        private void DeleteSubjectsOfCostumer()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "DELETE FROM [dbo].[t_s_fach_kunde] WHERE fs_kundenid = @costumerId";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@costumerId", CostumerId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// deactivates the current costumer
        /// </summary>
        public void DeactivateCostumer()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string RawCommand = "UPDATE [dbo].[t_s_kunden] set kunde_activated = 0 WHERE kunde_ID = @costumerId";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@costumerId", CostumerId);
            DeleteSubjectsOfCostumer();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// activates the current costumer
        /// </summary>
        public void ActivateCostumer()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "UPDATE [dbo].[t_s_kunden] set kunde_activated = 1 WHERE kunde_ID = @costumerId";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@costumerId", CostumerId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// checks whether the costumer has borrowed a book or not
        /// </summary>
        /// <returns></returns>
        public bool HasBorrowedSomething()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return true;
            int number = 0;
            string command = "SELECT Count(aus_leihnummer) as 'Anzahl' from t_bd_ausgeliehen WHERE aus_kundenid = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, CostumerId);
            while (dr.Read())
            {
                number = int.Parse(dr["Anzahl"].ToString());
            }
            dr.Close();
            con.Close();
            return number > 0 ? true : false;
        }

        /// <summary>
        /// returns a datatable with the borrowed books of the costumer
        /// </summary>
        /// <param name="KID"></param>
        /// <returns></returns>
        public DataTable GetBorrowedBooks()
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string command = "SELECT aus_buchid as 'ID', buch_isbn as 'ISBN', aus_leihdatum as 'Leihdatum', " +
                "aus_rückgabedatum as 'Rückgabedatum' FROM t_bd_ausgeliehen left join t_s_buchid on bu_id = aus_buchid " +
                "left join t_s_buecher on buch_isbn = bu_isbn WHERE aus_kundenid = @0";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", CostumerId);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// returns a datatable with the borrowed school books of the costumer
        /// </summary>
        /// <param name="KID"></param>
        /// <returns></returns>
        public DataTable GetBorrowedSchoolBooks()
        {
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return table;
            string command = "SELECT DISTINCT aus_buchid as 'ID', f_kurzform as 'Fach', buch_isbn as 'ISBN', aus_leihdatum as 'Leihdatum', " +
                "aus_rückgabedatum as 'Rückgabedatum' FROM t_bd_ausgeliehen left join t_s_buchid on bu_id = aus_buchid " +
                "left join t_s_buecher on buch_isbn = bu_isbn left join t_s_buch_fach on bf_isbn = buch_isbn " +
                "left join t_s_faecher on f_id = bf_fachid WHERE aus_kundenid = @0 AND buch_isbn IN (SELECT bf_isbn FROM t_s_buch_fach)";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", CostumerId);
            adapter.Fill(table);
            con.Close();
            return table;
        }

        /// <summary>
        /// returns a list with the isbns of the borrowed books of the costumer
        /// </summary>
        /// <param name="KID"></param>
        /// <returns></returns>
        public List<string> BorrowedBookIsbns()
        {
            List<string> borrowedBooks = new List<string>();
            DataTable table = new DataTable();
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return borrowedBooks;
            string command = "SELECT aus_buchid as 'ID', buch_isbn as 'ISBN' " +
                "FROM t_bd_ausgeliehen left join t_s_buchid on bu_id = aus_buchid " +
                "left join t_s_buecher on buch_isbn = bu_isbn WHERE aus_kundenid = @0";
            SqlDataAdapter adapter = new SqlDataAdapter(command, con.Con);
            adapter.SelectCommand.Parameters.AddWithValue("@0", CostumerId);
            adapter.Fill(table);
            con.Close();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                borrowedBooks.Add(table.Rows[i][1].ToString());
            }
            return borrowedBooks;
        }

        /// <summary>
        /// returns the grade of the costumer
        /// </summary>
        /// <returns></returns>
        public int ReturnGrade()
        {
            int grade = -1;
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return grade;
            string command = "SELECT ks_klassenstufe FROM [dbo].t_s_klasse_stufe WHERE ks_klasse = @0";
            SqlDataReader dr = con.ExcecuteCommand(command, CostumerSchoolClass.SchoolClassId);
            while (dr.Read())
            {
                if (dr.HasRows)
                {
                    grade = int.Parse(dr["ks_klassenstufe"].ToString());
                }
            }
            dr.Close();
            con.Close();
            return grade;
        }
    }
}

