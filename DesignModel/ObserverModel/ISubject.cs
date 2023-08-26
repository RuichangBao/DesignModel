using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverModel
{
    /// <summary>
    /// 主题接口
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// 添加观察者
        /// </summary>
        void AddObserver(IObserver observer);
        /// <summary>
        /// 删除观察者
        /// </summary>
        void RemoveObserver(IObserver observer);
        /// <summary>
        /// 通知观察者改变
        /// </summary>
        void NotifyObservers();
    }
}
