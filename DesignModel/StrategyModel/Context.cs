using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    /// <summary>
    /// 上下文
    /// </summary>
    internal class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            strategy.Execute();
        }

    }
}
