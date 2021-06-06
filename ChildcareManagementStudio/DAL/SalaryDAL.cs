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
    }
}