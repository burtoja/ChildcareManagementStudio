using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;

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
                            student.VaccinationRecordExpirationDate = reader.GetDateTime(vaccinationRecordExpirationDateOrdinal);
                            student.PhysicalExamExpirationDate = reader.GetDateTime(physicalExpirationDateOrdinal);

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
    }
}