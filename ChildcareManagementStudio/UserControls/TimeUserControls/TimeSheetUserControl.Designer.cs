
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.EmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClockRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEndingDate = new System.Windows.Forms.Label();
            this.labelStartingDate = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.reportViewerTimeSheet = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockRecordBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeBindingSource
            // 
            this.EmployeeBindingSource.DataSource = typeof(ChildcareManagementStudio.Model.Employee);
            // 
            // ClockRecordBindingSource
            // 
            this.ClockRecordBindingSource.DataSource = typeof(ChildcareManagementStudio.Model.ClockRecord);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.10614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.89386F));
            this.tableLayoutPanel1.Controls.Add(this.labelEndingDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelStartingDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxEmployee, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerStart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerEnd, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(93, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(537, 130);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelEndingDate
            // 
            this.labelEndingDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEndingDate.AutoSize = true;
            this.labelEndingDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndingDate.Location = new System.Drawing.Point(37, 97);
            this.labelEndingDate.Name = "labelEndingDate";
            this.labelEndingDate.Size = new System.Drawing.Size(169, 21);
            this.labelEndingDate.TabIndex = 28;
            this.labelEndingDate.Text = "Report Ending Date:";
            // 
            // labelStartingDate
            // 
            this.labelStartingDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelStartingDate.AutoSize = true;
            this.labelStartingDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartingDate.Location = new System.Drawing.Point(29, 54);
            this.labelStartingDate.Name = "labelStartingDate";
            this.labelStartingDate.Size = new System.Drawing.Size(177, 21);
            this.labelStartingDate.TabIndex = 22;
            this.labelStartingDate.Text = "Report Starting Date:";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(212, 7);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(304, 29);
            this.comboBoxEmployee.TabIndex = 21;
            this.comboBoxEmployee.SelectedIndexChanged += new System.EventHandler(this.ClearReportEventHandler);
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(116, 11);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(90, 21);
            this.labelName.TabIndex = 26;
            this.labelName.Text = "Employee:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(212, 46);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerStart.TabIndex = 29;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.ClearReportEventHandler);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(212, 89);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 27);
            this.dateTimePickerEnd.TabIndex = 30;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.ClearReportEventHandler);
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
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
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
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // reportViewerTimeSheet
            // 
            this.reportViewerTimeSheet.CausesValidation = false;
            reportDataSource5.Name = "DataSetTimeSheetReportEmployee";
            reportDataSource5.Value = this.EmployeeBindingSource;
            reportDataSource6.Name = "DataSetTimeSheetReportClockRecord";
            reportDataSource6.Value = this.ClockRecordBindingSource;
            this.reportViewerTimeSheet.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewerTimeSheet.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewerTimeSheet.LocalReport.ReportEmbeddedResource = "ChildcareManagementStudio.Resources.TimeSheetReport.rdlc";
            this.reportViewerTimeSheet.Location = new System.Drawing.Point(3, 195);
            this.reportViewerTimeSheet.Name = "reportViewerTimeSheet";
            this.reportViewerTimeSheet.ServerReport.BearerToken = null;
            this.reportViewerTimeSheet.Size = new System.Drawing.Size(739, 258);
            this.reportViewerTimeSheet.TabIndex = 28;
            // 
            // TimeSheetUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.reportViewerTimeSheet);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TimeSheetUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockRecordBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEndingDate;
        private System.Windows.Forms.Label labelStartingDate;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.BindingSource EmployeeBindingSource;
        private System.Windows.Forms.BindingSource ClockRecordBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerTimeSheet;
    }
}
