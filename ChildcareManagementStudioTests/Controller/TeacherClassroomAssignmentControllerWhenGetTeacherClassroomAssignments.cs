using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetTeacherClassroomAssignments method of the TeacherClassroomAssignmentController class.
    /// </summary>
    [TestClass]
    public class TeacherClassroomAssignmentControllerWhenGetTeacherClassroomAssignments
    {
        private TeacherClassroomAssignmentController teacherClassroomAssignmentController;

        [TestInitialize]
        public void TestInitialize()
        {
            teacherClassroomAssignmentController = new TeacherClassroomAssignmentController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfSchoolYearIsNull()
        {
            string schoolYear = null;
            string location = "A-101";
            Assert.ThrowsException<System.ArgumentNullException>(() => teacherClassroomAssignmentController.GetTeacherClassroomAssignments(schoolYear, location));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfClassroomLocationIsNull()
        {
            string schoolYear = "2021-22";
            string location = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => teacherClassroomAssignmentController.GetTeacherClassroomAssignments(schoolYear, location));
        }

        [TestMethod]
        public void ShouldReturnCorrectListWithValidArguments()
        {
            string schoolYear = "2021-22";
            string location = "A-101";
            List<TeacherClassroomAssignment> teacherClassroomAssignments = teacherClassroomAssignmentController.GetTeacherClassroomAssignments(schoolYear, location);
            Assert.AreEqual(2, teacherClassroomAssignments.Count);
            Assert.AreEqual(1, teacherClassroomAssignments[0].Teacher.EmployeeId);
            Assert.AreEqual(new DateTime(2021, 8, 1), teacherClassroomAssignments[0].StartDate);
            Assert.AreEqual("A-101", teacherClassroomAssignments[0].Classroom.Location);
            Assert.AreEqual("2021-22", teacherClassroomAssignments[0].SchoolYear);
            Assert.AreEqual("Lead teacher", teacherClassroomAssignments[0].PositionType);
        }
    }
}