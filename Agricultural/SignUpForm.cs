using System;
using System.Configuration;
using System.Data.SqlClient; // Use the appropriate namespace for your database
using System.Linq;
using System.Windows.Forms;
using Agricultural.SignUpControls;
using MySql.Data.MySqlClient;

namespace Agricultural
{
    public partial class SignUpForm : Form
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

        private int currentControlIndex = 0;
        private UserControl[] userControls;

        public SignUpForm()
        {
            InitializeComponent();
            try
            {
                InitializeUserControls();
                ShowCurrentUserControl();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"A null reference occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            // Hash the password using bcrypt
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            // Insert data into the Beneficiaries table
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Check for duplicate username
                string duplicateUsernameQuery = "SELECT COUNT(*) FROM Beneficiaries WHERE Username = @Username";
                int usernameCount;

                using (MySqlCommand duplicateUsernameCommand = new MySqlCommand(duplicateUsernameQuery, connection))
                {
                    duplicateUsernameCommand.Parameters.AddWithValue("@Username", username);
                    usernameCount = Convert.ToInt32(duplicateUsernameCommand.ExecuteScalar());
                }

                // Check if email or username already exists
                if (usernameCount > 0)
                {
                    usernameMessage.Show(this.FindForm(), "Username already exists.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    return; // Prevent navigation
                }

                // Insert Beneficiary
                string beneficiaryQuery = "INSERT INTO Beneficiaries (First_Name, Middle_Name, Last_Name, Username, Phone_Number, Email, Address, Birth_Date, Gender, Password_Hash) " +
                                           "VALUES (@FirstName, @MiddleName, @LastName, @Username, @PhoneNumber, @Email, @Address, @BirthDate, @Gender, @PasswordHash)";

                long userId;

                using (MySqlCommand command = new MySqlCommand(beneficiaryQuery, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@MiddleName", middleName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@BirthDate", birthDate);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@PasswordHash", passwordHash);

                    command.ExecuteNonQuery();
                    userId = command.LastInsertedId; // Store the User_ID
                }

                // Insert Account record
                string accountQuery = "INSERT INTO Accounts (User_ID) VALUES (@UserID)";
                using (MySqlCommand accountCommand = new MySqlCommand(accountQuery, connection))
                {
                    accountCommand.Parameters.AddWithValue("@UserID", userId);
                    accountCommand.ExecuteNonQuery();
                }
            }

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