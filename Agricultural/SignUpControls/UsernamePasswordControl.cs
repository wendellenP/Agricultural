using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Agricultural.SignUpControls
{
    public partial class UsernamePasswordControl : UserControl
    {
        public UsernamePasswordControl()
        {
            InitializeComponent();
            SignUpButton.Click += signUpButtonT_Click;

            // Initialize error messages to be hidden
            usernameErrorMessage.Visible = false;
            passwordErrorMessage.Visible = false;
            confirmPassErrorMessage.Visible = false;
            invalidMessageUsername.Visible = false;
            weakMessagePassword.Visible = false;
            weakMessagePassword2.Visible = false;
            invalidConfirmMessage.Visible = false;
        }

        public Guna.UI2.WinForms.Guna2Button SignUpButton => signUpButtonT;

        public string Username => UsernameTxt.Text;
        public string Password => PasswordTxt.Text;
        public string ConfirmPassword => ConfirmPasswordTxt.Text;

        private void signUpButtonT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Handle the sign-up logic if needed
                MessageBox.Show("Sign Up successful!");
            }
        }

        public bool ValidateInput()
        {
            bool isValid = true;

            // Hide all error messages at the start
            usernameErrorMessage.Visible = false;
            passwordErrorMessage.Visible = false;
            confirmPassErrorMessage.Visible = false;
            invalidMessageUsername.Visible = false;
            weakMessagePassword.Visible = false;
            weakMessagePassword2.Visible = false;
            invalidConfirmMessage.Visible = false;

            // Validate Username
            if (string.IsNullOrWhiteSpace(Username))
            {
                DisplayErrorChangeColor(usernameErrorMessage, UsernameTxt);
                isValid = false;
            }
            else if (!IsValidUserName(Username))
            {
                ValidUsername();
                isValid = false;
            }
            else
            {
                UsernameTxt.BorderColor = SystemColors.WindowFrame; // Reset color if valid
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(Password))
            {
                DisplayErrorChangeColor(passwordErrorMessage, PasswordTxt);
                isValid = false;
            }
            else if (!IsValidPassword(Password))
            {
                ValidPassword();
                isValid = false;
            }
            else
            {
                PasswordTxt.BorderColor = SystemColors.WindowFrame; // Reset color if valid
            }

            // Validate Confirm Password
            if (string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                DisplayErrorChangeColor(confirmPassErrorMessage, ConfirmPasswordTxt);
                isValid = false;
            }
            else if (Password != ConfirmPassword)
            {
                ValidConfirmPassword();
                isValid = false;
            }
            else
            {
                ConfirmPasswordTxt.BorderColor = SystemColors.WindowFrame; // Reset color if valid
            }

            return isValid;
        }

        private void DisplayErrorChangeColor(Label label, Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            label.Visible = true;
            textBox.BorderColor = Color.Red; // Change border color to red
        }

        private bool IsValidUserName(string username)
        {
            // Username must be alphanumeric and 5-15 characters long
            return Regex.IsMatch(username, @"^[a-zA-Z0-9]{5,15}$");
        }

        private bool IsValidPassword(string password)
        {
            // Password must be at least 8 characters long and contain at least one digit and one letter
            return Regex.IsMatch(password, @"^(?=.*[a-zA-Z])(?=.*\d)[A-Za-z\d]{8,}$");
        }

        private void ValidUsername()
        {
            invalidMessageUsername.Visible = true; // Show invalid username message
        }

        private void ValidPassword()
        {
            weakMessagePassword.Visible = true; // Show invalid password message
            weakMessagePassword2.Visible = true;
        }

        private void ValidConfirmPassword()
        {
            invalidConfirmMessage.Visible = true; // Show invalid confirm password message
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Username))
            {
                usernameErrorMessage.Visible = false;
                UsernameTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255); // Reset to a valid border color
                invalidMessageUsername.Visible = false; // Hide invalid message
            }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Password))
            {
                passwordErrorMessage.Visible = false; // Hide error if valid
                PasswordTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255); // Reset to a valid border color

                // If password is valid, hide weak password message
                if (IsValidPassword(Password))
                {
                    weakMessagePassword.Visible = false; // Hide weak password message if valid
                    weakMessagePassword2.Visible = false; // Also hide the second weak password message
                }
            }
        }

        private void ConfirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                confirmPassErrorMessage.Visible = false; // Hide error if valid
                ConfirmPasswordTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255); // Reset to a valid border color

                // Check if passwords match and reset confirmation message
                if (Password == ConfirmPassword)
                {
                    invalidConfirmMessage.Visible = false; // Hide invalid confirm message if passwords match
                }
            }
        }

    }
}
