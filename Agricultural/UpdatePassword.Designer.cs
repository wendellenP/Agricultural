namespace Agricultural
{
    partial class Update_Password
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_Password));
            this.newPasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.confirmPasswordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showPassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.showConfirmPassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.hidePassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.hideConfirmPassword = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.errorMessage1 = new System.Windows.Forms.Label();
            this.errorMessage2 = new System.Windows.Forms.Label();
            this.backLogInLbl = new System.Windows.Forms.Label();
            this.SuccessfulMessage = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordTxt.DefaultText = "";
            this.newPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.newPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.newPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.newPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.newPasswordTxt.Location = new System.Drawing.Point(99, 131);
            this.newPasswordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.PasswordChar = '●';
            this.newPasswordTxt.PlaceholderText = "New Password";
            this.newPasswordTxt.SelectedText = "";
            this.newPasswordTxt.Size = new System.Drawing.Size(439, 68);
            this.newPasswordTxt.TabIndex = 0;
            this.newPasswordTxt.TextChanged += new System.EventHandler(this.newPasswordTxt_TextChanged);
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.confirmPasswordTxt.DefaultText = "";
            this.confirmPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.confirmPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.confirmPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.confirmPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.confirmPasswordTxt.Location = new System.Drawing.Point(99, 237);
            this.confirmPasswordTxt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.PasswordChar = '●';
            this.confirmPasswordTxt.PlaceholderText = "Confirm New Password";
            this.confirmPasswordTxt.SelectedText = "";
            this.confirmPasswordTxt.Size = new System.Drawing.Size(439, 68);
            this.confirmPasswordTxt.TabIndex = 1;
            this.confirmPasswordTxt.TextChanged += new System.EventHandler(this.confirmPasswordTxt_TextChanged);
            // 
            // updateBtn
            // 
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.Green;
            this.updateBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(99, 348);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(439, 45);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Save";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(131, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create New Password";
            // 
            // showPassword
            // 
            this.showPassword.Image = ((System.Drawing.Image)(resources.GetObject("showPassword.Image")));
            this.showPassword.ImageRotate = 0F;
            this.showPassword.Location = new System.Drawing.Point(480, 145);
            this.showPassword.Name = "showPassword";
            this.showPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showPassword.Size = new System.Drawing.Size(44, 37);
            this.showPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPassword.TabIndex = 29;
            this.showPassword.TabStop = false;
            this.showPassword.Click += new System.EventHandler(this.showPassword_Click);
            // 
            // showConfirmPassword
            // 
            this.showConfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("showConfirmPassword.Image")));
            this.showConfirmPassword.ImageRotate = 0F;
            this.showConfirmPassword.Location = new System.Drawing.Point(480, 255);
            this.showConfirmPassword.Name = "showConfirmPassword";
            this.showConfirmPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showConfirmPassword.Size = new System.Drawing.Size(44, 37);
            this.showConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showConfirmPassword.TabIndex = 30;
            this.showConfirmPassword.TabStop = false;
            this.showConfirmPassword.Click += new System.EventHandler(this.showConfirmPassword_Click);
            // 
            // hidePassword
            // 
            this.hidePassword.Image = ((System.Drawing.Image)(resources.GetObject("hidePassword.Image")));
            this.hidePassword.ImageRotate = 0F;
            this.hidePassword.Location = new System.Drawing.Point(480, 145);
            this.hidePassword.Name = "hidePassword";
            this.hidePassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.hidePassword.Size = new System.Drawing.Size(44, 37);
            this.hidePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePassword.TabIndex = 31;
            this.hidePassword.TabStop = false;
            this.hidePassword.Click += new System.EventHandler(this.hidePassword_Click);
            // 
            // hideConfirmPassword
            // 
            this.hideConfirmPassword.Image = ((System.Drawing.Image)(resources.GetObject("hideConfirmPassword.Image")));
            this.hideConfirmPassword.ImageRotate = 0F;
            this.hideConfirmPassword.Location = new System.Drawing.Point(480, 255);
            this.hideConfirmPassword.Name = "hideConfirmPassword";
            this.hideConfirmPassword.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.hideConfirmPassword.Size = new System.Drawing.Size(44, 37);
            this.hideConfirmPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hideConfirmPassword.TabIndex = 32;
            this.hideConfirmPassword.TabStop = false;
            this.hideConfirmPassword.Click += new System.EventHandler(this.hideConfirmPassword_Click);
            // 
            // errorMessage1
            // 
            this.errorMessage1.AutoSize = true;
            this.errorMessage1.ForeColor = System.Drawing.Color.Red;
            this.errorMessage1.Location = new System.Drawing.Point(99, 206);
            this.errorMessage1.Name = "errorMessage1";
            this.errorMessage1.Size = new System.Drawing.Size(92, 16);
            this.errorMessage1.TabIndex = 33;
            this.errorMessage1.Text = "errorMessage";
            // 
            // errorMessage2
            // 
            this.errorMessage2.AutoSize = true;
            this.errorMessage2.ForeColor = System.Drawing.Color.Red;
            this.errorMessage2.Location = new System.Drawing.Point(99, 312);
            this.errorMessage2.Name = "errorMessage2";
            this.errorMessage2.Size = new System.Drawing.Size(92, 16);
            this.errorMessage2.TabIndex = 34;
            this.errorMessage2.Text = "errorMessage";
            // 
            // backLogInLbl
            // 
            this.backLogInLbl.AutoSize = true;
            this.backLogInLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLogInLbl.Location = new System.Drawing.Point(244, 414);
            this.backLogInLbl.Name = "backLogInLbl";
            this.backLogInLbl.Size = new System.Drawing.Size(145, 20);
            this.backLogInLbl.TabIndex = 35;
            this.backLogInLbl.Text = "Back to log in form";
            this.backLogInLbl.Click += new System.EventHandler(this.backLogInLbl_Click);
            // 
            // SuccessfulMessage
            // 
            this.SuccessfulMessage.AllowDragging = false;
            this.SuccessfulMessage.AllowMultipleViews = true;
            this.SuccessfulMessage.ClickToClose = true;
            this.SuccessfulMessage.DoubleClickToClose = true;
            this.SuccessfulMessage.DurationAfterIdle = 3000;
            this.SuccessfulMessage.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.ErrorOptions.ActionBorderRadius = 1;
            this.SuccessfulMessage.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuccessfulMessage.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.SuccessfulMessage.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.SuccessfulMessage.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.SuccessfulMessage.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.SuccessfulMessage.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SuccessfulMessage.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.SuccessfulMessage.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.SuccessfulMessage.ErrorOptions.IconLeftMargin = 12;
            this.SuccessfulMessage.FadeCloseIcon = false;
            this.SuccessfulMessage.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.SuccessfulMessage.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.InformationOptions.ActionBorderRadius = 1;
            this.SuccessfulMessage.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuccessfulMessage.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.SuccessfulMessage.InformationOptions.BackColor = System.Drawing.Color.White;
            this.SuccessfulMessage.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.SuccessfulMessage.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SuccessfulMessage.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.SuccessfulMessage.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.SuccessfulMessage.InformationOptions.IconLeftMargin = 12;
            this.SuccessfulMessage.Margin = 10;
            this.SuccessfulMessage.MaximumSize = new System.Drawing.Size(0, 0);
            this.SuccessfulMessage.MaximumViews = 7;
            this.SuccessfulMessage.MessageRightMargin = 15;
            this.SuccessfulMessage.MessageTopMargin = 0;
            this.SuccessfulMessage.MinimumSize = new System.Drawing.Size(0, 0);
            this.SuccessfulMessage.ShowBorders = false;
            this.SuccessfulMessage.ShowCloseIcon = false;
            this.SuccessfulMessage.ShowIcon = true;
            this.SuccessfulMessage.ShowShadows = true;
            this.SuccessfulMessage.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.SuccessOptions.ActionBorderRadius = 1;
            this.SuccessfulMessage.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuccessfulMessage.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.SuccessfulMessage.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.SuccessfulMessage.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.SuccessfulMessage.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.SuccessfulMessage.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SuccessfulMessage.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.SuccessfulMessage.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.SuccessfulMessage.SuccessOptions.IconLeftMargin = 12;
            this.SuccessfulMessage.ViewsMargin = 7;
            this.SuccessfulMessage.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SuccessfulMessage.WarningOptions.ActionBorderRadius = 1;
            this.SuccessfulMessage.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.SuccessfulMessage.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.SuccessfulMessage.WarningOptions.BackColor = System.Drawing.Color.White;
            this.SuccessfulMessage.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.SuccessfulMessage.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.SuccessfulMessage.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SuccessfulMessage.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.SuccessfulMessage.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.SuccessfulMessage.WarningOptions.IconLeftMargin = 12;
            this.SuccessfulMessage.ZoomCloseIcon = true;
            // 
            // Update_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 470);
            this.Controls.Add(this.backLogInLbl);
            this.Controls.Add(this.errorMessage2);
            this.Controls.Add(this.errorMessage1);
            this.Controls.Add(this.hideConfirmPassword);
            this.Controls.Add(this.hidePassword);
            this.Controls.Add(this.showConfirmPassword);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.newPasswordTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Update_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update_Password";
            this.Load += new System.EventHandler(this.Update_Password_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideConfirmPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox newPasswordTxt;
        private Guna.UI2.WinForms.Guna2TextBox confirmPasswordTxt;
        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox showPassword;
        private Guna.UI2.WinForms.Guna2CirclePictureBox showConfirmPassword;
        private Guna.UI2.WinForms.Guna2CirclePictureBox hidePassword;
        private Guna.UI2.WinForms.Guna2CirclePictureBox hideConfirmPassword;
        private System.Windows.Forms.Label errorMessage1;
        private System.Windows.Forms.Label errorMessage2;
        private System.Windows.Forms.Label backLogInLbl;
        private Bunifu.UI.WinForms.BunifuSnackbar SuccessfulMessage;
    }
}