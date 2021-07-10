using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Model
{
    /// <summary>
    /// Class for testing the GetTuitionTotal method of the BalanceCalculator class.
    /// </summary>
    [TestClass]
    public class BalanceCalculatorWhenGetTuitionTotal
    {
        [TestMethod]
        public void ShouldReturnCorrectValue()
        {
            List<TuitionRateRecord> tuitionRateRecords = new List<TuitionRateRecord>();
            List<Payment> payments = new List<Payment>();

            TuitionRateRecord firstTuitionRateRecord = new TuitionRateRecord()
            {
                DailyRate = 1,
                StartDate = new DateTime(2021, 6, 28),
                EndDate = new DateTime(2021, 7, 2)
            };
            tuitionRateRecords.Add(firstTuitionRateRecord);

            TuitionRateRecord secondTuitionRateRecord = new TuitionRateRecord()
            {
                DailyRate = 2,
                StartDate = new DateTime(2021, 7, 5),
                EndDate = new DateTime(2021, 7, 9)
            };
            tuitionRateRecords.Add(secondTuitionRateRecord);

            BalanceCalculator balanceCalculator = new BalanceCalculator(tuitionRateRecords, payments);

            Assert.AreEqual(15, balanceCalculator.GetTuitionTotal());
        }
    }
}