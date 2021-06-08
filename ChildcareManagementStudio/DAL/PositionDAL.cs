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
    }
}