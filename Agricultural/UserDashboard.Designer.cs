namespace Agricultural
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.userPanel = new System.Windows.Forms.Panel();
            this.profilePicture = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.requestBtn = new Guna.UI2.WinForms.Guna2Button();
            this.logoutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.aboutBtn = new Guna.UI2.WinForms.Guna2Button();
            this.profileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.settingsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dashBoardFillPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.Color.Green;
            this.userPanel.Controls.Add(this.profilePicture);
            this.userPanel.Controls.Add(this.requestBtn);
            this.userPanel.Controls.Add(this.logoutBtn);
            this.userPanel.Controls.Add(this.aboutBtn);
            this.userPanel.Controls.Add(this.profileBtn);
            this.userPanel.Controls.Add(this.settingsBtn);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.userPanel.Location = new System.Drawing.Point(0, 0);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(298, 615);
            this.userPanel.TabIndex = 22;
            // 
            // profilePicture
            // 
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.ImageRotate = 0F;
            this.profilePicture.Location = new System.Drawing.Point(103, 34);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePicture.Size = new System.Drawing.Size(85, 86);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 14;
            this.profilePicture.TabStop = false;
            // 
            // requestBtn
            // 
            this.requestBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.requestBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.requestBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.requestBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.requestBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.requestBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.requestBtn.FillColor = System.Drawing.Color.Green;
            this.requestBtn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestBtn.ForeColor = System.Drawing.Color.White;
            this.requestBtn.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.requestBtn.Image = ((System.Drawing.Image)(resources.GetObject("requestBtn.Image")));
            this.requestBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.requestBtn.Location = new System.Drawing.Point(24, 234);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.PressedColor = System.Drawing.Color.DarkGreen;
            this.requestBtn.Size = new System.Drawing.Size(249, 45);
            this.requestBtn.TabIndex = 9;
            this.requestBtn.Text = "      Request";
            // 
            // logoutBtn
            // 
            this.logoutBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.logoutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logoutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutBtn.FillColor = System.Drawing.Color.Green;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.White;
            this.logoutBtn.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logoutBtn.Location = new System.Drawing.Point(24, 466);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.PressedColor = System.Drawing.Color.DarkGreen;
            this.logoutBtn.Size = new System.Drawing.Size(249, 45);
            this.logoutBtn.TabIndex = 11;
            this.logoutBtn.Text = "      Log out";
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.aboutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aboutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.aboutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.aboutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.aboutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.aboutBtn.FillColor = System.Drawing.Color.Green;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.ForeColor = System.Drawing.Color.White;
            this.aboutBtn.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.aboutBtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutBtn.Image")));
            this.aboutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.aboutBtn.Location = new System.Drawing.Point(24, 388);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.PressedColor = System.Drawing.Color.DarkGreen;
            this.aboutBtn.Size = new System.Drawing.Size(249, 45);
            this.aboutBtn.TabIndex = 13;
            this.aboutBtn.Text = "    About";
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.Honeydew;
            this.profileBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.profileBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.profileBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.profileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.profileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.profileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.profileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.profileBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.profileBtn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.profileBtn.Location = new System.Drawing.Point(24, 158);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.PressedColor = System.Drawing.Color.DarkGreen;
            this.profileBtn.Size = new System.Drawing.Size(249, 45);
            this.profileBtn.TabIndex = 8;
            this.profileBtn.Text = "   Profile";
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.settingsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.settingsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.settingsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.settingsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.settingsBtn.FillColor = System.Drawing.Color.Green;
            this.settingsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.Color.White;
            this.settingsBtn.HoverState.FillColor = System.Drawing.Color.LimeGreen;
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.settingsBtn.Location = new System.Drawing.Point(24, 311);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.PressedColor = System.Drawing.Color.DarkGreen;
            this.settingsBtn.Size = new System.Drawing.Size(249, 45);
            this.settingsBtn.TabIndex = 12;
            this.settingsBtn.Text = "      Settings";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Green;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Location = new System.Drawing.Point(291, -8);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(930, 62);
            this.guna2Panel1.TabIndex = 24;
            // 
            // dashBoardFillPanel
            // 
            this.dashBoardFillPanel.BackColor = System.Drawing.Color.White;
            this.dashBoardFillPanel.Location = new System.Drawing.Point(294, 34);
            this.dashBoardFillPanel.Name = "dashBoardFillPanel";
            this.dashBoardFillPanel.Size = new System.Drawing.Size(922, 581);
            this.dashBoardFillPanel.TabIndex = 25;
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1218, 615);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.dashBoardFillPanel);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboard";
            this.Load += new System.EventHandler(this.UserDashboard_Load);
            this.userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePicture;
        private Guna.UI2.WinForms.Guna2Button requestBtn;
        private Guna.UI2.WinForms.Guna2Button logoutBtn;
        private Guna.UI2.WinForms.Guna2Button aboutBtn;
        private Guna.UI2.WinForms.Guna2Button profileBtn;
        private Guna.UI2.WinForms.Guna2Button settingsBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel dashBoardFillPanel;
    }
}