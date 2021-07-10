using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Model
{
    /// <summary>
    /// Class for testing the GetPaymentTotal method of the BalanceCalculator class.
    /// </summary>
    [TestClass]
    public class BalanceCalculatorWhenGetPaymentTotal
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

            Payment firstPayment = new Payment()
            {
                Amount = 25
            };
            payments.Add(firstPayment);

            Payment secondPayment = new Payment()
            {
                Amount = 75
            };
            payments.Add(secondPayment);

            BalanceCalculator balanceCalculator = new BalanceCalculator(tuitionRateRecords, payments);

            Assert.AreEqual(100, balanceCalculator.GetPaymentTotal());
        }
    }
}