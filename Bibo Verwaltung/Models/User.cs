using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Bibo_Verwaltung
{
    class User
    {
        string userName;
        public string UserName { get { return userName; } set { userName = value; } }

        string userPassword;
        public string UserPassword { get { return userPassword; } set { userPassword = value; } }

        string permissionName;
        public string PermissionName { get { return permissionName; } set { permissionName = value; } }

        private int permissionId;
        public int PermissionId { get { return permissionId; } set { permissionId = value; } }


        #region constructor
        public User()
        {
        }
        public User(string userName)
        {
            UserName = userName;
            LoadUser();
        }
        #endregion

        /// <summary>
        /// loads the information of the user
        /// </summary>
        private void LoadUser()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string RawCommand = "SELECT * FROM [dbo].[t_s_benutzer] WHERE b_name = @0";
            SqlDataReader dr = con.ExcecuteCommand(RawCommand, userName);
            while (dr.Read())
            {
                UserName = dr["b_name"].ToString();
                byte[] binaryString = (byte[])dr["b_password"];
                UserPassword = Encoding.UTF8.GetString(binaryString);
                PermissionId = int.Parse(dr["b_rechte"].ToString());
                PermissionName = GetPermissionById(permissionId);
            }
            dr.Close();
            con.Close();
        }

        public enum Permission
        {
            Gast = 0,
            Benutzer = 1,
            Admin = 2,
            unbekannt
        }
        /// <summary>
        /// returns the name of the permission by its id
        /// </summary>
        /// <param name="permissionId"></param>
        /// <returns></returns>
        private string GetPermissionById(int permissionId)
        {
            switch (permissionId)
            {
                case 0:
                    return "Gast";
                case 1:
                    return "Benutzer";
                case 2:
                    return "Admin";
                default:
                    return "unbekannt";
            }
        }

        /// <summary>
        /// checks whether the password and name are correct and tries a login of the user
        /// </summary>
        /// <param name="inputPassword"></param>
        /// <param name="inputUserName"></param>
        /// <returns></returns>
        public bool CanLogin(string inputPassword)
        {
            if (UserName != null && !UserName.Equals(""))
            {
                try
                {
                    LoadUser();

                    /* Fetch the stored value */
                    string savedPasswordHash = UserPassword;
                    /* Extract the bytes */
                    byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);
                    /* Get the salt */
                    byte[] salt = new byte[16];
                    Array.Copy(hashBytes, 0, salt, 0, 16);
                    /* Compute the hash on the password the user entered */
                    var pbkdf2 = new Rfc2898DeriveBytes(inputPassword, salt, 100000);
                    byte[] hash = pbkdf2.GetBytes(20);
                    /* Compare the results */
                    /* Compare the results */
                    for (int i = 0; i < 20; i++)
                        if (hashBytes[i + 16] != hash[i])
                            throw new UnauthorizedAccessException();
                    return true;
                }
                catch
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// adds a new user to database
        /// </summary>
        public void AddUser()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string command = "INSERT INTO [dbo].[t_s_benutzer] (b_name, b_password, b_rechte) VALUES (@0, @1, @2)";
            SqlCommand cmd = new SqlCommand(command, con.Con);
            cmd.Parameters.AddWithValue("@0", UserName);
            cmd.Parameters.AddWithValue("@1", Encoding.UTF8.GetBytes(UserPassword));
            cmd.Parameters.AddWithValue("@2", PermissionId);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// removes the user from database
        /// </summary>
        public void DeleteUser()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            if (con.ConnectError()) return;
            string RawCommand = "DELETE FROM [dbo].[t_s_benutzer] WHERE b_name = @userName";
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@userName", UserName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        /// <summary>
        /// updates the user data
        /// </summary>
        public void UpdateUser()
        {
            CustomSqlConnection con = new CustomSqlConnection();
            string RawCommand = "UPDATE t_s_benutzer set b_password = @userPassword, b_rechte = @permissionId WHERE b_name = @userName";
            if (con.ConnectError()) return;
            SqlCommand cmd = new SqlCommand(RawCommand, con.Con);
            cmd.Parameters.AddWithValue("@userPassword", Encoding.UTF8.GetBytes(UserPassword));
            cmd.Parameters.AddWithValue("@permissionId", PermissionId);
            cmd.Parameters.AddWithValue("@userName", UserName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}