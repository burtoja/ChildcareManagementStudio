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
    }
}