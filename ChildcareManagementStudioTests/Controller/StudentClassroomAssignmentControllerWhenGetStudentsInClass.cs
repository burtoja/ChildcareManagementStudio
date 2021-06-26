using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    [TestClass]
    public class StudentClassroomAssignmentControllerWhenGetStudentsInClass
    {
        private StudentClassroomAssignmentController studentClassroomAssignmentController;

        [TestInitialize]
        public void TestInitialize()
        {
            studentClassroomAssignmentController = new StudentClassroomAssignmentController();
        }

        [TestMethod]
        public void ShouldReturnCorrectListWithValidArguments()
        {
            int classId = 1;
            List<StudentClassroomAssignment> studentClassroomAssignments = studentClassroomAssignmentController.GetStudentsInClass(classId);
            Assert.AreEqual(3, studentClassroomAssignments.Count);
            Assert.AreEqual(1, studentClassroomAssignments[2].Student.StudentId);
            Assert.AreEqual("A-101", studentClassroomAssignments[2].ClassRecord.Classroom.Location);
            Assert.AreEqual("2021-22", studentClassroomAssignments[2].ClassRecord.SchoolYear);
        }
    }
}