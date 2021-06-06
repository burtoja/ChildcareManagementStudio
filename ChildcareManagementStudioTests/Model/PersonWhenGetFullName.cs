using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChildcareManagementStudioTests
{
    /// <summary>
    /// Class for testing the FullName property of the Person class.
    /// </summary>
    [TestClass]
    public class PersonWhenGetFullName
    {
        [TestMethod]
        public void ShouldReturnAppropriateValue()
        {
            Person person = new Person
            {
                FirstName = "Mickey",
                LastName = "Mouse"
            };
            Assert.AreEqual("Mickey Mouse", person.FullName);
        }
    }
}