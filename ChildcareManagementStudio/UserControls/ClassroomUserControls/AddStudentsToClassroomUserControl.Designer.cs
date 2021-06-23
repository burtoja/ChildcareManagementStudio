﻿
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class AddStudentsToClassroomUserControl
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
            this.labelLocation = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.labelSchoolYear = new System.Windows.Forms.Label();
            this.labelValueSchoolYear = new System.Windows.Forms.Label();
            this.buttonChangeSchoolYear = new System.Windows.Forms.Button();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonEditTeacherList = new System.Windows.Forms.Button();
            this.labelAddedStudents = new System.Windows.Forms.Label();
            this.listViewStudentsNotInClass = new System.Windows.Forms.ListView();
            this.listViewStudentsInClass = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(17, 63);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(82, 21);
            this.labelLocation.TabIndex = 0;
            this.labelLocation.Text = "Location:";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(105, 60);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(151, 29);
            this.comboBoxLocation.TabIndex = 1;
            // 
            // labelSchoolYear
            // 
            this.labelSchoolYear.AutoSize = true;
            this.labelSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSchoolYear.Location = new System.Drawing.Point(17, 20);
            this.labelSchoolYear.Name = "labelSchoolYear";
            this.labelSchoolYear.Size = new System.Drawing.Size(106, 21);
            this.labelSchoolYear.TabIndex = 2;
            this.labelSchoolYear.Text = "School Year:";
            // 
            // labelValueSchoolYear
            // 
            this.labelValueSchoolYear.AutoSize = true;
            this.labelValueSchoolYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueSchoolYear.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueSchoolYear.Location = new System.Drawing.Point(118, 22);
            this.labelValueSchoolYear.Name = "labelValueSchoolYear";
            this.labelValueSchoolYear.Size = new System.Drawing.Size(70, 19);
            this.labelValueSchoolYear.TabIndex = 3;
            this.labelValueSchoolYear.Text = "2020-21";
            // 
            // buttonChangeSchoolYear
            // 
            this.buttonChangeSchoolYear.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeSchoolYear.Location = new System.Drawing.Point(194, 22);
            this.buttonChangeSchoolYear.Name = "buttonChangeSchoolYear";
            this.buttonChangeSchoolYear.Size = new System.Drawing.Size(176, 23);
            this.buttonChangeSchoolYear.TabIndex = 4;
            this.buttonChangeSchoolYear.Text = "Change School Year";
            this.buttonChangeSchoolYear.UseVisualStyleBackColor = true;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeacher.Location = new System.Drawing.Point(417, 22);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(96, 21);
            this.labelTeacher.TabIndex = 5;
            this.labelTeacher.Text = "Teacher(s):";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(519, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(200, 70);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonEditTeacherList
            // 
            this.buttonEditTeacherList.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditTeacherList.Location = new System.Drawing.Point(519, 98);
            this.buttonEditTeacherList.Name = "buttonEditTeacherList";
            this.buttonEditTeacherList.Size = new System.Drawing.Size(200, 23);
            this.buttonEditTeacherList.TabIndex = 7;
            this.buttonEditTeacherList.Text = "Add/Remove Teachers";
            this.buttonEditTeacherList.UseVisualStyleBackColor = true;
            // 
            // labelAddedStudents
            // 
            this.labelAddedStudents.AutoSize = true;
            this.labelAddedStudents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddedStudents.Location = new System.Drawing.Point(417, 144);
            this.labelAddedStudents.Name = "labelAddedStudents";
            this.labelAddedStudents.Size = new System.Drawing.Size(145, 21);
            this.labelAddedStudents.TabIndex = 8;
            this.labelAddedStudents.Text = "Students In Class:";
            // 
            // listViewStudentsNotInClass
            // 
            this.listViewStudentsNotInClass.HideSelection = false;
            this.listViewStudentsNotInClass.Location = new System.Drawing.Point(21, 168);
            this.listViewStudentsNotInClass.Name = "listViewStudentsNotInClass";
            this.listViewStudentsNotInClass.Size = new System.Drawing.Size(298, 244);
            this.listViewStudentsNotInClass.TabIndex = 9;
            this.listViewStudentsNotInClass.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentsInClass
            // 
            this.listViewStudentsInClass.HideSelection = false;
            this.listViewStudentsInClass.Location = new System.Drawing.Point(421, 168);
            this.listViewStudentsInClass.Name = "listViewStudentsInClass";
            this.listViewStudentsInClass.Size = new System.Drawing.Size(298, 244);
            this.listViewStudentsInClass.TabIndex = 10;
            this.listViewStudentsInClass.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Students in School:";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(325, 220);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(90, 23);
            this.buttonAddStudent.TabIndex = 12;
            this.buttonAddStudent.Text = "-->";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.Location = new System.Drawing.Point(324, 266);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(91, 23);
            this.buttonRemoveStudent.TabIndex = 13;
            this.buttonRemoveStudent.Text = "<--";
            this.buttonRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // AddStudentsToClassroomUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonRemoveStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewStudentsInClass);
            this.Controls.Add(this.listViewStudentsNotInClass);
            this.Controls.Add(this.labelAddedStudents);
            this.Controls.Add(this.buttonEditTeacherList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.buttonChangeSchoolYear);
            this.Controls.Add(this.labelValueSchoolYear);
            this.Controls.Add(this.labelSchoolYear);
            this.Controls.Add(this.comboBoxLocation);
            this.Controls.Add(this.labelLocation);
            this.Name = "AddStudentsToClassroomUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label labelSchoolYear;
        private System.Windows.Forms.Label labelValueSchoolYear;
        private System.Windows.Forms.Button buttonChangeSchoolYear;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonEditTeacherList;
        private System.Windows.Forms.Label labelAddedStudents;
        private System.Windows.Forms.ListView listViewStudentsNotInClass;
        private System.Windows.Forms.ListView listViewStudentsInClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonRemoveStudent;
    }
}
