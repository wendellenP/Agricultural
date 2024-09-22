using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Agricultural.SignUpControls
{
    public partial class NameBirthControl : UserControl
    {
        public NameBirthControl()
        {
            InitializeComponent();
            this.Load += NameBirthControl_Load;
            // Initially hide error messages
            fnameErrorMessage.Visible = false;
            lnameErrorMessage.Visible = false;
            invalidMessageFname.Visible = false;
            invalidMessageMname.Visible = false;
            invalidMessageLname.Visible = false;
        }

        private void NameBirthControl_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization logic you need when the control loads
        }

        public string FirstName => FnameTxt.Text;
        public string MiddleName => MNameTxt.Text;
        public string LastName => LNameTxt.Text;
        public DateTime BirthDayPick => BirthDayPicker.Value;

        // Validate the input fields
        public bool ValidateInput()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                DisplayErrorChangeColor(fnameErrorMessage, FnameTxt);
                isValid = false;
            }
            else if (!IsValidName(FirstName))
            {
                InvalidInput(FnameTxt, invalidMessageFname);
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                DisplayErrorChangeColor(lnameErrorMessage, LNameTxt);
                isValid = false;
            }
            else if (!IsValidName(LastName))
            {
                InvalidInput(LNameTxt, invalidMessageLname);
                isValid = false;
            }

            return isValid;
        }

        private bool IsValidName(string name)
        {
            string pattern = @"^[A-Za-z\s'-]+$"; // Allows letters, spaces, apostrophes, and hyphens
            return Regex.IsMatch(name, pattern);
        }

        private void FnameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(FirstName))
            {
                fnameErrorMessage.Visible = false;
                FnameTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                invalidMessageFname.Visible = false; // Hide invalid message
            }
        }

        private void LNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LastName))
            {
                lnameErrorMessage.Visible = false;
                LNameTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
                invalidMessageLname.Visible = false; // Hide invalid message
            }
        }

        private void DisplayErrorChangeColor(Label label, Guna.UI2.WinForms.Guna2TextBox textBox)
        {
            label.Visible = true;
            textBox.BorderColor = System.Drawing.Color.Red;
        }

        private void InvalidInput(Guna.UI2.WinForms.Guna2TextBox textBox, Label label)
        {
            label.Visible = true;
            textBox.BorderColor = System.Drawing.Color.Red;
        }
    }
}