using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryModel
{
    internal class ProductB : ISimpleFactory
    {
        public void Print()
        {
            Console.WriteLine("ProductB Print");
        }
    }
}
