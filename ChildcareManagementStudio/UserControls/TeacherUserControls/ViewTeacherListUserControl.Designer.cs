
namespace ChildcareManagementStudio.UserControls
{
    partial class ViewTeacherListUserControl
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
            this.listViewAllTeachers = new System.Windows.Forms.ListView();
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonViewTeacherDetails = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAllTeachers
            // 
            this.listViewAllTeachers.AccessibleDescription = "List of all teacher";
            this.listViewAllTeachers.AccessibleName = "Teacher List";
            this.listViewAllTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lastName,
            this.firstName,
            this.dob,
            this.phone});
            this.listViewAllTeachers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAllTeachers.FullRowSelect = true;
            this.listViewAllTeachers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAllTeachers.HideSelection = false;
            this.listViewAllTeachers.Location = new System.Drawing.Point(16, 21);
            this.listViewAllTeachers.MultiSelect = false;
            this.listViewAllTeachers.Name = "listViewAllTeachers";
            this.listViewAllTeachers.Size = new System.Drawing.Size(708, 383);
            this.listViewAllTeachers.TabIndex = 0;
            this.listViewAllTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewAllTeachers.View = System.Windows.Forms.View.Details;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 200;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 191;
            // 
            // dob
            // 
            this.dob.Text = "Date of Birth";
            this.dob.Width = 130;
            // 
            // phone
            // 
            this.phone.Text = "Phone Number";
            this.phone.Width = 180;
            // 
            // buttonViewTeacherDetails
            // 
            this.buttonViewTeacherDetails.AccessibleDescription = "View teacher details button";
            this.buttonViewTeacherDetails.AccessibleName = "View teacher details button";
            this.buttonViewTeacherDetails.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewTeacherDetails.Location = new System.Drawing.Point(16, 410);
            this.buttonViewTeacherDetails.Name = "buttonViewTeacherDetails";
            this.buttonViewTeacherDetails.Size = new System.Drawing.Size(708, 43);
            this.buttonViewTeacherDetails.TabIndex = 1;
            this.buttonViewTeacherDetails.Text = "View Details for Selected Teacher";
            this.buttonViewTeacherDetails.UseVisualStyleBackColor = true;
            this.buttonViewTeacherDetails.Click += new System.EventHandler(this.ButtonViewTeacherDetails_Click);
            // 
            // ViewTeacherListUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.buttonViewTeacherDetails);
            this.Controls.Add(this.listViewAllTeachers);
            this.Name = "ViewTeacherListUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllTeachers;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader dob;
        private System.Windows.Forms.ColumnHeader phone;
        private System.Windows.Forms.Button buttonViewTeacherDetails;
    }
}
