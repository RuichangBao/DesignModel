﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryModel
{
    internal class MacButton : IButton
    {
        public void Click()
        {
            Console.WriteLine("MacButton Click");
        }
    }
}
