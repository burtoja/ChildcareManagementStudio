using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the DeleteStudentClassroomAssignment method of the StudentClassroomAssignmentController class.
    /// </summary>
    [TestClass]
    public class StudentClassroomAssignmentControllerWhenDeleteStudentClassroomAssignment
    {
        private StudentClassroomAssignmentController studentClassroomAssignmentController;

        [TestInitialize]
        public void TestInitialize()
        {
            studentClassroomAssignmentController = new StudentClassroomAssignmentController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfArgumentIsNull()
        {
            StudentClassroomAssignment studentClassroomAssignment = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => studentClassroomAssignmentController.AddStudentClassroomAssignment(studentClassroomAssignment));
        }

        [TestMethod]
        public void ShouldAddValidRecord()
        {
            Student student = new Student()
            {
                StudentId = 1
            };

            ClassRecord classRecord = new ClassRecord()
            {
                ClassId = 1
            };

            StudentClassroomAssignment studentClassroomAssignment = new StudentClassroomAssignment()
            {
                Student = student,
                ClassRecord = classRecord
            };

            studentClassroomAssignmentController.DeleteStudentClassroomAssignment(studentClassroomAssignment);

            List<StudentClassroomAssignment> studentClassroomAssignments = studentClassroomAssignmentController.GetStudentsInClass(classRecord.ClassId);
            Assert.AreEqual(2, studentClassroomAssignments.Count);

            studentClassroomAssignmentController.AddStudentClassroomAssignment(studentClassroomAssignment);
        }
    }
}