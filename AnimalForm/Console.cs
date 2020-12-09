using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalForm
{
    class Console
    {
        private static RichTextBox myConsole;

        public static void SetConsole(RichTextBox rtx)
        {
            myConsole = rtx;
        }

        public static void WriteLine(string text)
        {
            if (myConsole != null)
            {
                myConsole.AppendText(text + Environment.NewLine);
            }
            else
            {
                MessageBox.Show("Console is not initiated.");
            }
        }
    }
}
