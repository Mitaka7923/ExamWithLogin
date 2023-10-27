using System;
using System.Windows.Forms;
using TestForm;

namespace LoginPassword
{
    public partial class CorrectUserForm : Form
    {
        private string username;

        public CorrectUserForm(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CorrectUserForm_Load(object sender, EventArgs e)
        {
            this.welcomeLabel.Text += $" {this.username}"; //ttt+
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            this.Hide();
            var examForm = new Test(this.username);
            examForm.Show();
        }
    }
}
