using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverModel
{
    /// <summary>
    /// 具体观察者
    /// </summary>
    public class ConcreteObserver:IObserver
    {
        private string name;
        private ConcreteSubject subject;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void Update()
        {
            Console.WriteLine($"观察者 {name} 收到更新. 新状态: {subject.State}");
        }
    }
}
