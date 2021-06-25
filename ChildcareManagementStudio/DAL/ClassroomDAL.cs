using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

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
        /// <param name="classroomId">Unique ID of the classroom being requested.</param>
        /// <returns>A Classroom object representing the requested classroom.</returns>
        public Classroom GetClassroom(int classroomId)
        {
            Classroom classroom = new Classroom();

            string selectStatement =
                "SELECT location, capacity " +
                "FROM Classroom " +
                "WHERE classroomId = $classroomId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$classroomId", classroomId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            throw new ArgumentException("The specified classroom is not in the database.", "location");
                        }

                        int locationOrdinal = reader.GetOrdinal("location");
                        int capacityOrdinal = reader.GetOrdinal("capacity");
                        while (reader.Read())
                        {
                            classroom.Id = classroomId;
                            classroom.Location = reader.GetString(locationOrdinal);
                            classroom.Capacity = reader.GetInt32(capacityOrdinal);
                        }
                    }
                }
            }

            return classroom;
        }

        /// <summary>
        /// Method that returns Classroom objects for all of the classrooms in the database.
        /// </summary>
        /// <returns>A list of Classroom objects for all of the classrooms in the database.</returns>
        public List<Classroom> GetAllClassrooms()
        {
            List<Classroom> classrooms = new List<Classroom>();

            string selectStatement =
                "SELECT classroomId, location, capacity " +
                "FROM Classroom";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int idOrdinal = reader.GetOrdinal("classroomId");
                        int locationOrdinal = reader.GetOrdinal("location");
                        int capacityOrdinal = reader.GetOrdinal("capacity");
                        while (reader.Read())
                        {
                            Classroom classroom = new Classroom
                            {
                                Id = reader.GetInt32(idOrdinal),
                                Location = reader.GetString(locationOrdinal),
                                Capacity = reader.GetInt32(capacityOrdinal)
                            };

                            classrooms.Add(classroom);
                        }
                    }
                }
            }

            return classrooms;
        }

        /// <summary>
        /// Method that adds a classroom record to the database.
        /// </summary>
        /// <param name="theClassroom">The Classroom object holding the information to be added to the DB</param>
        public void CreateNewClassroom(Classroom theClassroom)
        {
            if (theClassroom == null)
            {
                throw new ArgumentNullException("theClassroom", "The classroom record cannot be null.");
            }

            string insertStatement =
                "INSERT INTO Classroom (Location, Capacity) " +
                "VALUES ($location, $capacity)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$location", theClassroom.Location);
                    insertCommand.Parameters.AddWithValue("$capacity", theClassroom.Capacity);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that edits an classrooms's records in the database.
        /// The method will throw an exception if any of the aforementioned records are different between the original and revised Classroom objects.
        /// </summary>
        /// <param name="originalClassroom">Classroom object representing the classrooms's records before the edits are made.</param>
        /// <param name="revisedClassroom">Classroom object representing the classrooms's records after the edits are made.</param>
        public void EditClassroom(Classroom originalClassroom, Classroom revisedClassroom)
        {
            if (originalClassroom == null)
            {
                throw new ArgumentNullException("originalClassroom", "The original classroom cannot be null.");
            }

            if (revisedClassroom == null)
            {
                throw new ArgumentNullException("revisedClassroom", "The revised classroom cannot be null.");
            }

            if (originalClassroom.Id != revisedClassroom.Id)
            {
                throw new ArgumentException("The ID must be the same for the two classrooms.");
            }

            // TODO: wrap both table updates in a transaction

            // TODO: propagate this change to other table entries as needed

            string updateStatement =
                "UPDATE Classroom SET " +
                    "location = $revisedLocation, " +
                    "capacity = $revisedCapacity " +
                "WHERE location = $originalLocation " +
                    "AND capacity = $originalCapacity";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand updateCommand = new SqliteCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("$originalLocation", originalClassroom.Location);
                    updateCommand.Parameters.AddWithValue("$originalCapacity", originalClassroom.Capacity);
                    updateCommand.Parameters.AddWithValue("$revisedLocation", revisedClassroom.Location);
                    updateCommand.Parameters.AddWithValue("$revisedCapacity", revisedClassroom.Capacity);
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

    }
}