using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodModel
{
    internal class FactoryMethodA : FactoryMethod
    {
        public override FactoryMethod Create()
        {
            return new FactoryMethodA();
        }

        public override void Print()
        {
            Console.WriteLine("FactoryMethodA Print");
        }
    }
}
