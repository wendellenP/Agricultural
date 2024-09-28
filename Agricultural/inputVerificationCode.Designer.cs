namespace Agricultural
{
    partial class inputVerificationCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputVerificationCode));
            this.sendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.firstDigit = new Guna.UI2.WinForms.Guna2TextBox();
            this.backLogInLbl = new System.Windows.Forms.Label();
            this.errorMessageLbl = new System.Windows.Forms.Label();
            this.countDownCode = new System.Windows.Forms.Label();
            this.countDownTime = new System.Windows.Forms.Timer(this.components);
            this.secodeDigit = new Guna.UI2.WinForms.Guna2TextBox();
            this.thirdDigit = new Guna.UI2.WinForms.Guna2TextBox();
            this.sixDigit = new Guna.UI2.WinForms.Guna2TextBox();
            this.fifthDigit = new Guna.UI2.WinForms.Guna2TextBox();
            this.fourthDigit = new Guna.UI2.WinForms.Guna2TextBox();
            this.backToSendCodeForm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.displayEmail = new System.Windows.Forms.Label();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.SuspendLayout();
            // 
            // sendBtn
            // 
            this.sendBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sendBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sendBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sendBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sendBtn.FillColor = System.Drawing.Color.Green;
            this.sendBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(40, 351);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(485, 45);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "Verify";
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // firstDigit
            // 
            this.firstDigit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.firstDigit.DefaultText = "";
            this.firstDigit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.firstDigit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.firstDigit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstDigit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.firstDigit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstDigit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstDigit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.firstDigit.Location = new System.Drawing.Point(44, 192);
            this.firstDigit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstDigit.Name = "firstDigit";
            this.firstDigit.PasswordChar = '\0';
            this.firstDigit.PlaceholderText = "";
            this.firstDigit.SelectedText = "";
            this.firstDigit.Size = new System.Drawing.Size(65, 75);
            this.firstDigit.TabIndex = 0;
            this.firstDigit.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            // 
            // backLogInLbl
            // 
            this.backLogInLbl.AutoSize = true;
            this.backLogInLbl.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backLogInLbl.Location = new System.Drawing.Point(203, 415);
            this.backLogInLbl.Name = "backLogInLbl";
            this.backLogInLbl.Size = new System.Drawing.Size(145, 20);
            this.backLogInLbl.TabIndex = 3;
            this.backLogInLbl.Text = "Back to log in form";
            this.backLogInLbl.Click += new System.EventHandler(this.backLogInLbl_Click);
            // 
            // errorMessageLbl
            // 
            this.errorMessageLbl.AutoSize = true;
            this.errorMessageLbl.ForeColor = System.Drawing.Color.Red;
            this.errorMessageLbl.Location = new System.Drawing.Point(37, 287);
            this.errorMessageLbl.Name = "errorMessageLbl";
            this.errorMessageLbl.Size = new System.Drawing.Size(96, 16);
            this.errorMessageLbl.TabIndex = 4;
            this.errorMessageLbl.Text = "Error Message";
            // 
            // countDownCode
            // 
            this.countDownCode.AutoSize = true;
            this.countDownCode.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownCode.Location = new System.Drawing.Point(250, 306);
            this.countDownCode.Name = "countDownCode";
            this.countDownCode.Size = new System.Drawing.Size(53, 26);
            this.countDownCode.TabIndex = 5;
            this.countDownCode.Text = "0:00";
            //this.countDownCode.Click += new System.EventHandler(this.countDownCode_Click);
            // 
            // countDownTime
            // 
            this.countDownTime.Tick += new System.EventHandler(this.countDownTime_Tick);
            // 
            // secodeDigit
            // 
            this.secodeDigit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.secodeDigit.DefaultText = "";
            this.secodeDigit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.secodeDigit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.secodeDigit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secodeDigit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.secodeDigit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secodeDigit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secodeDigit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.secodeDigit.Location = new System.Drawing.Point(127, 192);
            this.secodeDigit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secodeDigit.Name = "secodeDigit";
            this.secodeDigit.PasswordChar = '\0';
            this.secodeDigit.PlaceholderText = "";
            this.secodeDigit.SelectedText = "";
            this.secodeDigit.Size = new System.Drawing.Size(65, 75);
            this.secodeDigit.TabIndex = 7;
            this.secodeDigit.TextChanged += new System.EventHandler(this.secodeDigit_TextChanged);
            // 
            // thirdDigit
            // 
            this.thirdDigit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.thirdDigit.DefaultText = "";
            this.thirdDigit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.thirdDigit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.thirdDigit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thirdDigit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.thirdDigit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thirdDigit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdDigit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.thirdDigit.Location = new System.Drawing.Point(211, 192);
            this.thirdDigit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.thirdDigit.Name = "thirdDigit";
            this.thirdDigit.PasswordChar = '\0';
            this.thirdDigit.PlaceholderText = "";
            this.thirdDigit.SelectedText = "";
            this.thirdDigit.Size = new System.Drawing.Size(65, 75);
            this.thirdDigit.TabIndex = 8;
            this.thirdDigit.TextChanged += new System.EventHandler(this.thirdDigit_TextChanged);
            // 
            // sixDigit
            // 
            this.sixDigit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sixDigit.DefaultText = "";
            this.sixDigit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sixDigit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sixDigit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sixDigit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sixDigit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sixDigit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sixDigit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sixDigit.Location = new System.Drawing.Point(464, 192);
            this.sixDigit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sixDigit.Name = "sixDigit";
            this.sixDigit.PasswordChar = '\0';
            this.sixDigit.PlaceholderText = "";
            this.sixDigit.SelectedText = "";
            this.sixDigit.Size = new System.Drawing.Size(65, 75);
            this.sixDigit.TabIndex = 9;
            this.sixDigit.TextChanged += new System.EventHandler(this.sixDigit_TextChanged);
            // 
            // fifthDigit
            // 
            this.fifthDigit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fifthDigit.DefaultText = "";
            this.fifthDigit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fifthDigit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fifthDigit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fifthDigit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fifthDigit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fifthDigit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fifthDigit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fifthDigit.Location = new System.Drawing.Point(380, 192);
            this.fifthDigit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fifthDigit.Name = "fifthDigit";
            this.fifthDigit.PasswordChar = '\0';
            this.fifthDigit.PlaceholderText = "";
            this.fifthDigit.SelectedText = "";
            this.fifthDigit.Size = new System.Drawing.Size(65, 75);
            this.fifthDigit.TabIndex = 10;
            this.fifthDigit.TextChanged += new System.EventHandler(this.fifthDigit_TextChanged);
            // 
            // fourthDigit
            // 
            this.fourthDigit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fourthDigit.DefaultText = "";
            this.fourthDigit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fourthDigit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fourthDigit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fourthDigit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fourthDigit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fourthDigit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fourthDigit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fourthDigit.Location = new System.Drawing.Point(296, 192);
            this.fourthDigit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fourthDigit.Name = "fourthDigit";
            this.fourthDigit.PasswordChar = '\0';
            this.fourthDigit.PlaceholderText = "";
            this.fourthDigit.SelectedText = "";
            this.fourthDigit.Size = new System.Drawing.Size(65, 75);
            this.fourthDigit.TabIndex = 11;
            this.fourthDigit.TextChanged += new System.EventHandler(this.fourthDigit_TextChanged);
            // 
            // backToSendCodeForm
            // 
            this.backToSendCodeForm.AutoSize = true;
            this.backToSendCodeForm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToSendCodeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.backToSendCodeForm.Location = new System.Drawing.Point(37, 444);
            this.backToSendCodeForm.Name = "backToSendCodeForm";
            this.backToSendCodeForm.Size = new System.Drawing.Size(131, 17);
            this.backToSendCodeForm.TabIndex = 12;
            this.backToSendCodeForm.Text = "Didn\'t get a code?";
            this.backToSendCodeForm.Click += new System.EventHandler(this.backToSendCodeForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(143, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Verify Your Email";
            // 
            // displayEmail
            // 
            this.displayEmail.AutoSize = true;
            this.displayEmail.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayEmail.Location = new System.Drawing.Point(47, 127);
            this.displayEmail.Name = "displayEmail";
            this.displayEmail.Size = new System.Drawing.Size(0, 24);
            this.displayEmail.TabIndex = 1;
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
            // inputVerificationCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(572, 493);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.displayEmail);
            this.Controls.Add(this.backToSendCodeForm);
            this.Controls.Add(this.fourthDigit);
            this.Controls.Add(this.fifthDigit);
            this.Controls.Add(this.sixDigit);
            this.Controls.Add(this.thirdDigit);
            this.Controls.Add(this.secodeDigit);
            this.Controls.Add(this.countDownCode);
            this.Controls.Add(this.errorMessageLbl);
            this.Controls.Add(this.backLogInLbl);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.firstDigit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "inputVerificationCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inputVerificationCode";
            this.Load += new System.EventHandler(this.inputVerificationCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button sendBtn;
        private Guna.UI2.WinForms.Guna2TextBox firstDigit;
        private System.Windows.Forms.Label backLogInLbl;
        private System.Windows.Forms.Label errorMessageLbl;
        private System.Windows.Forms.Label countDownCode;
        private System.Windows.Forms.Timer countDownTime;
        private Guna.UI2.WinForms.Guna2TextBox secodeDigit;
        private Guna.UI2.WinForms.Guna2TextBox thirdDigit;
        private Guna.UI2.WinForms.Guna2TextBox sixDigit;
        private Guna.UI2.WinForms.Guna2TextBox fifthDigit;
        private Guna.UI2.WinForms.Guna2TextBox fourthDigit;
        private System.Windows.Forms.Label backToSendCodeForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label displayEmail;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
    }
}