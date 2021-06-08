using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for managing positions.
    /// </summary>
    public class PositionController
    {
        private readonly PositionDAL positionDAL;

        /// <summary>
        /// Constructor for the PositionController class.
        /// </summary>
        public PositionController()
        {
            positionDAL = new PositionDAL();
        }

        /// <summary>
        /// Method that returns all of the position records for a given employee.
        /// </summary>
        /// <param name="employeeId">Employee ID for the employee in question.</param>
        /// <returns>A list of all the position records for the specified employee.</returns>
        public List<PositionRecord> GetPositionRecords(int employeeId)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            return positionDAL.GetPositionRecords(employeeId);
        }
    }
}