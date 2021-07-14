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
                "SELECT sca.studentId " +
                "FROM StudentClassroomAssignment sca " +
                "JOIN Student s ON sca.studentId = s.studentId " +
                "JOIN Person p ON s.personId = p.personId " +
                "WHERE sca.class = $classId " +
                "ORDER BY p.lastName, p.firstName";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$classId", classId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        //if (!reader.HasRows)
                        //{
                        //    throw new ArgumentException("The specified student/classroom assignment is not in the database.");
                        //}

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

        /// <summary>
        /// Method that returns a list of students that are not currently enrolled in a class for the specified school year.
        /// </summary>
        /// <param name="schoolYear">The school year being specified.</param>
        /// <returns>A list of students that are not currently enrolled in a class for the specified school year.</returns>
        public List<Student> GetAvailableStudents(string schoolYear)
        {
            List<Student> students = new List<Student>();

            string selectStatement =
                "SELECT s.studentId " +
                "FROM Student s " +
                "JOIN Person p ON s.personId = p.personId " +
                "WHERE NOT EXISTS (" +
                    "SELECT * " +
                    "FROM StudentClassroomAssignment sca " +
                    "JOIN Class c ON sca.class = c.classId " +
                    "WHERE sca.studentId = s.studentId " +
                    "AND c.schoolYear = $schoolYear) " +
                "ORDER BY p.lastName, p.firstName";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$schoolYear", schoolYear);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int studentIdOrdinal = reader.GetOrdinal("studentId");
                        while (reader.Read())
                        {
                            int studentId = reader.GetInt32(studentIdOrdinal);
                            Student student = studentDAL.GetStudent(studentId);

                            students.Add(student);
                        }
                    }
                }
            }

            return students;
        }

        /// <summary>
        /// Method that adds a student/classroom assignment to the database.
        /// </summary>
        /// <param name="studentClassroomAssignment">An object representing the student/classroom assignment being added.</param>
        public void AddStudentClassroomAssignment(StudentClassroomAssignment studentClassroomAssignment)
        {
            if (studentClassroomAssignment == null)
            {
                throw new ArgumentNullException("studentClassroomAssignment", "The StudentClassroomAssignment object cannot be null.");
            }
            int studentCount = this.GetStudentsInClass(studentClassroomAssignment.ClassRecord.ClassId).Count;
            if (studentCount >= studentClassroomAssignment.ClassRecord.Classroom.Capacity)
            {
                throw new InvalidOperationException("No students can be added. The classroom is at maximum capacity.");
            }

            string insertStatement =
                "INSERT INTO StudentClassroomAssignment (studentId, class) " +
                "VALUES ($studentId, $class)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$studentId", studentClassroomAssignment.Student.StudentId);
                    insertCommand.Parameters.AddWithValue("$class", studentClassroomAssignment.ClassRecord.ClassId);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Method that deletes a student/classroom assignment.
        /// </summary>
        /// <param name="studentClassroomAssignment">The student/classroom assignment being deleted.</param>
        public void DeleteStudentClassroomAssignment(StudentClassroomAssignment studentClassroomAssignment)
        {
            if (studentClassroomAssignment == null)
            {
                throw new ArgumentNullException("studentClassroomAssignment", "The StudentClassroomAssignment object cannot be null.");
            }

            string deleteStatement =
                "DELETE FROM StudentClassroomAssignment " +
                "WHERE studentId = $studentId " +
                "AND class = $classId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand deleteCommand = new SqliteCommand(deleteStatement, connection))
                {
                    deleteCommand.Parameters.AddWithValue("$studentId", studentClassroomAssignment.Student.StudentId);
                    deleteCommand.Parameters.AddWithValue("$classId", studentClassroomAssignment.ClassRecord.ClassId);
                    deleteCommand.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Examines a list of ClassRecord objects and determines the size of the largest class.
        /// </summary>
        /// <param name="">list of ClassRecord objects to examine</param>
        /// <returns>the size of the largest class in the list (0 if no classes in list)</returns>
        public int FindLargestClassSizeInList(List<ClassRecord> classList)
        {
            if (classList == null)
            {
                throw new ArgumentNullException("classList", "The list of class records cannot be null");
            }
            if (classList.Count == 0)
            {
                return 0;
            }

            int largestClassSize = 0;

            string selectStatement =
                "SELECT COUNT() AS classSize " +
                "FROM StudentClassroomAssignment " +
                "WHERE class = $classId " +
                "GROUP BY class";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                foreach (ClassRecord current in classList)
                {
                    using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                    {                                       
                        selectCommand.Parameters.AddWithValue("$classId", current.ClassId);
                        using (SqliteDataReader reader = selectCommand.ExecuteReader())
                        {
                            int classSizeOrdinal = reader.GetOrdinal("classSize");
                            while (reader.Read())
                            {
                                int currentClassSize = reader.GetInt32(classSizeOrdinal);
                                if (currentClassSize > largestClassSize)
                                {
                                    largestClassSize = currentClassSize;
                                }
                            }
                        }
                    }                 
                }
            }
            return largestClassSize;
        }

    }
}