using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModel
{
    internal class WinButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("WinButton Click");
        }
    }
}
