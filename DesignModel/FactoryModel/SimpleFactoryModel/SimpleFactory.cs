using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryModel
{
    public enum ESimpleFactoryType
    {
        SimpleFactoryA = 1,
        SimpleFactoryB = 2
    }
    /// <summary>
    /// 简单工厂类
    /// </summary>
    internal class SimpleFactory
    {

        public static ISimpleFactory Printer(ESimpleFactoryType eSimpleFactoryType)
        {
            switch (eSimpleFactoryType)
            {
                case ESimpleFactoryType.SimpleFactoryA:
                    return new ProductA();
                case ESimpleFactoryType.SimpleFactoryB:
                    return new ProductB();
                default:
                    return null;
            }
        }
    }
}