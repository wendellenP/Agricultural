using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agricultural.UserPanelsControls;

namespace Agricultural
{
    public partial class UserDashboard : Form
    {
        private int currentControlIndex = 0;
        private UserControl[] userControls;
        private int userId; // Store the user ID
        private string profilePicturePath; // Store the profile picture path
        public UserDashboard(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Set the user ID
            LoadProfilePanel(); // Load the profile panel with the user ID
            try
            {
                InitializeUserControls();
                ShowCurrentUserControl();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"A null reference occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProfilePanel()
        {
            ProfilePanel profilePanel = new ProfilePanel(userId); // Pass userId to ProfilePanel
            this.Controls.Add(profilePanel); // Add the ProfilePanel to the form
            profilePanel.Dock = DockStyle.Fill; // Set the panel to fill the user dashboard
            profilePicturePath = profilePanel.ProfilePicturePath; // Get the profile picture path
            LoadProfilePicture();
        }

        private void InitializeUserControls()
        {
            userControls = new UserControl[]
            {
                new ProfilePanel(userId)
            };
        }

        private void ShowCurrentUserControl()
        {
            AddUserControl(userControls[currentControlIndex]);
        }

        private void AddUserControl(UserControl userControl)
        {
            dashBoardFillPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            dashBoardFillPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            AddUserControl(userControls[0]);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.ShowDialog();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            //Image profileImage = Image.FromFile(profilePicturePath);
            //profilePicture.Image = profileImage;
        }
        private void LoadProfilePicture()
        {
            if (!string.IsNullOrEmpty(profilePicturePath))
            {
                try
                {
                    profilePicture.Image = Image.FromFile(profilePicturePath); // Set the image to the PictureBox
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading profile picture: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
