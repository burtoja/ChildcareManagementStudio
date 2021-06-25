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
        public void ShouldThrowExceptionIfLocationIsClassroomIsNotInDatabase()
        {
            int classroomId = 0;
            Assert.ThrowsException<System.ArgumentException>(() => classroomController.GetClassroom(classroomId));
        }

        [TestMethod]
        public void ShouldReturnClassroomObjectIfClassroomExists()
        {
            int classroomId = 1;
            Classroom classroom = classroomController.GetClassroom(classroomId);
            Assert.AreEqual("A-101", classroom.Location);
            Assert.AreEqual(30, classroom.Capacity);
        }
    }
}
