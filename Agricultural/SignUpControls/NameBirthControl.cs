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
            InitializeErrorMessageVisibility();
            this.Load += NameBirthControl_Load;
            // Initially hide error messages
           
            BirthDayPicker.Cursor = Cursors.Hand;
        }

        private void NameBirthControl_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization logic you need when the control loads
        }

        private void InitializeErrorMessageVisibility()
        {
            fnameErrorMessage.Visible = false;
            lnameErrorMessage.Visible = false;
            invalidMessageMname.Visible = false;

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
                DisplayErrorChangeColor(fnameErrorMessage, FnameTxt, "This is required!");
                isValid = false;
            }
            else if (!IsValidName(FirstName))
            {
                InvalidInput(FnameTxt, fnameErrorMessage, "Please provide your valid first name.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(LastName))
            {
                DisplayErrorChangeColor(lnameErrorMessage, LNameTxt, "This is required");
                isValid = false;
            }
            else if (!IsValidName(LastName))
            {
                InvalidInput(LNameTxt, lnameErrorMessage, "Please provide your valid last name");
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
            }
        }

        private void LNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(LastName))
            {
                lnameErrorMessage.Visible = false;
                LNameTxt.BorderColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
        }

        private void DisplayErrorChangeColor(Label label, Guna.UI2.WinForms.Guna2TextBox textBox, string message)
        {
            label.Visible = true;
            label.Text = message;
            textBox.BorderColor = System.Drawing.Color.Red;
        }

        private void InvalidInput(Guna.UI2.WinForms.Guna2TextBox textBox, Label label, string message)
        {
            label.Visible = true;
            label.Text = message;
            textBox.BorderColor = System.Drawing.Color.Red;
        }
    }
}