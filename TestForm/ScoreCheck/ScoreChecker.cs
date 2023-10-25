using System.Collections.Generic;
using System.Windows.Forms;

namespace TestForm.ScoreCheck
{
    class ScoreChecker
    {
        public double UserScore { get; set; }

        internal Test form;
        private List<TextBox> textBoxes;
        private List<CheckBox[]> correctCheckBoxes;

        public ScoreChecker(Test form)
        {
            this.form = form;
            this.textBoxes = new List<TextBox>() { this.form.textBox1, this.form.textBox2, this.form.textBox3, this.form.textBox4, this.form.textBox5 };
            this.correctCheckBoxes = new List<CheckBox[]>() {
                new CheckBox[] { this.form.checkBox11C, this.form.checkBox14C },
                new CheckBox[] { this.form.checkBox21C, this.form.checkBox23C },
                new CheckBox[] { this.form.checkBox31C, this.form.checkBox32C },
                new CheckBox[] { this.form.checkBox44C, this.form.checkBox43C },
                new CheckBox[] { this.form.checkBox51C, this.form.checkBox53C, this.form.checkBox5C4 } };
        }

        internal void SetStudentScore()
        {
            var func = new CheckAnswersFunctionallity(this.form);

            func.CheckRadioAnswers(this.form);
            func.CheckCheckBoxAnswers(correctCheckBoxes);
            func.CheckOpenAnswers(textBoxes);

            this.UserScore = func.userScore;
        }
    }
}
