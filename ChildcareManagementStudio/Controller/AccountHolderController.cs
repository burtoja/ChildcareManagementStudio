using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for account holders.
    /// </summary>
    public class AccountHolderController
    {
        private readonly AccountHolderDAL accountHolderDAL;

        /// <summary>
        /// Constructor for the AccountHolderController class.
        /// </summary>
        public AccountHolderController()
        {
            accountHolderDAL = new AccountHolderDAL();
        }

        /// <summary>
        /// Method that returns an AccountHolder object for the requested account holder.
        /// </summary>
        /// <returns>An AccountHolder object for the specified account holder.</returns>
        public AccountHolder GetAccountHolder(int accountHolderId)
        {
            return accountHolderDAL.GetAccountHolder(accountHolderId);
        }

        /// <summary>
        /// Method that returns AccountHolder objects for all of the account holders in the database.
        /// </summary>
        /// <returns>A list of AccountHolder objects for all of the account holders in the database.</returns>
        public List<AccountHolder> GetAllAccountHolders()
        {
            return accountHolderDAL.GetAllAccountHolders();
        }

        /// <summary>
        /// Method that adds the specified account holder to the database.
        /// </summary>
        /// <param name="accountHolder">
        /// AccountHolder object representing the account holder to add.
        /// The AccountHolder object cannot have a value for the AccountHolderId property, since this will be assigned by the database.
        /// </param>
        public void AddAccountHolder(AccountHolder accountHolder)
        {
            if (accountHolder.AccountHolderId != default)
            {
                throw new ArgumentException("The AccountHolderId property cannot be filled out because it will be assigned by the database.", "accountHolder");
            }

            accountHolderDAL.AddAccountHolder(accountHolder);
        }

        /// <summary>
        /// Method that edits an employee's records in the database.
        /// </summary>
        /// <param name="originalAccountHolder">AccountHolder object representing the account holder's records before the edits are made.</param>
        /// <param name="revisedAccountHolder">AccountHolder object representing the account holder's records after the edits are made.</param>
        public void EditAccountHolder(AccountHolder originalAccountHolder, AccountHolder revisedAccountHolder)
        {
            if (originalAccountHolder == null)
            {
                throw new ArgumentNullException("originalAccountHolder", "The original account holder cannot be null.");
            }

            if (revisedAccountHolder == null)
            {
                throw new ArgumentNullException("revisedAccountHolder", "The revised account holder cannot be null.");
            }

            if (originalAccountHolder.AccountHolderId != revisedAccountHolder.AccountHolderId)
            {
                throw new ArgumentException("The account holder ID must be the same for both AccountHolder objects.");
            }

            accountHolderDAL.EditAccountHolder(originalAccountHolder, revisedAccountHolder);
        }
    }
}