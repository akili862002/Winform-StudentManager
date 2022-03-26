namespace StudentManager
{
    partial class AddStudentForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.firstNameTextField = new StudentManager.CusTextField();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastNameTextField = new StudentManager.CusTextField();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.famaleRadio = new System.Windows.Forms.RadioButton();
            this.phoneNumberTextField = new StudentManager.CusTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.addressTextField = new StudentManager.CusTextField();
            this.addressLabel = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.Label();
            this.avatarPicture = new System.Windows.Forms.PictureBox();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.birthdateDatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // firstNameTextField
            // 
            this.firstNameTextField.BackColor = System.Drawing.Color.White;
            this.firstNameTextField.BorderColor = System.Drawing.Color.Gray;
            this.firstNameTextField.BorderFocusColor = System.Drawing.Color.Black;
            this.firstNameTextField.BorderSize = 2;
            this.firstNameTextField.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextField.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextField.Location = new System.Drawing.Point(24, 47);
            this.firstNameTextField.Multiline = false;
            this.firstNameTextField.Name = "firstNameTextField";
            this.firstNameTextField.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.firstNameTextField.PasswordChar = false;
            this.firstNameTextField.Size = new System.Drawing.Size(185, 46);
            this.firstNameTextField.TabIndex = 15;
            this.firstNameTextField.Texts = "";
            this.firstNameTextField.UnderlinedStyle = false;
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstnameLabel.Location = new System.Drawing.Point(24, 21);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(127, 23);
            this.firstnameLabel.TabIndex = 14;
            this.firstnameLabel.Text = "First Name";
            // 
            // lastNameTextField
            // 
            this.lastNameTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameTextField.BackColor = System.Drawing.Color.White;
            this.lastNameTextField.BorderColor = System.Drawing.Color.Gray;
            this.lastNameTextField.BorderFocusColor = System.Drawing.Color.Black;
            this.lastNameTextField.BorderSize = 2;
            this.lastNameTextField.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextField.ForeColor = System.Drawing.Color.Black;
            this.lastNameTextField.Location = new System.Drawing.Point(222, 47);
            this.lastNameTextField.Multiline = false;
            this.lastNameTextField.Name = "lastNameTextField";
            this.lastNameTextField.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.lastNameTextField.PasswordChar = false;
            this.lastNameTextField.Size = new System.Drawing.Size(239, 46);
            this.lastNameTextField.TabIndex = 17;
            this.lastNameTextField.Texts = "";
            this.lastNameTextField.UnderlinedStyle = false;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.Location = new System.Drawing.Point(222, 21);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(127, 23);
            this.lastnameLabel.TabIndex = 16;
            this.lastnameLabel.Text = "Last Name";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdateLabel.Location = new System.Drawing.Point(24, 112);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(127, 23);
            this.birthdateLabel.TabIndex = 18;
            this.birthdateLabel.Text = "Birth Date";
            // 
            // genderLabel
            // 
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(24, 181);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(127, 23);
            this.genderLabel.TabIndex = 21;
            this.genderLabel.Text = "Gender";
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Location = new System.Drawing.Point(32, 207);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(63, 24);
            this.maleRadio.TabIndex = 22;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // famaleRadio
            // 
            this.famaleRadio.AutoSize = true;
            this.famaleRadio.Location = new System.Drawing.Point(111, 207);
            this.famaleRadio.Name = "famaleRadio";
            this.famaleRadio.Size = new System.Drawing.Size(77, 24);
            this.famaleRadio.TabIndex = 23;
            this.famaleRadio.TabStop = true;
            this.famaleRadio.Text = "Famale";
            this.famaleRadio.UseVisualStyleBackColor = true;
            // 
            // phoneNumberTextField
            // 
            this.phoneNumberTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextField.BackColor = System.Drawing.Color.White;
            this.phoneNumberTextField.BorderColor = System.Drawing.Color.Gray;
            this.phoneNumberTextField.BorderFocusColor = System.Drawing.Color.Black;
            this.phoneNumberTextField.BorderSize = 2;
            this.phoneNumberTextField.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phoneNumberTextField.ForeColor = System.Drawing.Color.Black;
            this.phoneNumberTextField.Location = new System.Drawing.Point(24, 270);
            this.phoneNumberTextField.Multiline = false;
            this.phoneNumberTextField.Name = "phoneNumberTextField";
            this.phoneNumberTextField.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.phoneNumberTextField.PasswordChar = false;
            this.phoneNumberTextField.Size = new System.Drawing.Size(437, 46);
            this.phoneNumberTextField.TabIndex = 25;
            this.phoneNumberTextField.Texts = "";
            this.phoneNumberTextField.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Phone number";
            // 
            // addressTextField
            // 
            this.addressTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addressTextField.BackColor = System.Drawing.Color.White;
            this.addressTextField.BorderColor = System.Drawing.Color.Gray;
            this.addressTextField.BorderFocusColor = System.Drawing.Color.Black;
            this.addressTextField.BorderSize = 2;
            this.addressTextField.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressTextField.ForeColor = System.Drawing.Color.Black;
            this.addressTextField.Location = new System.Drawing.Point(24, 360);
            this.addressTextField.Multiline = true;
            this.addressTextField.Name = "addressTextField";
            this.addressTextField.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.addressTextField.PasswordChar = false;
            this.addressTextField.Size = new System.Drawing.Size(437, 90);
            this.addressTextField.TabIndex = 27;
            this.addressTextField.Texts = "";
            this.addressTextField.UnderlinedStyle = false;
            this.addressTextField.Load += new System.EventHandler(this.cusTextField5_Load);
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(24, 334);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(127, 23);
            this.addressLabel.TabIndex = 26;
            this.addressLabel.Text = "Address";
            this.addressLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // picture
            // 
            this.picture.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.picture.Location = new System.Drawing.Point(24, 475);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(127, 23);
            this.picture.TabIndex = 28;
            this.picture.Text = "Picture";
            // 
            // avatarPicture
            // 
            this.avatarPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPicture.Image = global::StudentManager.Properties.Resources.avatar;
            this.avatarPicture.InitialImage = global::StudentManager.Properties.Resources.avatar;
            this.avatarPicture.Location = new System.Drawing.Point(24, 501);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(200, 200);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPicture.TabIndex = 29;
            this.avatarPicture.TabStop = false;
            this.avatarPicture.WaitOnLoad = true;
            this.avatarPicture.Click += new System.EventHandler(this.avatarPicture_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.createButton.BackColor = System.Drawing.Color.Black;
            this.createButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createButton.ForeColor = System.Drawing.Color.White;
            this.createButton.Location = new System.Drawing.Point(329, 747);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(132, 50);
            this.createButton.TabIndex = 30;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(182, 747);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cancelButton.Size = new System.Drawing.Size(132, 50);
            this.cancelButton.TabIndex = 31;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // birthdateDatePicker
            // 
            this.birthdateDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdateDatePicker.CalendarForeColor = System.Drawing.Color.Coral;
            this.birthdateDatePicker.CalendarTitleBackColor = System.Drawing.Color.Transparent;
            this.birthdateDatePicker.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.birthdateDatePicker.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthdateDatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.birthdateDatePicker.Location = new System.Drawing.Point(24, 138);
            this.birthdateDatePicker.Name = "birthdateDatePicker";
            this.birthdateDatePicker.Size = new System.Drawing.Size(437, 27);
            this.birthdateDatePicker.TabIndex = 20;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 813);
            this.Controls.Add(this.birthdateDatePicker);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.avatarPicture);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.addressTextField);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberTextField);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.famaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.lastNameTextField);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstNameTextField);
            this.Controls.Add(this.firstnameLabel);
            this.MinimumSize = new System.Drawing.Size(500, 54);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add student form";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog1;
        private CusTextField firstNameTextField;
        private Label firstnameLabel;
        private CusTextField lastNameTextField;
        private Label lastnameLabel;
        private Label birthdateLabel;
        private Label genderLabel;
        private RadioButton maleRadio;
        private RadioButton famaleRadio;
        private CusTextField phoneNumberTextField;
        private Label label5;
        private CusTextField addressTextField;
        private Label addressLabel;
        private Label picture;
        private PictureBox avatarPicture;
        private Button createButton;
        private Button cancelButton;
        private DateTimePicker birthdateDatePicker;
    }
}