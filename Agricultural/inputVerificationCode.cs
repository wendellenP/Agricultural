using System;
using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;

namespace Agricultural
{
    public partial class inputVerificationCode : Form
    {
        private string recipientEmail;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        private int invalidAttempts = 0; // Counter for invalid attempts
        private TimeSpan remainingTime;

        public inputVerificationCode(string email)
        {
            InitializeComponent();
            recipientEmail = email; // Store the provided email
            errorMessageLbl.Visible = false;

            remainingTime = TimeSpan.FromMinutes(3); // Set countdown duration to 3 minutes
            countDownTime.Interval = 1000; // Set timer interval to 1 second
            countDownTime.Tick += countDownTime_Tick; // Attach event handler

            // Attach KeyPress event handlers
            AttachKeyPressEvents();
            displayEmail.Text = "A verification code has been sent to \n" + recipientEmail;

            sendBtn.Cursor = Cursors.Hand;
            backLogInLbl.Cursor = Cursors.Hand;
            backToSendCodeForm.Cursor = Cursors.Hand;
        }

        private void AttachKeyPressEvents()
        {
            // Assuming your text box names are Guna2TextBox types
            firstDigit.KeyPress += SingleDigitTextBox_KeyPress;
            secodeDigit.KeyPress += SingleDigitTextBox_KeyPress;
            thirdDigit.KeyPress += SingleDigitTextBox_KeyPress;
            fourthDigit.KeyPress += SingleDigitTextBox_KeyPress;
            fifthDigit.KeyPress += SingleDigitTextBox_KeyPress;
            sixDigit.KeyPress += SingleDigitTextBox_KeyPress;

            // Attach Leave event to move focus
            firstDigit.Leave += MoveToNextTextBox;
            secodeDigit.Leave += MoveToNextTextBox;
            thirdDigit.Leave += MoveToNextTextBox;
            fourthDigit.Leave += MoveToNextTextBox;
            fifthDigit.Leave += MoveToNextTextBox;
        }

        private void SingleDigitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits (0-9) and control characters (like backspace)
            if (!char.IsControl(e.KeyChar) && (e.KeyChar < '0' || e.KeyChar > '9'))
            {
                e.Handled = true; // Reject the input
            }

            // Ensure only one digit can be entered
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox; // Adjust to Guna2TextBox
            if (textBox != null && textBox.Text.Length >= 1 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Reject the input if already one digit is present
            }
            else
            {
                // Reset error message and color when valid input
                errorMessageLbl.Visible = false;
                textBox.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void MoveToNextTextBox(object sender, EventArgs e)
        {
            var textBox = sender as Guna.UI2.WinForms.Guna2TextBox;
            if (textBox != null && textBox.Text.Length == 1)
            {
                SelectNextTextBox(textBox);
            }
            else
            {
                // Optional: Set border to red if text box is empty
                textBox.BorderColor = Color.Red;
            }
        }

        private void SelectNextTextBox(Guna.UI2.WinForms.Guna2TextBox currentTextBox)
        {
            if (currentTextBox == firstDigit)
            {
                secodeDigit.Focus();
            }
            else if (currentTextBox == secodeDigit)
            {
                thirdDigit.Focus();
            }
            else if (currentTextBox == thirdDigit)
            {
                fourthDigit.Focus();
            }
            else if (currentTextBox == fourthDigit)
            {
                fifthDigit.Focus();
            }
            else if (currentTextBox == fifthDigit)
            {
                sixDigit.Focus();
            }
        }

        private void verifyCodeBtn_Click(object sender, EventArgs e)
        {
            // Verify the entered code when the button is clicked
            sendBtn_Click(sender, e); // Call the same method as the send button for verification
        }

        private bool ValidateVerificationCode(string email, int enteredCode)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT VerificationCode, VerificationCodeTimestamp FROM Beneficiaries WHERE Email = @Email";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int storedCode = reader.GetInt32("VerificationCode");
                                DateTime timestamp = reader.GetDateTime("VerificationCodeTimestamp");

                                // Check if the entered code matches and is not expired (3 minutes)
                                if (storedCode == enteredCode && (DateTime.Now - timestamp).TotalMinutes < 3)
                                {
                                    return true; // Code is valid
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating verification code: " + ex.Message);
            }
            return false; // Code is invalid or expired
        }

        private void HandleInvalidAttempt()
        {
            invalidAttempts++; // Increment the invalid attempt counter
            if (invalidAttempts >= 3)
            {
                TooManyAttemptSendCode();
                Hide();
                LogInForm form = new LogInForm();
                form.Show();
            }
            else
            {
                VerificationCode();
            }
        }

        private void CheckEmpty()
        {
            if (string.IsNullOrEmpty(firstDigit.Text)) // Check if the first box is empty
            {
                errorMessageLbl.Text = "Provide the verification code.";
                errorMessageLbl.Visible = true;
                firstDigit.BorderColor = Color.Red;
            }
        }

        private void VerificationCode()
        {
            ChangeColorError();
            ClearCodeTextBoxes();
            errorMessageLbl.Text = "Incorrect verification code.";
            errorMessageLbl.Visible = true;
            firstDigit.BorderColor = Color.Red;
        }

        private void TooManyAttemptSendCode()
        {
            errorMessageLbl.Text = "Too many invalid attempts. Please try again later.";
            errorMessageLbl.Visible = true;
            firstDigit.BorderColor = Color.Red;
        }

        private bool ValidCode(string input) => Regex.IsMatch(input, @"^\d+$"); // Check if input is numeric

        private void inputVerificationCode_Load(object sender, EventArgs e)
        {
            // Display initial time
            countDownCode.Text = remainingTime.ToString(@"mm\:ss");
            // Start the countdown timer
            StartTimer();
        }

