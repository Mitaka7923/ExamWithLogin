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

        public List<CheckBox> GetCheckedBoxes()
        {
            var checkBoxes = new List<CheckBox>() { form.checkBox11C, form.checkBox12, form.checkBox13, form.checkBox14C, form.checkBox21C, form.checkBox22, form.checkBox23C, form.checkBox24, form.checkBox31C, form.checkBox32C, form.checkBox33, form.checkBox34, form.checkBox41, form.checkBox42, form.checkBox43C, form.checkBox44C, form.checkBox51C, form.checkBox52, form.checkBox53C, form.checkBox5C4 };
            var checkedBoxes = new List<CheckBox>();

            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    checkedBoxes.Add(checkBox);
                }
            }

            return checkedBoxes;
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
