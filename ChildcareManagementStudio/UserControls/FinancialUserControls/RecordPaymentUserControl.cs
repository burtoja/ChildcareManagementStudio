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
            this.accountHolderList.Insert(0, new AccountHolder { FirstName = "Select an account holder..." });
            BindingList<AccountHolder> accountHolders = new BindingList<AccountHolder>();
            foreach (AccountHolder current in this.accountHolderList)
            {
                accountHolders.Add(current);
            }
            this.comboAccountHolder.DataSource = accountHolders;
            this.comboAccountHolder.ValueMember = "AccountHolderId";
            this.comboAccountHolder.DisplayMember = "FullName";
            this.comboAccountHolder.SelectedIndex = 0;
        }

        /// <summary>
        /// Populate the payment type comboBox using the enum values in the model class
        /// </summary>
        private void PopulatePaymentTypeComboBox()
        {
            this.comboBoxPaymentType.Items.Add("Select a payment type...");
            this.comboBoxPaymentType.Items.Add("Cash");
            this.comboBoxPaymentType.Items.Add("Check");
            this.comboBoxPaymentType.Items.Add("Credit Card");
            this.comboBoxPaymentType.SelectedIndex = 0;
        }

        /// <summary>
        /// Displays message box and handles the enabling and disabling of the UC
        /// </summary>
        /// <param name="title">title of the message box</param>
        /// <param name="message">the message to display</param>
        private void DisplayMessageBox(string title, string message)
        {
            this.Enabled = false;
            MessageBox.Show(message, title);
            this.Enabled = true;
        }

        /// <summary>
        /// Validate that the user input is valid on the form
        /// </summary>
        /// <returns>true if all forms are filled with valid data</returns>
        private bool FormFieldEntriesAreValid()
        {
            string title = "";
            string message = "";
            if (this.comboAccountHolder.SelectedIndex <= 0)
            {
                title = "Account Holder Not Selected";
                message = "Please select an account holder.";
            }
            else if (this.numericUpDownAmount.Value < 0)
            {
                title = "Negative Payment Not Allowed";
                message = "Negative payments are not allowed. Please input a positive value for the payment.";
            }
            else if (this.numericUpDownAmount.Value == 0)
            {
                title = "Payment Not Entered";
                message = "A payment amount was not entered. Please input a positive value for the payment.";
            }
            else if (this.comboBoxPaymentType.SelectedIndex <= 0)
            {
                title = "Payment Type Not Selected";
                message = "Please select a payment type.";
            }

            if (title != "")
            {
                this.DisplayMessageBox(title, message);
                return false;
            }
            else
            {
                return true;
            }
            
        }

        /// <summary>
        /// Enables or disables buttons depending on the selected indices of the combo boxes.
        /// </summary>
        private void EnableOrDisableButtons()
        {
            if (this.comboAccountHolder.SelectedIndex > 0 && this.comboBoxPaymentType.SelectedIndex > 0)
            {
                this.buttonSubmit.Enabled = true;
                this.buttonClear.Enabled = true;
            }
            else
            {
                this.buttonSubmit.Enabled = false;
                this.buttonClear.Enabled = false;
            }
        }

        /// <summary>
        /// Gets the selected payment type in the form of an enumeration.
        /// </summary>
        /// <returns>The payment type in the form of an enumeration.</returns>
        private PaymentType GetPaymentType()
        {
            if (this.comboBoxPaymentType.Text.Equals("Cash"))
            {
                return PaymentType.Cash;
            }
            else if (this.comboBoxPaymentType.Text.Equals("Check"))
            {
                return PaymentType.Check;
            }
            else
            {
                return PaymentType.CreditCard;
            }
        }

        /// <summary>
        /// Handles the submit button clicks and attempts to add entry to the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    PaymentType = this.GetPaymentType()
                };
                try
                {
                    this.paymentController.AddPayment(payment);
                    this.DisplayMessageBox(
                        "Payment Successfully Recorded",
                        "The payment of " +
                        String.Format("{0:C}", Convert.ToInt32(payment.Amount)) + 
                        " was added for " + payment.AccountHolder.FullName + ".");
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

        private void ComboAccountHolder_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EnableOrDisableButtons();
        }

        private void ComboBoxPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EnableOrDisableButtons();
        }
    }
}