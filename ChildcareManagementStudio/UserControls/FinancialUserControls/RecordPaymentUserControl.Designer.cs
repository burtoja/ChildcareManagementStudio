
namespace ChildcareManagementStudio.UserControls.FinancialUserControls
{
    partial class RecordPaymentUserControl
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
            this.comboParentName = new System.Windows.Forms.ComboBox();
            this.labelAccountHolder = new System.Windows.Forms.Label();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dateTimePickerPayment = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboParentName
            // 
            this.comboParentName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboParentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboParentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboParentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboParentName.FormattingEnabled = true;
            this.comboParentName.Location = new System.Drawing.Point(193, 21);
            this.comboParentName.Name = "comboParentName";
            this.comboParentName.Size = new System.Drawing.Size(287, 29);
            this.comboParentName.TabIndex = 1;
            // 
            // labelAccountHolder
            // 
            this.labelAccountHolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAccountHolder.AutoSize = true;
            this.labelAccountHolder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountHolder.Location = new System.Drawing.Point(49, 25);
            this.labelAccountHolder.Name = "labelAccountHolder";
            this.labelAccountHolder.Size = new System.Drawing.Size(138, 21);
            this.labelAccountHolder.TabIndex = 17;
            this.labelAccountHolder.Text = "Account Holder:";
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentDate.Location = new System.Drawing.Point(59, 96);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(128, 21);
            this.labelPaymentDate.TabIndex = 19;
            this.labelPaymentDate.Text = "Payment Date:";
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentAmount.Location = new System.Drawing.Point(34, 167);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(153, 21);
            this.labelPaymentAmount.TabIndex = 21;
            this.labelPaymentAmount.Text = "Payment Amount:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.64728F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.35272F));
            this.tableLayoutPanel1.Controls.Add(this.labelAccountHolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPaymentDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPaymentAmount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboParentName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerPayment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownAmount, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 213);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // dateTimePickerPayment
            // 
            this.dateTimePickerPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPayment.Location = new System.Drawing.Point(193, 93);
            this.dateTimePickerPayment.Name = "dateTimePickerPayment";
            this.dateTimePickerPayment.Size = new System.Drawing.Size(157, 27);
            this.dateTimePickerPayment.TabIndex = 2;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(193, 164);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(96, 27);
            this.numericUpDownAmount.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(40, 16);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(288, 33);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit Payment Record";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(421, 16);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(266, 33);
            this.buttonClear.TabIndex = 5;
            this.buttonClear.Text = "Clear Form";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClear, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 314);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(739, 65);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // RecordPaymentUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RecordPaymentUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboParentName;
        private System.Windows.Forms.Label labelAccountHolder;
        private System.Windows.Forms.Label labelPaymentDate;
        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerPayment;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
    }
}
