using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Agricultural.SignUpControls
{
    public partial class AddressGenderControl : UserControl
    {
        public AddressGenderControl()
        {
            InitializeComponent();
            addressErrorMessage.Visible = false;
            phoneNumberErrorMessage.Visible = false;
            emailErrorMessage.Visible = false;
            invalidMessagePhoneNumber.Visible = false;
            invalidMessageEmail.Visible = false;
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
                DisplayErrorChangeColor(addressErrorMessage, AddressTxt);
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
                DisplayErrorChangeColor(phoneNumberErrorMessage, PhoneNumberTxt);
                isValid = false;
            }
            else if (!IsValidPhoneNumber(PhoneNumber))
            {
                ValidPhoneNumber(); // Show invalid message
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
                DisplayErrorChangeColor(emailErrorMessage, EmailAddressTxt);
                isValid = false;
            }
            else if (!IsValidEmail(Email))
            {
                ValidEmail(); // Show invalid message
                isValid = false;
            }
            else
            {
                emailErrorMessage.Visible = false; // Hide error if valid
                EmailAddressTxt.BorderColor = SystemColors.WindowFrame; // Reset color if valid
            }

            return isValid;
        }

        private void DisplayErrorChangeColor(Label label, Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            label.Visible = true;
            textBox.BorderColor = Color.Red; // Change border color to red
        }

        private void ValidPhoneNumber()
        {
            invalidMessagePhoneNumber.Visible = true; // Show invalid phone number message
        }

        private void ValidEmail()
        {
            invalidMessageEmail.Visible = true; // Show invalid email message
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

        private void EmailAddressTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Email))
            {
                emailErrorMessage.Visible = false;
                EmailAddressTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                invalidMessageEmail.Visible = false; // Hide invalid message
            }
        }

        private void PhoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(PhoneNumber))
            {
                phoneNumberErrorMessage.Visible = false;
                PhoneNumberTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                invalidMessagePhoneNumber.Visible = false; // Hide invalid message
            }
        }
    }
}