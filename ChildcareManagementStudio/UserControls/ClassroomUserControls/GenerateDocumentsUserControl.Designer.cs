
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateDocumentsUserControl));
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSchoolYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.classroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelInstructions = new System.Windows.Forms.Label();
            this.labelInstructionsTitle = new System.Windows.Forms.Label();
            this.generateSignInSheetButton = new System.Windows.Forms.Button();
            this.labelAttendanceDescription = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxClass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxSchoolYear);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(41, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 74);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxClass.DisplayMember = "Location";
            this.comboBoxClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(390, 22);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(112, 31);
            this.comboBoxClass.TabIndex = 2;
            this.comboBoxClass.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Classroom:";
            // 
            // comboBoxSchoolYear
            // 
            this.comboBoxSchoolYear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSchoolYear.FormattingEnabled = true;
            this.comboBoxSchoolYear.Location = new System.Drawing.Point(112, 22);
            this.comboBoxSchoolYear.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxSchoolYear.Name = "comboBoxSchoolYear";
            this.comboBoxSchoolYear.Size = new System.Drawing.Size(104, 31);
            this.comboBoxSchoolYear.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "School Year:";
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerateReport.Location = new System.Drawing.Point(41, 292);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(251, 33);
            this.buttonGenerateReport.TabIndex = 3;
            this.buttonGenerateReport.Text = "Generate Attendance Sheet";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // classroomBindingSource
            // 
            this.classroomBindingSource.DataSource = typeof(ChildcareManagementStudio.Model.Classroom);
            // 
            // labelInstructions
            // 
            this.labelInstructions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInstructions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(37, 44);
            this.labelInstructions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(660, 116);
            this.labelInstructions.TabIndex = 8;
            this.labelInstructions.Text = resources.GetString("labelInstructions.Text");
            // 
            // labelInstructionsTitle
            // 
            this.labelInstructionsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInstructionsTitle.AutoSize = true;
            this.labelInstructionsTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructionsTitle.Location = new System.Drawing.Point(37, 25);
            this.labelInstructionsTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInstructionsTitle.Name = "labelInstructionsTitle";
            this.labelInstructionsTitle.Size = new System.Drawing.Size(125, 23);
            this.labelInstructionsTitle.TabIndex = 8;
            this.labelInstructionsTitle.Text = "Instructions:";
            // 
            // generateSignInSheetButton
            // 
            this.generateSignInSheetButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateSignInSheetButton.Location = new System.Drawing.Point(41, 369);
            this.generateSignInSheetButton.Margin = new System.Windows.Forms.Padding(2);
            this.generateSignInSheetButton.Name = "generateSignInSheetButton";
            this.generateSignInSheetButton.Size = new System.Drawing.Size(251, 33);
            this.generateSignInSheetButton.TabIndex = 9;
            this.generateSignInSheetButton.Text = "Generate Sign-in Sheet";
            this.generateSignInSheetButton.UseVisualStyleBackColor = true;
            this.generateSignInSheetButton.Click += new System.EventHandler(this.GenerateSignInSheetButton_Click);
            // 
            // labelAttendanceDescription
            // 
            this.labelAttendanceDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAttendanceDescription.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAttendanceDescription.Location = new System.Drawing.Point(315, 292);
            this.labelAttendanceDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAttendanceDescription.Name = "labelAttendanceDescription";
            this.labelAttendanceDescription.Size = new System.Drawing.Size(382, 69);
            this.labelAttendanceDescription.TabIndex = 8;
            this.labelAttendanceDescription.Text = "Generates a document with student names in a one week grid ready for a teacher to" +
    " mark classroom attendance.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(382, 75);
            this.label3.TabIndex = 10;
            this.label3.Text = "Generates a document with student names in a grid prepared for parents to sign st" +
    "udent in/out.";
            // 
            // GenerateDocumentsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelAttendanceDescription);
            this.Controls.Add(this.generateSignInSheetButton);
            this.Controls.Add(this.labelInstructionsTitle);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.buttonGenerateReport);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GenerateDocumentsUserControl";
            this.Size = new System.Drawing.Size(770, 540);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classroomBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource StudentBindingSource;
        private System.Windows.Forms.BindingSource classroomBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSchoolYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Label labelInstructionsTitle;
        private System.Windows.Forms.Button generateSignInSheetButton;
        private System.Windows.Forms.Label labelAttendanceDescription;
        private System.Windows.Forms.Label label3;
    }
}
