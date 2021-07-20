using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the EditClass method of the ClassRecordController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class ClassRecordControllerWhenEditClass
    {
        private ClassRecordController classRecordController;

        [TestInitialize]
        public void TestInitialize()
        {
            classRecordController = new ClassRecordController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfOriginalClassRecordIsNull()
        {
            ClassRecord originalClassRecord = null;

            Classroom revisedClassroom = new Classroom()
            {
                Id = 1
            };

            ClassRecord revisedClassRecord = new ClassRecord
            {
                ClassId = 1,
                SchoolYear = "2022-23",
                Classroom = revisedClassroom
            };

            Assert.ThrowsException<System.ArgumentNullException>(() => classRecordController.EditClass(originalClassRecord, revisedClassRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfRevisedClassRecordIsNull()
        {
            Classroom originalClassroom = new Classroom()
            {
                Id = 1
            };

            ClassRecord originalClassRecord = new ClassRecord
            {
                ClassId = 1,
                SchoolYear = "2021-22",
                Classroom = originalClassroom
            };

            ClassRecord revisedClassRecord = null;

            Assert.ThrowsException<System.ArgumentNullException>(() => classRecordController.EditClass(originalClassRecord, revisedClassRecord));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfClassRecordIdIsDifferent()
        {
            Classroom originalClassroom = new Classroom()
            {
                Id = 1
            };

            ClassRecord originalClassRecord = new ClassRecord
            {
                ClassId = 1,
                SchoolYear = "2021-22",
                Classroom = originalClassroom
            };

            Classroom revisedClassroom = new Classroom()
            {
                Id = 1
            };

            ClassRecord revisedClassRecord = new ClassRecord
            {
                ClassId = 2,
                SchoolYear = "2022-23",
                Classroom = revisedClassroom
            };

            Assert.ThrowsException<System.ArgumentException>(() => classRecordController.EditClass(originalClassRecord, revisedClassRecord));
        }

        [TestMethod]
        public void ShouldUpdateDatabaseIfArgumentsAreValid()
        {
            Classroom originalClassroom = new Classroom()
            {
                Id = 1,
                Capacity = 30
            };

            ClassRecord originalClassRecord = new ClassRecord
            {
                ClassId = 1,
                SchoolYear = "2021-22",
                Classroom = originalClassroom
            };

            Classroom revisedClassroom = new Classroom()
            {
                Id = 1,
                Capacity = 30
            };

            ClassRecord revisedClassRecord = new ClassRecord
            {
                ClassId = 1,
                SchoolYear = "2020-21",
                Classroom = revisedClassroom
            };

            classRecordController.EditClass(originalClassRecord, revisedClassRecord);

            ClassRecord retrievedClassRecord = classRecordController.GetClassRecord(originalClassRecord.ClassId);
            Assert.AreEqual("2020-21", retrievedClassRecord.SchoolYear);

            classRecordController.EditClass(revisedClassRecord, originalClassRecord);    // this line is intended to undo the change made during the test
        }
    }
}