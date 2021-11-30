using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignMode
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Single
    {
        private Single()
        {

        }
        private static Single instance;

        public static Single Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Single();
                }
                return instance;
            }
        }
    }
}
