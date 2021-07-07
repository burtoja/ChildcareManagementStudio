﻿using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing clock record information from the child care database.
    /// </summary>
    public class ClockRecordDAL
    {

        /// <summary>
        /// Returns a list of ClockRecord objects matching the provided employeeId
        /// </summary>
        /// <param name="employeeId">theemployeeId for which to return a list of ClockRecord objects</param>
        /// <returns></returns>
        public List<ClockRecord> GetAllClockRecordsForEmployee(int employeeId)
        {
            List<ClockRecord> records = new List<ClockRecord>();

            string selectStatement =
                "SELECT inDateTime, outDateTime " +
                "FROM ClockRecord " +
                "WHERE employeeId = $employeeId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int inDateTimeOrdinal = reader.GetOrdinal("inDateTime");
                        int outDateTimeOrdinal = reader.GetOrdinal("outDateTime");
                        while (reader.Read())
                        {
                            ClockRecord clockRecord = new ClockRecord
                            {
                                InDateTime = reader.GetDateTime(inDateTimeOrdinal),
                                OutDateTime = reader.GetDateTime(outDateTimeOrdinal)
                            };
                            records.Add(clockRecord);
                        }
                    }
                }
            }
            return records;
        }


        /// <summary>
        /// Adds a new ClockRecord entry into the DAL with the clocked-in date time for an employee
        /// </summary>
        /// <param name="clockRecord">the clock record object to insert into the DB</param>
        public void ClockIn(ClockRecord clockRecord)
        {
            if (clockRecord == null)
            {
                throw new ArgumentNullException("clockRecord", "The ClockRecord cannot be null.");
            }

            string insertStatement =
                "INSERT INTO ClockRecord (employeeId, inDateTime) " +
                "VALUES ($employeeId, $inDatetime)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$employeeId", clockRecord.EmployeeId);
                    insertCommand.Parameters.AddWithValue("$inDatetime", clockRecord.InDateTime);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Edit ClockRecord in DB to add OutDateTime
        /// </summary>
        /// <param name="clockInRecord">original ClockRecord object</param>
        /// <param name="clockOutRecord">revised ClockRecord object</param>
        public void ClockOut(ClockRecord clockInRecord, ClockRecord clockOutRecord)
        {
            if (clockInRecord == null)
            {
                throw new ArgumentNullException("clockInRecord", "The clock-in record cannot be null.");
            }

            if (clockOutRecord == null)
            {
                throw new ArgumentNullException("clockOutRecord", "The clock-out record cannot be null.");
            }

            if (clockInRecord.EmployeeId != clockOutRecord.EmployeeId)
            {
                throw new ArgumentException("The ID must be the same for both ClassRecord objects.");
            }

            if (clockInRecord.OutDateTime != null)
            {
                throw new ArgumentException("This record already has a clock-out time associated with it.");
            }

            string updateStatement =
                "UPDATE ClockRecord SET " +
                    "outDateTime = $outDatetime, " +
                "WHERE employeeId = $employeeId " +
                    "AND inDateTime = $inDateTime ";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand updateCommand = new SqliteCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("$employeeId", clockInRecord.EmployeeId);
                    updateCommand.Parameters.AddWithValue("$inDateTime", clockInRecord.InDateTime);
                    updateCommand.Parameters.AddWithValue("$outDatetime", clockOutRecord.OutDateTime);
                    
                    updateCommand.ExecuteNonQuery();
                }
            }
        }

    }
}