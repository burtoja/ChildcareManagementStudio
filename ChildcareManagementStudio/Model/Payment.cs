using System;

namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing a payment made by an account holder.
    /// </summary>
    public class Payment
    {
        /// <summary>
        /// The account holder making the payment.
        /// </summary>
        public AccountHolder AccountHolder { get; set; }

        /// <summary>
        /// The unique ID of the payment.
        /// </summary>
        public int PaymentId { get; set; }

        /// <summary>
        /// The date the payment was made.
        /// </summary>
        public DateTime PaymentDate { get; set; }

        /// <summary>
        /// The amount of the payment, expressed in US dollars.
        /// A positive number indicates a payment.
        /// A negative number indicates a refund.
        /// </summary>
        public double Amount { get; set; }

        /// <summary>
        /// The method of payment that the account holder used for this payment.
        /// </summary>
        public PaymentType PaymentType { get; set; }
    }

    /// <summary>
    /// Enumeration for recording a form of payment.
    /// </summary>
    public enum PaymentType
    {
        Cash,
        Check,
        CreditCard
    }
}