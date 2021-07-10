using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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