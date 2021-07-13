using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for payments.
    /// </summary>
    public class PaymentController
    {
        private readonly PaymentDAL paymentDAL;

        /// <summary>
        /// Constructor for the PaymentController class.
        /// </summary>
        public PaymentController()
        {
            paymentDAL = new PaymentDAL();
        }

        /// <summary>
        /// Method that returns all of the payments made by the specified account holder.
        /// </summary>
        /// <param name="accountHolder">The account holder in question.</param>
        /// <returns>A list of Payment objects representing all of the payments made by the specified account holder.</returns>
        public List<Payment> GetPayments(AccountHolder accountHolder)
        {
            if (accountHolder == null)
            {
                throw new ArgumentNullException("accountHolder", "The account holder cannot be null.");
            }

            return paymentDAL.GetPayments(accountHolder);
        }

        /// <summary>
        /// Method that adds a payment record to the database.
        /// </summary>
        /// <param name="payment">The payment being added.</param>
        public void AddPayment(Payment payment)
        {
            if (payment.PaymentId != default)
            {
                throw new ArgumentNullException("payment", "The payment cannot be null.");
            }

            if (payment.PaymentId != default)
            {
                throw new ArgumentException("The PaymentId property cannot be filled out because it will be assigned by the database.", "payment");
            }

            paymentDAL.AddPayment(payment);
        }

        /// <summary>
        /// Method that returns a list of all the payments in the database.
        /// </summary>
        /// <returns>A list of all the payments in the database.</returns>
        public List<Payment> GetAllPayments()
        {
            return paymentDAL.GetAllPayments();
        }

        /// <summary>
        /// Method that deletes a payment from the database.
        /// </summary>
        /// <param name="payment">The payment being deleted.</param>
        public void DeletePayment(Payment payment)
        {
            paymentDAL.DeletePayment(payment);
        }
    }
}