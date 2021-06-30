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
                ClassId = 2
            };

            TeacherClassroomAssignment teacherClassroomAssignment = new TeacherClassroomAssignment()
            {
                Teacher = teacher,
                ClassRecord = classRecord
            };

            teacherClassroomAssignmentDAL.AddTeacherClassroomAssignment(teacherClassroomAssignment);

            List<TeacherClassroomAssignment> teacherClassroomAssignments = teacherClassroomAssignmentDAL.GetTeacherClassroomAssignments(2);
            Assert.AreEqual(1, teacherClassroomAssignments.Count);
            Assert.AreEqual(teacher.EmployeeId, teacherClassroomAssignments[0].Teacher.EmployeeId);
            Assert.AreEqual(classRecord.ClassId, teacherClassroomAssignments[0].ClassRecord.ClassId);

            teacherClassroomAssignmentDAL.DeleteTeacherClassroomAssignment(teacherClassroomAssignment);
        }
    }
}