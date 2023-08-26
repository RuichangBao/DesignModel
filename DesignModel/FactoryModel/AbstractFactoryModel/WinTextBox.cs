using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModel
{
    internal class WinTextBox : ITextBox
    {
        public void Input(string text)
        {
            Console.WriteLine("WinTextBox Input" + text);
        }
    }
}
