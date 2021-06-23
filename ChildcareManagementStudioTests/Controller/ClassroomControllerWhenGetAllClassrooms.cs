using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetAllClassrooms method of the ClassroomController class.
    /// </summary>
    [TestClass]
    public class ClassroomControllerWhenGetAllClassrooms
    {
        [TestMethod]
        public void ShouldReturnAllClassrooms()
        {
            ClassroomController classroomController = new ClassroomController();
            List<Classroom> classrooms = classroomController.GetAllClassrooms();
            Assert.AreEqual(2, classrooms.Count);
            Assert.AreEqual("A-101", classrooms[0].Location);
            Assert.AreEqual(30, classrooms[0].Capacity);
        }
    }
}