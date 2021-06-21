
namespace ChildcareManagementStudio.UserControls.StudentUserControls
{
    partial class ViewStudentListUserControl
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
            this.listViewAllStudents = new System.Windows.Forms.ListView();
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonViewTeacherDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAllStudents
            // 
            this.listViewAllStudents.AccessibleDescription = "List of all student";
            this.listViewAllStudents.AccessibleName = "Student List";
            this.listViewAllStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastName,
            this.firstName,
            this.dob});
            this.listViewAllStudents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAllStudents.FullRowSelect = true;
            this.listViewAllStudents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAllStudents.HideSelection = false;
            this.listViewAllStudents.Location = new System.Drawing.Point(18, 19);
            this.listViewAllStudents.MultiSelect = false;
            this.listViewAllStudents.Name = "listViewAllStudents";
            this.listViewAllStudents.Size = new System.Drawing.Size(708, 383);
            this.listViewAllStudents.TabIndex = 2;
            this.listViewAllStudents.UseCompatibleStateImageBehavior = false;
            this.listViewAllStudents.View = System.Windows.Forms.View.Details;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 200;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 200;
            // 
            // dob
            // 
            this.dob.Text = "Date of Birth";
            this.dob.Width = 130;
            // 
            // buttonViewTeacherDetails
            // 
            this.buttonViewTeacherDetails.AccessibleDescription = "View student details button";
            this.buttonViewTeacherDetails.AccessibleName = "View student details button";
            this.buttonViewTeacherDetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewTeacherDetails.Location = new System.Drawing.Point(18, 408);
            this.buttonViewTeacherDetails.Name = "buttonViewTeacherDetails";
            this.buttonViewTeacherDetails.Size = new System.Drawing.Size(708, 43);
            this.buttonViewTeacherDetails.TabIndex = 3;
            this.buttonViewTeacherDetails.Text = "View Details for Selected Student";
            this.buttonViewTeacherDetails.UseVisualStyleBackColor = true;
            this.buttonViewTeacherDetails.Click += new System.EventHandler(this.ButtonViewStudentDetails_Click);
            // 
            // ViewStudentListUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.listViewAllStudents);
            this.Controls.Add(this.buttonViewTeacherDetails);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewStudentListUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllStudents;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader dob;
        private System.Windows.Forms.Button buttonViewTeacherDetails;
    }
}
