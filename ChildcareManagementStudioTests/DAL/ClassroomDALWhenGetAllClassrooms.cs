using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetAllClassrooms method of the ClassroomDAL class.
    /// </summary>
    [TestClass]
    public class ClassroomDALWhenGetAllClassrooms
    {
        [TestMethod]
        public void ShouldReturnAllClassrooms()
        {
            ClassroomDAL classroomDAL = new ClassroomDAL();
            List<Classroom> classrooms = classroomDAL.GetAllClassrooms();
            Assert.AreEqual(2, classrooms.Count);
            Assert.AreEqual("A-101", classrooms[0].Location);
            Assert.AreEqual(30, classrooms[0].Capacity);
        }
    }
}