
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
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
            this.attendanceReportTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.attendanceReportTableLayoutPanel.Name = "attendanceReportTableLayoutPanel";
            this.attendanceReportTableLayoutPanel.RowCount = 2;
            this.attendanceReportTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.87234F));
            this.attendanceReportTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.12766F));
            this.attendanceReportTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.attendanceReportTableLayoutPanel.Size = new System.Drawing.Size(639, 306);
            this.attendanceReportTableLayoutPanel.TabIndex = 0;
            // 
            // attendanceReportViewer
            // 
            this.attendanceReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentDataSet";
            reportDataSource1.Value = this.StudentBindingSource;
            this.attendanceReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.attendanceReportViewer.LocalReport.ReportEmbeddedResource = "ChildcareManagementStudio.AttendanceReport.rdlc";
            this.attendanceReportViewer.Location = new System.Drawing.Point(2, 56);
            this.attendanceReportViewer.Margin = new System.Windows.Forms.Padding(2);
            this.attendanceReportViewer.Name = "attendanceReportViewer";
            this.attendanceReportViewer.ServerReport.BearerToken = null;
            this.attendanceReportViewer.Size = new System.Drawing.Size(635, 248);
            this.attendanceReportViewer.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.55253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32283F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.259843F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.291339F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.889764F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.85827F));
            this.tableLayoutPanel1.Controls.Add(this.schoolYearLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.schoolYearComboBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.classLabel, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.classComboBox, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.generateReportButton, 6, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 50);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // schoolYearLabel
            // 
            this.schoolYearLabel.AutoSize = true;
            this.schoolYearLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.schoolYearLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearLabel.Location = new System.Drawing.Point(9, 0);
            this.schoolYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.schoolYearLabel.Name = "schoolYearLabel";
            this.schoolYearLabel.Size = new System.Drawing.Size(99, 50);
            this.schoolYearLabel.TabIndex = 0;
            this.schoolYearLabel.Text = "School year";
            // 
            // schoolYearComboBox
            // 
            this.schoolYearComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.schoolYearComboBox.FormattingEnabled = true;
            this.schoolYearComboBox.Location = new System.Drawing.Point(112, 2);
            this.schoolYearComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.schoolYearComboBox.Name = "schoolYearComboBox";
            this.schoolYearComboBox.Size = new System.Drawing.Size(104, 21);
            this.schoolYearComboBox.TabIndex = 1;
            // 
            // classLabel
            // 
            this.classLabel.AutoSize = true;
            this.classLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.classLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(232, 0);
            this.classLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(49, 50);
            this.classLabel.TabIndex = 2;
            this.classLabel.Text = "Class";
            // 
            // classComboBox
            // 
            this.classComboBox.DataSource = this.classroomBindingSource;
            this.classComboBox.DisplayMember = "Location";
            this.classComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(285, 2);
            this.classComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(112, 21);
            this.classComboBox.TabIndex = 3;
            this.classComboBox.ValueMember = "Id";
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataSource = typeof(ChildcareManagementStudio.Model.Classroom);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(421, 2);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(205, 21);
            this.generateReportButton.TabIndex = 4;
            this.generateReportButton.Text = "Generate Attendance Sheet";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // AttendanceReportUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attendanceReportTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AttendanceReportUserControl";
            this.Size = new System.Drawing.Size(639, 306);
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
