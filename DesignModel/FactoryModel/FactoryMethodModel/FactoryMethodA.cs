using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodModel
{
    /// <summary>
    /// 工厂A
    /// </summary>
    internal class FactoryMethodA : FactoryMethod
    {
        public override IProduct Create()
        {
            return new ProductA();
        }
    }
}
