using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildcareManagementStudio.UserControls.FinancialUserControls
{
    /// <summary>
    /// This class will create and manage the RecordPayments UC
    /// </summary>
    public partial class RecordPaymentUserControl : UserControl
    {
        private readonly AccountHolderController accountHolderController;
        private readonly PaymentController paymentController;
        private List<AccountHolder> accountHolderList;

        /// <summary>
        /// Constructor for the UC
        /// </summary>
        public RecordPaymentUserControl()
        {
            InitializeComponent();
            this.accountHolderController = new AccountHolderController();
            this.paymentController = new PaymentController();
            this.PopulateDropDownList();
        }

        /// <summary>
        /// Populate the comboBox with parent names
        /// </summary>
        public void PopulateDropDownList()
        {
            this.accountHolderList = this.accountHolderController.GetAllAccountHolders();
            BindingList<AccountHolder> accountHolders = new BindingList<AccountHolder>();
            foreach (AccountHolder current in this.accountHolderList)
            {
                accountHolders.Add(current);
            }
            this.comboParentName.DataSource = accountHolders;
            this.comboParentName.ValueMember = "AccountHolderId";
            this.comboParentName.DisplayMember = "FullName";
            this.comboParentName.SelectedIndex = -1;
            this.comboParentName.SelectedText = "--select--";
        }
    }
}
