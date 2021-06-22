
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class ViewClassroomListUserControl
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
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numberOfStudents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonAddNewClassroom = new System.Windows.Forms.Button();
            this.buttonViewSelectedClassroomDetails = new System.Windows.Forms.Button();
            this.buttonEditSelectedClassroom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAllStudents
            // 
            this.listViewAllStudents.AccessibleDescription = "List of all student";
            this.listViewAllStudents.AccessibleName = "Student List";
            this.listViewAllStudents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.location,
            this.numberOfStudents,
            this.schoolYear});
            this.listViewAllStudents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewAllStudents.FullRowSelect = true;
            this.listViewAllStudents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAllStudents.HideSelection = false;
            this.listViewAllStudents.Location = new System.Drawing.Point(18, 19);
            this.listViewAllStudents.MultiSelect = false;
            this.listViewAllStudents.Name = "listViewAllStudents";
            this.listViewAllStudents.Size = new System.Drawing.Size(708, 383);
            this.listViewAllStudents.TabIndex = 4;
            this.listViewAllStudents.UseCompatibleStateImageBehavior = false;
            this.listViewAllStudents.View = System.Windows.Forms.View.Details;
            // 
            // location
            // 
            this.location.Text = "Classroom Location";
            this.location.Width = 248;
            // 
            // numberOfStudents
            // 
            this.numberOfStudents.Text = "Number of Students Enrolled";
            this.numberOfStudents.Width = 244;
            // 
            // schoolYear
            // 
            this.schoolYear.Text = "School Year";
            this.schoolYear.Width = 206;
            // 
            // buttonAddNewClassroom
            // 
            this.buttonAddNewClassroom.AccessibleDescription = "";
            this.buttonAddNewClassroom.AccessibleName = "";
            this.buttonAddNewClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewClassroom.Location = new System.Drawing.Point(19, 408);
            this.buttonAddNewClassroom.Name = "buttonAddNewClassroom";
            this.buttonAddNewClassroom.Size = new System.Drawing.Size(182, 43);
            this.buttonAddNewClassroom.TabIndex = 5;
            this.buttonAddNewClassroom.Text = "Add New Classroom";
            this.buttonAddNewClassroom.UseVisualStyleBackColor = true;
            // 
            // buttonViewSelectedClassroomDetails
            // 
            this.buttonViewSelectedClassroomDetails.AccessibleDescription = "";
            this.buttonViewSelectedClassroomDetails.AccessibleName = "";
            this.buttonViewSelectedClassroomDetails.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewSelectedClassroomDetails.Location = new System.Drawing.Point(221, 408);
            this.buttonViewSelectedClassroomDetails.Name = "buttonViewSelectedClassroomDetails";
            this.buttonViewSelectedClassroomDetails.Size = new System.Drawing.Size(304, 43);
            this.buttonViewSelectedClassroomDetails.TabIndex = 6;
            this.buttonViewSelectedClassroomDetails.Text = "View Selected Classroom Details";
            this.buttonViewSelectedClassroomDetails.UseVisualStyleBackColor = true;
            // 
            // buttonEditSelectedClassroom
            // 
            this.buttonEditSelectedClassroom.AccessibleDescription = "";
            this.buttonEditSelectedClassroom.AccessibleName = "";
            this.buttonEditSelectedClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditSelectedClassroom.Location = new System.Drawing.Point(544, 408);
            this.buttonEditSelectedClassroom.Name = "buttonEditSelectedClassroom";
            this.buttonEditSelectedClassroom.Size = new System.Drawing.Size(182, 43);
            this.buttonEditSelectedClassroom.TabIndex = 7;
            this.buttonEditSelectedClassroom.Text = "Add New Classroom";
            this.buttonEditSelectedClassroom.UseVisualStyleBackColor = true;
            // 
            // ViewClassroomListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonEditSelectedClassroom);
            this.Controls.Add(this.buttonViewSelectedClassroomDetails);
            this.Controls.Add(this.listViewAllStudents);
            this.Controls.Add(this.buttonAddNewClassroom);
            this.Name = "ViewClassroomListUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewAllStudents;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader numberOfStudents;
        private System.Windows.Forms.ColumnHeader schoolYear;
        private System.Windows.Forms.Button buttonAddNewClassroom;
        private System.Windows.Forms.Button buttonViewSelectedClassroomDetails;
        private System.Windows.Forms.Button buttonEditSelectedClassroom;
    }
}
