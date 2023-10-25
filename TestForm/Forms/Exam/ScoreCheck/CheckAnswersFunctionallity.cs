using System.Collections.Generic;
using System.Windows.Forms;
using static TestForm.ColorManipulation.ColorManipulation;

namespace TestForm.ScoreCheck
{
    class CheckAnswersFunctionallity
    {
        private Test form;
        private static string[] textCorrect = new string[] { "2", "86400", "Септември", "Да", "17" };
        internal double userScore;

        public CheckAnswersFunctionallity(Test form)
        {
            this.form = form;
        }

        internal void CheckOpenAnswers(List<TextBox> textAnswers)
        {
            for (int i = 0; i < textCorrect.Length; i++)
            {
                if (textAnswers[i].Text.Contains(textCorrect[i]))
                {
                    this.userScore++;
                    ChangeColor("correct", textAnswers[i].Parent);
                }
                else
                {
                    ChangeColor("incorrect", textAnswers[i].Parent);
                }
            }
        }

        internal void CheckRadioAnswers(Test form)
        {
            var correctRadioButtons = new List<RadioButton>() { this.form.aAnswerC1, this.form.cAnswerC2, this.form.bAnswerC3, this.form.cAnswerC4, this.form.bAnswerC5 };
            var checkedRadio = this.form.userInput.GetCheckedRadio();

            foreach (var button in correctRadioButtons)
            {
                ChangeColor("incorrect", button.Parent);
            }

            checkedRadio.ForEach(radio =>
            {
                if (correctRadioButtons.Contains(radio))
                {
                    this.userScore+=1;
                    ChangeColor("correct", radio.Parent);
                }
            });
        }

        internal void CheckCheckBoxAnswers(List<CheckBox[]> correctCheckBoxes)
        {
            foreach (var checkBoxPair in correctCheckBoxes)
            {
                var checkedCounter = GetCheckedBoxes(checkBoxPair);

                if (checkBoxPair != correctCheckBoxes[4] &&
                    checkedCounter > 1)
                {
                    this.userScore+=1;
                    ChangeColor("correct", checkBoxPair[0].Parent);
                }
                else if (checkedCounter == 3 && checkBoxPair == correctCheckBoxes[4])
                {
                    this.userScore+=1;
                    ChangeColor("correct", checkBoxPair[0].Parent);
                }
                else if ((checkedCounter < 3 && checkedCounter > 1 && checkBoxPair == correctCheckBoxes[4]) || checkedCounter == 1)
                {
                    this.userScore += 0.5;
                    ChangeColor("partialy-correct", checkBoxPair[0].Parent);
                }
                else
                {
                    ChangeColor("incorrect", checkBoxPair[0].Parent);
                }
            }
        }

        private int GetCheckedBoxes(CheckBox[] checkBoxPair)
        {
            var checkedCounter = 0;

            foreach (var checkBox in checkBoxPair)
            {
                if (checkBox.Checked)
                {
                    checkedCounter++;
                }
            }

            return checkedCounter;
        }
    }
}
