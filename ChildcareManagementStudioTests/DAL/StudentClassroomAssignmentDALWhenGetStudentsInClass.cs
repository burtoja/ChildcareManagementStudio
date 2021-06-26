using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    [TestClass]
    public class StudentClassroomAssignmentDALWhenGetStudentsInClass
    {
        private StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            studentClassroomAssignmentDAL = new StudentClassroomAssignmentDAL();
        }

        [TestMethod]
        public void ShouldReturnCorrectListWithValidArguments()
        {
            int classId = 1;
            List<StudentClassroomAssignment> studentClassroomAssignments = studentClassroomAssignmentDAL.GetStudentsInClass(classId);
            Assert.AreEqual(3, studentClassroomAssignments.Count);
            Assert.AreEqual(1, studentClassroomAssignments[0].Student.StudentId);
            Assert.AreEqual("A-101", studentClassroomAssignments[0].ClassRecord.Classroom.Location);
            Assert.AreEqual("2021-22", studentClassroomAssignments[0].ClassRecord.SchoolYear);
        }
    }
}