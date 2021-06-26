using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing class information from the child care database.
    /// </summary>
    public class ClassRecordDAL
    {
        private readonly ClassroomDAL classroomDAL;
        
        /// <summary>
        /// Constructor for the ClassRecordDAL class.
        /// </summary>
        public ClassRecordDAL()
        {
            classroomDAL = new ClassroomDAL();
        }

        /// <summary>
        /// Method that gets the requested class record.
        /// </summary>
        /// <param name="classId">Unique ID of the class record.</param>
        /// <returns>A ClassRecord object representing the requested class record.</returns>
        public ClassRecord GetClassRecord(int classId)
        {
            ClassRecord classRecord = new ClassRecord();

            string selectStatement =
                "SELECT classroomId, schoolYear " +
                "FROM Class " +
                "WHERE classId = $classId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$classId", classId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            throw new ArgumentException("The specified class is not in the database.", "classId");
                        }

                        int classroomIdOrdinal = reader.GetOrdinal("classroomId");
                        int schoolYearOrdinal = reader.GetOrdinal("schoolYear");
                        while (reader.Read())
                        {
                            int classroomId = reader.GetInt32(classroomIdOrdinal);
                            Classroom classroom = classroomDAL.GetClassroom(classroomId);

                            classRecord.ClassId = classId;
                            classRecord.Classroom = classroom;
                            classRecord.SchoolYear = reader.GetString(schoolYearOrdinal);
                        }
                    }
                }
            }

            return classRecord;
        }

        /// <summary>
        /// Returns a list of Class objects matching the provided school year
        /// </summary>
        /// <param name="schoolYear">the school year for which to return a list of Class objects</param>
        /// <returns></returns>
        public List<ClassRecord> GetAllClassesForSchoolYear(string schoolYear)
        {
            List<ClassRecord> classrooms = new List<ClassRecord>();

            string selectStatement =
                "SELECT classId, classroomId, schoolYear " +
                "FROM Class";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int classIdOrdinal = reader.GetOrdinal("classId");
                        int classroomIdOrdinal = reader.GetOrdinal("classroomId");
                        int schoolYearOrdinal = reader.GetOrdinal("schoolYear");
                        while (reader.Read())
                        {
                            ClassRecord classRecord = new ClassRecord
                            {
                                ClassId = reader.GetInt32(classIdOrdinal),
                                Classroom = this.classroomDAL.GetClassroom(reader.GetInt32(classroomIdOrdinal)),
                                SchoolYear = reader.GetString(schoolYearOrdinal)
                            };
                            classrooms.Add(classRecord);
                        }
                    }
                }
            }
            return classrooms;
        }

        /// <summary>
        /// Adds a new ClassRecord to the db
        /// </summary>
        /// <param name="classRecord"></param>
        public void AddClassRecord(ClassRecord classRecord)
        {
            if (classRecord == null)
            {
                throw new ArgumentNullException("classRecord", "The ClassRecord cannot be null.");
            }

            string insertStatement =
                "INSERT INTO ClassRecord (classroomId, schoolYear) " +
                "VALUES ($classroomId, $schoolYear)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$classroomId", classRecord.Classroom.Id);
                    insertCommand.Parameters.AddWithValue("$schoolYear", classRecord.SchoolYear);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

    }
}