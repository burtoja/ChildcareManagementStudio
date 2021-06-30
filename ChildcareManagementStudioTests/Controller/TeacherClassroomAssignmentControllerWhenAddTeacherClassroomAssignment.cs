using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddTeacherClassroomAssignment method of the TeacherClassroomAssignmentController class.
    /// </summary>
    [TestClass]
    public class TeacherClassroomAssignmentControllerWhenAddTeacherClassroomAssignment
    {
        private TeacherClassroomAssignmentController teacherClassroomAssignmentController;

        [TestInitialize]
        public void TestInitialize()
        {
            teacherClassroomAssignmentController = new TeacherClassroomAssignmentController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfArgumentIsNull()
        {
            TeacherClassroomAssignment teacherClassroomAssignment = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => teacherClassroomAssignmentController.AddTeacherClassroomAssignment(teacherClassroomAssignment));
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

            teacherClassroomAssignmentController.AddTeacherClassroomAssignment(teacherClassroomAssignment);

            List<TeacherClassroomAssignment> teacherClassroomAssignments = teacherClassroomAssignmentController.GetTeacherClassroomAssignments(2);
            Assert.AreEqual(1, teacherClassroomAssignments.Count);
            Assert.AreEqual(teacher.EmployeeId, teacherClassroomAssignments[0].Teacher.EmployeeId);
            Assert.AreEqual(classRecord.ClassId, teacherClassroomAssignments[0].ClassRecord.ClassId);

            teacherClassroomAssignmentController.DeleteTeacherClassroomAssignment(teacherClassroomAssignment);
        }
    }
}