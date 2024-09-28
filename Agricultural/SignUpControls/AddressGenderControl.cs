using System;
using System.Configuration;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Agricultural.SignUpControls
{
    public partial class AddressGenderControl : UserControl
    {

        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        public AddressGenderControl()
        {
            InitializeComponent();
            addressErrorMessage.Visible = false;
            phoneNumberErrorMessage.Visible = false;
            emailErrorMessage.Visible = false;
            
            maleGender.Cursor = Cursors.Hand;
            femaleGender.Cursor = Cursors.Hand;
            otherGender.Cursor = Cursors.Hand;
        }

        public string Address => AddressTxt.Text;
        public string PhoneNumber => PhoneNumberTxt.Text;
        public string Email => EmailAddressTxt.Text;
        public string Gender => GetGender();

        private string GetGender()
        {
            if (maleGender.Checked) return "Male";
            if (femaleGender.Checked) return "Female";
            if (otherGender.Checked) return "Others";
            return null;
        }

        public bool ValidateInput()
        {
            bool isValid = true;

            // Validate Address
            if (string.IsNullOrWhiteSpace(Address))
            {
                DisplayErrorChangeColor(addressErrorMessage, AddressTxt, "This is required!");
                isValid = false;
            }
            else
            {
                addressErrorMessage.Visible = false; // Hide error if valid
                AddressTxt.BorderColor = SystemColors.WindowFrame; // Reset color if valid
            }

            // Validate Phone Number
            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                DisplayErrorChangeColor(phoneNumberErrorMessage, PhoneNumberTxt, "This is required!");
                isValid = false;
            }
            else if (!IsValidPhoneNumber(PhoneNumber))
            {
                DisplayErrorChangeColor(phoneNumberErrorMessage, PhoneNumberTxt, "Provide a valid phone number"); // Show invalid message
                isValid = false;
            }
            else
            {
                phoneNumberErrorMessage.Visible = false; // Hide error if valid
                PhoneNumberTxt.BorderColor = SystemColors.WindowFrame; // Reset color if valid
            }

            // Validate Email
            if (string.IsNullOrWhiteSpace(Email))
            {
                DisplayErrorChangeColor(emailErrorMessage, EmailAddressTxt, "This is required!");
                isValid = false;
            }
            else if (!IsValidEmail(Email))
            {
                DisplayErrorChangeColor(emailErrorMessage, EmailAddressTxt, "Provide a valid email address");
                isValid = false;
            }
            else if (!IsEmailUnique(Email))
            {
                DisplayErrorChangeColor(emailErrorMessage, EmailAddressTxt, "Email address is already exists.");
                isValid = false;
            }
            else
            {
                emailErrorMessage.Visible = false; // Hide error if valid
                EmailAddressTxt.BorderColor = SystemColors.WindowFrame; // Reset color if valid
            }

            return isValid;
        }

        private void DisplayErrorChangeColor(Label label, Guna.UI2.WinForms.Guna2TextBox textBox, string message)
        {
            label.Visible = true;
            label.Text = message;
            textBox.BorderColor = Color.Red; // Change border color to red
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Implement a regex or logic to validate phone numbers
            return Regex.IsMatch(phoneNumber, @"^\d{10}$"); // Example: Validates 10-digit phone numbers
        }

        private bool IsValidEmail(string email)
        {
            // Implement a regex or logic to validate email
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"); // Basic email validation
        }

        private void AddressTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Address))
            {
                addressErrorMessage.Visible = false;
                AddressTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private bool IsEmailUnique(string email)
        {
            using MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            string query = "SELECT COUNT(*) FROM Beneficiaries WHERE Email = @Email";
            using MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@Email", email);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count == 0; // Return true if no existing email found
        }

        private void EmailAddressTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Email))
            {
                emailErrorMessage.Visible = false;
                EmailAddressTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void PhoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PhoneNumber))
            {
                phoneNumberErrorMessage.Visible = false;
                PhoneNumberTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }
    }
}