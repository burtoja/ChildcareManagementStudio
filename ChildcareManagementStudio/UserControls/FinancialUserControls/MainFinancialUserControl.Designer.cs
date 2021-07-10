
namespace ChildcareManagementStudio.UserControls.FinancialUserControls
{
    partial class MainFinancialUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMainFinancial = new System.Windows.Forms.TabControl();
            this.tabPageViewPayments = new System.Windows.Forms.TabPage();
            this.tabPageRecordPayment = new System.Windows.Forms.TabPage();
            this.tabPageViewBalances = new System.Windows.Forms.TabPage();
            this.tabControlMainFinancial.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMainFinancial
            // 
            this.tabControlMainFinancial.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlMainFinancial.Controls.Add(this.tabPageViewPayments);
            this.tabControlMainFinancial.Controls.Add(this.tabPageRecordPayment);
            this.tabControlMainFinancial.Controls.Add(this.tabPageViewBalances);
            this.tabControlMainFinancial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMainFinancial.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMainFinancial.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainFinancial.Name = "tabControlMainFinancial";
            this.tabControlMainFinancial.SelectedIndex = 0;
            this.tabControlMainFinancial.Size = new System.Drawing.Size(760, 515);
            this.tabControlMainFinancial.TabIndex = 1;
            this.tabControlMainFinancial.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlMainFinanical_Selected);
            // 
            // tabPageViewPayments
            // 
            this.tabPageViewPayments.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageViewPayments.Location = new System.Drawing.Point(4, 35);
            this.tabPageViewPayments.Name = "tabPageViewPayments";
            this.tabPageViewPayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewPayments.Size = new System.Drawing.Size(752, 476);
            this.tabPageViewPayments.TabIndex = 1;
            this.tabPageViewPayments.Text = "View Payments";
            // 
            // tabPageRecordPayment
            // 
            this.tabPageRecordPayment.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageRecordPayment.Location = new System.Drawing.Point(4, 35);
            this.tabPageRecordPayment.Name = "tabPageRecordPayment";
            this.tabPageRecordPayment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRecordPayment.Size = new System.Drawing.Size(752, 476);
            this.tabPageRecordPayment.TabIndex = 0;
            this.tabPageRecordPayment.Text = "Record Payment";
            // 
            // tabPageViewBalances
            // 
            this.tabPageViewBalances.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageViewBalances.Location = new System.Drawing.Point(4, 35);
            this.tabPageViewBalances.Name = "tabPageViewBalances";
            this.tabPageViewBalances.Size = new System.Drawing.Size(752, 476);
            this.tabPageViewBalances.TabIndex = 2;
            this.tabPageViewBalances.Text = "View Balances";
            // 
            // MainFinancialUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControlMainFinancial);
            this.Name = "MainFinancialUserControl";
            this.Size = new System.Drawing.Size(760, 515);
            this.tabControlMainFinancial.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMainFinancial;
        private System.Windows.Forms.TabPage tabPageViewPayments;
        private System.Windows.Forms.TabPage tabPageRecordPayment;
        private System.Windows.Forms.TabPage tabPageViewBalances;
    }
}
