namespace StudentManager
{
    partial class EditOrRemoveForm
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
            this.birthdateDatePicker = new System.Windows.Forms.DateTimePicker();
            this.avatarPicture = new System.Windows.Forms.PictureBox();
            this.avatarLabel = new System.Windows.Forms.Label();
            this.addressTextField = new StudentManager.CusTextField();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberTextField = new StudentManager.CusTextField();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.famaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.genderLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.lastNameTextField = new StudentManager.CusTextField();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.firstNameTextField = new StudentManager.CusTextField();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).BeginInit();
            this.SuspendLayout();
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
            this.birthdateDatePicker.Location = new System.Drawing.Point(12, 134);
            this.birthdateDatePicker.Name = "birthdateDatePicker";
            this.birthdateDatePicker.Size = new System.Drawing.Size(522, 27);
            this.birthdateDatePicker.TabIndex = 37;
            // 
            // avatarPicture
            // 
            this.avatarPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avatarPicture.Image = global::StudentManager.Properties.Resources.avatar;
            this.avatarPicture.InitialImage = global::StudentManager.Properties.Resources.avatar;
            this.avatarPicture.Location = new System.Drawing.Point(12, 497);
            this.avatarPicture.Name = "avatarPicture";
            this.avatarPicture.Size = new System.Drawing.Size(200, 200);
            this.avatarPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatarPicture.TabIndex = 46;
            this.avatarPicture.TabStop = false;
            this.avatarPicture.WaitOnLoad = true;
            // 
            // avatarLabel
            // 
            this.avatarLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.avatarLabel.Location = new System.Drawing.Point(12, 462);
            this.avatarLabel.Name = "avatarLabel";
            this.avatarLabel.Size = new System.Drawing.Size(301, 23);
            this.avatarLabel.TabIndex = 45;
            this.avatarLabel.Text = "Picture";
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
            this.addressTextField.Location = new System.Drawing.Point(12, 356);
            this.addressTextField.Multiline = true;
            this.addressTextField.Name = "addressTextField";
            this.addressTextField.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.addressTextField.PasswordChar = false;
            this.addressTextField.Size = new System.Drawing.Size(522, 90);
            this.addressTextField.TabIndex = 44;
            this.addressTextField.Texts = "";
            this.addressTextField.UnderlinedStyle = false;
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addressLabel.Location = new System.Drawing.Point(12, 330);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(301, 23);
            this.addressLabel.TabIndex = 43;
            this.addressLabel.Text = "Address";
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
            this.phoneNumberTextField.Location = new System.Drawing.Point(12, 266);
            this.phoneNumberTextField.Multiline = false;
            this.phoneNumberTextField.Name = "phoneNumberTextField";
            this.phoneNumberTextField.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.phoneNumberTextField.PasswordChar = false;
            this.phoneNumberTextField.Size = new System.Drawing.Size(522, 46);
            this.phoneNumberTextField.TabIndex = 42;
            this.phoneNumberTextField.Texts = "";
            this.phoneNumberTextField.UnderlinedStyle = false;
            // 
            // phoneLabel
            // 
            this.phoneLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.phoneLabel.Location = new System.Drawing.Point(12, 240);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(301, 23);
            this.phoneLabel.TabIndex = 41;
            this.phoneLabel.Text = "Phone number";
            // 
            // famaleRadio
            // 
            this.famaleRadio.AutoSize = true;
            this.famaleRadio.Location = new System.Drawing.Point(99, 203);
            this.famaleRadio.Name = "famaleRadio";
            this.famaleRadio.Size = new System.Drawing.Size(77, 24);
            this.famaleRadio.TabIndex = 40;
            this.famaleRadio.TabStop = true;
            this.famaleRadio.Text = "Famale";
            this.famaleRadio.UseVisualStyleBackColor = true;
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.Checked = true;
            this.maleRadio.Location = new System.Drawing.Point(20, 203);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(63, 24);
            this.maleRadio.TabIndex = 39;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            // 
            // genderLabel
            // 
            this.genderLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genderLabel.Location = new System.Drawing.Point(12, 177);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(301, 23);
            this.genderLabel.TabIndex = 38;
            this.genderLabel.Text = "Gender";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.birthdateLabel.Location = new System.Drawing.Point(12, 108);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(301, 23);
            this.birthdateLabel.TabIndex = 36;
            this.birthdateLabel.Text = "Birth Date";
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
            this.lastNameTextField.Location = new System.Drawing.Point(247, 43);
            this.lastNameTextField.Multiline = false;
            this.lastNameTextField.Name = "lastNameTextField";
            this.lastNameTextField.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.lastNameTextField.PasswordChar = false;
            this.lastNameTextField.Size = new System.Drawing.Size(287, 46);
            this.lastNameTextField.TabIndex = 35;
            this.lastNameTextField.Texts = "";
            this.lastNameTextField.UnderlinedStyle = false;
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastnameLabel.Location = new System.Drawing.Point(247, 17);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(104, 23);
            this.lastnameLabel.TabIndex = 34;
            this.lastnameLabel.Text = "Last Name";
            // 
            // firstNameTextField
            // 
            this.firstNameTextField.BackColor = System.Drawing.Color.White;
            this.firstNameTextField.BorderColor = System.Drawing.Color.Gray;
            this.firstNameTextField.BorderFocusColor = System.Drawing.Color.Black;
            this.firstNameTextField.BorderSize = 2;
            this.firstNameTextField.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextField.ForeColor = System.Drawing.Color.Black;
            this.firstNameTextField.Location = new System.Drawing.Point(12, 43);
            this.firstNameTextField.Multiline = false;
            this.firstNameTextField.Name = "firstNameTextField";
            this.firstNameTextField.Padding = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.firstNameTextField.PasswordChar = false;
            this.firstNameTextField.Size = new System.Drawing.Size(218, 46);
            this.firstNameTextField.TabIndex = 33;
            this.firstNameTextField.Texts = "";
            this.firstNameTextField.UnderlinedStyle = false;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.Location = new System.Drawing.Point(12, 17);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(107, 23);
            this.firstNameLabel.TabIndex = 32;
            this.firstNameLabel.Text = "First Name";
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.ForeColor = System.Drawing.Color.Red;
            this.deleteButton.Location = new System.Drawing.Point(247, 738);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.deleteButton.Size = new System.Drawing.Size(132, 50);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.updateButton.BackColor = System.Drawing.Color.Black;
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(398, 738);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(132, 50);
            this.updateButton.TabIndex = 47;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // EditOrRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(546, 801);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.birthdateDatePicker);
            this.Controls.Add(this.avatarPicture);
            this.Controls.Add(this.avatarLabel);
            this.Controls.Add(this.addressTextField);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phoneNumberTextField);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.famaleRadio);
            this.Controls.Add(this.maleRadio);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.lastNameTextField);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstNameTextField);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "EditOrRemoveForm";
            this.Text = "Edit or remove student";
            this.Load += new System.EventHandler(this.EditOrRemoveForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avatarPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker birthdateDatePicker;
        private PictureBox avatarPicture;
        private Label avatarLabel;
        private CusTextField addressTextField;
        private Label addressLabel;
        private CusTextField phoneNumberTextField;
        private Label phoneLabel;
        private RadioButton famaleRadio;
        private RadioButton maleRadio;
        private Label genderLabel;
        private Label birthdateLabel;
        private CusTextField lastNameTextField;
        private Label lastnameLabel;
        private CusTextField firstNameTextField;
        private Label firstNameLabel;
        private Button deleteButton;
        private Button updateButton;
    }
}