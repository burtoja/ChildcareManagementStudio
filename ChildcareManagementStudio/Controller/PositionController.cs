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

        /// <summary>
        /// Method that adds a position record to the database.
        /// </summary>
        /// <param name="employeeId">The employee ID of the employee that the record is associated with.</param>
        /// <param name="positionRecord">A PositionRecord object containing the record details.</param>
        public void AddPositionRecord(int employeeId, PositionRecord positionRecord)
        {
            if (employeeId < 0)
            {
                throw new ArgumentException("The employee ID cannot be a negative number.", "employeeId");
            }

            if (positionRecord == null)
            {
                throw new ArgumentNullException("positionRecord", "The position record cannot be null.");
            }

            positionDAL.AddPositionRecord(employeeId, positionRecord);
        }

        // TODO: delete this temporary method (it is only used to clean up temporary test additions)
        public void DeletePositionRecord(int employeeId, PositionRecord positionRecord)
        {
            positionDAL.DeletePositionRecord(employeeId, positionRecord);
        }
    }
}