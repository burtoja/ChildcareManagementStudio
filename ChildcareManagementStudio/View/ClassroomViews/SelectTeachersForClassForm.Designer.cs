
namespace ChildcareManagementStudio.View.ClassroomViews
{
    partial class SelectTeachersForClassForm
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
            this.labelInstructions = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.Location = new System.Drawing.Point(12, 20);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(380, 49);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "Choose the teacher(s) in the list below to be associated with this class.";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(16, 72);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(376, 281);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(16, 370);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(171, 29);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Update Class";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(221, 370);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(171, 29);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SelectTeachersForClassForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(410, 414);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelInstructions);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectTeachersForClassForm";
            this.Text = "Select Teachers For Class Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
    }
}