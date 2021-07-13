using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.DAL
{
    /// <summary>
    /// Class for testing the GetAllPayments method of the PaymentDAL class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PaymentDALWhenGetAllPayments
    {
        [TestMethod]
        public void ShouldGetAllPayments()
        {
            PaymentDAL paymentDAL = new PaymentDAL();
            List<Payment> payments = paymentDAL.GetAllPayments();

            Assert.AreEqual(1, payments.Count);
            Payment firstPayment = payments[0];

            Assert.AreEqual(3, firstPayment.PaymentId);
            Assert.AreEqual(new DateTime(2021, 7, 8), firstPayment.PaymentDate);
            Assert.AreEqual(125.00, firstPayment.Amount);
            Assert.AreEqual(PaymentType.Cash, firstPayment.PaymentType);
        }
    }
}