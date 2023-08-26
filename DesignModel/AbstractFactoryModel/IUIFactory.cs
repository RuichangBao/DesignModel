using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModel
{
    internal interface IUIFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
