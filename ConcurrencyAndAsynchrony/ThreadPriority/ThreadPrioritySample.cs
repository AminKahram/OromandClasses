using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.ThreadPriority
{
    internal class ThreadPrioritySample
    {
        public static void Start()
        {
            ThreadPrioritySample threadPrioritySample = new();
            Thread t1 = new Thread(() => threadPrioritySample.ThreadPrinter("*"));
            t1.Priority = System.Threading.ThreadPriority.Highest;
            Thread t2 = new Thread(() => threadPrioritySample.ThreadPrinter("-"));

            Thread t3 = new Thread(() => threadPrioritySample.ThreadPrinter("/"));
            t3.Priority = System.Threading.ThreadPriority.Lowest;
            t1.Start();
            t2.Start();
            t3.Start();
        }
        public void ThreadPrinter(string input)
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write(input);
            }
        }
    }
}
