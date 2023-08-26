using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyModel
{
    /// <summary>
    /// 策略接口
    /// </summary>
    internal interface IStrategy
    {
        void Execute();
    }
}