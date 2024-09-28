using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using MySql.Data.MySqlClient;

namespace Agricultural
{
    public partial class sendVerificationCodecs : Form
    {
        private string recipientEmail;
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        private int invalidAttempts = 0; // Counter for invalid attempts
        private TimeSpan remainingTime;

        public sendVerificationCodecs(string email)
        {
            InitializeComponent();
            recipientEmail = email;
            emailAddressLbl.Text = recipientEmail;
            getUsernameProfile();

            sendCodeRadioBtn.Cursor = Cursors.Hand;
            backLogInRadioBtn.Cursor = Cursors.Hand;
            notBtn.Cursor = Cursors.Hand;
            continueBtn.Cursor = Cursors.Hand;
        }

        public void getUsernameProfile()
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Username, Profile_Picture FROM beneficiaries WHERE Email = @Email";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", recipientEmail);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string username = reader["Username"].ToString();
                            string profilePicturePath = reader["Profile_Picture"].ToString(); // Get the file path

                            profileName.Text = username;

                            if (!string.IsNullOrEmpty(profilePicturePath))// Check if the file exists
                            {
                                try
                                {
                                    // Load the image from the file path
                                    Image profileImage = Image.FromFile(profilePicturePath);
                                    ProfilePicture.Image = profileImage; // Set the image to Guna2CirclePictureBox
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Error loading image: {ex.Message}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No valid profile picture found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No user found with that email.");
                        }
                    }
                }
            }
        }

        private async void continueBtn_Click(object sender, EventArgs e)
        {
            bunifuSnackbar1.Show(this.FindForm(), "Please wait for a moment...",
                      Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Information);
            if (sendCodeRadioBtn.Checked)
                {
                continueBtn.Enabled = false;
                //sendingLbl.Visible = true;
                await SendVerificationCode(recipientEmail); // Call the method to send the verification code
               
            }
            else if (backLogInRadioBtn.Checked)
            {
                    Hide(); // Hide the current form
                    LogInForm logIn = new LogInForm(); // Create a new instance of LogInForm
                    logIn.Show(); // Show the new form
            }
        }

        private async Task SendVerificationCode(string recipientEmail)
        {
           
            Random random = new Random();
            int verificationCode = random.Next(100000, 1000000);

            StoreVerificationCodeInDatabase(recipientEmail, verificationCode);

            try
            {
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new NetworkCredential("j.bolocano2468013579@gmail.com", "rvkuxwnugzgtujlh");
                    smtpClient.EnableSsl = true;

                    MailMessage mailMessage = new MailMessage
                    {
                        From = new MailAddress("j.bolocano2468013579@gmail.com"),
                        Subject = "Verification Code",
                        Body = "Your verification code is: " + verificationCode
                    };
                    mailMessage.To.Add(recipientEmail);
                        
                    await smtpClient.SendMailAsync(mailMessage);
                    
                    //MessageBox.Show("Verification code sent successfully to " + recipientEmail);
                    inputVerificationCode verificationForm = new inputVerificationCode(recipientEmail);
                    verificationForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error sending email: " + ex.Message);
                
                    backEndErrorMessage.Show(this.FindForm(), "Something went wrong. Please try again later.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error);
                    Hide();
                    LogInForm logInForm = new LogInForm();
                    logInForm.Show();
                
            }
        }

        private void StoreVerificationCodeInDatabase(string email, int code)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE beneficiaries SET VerificationCode = @code, VerificationCodeTimestamp = @timestamp WHERE Email = @Email";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@code", code);
                        command.Parameters.AddWithValue("@timestamp", DateTime.Now);
                        command.Parameters.AddWithValue("@Email", email);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error storing verification code: " + ex.Message);
            }
        }

        private void notBtn_Click(object sender, EventArgs e)
        {
            Hide(); // Hide the current form
            emailVerify email = new emailVerify(); // Create a new instance of LogInForm
            email.Show(); // Show the new form
        }
    }
}