using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the EditClass method of the ClassRecordDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class ClassRecordDALWhenEditClass
    {
        private ClassRecordDAL classRecordDAL;

        [TestInitialize]
        public void TestInitialize()
        {
            classRecordDAL = new ClassRecordDAL();
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

            Assert.ThrowsException<System.ArgumentNullException>(() => classRecordDAL.EditClass(originalClassRecord, revisedClassRecord));
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

            Assert.ThrowsException<System.ArgumentNullException>(() => classRecordDAL.EditClass(originalClassRecord, revisedClassRecord));
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

            Assert.ThrowsException<System.ArgumentException>(() => classRecordDAL.EditClass(originalClassRecord, revisedClassRecord));
        }

        [TestMethod]
        public void ShouldUpdateDatabaseIfArgumentsAreValid()
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
                ClassId = 1,
                SchoolYear = "2020-21",
                Classroom = revisedClassroom
            };

            classRecordDAL.EditClass(originalClassRecord, revisedClassRecord);

            ClassRecord retrievedClassRecord = classRecordDAL.GetClassRecord(originalClassRecord.ClassId);
            Assert.AreEqual("2020-21", retrievedClassRecord.SchoolYear);

            classRecordDAL.EditClass(revisedClassRecord, originalClassRecord);    // this line is intended to undo the change made during the test
        }
    }
}