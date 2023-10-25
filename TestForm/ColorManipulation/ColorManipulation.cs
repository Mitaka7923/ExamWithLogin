using System.Drawing;
using System.Windows.Forms;

namespace TestForm.ColorManipulation
{
    static class ColorManipulation
    {
        internal static void ChangeColor(string isCorrect, Control component)
        {
            switch (isCorrect)
            {
                case "correct":
                    component.ForeColor = Color.Green;
                    foreach (Control c in component.Controls)
                    {
                        c.ForeColor = Color.Black;
                    }
                    break;
                case "incorrect":
                    component.ForeColor = Color.Red;
                    foreach (Control c in component.Controls)
                    {
                        c.ForeColor = Color.Black;
                    }
                    break;
                case "partialy-correct":
                    component.ForeColor = Color.DarkOrange;
                    foreach (Control c in component.Controls)
                    {
                        c.ForeColor = Color.Black;
                    }
                    break;
            }
        }
    }
}
