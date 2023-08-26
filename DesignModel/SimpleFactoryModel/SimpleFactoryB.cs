using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryModel
{
    internal class SimpleFactoryB : ISimpleFactory
    {
        public void Print()
        {
            Console.WriteLine("SimpleFactoryB Print");
        }
    }
}
