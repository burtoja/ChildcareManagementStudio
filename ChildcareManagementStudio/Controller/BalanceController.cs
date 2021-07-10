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
            List<TuitionRateRecord> tuitionRateRecords = tuitionRateRecordDAL.GetTuitionRateRecords(accountHolder);
            List<Payment> payments = paymentDAL.GetPayments(accountHolder);
            BalanceCalculator balanceCalculator = new BalanceCalculator(tuitionRateRecords, payments);
            Balance balance = balanceCalculator.GetBalance();
            return balance;
        }
    }
}