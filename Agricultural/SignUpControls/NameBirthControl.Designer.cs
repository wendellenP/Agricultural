namespace Agricultural.SignUpControls
{
    partial class NameBirthControl
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
            this.label4 = new System.Windows.Forms.Label();
            this.BirthDayPicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.LNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.MNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.FnameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fnameErrorMessage = new System.Windows.Forms.Label();
            this.lnameErrorMessage = new System.Windows.Forms.Label();
            this.invalidMessageFname = new System.Windows.Forms.Label();
            this.invalidMessageMname = new System.Windows.Forms.Label();
            this.invalidMessageLname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(87, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Birth Date";
            // 
            // BirthDayPicker
            // 
            this.BirthDayPicker.Checked = true;
            this.BirthDayPicker.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BirthDayPicker.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.BirthDayPicker.Location = new System.Drawing.Point(90, 389);
            this.BirthDayPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.BirthDayPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.BirthDayPicker.Name = "BirthDayPicker";
            this.BirthDayPicker.Size = new System.Drawing.Size(506, 56);
            this.BirthDayPicker.TabIndex = 22;
            this.BirthDayPicker.Value = new System.DateTime(2024, 9, 19, 15, 34, 23, 959);
            // 
            // LNameTxt
            // 
            this.LNameTxt.BorderColor = System.Drawing.Color.Silver;
            this.LNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LNameTxt.DefaultText = "";
            this.LNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LNameTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LNameTxt.Location = new System.Drawing.Point(90, 258);
            this.LNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.PasswordChar = '\0';
            this.LNameTxt.PlaceholderText = "Last_Name";
            this.LNameTxt.SelectedText = "";
            this.LNameTxt.Size = new System.Drawing.Size(506, 55);
            this.LNameTxt.TabIndex = 21;
            this.LNameTxt.TextChanged += new System.EventHandler(this.LNameTxt_TextChanged);
            // 
            // MNameTxt
            // 
            this.MNameTxt.BorderColor = System.Drawing.Color.Silver;
            this.MNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MNameTxt.DefaultText = "";
            this.MNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MNameTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MNameTxt.Location = new System.Drawing.Point(90, 174);
            this.MNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MNameTxt.Name = "MNameTxt";
            this.MNameTxt.PasswordChar = '\0';
            this.MNameTxt.PlaceholderText = "Middle Name (optional)";
            this.MNameTxt.SelectedText = "";
            this.MNameTxt.Size = new System.Drawing.Size(506, 55);
            this.MNameTxt.TabIndex = 20;
            // 
            // FnameTxt
            // 
            this.FnameTxt.BorderColor = System.Drawing.Color.Silver;
            this.FnameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FnameTxt.DefaultText = "";
            this.FnameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FnameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FnameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FnameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FnameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FnameTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FnameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FnameTxt.Location = new System.Drawing.Point(90, 82);
            this.FnameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.PasswordChar = '\0';
            this.FnameTxt.PlaceholderText = "First Name";
            this.FnameTxt.SelectedText = "";
            this.FnameTxt.Size = new System.Drawing.Size(506, 55);
            this.FnameTxt.TabIndex = 19;
            this.FnameTxt.TextChanged += new System.EventHandler(this.FnameTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(131, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 44);
            this.label3.TabIndex = 18;
            this.label3.Text = "Gumawa ng account";
            // 
            // fnameErrorMessage
            // 
            this.fnameErrorMessage.AutoSize = true;
            this.fnameErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.fnameErrorMessage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.fnameErrorMessage.Location = new System.Drawing.Point(87, 142);
            this.fnameErrorMessage.Name = "fnameErrorMessage";
            this.fnameErrorMessage.Size = new System.Drawing.Size(101, 17);
            this.fnameErrorMessage.TabIndex = 23;
            this.fnameErrorMessage.Text = "This is required!";
            // 
            // lnameErrorMessage
            // 
            this.lnameErrorMessage.AutoSize = true;
            this.lnameErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lnameErrorMessage.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lnameErrorMessage.Location = new System.Drawing.Point(88, 318);
            this.lnameErrorMessage.Name = "lnameErrorMessage";
            this.lnameErrorMessage.Size = new System.Drawing.Size(101, 17);
            this.lnameErrorMessage.TabIndex = 24;
            this.lnameErrorMessage.Text = "This is required!";
            // 
            // invalidMessageFname
            // 
            this.invalidMessageFname.AutoSize = true;
            this.invalidMessageFname.BackColor = System.Drawing.Color.Transparent;
            this.invalidMessageFname.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidMessageFname.ForeColor = System.Drawing.Color.Red;
            this.invalidMessageFname.Location = new System.Drawing.Point(87, 142);
            this.invalidMessageFname.Name = "invalidMessageFname";
            this.invalidMessageFname.Size = new System.Drawing.Size(237, 17);
            this.invalidMessageFname.TabIndex = 25;
            this.invalidMessageFname.Text = "Please provide you valid first name.";
            // 
            // invalidMessageMname
            // 
            this.invalidMessageMname.AutoSize = true;
            this.invalidMessageMname.BackColor = System.Drawing.Color.Transparent;
            this.invalidMessageMname.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidMessageMname.ForeColor = System.Drawing.Color.Red;
            this.invalidMessageMname.Location = new System.Drawing.Point(87, 234);
            this.invalidMessageMname.Name = "invalidMessageMname";
            this.invalidMessageMname.Size = new System.Drawing.Size(261, 17);
            this.invalidMessageMname.TabIndex = 26;
            this.invalidMessageMname.Text = "Please provide you valid middle name.";
            // 
            // invalidMessageLname
            // 
            this.invalidMessageLname.AutoSize = true;
            this.invalidMessageLname.BackColor = System.Drawing.Color.Transparent;
            this.invalidMessageLname.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidMessageLname.ForeColor = System.Drawing.Color.Red;
            this.invalidMessageLname.Location = new System.Drawing.Point(88, 318);
            this.invalidMessageLname.Name = "invalidMessageLname";
            this.invalidMessageLname.Size = new System.Drawing.Size(238, 17);
            this.invalidMessageLname.TabIndex = 27;
            this.invalidMessageLname.Text = "Please provide you valid last name.";
            // 
            // NameBirthControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.invalidMessageLname);
            this.Controls.Add(this.invalidMessageMname);
            this.Controls.Add(this.invalidMessageFname);
            this.Controls.Add(this.lnameErrorMessage);
            this.Controls.Add(this.fnameErrorMessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthDayPicker);
            this.Controls.Add(this.LNameTxt);
            this.Controls.Add(this.MNameTxt);
            this.Controls.Add(this.FnameTxt);
            this.Controls.Add(this.label3);
            this.Name = "NameBirthControl";
            this.Size = new System.Drawing.Size(686, 472);
            this.Load += new System.EventHandler(this.NameBirthControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DateTimePicker BirthDayPicker;
        private Guna.UI2.WinForms.Guna2TextBox LNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox MNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox FnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fnameErrorMessage;
        private System.Windows.Forms.Label lnameErrorMessage;
        private System.Windows.Forms.Label invalidMessageFname;
        private System.Windows.Forms.Label invalidMessageMname;
        private System.Windows.Forms.Label invalidMessageLname;
    }
}
