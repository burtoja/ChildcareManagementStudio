using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing classroom information from the child care database.
    /// </summary>
    public class ClassroomDAL
    {
        /// <summary>
        /// Method that returns a Classroom object representing the requested classroom.
        /// </summary>
        /// <param name="location">Location of the classroom being requested.</param>
        /// <returns>A Classroom object representing the requested classroom.</returns>
        public Classroom GetClassroom(string location)
        {
            if (string.IsNullOrEmpty(location))
            {
                throw new ArgumentNullException("location", "The classroom location cannot be null.");
            }

            Classroom classroom = new Classroom();

            string selectStatement =
                "SELECT capacity " +
                "FROM Classroom " +
                "WHERE location = $location";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$location", location);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            throw new ArgumentException("The specified classroom is not in the database.", "location");
                        }

                        int capacityOrdinal = reader.GetOrdinal("capacity");
                        while (reader.Read())
                        {
                            classroom.Location = location;
                            classroom.Capacity = reader.GetInt32(capacityOrdinal);
                        }
                    }
                }
            }

            return classroom;
        }
    }
}