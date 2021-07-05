
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
            this.labelParentName = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPaymentDate = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelPaymentAmount = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.comboParentName.Location = new System.Drawing.Point(192, 21);
            this.comboParentName.Name = "comboParentName";
            this.comboParentName.Size = new System.Drawing.Size(287, 29);
            this.comboParentName.TabIndex = 18;
            // 
            // labelParentName
            // 
            this.labelParentName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelParentName.AutoSize = true;
            this.labelParentName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParentName.Location = new System.Drawing.Point(68, 25);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(118, 21);
            this.labelParentName.TabIndex = 17;
            this.labelParentName.Text = "Parent Name:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(192, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 29);
            this.comboBox1.TabIndex = 20;
            // 
            // labelPaymentDate
            // 
            this.labelPaymentDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaymentDate.AutoSize = true;
            this.labelPaymentDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentDate.Location = new System.Drawing.Point(58, 96);
            this.labelPaymentDate.Name = "labelPaymentDate";
            this.labelPaymentDate.Size = new System.Drawing.Size(128, 21);
            this.labelPaymentDate.TabIndex = 19;
            this.labelPaymentDate.Text = "Payment Date:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(192, 163);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(287, 29);
            this.comboBox2.TabIndex = 22;
            // 
            // labelPaymentAmount
            // 
            this.labelPaymentAmount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelPaymentAmount.AutoSize = true;
            this.labelPaymentAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPaymentAmount.Location = new System.Drawing.Point(33, 167);
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
            this.tableLayoutPanel1.Controls.Add(this.labelParentName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelPaymentDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelPaymentAmount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboParentName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(96, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(533, 213);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(40, 16);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(288, 33);
            this.buttonSubmit.TabIndex = 24;
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
            this.buttonClear.TabIndex = 25;
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
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboParentName;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelPaymentDate;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelPaymentAmount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}
