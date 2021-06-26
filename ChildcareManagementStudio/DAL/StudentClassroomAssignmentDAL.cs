using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing student/classroom assignments from the database.
    /// </summary>
    public class StudentClassroomAssignmentDAL
    {
        private readonly ClassRecordDAL classRecordDAL;
        private readonly StudentDAL studentDAL;

        /// <summary>
        /// Constructor for the StudentClassroomAssignmentDAL class.
        /// </summary>
        public StudentClassroomAssignmentDAL()
        {
            classRecordDAL = new ClassRecordDAL();
            studentDAL = new StudentDAL();
        }

        /// <summary>
        /// Method that returns a list of all the StudentClassroomAssignment objects associated with a specific class record (classroom + school year).
        /// </summary>
        /// <param name="classId">The unique ID of the class being requested.</param>
        /// <returns>A list of all the StudentClassroomAssignment objects associated with a specific class record.</returns>
        public List<StudentClassroomAssignment> GetStudentsInClass(int classId)
        {
            List<StudentClassroomAssignment> studentClassroomAssignments = new List<StudentClassroomAssignment>();

            ClassRecord classRecord = classRecordDAL.GetClassRecord(classId);

            string selectStatement =
                "SELECT studentId " +
                "FROM StudentClassroomAssignment " +
                "WHERE class = $classId";

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
                            throw new ArgumentException("The specified student/classroom assignment is not in the database.");
                        }

                        int studentIdOrdinal = reader.GetOrdinal("studentId");
                        while (reader.Read())
                        {
                            int studentId = reader.GetInt32(studentIdOrdinal);
                            Student student = studentDAL.GetStudent(studentId);

                            StudentClassroomAssignment studentClassroomAssignment = new StudentClassroomAssignment
                            {
                                ClassRecord = classRecord,
                                Student = student
                            };

                            studentClassroomAssignments.Add(studentClassroomAssignment);
                        }
                    }
                }
            }

            return studentClassroomAssignments;
        }
    }
}