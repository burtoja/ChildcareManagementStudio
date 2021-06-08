using ChildcareManagementStudio.Model;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

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

        /// <summary>
        /// Method that returns Employee objects for all of the employees in the database.
        /// </summary>
        /// <returns>A list of Employee objects for all of the employees in the database.</returns>
        public List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();

            string selectStatement =
                "SELECT personId, employeeId, startDate " +
                "FROM Employee";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();
                using (SqliteCommand selectCommand = new SqliteCommand(selectStatement, connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        int personIdOrdinal = reader.GetOrdinal("personId");
                        int employeeIdOrdinal = reader.GetOrdinal("employeeId");
                        int startDateOrdinal = reader.GetOrdinal("startDate");
                        while (reader.Read())
                        {
                            Employee employee = new Employee
                            {
                                PersonId = reader.GetInt32(personIdOrdinal),
                                EmployeeId = reader.GetInt32(employeeIdOrdinal),
                                StartDate = reader.GetDateTime(startDateOrdinal)
                            };

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

                            employees.Add(employee);
                        }
                    }
                }
            }

            return employees;
        }

        /// <summary>
        /// Method that adds the specified employee to the database.
        /// </summary>
        /// <param name="employee">
        /// Employee object representing the employee to add.
        /// The Employee object cannot have a value for the EmployeeId property, since this will be assigned by the database.
        /// Additionally, the Employee object must have a value for the StartDate property.
        /// Finally, the Employee object cannot have values for any of the list properties (SalaryRecords, CertificationRecords, and PositionRecords).
        /// To add records for any of the list properties, use the appropriate method specific to that type of record.
        /// </param>
        public void AddEmployee(Employee employee)
        {
            if (employee.StartDate == default)
            {
                throw new ArgumentException("The Employee object must have a value for the StartDate property.", "employee");
            }

            if (employee.EmployeeId != default)
            {
                throw new ArgumentException("The EmployeeId property cannot be filled out because it will be assigned by the database.", "employee");
            }

            if (EmployeeListPropertiesHaveRecords(employee))
            {
                throw new ArgumentException("The Employee object cannot have salary, certification, or position records since these will not be added to the database by this method.", "employee");
            }

            // TODO: wrap the table updates in a transaction

            AddPerson(employee);

            string insertStatement =
                "INSERT INTO Employee (personId, startDate) " +
                "VALUES ($personId, $startDate)";

            using (SqliteConnection connection = ChildCareDatabaseConnection.GetConnection())
            {
                connection.Open();

                using (SqliteCommand insertCommand = new SqliteCommand(insertStatement, connection))
                {
                    insertCommand.Parameters.AddWithValue("$personId", employee.PersonId);
                    insertCommand.Parameters.AddWithValue("$startDate", employee.StartDate);
                    insertCommand.ExecuteNonQuery();
                }

                using (SqliteCommand selectCommand = new SqliteCommand("SELECT last_insert_rowid()", connection))
                {
                    using (SqliteDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employee.EmployeeId = reader.GetInt32(0);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Helper method that checks to see if any of the Employee list properties (SalaryRecords, CertificationRecords, and PositionRecords) have records.
        /// </summary>
        /// <param name="employee">The Employee object being evaluated.</param>
        /// <returns>True if any of the Employee list properties have records, false otherwise.</returns>
        private bool EmployeeListPropertiesHaveRecords(Employee employee)
        {
            return employee.SalaryRecords != null || employee.CertificationRecords != null || employee.PositionRecords != null;
        }
    }
}