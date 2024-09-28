using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Agricultural.SignUpControls
{
    public partial class UsernamePasswordControl : UserControl
    {
        public UsernamePasswordControl()
        {
            InitializeComponent();
            SignUpButton.Click += signUpButtonT_Click;

            InitializeErrorHandling();
            InitializePasswordVisibility();
            InitializeCursors();
        }

        public Guna2Button SignUpButton => signUpButtonT;

        public string Username => UsernameTxt.Text;
        public string Password => PasswordTxt.Text;
        public string ConfirmPassword => ConfirmPasswordTxt.Text;

        private void signUpButtonT_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                // Handle successful validation, proceed with signup logic
                MessageBox.Show("Sign Up successful!");
            }
        }

        private void InitializeErrorHandling()
        {
            // Initialize error messages to be hidden
            errorMessageUsername.Visible = false;
            passwordErrorMessage.Visible = false;
            confirmPassErrorMessage.Visible = false;
        }

        private void InitializePasswordVisibility()
        {
            // Initialize password visibility controls
            showPasswordSign.Show();
            showPasswordSignConfirm.Show();

            hidePasswordSign.Hide();
            hidePasswordSignConfirm.Hide();
        }

        private void InitializeCursors()
        {
            // Initialize cursor icons for user experience
            showPasswordSign.Cursor = Cursors.Hand;
            showPasswordSignConfirm.Cursor = Cursors.Hand;
            hidePasswordSign.Cursor = Cursors.Hand;
            hidePasswordSignConfirm.Cursor = Cursors.Hand;
            signUpButtonT.Cursor = Cursors.Hand;
        }

        public bool ValidateInput()
        {
            bool isValid = true;

            // Reset error messages and colors
            ResetErrors();

            // Validate Username
            if (string.IsNullOrWhiteSpace(Username))
            {
                SetError(errorMessageUsername, UsernameTxt, "Username cannot be empty.");
                isValid = false;
            }
            else if (!IsValidUserName(Username))
            {
                SetError(errorMessageUsername, UsernameTxt, "Username must be 5-15 alphanumeric characters.");
                isValid = false;
            }

            // Validate Password
            if (string.IsNullOrWhiteSpace(Password))
            {
                SetError(passwordErrorMessage, PasswordTxt, "Password cannot be empty.");
                isValid = false;
            }
            else if (!IsValidPassword(Password))
            {
                SetError(passwordErrorMessage, PasswordTxt, "Password must be at least 8 characters with one digit and capital letter.");
                isValid = false;
            }

            // Validate Confirm Password
            if (string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                SetError(confirmPassErrorMessage, ConfirmPasswordTxt, "Please confirm your password.");
                isValid = false;
            }
            else if (Password != ConfirmPassword)
            {
                SetError(confirmPassErrorMessage, ConfirmPasswordTxt, "Passwords do not match.");
                isValid = false;
            }

            return isValid;
        }

        private void ResetErrors()
        {
            // Hide all error messages and reset colors
            errorMessageUsername.Visible = false;
            passwordErrorMessage.Visible = false;
            confirmPassErrorMessage.Visible = false;

            UsernameTxt.BorderColor = SystemColors.WindowFrame;
            PasswordTxt.BorderColor = SystemColors.WindowFrame;
            ConfirmPasswordTxt.BorderColor = SystemColors.WindowFrame;
        }

        private void SetError(Label errorLabel, Guna2TextBox textBox, string message)
        {
            // Display error message and highlight field
            errorLabel.Text = message;
            errorLabel.Visible = true;
            textBox.BorderColor = Color.Red;
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

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Username))
            {
                UsernameTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                errorMessageUsername.Visible = false;
            }
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Password))
            {
                passwordErrorMessage.Visible = false;
                PasswordTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                showPasswordSign.Show();
                hidePasswordSign.Hide();
            }
            else
            {
                PasswordTxt.PasswordChar = '●';
                showPasswordSign.Show();
                hidePasswordSign.Hide();
            }
        }

        private void ConfirmPasswordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ConfirmPassword))
            {
                confirmPassErrorMessage.Visible = false;
                ConfirmPasswordTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                showPasswordSignConfirm.Show();
                hidePasswordSignConfirm.Hide();
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
                password.PasswordChar = '●';
                showEye.Show();
                hideEye.Hide();
            }
            else
            {
                password.PasswordChar = '●';
                showEye.Hide();
            }
        }

        private void hidePasswordSign_Click(object sender, EventArgs e)
        {
            HidePassword(hidePasswordSign, showPasswordSign, PasswordTxt);
        }

        private void showPasswordSign_Click(object sender, EventArgs e)
        {
            ShowPassword(showPasswordSign, hidePasswordSign, PasswordTxt);
        }

        private void hidePasswordSignConfirm_Click(object sender, EventArgs e)
        {
            HidePassword(hidePasswordSignConfirm, showPasswordSignConfirm, ConfirmPasswordTxt);
        }

        private void showPasswordSignConfirm_Click(object sender, EventArgs e)
        {
            ShowPassword(showPasswordSignConfirm, hidePasswordSignConfirm, ConfirmPasswordTxt);
        }
    }
}
