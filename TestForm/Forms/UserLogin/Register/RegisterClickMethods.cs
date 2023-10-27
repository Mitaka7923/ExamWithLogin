using System;
using System.Windows.Forms;
using TestForm.Forms.UserLogin.Register;

namespace LoginPassword
{
    internal class RegisterClickMethods
    {
        private Register registerForm;

        public RegisterClickMethods(Register form)
        {
            this.registerForm = form;
        }

        internal void passwordInput_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                registerForm.registerButton.PerformClick();
            }
        }
    }
}