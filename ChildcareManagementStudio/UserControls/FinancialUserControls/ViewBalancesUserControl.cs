using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.FinancialUserControls
{
    /// <summary>
    /// User control that allows users to view all non-zero account holder balances.
    /// </summary>
    public partial class ViewBalancesUserControl : UserControl
    {
        private BalanceController balanceController;
        private List<Balance> balances;

        /// <summary>
        /// Constructor for the user control.
        /// </summary>
        public ViewBalancesUserControl()
        {
            InitializeComponent();
            balanceController = new BalanceController();
            this.RefreshBalanceListView();
        }

        /// <summary>
        /// Method that refreshes the list of balances.
        /// </summary>
        public void RefreshBalanceListView()
        {
            this.listViewBalances.Items.Clear();
            balances = balanceController.GetAllBalances();
            foreach (Balance currentBalance in balances)
            {
                if (currentBalance.Amount != 0)
                {
                    ListViewItem item = new ListViewItem(currentBalance.AccountHolder.FullName);
                    item.SubItems.Add(currentBalance.Amount.ToString("$#,##0.00"));
                    this.listViewBalances.Items.Add(item);
                }
            }
        }
    }
}
