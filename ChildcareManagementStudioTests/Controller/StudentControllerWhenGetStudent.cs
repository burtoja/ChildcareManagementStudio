using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetStudent method of the StudentController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class StudentControllerWhenGetStudent
    {
        private StudentController studentController;

        [TestInitialize]
        public void TestInitialize()
        {
            studentController = new StudentController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfStudentIdIsNegative()
        {
            int studentId = -1;
            Assert.ThrowsException<System.ArgumentException>(() => studentController.GetStudent(studentId));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfTheSpecifiedEmployeeDoesNotExist()
        {
            int studentId = 0;
            Assert.ThrowsException<System.ArgumentException>(() => studentController.GetStudent(studentId));
        }

        [TestMethod]
        public void ShouldReturnEmployeeObjectIfTheSpecifiedEmployeeExists()
        {
            int studentId = 1;
            Student student = studentController.GetStudent(studentId);
            Assert.AreEqual(3, student.PersonId);
            Assert.AreEqual("Fischer", student.LastName);
            Assert.AreEqual("Macaulay", student.FirstName);
            Assert.AreEqual(new DateTime(2014, 1, 4), student.DateOfBirth);
            Assert.AreEqual("826-91-1339", student.SocialSecurityNumber);
            Assert.AreEqual("M", student.Gender);
            Assert.AreEqual("(648) 518-6345", student.PhoneNumber);
            Assert.AreEqual("463-6872 Commodo Road", student.AddressLine1);
            Assert.AreEqual("Apartment 32", student.AddressLine2);
            Assert.AreEqual("Boncelles", student.City);
            Assert.AreEqual("VA", student.State);
            Assert.AreEqual("93179", student.ZipCode);
            Assert.AreEqual(studentId, student.StudentId);
            Assert.AreEqual(new DateTime(2021, 11, 22), student.VaccinationRecordExpirationDate);
            Assert.AreEqual(new DateTime(2020, 10, 5), student.PhysicalExamExpirationDate);
        }
    }
}