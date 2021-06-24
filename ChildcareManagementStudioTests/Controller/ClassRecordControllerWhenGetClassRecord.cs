using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetClassRecord method of the ClassRecordController class.
    /// </summary>
    [TestClass]
    public class ClassRecordControllerWhenGetClassRecord
    {
        [TestMethod]
        public void ShouldReturnClassRecord()
        {
            ClassRecordController classRecordController = new ClassRecordController();
            int classId = 1;
            ClassRecord classRecord = classRecordController.GetClassRecord(classId);
            Assert.AreEqual(1, classRecord.ClassId);
            Assert.AreEqual("A-101", classRecord.Classroom.Location);
            Assert.AreEqual("2021-22", classRecord.SchoolYear);
        }
    }
}