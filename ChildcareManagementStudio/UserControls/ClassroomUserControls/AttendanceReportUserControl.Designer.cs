
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class AttendanceReportUserControl
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceReportTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.attendanceReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.schoolYearLabel = new System.Windows.Forms.Label();
            this.schoolYearComboBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generateReportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            this.attendanceReportTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceReportTableLayoutPanel
            // 
            this.attendanceReportTableLayoutPanel.ColumnCount = 1;
            this.attendanceReportTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.attendanceReportTableLayoutPanel.Controls.Add(this.attendanceReportViewer, 0, 1);
            this.attendanceReportTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.attendanceReportTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attendanceReportTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.attendanceReportTableLayoutPanel.Name = "attendanceReportTableLayoutPanel";
            this.attendanceReportTableLayoutPanel.RowCount = 2;
            this.attendanceReportTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.87234F));
            this.attendanceReportTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.12766F));
            this.attendanceReportTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.attendanceReportTableLayoutPanel.Size = new System.Drawing.Size(815, 376);
            this.attendanceReportTableLayoutPanel.TabIndex = 0;
            // 
            // attendanceReportViewer
            // 
            this.attendanceReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "StudentDataSet";
            reportDataSource2.Value = this.StudentBindingSource;
            this.attendanceReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.attendanceReportViewer.LocalReport.ReportEmbeddedResource = "ChildcareManagementStudio.AttendanceReport.rdlc";
            this.attendanceReportViewer.Location = new System.Drawing.Point(3, 70);
            this.attendanceReportViewer.Name = "attendanceReportViewer";
            this.attendanceReportViewer.ServerReport.BearerToken = null;
            this.attendanceReportViewer.Size = new System.Drawing.Size(809, 303);
            this.attendanceReportViewer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.55253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.88999F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.38295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.394314F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.62052F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.337454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.36217F));
            this.tableLayoutPanel1.Controls.Add(this.schoolYearLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.schoolYearComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.classLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.classComboBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.generateReportButton, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 61);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // schoolYearLabel
            // 
            this.schoolYearLabel.AutoSize = true;
            this.schoolYearLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.schoolYearLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearLabel.Location = new System.Drawing.Point(12, 0);
            this.schoolYearLabel.Name = "schoolYearLabel";
            this.schoolYearLabel.Size = new System.Drawing.Size(126, 61);
            this.schoolYearLabel.TabIndex = 0;
            this.schoolYearLabel.Text = "School year";
            // 
            // schoolYearComboBox
            // 
            this.schoolYearComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.schoolYearComboBox.FormattingEnabled = true;
            this.schoolYearComboBox.Location = new System.Drawing.Point(144, 3);
            this.schoolYearComboBox.Name = "schoolYearComboBox";
            this.schoolYearComboBox.Size = new System.Drawing.Size(203, 24);
            this.schoolYearComboBox.TabIndex = 1;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.classLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(347, 0);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(61, 61);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class";
            // 
            // classComboBox
            // 
            this.classComboBox.DataSource = this.classroomBindingSource;
            this.classComboBox.DisplayMember = "Location";
            this.classComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(414, 3);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(220, 24);
            this.classComboBox.TabIndex = 3;
            this.classComboBox.ValueMember = "Id";
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataSource = typeof(ChildcareManagementStudio.Model.Classroom);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.generateReportButton.Location = new System.Drawing.Point(622, 3);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(184, 55);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // AttendanceReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attendanceReportTableLayoutPanel);
            this.Name = "AttendanceReportUserControl";
            this.Size = new System.Drawing.Size(815, 376);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            this.attendanceReportTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource StudentBindingSource;
        private System.Windows.Forms.TableLayoutPanel attendanceReportTableLayoutPanel;
        private Microsoft.Reporting.WinForms.ReportViewer attendanceReportViewer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label schoolYearLabel;
        private System.Windows.Forms.ComboBox schoolYearComboBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.BindingSource classroomBindingSource;
    }
}
