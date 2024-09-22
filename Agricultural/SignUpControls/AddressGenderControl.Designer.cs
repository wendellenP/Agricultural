namespace Agricultural.SignUpControls
{
    partial class AddressGenderControl
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
            this.AddressTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.genderFemale = new System.Windows.Forms.RadioButton();
            this.genderOthers = new System.Windows.Forms.RadioButton();
            this.genderMale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.PhoneNumberTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailAddressTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.addressErrorMessage = new System.Windows.Forms.Label();
            this.phoneNumberErrorMessage = new System.Windows.Forms.Label();
            this.emailErrorMessage = new System.Windows.Forms.Label();
            this.invalidMessagePhoneNumber = new System.Windows.Forms.Label();
            this.invalidMessageEmail = new System.Windows.Forms.Label();
            this.boxGender = new System.Windows.Forms.GroupBox();
            this.otherGender = new System.Windows.Forms.RadioButton();
            this.maleGender = new System.Windows.Forms.RadioButton();
            this.femaleGender = new System.Windows.Forms.RadioButton();
            this.boxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddressTxt
            // 
            this.AddressTxt.BorderColor = System.Drawing.Color.Silver;
            this.AddressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressTxt.DefaultText = "";
            this.AddressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressTxt.Location = new System.Drawing.Point(90, 185);
            this.AddressTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressTxt.Name = "AddressTxt";
            this.AddressTxt.PasswordChar = '\0';
            this.AddressTxt.PlaceholderText = "Address";
            this.AddressTxt.SelectedText = "";
            this.AddressTxt.Size = new System.Drawing.Size(506, 55);
            this.AddressTxt.TabIndex = 20;
            this.AddressTxt.TextChanged += new System.EventHandler(this.AddressTxt_TextChanged);
            // 
            // genderFemale
            // 
            this.genderFemale.AutoSize = true;
            this.genderFemale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderFemale.Location = new System.Drawing.Point(50, 21);
            this.genderFemale.Name = "genderFemale";
            this.genderFemale.Size = new System.Drawing.Size(106, 27);
            this.genderFemale.TabIndex = 55;
            this.genderFemale.TabStop = true;
            this.genderFemale.Text = "Famale";
            this.genderFemale.UseVisualStyleBackColor = true;
            // 
            // genderOthers
            // 
            this.genderOthers.AutoSize = true;
            this.genderOthers.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderOthers.Location = new System.Drawing.Point(318, 21);
            this.genderOthers.Name = "genderOthers";
            this.genderOthers.Size = new System.Drawing.Size(94, 27);
            this.genderOthers.TabIndex = 56;
            this.genderOthers.TabStop = true;
            this.genderOthers.Text = "Others";
            this.genderOthers.UseVisualStyleBackColor = true;
            // 
            // genderMale
            // 
            this.genderMale.AutoSize = true;
            this.genderMale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderMale.Location = new System.Drawing.Point(190, 21);
            this.genderMale.Name = "genderMale";
            this.genderMale.Size = new System.Drawing.Size(80, 27);
            this.genderMale.TabIndex = 53;
            this.genderMale.TabStop = true;
            this.genderMale.Text = "Male";
            this.genderMale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(89, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 23);
            this.label8.TabIndex = 58;
            this.label8.Text = "Gender";
            // 
            // PhoneNumberTxt
            // 
            this.PhoneNumberTxt.BorderColor = System.Drawing.Color.Silver;
            this.PhoneNumberTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhoneNumberTxt.DefaultText = "";
            this.PhoneNumberTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PhoneNumberTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PhoneNumberTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PhoneNumberTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PhoneNumberTxt.Location = new System.Drawing.Point(90, 279);
            this.PhoneNumberTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PhoneNumberTxt.Name = "PhoneNumberTxt";
            this.PhoneNumberTxt.PasswordChar = '\0';
            this.PhoneNumberTxt.PlaceholderText = "Phone Number";
            this.PhoneNumberTxt.SelectedText = "";
            this.PhoneNumberTxt.Size = new System.Drawing.Size(506, 55);
            this.PhoneNumberTxt.TabIndex = 60;
            this.PhoneNumberTxt.TextChanged += new System.EventHandler(this.PhoneNumberTxt_TextChanged);
            // 
            // EmailAddressTxt
            // 
            this.EmailAddressTxt.BorderColor = System.Drawing.Color.Silver;
            this.EmailAddressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailAddressTxt.DefaultText = "";
            this.EmailAddressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailAddressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailAddressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailAddressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailAddressTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailAddressTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailAddressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailAddressTxt.Location = new System.Drawing.Point(93, 374);
            this.EmailAddressTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailAddressTxt.Name = "EmailAddressTxt";
            this.EmailAddressTxt.PasswordChar = '\0';
            this.EmailAddressTxt.PlaceholderText = "Email Address";
            this.EmailAddressTxt.SelectedText = "";
            this.EmailAddressTxt.Size = new System.Drawing.Size(506, 55);
            this.EmailAddressTxt.TabIndex = 61;
            this.EmailAddressTxt.TextChanged += new System.EventHandler(this.EmailAddressTxt_TextChanged);
            // 
            // addressErrorMessage
            // 
            this.addressErrorMessage.AutoSize = true;
            this.addressErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.addressErrorMessage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.addressErrorMessage.Location = new System.Drawing.Point(90, 245);
            this.addressErrorMessage.Name = "addressErrorMessage";
            this.addressErrorMessage.Size = new System.Drawing.Size(101, 17);
            this.addressErrorMessage.TabIndex = 63;
            this.addressErrorMessage.Text = "This is required!";
            // 
            // phoneNumberErrorMessage
            // 
            this.phoneNumberErrorMessage.AutoSize = true;
            this.phoneNumberErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberErrorMessage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.phoneNumberErrorMessage.Location = new System.Drawing.Point(90, 338);
            this.phoneNumberErrorMessage.Name = "phoneNumberErrorMessage";
            this.phoneNumberErrorMessage.Size = new System.Drawing.Size(101, 17);
            this.phoneNumberErrorMessage.TabIndex = 64;
            this.phoneNumberErrorMessage.Text = "This is required!";
            // 
            // emailErrorMessage
            // 
            this.emailErrorMessage.AutoSize = true;
            this.emailErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.emailErrorMessage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.emailErrorMessage.Location = new System.Drawing.Point(90, 433);
            this.emailErrorMessage.Name = "emailErrorMessage";
            this.emailErrorMessage.Size = new System.Drawing.Size(101, 17);
            this.emailErrorMessage.TabIndex = 65;
            this.emailErrorMessage.Text = "This is required!";
            // 
            // invalidMessagePhoneNumber
            // 
            this.invalidMessagePhoneNumber.AutoSize = true;
            this.invalidMessagePhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.invalidMessagePhoneNumber.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidMessagePhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.invalidMessagePhoneNumber.Location = new System.Drawing.Point(90, 339);
            this.invalidMessagePhoneNumber.Name = "invalidMessagePhoneNumber";
            this.invalidMessagePhoneNumber.Size = new System.Drawing.Size(252, 17);
            this.invalidMessagePhoneNumber.TabIndex = 68;
            this.invalidMessagePhoneNumber.Text = "Please provide a valid phone number";
            // 
            // invalidMessageEmail
            // 
            this.invalidMessageEmail.AutoSize = true;
            this.invalidMessageEmail.BackColor = System.Drawing.Color.Transparent;
            this.invalidMessageEmail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidMessageEmail.ForeColor = System.Drawing.Color.Red;
            this.invalidMessageEmail.Location = new System.Drawing.Point(90, 434);
            this.invalidMessageEmail.Name = "invalidMessageEmail";
            this.invalidMessageEmail.Size = new System.Drawing.Size(236, 17);
            this.invalidMessageEmail.TabIndex = 69;
            this.invalidMessageEmail.Text = "Please provide valid email address.";
            // 
            // boxGender
            // 
            this.boxGender.Controls.Add(this.otherGender);
            this.boxGender.Controls.Add(this.maleGender);
            this.boxGender.Controls.Add(this.femaleGender);
            this.boxGender.Location = new System.Drawing.Point(90, 89);
            this.boxGender.Name = "boxGender";
            this.boxGender.Size = new System.Drawing.Size(509, 68);
            this.boxGender.TabIndex = 70;
            this.boxGender.TabStop = false;
            // 
            // otherGender
            // 
            this.otherGender.AutoSize = true;
            this.otherGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherGender.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.otherGender.Location = new System.Drawing.Point(345, 21);
            this.otherGender.Name = "otherGender";
            this.otherGender.Size = new System.Drawing.Size(94, 27);
            this.otherGender.TabIndex = 73;
            this.otherGender.TabStop = true;
            this.otherGender.Text = "Others";
            this.otherGender.UseVisualStyleBackColor = true;
            // 
            // maleGender
            // 
            this.maleGender.AutoSize = true;
            this.maleGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maleGender.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.maleGender.Location = new System.Drawing.Point(206, 21);
            this.maleGender.Name = "maleGender";
            this.maleGender.Size = new System.Drawing.Size(80, 27);
            this.maleGender.TabIndex = 72;
            this.maleGender.TabStop = true;
            this.maleGender.Text = "Male";
            this.maleGender.UseVisualStyleBackColor = true;
            // 
            // femaleGender
            // 
            this.femaleGender.AutoSize = true;
            this.femaleGender.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femaleGender.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.femaleGender.Location = new System.Drawing.Point(48, 21);
            this.femaleGender.Name = "femaleGender";
            this.femaleGender.Size = new System.Drawing.Size(105, 27);
            this.femaleGender.TabIndex = 71;
            this.femaleGender.TabStop = true;
            this.femaleGender.Text = "Female";
            this.femaleGender.UseVisualStyleBackColor = true;
            // 
            // AddressGenderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.boxGender);
            this.Controls.Add(this.invalidMessageEmail);
            this.Controls.Add(this.invalidMessagePhoneNumber);
            this.Controls.Add(this.emailErrorMessage);
            this.Controls.Add(this.phoneNumberErrorMessage);
            this.Controls.Add(this.addressErrorMessage);
            this.Controls.Add(this.EmailAddressTxt);
            this.Controls.Add(this.PhoneNumberTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AddressTxt);
            this.Name = "AddressGenderControl";
            this.Size = new System.Drawing.Size(686, 472);
            this.boxGender.ResumeLayout(false);
            this.boxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox AddressTxt;
        private System.Windows.Forms.RadioButton genderOthers;
        private System.Windows.Forms.RadioButton genderMale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton genderFemale;
        private Guna.UI2.WinForms.Guna2TextBox PhoneNumberTxt;
        private Guna.UI2.WinForms.Guna2TextBox EmailAddressTxt;
        private System.Windows.Forms.Label addressErrorMessage;
        private System.Windows.Forms.Label phoneNumberErrorMessage;
        private System.Windows.Forms.Label emailErrorMessage;
        private System.Windows.Forms.Label invalidMessagePhoneNumber;
        private System.Windows.Forms.Label invalidMessageEmail;
        private System.Windows.Forms.GroupBox boxGender;
        private System.Windows.Forms.RadioButton otherGender;
        private System.Windows.Forms.RadioButton maleGender;
        private System.Windows.Forms.RadioButton femaleGender;
    }
}
