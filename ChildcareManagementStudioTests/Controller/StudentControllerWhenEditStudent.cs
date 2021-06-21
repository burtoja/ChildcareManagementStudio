using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the EditStudent method of the StudentController class.
    /// </summary>
    [TestClass]
    public class StudentControllerWhenEditStudent
    {
        private StudentController studentController;

        [TestInitialize]
        public void TestInitialize()
        {
            studentController = new StudentController();
        }

        [TestMethod]
        public void ShouldThrowExceptionIfOriginalStudentIsNull()
        {
            Student originalStudent = null;

            Student revisedStudent = new Student
            {
                PersonId = 3,
                StudentId = 1,
                LastName = "Fischer",
                FirstName = "Macaulay",
                DateOfBirth = new DateTime(2014, 1, 4),
                SocialSecurityNumber = "826-91-1339",
                Gender = "M",
                PhoneNumber = "(648) 518-6345",
                AddressLine1 = "463-6872 Commodo Road",
                AddressLine2 = "Apartment 32",
                City = "Boncelles",
                State = "VA",
                ZipCode = "93179",
                VaccinationRecordExpirationDate = new DateTime(2021, 11, 22),
                PhysicalExamExpirationDate = new DateTime(2020, 10, 5)
            };

            Assert.ThrowsException<System.ArgumentNullException>(() => studentController.EditStudent(originalStudent, revisedStudent));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfRevisedStudentIsNull()
        {
            Student originalStudent = new Student
            {
                PersonId = 3,
                StudentId = 1,
                LastName = "Fischer",
                FirstName = "Macaulay",
                DateOfBirth = new DateTime(2014, 1, 4),
                SocialSecurityNumber = "826-91-1339",
                Gender = "M",
                PhoneNumber = "(648) 518-6345",
                AddressLine1 = "463-6872 Commodo Road",
                AddressLine2 = "Apartment 32",
                City = "Boncelles",
                State = "VA",
                ZipCode = "93179",
                VaccinationRecordExpirationDate = new DateTime(2021, 11, 22),
                PhysicalExamExpirationDate = new DateTime(2020, 10, 5)
            };

            Student revisedStudent = null;

            Assert.ThrowsException<System.ArgumentNullException>(() => studentController.EditStudent(originalStudent, revisedStudent));
        }

        [TestMethod]
        public void ShouldThrowExceptionIfStudentIdIsDifferent()
        {
            Student originalStudent = new Student
            {
                PersonId = 3,
                StudentId = 1,
                LastName = "Fischer",
                FirstName = "Macaulay",
                DateOfBirth = new DateTime(2014, 1, 4),
                SocialSecurityNumber = "826-91-1339",
                Gender = "M",
                PhoneNumber = "(648) 518-6345",
                AddressLine1 = "463-6872 Commodo Road",
                AddressLine2 = "Apartment 32",
                City = "Boncelles",
                State = "VA",
                ZipCode = "93179",
                VaccinationRecordExpirationDate = new DateTime(2021, 11, 22),
                PhysicalExamExpirationDate = new DateTime(2020, 10, 5)
            };

            Student revisedStudent = new Student
            {
                PersonId = 3,
                StudentId = 2,
                LastName = "Fischer",
                FirstName = "Macaulay",
                DateOfBirth = new DateTime(2014, 1, 4),
                SocialSecurityNumber = "826-91-1339",
                Gender = "M",
                PhoneNumber = "(648) 518-6345",
                AddressLine1 = "463-6872 Commodo Road",
                AddressLine2 = "Apartment 32",
                City = "Boncelles",
                State = "VA",
                ZipCode = "93179",
                VaccinationRecordExpirationDate = new DateTime(2021, 11, 22),
                PhysicalExamExpirationDate = new DateTime(2020, 10, 5)
            };

            Assert.ThrowsException<System.ArgumentException>(() => studentController.EditStudent(originalStudent, revisedStudent));
        }

        [TestMethod]
        public void ShouldUpdateDatabaseIfArgumentsAreValid()
        {
            Student originalStudent = new Student
            {
                PersonId = 3,
                StudentId = 1,
                LastName = "Fischer",
                FirstName = "Macaulay",
                DateOfBirth = new DateTime(2014, 1, 4),
                SocialSecurityNumber = "826-91-1339",
                Gender = "M",
                PhoneNumber = "(648) 518-6345",
                AddressLine1 = "463-6872 Commodo Road",
                AddressLine2 = "Apartment 32",
                City = "Boncelles",
                State = "VA",
                ZipCode = "93179",
                VaccinationRecordExpirationDate = new DateTime(2021, 11, 22),
                PhysicalExamExpirationDate = new DateTime(2020, 10, 5)
            };

            Student revisedStudent = new Student
            {
                PersonId = 3,
                StudentId = 1,
                LastName = "Fischer",
                FirstName = "Macaulay",
                DateOfBirth = new DateTime(2014, 1, 4),
                SocialSecurityNumber = "826-91-1339",
                Gender = "M",
                PhoneNumber = "(648) 518-6345",
                AddressLine1 = "463-6872 Commodo Road",
                AddressLine2 = "Apartment 32",
                City = "Boncelles",
                State = "VA",
                ZipCode = "93179",
                VaccinationRecordExpirationDate = new DateTime(2022, 11, 22),
                PhysicalExamExpirationDate = new DateTime(2021, 10, 5)
            };

            studentController.EditStudent(originalStudent, revisedStudent);

            Student retrievedStudent = studentController.GetStudent(originalStudent.StudentId);
            Assert.AreEqual(new DateTime(2022, 11, 22), retrievedStudent.VaccinationRecordExpirationDate);
            Assert.AreEqual(new DateTime(2021, 10, 5), retrievedStudent.PhysicalExamExpirationDate);

            studentController.EditStudent(revisedStudent, originalStudent);    // this line is intended to undo the change made during the test
        }
    }
}