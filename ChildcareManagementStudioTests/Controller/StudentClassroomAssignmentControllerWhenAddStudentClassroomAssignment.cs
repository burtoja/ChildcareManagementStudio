using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the AddStudentClassroomAssignment method of the StudentClassroomAssignmentController class.
    /// </summary>
    [TestClass]
    public class StudentClassroomAssignmentControllerWhenAddStudentClassroomAssignment
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
                StudentId = 7
            };

            Classroom classroom = new Classroom()
            {
                Capacity = 30
            };

            ClassRecord classRecord = new ClassRecord()
            {
                ClassId = 1,
                Classroom = classroom
            };

            StudentClassroomAssignment studentClassroomAssignment = new StudentClassroomAssignment()
            {
                Student = student,
                ClassRecord = classRecord
            };

            studentClassroomAssignmentController.AddStudentClassroomAssignment(studentClassroomAssignment);

            List<StudentClassroomAssignment> studentClassroomAssignments = studentClassroomAssignmentController.GetStudentsInClass(classRecord.ClassId);
            Assert.AreEqual(4, studentClassroomAssignments.Count);
            Assert.AreEqual(student.StudentId, studentClassroomAssignments[3].Student.StudentId);
            Assert.AreEqual(classRecord.ClassId, studentClassroomAssignments[3].ClassRecord.ClassId);

            studentClassroomAssignmentController.DeleteStudentClassroomAssignment(studentClassroomAssignment);
        }
    }
}