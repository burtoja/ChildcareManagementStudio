using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Tests for the edit class method in the DAL
    /// </summary>
    [TestClass]
    public class ClassroomDALWhenEditClassroom
    {
        private ClassroomDAL classroomDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            this.classroomDAL = new ClassroomDAL();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfRevisedCapacityLessThanLargestClass()
        {
            Classroom originalClassroom = this.classroomDAL.GetClassroom(1);
            Classroom revisedClassroom = new Classroom()
            {
                Id = originalClassroom.Id,
                Location = originalClassroom.Location,
                Capacity = 2
            };

            Assert.ThrowsException<System.Exception>(() => classroomDAL.EditClassroom(originalClassroom, revisedClassroom));
        }

        //[TestMethod]
        //public void ShouldReturnClassroomObjectIfClassroomExists()
        //{
        //    int classroomId = 1;
        //    Classroom classroom = classroomDAL.GetClassroom(classroomId);
        //    Assert.AreEqual("A-101", classroom.Location);
        //    Assert.AreEqual(30, classroom.Capacity);
        //}
    }
}