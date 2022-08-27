namespace User_Registration_Exercise_1
{
    partial class RegistrationFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationFrom));
            this.nameLabel = new System.Windows.Forms.Label();
            this.userRegistration = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton1 = new System.Windows.Forms.Button();
            this.termscheckBox = new System.Windows.Forms.CheckBox();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.genderRadioButton2 = new System.Windows.Forms.RadioButton();
            this.genderRadioButton1 = new System.Windows.Forms.RadioButton();
            this.dateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.bloodGroupLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.dateOfBrithLabel = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.userRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel.Location = new System.Drawing.Point(68, 86);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 19);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name: ";
            // 
            // userRegistration
            // 
            this.userRegistration.Controls.Add(this.label1);
            this.userRegistration.Controls.Add(this.submitButton1);
            this.userRegistration.Controls.Add(this.termscheckBox);
            this.userRegistration.Controls.Add(this.bloodGroupComboBox);
            this.userRegistration.Controls.Add(this.genderRadioButton2);
            this.userRegistration.Controls.Add(this.genderRadioButton1);
            this.userRegistration.Controls.Add(this.dateOfBirthDatePicker);
            this.userRegistration.Controls.Add(this.bloodGroupLabel);
            this.userRegistration.Controls.Add(this.genderLabel);
            this.userRegistration.Controls.Add(this.dateOfBrithLabel);
            this.userRegistration.Controls.Add(this.userNameTextBox);
            this.userRegistration.Controls.Add(this.usernameLabel);
            this.userRegistration.Controls.Add(this.emailTextBox);
            this.userRegistration.Controls.Add(this.emailLabel);
            this.userRegistration.Controls.Add(this.passwordTextBox);
            this.userRegistration.Controls.Add(this.passwordLabel);
            this.userRegistration.Controls.Add(this.confirmPasswordTextBox);
            this.userRegistration.Controls.Add(this.confirmPasswordLabel);
            this.userRegistration.Controls.Add(this.nameTextBox);
            this.userRegistration.Controls.Add(this.nameLabel);
            this.userRegistration.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRegistration.Location = new System.Drawing.Point(51, 34);
            this.userRegistration.Name = "userRegistration";
            this.userRegistration.Size = new System.Drawing.Size(719, 740);
            this.userRegistration.TabIndex = 1;
            this.userRegistration.TabStop = false;
            this.userRegistration.Text = " ";
            this.userRegistration.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(719, 46);
            this.label1.TabIndex = 32;
            this.label1.Text = "Registration";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton1
            // 
            this.submitButton1.Enabled = false;
            this.submitButton1.Location = new System.Drawing.Point(287, 663);
            this.submitButton1.Name = "submitButton1";
            this.submitButton1.Size = new System.Drawing.Size(89, 38);
            this.submitButton1.TabIndex = 31;
            this.submitButton1.Text = "Submit";
            this.submitButton1.UseVisualStyleBackColor = true;
            this.submitButton1.Click += new System.EventHandler(this.submitButton1_Click);
            // 
            // termscheckBox
            // 
            this.termscheckBox.AutoSize = true;
            this.termscheckBox.Location = new System.Drawing.Point(69, 579);
            this.termscheckBox.Name = "termscheckBox";
            this.termscheckBox.Size = new System.Drawing.Size(293, 23);
            this.termscheckBox.TabIndex = 30;
            this.termscheckBox.Text = "I agree all the terms and conditions.";
            this.termscheckBox.UseVisualStyleBackColor = true;
            this.termscheckBox.CheckedChanged += new System.EventHandler(this.termsheckBox_CheckedChanged);
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A-",
            "A+",
            "AB-",
            "AB+",
            "B-",
            "B+",
            "O-",
            "O+"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(273, 496);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(353, 27);
            this.bloodGroupComboBox.Sorted = true;
            this.bloodGroupComboBox.TabIndex = 29;
            // 
            // genderRadioButton2
            // 
            this.genderRadioButton2.AutoSize = true;
            this.genderRadioButton2.Location = new System.Drawing.Point(432, 435);
            this.genderRadioButton2.Name = "genderRadioButton2";
            this.genderRadioButton2.Size = new System.Drawing.Size(82, 23);
            this.genderRadioButton2.TabIndex = 28;
            this.genderRadioButton2.TabStop = true;
            this.genderRadioButton2.Text = "Female";
            this.genderRadioButton2.UseVisualStyleBackColor = true;
            // 
            // genderRadioButton1
            // 
            this.genderRadioButton1.AutoSize = true;
            this.genderRadioButton1.Location = new System.Drawing.Point(273, 438);
            this.genderRadioButton1.Name = "genderRadioButton1";
            this.genderRadioButton1.Size = new System.Drawing.Size(65, 23);
            this.genderRadioButton1.TabIndex = 27;
            this.genderRadioButton1.TabStop = true;
            this.genderRadioButton1.Text = "Male";
            this.genderRadioButton1.UseVisualStyleBackColor = true;
            // 
            // dateOfBirthDatePicker
            // 
            this.dateOfBirthDatePicker.Location = new System.Drawing.Point(273, 364);
            this.dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
            this.dateOfBirthDatePicker.Size = new System.Drawing.Size(353, 27);
            this.dateOfBirthDatePicker.TabIndex = 26;
            // 
            // bloodGroupLabel
            // 
            this.bloodGroupLabel.AutoSize = true;
            this.bloodGroupLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bloodGroupLabel.Location = new System.Drawing.Point(65, 499);
            this.bloodGroupLabel.Name = "bloodGroupLabel";
            this.bloodGroupLabel.Size = new System.Drawing.Size(117, 19);
            this.bloodGroupLabel.TabIndex = 22;
            this.bloodGroupLabel.Text = "Blood Group: ";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.genderLabel.Location = new System.Drawing.Point(68, 435);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(75, 19);
            this.genderLabel.TabIndex = 20;
            this.genderLabel.Text = "Gender: ";
            // 
            // dateOfBrithLabel
            // 
            this.dateOfBrithLabel.AutoSize = true;
            this.dateOfBrithLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.dateOfBrithLabel.Location = new System.Drawing.Point(68, 370);
            this.dateOfBrithLabel.Name = "dateOfBrithLabel";
            this.dateOfBrithLabel.Size = new System.Drawing.Size(110, 19);
            this.dateOfBrithLabel.TabIndex = 18;
            this.dateOfBrithLabel.Text = "Date Of Birth";
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(273, 128);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(353, 27);
            this.userNameTextBox.TabIndex = 17;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLabel.Location = new System.Drawing.Point(65, 136);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(93, 19);
            this.usernameLabel.TabIndex = 16;
            this.usernameLabel.Text = "Username: ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(273, 182);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(353, 27);
            this.emailTextBox.TabIndex = 15;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.emailLabel.Location = new System.Drawing.Point(65, 190);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(64, 19);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email: ";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(273, 234);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(353, 27);
            this.passwordTextBox.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLabel.Location = new System.Drawing.Point(67, 242);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(91, 19);
            this.passwordLabel.TabIndex = 12;
            this.passwordLabel.Text = "Password: ";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(273, 285);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(353, 27);
            this.confirmPasswordTextBox.TabIndex = 11;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(67, 293);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(158, 19);
            this.confirmPasswordLabel.TabIndex = 10;
            this.confirmPasswordLabel.Text = "Confirm Password: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(273, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(353, 27);
            this.nameTextBox.TabIndex = 1;
            // 
            // RegistrationFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(817, 825);
            this.Controls.Add(this.userRegistration);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RegistrationFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.userRegistration.ResumeLayout(false);
            this.userRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox userRegistration;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.RadioButton genderRadioButton2;
        private System.Windows.Forms.RadioButton genderRadioButton1;
        private System.Windows.Forms.DateTimePicker dateOfBirthDatePicker;
        private System.Windows.Forms.Label bloodGroupLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.Label dateOfBrithLabel;
        private System.Windows.Forms.Button submitButton1;
        private System.Windows.Forms.CheckBox termscheckBox;
        private System.Windows.Forms.Label label1;
    }
}

