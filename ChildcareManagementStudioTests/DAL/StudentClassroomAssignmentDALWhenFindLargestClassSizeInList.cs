using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace ChildcareManagementStudioTests.DAL
{
    [TestClass]
    public class StudentClassroomAssignmentDALWhenFindLargestClassSizeInList
    {
        private StudentClassroomAssignmentDAL studentClassroomAssignmentDAL;
        private ClassRecordDAL classRecordDAL;
        private StudentDAL studentDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            this.studentClassroomAssignmentDAL = new StudentClassroomAssignmentDAL();
            this.classRecordDAL = new ClassRecordDAL();
            this.studentDAL = new StudentDAL();
        }

        [TestMethod]
        public void ShouldReturnCorrectValueForLargestSize()
        {
            List<ClassRecord> classList = this.classRecordDAL.GetAllClassesForSchoolYear("2021-22");
            int largestClassSize = this.studentClassroomAssignmentDAL.FindLargestClassSizeInList(classList);
            Assert.AreEqual(3, largestClassSize);
            StudentClassroomAssignment testClassroomAssignment = new StudentClassroomAssignment()
            {
                Student = this.studentDAL.GetStudent(12),
                ClassRecord = classList[1]
            };
            this.studentClassroomAssignmentDAL.AddStudentClassroomAssignment(testClassroomAssignment);
            largestClassSize = this.studentClassroomAssignmentDAL.FindLargestClassSizeInList(classList);
            Assert.AreEqual(4, largestClassSize);
            this.studentClassroomAssignmentDAL.DeleteStudentClassroomAssignment(testClassroomAssignment);
        }
    }
}
