using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Agricultural
{
    public partial class LogInForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        public LogInForm()
        {
            InitializeComponent();
            showPasswordLog.Show();
            hidePasswordLog.Hide();

            errorMessageUsername.Visible = false;
            ErrorMessagePassword.Visible = false;

            logInBtn.Cursor = Cursors.Hand;
            forgotPasswordLbl.Cursor = Cursors.Hand;

            showPasswordLog.Cursor = Cursors.Hand;
            hidePasswordLog.Cursor= Cursors.Hand;

            SignUpBtnPanel.Cursor = Cursors.Hand;


            // Attach KeyPress event handlers
            usernameTxt.KeyPress += TextBox_KeyPress;
            passwordTxt.KeyPress += TextBox_KeyPress;
        }

        private void SignUpBtnPanel_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpForm form = new SignUpForm();
            form.Show();
        }

        private void closeCtrl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInBtn_Click(object sender, EventArgs e)
        {
            SuccessfulLogIn();
        }

        private void SuccessfulLogIn()
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            // Clear previous error states
            ClearError(usernameTxt, errorMessageUsername);
            ClearError(passwordTxt, ErrorMessagePassword);

            bool hasError = false;

            if (string.IsNullOrEmpty(username))
            {
                DisplayError(usernameTxt, errorMessageUsername, "Please enter your username.");
                hasError = true;
            }

            if (string.IsNullOrEmpty(password))
            {
                DisplayError(passwordTxt, ErrorMessagePassword, "Please enter your password");
                hasError = true;
            }

            if (!hasError && VerifyUser(username, password, out int userId))
            {
                //bunifuSnackbar1.Show(this.FindForm(), "You are successfully log in.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success);

                // Log the login time and activity
                LogLogin(userId);

                Hide();
                UserDashboard mainForm = new UserDashboard(userId); // Replace with your main form
                mainForm.Show();
            }
            else if (!hasError)
            {
                bunifuSnackbar1.Show(this.FindForm(), "Invalid username or password.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                passwordTxt.Text = "";
            }
        }

        private bool VerifyUser(string username, string password, out int userId)
        {
            userId = 0;
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT User_ID, Password_Hash FROM Beneficiaries WHERE Username = @username";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string storedPasswordHash = reader["Password_Hash"].ToString();
                                userId = Convert.ToInt32(reader["User_ID"]);

                                if (VerifyPassword(password, storedPasswordHash))
                                {
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bunifuSnackbar1.Show(this.FindForm(), "Please try again later.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
            return false;
        }


        private bool VerifyPassword(string inputPassword, string storedPasswordHash)
        {
            return BCrypt.Net.BCrypt.Verify(inputPassword, storedPasswordHash);
        }

        private void forgotPasswordLbl_Click(object sender, EventArgs e)
        {
            Hide();
            emailVerify code = new emailVerify();
            code.Show();
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

        private void showPasswordLog_Click(object sender, EventArgs e)
        {
            ShowPassword(showPasswordLog, hidePasswordLog, passwordTxt);
        }

        private void hidePasswordLog_Click(object sender, EventArgs e)
        {
            HidePassword(hidePasswordLog, showPasswordLog, passwordTxt);
        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(passwordTxt.Text))
            {
                ErrorMessagePassword.Visible = false;
                passwordTxt.BorderColor = Color.FromArgb(94, 148, 255); // Reset to default color
            }
            if (!string.IsNullOrEmpty(passwordTxt.Text))
            {
                showPasswordLog.Show();
                hidePasswordLog.Hide();
            }
            else
            {
                passwordTxt.PasswordChar = '●';
                showPasswordLog.Show();
                hidePasswordLog.Hide();
            }
        }

        private void DisplayError(Guna2TextBox textbox, Label label, string message)
        {
            label.Text = message;
            textbox.BorderColor = Color.Red;
            label.Visible = true;
        }

        private void ClearError(Guna2TextBox textbox, Label label)
        {
            label.Visible = false;
            textbox.BorderColor = Color.FromArgb(94, 148, 255); // Reset to default color
        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTxt.Text))
            {
                errorMessageUsername.Visible = false;
                usernameTxt.BorderColor = Color.FromArgb(94, 148, 255); // Reset to default color
            }
        }

        private void LogLogin(int userId)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Check if the user already has an entry in the Accounts table
                    string checkQuery = "SELECT COUNT(*) FROM Accounts WHERE User_ID = @userId";
                    using (var checkCmd = new MySqlCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@userId", userId);
                        int accountExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (accountExists > 0)
                        {
                            // Update the existing account with the new login and activity dates
                            string updateQuery = "UPDATE Accounts SET Last_Login_Date = @loginDate, Last_Activity_Date = @activityDate WHERE User_ID = @userId";
                            using (var updateCmd = new MySqlCommand(updateQuery, connection))
                            {
                                updateCmd.Parameters.AddWithValue("@loginDate", DateTime.Now);
                                updateCmd.Parameters.AddWithValue("@activityDate", DateTime.Now);
                                updateCmd.Parameters.AddWithValue("@userId", userId);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert a new account for the user
                            string insertQuery = "INSERT INTO Accounts (User_ID, Last_Login_Date, Last_Activity_Date) VALUES (@userId, @loginDate, @activityDate)";
                            using (var insertCmd = new MySqlCommand(insertQuery, connection))
                            {
                                insertCmd.Parameters.AddWithValue("@userId", userId);
                                insertCmd.Parameters.AddWithValue("@loginDate", DateTime.Now);
                                insertCmd.Parameters.AddWithValue("@activityDate", DateTime.Now);
                                insertCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error logging login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bunifuSnackbar1.Show(this.FindForm(), "Please try again later.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the ding sound on Enter
                SuccessfulLogIn(); // Call the login method
            }
        }
    }
}