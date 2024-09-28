using System;
using System.Configuration;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agricultural
{
    public partial class emailVerify : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        private string userEmail;

        public emailVerify()
        {
            InitializeComponent();
            emailErrorMessage.Visible = false;

            cancelBtn.Cursor = Cursors.Hand;
            searchBtn.Cursor = Cursors.Hand;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            userEmail = emailTextBox.Text; // Get the email input from the TextBox

            // Validate email input
            if (string.IsNullOrEmpty(userEmail))
            {
                emailErrorMessage.Text = "Email cannot be empty.";
                emailErrorMessage.Visible = true;
                emailTextBox.BorderColor = Color.Red;
                return;
            }

            if (!IsValidEmail(userEmail))
            {
                emailErrorMessage.Text = "Invalid email format.";
                emailErrorMessage.Visible = true;
                emailTextBox.BorderColor = Color.Red;
                return;
            }

            // Check if the email exists in the database
            if (CheckEmailExists(userEmail))
            {
                Hide();
                sendVerificationCodecs send = new sendVerificationCodecs(userEmail);
                send.Show();
            }
            else
            {
                emailErrorMessage.Text = "Email does not exist. Please check and try again.";
                emailErrorMessage.Visible = true;
                emailTextBox.BorderColor = Color.Red;
            }
        }
        private bool CheckEmailExists(string email)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM Beneficiaries WHERE Email = @Email";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking email: " + ex.Message);
                return false;
            }
        }

       
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(emailTextBox.Text))
            {
                emailErrorMessage.Visible = false;
                emailTextBox.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void loadingDot_Click(object sender, EventArgs e)
        {

        }
    }
}