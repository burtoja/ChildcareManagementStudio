using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetClassroom method of the ClassroomController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class ClassroomControllerWhenGetClassroom
    {
        private ClassroomController classroomController;

        [TestInitialize]
        public void TestInitialize()
        {
            classroomController = new ClassroomController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfLocationIsEmpty()
        {
            string location = "";
            Assert.ThrowsException<System.ArgumentNullException>(() => classroomController.GetClassroom(location));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfLocationIsNull()
        {
            string location = null;
            Assert.ThrowsException<System.ArgumentNullException>(() => classroomController.GetClassroom(location));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfLocationIsClassroomIsNotInDatabase()
        {
            string location = "Z-101";
            Assert.ThrowsException<System.ArgumentException>(() => classroomController.GetClassroom(location));
        }

        [TestMethod]
        public void ShouldReturnClassroomObjectIfClassroomExists()
        {
            string location = "A-101";
            Classroom classroom = classroomController.GetClassroom(location);
            Assert.AreEqual("A-101", classroom.Location);
            Assert.AreEqual(30, classroom.Capacity);
        }
    }
}
