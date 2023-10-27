using LoginPassword;
using System;
using System.Windows.Forms;

namespace TestForm.Forms.UserLogin.Register
{
    public partial class Register : Form
    {
        private RegisterClickMethods clickMethods;

        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.clickMethods = new RegisterClickMethods(this);
        }
    }
}
