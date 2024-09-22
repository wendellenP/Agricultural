using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agricultural
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void SignUpBtnPanel_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpForm form = new SignUpForm();
            form.Show();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {

        }

        public Button LogInBtn
        {
            get { return LogInBtn; }
        }

        private void closeCtrl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
