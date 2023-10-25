using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPassword
{
    public partial class LoginForm : Form
    {
        public static string username = "dsideriss"; 
        public static string password = "Dimitar2002";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var inputUsername = usernameBox.Text;
            var inputPassword = passwordInput.Text;

            var correctUsername = CheckCorrection(inputUsername, username);
            var correctPassword = CheckCorrection(inputPassword, password);

            if (correctUsername && correctPassword && CheckPasswordValidity(inputPassword))
            {
                var form2 = new CorrectUserForm();
                form2.TopMost = true;
                form2.Show();

                this.Hide();
            }
            else
            {
                passwordInfo.Visible = Visible;
                passwordInfo.ForeColor = Color.Red;

                passwordInput.Text = "";
                passwordInput.Focus();
            }
        }

        private bool CheckPasswordValidity(string password)
        {
            var regex = new Regex(@"^(?=.*[0-9])(?=.*[A-Z]).{8,}$");
            var match = regex.Match(password);

            return match.Success;
        }

        private bool CheckCorrection(string text, string correctText)
        {
            if (text.Trim().Equals(correctText))
            {
                return true;
            }

            return false;
        }
    }
}
