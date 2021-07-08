using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAvailableStudents method of the StudentClassroomAssignmentController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class StudentClassroomAssignmentControllerWhenGetAvailableStudents
    {
        private StudentClassroomAssignmentController studentClassroomAssignmentController;

        [TestInitialize]
        public void TestInitialize()
        {
            studentClassroomAssignmentController = new StudentClassroomAssignmentController();
        }

        [TestMethod]
        public void ShouldReturnCorrectListWhenNoStudentsAreEnrolled()
        {
            string schoolYear = "2020-21";
            List<Student> students = studentClassroomAssignmentController.GetAvailableStudents(schoolYear);
            Assert.AreEqual(98, students.Count);
        }

        [TestMethod]
        public void ShouldReturnCorrectListWhenSomeStudentsAreEnrolled()
        {
            string schoolYear = "2021-22";
            List<Student> students = studentClassroomAssignmentController.GetAvailableStudents(schoolYear);
            Assert.AreEqual(92, students.Count);
        }
    }
}