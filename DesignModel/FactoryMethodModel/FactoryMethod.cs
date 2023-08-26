using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodModel
{
    public enum EFactoryMethod
    {
        SimpleFactoryA = 1,
        SimpleFactoryB = 2
    }
    /// <summary>
    /// 工厂方法
    /// </summary>
    internal abstract class FactoryMethod
    {

        public abstract FactoryMethod Create();
        public abstract void Print();


    }
}