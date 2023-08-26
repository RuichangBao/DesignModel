using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModel
{
    internal class MacTextBox : ITextBox
    {
        public void Input(string text)
        {
            Console.WriteLine("MacTextBox Input:" + text);
        }
    }
}
