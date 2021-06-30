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
        private readonly ClassRecordDAL classRecordDAL;
        private readonly EmployeeDAL employeeDAL;

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
                "SELECT tca.teacherId " +
                "FROM TeacherClassroomAssignment tca " +
                "JOIN Employee e ON tca.teacherId = e.employeeId " +
                "JOIN Person p ON e.personId = p.personId " +
                "WHERE tca.class = $class " +
                "ORDER BY p.lastName, p.firstName";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$class", classId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int teacherIdOrdinal = reader.GetOrdinal("teacherId");
                        while (reader.Read())
                        {
                            int teacherId = reader.GetInt32(teacherIdOrdinal);
                            Employee teacher = employeeDAL.GetEmployee(teacherId);

                            TeacherClassroomAssignment teacherClassroomAssignment = new TeacherClassroomAssignment
                            {
                                ClassRecord = classRecord,
                                Teacher = teacher
                            };

                            teacherClassroomAssignments.Add(teacherClassroomAssignment);
                        }
                    }
                }
            }

            return teacherClassroomAssignments;
        }

        /// <summary>
        /// Method that adds a teacher/classroom assignment to the database.
        /// </summary>
        /// <param name="teacherClassroomAssignment">An object representing the teacher/classroom assignment being added.</param>
        public void AddTeacherClassroomAssignment(TeacherClassroomAssignment teacherClassroomAssignment)
        {
            if (teacherClassroomAssignment == null)
            {
                throw new ArgumentNullException("teacherClassroomAssignment", "The TeacherClassroomAssignment object cannot be null.");
            }

            string insertStatement =
                "INSERT INTO TeacherClassroomAssignment (teacherId, class) " +
                "VALUES ($teacherId, $class)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$teacherId", teacherClassroomAssignment.Teacher.EmployeeId);
                    insertCommand.Parameters.AddWithValue("$class", teacherClassroomAssignment.ClassRecord.ClassId);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        // TODO: delete this temporary method (it is only used to clean up temporary test additions)
        public void DeleteTeacherClassroomAssignment(TeacherClassroomAssignment teacherClassroomAssignment)
        {
            string deleteStatement =
                "DELETE FROM TeacherClassroomAssignment " +
                "WHERE teacherId = $teacherId " +
                "AND class = $classId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand deleteCommand = new SqliteCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("$teacherId", teacherClassroomAssignment.Teacher.EmployeeId);
                    deleteCommand.Parameters.AddWithValue("$classId", teacherClassroomAssignment.ClassRecord.ClassId);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }
    }
}