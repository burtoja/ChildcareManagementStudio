using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the DeletePayment method of the PaymentDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PaymentDALWhenDeletePayment
    {
        public object MessageBox { get; private set; }

        [TestMethod]
        public void ShouldDeletePayment()
        {
            AccountHolder accountHolder = new AccountHolder()
            {
                AccountHolderId = 1
            };

            PaymentDAL paymentDAL = new PaymentDAL();

            List<Payment> initialPayments = paymentDAL.GetPayments(accountHolder);
            Payment payment = initialPayments[0];
            Assert.AreEqual(3, initialPayments.Count);
            paymentDAL.DeletePayment(payment);
            List<Payment> updatedPayments = paymentDAL.GetPayments(accountHolder);
            Assert.AreEqual(2, updatedPayments.Count);
        }
    }
}