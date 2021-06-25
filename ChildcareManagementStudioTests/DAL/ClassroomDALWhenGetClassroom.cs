using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetClassroom method of the ClassroomDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class ClassroomDALWhenGetClassroom
    {
        private ClassroomDAL classroomDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            classroomDAL = new ClassroomDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfLocationIsClassroomIsNotInDatabase()
        {
            int classroomId = 0;
            Assert.ThrowsException<System.ArgumentException>(() => classroomDAL.GetClassroom(classroomId));
        }

        [TestMethod]
        public void ShouldReturnClassroomObjectIfClassroomExists()
        {
            int classroomId = 1;
            Classroom classroom = classroomDAL.GetClassroom(classroomId);
            Assert.AreEqual("A-101", classroom.Location);
            Assert.AreEqual(30, classroom.Capacity);
        }
    }
}