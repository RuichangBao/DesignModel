using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    /// <summary>
    /// 具体策略B
    /// </summary>
    internal class StrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("具体策略B");
        }
    }
}
