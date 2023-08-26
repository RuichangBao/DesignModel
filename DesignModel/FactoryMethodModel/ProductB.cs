using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodModel
{
    /// <summary>
    /// 产品B
    /// </summary>
    internal class ProductB : IProduct
    {
        public void Print()
        {
            Console.WriteLine("产品B");
        }
    }
}
