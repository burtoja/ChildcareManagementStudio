using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing position information from the child care database.
    /// </summary>
    public class PositionDAL
    {
        /// <summary>
        /// Method that returns all of the position records for a given employee.
        /// </summary>
        /// <param name="employeeId">Employee ID for the employee in question.</param>
        /// <returns>A list of all the position records for the specified employee.</returns>
        public List<PositionRecord> GetPositionRecords(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            List<PositionRecord> positionRecords = new List<PositionRecord>();

            string selectStatement =
                "SELECT type, schoolYear " +
                "FROM Position " +
                "WHERE employeeId = $employeeId " +
                "ORDER BY schoolYear";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int typeOrdinal = reader.GetOrdinal("type");
                        int schoolYearOrdinal = reader.GetOrdinal("schoolYear");
                        while (reader.Read())
                        {
                            string type = reader.GetString(typeOrdinal);
                            string schoolYear = reader.GetString(schoolYearOrdinal);
                            PositionRecord currentPositionRecord = new PositionRecord
                            {
                                Type = type,
                                SchoolYear = schoolYear
                            };
                            positionRecords.Add(currentPositionRecord);
                        }
                    }
                }
            }

            return positionRecords;
        }

        /// <summary>
        /// Method that adds a position record to the database.
        /// </summary>
        /// <param name="employeeId">The employee ID of the employee that the record is associated with.</param>
        /// <param name="positionRecord">A PositionRecord object containing the record details.</param>
        public void AddPositionRecord(int employeeId, PositionRecord positionRecord)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            if (positionRecord == null)
            {
                throw new ArgumentNullException("positionRecord", "The position record cannot be null.");
            }

            string insertStatement =
                "INSERT INTO Position (employeeId, startDate, type, schoolYear) " +
                "VALUES ($employeeId, $startDate, $type, $schoolYear)";
            

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    insertCommand.Parameters.AddWithValue("$startDate", positionRecord.StartDate.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("$type", positionRecord.Type);
                    insertCommand.Parameters.AddWithValue("$schoolYear", positionRecord.SchoolYear);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        // TODO: delete this temporary method (it is only used to clean up temporary test additions)
        public void DeletePositionRecord(int employeeId, PositionRecord positionRecord)
        {
            string deleteStatement =
                "DELETE FROM Position " +
                "WHERE employeeId = $employeeId " +
                "AND startDate = $startDate";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand deleteCommand = new SqliteCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    deleteCommand.Parameters.AddWithValue("$startDate", positionRecord.StartDate.ToString("yyyy-MM-dd"));
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}