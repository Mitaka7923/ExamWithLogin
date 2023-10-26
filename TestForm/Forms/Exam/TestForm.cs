using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestForm.ScoreCheck;
using TestForm.Initialization;
using LoginPassword;

namespace TestForm
{
    public partial class Test : Form
    {
        internal ScoreChecker scoreChecker;
        internal string username;
        internal List<GroupBox> groupBoxes;
        internal GetUserInput.GetUserInput userInput;

        public Test(string username)
        {
            this.username = username;
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            this.userInput = new GetUserInput.GetUserInput(this);
            this.scoreChecker = new ScoreChecker(this);

            var questions = Questions.GetQuestions();
            this.groupBoxes = new List<GroupBox>() { this.groupBox1, this.groupBox2, this.groupBox3, this.groupBox4, this.groupBox5, this.groupBox6, this.groupBox7, this.groupBox8, this.groupBox9, this.groupBox10, this.groupBox11, this.groupBox12, this.groupBox13, this.groupBox14, this.groupBox15 };

            InitializeTestForm.SetQuestions(questions, groupBoxes);
        }

        private void checkAnswersButton_Click(object sender, EventArgs e)
        {
            this.continueButton.Enabled = true;
            this.scoreChecker.form = this;
            this.scoreChecker.SetStudentScore();
            this.continueButton.Focus();
            this.checkAnswersButton.Enabled = false;

            foreach (var groupBox in this.groupBoxes)
            {
                foreach (Control c in groupBox.Controls)
                {
                    c.Enabled = false;
                }
            }
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var scoreForm = new ScoreForm(this.scoreChecker.UserScore, this.username);
            scoreForm.Show();
        }

        private void TextBoxResetColor(TextBox textBox) => textBox.BackColor = Color.White;
        private void textBox1_TextChanged(object sender, EventArgs e) => TextBoxResetColor(this.textBox1);
        private void textBox2_TextChanged(object sender, EventArgs e) => TextBoxResetColor(this.textBox2);
        private void textBox3_TextChanged(object sender, EventArgs e) => TextBoxResetColor(this.textBox3);
        private void textBox4_TextChanged(object sender, EventArgs e) => TextBoxResetColor(this.textBox4);
        private void textBox5_TextChanged(object sender, EventArgs e) => TextBoxResetColor(this.textBox5);
    }
}
