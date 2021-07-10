using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.FinancialUserControls
{
    /// <summary>
    /// This class will create and manage the main tab page in the section
    /// </summary>
    public partial class MainFinancialUserControl : UserControl
    {
        private readonly ViewPaymentsUserControl viewPaymentsUserControl;
        private readonly RecordPaymentUserControl recordPaymentUserControl;
        private readonly ViewBalancesUserControl viewBalancesUserControl;

        /// <summary>
        /// Constructor for the tab page
        /// </summary>
        public MainFinancialUserControl()
        {
            InitializeComponent();
            this.viewPaymentsUserControl = new ViewPaymentsUserControl();
            this.recordPaymentUserControl = new RecordPaymentUserControl();
            this.viewBalancesUserControl = new ViewBalancesUserControl();
            this.AddUserControls();
        }

        /// <summary>
        /// Add the user controls to the proper tab pages
        /// </summary>
        private void AddUserControls()
        {
            this.tabPageViewPayments.Controls.Add(this.viewPaymentsUserControl);
            this.tabPageRecordPayment.Controls.Add(this.recordPaymentUserControl);
            this.tabPageViewBalances.Controls.Add(this.viewBalancesUserControl);
        }

        /// <summary>
        /// Event handler for selecting tabs within this section of the application 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlMainClassroom_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // View Payments tab

                    break;
                case 1:
                    // Record Payments tab

                    break;
                case 2:
                    // View Balances tab

                    break;
            }
        }

        private void TabControlMainFinanical_Selected(object sender, TabControlEventArgs e)
        {
            switch ((sender as TabControl).SelectedIndex)
            {
                case 0:
                    // 'view payments' tab

                    break;
                case 1:
                    // 'record payment' tab

                    break;
                case 2:
                    // 'view balances' tab
                    viewBalancesUserControl.RefreshBalanceListView();
                    break;
            }
        }
    }
}
