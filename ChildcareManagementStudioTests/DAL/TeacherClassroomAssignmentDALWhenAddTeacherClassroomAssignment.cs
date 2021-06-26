using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the AddTeacherClassroomAssignment method of the TeacherClassroomAssignmentDAL class.
    /// </summary>
    [TestClass]
    public class TeacherClassroomAssignmentDALWhenAddTeacherClassroomAssignment
    {
        private TeacherClassroomAssignmentDAL teacherClassroomAssignmentDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            teacherClassroomAssignmentDAL = new TeacherClassroomAssignmentDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfArgumentIsNull()
        {
            TeacherClassroomAssignment teacherClassroomAssignment = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => teacherClassroomAssignmentDAL.AddTeacherClassroomAssignment(teacherClassroomAssignment));
        }

        [TestMethod]
        public void ShouldAddValidRecord()
        {
            Employee teacher = new Employee()
            {
                EmployeeId = 2
            };

            ClassRecord classRecord = new ClassRecord()
            {
                ClassId = 1
            };

            string positionType = "Lead teacher";

            DateTime startDate = new DateTime(2022, 8, 1);

            TeacherClassroomAssignment teacherClassroomAssignment = new TeacherClassroomAssignment()
            {
                Teacher = teacher,
                ClassRecord = classRecord,
                StartDate = startDate,
                PositionType = positionType
            };

            teacherClassroomAssignmentDAL.AddTeacherClassroomAssignment(teacherClassroomAssignment);

            List<TeacherClassroomAssignment> teacherClassroomAssignments = teacherClassroomAssignmentDAL.GetTeacherClassroomAssignments(1);
            Assert.AreEqual(3, teacherClassroomAssignments.Count);
            Assert.AreEqual(teacher.EmployeeId, teacherClassroomAssignments[2].Teacher.EmployeeId);
            Assert.AreEqual(classRecord.ClassId, teacherClassroomAssignments[2].ClassRecord.ClassId);
            Assert.AreEqual(startDate, teacherClassroomAssignments[2].StartDate);
            Assert.AreEqual(positionType, teacherClassroomAssignments[2].PositionType);

            teacherClassroomAssignmentDAL.DeleteTeacherClassroomAssignment(teacherClassroomAssignment);
        }
    }
}