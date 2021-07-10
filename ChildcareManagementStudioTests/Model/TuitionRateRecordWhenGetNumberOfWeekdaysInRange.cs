using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ChildcareManagementStudioTests.Model
{
    /// <summary>
    /// Class for testing the GetNumberOfWeekdaysInRange property of the TuitionRateRecord class.
    /// </summary>
    [TestClass]
    public class TuitionRateRecordWhenGetNumberOfWeekdaysInRange
    {
        [TestMethod]
        public void ShouldWorkWhenAllDaysAreInTheSameWeek()
        {
            TuitionRateRecord tuitionRateRecord = new TuitionRateRecord()
            {
                StartDate = new DateTime(2021, 7, 5),
                EndDate = new DateTime(2021, 7, 7)
            };

            Assert.AreEqual(3, tuitionRateRecord.NumberOfWeekdaysInRange);
        }

        [TestMethod]
        public void ShouldWorkWhenDaysSpanWeekends()
        {
            TuitionRateRecord tuitionRateRecord = new TuitionRateRecord()
            {
                StartDate = new DateTime(2021, 6, 30),
                EndDate = new DateTime(2021, 7, 6)
            };

            Assert.AreEqual(5, tuitionRateRecord.NumberOfWeekdaysInRange);
        }

        [TestMethod]
        public void ShouldWorkWhenStartDateIsWeekend()
        {
            TuitionRateRecord tuitionRateRecord = new TuitionRateRecord()
            {
                StartDate = new DateTime(2021, 7, 3),
                EndDate = new DateTime(2021, 7, 7)
            };

            Assert.AreEqual(3, tuitionRateRecord.NumberOfWeekdaysInRange);
        }

        [TestMethod]
        public void ShouldWorkWhenEndDateIsWeekend()
        {
            TuitionRateRecord tuitionRateRecord = new TuitionRateRecord()
            {
                StartDate = new DateTime(2021, 7, 5),
                EndDate = new DateTime(2021, 7, 11)
            };

            Assert.AreEqual(5, tuitionRateRecord.NumberOfWeekdaysInRange);
        }
    }
}