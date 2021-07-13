using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the GetPayments method of the PaymentController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PaymentControllerWhenGetPayments
    {
        [TestMethod]
        public void ShouldReturnAllPayments()
        {
            PaymentController paymentController = new PaymentController();
            AccountHolder accountHolder = new AccountHolder()
            {
                AccountHolderId = 1
            };
            List<Payment> payments = paymentController.GetPayments(accountHolder);
            Payment firstPayment = payments[0];

            Assert.AreEqual(1, payments.Count);
            Assert.AreEqual(2, firstPayment.PaymentId);
            Assert.AreEqual(new DateTime(2021, 7, 8), firstPayment.PaymentDate);
            Assert.AreEqual(125.00, firstPayment.Amount);
            Assert.AreEqual(PaymentType.Cash, firstPayment.PaymentType);
        }
    }
}