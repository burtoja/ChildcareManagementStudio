using ChildcareManagementStudio.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAllPositionTypes method of the PositionTypeController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PositionTypeControllerWhenGetAllPositionTypes
    {
        [TestMethod]
        public void ShouldReturnAllPositionTypes()
        {
            PositionTypeController positionTypeController = new PositionTypeController();
            List<string> positionTypes = positionTypeController.GetAllPositionTypes();
            Assert.AreEqual(9, positionTypes.Count);
        }
    }
}