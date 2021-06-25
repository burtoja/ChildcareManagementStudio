using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;

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
                "SELECT classroomLocation, schoolYear " +
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

                        int classroomLocationOrdinal = reader.GetOrdinal("classroomLocation");
                        int schoolYearOrdinal = reader.GetOrdinal("schoolYear");
                        while (reader.Read())
                        {
                            string classroomLocation = reader.GetString(classroomLocationOrdinal);
                            Classroom classroom = classroomDAL.GetClassroom(classroomLocation);

                            classRecord.ClassId = classId;
                            classRecord.Classroom = classroom;
                            classRecord.SchoolYear = reader.GetString(schoolYearOrdinal);
                        }
                    }
                }
            }

            return classRecord;
        }
    }
}