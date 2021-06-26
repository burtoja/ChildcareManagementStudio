using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing student information from the child care database.
    /// </summary>
    public class StudentDAL : PersonDAL
    {
        /// <summary>
        /// Method that returns a Student object for the specified student ID.
        /// </summary>
        /// <param name="studentId">The student ID of the student in question.</param>
        /// <returns>A Student object for the specified student.</returns>
        public Student GetStudent(int studentId)
        {
            if (studentId < 0)
            {
                throw new ArgumentException("The student ID cannot be a negative number.", "studentId");
            }

            Student student = new Student();

            string selectStatement =
                "SELECT personId, vaccinationRecordExpirationDate, physicalExpirationDate " +
                "FROM Student " +
                "WHERE studentId = $studentId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$studentId", studentId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            throw new ArgumentException("The specified student is not in the database.", "studentId");
                        }

                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int vaccinationRecordExpirationDateOrdinal = reader.GetOrdinal("vaccinationRecordExpirationDate");
                        int physicalExpirationDateOrdinal = reader.GetOrdinal("physicalExpirationDate");
                        while (reader.Read())
                        {
                            student.StudentId = studentId;

                            student.PersonId = reader.GetInt32(personIdOrdinal);

                            if (!reader.IsDBNull(vaccinationRecordExpirationDateOrdinal))
                            {
                                student.VaccinationRecordExpirationDate = reader.GetDateTime(vaccinationRecordExpirationDateOrdinal);
                            }

                            if (!reader.IsDBNull(physicalExpirationDateOrdinal))
                            {
                                student.PhysicalExamExpirationDate = reader.GetDateTime(physicalExpirationDateOrdinal);
                            }

                            Person person = GetPerson(student.PersonId);
                            student.LastName = person.LastName;
                            student.FirstName = person.FirstName;
                            student.DateOfBirth = person.DateOfBirth;
                            student.SocialSecurityNumber = person.SocialSecurityNumber;
                            student.Gender = person.Gender;
                            student.PhoneNumber = person.PhoneNumber;
                            student.AddressLine1 = person.AddressLine1;
                            if (person.AddressLine2 != default) { student.AddressLine2 = person.AddressLine2; }
                            student.City = person.City;
                            student.State = person.State;
                            student.ZipCode = person.ZipCode;
                        }
                    }
                }
            }

            return student;
        }

        /// <summary>
        /// Method that returns Student objects for all of the studentsin the database.
        /// </summary>
        /// <returns>A list of Student objects for all of the students in the database.</returns>
        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            string selectStatement =
                "SELECT personId, studentId " +
                "FROM Student s " +
                "JOIN Person p ON s.personId = p.personId " +
                "ORDER BY p.lastName, p.firstName";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int studnetIdOrdinal = reader.GetOrdinal("studentId");
                        while (reader.Read())
                        {
                            Student student = new Student
                            {
                                PersonId = reader.GetInt32(personIdOrdinal),
                                StudentId = reader.GetInt32(studnetIdOrdinal)
                            };

                            Person person = GetPerson(student.PersonId);
                            student.LastName = person.LastName;
                            student.FirstName = person.FirstName;
                            student.DateOfBirth = person.DateOfBirth;
                            student.SocialSecurityNumber = person.SocialSecurityNumber;
                            student.Gender = person.Gender;
                            student.PhoneNumber = person.PhoneNumber;
                            student.AddressLine1 = person.AddressLine1;
                            if (person.AddressLine2 != default) { student.AddressLine2 = person.AddressLine2; }
                            student.City = person.City;
                            student.State = person.State;
                            student.ZipCode = person.ZipCode;

                            students.Add(student);
                        }
                    }
                }
            }
            return students;
        }

        /// <summary>
        /// Method that adds the specified student to the database.
        /// </summary>
        /// <param name="student">
        /// Student object representing the student to add.
        /// The Student object cannot have a value for the StudentId property, since this will be assigned by the database.
        /// </param>
        public void AddStudent(Student student)
        {
            if (student.StudentId != default)
            {
                throw new ArgumentException("The StudentId property cannot be filled out because it will be assigned by the database.", "employee");
            }

            // TODO: Add validation for list properties (vaccination records, physical records, etc.)

            // TODO: wrap the table updates in a transaction

            AddPerson(student);

            string insertStatement =
                "INSERT INTO Student (personId) " +
                "VALUES ($personId)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$personId", student.PersonId);
                    insertCommand.ExecuteNonQuery();
                }

                using (SqliteCommand selectCommand = new SqliteCommand("SELECT last_insert_rowid()", connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            student.StudentId = reader.GetInt32(0);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Method that edits an student's records in the database.
        /// </summary>
        /// <param name="originalStudent">Student object representing the student's records before the edits are made.</param>
        /// <param name="revisedStudent">Student object representing the student's records after the edits are made.</param>
        public void EditStudent(Student originalStudent, Student revisedStudent)
        {
            if (originalStudent == null)
            {
                throw new ArgumentNullException("originalStudent", "The original student cannot be null.");
            }

            if (revisedStudent == null)
            {
                throw new ArgumentNullException("revisedStudent", "The revised student cannot be null.");
            }

            if (originalStudent.StudentId != revisedStudent.StudentId)
            {
                throw new ArgumentException("The student ID must be the same for both Student objects.");
            }

            // TODO: wrap both table updates in a transaction

            EditPerson(originalStudent, revisedStudent);

            string updateStatementVaccinationWhere;
            if (originalStudent.VaccinationRecordExpirationDate == default)
                updateStatementVaccinationWhere = "vaccinationRecordExpirationDate IS NULL ";
            else 
                updateStatementVaccinationWhere = "vaccinationRecordExpirationDate = $originalVaccinationRecordExpirationDate ";

            string updateStatementPhysicalWhere;
            if (originalStudent.PhysicalExamExpirationDate == default) 
                updateStatementPhysicalWhere = "physicalExpirationDate IS NULL";
            else
                updateStatementPhysicalWhere = "physicalExpirationDate = $originalPhysicalExpirationDate";

            string updateStatement =
                "UPDATE Student SET " +
                    "vaccinationRecordExpirationDate = $revisedVaccinationRecordExpirationDate, " +
                    "physicalExpirationDate = $revisedPhysicalExpirationDate " +
                "WHERE studentId = $studentId " +
                    "AND personId = $personId " +
                    "AND " + updateStatementVaccinationWhere +
                    "AND " + updateStatementPhysicalWhere;

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand updateCommand = new SqliteCommand(updateStatement, connection))
                {
                    updateCommand.Parameters.AddWithValue("$studentId", originalStudent.StudentId);
                    updateCommand.Parameters.AddWithValue("$personId", originalStudent.PersonId);

                    if (originalStudent.VaccinationRecordExpirationDate != default)
                        updateCommand.Parameters.AddWithValue("$originalVaccinationRecordExpirationDate", originalStudent.VaccinationRecordExpirationDate.ToString("yyyy-MM-dd"));

                    if (originalStudent.PhysicalExamExpirationDate != default)
                        updateCommand.Parameters.AddWithValue("$originalPhysicalExpirationDate", originalStudent.PhysicalExamExpirationDate.ToString("yyyy-MM-dd"));


                    if (revisedStudent.VaccinationRecordExpirationDate == default)
                        updateCommand.Parameters.AddWithValue("$revisedVaccinationRecordExpirationDate", DBNull.Value);
                    else
                        updateCommand.Parameters.AddWithValue("$revisedVaccinationRecordExpirationDate", revisedStudent.VaccinationRecordExpirationDate.ToString("yyyy-MM-dd"));

                    if (revisedStudent.PhysicalExamExpirationDate == default)
                        updateCommand.Parameters.AddWithValue("$revisedPhysicalExpirationDate", DBNull.Value);
                    else
                        updateCommand.Parameters.AddWithValue("$revisedPhysicalExpirationDate", revisedStudent.PhysicalExamExpirationDate.ToString("yyyy-MM-dd"));
                   
                    updateCommand.ExecuteNonQuery();
                }
            }
        }
    }
}