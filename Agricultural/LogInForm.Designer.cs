namespace Agricultural
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.closeCtrl = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SignUpBtnPanel = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logInPanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.forgotPasswordLbl = new System.Windows.Forms.Label();
            this.showPasswordLog = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.logInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.hidePasswordLog = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ErrorMessagePassword = new System.Windows.Forms.Label();
            this.errorMessageUsername = new System.Windows.Forms.Label();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasswordLog)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2CustomGradientPanel1.BackgroundImage")));
            this.guna2CustomGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2CustomGradientPanel1.Controls.Add(this.closeCtrl);
            this.guna2CustomGradientPanel1.Controls.Add(this.SignUpBtnPanel);
            this.guna2CustomGradientPanel1.Controls.Add(this.label5);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Green;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Green;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(619, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(496, 580);
            this.guna2CustomGradientPanel1.TabIndex = 1;
            // 
            // closeCtrl
            // 
            this.closeCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeCtrl.FillColor = System.Drawing.Color.Green;
            this.closeCtrl.IconColor = System.Drawing.Color.White;
            this.closeCtrl.Location = new System.Drawing.Point(451, 0);
            this.closeCtrl.Name = "closeCtrl";
            this.closeCtrl.Size = new System.Drawing.Size(45, 29);
            this.closeCtrl.TabIndex = 13;
            this.closeCtrl.Click += new System.EventHandler(this.closeCtrl_Click);
            // 
            // SignUpBtnPanel
            // 
            this.SignUpBtnPanel.BackColor = System.Drawing.Color.Transparent;
            this.SignUpBtnPanel.BorderColor = System.Drawing.Color.Transparent;
            this.SignUpBtnPanel.BorderRadius = 10;
            this.SignUpBtnPanel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SignUpBtnPanel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SignUpBtnPanel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SignUpBtnPanel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SignUpBtnPanel.FillColor = System.Drawing.Color.LimeGreen;
            this.SignUpBtnPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SignUpBtnPanel.ForeColor = System.Drawing.Color.White;
            this.SignUpBtnPanel.Location = new System.Drawing.Point(188, 500);
            this.SignUpBtnPanel.Name = "SignUpBtnPanel";
            this.SignUpBtnPanel.Size = new System.Drawing.Size(164, 24);
            this.SignUpBtnPanel.TabIndex = 12;
            this.SignUpBtnPanel.Text = "Sign Up";
            this.SignUpBtnPanel.Click += new System.EventHandler(this.SignUpBtnPanel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(419, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kung wala ka pang account, mag-sign up muna.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Maligayang pagbalik!";
            // 
            // logInPanelTop
            // 
            this.logInPanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.logInPanelTop.Location = new System.Drawing.Point(0, 0);
            this.logInPanelTop.Name = "logInPanelTop";
            this.logInPanelTop.Size = new System.Drawing.Size(619, 50);
            this.logInPanelTop.TabIndex = 2;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.logInPanelTop;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(84, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Mag-log in upang magpatuloy.";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Animated = true;
            this.passwordTxt.BorderColor = System.Drawing.Color.Silver;
            this.passwordTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTxt.DefaultText = "";
            this.passwordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTxt.Location = new System.Drawing.Point(50, 339);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '●';
            this.passwordTxt.PlaceholderText = "Password";
            this.passwordTxt.SelectedText = "";
            this.passwordTxt.Size = new System.Drawing.Size(506, 55);
            this.passwordTxt.TabIndex = 22;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderColor = System.Drawing.Color.Silver;
            this.usernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTxt.DefaultText = "";
            this.usernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTxt.Location = new System.Drawing.Point(50, 231);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.PasswordChar = '\0';
            this.usernameTxt.PlaceholderText = "Username";
            this.usernameTxt.SelectedText = "";
            this.usernameTxt.Size = new System.Drawing.Size(506, 55);
            this.usernameTxt.TabIndex = 21;
            this.usernameTxt.TextChanged += new System.EventHandler(this.usernameTxt_TextChanged);
            // 
            // forgotPasswordLbl
            // 
            this.forgotPasswordLbl.AutoSize = true;
            this.forgotPasswordLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLbl.ForeColor = System.Drawing.Color.Green;
            this.forgotPasswordLbl.Location = new System.Drawing.Point(416, 400);
            this.forgotPasswordLbl.Name = "forgotPasswordLbl";
            this.forgotPasswordLbl.Size = new System.Drawing.Size(140, 20);
            this.forgotPasswordLbl.TabIndex = 27;
            this.forgotPasswordLbl.Text = "Forgot password?";
            this.forgotPasswordLbl.Click += new System.EventHandler(this.forgotPasswordLbl_Click);
            // 
            // showPasswordLog
            // 
            this.showPasswordLog.Image = ((System.Drawing.Image)(resources.GetObject("showPasswordLog.Image")));
            this.showPasswordLog.ImageRotate = 0F;
            this.showPasswordLog.Location = new System.Drawing.Point(502, 348);
            this.showPasswordLog.Name = "showPasswordLog";
            this.showPasswordLog.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showPasswordLog.Size = new System.Drawing.Size(44, 37);
            this.showPasswordLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPasswordLog.TabIndex = 28;
            this.showPasswordLog.TabStop = false;
            this.showPasswordLog.Click += new System.EventHandler(this.showPasswordLog_Click);
            // 
            // logInBtn
            // 
            this.logInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logInBtn.FillColor = System.Drawing.Color.Green;
            this.logInBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBtn.ForeColor = System.Drawing.Color.White;
            this.logInBtn.Location = new System.Drawing.Point(50, 474);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(506, 50);
            this.logInBtn.TabIndex = 29;
            this.logInBtn.Text = "Log In";
            this.logInBtn.Click += new System.EventHandler(this.logInBtn_Click);
            // 
            // hidePasswordLog
            // 
            this.hidePasswordLog.Image = ((System.Drawing.Image)(resources.GetObject("hidePasswordLog.Image")));
            this.hidePasswordLog.ImageRotate = 0F;
            this.hidePasswordLog.Location = new System.Drawing.Point(502, 348);
            this.hidePasswordLog.Name = "hidePasswordLog";
            this.hidePasswordLog.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.hidePasswordLog.Size = new System.Drawing.Size(44, 37);
            this.hidePasswordLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hidePasswordLog.TabIndex = 30;
            this.hidePasswordLog.TabStop = false;
            this.hidePasswordLog.Click += new System.EventHandler(this.hidePasswordLog_Click);
            // 
            // ErrorMessagePassword
            // 
            this.ErrorMessagePassword.AutoSize = true;
            this.ErrorMessagePassword.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessagePassword.Location = new System.Drawing.Point(47, 400);
            this.ErrorMessagePassword.Name = "ErrorMessagePassword";
            this.ErrorMessagePassword.Size = new System.Drawing.Size(93, 16);
            this.ErrorMessagePassword.TabIndex = 31;
            this.ErrorMessagePassword.Text = "ErrorMessage";
            // 
            // errorMessageUsername
            // 
            this.errorMessageUsername.AutoSize = true;
            this.errorMessageUsername.ForeColor = System.Drawing.Color.Red;
            this.errorMessageUsername.Location = new System.Drawing.Point(47, 294);
            this.errorMessageUsername.Name = "errorMessageUsername";
            this.errorMessageUsername.Size = new System.Drawing.Size(93, 16);
            this.errorMessageUsername.TabIndex = 32;
            this.errorMessageUsername.Text = "ErrorMessage";
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MessageTopMargin = 0;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 580);
            this.Controls.Add(this.errorMessageUsername);
            this.Controls.Add(this.ErrorMessagePassword);
            this.Controls.Add(this.hidePasswordLog);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.showPasswordLog);
            this.Controls.Add(this.forgotPasswordLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logInPanelTop);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInForm";
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePasswordLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button SignUpBtnPanel;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Panel logInPanelTop;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox passwordTxt;
        private Guna.UI2.WinForms.Guna2TextBox usernameTxt;
        private Guna.UI2.WinForms.Guna2ControlBox closeCtrl;
        private System.Windows.Forms.Label forgotPasswordLbl;
        private Guna.UI2.WinForms.Guna2CirclePictureBox showPasswordLog;
        private Guna.UI2.WinForms.Guna2Button logInBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox hidePasswordLog;
        private System.Windows.Forms.Label ErrorMessagePassword;
        private System.Windows.Forms.Label errorMessageUsername;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
    }
}