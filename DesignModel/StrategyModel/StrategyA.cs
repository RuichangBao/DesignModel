using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    /// <summary>
    /// 具体策略A
    /// </summary>
    internal class StrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("具体策略A");
        }
    }
}
