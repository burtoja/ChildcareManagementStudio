using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
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
        /// Method that returns AccountHolder objects for all of the account holders in the database.
        /// </summary>
        /// <returns>A list of AccountHolder objects for all of the account holders in the database.</returns>
        public List<AccountHolder> GetAllAccountHolders()
        {
            return accountHolderDAL.GetAllAccountHolders();
        }
    }
}