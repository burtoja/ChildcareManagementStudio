
namespace ChildcareManagementStudio.UserControls.StudentUserControls
{
    partial class MainStudentUserControl
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
            this.tabControlStudent = new System.Windows.Forms.TabControl();
            this.tabPageViewAllStudents = new System.Windows.Forms.TabPage();
            this.tabPageViewStudentDetails = new System.Windows.Forms.TabPage();
            this.tabPageAddStudent = new System.Windows.Forms.TabPage();
            this.tabControlStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabPageViewAllStudents);
            this.tabControlStudent.Controls.Add(this.tabPageViewStudentDetails);
            this.tabControlStudent.Controls.Add(this.tabPageAddStudent);
            this.tabControlStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStudent.Location = new System.Drawing.Point(0, 0);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(760, 515);
            this.tabControlStudent.TabIndex = 0;
            this.tabControlStudent.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlStudent_Selected);
            // 
            // tabPageViewAllStudents
            // 
            this.tabPageViewAllStudents.Location = new System.Drawing.Point(4, 30);
            this.tabPageViewAllStudents.Name = "tabPageViewAllStudents";
            this.tabPageViewAllStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewAllStudents.Size = new System.Drawing.Size(752, 481);
            this.tabPageViewAllStudents.TabIndex = 0;
            this.tabPageViewAllStudents.Text = "View All Students";
            this.tabPageViewAllStudents.UseVisualStyleBackColor = true;
            // 
            // tabPageViewStudentDetails
            // 
            this.tabPageViewStudentDetails.Location = new System.Drawing.Point(4, 22);
            this.tabPageViewStudentDetails.Name = "tabPageViewStudentDetails";
            this.tabPageViewStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageViewStudentDetails.Size = new System.Drawing.Size(752, 489);
            this.tabPageViewStudentDetails.TabIndex = 1;
            this.tabPageViewStudentDetails.Text = "View Student Details";
            this.tabPageViewStudentDetails.UseVisualStyleBackColor = true;
            // 
            // tabPageAddStudent
            // 
            this.tabPageAddStudent.Location = new System.Drawing.Point(4, 22);
            this.tabPageAddStudent.Name = "tabPageAddStudent";
            this.tabPageAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddStudent.Size = new System.Drawing.Size(752, 489);
            this.tabPageAddStudent.TabIndex = 2;
            this.tabPageAddStudent.Text = "Add Student";
            this.tabPageAddStudent.UseVisualStyleBackColor = true;
            // 
            // MainStudentUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tabControlStudent);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainStudentUserControl";
            this.Size = new System.Drawing.Size(760, 515);
            this.tabControlStudent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStudent;
        private System.Windows.Forms.TabPage tabPageViewAllStudents;
        private System.Windows.Forms.TabPage tabPageViewStudentDetails;
        private System.Windows.Forms.TabPage tabPageAddStudent;
    }
}
