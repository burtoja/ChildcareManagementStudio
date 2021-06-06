
namespace ChildcareManagementStudio.View
{
    partial class MainDashboard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDashboard));
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.panelTabIndicator = new System.Windows.Forms.Panel();
            this.buttonFinancialTab = new System.Windows.Forms.Button();
            this.buttonClassroomsTab = new System.Windows.Forms.Button();
            this.buttonStudentsTab = new System.Windows.Forms.Button();
            this.buttonTeacherTab = new System.Windows.Forms.Button();
            this.teacherMainUserControl1 = new ChildcareManagementStudio.UserControls.TeacherMainUserControl();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelLeftSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Maroon;
            this.panelTop.Controls.Add(this.buttonLogout);
            this.panelTop.Controls.Add(this.pictureBoxLogo);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1045, 81);
            this.panelTop.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.AccessibleDescription = "Click to logout";
            this.buttonLogout.AccessibleName = "Logout";
            this.buttonLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLogout.BackgroundImage")));
            this.buttonLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Location = new System.Drawing.Point(1004, 8);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(29, 31);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(152, 8);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(66, 64);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(245, 8);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(671, 52);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Childcare Management Studio";
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelLeftSide.Controls.Add(this.panelTabIndicator);
            this.panelLeftSide.Controls.Add(this.buttonFinancialTab);
            this.panelLeftSide.Controls.Add(this.buttonClassroomsTab);
            this.panelLeftSide.Controls.Add(this.buttonStudentsTab);
            this.panelLeftSide.Controls.Add(this.buttonTeacherTab);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 81);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(266, 563);
            this.panelLeftSide.TabIndex = 1;
            // 
            // panelTabIndicator
            // 
            this.panelTabIndicator.BackColor = System.Drawing.Color.Black;
            this.panelTabIndicator.Location = new System.Drawing.Point(3, 0);
            this.panelTabIndicator.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabIndicator.Name = "panelTabIndicator";
            this.panelTabIndicator.Size = new System.Drawing.Size(10, 140);
            this.panelTabIndicator.TabIndex = 2;
            // 
            // buttonFinancialTab
            // 
            this.buttonFinancialTab.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonFinancialTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinancialTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinancialTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonFinancialTab.Location = new System.Drawing.Point(13, 420);
            this.buttonFinancialTab.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFinancialTab.Name = "buttonFinancialTab";
            this.buttonFinancialTab.Size = new System.Drawing.Size(253, 140);
            this.buttonFinancialTab.TabIndex = 3;
            this.buttonFinancialTab.Text = "Financial";
            this.buttonFinancialTab.UseVisualStyleBackColor = true;
            this.buttonFinancialTab.Click += new System.EventHandler(this.ButtonFinancialTab_Click);
            // 
            // buttonClassroomsTab
            // 
            this.buttonClassroomsTab.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonClassroomsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassroomsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClassroomsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClassroomsTab.Location = new System.Drawing.Point(13, 280);
            this.buttonClassroomsTab.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClassroomsTab.Name = "buttonClassroomsTab";
            this.buttonClassroomsTab.Size = new System.Drawing.Size(253, 140);
            this.buttonClassroomsTab.TabIndex = 2;
            this.buttonClassroomsTab.Text = "Classrooms";
            this.buttonClassroomsTab.UseVisualStyleBackColor = true;
            this.buttonClassroomsTab.Click += new System.EventHandler(this.ButtonClassroomsTab_Click);
            // 
            // buttonStudentsTab
            // 
            this.buttonStudentsTab.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStudentsTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudentsTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStudentsTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonStudentsTab.Location = new System.Drawing.Point(13, 140);
            this.buttonStudentsTab.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStudentsTab.Name = "buttonStudentsTab";
            this.buttonStudentsTab.Size = new System.Drawing.Size(253, 140);
            this.buttonStudentsTab.TabIndex = 1;
            this.buttonStudentsTab.Text = "Students";
            this.buttonStudentsTab.UseVisualStyleBackColor = true;
            this.buttonStudentsTab.Click += new System.EventHandler(this.ButtonStudentsTab_Click);
            // 
            // buttonTeacherTab
            // 
            this.buttonTeacherTab.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTeacherTab.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonTeacherTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeacherTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTeacherTab.ForeColor = System.Drawing.Color.Black;
            this.buttonTeacherTab.Location = new System.Drawing.Point(13, 0);
            this.buttonTeacherTab.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTeacherTab.Name = "buttonTeacherTab";
            this.buttonTeacherTab.Size = new System.Drawing.Size(253, 140);
            this.buttonTeacherTab.TabIndex = 0;
            this.buttonTeacherTab.Text = "Teachers";
            this.buttonTeacherTab.UseVisualStyleBackColor = false;
            this.buttonTeacherTab.Click += new System.EventHandler(this.ButtonTeacherTab_Click);
            // 
            // teacherMainUserControl1
            // 
            this.teacherMainUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherMainUserControl1.Location = new System.Drawing.Point(266, 81);
            this.teacherMainUserControl1.Name = "teacherMainUserControl1";
            this.teacherMainUserControl1.Size = new System.Drawing.Size(779, 563);
            this.teacherMainUserControl1.TabIndex = 2;
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 644);
            this.Controls.Add(this.teacherMainUserControl1);
            this.Controls.Add(this.panelLeftSide);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelLeftSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonFinancialTab;
        private System.Windows.Forms.Button buttonClassroomsTab;
        private System.Windows.Forms.Button buttonStudentsTab;
        private System.Windows.Forms.Button buttonTeacherTab;
        private System.Windows.Forms.Panel panelTabIndicator;
        private System.Windows.Forms.Button buttonLogout;
        private UserControls.TeacherMainUserControl teacherMainUserControl1;
    }
}