
namespace ChildcareManagementStudio.UserControls.TimeUserControls
{
    partial class TimeSheetUserControl
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelStartingDate = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEndingDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(3, 210);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(739, 257);
            this.reportViewer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.53892F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.46108F));
            this.tableLayoutPanel1.Controls.Add(this.labelEndingDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelStartingDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerStart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerEnd, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(143, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 130);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(138, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 29);
            this.comboBox1.TabIndex = 21;
            // 
            // labelStartingDate
            // 
            this.labelStartingDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStartingDate.AutoSize = true;
            this.labelStartingDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingDate.Location = new System.Drawing.Point(12, 54);
            this.labelStartingDate.Name = "labelStartingDate";
            this.labelStartingDate.Size = new System.Drawing.Size(120, 21);
            this.labelStartingDate.TabIndex = 22;
            this.labelStartingDate.Text = "Starting Date:";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(42, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 21);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "Employee:";
            // 
            // labelEndingDate
            // 
            this.labelEndingDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEndingDate.AutoSize = true;
            this.labelEndingDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndingDate.Location = new System.Drawing.Point(20, 97);
            this.labelEndingDate.Name = "labelEndingDate";
            this.labelEndingDate.Size = new System.Drawing.Size(112, 21);
            this.labelEndingDate.TabIndex = 28;
            this.labelEndingDate.Text = "Ending Date:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(138, 46);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerStart.TabIndex = 29;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(138, 89);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerEnd.TabIndex = 30;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGenerateReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(159, 157);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(180, 33);
            this.buttonGenerateReport.TabIndex = 26;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(392, 157);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(180, 33);
            this.buttonClear.TabIndex = 27;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // TimeSheetUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TimeSheetUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEndingDate;
        private System.Windows.Forms.Label labelStartingDate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Button buttonClear;
    }
}
