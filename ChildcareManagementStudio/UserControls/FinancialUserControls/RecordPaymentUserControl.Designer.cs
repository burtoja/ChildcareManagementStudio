
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
            this.comboAccountHolder = new System.Windows.Forms.ComboBox();
            this.labelAccountHolder = new System.Windows.Forms.Label();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelPaymentType = new System.Windows.Forms.Label();
            this.dateTimePickerPayment = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPaymentType = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboAccountHolder
            // 
            this.comboAccountHolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboAccountHolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccountHolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboAccountHolder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAccountHolder.FormattingEnabled = true;
            this.comboAccountHolder.Location = new System.Drawing.Point(193, 14);
            this.comboAccountHolder.Name = "comboAccountHolder";
            this.comboAccountHolder.Size = new System.Drawing.Size(287, 29);
            this.comboAccountHolder.TabIndex = 1;
            // 
            // labelAccountHolder
            // 
            this.labelAccountHolder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAccountHolder.AutoSize = true;
            this.labelAccountHolder.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountHolder.Location = new System.Drawing.Point(43, 18);
            this.labelAccountHolder.Name = "labelAccountHolder";
            this.labelAccountHolder.Size = new System.Drawing.Size(144, 21);
            this.labelAccountHolder.TabIndex = 17;
            this.labelAccountHolder.Text = "*Account Holder:";
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentDate.Location = new System.Drawing.Point(53, 76);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(134, 21);
            this.labelPaymentDate.TabIndex = 19;
            this.labelPaymentDate.Text = "*Payment Date:";
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentAmount.Location = new System.Drawing.Point(28, 134);
            this.labelPaymentAmount.Name = "labelPaymentAmount";
            this.labelPaymentAmount.Size = new System.Drawing.Size(159, 21);
            this.labelPaymentAmount.TabIndex = 21;
            this.labelPaymentAmount.Text = "*Payment Amount:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.64728F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.35272F));
            this.tableLayoutPanel1.Controls.Add(this.labelPaymentType, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAccountHolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelPaymentDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPaymentAmount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboAccountHolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerPayment, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownAmount, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxPaymentType, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 233);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // labelPaymentType
            // 
            this.labelPaymentType.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaymentType.AutoSize = true;
            this.labelPaymentType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentType.Location = new System.Drawing.Point(56, 193);
            this.labelPaymentType.Name = "labelPaymentType";
            this.labelPaymentType.Size = new System.Drawing.Size(131, 21);
            this.labelPaymentType.TabIndex = 22;
            this.labelPaymentType.Text = "*Payment Type:";
            // 
            // dateTimePickerPayment
            // 
            this.dateTimePickerPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerPayment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerPayment.Location = new System.Drawing.Point(193, 73);
            this.dateTimePickerPayment.Name = "dateTimePickerPayment";
            this.dateTimePickerPayment.Size = new System.Drawing.Size(157, 27);
            this.dateTimePickerPayment.TabIndex = 2;
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(193, 131);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(96, 27);
            this.numericUpDownAmount.TabIndex = 3;
            // 
            // comboBoxPaymentType
            // 
            this.comboBoxPaymentType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPaymentType.FormattingEnabled = true;
            this.comboBoxPaymentType.Location = new System.Drawing.Point(193, 189);
            this.comboBoxPaymentType.Name = "comboBoxPaymentType";
            this.comboBoxPaymentType.Size = new System.Drawing.Size(228, 29);
            this.comboBoxPaymentType.TabIndex = 23;
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
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
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
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonSubmit, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClear, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 365);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(739, 65);
            this.tableLayoutPanel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(137, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "* Indicates required field";
            // 
            // RecordPaymentUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboAccountHolder;
        private System.Windows.Forms.Label labelAccountHolder;
        private System.Windows.Forms.Label labelPaymentDate;
        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerPayment;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelPaymentType;
        private System.Windows.Forms.ComboBox comboBoxPaymentType;
        private System.Windows.Forms.Label label1;
    }
}
