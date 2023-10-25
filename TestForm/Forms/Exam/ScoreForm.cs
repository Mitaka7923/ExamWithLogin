using System;
using System.Windows.Forms;
using TestForm.ScoreCheck;

namespace TestForm
{
    public partial class ScoreForm : Form
    {
        private double userScore;
        private double userGrade;
        private string username;

        public ScoreForm(double score, string username)
        {
            InitializeComponent();

            this.username = username;
            this.title.Text = $"{this.username} предаде теста си"; 
            this.userScore = score;
            this.userGrade = Grade.SetGrade(this.userScore);
        }

        private void ScoreForm_Load(object sender, EventArgs e)
        {
            this.scoreDisplayLabel.Text = $"{this.userScore:F2}";
            var gradeText = "Слаб";

            if (this.userGrade >= 5.5)
                gradeText = "Отличен";
            else if (this.userGrade >= 4.50)
                gradeText = "Много добър";
            else if (this.userGrade >= 3.50)
                gradeText = "Добър";
            else if (this.userGrade >= 2.5)
                gradeText = "Среден";

            this.gradeDisplayLabel.Text = $"{gradeText} {(this.userGrade < 2 ? 2 : this.userGrade):F2}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
