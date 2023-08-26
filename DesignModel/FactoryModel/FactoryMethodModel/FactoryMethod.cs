using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodModel
{
    /// <summary>
    /// 工厂方法
    /// </summary>
    internal abstract class FactoryMethod
    {

        public abstract IProduct Create();


    }
}