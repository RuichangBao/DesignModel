using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodModel
{
    internal class FactoryMethodB : FactoryMethod
    {
        
        public override FactoryMethod Create()
        {
            return new FactoryMethodB();
        }
        public override void Print()
        {
            Console.WriteLine("FactoryMethodB Print");
        }
    }
}
