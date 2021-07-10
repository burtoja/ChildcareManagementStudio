using ChildcareManagementStudio.Controller;
using ChildcareManagementStudio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            this.PopulatePaymentTypeComboBox();
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
            this.comboAccountHolder.DataSource = accountHolders;
            this.comboAccountHolder.ValueMember = "AccountHolderId";
            this.comboAccountHolder.DisplayMember = "FullName";
            this.comboAccountHolder.SelectedIndex = -1;
            this.comboAccountHolder.SelectedText = "--select--";
        }

        private void PopulatePaymentTypeComboBox()
        {
            foreach (var paymentType in Enum.GetValues(typeof(PaymentType)))
            {
                this.comboBoxPaymentType.Items.Add(paymentType);
            }          
        }

        private bool FormFieldEntriesAreValid()
        {
            return true;
        }

        private void ButtonSubmit_Click(object sender, System.EventArgs e)
        {
            if (this.FormFieldEntriesAreValid())
            {
                Int32.TryParse(this.comboAccountHolder.SelectedValue.ToString(), out int accountHolderId);
                Payment payment = new Payment()
                {
                    AccountHolder = this.accountHolderController.GetAccountHolder(accountHolderId),
                    PaymentDate = this.dateTimePickerPayment.Value,
                    Amount = Decimal.ToDouble(this.numericUpDownAmount.Value),
                    PaymentType = (PaymentType)this.comboBoxPaymentType.SelectedItem
                //PaymentType = (PaymentType)Enum.Parse(typeof(PaymentType), this.comboBoxPaymentType.ValueMember.ToString())
            };
                try
                {
                    this.paymentController.AddPayment(payment);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("-----EXCEPTION: " + ex.Message); //TODO:  Replace when implementation complete
                }                
            }           
        }

        /// <summary>
        /// Handler to reset form fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, System.EventArgs e)
        {
            this.PopulateDropDownList();
            this.numericUpDownAmount.ResetText();
            this.dateTimePickerPayment.ResetText();
        }

        
    }
}
