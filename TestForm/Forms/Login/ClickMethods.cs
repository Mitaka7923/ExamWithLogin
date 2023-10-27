using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginPassword
{
    internal class ClickMethods
    {
        private LoginForm loginForm;

        public ClickMethods(LoginForm form)
        {
            loginForm = form;
        }

        internal void LoginButton_Click(object sender, EventArgs e)
        {
            var validator = new DataValidator(loginForm.usernames, loginForm.username);
            var inputUsername = loginForm.usernameBox.Text;
            var inputPassword = loginForm.passwordInput.Text;

            var correctUsername = validator.ValidateUsername(inputUsername);
            var correctPassword = validator.ValidatePassword(inputPassword);

            if (correctUsername && correctPassword && validator.CheckPassword(inputPassword))
            {
                loginForm.username = inputUsername;
                loginForm.Hide();
                var form2 = new CorrectUserForm(this.loginForm.username);
                form2.TopMost = true;
                form2.Show();
            }
            else
            {
                loginForm.passwordInfo.Visible = loginForm.Visible;
                loginForm.passwordInfo.ForeColor = Color.Red;

                loginForm.passwordInput.Text = "";
                loginForm.passwordInput.Focus();
            }
        }

        internal void passwordInput_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                loginForm.loginButton.PerformClick();
            }
        }
    }
}