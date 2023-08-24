using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//单例模式
namespace SingletonMode
{
    public class Singleton
    {
        private static Singleton instance;

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
        private Singleton()
        {
            Console.WriteLine("单例模式构造函数");
        }
    }
}