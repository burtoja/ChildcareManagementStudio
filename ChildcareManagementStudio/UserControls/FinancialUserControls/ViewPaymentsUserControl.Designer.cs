
namespace ChildcareManagementStudio.UserControls.FinancialUserControls
{
    partial class ViewPaymentsUserControl
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
            this.labelParentName = new System.Windows.Forms.Label();
            this.comboParentName = new System.Windows.Forms.ComboBox();
            this.listViewPaymentRecords = new System.Windows.Forms.ListView();
            this.headerDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.headerAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deletePaymentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelParentName
            // 
            this.labelParentName.AutoSize = true;
            this.labelParentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParentName.Location = new System.Drawing.Point(14, 33);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(146, 23);
            this.labelParentName.TabIndex = 15;
            this.labelParentName.Text = "Parent Name:";
            // 
            // comboParentName
            // 
            this.comboParentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboParentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboParentName.FormattingEnabled = true;
            this.comboParentName.Location = new System.Drawing.Point(138, 30);
            this.comboParentName.Name = "comboParentName";
            this.comboParentName.Size = new System.Drawing.Size(287, 31);
            this.comboParentName.TabIndex = 16;
            this.comboParentName.SelectedIndexChanged += new System.EventHandler(this.ComboParentName_SelectedIndexChanged);
            // 
            // listViewPaymentRecords
            // 
            this.listViewPaymentRecords.AccessibleDescription = "List of all payments";
            this.listViewPaymentRecords.AccessibleName = "Payment List";
            this.listViewPaymentRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.headerDate,
            this.headerAmount});
            this.listViewPaymentRecords.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPaymentRecords.FullRowSelect = true;
            this.listViewPaymentRecords.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPaymentRecords.HideSelection = false;
            this.listViewPaymentRecords.Location = new System.Drawing.Point(18, 80);
            this.listViewPaymentRecords.MultiSelect = false;
            this.listViewPaymentRecords.Name = "listViewPaymentRecords";
            this.listViewPaymentRecords.Size = new System.Drawing.Size(708, 293);
            this.listViewPaymentRecords.TabIndex = 17;
            this.listViewPaymentRecords.UseCompatibleStateImageBehavior = false;
            this.listViewPaymentRecords.View = System.Windows.Forms.View.Details;
            // 
            // headerDate
            // 
            this.headerDate.Text = "Payment Date";
            this.headerDate.Width = 315;
            // 
            // headerAmount
            // 
            this.headerAmount.Text = "Payment Amount";
            this.headerAmount.Width = 244;
            // 
            // deletePaymentButton
            // 
            this.deletePaymentButton.Location = new System.Drawing.Point(18, 390);
            this.deletePaymentButton.Name = "deletePaymentButton";
            this.deletePaymentButton.Size = new System.Drawing.Size(708, 61);
            this.deletePaymentButton.TabIndex = 18;
            this.deletePaymentButton.Text = "Delete Payment";
            this.deletePaymentButton.UseVisualStyleBackColor = true;
            this.deletePaymentButton.Click += new System.EventHandler(this.DeletePaymentButton_Click);
            // 
            // ViewPaymentsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.deletePaymentButton);
            this.Controls.Add(this.listViewPaymentRecords);
            this.Controls.Add(this.comboParentName);
            this.Controls.Add(this.labelParentName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewPaymentsUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.ComboBox comboParentName;
        private System.Windows.Forms.ListView listViewPaymentRecords;
        private System.Windows.Forms.ColumnHeader headerDate;
        private System.Windows.Forms.ColumnHeader headerAmount;
        private System.Windows.Forms.Button deletePaymentButton;
    }
}
