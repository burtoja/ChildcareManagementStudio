using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing teacher/classroom assignments from the database.
    /// </summary>
    public class TeacherClassroomAssignmentDAL
    {
        private ClassRecordDAL classRecordDAL;
        private EmployeeDAL employeeDAL;

        /// <summary>
        /// Constructor for the TeacherClassroomAssignmentDAL class.
        /// </summary>
        public TeacherClassroomAssignmentDAL()
        {
            classRecordDAL = new ClassRecordDAL();
            employeeDAL = new EmployeeDAL();
        }

        /// <summary>
        /// Method that gets all teacher/classroom assignments for a given school year and classroom.
        /// </summary>
        /// <param name="classId">Class ID being requested.</param>
        /// <returns>All teacher/classroom assignments for the requested school year and classroom.</returns>
        public List<TeacherClassroomAssignment> GetTeacherClassroomAssignments(int classId)
        {
            List<TeacherClassroomAssignment> teacherClassroomAssignments = new List<TeacherClassroomAssignment>();

            ClassRecord classRecord = classRecordDAL.GetClassRecord(classId);

            string selectStatement =
                "SELECT teacherId, startDate, positionType " +
                "FROM TeacherClassroomAssignment " +
                "WHERE class = $class";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$class", classId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            throw new ArgumentException("The specified teacher/classroom assignment is not in the database.");
                        }

                        int teacherIdOrdinal = reader.GetOrdinal("teacherId");
                        int startDateOrdinal = reader.GetOrdinal("startDate");
                        int positionTypeOrdinal = reader.GetOrdinal("positionType");
                        while (reader.Read())
                        {
                            int teacherId = reader.GetInt32(teacherIdOrdinal);
                            Employee teacher = employeeDAL.GetEmployee(teacherId);

                            TeacherClassroomAssignment teacherClassroomAssignment = new TeacherClassroomAssignment
                            {
                                ClassRecord = classRecord,
                                StartDate = reader.GetDateTime(startDateOrdinal),
                                Teacher = teacher,
                                PositionType = reader.GetString(positionTypeOrdinal)
                            };

                            teacherClassroomAssignments.Add(teacherClassroomAssignment);
                        }
                    }
                }
            }

            return teacherClassroomAssignments;
        }
    }
}