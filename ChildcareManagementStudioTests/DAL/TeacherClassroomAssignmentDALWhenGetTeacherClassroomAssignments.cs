using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetTeacherClassroomAssignments method of the TeacherClassroomAssignmentDAL class.
    /// </summary>
    [TestClass]
    public class TeacherClassroomAssignmentDALWhenGetTeacherClassroomAssignments
    {
        private TeacherClassroomAssignmentDAL teacherClassroomAssignmentDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            teacherClassroomAssignmentDAL = new TeacherClassroomAssignmentDAL();
        }

        [TestMethod]
        public void ShouldReturnCorrectListWithValidArguments()
        {
            int classId = 1;
            List<TeacherClassroomAssignment> teacherClassroomAssignments = teacherClassroomAssignmentDAL.GetTeacherClassroomAssignments(classId);
            Assert.AreEqual(2, teacherClassroomAssignments.Count);
            Assert.AreEqual(1, teacherClassroomAssignments[0].Teacher.EmployeeId);
            Assert.AreEqual("A-101", teacherClassroomAssignments[0].ClassRecord.Classroom.Location);
            Assert.AreEqual("2021-22", teacherClassroomAssignments[0].ClassRecord.SchoolYear);
        }
    }
}