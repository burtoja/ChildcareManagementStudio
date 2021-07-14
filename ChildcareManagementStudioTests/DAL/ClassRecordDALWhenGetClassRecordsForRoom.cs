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
    public class ClassRecordDALWhenGetClassRecordsForRoom
    {
        [TestMethod]
        public void ShouldReturnOneClassMatchingDBInfo()
        {
            ClassroomDAL classroomDAL = new ClassroomDAL();
            Classroom testClassroom = classroomDAL.GetClassroom(2);
            ClassRecordDAL classRecordDAL = new ClassRecordDAL();
            List<ClassRecord> classRecords = classRecordDAL.GetClassRecordsForRoom(testClassroom);
            Assert.AreEqual(1, classRecords.Count);
            Assert.AreEqual("A-102", classRecords[0].Classroom.Location);
            Assert.AreEqual(2, classRecords[0].ClassId);
        }
    }
}
