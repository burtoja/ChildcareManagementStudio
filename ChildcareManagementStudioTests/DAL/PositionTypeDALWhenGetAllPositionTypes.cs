using ChildcareManagementStudio.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetAllPositionTypes method of the PositionTypeDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PositionTypeDALWhenGetAllPositionTypes
    {
        [TestMethod]
        public void ShouldReturnAllPositionTypes()
        {
            PositionTypeDAL positionTypeDAL = new PositionTypeDAL();
            List<string> positionTypes = positionTypeDAL.GetAllPositionTypes();
            Assert.AreEqual(9, positionTypes.Count);
        }
    }
}