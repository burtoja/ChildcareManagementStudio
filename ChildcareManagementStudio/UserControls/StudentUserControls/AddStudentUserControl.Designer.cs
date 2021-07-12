
namespace ChildcareManagementStudio.UserControls.StudentUserControls
{
    partial class AddStudentUserControl
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
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddress2 = new System.Windows.Forms.TextBox();
            this.textBoxAddress1 = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelAddress1 = new System.Windows.Forms.Label();
            this.labelAddress2 = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelState = new System.Windows.Forms.Label();
            this.labelZipCode = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.dateTimePickerDOB = new System.Windows.Forms.DateTimePicker();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSSN = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelRequiredField = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxZipCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxZipCode.Location = new System.Drawing.Point(164, 315);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(178, 32);
            this.textBoxZipCode.TabIndex = 21;
            this.textBoxZipCode.TextChanged += new System.EventHandler(this.TextBoxZipCode_TextChanged);
            // 
            // textBoxCity
            // 
            this.textBoxCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(164, 265);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(178, 32);
            this.textBoxCity.TabIndex = 19;
            this.textBoxCity.TextChanged += new System.EventHandler(this.TextBoxCity_TextChanged);
            // 
            // textBoxAddress2
            // 
            this.textBoxAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxAddress2, 3);
            this.textBoxAddress2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress2.Location = new System.Drawing.Point(164, 215);
            this.textBoxAddress2.Name = "textBoxAddress2";
            this.textBoxAddress2.Size = new System.Drawing.Size(549, 32);
            this.textBoxAddress2.TabIndex = 18;
            this.textBoxAddress2.TextChanged += new System.EventHandler(this.TextBoxAddress2_TextChanged);
            // 
            // textBoxAddress1
            // 
            this.textBoxAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxAddress1, 3);
            this.textBoxAddress1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress1.Location = new System.Drawing.Point(164, 165);
            this.textBoxAddress1.Name = "textBoxAddress1";
            this.textBoxAddress1.Size = new System.Drawing.Size(549, 32);
            this.textBoxAddress1.TabIndex = 17;
            this.textBoxAddress1.TextChanged += new System.EventHandler(this.TextBoxAddress1_TextChanged);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(537, 15);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(178, 32);
            this.textBoxLastName.TabIndex = 12;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.TextBoxLastName_TextChanged);
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(33, 27);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(125, 23);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "*First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(402, 27);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(129, 23);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "*Last Name:";
            // 
            // labelDOB
            // 
            this.labelDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOB.Location = new System.Drawing.Point(15, 77);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(143, 23);
            this.labelDOB.TabIndex = 2;
            this.labelDOB.Text = "*Date of Birth:";
            // 
            // labelAddress1
            // 
            this.labelAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress1.AutoSize = true;
            this.labelAddress1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress1.Location = new System.Drawing.Point(39, 177);
            this.labelAddress1.Name = "labelAddress1";
            this.labelAddress1.Size = new System.Drawing.Size(119, 23);
            this.labelAddress1.TabIndex = 4;
            this.labelAddress1.Text = "*Address 1:";
            // 
            // labelAddress2
            // 
            this.labelAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddress2.AutoSize = true;
            this.labelAddress2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress2.Location = new System.Drawing.Point(48, 227);
            this.labelAddress2.Name = "labelAddress2";
            this.labelAddress2.Size = new System.Drawing.Size(110, 23);
            this.labelAddress2.TabIndex = 5;
            this.labelAddress2.Text = "Address 2:";
            // 
            // labelCity
            // 
            this.labelCity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCity.Location = new System.Drawing.Point(97, 277);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(61, 23);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "*City:";
            // 
            // labelState
            // 
            this.labelState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelState.Location = new System.Drawing.Point(456, 277);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(75, 23);
            this.labelState.TabIndex = 7;
            this.labelState.Text = "*State:";
            // 
            // labelZipCode
            // 
            this.labelZipCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZipCode.AutoSize = true;
            this.labelZipCode.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelZipCode.Location = new System.Drawing.Point(45, 327);
            this.labelZipCode.Name = "labelZipCode";
            this.labelZipCode.Size = new System.Drawing.Size(113, 23);
            this.labelZipCode.TabIndex = 8;
            this.labelZipCode.Text = "*Zip Code:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSubmit.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(164, 362);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(178, 35);
            this.buttonSubmit.TabIndex = 23;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonClear, 2);
            this.buttonClear.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(475, 363);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(178, 34);
            this.buttonClear.TabIndex = 24;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFirstName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(164, 15);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(178, 32);
            this.textBoxFirstName.TabIndex = 11;
            this.textBoxFirstName.TextChanged += new System.EventHandler(this.TextBoxFirstName_TextChanged);
            // 
            // dateTimePickerDOB
            // 
            this.dateTimePickerDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateTimePickerDOB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDOB.Location = new System.Drawing.Point(164, 65);
            this.dateTimePickerDOB.Name = "dateTimePickerDOB";
            this.dateTimePickerDOB.Size = new System.Drawing.Size(178, 32);
            this.dateTimePickerDOB.TabIndex = 13;
            this.dateTimePickerDOB.ValueChanged += new System.EventHandler(this.DateTimePickerDOB_ValueChanged);
            // 
            // comboBoxState
            // 
            this.comboBoxState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxState.BackColor = System.Drawing.Color.White;
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxState.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "AK",
            "AL",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboBoxState.Location = new System.Drawing.Point(537, 266);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(94, 31);
            this.comboBoxState.TabIndex = 20;
            this.comboBoxState.SelectedIndexChanged += new System.EventHandler(this.ComboBoxState_SelectedIndexChanged);
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelErrorMessage, 3);
            this.labelErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(164, 400);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(0, 20);
            this.labelErrorMessage.TabIndex = 20;
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(64, 104);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(94, 46);
            this.labelPhone.TabIndex = 3;
            this.labelPhone.Text = "*Phone Number:";
            // 
            // labelSSN
            // 
            this.labelSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSSN.AutoSize = true;
            this.labelSSN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSSN.Location = new System.Drawing.Point(472, 77);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(59, 23);
            this.labelSSN.TabIndex = 23;
            this.labelSSN.Text = "*SSN:";
            // 
            // labelGender
            // 
            this.labelGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(432, 127);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(99, 23);
            this.labelGender.TabIndex = 24;
            this.labelGender.Text = "*Gender:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxGender.BackColor = System.Drawing.Color.White;
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboBoxGender.Location = new System.Drawing.Point(537, 116);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(94, 31);
            this.comboBoxGender.TabIndex = 16;
            this.comboBoxGender.SelectedIndexChanged += new System.EventHandler(this.ComboBoxGender_SelectedIndexChanged);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(164, 115);
            this.textBoxPhoneNumber.Mask = "(999) 000-0000";
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(117, 32);
            this.textBoxPhoneNumber.TabIndex = 15;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.TextBoxPhoneNumber_TextChanged);
            // 
            // textBoxSSN
            // 
            this.textBoxSSN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxSSN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSSN.Location = new System.Drawing.Point(537, 65);
            this.textBoxSSN.Mask = "000-00-0000";
            this.textBoxSSN.Name = "textBoxSSN";
            this.textBoxSSN.Size = new System.Drawing.Size(100, 32);
            this.textBoxSSN.TabIndex = 14;
            this.textBoxSSN.TextChanged += new System.EventHandler(this.TextBoxSSN_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.38024F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.41678F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.06685F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.03444F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxZipCode, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCity, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddress2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAddress1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLastName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFirstName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelLastName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDOB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAddress2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelCity, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelState, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelZipCode, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.buttonSubmit, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonClear, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePickerDOB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxState, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelErrorMessage, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelPhone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSSN, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGender, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxGender, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPhoneNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSSN, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRequiredField, 3, 9);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 534);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelRequiredField
            // 
            this.labelRequiredField.AutoSize = true;
            this.labelRequiredField.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequiredField.ForeColor = System.Drawing.Color.Maroon;
            this.labelRequiredField.Location = new System.Drawing.Point(537, 476);
            this.labelRequiredField.Name = "labelRequiredField";
            this.labelRequiredField.Size = new System.Drawing.Size(176, 17);
            this.labelRequiredField.TabIndex = 26;
            this.labelRequiredField.Text = "* Indicates required field";
            // 
            // AddStudentUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddStudentUserControl";
            this.Size = new System.Drawing.Size(760, 540);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddress2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxAddress1;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelAddress1;
        private System.Windows.Forms.Label labelAddress2;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelZipCode;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.DateTimePicker dateTimePickerDOB;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.MaskedTextBox textBoxPhoneNumber;
        private System.Windows.Forms.MaskedTextBox textBoxSSN;
        private System.Windows.Forms.Label labelRequiredField;
    }
}
