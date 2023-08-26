using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverModel
{
    /// <summary>
    /// 观察者接口
    /// </summary>
    public interface IObserver
    {
        void Update();
    }
}
