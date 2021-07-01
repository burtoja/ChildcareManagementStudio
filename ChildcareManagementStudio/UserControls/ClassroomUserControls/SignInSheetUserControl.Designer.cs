
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class SignInSheetUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.schoolYearLabel = new System.Windows.Forms.Label();
            this.schoolYearComboBox = new System.Windows.Forms.ComboBox();
            this.classLabel = new System.Windows.Forms.Label();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.reportViewerSignInSheet = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.generateReportButton);
            this.panel1.Controls.Add(this.classComboBox);
            this.panel1.Controls.Add(this.classLabel);
            this.panel1.Controls.Add(this.schoolYearComboBox);
            this.panel1.Controls.Add(this.schoolYearLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 80);
            this.panel1.TabIndex = 0;
            // 
            // schoolYearLabel
            // 
            this.schoolYearLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.schoolYearLabel.AutoSize = true;
            this.schoolYearLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearLabel.Location = new System.Drawing.Point(53, 31);
            this.schoolYearLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.schoolYearLabel.Name = "schoolYearLabel";
            this.schoolYearLabel.Size = new System.Drawing.Size(106, 21);
            this.schoolYearLabel.TabIndex = 1;
            this.schoolYearLabel.Text = "School Year:";
            // 
            // schoolYearComboBox
            // 
            this.schoolYearComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.schoolYearComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolYearComboBox.FormattingEnabled = true;
            this.schoolYearComboBox.Location = new System.Drawing.Point(163, 28);
            this.schoolYearComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.schoolYearComboBox.Name = "schoolYearComboBox";
            this.schoolYearComboBox.Size = new System.Drawing.Size(104, 29);
            this.schoolYearComboBox.TabIndex = 6;
            // 
            // classLabel
            // 
            this.classLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classLabel.AutoSize = true;
            this.classLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classLabel.Location = new System.Drawing.Point(291, 31);
            this.classLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.classLabel.Name = "classLabel";
            this.classLabel.Size = new System.Drawing.Size(53, 21);
            this.classLabel.TabIndex = 7;
            this.classLabel.Text = "Class:";
            // 
            // classComboBox
            // 
            this.classComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classComboBox.DisplayMember = "Location";
            this.classComboBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(348, 28);
            this.classComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(112, 29);
            this.classComboBox.TabIndex = 8;
            this.classComboBox.ValueMember = "Id";
            // 
            // generateReportButton
            // 
            this.generateReportButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportButton.Location = new System.Drawing.Point(486, 25);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(212, 33);
            this.generateReportButton.TabIndex = 9;
            this.generateReportButton.Text = "Generate Sign-in Sheet";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // reportViewerSignInSheet
            // 
            reportDataSource1.Name = "StudentDataSet";
            reportDataSource1.Value = this.StudentBindingSource;
            this.reportViewerSignInSheet.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerSignInSheet.LocalReport.ReportEmbeddedResource = "ChildcareManagementStudio.Reports.SignInSheetReport.rdlc";
            this.reportViewerSignInSheet.Location = new System.Drawing.Point(3, 86);
            this.reportViewerSignInSheet.Name = "reportViewerSignInSheet";
            this.reportViewerSignInSheet.ServerReport.BearerToken = null;
            this.reportViewerSignInSheet.Size = new System.Drawing.Size(764, 451);
            this.reportViewerSignInSheet.TabIndex = 1;
            // 
            // StudentBindingSource
            // 
            this.StudentBindingSource.DataSource = typeof(ChildcareManagementStudio.Model.Student);
            // 
            // SignInSheetUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.reportViewerSignInSheet);
            this.Controls.Add(this.panel1);
            this.Name = "SignInSheetUserControl";
            this.Size = new System.Drawing.Size(770, 540);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label classLabel;
        private System.Windows.Forms.ComboBox schoolYearComboBox;
        private System.Windows.Forms.Label schoolYearLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSignInSheet;
        private System.Windows.Forms.BindingSource StudentBindingSource;
    }
}
