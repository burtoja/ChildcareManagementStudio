
namespace ChildcareManagementStudio.UserControls
{
    partial class TeacherMainUserControl
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
            this.tabControlTeacher = new System.Windows.Forms.TabControl();
            this.tabViewAllTeachers = new System.Windows.Forms.TabPage();
            this.teacherViewTeachersUserControl2 = new ChildcareManagementStudio.UserControls.TeacherViewTeachersUserControl();
            this.tabAddTeacher = new System.Windows.Forms.TabPage();
            this.teacherAddTeacherUserControl1 = new ChildcareManagementStudio.UserControls.TeacherAddTeacherUserControl();
            this.tabControlTeacher.SuspendLayout();
            this.tabViewAllTeachers.SuspendLayout();
            this.tabAddTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlTeacher
            // 
            this.tabControlTeacher.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControlTeacher.Controls.Add(this.tabViewAllTeachers);
            this.tabControlTeacher.Controls.Add(this.tabAddTeacher);
            this.tabControlTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlTeacher.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlTeacher.Location = new System.Drawing.Point(0, 0);
            this.tabControlTeacher.Name = "tabControlTeacher";
            this.tabControlTeacher.SelectedIndex = 0;
            this.tabControlTeacher.Size = new System.Drawing.Size(760, 515);
            this.tabControlTeacher.TabIndex = 0;
            this.tabControlTeacher.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControlTeacher_Selected);
            // 
            // tabViewAllTeachers
            // 
            this.tabViewAllTeachers.Controls.Add(this.teacherViewTeachersUserControl2);
            this.tabViewAllTeachers.Location = new System.Drawing.Point(4, 34);
            this.tabViewAllTeachers.Name = "tabViewAllTeachers";
            this.tabViewAllTeachers.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewAllTeachers.Size = new System.Drawing.Size(752, 477);
            this.tabViewAllTeachers.TabIndex = 0;
            this.tabViewAllTeachers.Text = "View All Teachers";
            this.tabViewAllTeachers.UseVisualStyleBackColor = true;
            // 
            // teacherViewTeachersUserControl2
            // 
            this.teacherViewTeachersUserControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.teacherViewTeachersUserControl2.Location = new System.Drawing.Point(1, 4);
            this.teacherViewTeachersUserControl2.Name = "teacherViewTeachersUserControl2";
            this.teacherViewTeachersUserControl2.Size = new System.Drawing.Size(745, 470);
            this.teacherViewTeachersUserControl2.TabIndex = 0;
            // 
            // tabAddTeacher
            // 
            this.tabAddTeacher.Controls.Add(this.teacherAddTeacherUserControl1);
            this.tabAddTeacher.Location = new System.Drawing.Point(4, 34);
            this.tabAddTeacher.Name = "tabAddTeacher";
            this.tabAddTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddTeacher.Size = new System.Drawing.Size(752, 477);
            this.tabAddTeacher.TabIndex = 2;
            this.tabAddTeacher.Text = "Add New Teacher";
            this.tabAddTeacher.UseVisualStyleBackColor = true;
            // 
            // teacherAddTeacherUserControl1
            // 
            this.teacherAddTeacherUserControl1.Location = new System.Drawing.Point(3, 3);
            this.teacherAddTeacherUserControl1.Name = "teacherAddTeacherUserControl1";
            this.teacherAddTeacherUserControl1.Size = new System.Drawing.Size(745, 470);
            this.teacherAddTeacherUserControl1.TabIndex = 0;
            // 
            // TeacherMainUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlTeacher);
            this.Name = "TeacherMainUserControl";
            this.Size = new System.Drawing.Size(760, 515);
            this.tabControlTeacher.ResumeLayout(false);
            this.tabViewAllTeachers.ResumeLayout(false);
            this.tabAddTeacher.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTeacher;
        private System.Windows.Forms.TabPage tabViewAllTeachers;
        private System.Windows.Forms.TabPage tabAddTeacher;
        private TeacherViewTeachersUserControl teacherViewTeachersUserControl1;
        private TeacherAddTeacherUserControl teacherAddTeacherUserControl1;
        private TeacherViewTeachersUserControl teacherViewTeachersUserControl2;
    }
}
