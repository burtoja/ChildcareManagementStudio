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
        private ClassroomDAL classroomDAL;
        private EmployeeDAL employeeDAL;

        /// <summary>
        /// Constructor for the TeacherClassroomAssignmentDAL class.
        /// </summary>
        public TeacherClassroomAssignmentDAL()
        {
            classroomDAL = new ClassroomDAL();
            employeeDAL = new EmployeeDAL();
        }

        /// <summary>
        /// Method that gets all teacher/classroom assignments for a given school year and classroom.
        /// </summary>
        /// <param name="schoolYear">School year being requested.</param>
        /// <param name="classroomLocation">Classroom location being requested.</param>
        /// <returns>All teacher/classroom assignments for the requested school year and classroom.</returns>
        public List<TeacherClassroomAssignment> GetTeacherClassroomAssignments(string schoolYear, string classroomLocation)
        {
            if (string.IsNullOrEmpty(schoolYear))
            {
                throw new ArgumentNullException("schoolYear", "The school year cannot be null or empty.");
            }

            if (string.IsNullOrEmpty(classroomLocation))
            {
                throw new ArgumentNullException("classroomLocation", "The classroom location cannot be null or empty.");
            }

            List<TeacherClassroomAssignment> teacherClassroomAssignments = new List<TeacherClassroomAssignment>();

            Classroom classroom = classroomDAL.GetClassroom(classroomLocation);

            string selectStatement =
                "SELECT teacherId, startDate, positionType " +
                "FROM TeacherClassroomAssignment " +
                "WHERE schoolYear = $schoolYear " +
                "AND classroomLocation = $classroomLocation";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$schoolYear", schoolYear);
                    selectCommand.Parameters.AddWithValue("$classroomLocation", classroomLocation);
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
                                SchoolYear = schoolYear,
                                Classroom = classroom,
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