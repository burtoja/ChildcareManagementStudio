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
        public void ShouldThrowExceptionIfLocationIsEmpty()
        {
            string location = "";
            Assert.ThrowsException<System.ArgumentNullException>(() => classroomDAL.GetClassroom(location));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfLocationIsNull()
        {
            string location = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => classroomDAL.GetClassroom(location));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfLocationIsClassroomIsNotInDatabase()
        {
            string location = "Z-101";
            Assert.ThrowsException<System.ArgumentException>(() => classroomDAL.GetClassroom(location));
        }

        [TestMethod]
        public void ShouldReturnClassroomObjectIfClassroomExists()
        {
            string location = "A-101";
            Classroom classroom = classroomDAL.GetClassroom(location);
            Assert.AreEqual("A-101", classroom.Location);
            Assert.AreEqual(30, classroom.Capacity);
        }
    }
}