using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing salary information from the child care database.
    /// </summary>
    public class SalaryDAL
    {
        /// <summary>
        /// Method that returns all of the salary records for a given employee.
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public List<SalaryRecord> GetSalaryRecords(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            List<SalaryRecord> salaryRecords = new List<SalaryRecord>();

            string selectStatement =
                "SELECT effectiveDate, rate " +
                "FROM Salary " +
                "WHERE employeeId = $employeeId " +
                "ORDER BY effectiveDate";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int effectiveDateOrdinal = reader.GetOrdinal("effectiveDate");
                        int rateOrdinal = reader.GetOrdinal("rate");
                        while (reader.Read())
                        {
                            DateTime effectiveDate = reader.GetDateTime(effectiveDateOrdinal);
                            double rate = reader.GetDouble(rateOrdinal);
                            SalaryRecord currentSalaryRecord = new SalaryRecord
                            {
                                EffectiveDate = effectiveDate,
                                Rate = rate
                            };
                            salaryRecords.Add(currentSalaryRecord);
                        }
                    }
                }
            }

            return salaryRecords;
        }

        /// <summary>
        /// Method that adds a salary record to the database.
        /// </summary>
        /// <param name="employeeId">The employee ID for the employee that the record is associated with.</param>
        /// <param name="salaryRecord">A SalaryRecord object containing the details of the salary record.</param>
        public void AddSalaryRecord(int employeeId, SalaryRecord salaryRecord)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            if (salaryRecord == null)
            {
                throw new ArgumentNullException("salaryRecord", "The salary record cannot be null.");
            }

            string insertStatement =
                "INSERT INTO Salary (employeeId, effectiveDate, rate) " +
                "VALUES ($employeeId, $effectiveDate, $rate)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    insertCommand.Parameters.AddWithValue("$effectiveDate", salaryRecord.EffectiveDate.ToString("yyyy-MM-dd"));
                    insertCommand.Parameters.AddWithValue("$rate", salaryRecord.Rate);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        // TODO: delete this temporary method (it is only used to clean up temporary test additions)
        public void DeleteSalaryRecord(int employeeId, SalaryRecord salaryRecord)
        {
            string deleteStatement =
                "DELETE FROM Salary " +
                "WHERE employeeId = $employeeId " +
                "AND effectiveDate = $effectiveDate";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand deleteCommand = new SqliteCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    deleteCommand.Parameters.AddWithValue("$effectiveDate", salaryRecord.EffectiveDate.ToString("yyyy-MM-dd"));
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}