        private void countDownTime_Tick(object sender, EventArgs e)
        {
            if (remainingTime.TotalSeconds > 0)
            {
                // Decrease remaining time by 1 second
                remainingTime = remainingTime.Subtract(TimeSpan.FromSeconds(1));
                // Update the label with the remaining time
                countDownCode.Text = remainingTime.ToString(@"mm\:ss");
            }
            else
            {
                // Stop the timer when it reaches zero
                countDownTime.Stop();
                // Only show the expiration message if verification was not successful
                if (!isVerificationSuccessful)
                {
                    bunifuSnackbar1.Show(this.FindForm(), "Time expired!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    countDownCode.ForeColor = Color.Red;
                    // Handle expiration logic here
                }
            }
        }

        private void backLogInLbl_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }

        private void ClearCodeTextBoxes()
        {
            firstDigit.Text = "";    // Reset the first digit
            secodeDigit.Text = "";    // Reset the second digit
            thirdDigit.Text = "";     // Reset the third digit
            fourthDigit.Text = "";    // Reset the fourth digit
            fifthDigit.Text = "";     // Reset the fifth digit
            sixDigit.Text = "";       // Reset the sixth digit
        }

        private void ChangeColorError()
        {
            firstDigit.BorderColor = Color.Red;
            secodeDigit.BorderColor = Color.Red;
            thirdDigit.BorderColor = Color.Red;
            fourthDigit.BorderColor = Color.Red;
            fifthDigit.BorderColor = Color.Red;
            sixDigit.BorderColor = Color.Red;
        }

        private bool isVerificationSuccessful = false; // Flag to track verification success

        private void sendBtn_Click(object sender, EventArgs e)
        {
            // Check if any of the text boxes are empty
            if (string.IsNullOrEmpty(firstDigit.Text) ||
                string.IsNullOrEmpty(secodeDigit.Text) ||
                string.IsNullOrEmpty(thirdDigit.Text) ||
                string.IsNullOrEmpty(fourthDigit.Text) ||
                string.IsNullOrEmpty(fifthDigit.Text) ||
                string.IsNullOrEmpty(sixDigit.Text))
            {
                // Set all text box borders to red
                firstDigit.BorderColor = Color.Red;
                secodeDigit.BorderColor = Color.Red;
                thirdDigit.BorderColor = Color.Red;
                fourthDigit.BorderColor = Color.Red;
                fifthDigit.BorderColor = Color.Red;
                sixDigit.BorderColor = Color.Red;

                // Display an error message
                ClearCodeTextBoxes();
                errorMessageLbl.Text = "Please provide the complete verification code.";
                errorMessageLbl.Visible = true;
                return; // Exit the method early
            }

            // Combine digits from all text boxes into a single code
            string code = $"{firstDigit.Text}{secodeDigit.Text}{thirdDigit.Text}{fourthDigit.Text}{fifthDigit.Text}{sixDigit.Text}";

            if (ValidCode(code)) // Check if the input is numeric
            {
                int enteredCode = int.Parse(code); // Convert to integer

                if (ValidateVerificationCode(recipientEmail, enteredCode))
                {
                    // Code is valid, proceed to update password
                    isVerificationSuccessful = true; // Set the flag to true
                    Hide();
                    Update_Password updatePasswordForm = new Update_Password(recipientEmail);
                    updatePasswordForm.Show();
                }
                else
                {
                    HandleInvalidAttempt();
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid numeric code.");
                ClearCodeTextBoxes();
                firstDigit.BorderColor = Color.Red; // Highlight the first box for feedback
            }
        }

       

        private void backToSendCodeForm_Click(object sender, EventArgs e)
        {
            Hide();
            sendVerificationCodecs send = new sendVerificationCodecs(recipientEmail);
            send.Show();
        }

        private void StartTimer()
        {
            if (!countDownTime.Enabled)
            {
                countDownTime.Start();
            }
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle the text change in the first digit TextBox
            string text = firstDigit.Text;
            if (text.Length > 1)
            {
                // Split the characters and assign them to the respective TextBoxes
                char[] digits = text.ToCharArray();
                DistributeCodeAcrossTextBoxes(new string(digits));
                MoveFocusToLastFilledTextBox(digits.Length);
            }
            else if (text.Length == 1)
            {
                // Move to the next TextBox if only one character is entered
                secodeDigit.Focus();
            }
        }

        private void DistributeCodeAcrossTextBoxes(string code)
        {
            if (code.Length >= 1) firstDigit.Text = code[0].ToString();
            if (code.Length >= 2) secodeDigit.Text = code[1].ToString();
            if (code.Length >= 3) thirdDigit.Text = code[2].ToString();
            if (code.Length >= 4) fourthDigit.Text = code[3].ToString();
            if (code.Length >= 5) fifthDigit.Text = code[4].ToString();
            if (code.Length >= 6) sixDigit.Text = code[5].ToString();
        }

        private void MoveFocusToLastFilledTextBox(int length)
        {
            if (length >= 6) sixDigit.Focus();
            else if (length == 5) fifthDigit.Focus();
            else if (length == 4) fourthDigit.Focus();
            else if (length == 3) thirdDigit.Focus();
            else if (length == 2) secodeDigit.Focus();
        }

        private void secodeDigit_TextChanged(object sender, EventArgs e) => thirdDigit.Focus();
        private void thirdDigit_TextChanged(object sender, EventArgs e) => fourthDigit.Focus();
        private void fourthDigit_TextChanged(object sender, EventArgs e) => fifthDigit.Focus();
        private void fifthDigit_TextChanged(object sender, EventArgs e) => sixDigit.Focus();
        private void sixDigit_TextChanged(object sender, EventArgs e) => firstDigit.Focus();
    }
}