using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing certification information from the child care database.
    /// </summary>
    public class CertificationDAL
    {
        /// <summary>
        /// Method that returns all of the certification records for a given employee.
        /// </summary>
        /// <param name="employeeId">Employee ID for the employee in question.</param>
        /// <returns>A list of all the certification records for the specified employee.</returns>
        public List<CertificationRecord> GetCertificationRecords(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            List<CertificationRecord> certificationRecords = new List<CertificationRecord>();

            string selectStatement =
                "SELECT type, expirationDate " +
                "FROM Certification " +
                "WHERE employeeId = $employeeId " +
                "ORDER BY expirationDate";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int typeOrdinal = reader.GetOrdinal("type");
                        int expirationDateOrdinal = reader.GetOrdinal("expirationDate");
                        while (reader.Read())
                        {
                            string type = reader.GetString(typeOrdinal);
                            DateTime expirationDate = reader.GetDateTime(expirationDateOrdinal);
                            CertificationRecord currentCertificationRecord = new CertificationRecord
                            {
                                Type = type,
                                ExpirationDate = expirationDate
                            };
                            certificationRecords.Add(currentCertificationRecord);
                        }
                    }
                }
            }

            return certificationRecords;
        }
    }
}