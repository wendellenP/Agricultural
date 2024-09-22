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
            this.MNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.FnameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.logInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.showPasswordLog = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.showPasswordLog)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(20, 149);
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
            this.MNameTxt.Location = new System.Drawing.Point(50, 329);
            this.MNameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MNameTxt.Name = "MNameTxt";
            this.MNameTxt.PasswordChar = '\0';
            this.MNameTxt.PlaceholderText = "Password";
            this.MNameTxt.SelectedText = "";
            this.MNameTxt.Size = new System.Drawing.Size(506, 55);
            this.MNameTxt.TabIndex = 22;
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
            this.FnameTxt.Location = new System.Drawing.Point(50, 231);
            this.FnameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FnameTxt.Name = "FnameTxt";
            this.FnameTxt.PasswordChar = '\0';
            this.FnameTxt.PlaceholderText = "Username";
            this.FnameTxt.SelectedText = "";
            this.FnameTxt.Size = new System.Drawing.Size(506, 55);
            this.FnameTxt.TabIndex = 21;
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
            this.logInBtn.Location = new System.Drawing.Point(50, 438);
            this.logInBtn.Name = "logInBtn";
            this.logInBtn.Size = new System.Drawing.Size(506, 50);
            this.logInBtn.TabIndex = 26;
            this.logInBtn.Text = "Log In";
            this.logInBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(416, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Forgot password?";
            // 
            // showPasswordLog
            // 
            this.showPasswordLog.Image = ((System.Drawing.Image)(resources.GetObject("showPasswordLog.Image")));
            this.showPasswordLog.ImageRotate = 0F;
            this.showPasswordLog.Location = new System.Drawing.Point(502, 339);
            this.showPasswordLog.Name = "showPasswordLog";
            this.showPasswordLog.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.showPasswordLog.Size = new System.Drawing.Size(44, 37);
            this.showPasswordLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.showPasswordLog.TabIndex = 28;
            this.showPasswordLog.TabStop = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1115, 580);
            this.Controls.Add(this.showPasswordLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logInBtn);
            this.Controls.Add(this.MNameTxt);
            this.Controls.Add(this.FnameTxt);
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
        private Guna.UI2.WinForms.Guna2TextBox MNameTxt;
        private Guna.UI2.WinForms.Guna2TextBox FnameTxt;
        private Guna.UI2.WinForms.Guna2Button logInBtn;
        private Guna.UI2.WinForms.Guna2ControlBox closeCtrl;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2CirclePictureBox showPasswordLog;
    }
}