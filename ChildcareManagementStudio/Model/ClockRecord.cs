using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Decalring enums for clocked-in (0) and clocked-out (1) states
    /// </summary>
    public enum ClockState
    {
        CLockedIn,
        ClockedOut
    }

    /// <summary>
    /// Class to model a time clock record for an employee
    /// </summary>
    class ClockRecord
    {
        /// <summary>
        /// EmployeeId of Emplyee  associated with the record
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// The clock-in date and time of the employee
        /// </summary>
        public DateTime InDateTime { get; set; }

        /// <summary>
        /// The clock-out date and time of the employee.
        /// This can be null signalling that the employee is still "on the clock"
        /// </summary>
        public DateTime OutDateTime { get; set; }
    }
}
