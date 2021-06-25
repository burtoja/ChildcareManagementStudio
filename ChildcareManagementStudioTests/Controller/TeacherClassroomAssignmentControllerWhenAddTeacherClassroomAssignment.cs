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

            teacherClassroomAssignmentController.AddTeacherClassroomAssignment(teacherClassroomAssignment);

            List<TeacherClassroomAssignment> teacherClassroomAssignments = teacherClassroomAssignmentController.GetTeacherClassroomAssignments(1);
            Assert.AreEqual(3, teacherClassroomAssignments.Count);
            Assert.AreEqual(teacher.EmployeeId, teacherClassroomAssignments[2].Teacher.EmployeeId);
            Assert.AreEqual(classRecord.ClassId, teacherClassroomAssignments[2].ClassRecord.ClassId);
            Assert.AreEqual(startDate, teacherClassroomAssignments[2].StartDate);
            Assert.AreEqual(positionType, teacherClassroomAssignments[2].PositionType);

            teacherClassroomAssignmentController.DeleteTeacherClassroomAssignment(teacherClassroomAssignment);
        }
    }
}