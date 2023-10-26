using System.Collections.Generic;
using System.Windows.Forms;

namespace TestForm.GetUserInput
{
    class GetUserInput
    {
        private Test form;

        public GetUserInput(Test form)
        {
            this.form = form;
        }

        public int GetCheckedBoxes(CheckBox[] checkBoxPair)
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

        public List<RadioButton> GetCheckedRadio()
        {
            var radioButtons = new List<RadioButton>() { form.aAnswerC1, form.bAnswer1, form.cAnswer1, form.aAnswer2, form.bAnswer2, form.cAnswerC2, form.aAnswer3, form.bAnswerC3, form.cAnswer3, form.aAnswer4, form.bAnswer4, form.cAnswerC4, form.aAnswer5, form.bAnswerC5, form.cAnswer5 };

            var checkedRadio = new List<RadioButton>();
            foreach (var button in radioButtons)
            {
                if (button.Checked)
                {
                    checkedRadio.Add(button);
                }
            }

            return checkedRadio;
        }
    }
}
