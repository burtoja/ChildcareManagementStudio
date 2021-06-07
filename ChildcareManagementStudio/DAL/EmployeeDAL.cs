using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;

namespace ChildcareManagementStudio.DAL
{
    /// <summary>
    /// Class for accessing employee information from the child care database.
    /// </summary>
    public class EmployeeDAL : PersonDAL
    {
        private readonly SalaryDAL salaryDAL;
        private readonly CertificationDAL certificationDAL;
        private readonly PositionDAL positionDAL;

        /// <summary>
        /// Constructor for the EmployeeDAL class.
        /// </summary>
        public EmployeeDAL()
        {
            salaryDAL = new SalaryDAL();
            certificationDAL = new CertificationDAL();
            positionDAL = new PositionDAL();
        }

        /// <summary>
        /// Method that returns an Employee object for the specified person ID.
        /// </summary>
        /// <param name="personId">The person ID of the employee in question.</param>
        /// <returns>An Employee object for the specified employee.</returns>
        public Employee GetEmployee(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            Employee employee = new Employee();

            string selectStatement =
                "SELECT personId, startDate " +
                "FROM Employee " +
                "WHERE employeeId = $employeeId";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    selectCommand.Parameters.AddWithValue("$employeeId", employeeId);
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            throw new ArgumentException("The specified employee is not in the database.", "employeeId");
                        }

                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int startDateOrdinal = reader.GetOrdinal("startDate");
                        while (reader.Read())
                        {
                            employee.EmployeeId = employeeId;

                            employee.PersonId = reader.GetInt32(personIdOrdinal);
                            employee.StartDate = reader.GetDateTime(startDateOrdinal);

                            Person person = GetPerson(employee.PersonId);
                            employee.LastName = person.LastName;
                            employee.FirstName = person.FirstName;
                            employee.DateOfBirth = person.DateOfBirth;
                            employee.SocialSecurityNumber = person.SocialSecurityNumber;
                            employee.Gender = person.Gender;
                            employee.PhoneNumber = person.PhoneNumber;
                            employee.AddressLine1 = person.AddressLine1;
                            if (person.AddressLine2 != default) { employee.AddressLine2 = person.AddressLine2; }
                            employee.City = person.City;
                            employee.State = person.State;
                            employee.ZipCode = person.ZipCode;

                            employee.SalaryRecords = salaryDAL.GetSalaryRecords(employee.EmployeeId);
                            employee.CertificationRecords = certificationDAL.GetCertificationRecords(employee.EmployeeId);
                            employee.PositionRecords = positionDAL.GetPositionRecords(employee.EmployeeId);
                        }
                    }
                }
            }

            return employee;
        }
    }
}