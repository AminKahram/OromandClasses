using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.Locking
{
    internal class LockingSample
    {
        bool allowRight = true;
        private readonly static object _locker = new object();

        public static void Start()
        {
            LockingSample lockingSample = new LockingSample();
            Thread first = new Thread(lockingSample.SafeCheckSharedState);
            Thread  second = new Thread(lockingSample.SafeCheckSharedState);

            first.Name = "first";
            second.Name = "second";
            second.Start();

            first.Start();
            Console.Read();
        }
        public void SafeCheckSharedState()
        {
            lock (_locker)
            {
                if (allowRight)
                {
                    Console.WriteLine($"Locker Thread name is {Thread.CurrentThread.Name}");
                    Console.WriteLine("This is gholam");
                    allowRight = false;
                }
            }
            Console.WriteLine(Thread.CurrentThread.Name);
        }
    }
}
