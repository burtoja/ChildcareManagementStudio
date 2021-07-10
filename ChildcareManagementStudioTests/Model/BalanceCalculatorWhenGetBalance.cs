using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Model
{
    /// <summary>
    /// Class for testing the GetBalance method of the BalanceCalculator class.
    /// </summary>
    [TestClass]
    public class BalanceCalculatorWhenGetBalance
    {
        [TestMethod]
        public void ShouldReturnCorrectValue()
        {
            List<TuitionRateRecord> tuitionRateRecords = new List<TuitionRateRecord>();
            List<Payment> payments = new List<Payment>();

            AccountHolder accountHolder = new AccountHolder()
            {
                AccountHolderId = 1
            };

            TuitionRateRecord firstTuitionRateRecord = new TuitionRateRecord()
            {
                DailyRate = 10,
                StartDate = new DateTime(2021, 6, 28),
                EndDate = new DateTime(2021, 7, 2),
                AccountHolder = accountHolder
            };
            tuitionRateRecords.Add(firstTuitionRateRecord);

            TuitionRateRecord secondTuitionRateRecord = new TuitionRateRecord()
            {
                DailyRate = 20,
                StartDate = new DateTime(2021, 7, 5),
                EndDate = new DateTime(2021, 7, 9),
                AccountHolder = accountHolder
            };
            tuitionRateRecords.Add(secondTuitionRateRecord);

            Payment firstPayment = new Payment()
            {
                Amount = 25,
                AccountHolder = accountHolder
            };
            payments.Add(firstPayment);

            Payment secondPayment = new Payment()
            {
                Amount = 75,
                AccountHolder = accountHolder
            };
            payments.Add(secondPayment);

            BalanceCalculator balanceCalculator = new BalanceCalculator(tuitionRateRecords, payments);
            Balance balance = balanceCalculator.GetBalance();

            Assert.AreEqual(accountHolder.AccountHolderId, balance.AccountHolder.AccountHolderId);
            Assert.AreEqual(50, balance.Amount);
        }
    }
}