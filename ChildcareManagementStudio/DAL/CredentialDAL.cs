using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.Sqlite;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing credential information from the child care database.
    /// </summary>
    public class CredentialDAL
    {
        /// <summary>
        /// Method for checking if the specified credentials are valid.
        /// </summary>
        /// <param name="username">The username being checked.</param>
        /// <param name="passwordHash">The sha256 password hash being checked.</param>
        /// <returns>True if the specified credentials are valid.  False if the specified credentials are invalid.</returns>
        public bool CredentialsAreValid(string username, string passwordHash)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("username", "The username cannot be null or empty.");
            }

            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(""));
                string emptyStringHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

                if (passwordHash == emptyStringHash)
                {
                    throw new ArgumentNullException("password", "The password cannot be null or empty.");
                }
            }

            string selectStatement =
                "SELECT username " +
                "FROM Credential " +
                "WHERE username = $username " +
                "AND password = $passwordHash";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$username", username);
                    selectCommand.Parameters.AddWithValue("$passwordHash", passwordHash);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }
    }
}