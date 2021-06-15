using ChildcareManagementStudio.Controller;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAllSchoolYears method of the SchoolYearController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class SchoolYearControllerWhenGetAllSchoolYears
    {
        [TestMethod]
        public void ShouldReturnAllSchoolYears()
        {
            SchoolYearController schoolYearController = new SchoolYearController();
            List<string> schoolYears = schoolYearController.GetAllSchoolYears();
            Assert.AreEqual(3, schoolYears.Count);
            Assert.AreEqual("2019-20", schoolYears[0]);
            Assert.AreEqual("2020-21", schoolYears[1]);
            Assert.AreEqual("2021-22", schoolYears[2]);
        }
    }
}