using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.ForegroundAndBackgroundThread
{
    internal class ForegroundBackgroundThreadSample
    {
        public static void Start()
        {
            ForegroundBackgroundThreadSample threadSample = new ForegroundBackgroundThreadSample();
            Thread thread = new Thread(threadSample.PrintAndRead);
            thread.IsBackground = true;
            thread.Start();
            Console.WriteLine("Main thread finished");
            thread.Join(TimeSpan.FromSeconds(10));
        }
        public void PrintAndRead()
        {
            Console.Write("Please Enter Word : ");
            Console.ReadLine();
        }
    }
}
