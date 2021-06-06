using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing an employee.
    /// </summary>
    public class Employee : Person
    {
        public int EmployeeId { get; set; }

        public DateTime startDate { get; set; }
    }
}