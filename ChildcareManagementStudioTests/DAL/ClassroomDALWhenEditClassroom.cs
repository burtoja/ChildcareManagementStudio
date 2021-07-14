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
        public void ShouldThrowExceptionIfNoChanges()
        {
            Classroom originalClassroom = this.classroomDAL.GetClassroom(1);
            Classroom revisedClassroom = originalClassroom;

            Assert.ThrowsException<System.ArgumentException>(() => classroomDAL.EditClassroom(originalClassroom, revisedClassroom));
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

        [TestMethod]
        public void ShouldReflectChangesWhenChangingCapacity()
        {
            Classroom originalClassroom = this.classroomDAL.GetClassroom(1);
            Classroom revisedClassroom = new Classroom()
            {
                Id = originalClassroom.Id,
                Location = originalClassroom.Location,
                Capacity = 10
            };
            this.classroomDAL.EditClassroom(originalClassroom, revisedClassroom);
            Assert.AreEqual(10, this.classroomDAL.GetClassroom(originalClassroom.Id).Capacity);
        }
    }
}