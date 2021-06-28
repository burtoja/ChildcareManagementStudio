using ChildcareManagementStudio.DAL;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller for accessing position type information from the child care database.
    /// </summary>
    public class PositionTypeController
    {
        private readonly PositionTypeDAL positionTypeDAL;

        /// <summary>
        /// Constructor for the PositionTypeController class.
        /// </summary>
        public PositionTypeController()
        {
            positionTypeDAL = new PositionTypeDAL();
        }

        /// <summary>
        /// Method that returns a list of all the position types in the database.
        /// </summary>
        /// <returns>All of the position types in the database.</returns>
        public List<string> GetAllPositionTypes()
        {
            return positionTypeDAL.GetAllPositionTypes();
        }
    }
}