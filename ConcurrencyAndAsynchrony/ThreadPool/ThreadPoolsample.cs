using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.ThreadPool
{
    internal class ThreadPoolsample
    {
        public static void Start()
        {
            ThreadPoolsample threadPoolsample = new ThreadPoolsample();
            //Thread t = new Thread(threadPoolsample.PrintThreadType);
            //t.Start();
            
            Task.Run(threadPoolsample.PrintThreadType);
            Console.Read();
        }
        public void PrintThreadType()
        {
            var isPool = Thread.CurrentThread.IsThreadPoolThread;
            var isBackground = Thread.CurrentThread.IsBackground;
            Console.WriteLine($"Is Thread from pool : {isPool}, Is Thread background : {isBackground}");
        }
    }
}
