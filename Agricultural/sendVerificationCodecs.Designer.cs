namespace Agricultural
{
    partial class sendVerificationCodecs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sendVerificationCodecs));
            this.label2 = new System.Windows.Forms.Label();
            this.ProfilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.profileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sendCodeRadioBtn = new System.Windows.Forms.RadioButton();
            this.emailAddressLbl = new System.Windows.Forms.Label();
            this.backLogInRadioBtn = new System.Windows.Forms.RadioButton();
            this.notBtn = new Guna.UI2.WinForms.Guna2Button();
            this.continueBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuSnackbar2 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.backEndErrorMessage = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Get Verification Code";
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.ImageRotate = 0F;
            this.ProfilePicture.Location = new System.Drawing.Point(542, 130);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfilePicture.Size = new System.Drawing.Size(120, 113);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 7;
            this.ProfilePicture.TabStop = false;
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileName.ForeColor = System.Drawing.Color.Black;
            this.profileName.Location = new System.Drawing.Point(567, 258);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(81, 18);
            this.profileName.TabIndex = 8;
            this.profileName.Text = "M..... A......";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 42);
            this.label3.TabIndex = 9;
            this.label3.Text = "How do you want to get the code\r\nto reset your password?";
            // 
            // sendCodeRadioBtn
            // 
            this.sendCodeRadioBtn.AutoSize = true;
            this.sendCodeRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendCodeRadioBtn.Location = new System.Drawing.Point(19, 169);
            this.sendCodeRadioBtn.Name = "sendCodeRadioBtn";
            this.sendCodeRadioBtn.Size = new System.Drawing.Size(249, 24);
            this.sendCodeRadioBtn.TabIndex = 10;
            this.sendCodeRadioBtn.TabStop = true;
            this.sendCodeRadioBtn.Text = "Send code via Email Address";
            this.sendCodeRadioBtn.UseVisualStyleBackColor = true;
            // 
            // emailAddressLbl
            // 
            this.emailAddressLbl.AutoSize = true;
            this.emailAddressLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailAddressLbl.ForeColor = System.Drawing.Color.Black;
            this.emailAddressLbl.Location = new System.Drawing.Point(42, 197);
            this.emailAddressLbl.Name = "emailAddressLbl";
            this.emailAddressLbl.Size = new System.Drawing.Size(110, 18);
            this.emailAddressLbl.TabIndex = 11;
            this.emailAddressLbl.Text = "Email Address";
            // 
            // backLogInRadioBtn
            // 
            this.backLogInRadioBtn.AutoSize = true;
            this.backLogInRadioBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLogInRadioBtn.Location = new System.Drawing.Point(20, 258);
            this.backLogInRadioBtn.Name = "backLogInRadioBtn";
            this.backLogInRadioBtn.Size = new System.Drawing.Size(211, 24);
            this.backLogInRadioBtn.TabIndex = 12;
            this.backLogInRadioBtn.TabStop = true;
            this.backLogInRadioBtn.Text = "Enter password to log in";
            this.backLogInRadioBtn.UseVisualStyleBackColor = true;
            // 
            // notBtn
            // 
            this.notBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.notBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.notBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.notBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.notBtn.FillColor = System.Drawing.Color.DarkGray;
            this.notBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notBtn.ForeColor = System.Drawing.Color.White;
            this.notBtn.Location = new System.Drawing.Point(562, 14);
            this.notBtn.Name = "notBtn";
            this.notBtn.Size = new System.Drawing.Size(131, 45);
            this.notBtn.TabIndex = 13;
            this.notBtn.Text = "Not you?";
            this.notBtn.Click += new System.EventHandler(this.notBtn_Click);
            // 
            // continueBtn
            // 
            this.continueBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.continueBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.continueBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.continueBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.continueBtn.FillColor = System.Drawing.Color.Green;
            this.continueBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueBtn.ForeColor = System.Drawing.Color.White;
            this.continueBtn.Location = new System.Drawing.Point(706, 14);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(131, 45);
            this.continueBtn.TabIndex = 14;
            this.continueBtn.Text = "Continue";
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2CustomGradientPanel1.BorderThickness = 2;
            this.guna2CustomGradientPanel1.Controls.Add(this.continueBtn);
            this.guna2CustomGradientPanel1.Controls.Add(this.notBtn);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-108, 348);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(907, 213);
            this.guna2CustomGradientPanel1.TabIndex = 15;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2CustomGradientPanel2.BorderThickness = 2;
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(-3, -9);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(761, 91);
            this.guna2CustomGradientPanel2.TabIndex = 16;
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
            // bunifuSnackbar2
            // 
            this.bunifuSnackbar2.AllowDragging = false;
            this.bunifuSnackbar2.AllowMultipleViews = true;
            this.bunifuSnackbar2.ClickToClose = true;
            this.bunifuSnackbar2.DoubleClickToClose = true;
            this.bunifuSnackbar2.DurationAfterIdle = 3000;
            this.bunifuSnackbar2.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar2.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar2.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar2.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar2.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon4")));
            this.bunifuSnackbar2.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar2.FadeCloseIcon = false;
            this.bunifuSnackbar2.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar2.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar2.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar2.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar2.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon5")));
            this.bunifuSnackbar2.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar2.Margin = 10;
            this.bunifuSnackbar2.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar2.MaximumViews = 7;
            this.bunifuSnackbar2.MessageRightMargin = 15;
            this.bunifuSnackbar2.MessageTopMargin = 0;
            this.bunifuSnackbar2.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar2.ShowBorders = false;
            this.bunifuSnackbar2.ShowCloseIcon = false;
            this.bunifuSnackbar2.ShowIcon = true;
            this.bunifuSnackbar2.ShowShadows = true;
            this.bunifuSnackbar2.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar2.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar2.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar2.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar2.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon6")));
            this.bunifuSnackbar2.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar2.ViewsMargin = 7;
            this.bunifuSnackbar2.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar2.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar2.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar2.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar2.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar2.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar2.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar2.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon7")));
            this.bunifuSnackbar2.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar2.ZoomCloseIcon = true;
            // 
            // backEndErrorMessage
            // 
            this.backEndErrorMessage.AllowDragging = false;
            this.backEndErrorMessage.AllowMultipleViews = true;
            this.backEndErrorMessage.ClickToClose = true;
            this.backEndErrorMessage.DoubleClickToClose = true;
            this.backEndErrorMessage.DurationAfterIdle = 3000;
            this.backEndErrorMessage.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.ErrorOptions.ActionBorderRadius = 1;
            this.backEndErrorMessage.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.backEndErrorMessage.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.backEndErrorMessage.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.backEndErrorMessage.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.backEndErrorMessage.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.backEndErrorMessage.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.backEndErrorMessage.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.backEndErrorMessage.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon8")));
            this.backEndErrorMessage.ErrorOptions.IconLeftMargin = 12;
            this.backEndErrorMessage.FadeCloseIcon = false;
            this.backEndErrorMessage.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.backEndErrorMessage.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.InformationOptions.ActionBorderRadius = 1;
            this.backEndErrorMessage.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.backEndErrorMessage.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.backEndErrorMessage.InformationOptions.BackColor = System.Drawing.Color.White;
            this.backEndErrorMessage.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.backEndErrorMessage.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.backEndErrorMessage.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.backEndErrorMessage.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon9")));
            this.backEndErrorMessage.InformationOptions.IconLeftMargin = 12;
            this.backEndErrorMessage.Margin = 10;
            this.backEndErrorMessage.MaximumSize = new System.Drawing.Size(0, 0);
            this.backEndErrorMessage.MaximumViews = 7;
            this.backEndErrorMessage.MessageRightMargin = 15;
            this.backEndErrorMessage.MessageTopMargin = 0;
            this.backEndErrorMessage.MinimumSize = new System.Drawing.Size(0, 0);
            this.backEndErrorMessage.ShowBorders = false;
            this.backEndErrorMessage.ShowCloseIcon = false;
            this.backEndErrorMessage.ShowIcon = true;
            this.backEndErrorMessage.ShowShadows = true;
            this.backEndErrorMessage.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.SuccessOptions.ActionBorderRadius = 1;
            this.backEndErrorMessage.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.backEndErrorMessage.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.backEndErrorMessage.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.backEndErrorMessage.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.backEndErrorMessage.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.backEndErrorMessage.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.backEndErrorMessage.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.backEndErrorMessage.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon10")));
            this.backEndErrorMessage.SuccessOptions.IconLeftMargin = 12;
            this.backEndErrorMessage.ViewsMargin = 7;
            this.backEndErrorMessage.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.backEndErrorMessage.WarningOptions.ActionBorderRadius = 1;
            this.backEndErrorMessage.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.backEndErrorMessage.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.backEndErrorMessage.WarningOptions.BackColor = System.Drawing.Color.White;
            this.backEndErrorMessage.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.backEndErrorMessage.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.backEndErrorMessage.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.backEndErrorMessage.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.backEndErrorMessage.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon11")));
            this.backEndErrorMessage.WarningOptions.IconLeftMargin = 12;
            this.backEndErrorMessage.ZoomCloseIcon = true;
            // 
            // sendVerificationCodecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Controls.Add(this.backLogInRadioBtn);
            this.Controls.Add(this.emailAddressLbl);
            this.Controls.Add(this.sendCodeRadioBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.ProfilePicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sendVerificationCodecs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter password to log in";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfilePicture;
        private System.Windows.Forms.Label profileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sendCodeRadioBtn;
        private System.Windows.Forms.Label emailAddressLbl;
        private System.Windows.Forms.RadioButton backLogInRadioBtn;
        private Guna.UI2.WinForms.Guna2Button notBtn;
        private Guna.UI2.WinForms.Guna2Button continueBtn;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar2;
        private Bunifu.UI.WinForms.BunifuSnackbar backEndErrorMessage;
    }
}