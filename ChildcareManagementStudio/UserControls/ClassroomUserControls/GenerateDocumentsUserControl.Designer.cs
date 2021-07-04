
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class GenerateDocumentsUserControl
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
            this.attendanceReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSchoolYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceReportViewer
            // 
            reportDataSource1.Name = "StudentDataSet";
            reportDataSource1.Value = this.StudentBindingSource;
            this.attendanceReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.attendanceReportViewer.LocalReport.ReportEmbeddedResource = "ChildcareManagementStudio.Reports.AttendanceReport.rdlc";
            this.attendanceReportViewer.Location = new System.Drawing.Point(2, 85);
            this.attendanceReportViewer.Margin = new System.Windows.Forms.Padding(2);
            this.attendanceReportViewer.Name = "attendanceReportViewer";
            this.attendanceReportViewer.ServerReport.BearerToken = null;
            this.attendanceReportViewer.Size = new System.Drawing.Size(741, 391);
            this.attendanceReportViewer.TabIndex = 4;
            this.attendanceReportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonGenerateReport);
            this.panel1.Controls.Add(this.comboBoxClass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxSchoolYear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 80);
            this.panel1.TabIndex = 1;
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(481, 25);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(251, 33);
            this.buttonGenerateReport.TabIndex = 3;
            this.buttonGenerateReport.Text = "Generate Attendance Sheet";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClass.DisplayMember = "Location";
            this.comboBoxClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(346, 28);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(112, 29);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.ValueMember = "Id";
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Classroom:";
            // 
            // comboBoxSchoolYear
            // 
            this.comboBoxSchoolYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSchoolYear.FormattingEnabled = true;
            this.comboBoxSchoolYear.Location = new System.Drawing.Point(128, 28);
            this.comboBoxSchoolYear.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSchoolYear.Name = "comboBoxSchoolYear";
            this.comboBoxSchoolYear.Size = new System.Drawing.Size(104, 29);
            this.comboBoxSchoolYear.TabIndex = 1;
            this.comboBoxSchoolYear.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "School Year:";
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataSource = typeof(ChildcareManagementStudio.Model.Classroom);
            // 
            // AttendanceReportUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.attendanceReportViewer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AttendanceReportUserControl";
            this.Size = new System.Drawing.Size(770, 540);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource StudentBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer attendanceReportViewer;
        private System.Windows.Forms.BindingSource classroomBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSchoolYear;
        private System.Windows.Forms.Label label2;
    }
}
