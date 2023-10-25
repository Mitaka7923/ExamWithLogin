using System.Collections.Generic;
using System.Windows.Forms;

namespace TestForm.Initialization
{
    static class InitializeTestForm
    {
        public static void SetQuestions(List<string> questions, List<GroupBox> groupBoxes)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                groupBoxes[i].Text = $"Задача {i + 1} - {questions[i]}?";
            }
        }
    }
}
