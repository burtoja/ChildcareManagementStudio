
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
            this.tabViewAllStudents = new System.Windows.Forms.TabPage();
            this.tabViewStudentDetails = new System.Windows.Forms.TabPage();
            this.tabAddStudent = new System.Windows.Forms.TabPage();
            this.tabControlStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStudent
            // 
            this.tabControlStudent.Controls.Add(this.tabViewAllStudents);
            this.tabControlStudent.Controls.Add(this.tabViewStudentDetails);
            this.tabControlStudent.Controls.Add(this.tabAddStudent);
            this.tabControlStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStudent.Location = new System.Drawing.Point(0, 0);
            this.tabControlStudent.Name = "tabControlStudent";
            this.tabControlStudent.SelectedIndex = 0;
            this.tabControlStudent.Size = new System.Drawing.Size(760, 515);
            this.tabControlStudent.TabIndex = 0;
            this.tabControlStudent.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlStudent_Selected);
            // 
            // tabViewAllStudents
            // 
            this.tabViewAllStudents.Location = new System.Drawing.Point(4, 30);
            this.tabViewAllStudents.Name = "tabViewAllStudents";
            this.tabViewAllStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAllStudents.Size = new System.Drawing.Size(752, 481);
            this.tabViewAllStudents.TabIndex = 0;
            this.tabViewAllStudents.Text = "View All Students";
            this.tabViewAllStudents.UseVisualStyleBackColor = true;
            // 
            // tabViewStudentDetails
            // 
            this.tabViewStudentDetails.Location = new System.Drawing.Point(4, 30);
            this.tabViewStudentDetails.Name = "tabViewStudentDetails";
            this.tabViewStudentDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewStudentDetails.Size = new System.Drawing.Size(752, 481);
            this.tabViewStudentDetails.TabIndex = 1;
            this.tabViewStudentDetails.Text = "View Student Details";
            this.tabViewStudentDetails.UseVisualStyleBackColor = true;
            // 
            // tabAddStudent
            // 
            this.tabAddStudent.Location = new System.Drawing.Point(4, 30);
            this.tabAddStudent.Name = "tabAddStudent";
            this.tabAddStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddStudent.Size = new System.Drawing.Size(752, 481);
            this.tabAddStudent.TabIndex = 2;
            this.tabAddStudent.Text = "Add Student";
            this.tabAddStudent.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.TabPage tabViewAllStudents;
        private System.Windows.Forms.TabPage tabViewStudentDetails;
        private System.Windows.Forms.TabPage tabAddStudent;
    }
}
