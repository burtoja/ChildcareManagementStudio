
namespace ChildcareManagementStudio.UserControls.TimeUserControls
{
    partial class TimeClockUserControl
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEmployeeName = new System.Windows.Forms.Label();
            this.comboEmployeeName = new System.Windows.Forms.ComboBox();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.labelValueCurrentTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClockOut = new System.Windows.Forms.Button();
            this.buttonClockIn = new System.Windows.Forms.Button();
            this.timerCurrentTime = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.64228F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.35772F));
            this.tableLayoutPanel1.Controls.Add(this.labelEmployeeName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboEmployeeName, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(152, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(442, 57);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEmployeeName
            // 
            this.labelEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelEmployeeName.AutoSize = true;
            this.labelEmployeeName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeName.Location = new System.Drawing.Point(29, 18);
            this.labelEmployeeName.Name = "labelEmployeeName";
            this.labelEmployeeName.Size = new System.Drawing.Size(90, 21);
            this.labelEmployeeName.TabIndex = 18;
            this.labelEmployeeName.Text = "Employee:";
            // 
            // comboEmployeeName
            // 
            this.comboEmployeeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmployeeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmployeeName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEmployeeName.FormattingEnabled = true;
            this.comboEmployeeName.Location = new System.Drawing.Point(125, 14);
            this.comboEmployeeName.Name = "comboEmployeeName";
            this.comboEmployeeName.Size = new System.Drawing.Size(287, 29);
            this.comboEmployeeName.TabIndex = 19;
            this.comboEmployeeName.SelectedIndexChanged += new System.EventHandler(this.ComboEmployeeName_SelectedIndexChanged);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.Location = new System.Drawing.Point(310, 54);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(114, 21);
            this.labelCurrentTime.TabIndex = 20;
            this.labelCurrentTime.Text = "Current Time:";
            this.labelCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelValueCurrentTime
            // 
            this.labelValueCurrentTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelValueCurrentTime.AutoSize = true;
            this.labelValueCurrentTime.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueCurrentTime.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueCurrentTime.Location = new System.Drawing.Point(211, 85);
            this.labelValueCurrentTime.Name = "labelValueCurrentTime";
            this.labelValueCurrentTime.Size = new System.Drawing.Size(352, 38);
            this.labelValueCurrentTime.TabIndex = 21;
            this.labelValueCurrentTime.Tag = "";
            this.labelValueCurrentTime.Text = "12/7/2021 7:35:00 AM";
            this.labelValueCurrentTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.buttonClockOut, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonClockIn, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 289);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(739, 119);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // buttonClockOut
            // 
            this.buttonClockOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClockOut.Enabled = false;
            this.buttonClockOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClockOut.Location = new System.Drawing.Point(410, 28);
            this.buttonClockOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClockOut.Name = "buttonClockOut";
            this.buttonClockOut.Size = new System.Drawing.Size(288, 63);
            this.buttonClockOut.TabIndex = 25;
            this.buttonClockOut.Text = "Clock Out";
            this.buttonClockOut.UseVisualStyleBackColor = true;
            this.buttonClockOut.Click += new System.EventHandler(this.ButtonClockOut_Click);
            // 
            // buttonClockIn
            // 
            this.buttonClockIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonClockIn.Enabled = false;
            this.buttonClockIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClockIn.Location = new System.Drawing.Point(40, 28);
            this.buttonClockIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClockIn.Name = "buttonClockIn";
            this.buttonClockIn.Size = new System.Drawing.Size(288, 63);
            this.buttonClockIn.TabIndex = 24;
            this.buttonClockIn.Text = "Clock In";
            this.buttonClockIn.UseVisualStyleBackColor = true;
            this.buttonClockIn.Click += new System.EventHandler(this.ButtonClockIn_Click);
            // 
            // timerCurrentTime
            // 
            this.timerCurrentTime.Enabled = true;
            this.timerCurrentTime.Interval = 500;
            this.timerCurrentTime.Tick += new System.EventHandler(this.TimerCurrentTime_Tick);
            // 
            // TimeClockUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelValueCurrentTime);
            this.Controls.Add(this.labelCurrentTime);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TimeClockUserControl";
            this.Size = new System.Drawing.Size(745, 470);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEmployeeName;
        private System.Windows.Forms.ComboBox comboEmployeeName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonClockIn;
        private System.Windows.Forms.Button buttonClockOut;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.Label labelValueCurrentTime;
        private System.Windows.Forms.Timer timerCurrentTime;
    }
}
