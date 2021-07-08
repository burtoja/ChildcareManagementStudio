using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the AddStudentClassroomAssignment method of the StudentClassroomAssignmentDAL class.
    /// </summary>
    [TestClass]
    public class StudentClassroomAssignmentDALWhenAddStudentClassroomAssignment
    {
        private StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            studentClassroomAssignmentDAL = new StudentClassroomAssignmentDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfArgumentIsNull()
        {
            StudentClassroomAssignment studentClassroomAssignment = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => studentClassroomAssignmentDAL.AddStudentClassroomAssignment(studentClassroomAssignment));
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

            studentClassroomAssignmentDAL.AddStudentClassroomAssignment(studentClassroomAssignment);

            List<StudentClassroomAssignment> studentClassroomAssignments = studentClassroomAssignmentDAL.GetStudentsInClass(classRecord.ClassId);
            Assert.AreEqual(4, studentClassroomAssignments.Count);
            Assert.AreEqual(student.StudentId, studentClassroomAssignments[3].Student.StudentId);
            Assert.AreEqual(classRecord.ClassId, studentClassroomAssignments[3].ClassRecord.ClassId);

            studentClassroomAssignmentDAL.DeleteStudentClassroomAssignment(studentClassroomAssignment);
        }
    }
}
