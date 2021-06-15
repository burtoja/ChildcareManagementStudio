using Microsoft.Data.Sqlite;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing school year information from the child care database.
    /// </summary>
    public class SchoolYearDAL
    {
        /// <summary>
        /// Method that returns all of the school years in the database.
        /// </summary>
        /// <returns>All of the school years in the database.</returns>
        public List<string> GetAllSchoolYears()
        {
            List<string> schoolYears = new List<string>();

            string selectStatement =
                "SELECT schoolYear " +
                "FROM SchoolYear";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int schoolYearOrdinal = reader.GetOrdinal("schoolYear");
                        while (reader.Read())
                        {
                            string currentSchoolYear = reader.GetString(schoolYearOrdinal);
                            schoolYears.Add(currentSchoolYear);
                        }
                    }
                }
            }

            return schoolYears;
        }
    }
}