using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetClassRecord method of the ClassRecordDAL class.
    /// </summary>
    [TestClass]
    public class ClassRecordDALWhenGetClassRecord
    {
        [TestMethod]
        public void ShouldReturnClassRecord()
        {
            ClassRecordDAL classRecordDAL = new ClassRecordDAL();
            int classId = 1;
            ClassRecord classRecord = classRecordDAL.GetClassRecord(classId);
            Assert.AreEqual(1, classRecord.ClassId);
            Assert.AreEqual("A-101", classRecord.Classroom.Location);
            Assert.AreEqual("2021-22", classRecord.SchoolYear);
        }
    }
}