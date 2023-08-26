using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodModel
{
    /// <summary>
    /// 工厂B
    /// </summary>
    internal class FactoryMethodB : FactoryMethod
    {
        
        public override IProduct Create()
        {
            return new ProductB();
        }
    }
}
