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
                "FROM Class " +
                "WHERE schoolYear = $schoolYear";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$schoolYear", schoolYear);
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
                "INSERT INTO Class (classroomId, schoolYear) " +
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

        /// <summary>
        /// Edit the details of a Class
        /// </summary>
        /// <param name="originalClass">original Class object</param>
        /// <param name="revisedClass">revised Class object</param>
        public void EditClass(ClassRecord originalClass, ClassRecord revisedClass)
        {
            if (originalClass == null)
            {
                throw new ArgumentNullException("originalClass", "The original class cannot be null.");
            }

            if (revisedClass == null)
            {
                throw new ArgumentNullException("revisedClass", "The revised class cannot be null.");
            }

            if (originalClass.ClassId != revisedClass.ClassId)
            {
                throw new ArgumentException("The ID must be the same for both ClassRecord objects.");
            }

            string updateStatement =
                "UPDATE Class SET " +
                    "classroomId = $revisedClassroomId, " +
                    "schoolYear = $revisedSchoolYear " +
                "WHERE classId = $classId " +
                    "AND classroomId = $originalClassroomId " +
                    "AND schoolYear = $originalSchoolYear";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand updateCommand = new SqliteCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("$classId", originalClass.ClassId);
                    updateCommand.Parameters.AddWithValue("$originalClassroomId", originalClass.Classroom.Id);
                    updateCommand.Parameters.AddWithValue("$originalSchoolYear", originalClass.SchoolYear);
                    updateCommand.Parameters.AddWithValue("$revisedClassroomId", revisedClass.Classroom.Id);
                    updateCommand.Parameters.AddWithValue("$revisedSchoolYear", revisedClass.SchoolYear);

                    updateCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that returns the ID of a class for a given classroom and school year.
        /// </summary>
        /// <param name="classroomId">The classroom ID.</param>
        /// <param name="schoolYear">The school year.</param>
        /// <returns>The class ID.</returns>
        public int GetClassId(int classroomId, string schoolYear)
        {
            int classId;

            string selectStatement =
                "SELECT classId " +
                "FROM Class " +
                "WHERE classroomId = $classroomId " +
                "AND schoolYear = $schoolYear";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$classroomId", classroomId);
                    selectCommand.Parameters.AddWithValue("$schoolYear", schoolYear);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            throw new ArgumentException("The specified class is not in the database.");
                        }

                        int classIdOrdinal = reader.GetOrdinal("classId");
                        while (reader.Read())
                        {
                            classId = reader.GetInt32(classIdOrdinal);
                        }
                    }
                }
            }
            return classroomId;
        }

        /// <summary>
        /// Queries DB to get all ClassRecords with the location (Classroom) provided in the parameter
        /// </summary>
        /// <param name="classroom">Classroom object defining the search</param>
        /// <returns>List of ClassRecord objects matching the search</returns>
        public List<ClassRecord> GetClassRecordsForRoom(Classroom classroom)
        {
            if (classroom == null)
            {
                throw new ArgumentNullException("classroom", "The classroom cannot be null.");
            }

            List<ClassRecord> classrooms = new List<ClassRecord>();

            string selectStatement =
                "SELECT classId, schoolYear " +
                "FROM Class " +
                "WHERE classroomId = $classroomId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$classroomId", classroom.Id);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int classIdOrdinal = reader.GetOrdinal("classId");
                        int schoolYearOrdinal = reader.GetOrdinal("schoolYear");
                        while (reader.Read())
                        {
                            ClassRecord classRecord = new ClassRecord
                            {
                                ClassId = reader.GetInt32(classIdOrdinal),
                                Classroom = classroom,
                                SchoolYear = reader.GetString(schoolYearOrdinal)
                            };
                            classrooms.Add(classRecord);
                        }
                    }
                }
            }
            return classrooms;
        }
    }
}