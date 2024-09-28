using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Agricultural
{
    public partial class Update_Password : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        private string userEmail;

        public Update_Password(string email)
        {
            InitializeComponent();
            userEmail = email; // Store the provided email

            errorMessage1.Visible = false;
            errorMessage2.Visible = false;

            showPassword.Visible = true;
            hidePassword.Visible = false;

            showConfirmPassword.Visible = true;
            hideConfirmPassword.Visible = false;

            showPassword.Cursor = Cursors.Hand;
            hidePassword.Cursor = Cursors.Hand;

            showConfirmPassword.Cursor = Cursors.Hand;
            hideConfirmPassword.Cursor = Cursors.Hand;

            updateBtn.Cursor = Cursors.Hand;
            backLogInLbl.Cursor = Cursors.Hand;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            // Validate password fields
            if (!ValidatePasswordFields())
            {
                return; // Exit if validation fails
            }

            string newPassword = newPasswordTxt.Text; // New password
            UpdatePasswordInDatabase(userEmail, newPassword);
        }

        private bool ValidatePasswordFields()
        {
            bool isValid = true;

            // Check if new password is empty
            if (!CheckNotEmptyPass(newPasswordTxt, errorMessage1))
            {
                isValid = false;
            }

            // Check if confirm password is empty
            if (!CheckNotEmptyPass(confirmPasswordTxt, errorMessage2))
            {
                isValid = false;
            }

            // Perform other validations
            string newPassword = newPasswordTxt.Text;
            string confirmPassword = confirmPasswordTxt.Text;

            if (newPassword != confirmPassword)
            {
                errorMessage2.Visible = true; // Show error message
                errorMessage2.Text = "Passwords do not match."; // Set error message text
                confirmPasswordTxt.BorderColor = Color.Red; // Change border color to red
                isValid = false; // Mark as invalid
            }

            return isValid; // Return overall validation result
        }

        private void UpdatePasswordInDatabase(string email, string newPassword)
        {
            try
            {
                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(newPassword);

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Beneficiaries SET Password_Hash = @hashedPassword WHERE Email = @Email";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                        command.Parameters.AddWithValue("@Email", email);
                        command.ExecuteNonQuery();
                    }
                }

                SuccessfulMessage.Show(this.FindForm(), "Password updated successfully!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);
                //MessageBox.Show("Password updated successfully!");
                Close(); // Close the form after successful update
                new LogInForm().Show(); // Show the login form
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }
        }

        private bool CheckNotEmptyPass(Guna.UI2.WinForms.Guna2TextBox textBox, Label label)
        {
            if (string.IsNullOrEmpty(textBox.Text)) // Check the Text property
            {
                label.Visible = true;
                label.Text = "This is required!";
                textBox.BorderColor = Color.Red;
                return false; // Indicate validation failure
            }
            else
            {
                label.Visible = false;
                textBox.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                return true; // Indicate validation success
            }
        }

        private void backLogInLbl_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void Update_Password_Load(object sender, EventArgs e)
        {

        }

        private void newPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(newPasswordTxt.Text))
            {
                showPassword.Show();
                hidePassword.Hide();
            }
            else
            {
                newPasswordTxt.PasswordChar = '●';
                showPassword.Show();
                hidePassword.Hide();
            }
        }

        private void confirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(confirmPasswordTxt.Text))
            {
                showConfirmPassword.Show();
                hideConfirmPassword.Hide();
                errorMessage2.Visible = false;
                confirmPasswordTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
            else
            {
                confirmPasswordTxt.PasswordChar = '●';
                showConfirmPassword.Show();
                hideConfirmPassword.Hide();
            }
        }

        public void ShowPassword(PictureBox showEye, PictureBox hideEye, Guna2TextBox password)
        {
            if (password.PasswordChar == '●' && !string.IsNullOrEmpty(password.Text))
            {
                password.PasswordChar = '\0';
                showEye.Hide();
                hideEye.Show();
            }
            else
            {
                showEye.Show();
            }
        }

        public void HidePassword(PictureBox hideEye, PictureBox showEye, Guna2TextBox password)
        {
            if (password.PasswordChar == '\0' && !string.IsNullOrEmpty(password.Text))
            {
                password.PasswordChar = '●'; // Unmask
                showEye.Show();
                hideEye.Hide();
            }
            else
            {
                password.PasswordChar = '●';
                showEye.Hide();
            }
        }

        private void showPassword_Click(object sender, EventArgs e)
        {
            ShowPassword(showPassword, hidePassword, newPasswordTxt);
        }

        private void hidePassword_Click(object sender, EventArgs e)
        {
            HidePassword(hidePassword, showPassword, newPasswordTxt);

        }

        private void showConfirmPassword_Click(object sender, EventArgs e)
        {
            ShowPassword(showConfirmPassword, hideConfirmPassword, confirmPasswordTxt);
        }

        private void hideConfirmPassword_Click(object sender, EventArgs e)
        {
            HidePassword(hideConfirmPassword, showConfirmPassword, confirmPasswordTxt);
        }
    }
}