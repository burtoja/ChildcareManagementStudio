namespace ChildcareManagementStudio.Model
{
    /// <summary>
    /// Class representing an account holder's balance.
    /// </summary>
    public class Balance
    {
        /// <summary>
        /// The account holder responsible for the balance.
        /// </summary>
        public AccountHolder AccountHolder { get; set; }

        /// <summary>
        /// The amount that the account holder owes, expressed in US dollars.
        /// A positive number indicates a balance.
        /// A negative number indicates a credit.
        /// </summary>
        public double Amount { get; set; }
    }
}