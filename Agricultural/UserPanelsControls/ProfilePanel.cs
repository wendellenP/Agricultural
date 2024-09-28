using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agricultural.UserPanelsControls
{
    public partial class ProfilePanel : UserControl
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        private int userId; // Store the user ID
        public string ProfilePicturePath { get; private set; } // Store the profile picture path

        public ProfilePanel(int userId)
        {
            InitializeComponent();
            this.userId = userId; // Set the user ID
            LoadUserData();
        }

        private void LoadUserData()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM beneficiaries WHERE User_ID = @UserId";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId); // Add user ID parameter
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Load user data
                            nameTxt.Text = $"{reader["First_Name"]} {reader["Middle_Name"]} {reader["Last_Name"]}";
                            addressTxt.Text = reader["Address"].ToString();
                            birthdayTxt.Text = reader["Birth_Date"].ToString();
                            genderTxt.Text = reader["Gender"].ToString();
                            usernameTxt.Text = reader["Username"].ToString();
                            phoneTxt.Text = reader["Phone_Number"].ToString();
                            emailTxt.Text = reader["Email"].ToString();
                            ProfilePicturePath = reader["Profile_Picture"].ToString(); // Get profile picture path

                            LoadProfilePicture(); // Load the profile picture
                        }
                    }
                }
            }
        }

        private void LoadProfilePicture()
        {
            if (!string.IsNullOrEmpty(ProfilePicturePath))
            {
                try
                {
                    userProfile.Image = Image.FromFile(ProfilePicturePath); // Set the image
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image: {ex.Message}");
                }
            }
        }
    }
}