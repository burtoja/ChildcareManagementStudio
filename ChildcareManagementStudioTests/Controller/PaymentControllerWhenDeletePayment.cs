using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChildcareManagementStudioTests.Controller
{
    /// <summary>
    /// Class for testing the DeletePayment method of the PaymentController class.
    /// Note that this is only a temporary test class.
    /// These tests are based on the current state of the production database.
    /// </summary>
    [TestClass]
    public class PaymentControllerWhenDeletePayment
    {
        public object MessageBox { get; private set; }

        [TestMethod]
        public void ShouldDeletePayment()
        {
            AccountHolder accountHolder = new AccountHolder()
            {
                AccountHolderId = 1
            };

            PaymentController paymentController = new PaymentController();

            List<Payment> initialPayments = paymentController.GetPayments(accountHolder);
            Payment payment = initialPayments[0];
            Assert.AreEqual(2, initialPayments.Count);
            paymentController.DeletePayment(payment);
            List<Payment> updatedPayments = paymentController.GetPayments(accountHolder);
            Assert.AreEqual(1, updatedPayments.Count);
        }
    }
}