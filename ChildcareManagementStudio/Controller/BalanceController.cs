using ChildcareManagementStudio.DAL;

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
    }
}