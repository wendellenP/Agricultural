using System;
using System.Linq;
using System.Windows.Forms;
using Agricultural.SignUpControls;

namespace Agricultural
{
    public partial class SignUpForm : Form
    {
        private int currentControlIndex = 0;
        private UserControl[] userControls;

        public SignUpForm()
        {
            InitializeComponent();
            InitializeUserControls();
            ShowCurrentUserControl();
        }

        private void InitializeUserControls()
        {
            userControls = new UserControl[]
            {
                new NameBirthControl(),
                new AddressGenderControl(),
                new UsernamePasswordControl()
            };

            // Subscribe to the SignUpButton click event
            if (userControls[2] is UsernamePasswordControl lastControl)
            {
                lastControl.SignUpButton.Click += SignUpButton_Click;
            }
        }

        private void ShowCurrentUserControl()
        {
            AddUserControl(userControls[currentControlIndex]);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Get the current user control
            var currentControl = userControls[currentControlIndex];

            // Perform validation based on the current control type
            bool isValid = currentControl switch
            {
                NameBirthControl nameControl => nameControl.ValidateInput(),
                AddressGenderControl addressControl => addressControl.ValidateInput(),
                UsernamePasswordControl usernameControl => usernameControl.ValidateInput(),
                _ => false
            };

            // If the current control is valid, move to the next one
            if (isValid)
            {
                currentControlIndex++;

                if (currentControlIndex >= userControls.Length)
                {
                    currentControlIndex = 0; // Loop back to the first UserControl
                }

                AddUserControl(userControls[currentControlIndex]);
            }
            else
            {
                MessageBox.Show("Please correct the errors in the current section before proceeding.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddUserControl(UserControl userControl)
        {
            SignUpFillPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            SignUpFillPanel.Controls.Add(userControl);
            userControl.BringToFront();
            NextBtn.Visible = !(userControl is UsernamePasswordControl);
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var nameControl = userControls.OfType<NameBirthControl>().FirstOrDefault();
            var addressControl = userControls.OfType<AddressGenderControl>().FirstOrDefault();
            var usernameControl = userControls.OfType<UsernamePasswordControl>().FirstOrDefault();

            // Validate inputs from each control
            if (nameControl == null || addressControl == null || usernameControl == null ||
                !nameControl.ValidateInput() ||
                !addressControl.ValidateInput() ||
                !usernameControl.ValidateInput())
               
            {
                return; // Exit if any validation fails
            }

            // Check password confirmation
            if (usernameControl.Password != usernameControl.ConfirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Collect data from controls
            string firstName = nameControl.FirstName;
            string middleName = nameControl.MiddleName;
            string lastName = nameControl.LastName;
            DateTime birthDate = nameControl.BirthDayPick;

            string address = addressControl.Address;
            string phoneNumber = addressControl.PhoneNumber;
            string email = addressControl.Email;
            string gender = addressControl.Gender;

            string username = usernameControl.Username;
            string password = usernameControl.Password;

            // Show success message
            MessageBox.Show($"Sign-up successful! \nHi {firstName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
            LogInForm login = new LogInForm();
            login.Show();
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LogInForm login = new LogInForm();
            login.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}