using ChildcareManagementStudio.DAL;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;

namespace ChildcareManagementStudio.Controller
{
    /// <summary>
    /// Controller class for getting balances.
    /// </summary>
    public class BalanceController
    {
        private readonly AccountHolderDAL accountHolderDAL;
        private readonly TuitionRateRecordDAL tuitionRateRecordDAL;
        private readonly PaymentDAL paymentDAL;

        /// <summary>
        /// Constructor for the BalanceController class.
        /// </summary>
        public BalanceController()
        {
            accountHolderDAL = new AccountHolderDAL();
            tuitionRateRecordDAL = new TuitionRateRecordDAL();
            paymentDAL = new PaymentDAL();
        }

        /// <summary>
        /// Method that gets the balance for the specified account holder.
        /// </summary>
        /// <param name="accountHolder">The account holder.</param>
        /// <returns>The balance for the specified account holder.</returns>
        public Balance GetBalance(AccountHolder accountHolder)
        {
            Balance balance;
            try
            {
                List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordDAL.GetTuitionRateRecords(accountHolder);
                List<Payment> payments = paymentDAL.GetPayments(accountHolder);
                BalanceCalculator balanceCalculator = new BalanceCalculator(tuitionRateRecords, payments);
                balance = balanceCalculator.GetBalance();
            }
            catch
            {
                balance = new Balance()
                {
                    AccountHolder = accountHolder,
                    Amount = 0
                };
            }
            return balance;
        }

        /// <summary>
        /// Method that returns the balances of all the account holders in the database.
        /// </summary>
        /// <returns>Balances for all of the account holders in the database.</returns>
        public List<Balance> GetAllBalances()
        {
            List<Balance> balances = new List<Balance>();
            List<AccountHolder> accountHolders = accountHolderDAL.GetAllAccountHolders();
            foreach (AccountHolder accountHolder in accountHolders)
            {
                Balance currentBalance = this.GetBalance(accountHolder);
                balances.Add(currentBalance);
            }
            return balances;
        }
    }
}