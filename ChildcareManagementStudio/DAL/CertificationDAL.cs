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

        /// <summary>
        /// Method that adds a certification record to the database.
        /// </summary>
        /// <param name="employeeId">The employee ID of the employee that the record is associated with.</param>
        /// <param name="certificationRecord">A CertificationRecord object that contains the details of the certification record.</param>
        public void AddCertificationRecord(int employeeId, CertificationRecord certificationRecord)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            if (certificationRecord == null)
            {
                throw new ArgumentNullException("certificationRecord", "The certification record cannot be null.");
            }

            string insertStatement =
                "INSERT INTO Certification (employeeId, type, expirationDate) " +
                "VALUES ($employeeId, $type, $expirationDate)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    insertCommand.Parameters.AddWithValue("$type", certificationRecord.Type);
                    insertCommand.Parameters.AddWithValue("$expirationDate", certificationRecord.ExpirationDate.ToString("yyyy-MM-dd"));
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        // TODO: delete this temporary method (it is only used to clean up temporary test additions)
        public void DeleteCertificationRecord(int employeeId, CertificationRecord certificationRecord)
        {
            string deleteStatement =
                "DELETE FROM Certification " +
                "WHERE employeeId = $employeeId " +
                "AND type = $type " +
                "AND expirationDate = $expirationDate";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand deleteCommand = new SqliteCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    deleteCommand.Parameters.AddWithValue("$type", certificationRecord.Type);
                    deleteCommand.Parameters.AddWithValue("$expirationDate", certificationRecord.ExpirationDate.ToString("yyyy-MM-dd"));
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}