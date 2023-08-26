using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodModel
{
    /// <summary>
    /// 产品A
    /// </summary>
    internal class ProductA : IProduct
    {
        public void Print()
        {
            Console.WriteLine("产品A");
        }
    }
}
