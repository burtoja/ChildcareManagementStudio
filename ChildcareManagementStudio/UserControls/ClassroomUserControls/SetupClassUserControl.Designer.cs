
namespace ChildcareManagementStudio.UserControls.ClassroomUserControls
{
    partial class SetupClassUserControl
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
            this.labelClassroom = new System.Windows.Forms.Label();
            this.comboBoxClassroom = new System.Windows.Forms.ComboBox();
            this.labelSchoolYear = new System.Windows.Forms.Label();
            this.labelValueSchoolYear = new System.Windows.Forms.Label();
            this.buttonChangeSchoolYear = new System.Windows.Forms.Button();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.listViewTeachers = new System.Windows.Forms.ListView();
            this.buttonEditTeacherList = new System.Windows.Forms.Button();
            this.labelAddedStudents = new System.Windows.Forms.Label();
            this.listViewStudentsNotInClass = new System.Windows.Forms.ListView();
            this.listViewStudentsInClass = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.buttonNewClass = new System.Windows.Forms.Button();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // labelClassroom
            // 
            this.labelClassroom.AutoSize = true;
            this.labelClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClassroom.Location = new System.Drawing.Point(17, 101);
            this.labelClassroom.Name = "labelClassroom";
            this.labelClassroom.Size = new System.Drawing.Size(93, 21);
            this.labelClassroom.TabIndex = 0;
            this.labelClassroom.Text = "Classroom:";
            // 
            // comboBoxClassroom
            // 
            this.comboBoxClassroom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClassroom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClassroom.FormattingEnabled = true;
            this.comboBoxClassroom.Location = new System.Drawing.Point(116, 98);
            this.comboBoxClassroom.Name = "comboBoxClassroom";
            this.comboBoxClassroom.Size = new System.Drawing.Size(254, 29);
            this.comboBoxClassroom.TabIndex = 1;
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
            this.buttonChangeSchoolYear.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // listViewTeachers
            // 
            this.listViewTeachers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName});
            this.listViewTeachers.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTeachers.HideSelection = false;
            this.listViewTeachers.Location = new System.Drawing.Point(519, 22);
            this.listViewTeachers.Name = "listViewTeachers";
            this.listViewTeachers.Size = new System.Drawing.Size(200, 70);
            this.listViewTeachers.TabIndex = 6;
            this.listViewTeachers.UseCompatibleStateImageBehavior = false;
            this.listViewTeachers.View = System.Windows.Forms.View.Details;
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
            this.buttonEditTeacherList.Click += new System.EventHandler(this.ButtonEditTeacherList_Click);
            // 
            // labelAddedStudents
            // 
            this.labelAddedStudents.AutoSize = true;
            this.labelAddedStudents.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddedStudents.Location = new System.Drawing.Point(417, 142);
            this.labelAddedStudents.Name = "labelAddedStudents";
            this.labelAddedStudents.Size = new System.Drawing.Size(145, 21);
            this.labelAddedStudents.TabIndex = 8;
            this.labelAddedStudents.Text = "Students In Class:";
            // 
            // listViewStudentsNotInClass
            // 
            this.listViewStudentsNotInClass.HideSelection = false;
            this.listViewStudentsNotInClass.Location = new System.Drawing.Point(21, 166);
            this.listViewStudentsNotInClass.Name = "listViewStudentsNotInClass";
            this.listViewStudentsNotInClass.Size = new System.Drawing.Size(298, 244);
            this.listViewStudentsNotInClass.TabIndex = 9;
            this.listViewStudentsNotInClass.UseCompatibleStateImageBehavior = false;
            // 
            // listViewStudentsInClass
            // 
            this.listViewStudentsInClass.HideSelection = false;
            this.listViewStudentsInClass.Location = new System.Drawing.Point(421, 166);
            this.listViewStudentsInClass.Name = "listViewStudentsInClass";
            this.listViewStudentsInClass.Size = new System.Drawing.Size(298, 244);
            this.listViewStudentsInClass.TabIndex = 10;
            this.listViewStudentsInClass.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Students in School:";
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(325, 217);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(90, 40);
            this.buttonAddStudent.TabIndex = 12;
            this.buttonAddStudent.Text = "-->";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.Location = new System.Drawing.Point(325, 272);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(90, 40);
            this.buttonRemoveStudent.TabIndex = 13;
            this.buttonRemoveStudent.Text = "<--";
            this.buttonRemoveStudent.UseVisualStyleBackColor = true;
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(17, 60);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(53, 21);
            this.labelClass.TabIndex = 14;
            this.labelClass.Text = "Class:";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(76, 57);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(254, 29);
            this.comboBoxClass.TabIndex = 15;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClass_SelectedIndexChanged);
            // 
            // buttonNewClass
            // 
            this.buttonNewClass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewClass.Location = new System.Drawing.Point(336, 60);
            this.buttonNewClass.Name = "buttonNewClass";
            this.buttonNewClass.Size = new System.Drawing.Size(113, 25);
            this.buttonNewClass.TabIndex = 16;
            this.buttonNewClass.Text = "Create New Class";
            this.buttonNewClass.UseVisualStyleBackColor = true;
            this.buttonNewClass.Click += new System.EventHandler(this.ButtonNewClass_Click);
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Teacher Name";
            // 
            // SetupClassUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.buttonNewClass);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.buttonRemoveStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewStudentsInClass);
            this.Controls.Add(this.listViewStudentsNotInClass);
            this.Controls.Add(this.labelAddedStudents);
            this.Controls.Add(this.buttonEditTeacherList);
            this.Controls.Add(this.listViewTeachers);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.buttonChangeSchoolYear);
            this.Controls.Add(this.labelValueSchoolYear);
            this.Controls.Add(this.labelSchoolYear);
            this.Controls.Add(this.comboBoxClassroom);
            this.Controls.Add(this.labelClassroom);
            this.Name = "SetupClassUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClassroom;
        private System.Windows.Forms.ComboBox comboBoxClassroom;
        private System.Windows.Forms.Label labelSchoolYear;
        private System.Windows.Forms.Label labelValueSchoolYear;
        private System.Windows.Forms.Button buttonChangeSchoolYear;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.ListView listViewTeachers;
        private System.Windows.Forms.Button buttonEditTeacherList;
        private System.Windows.Forms.Label labelAddedStudents;
        private System.Windows.Forms.ListView listViewStudentsNotInClass;
        private System.Windows.Forms.ListView listViewStudentsInClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonRemoveStudent;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Button buttonNewClass;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
    }
}
