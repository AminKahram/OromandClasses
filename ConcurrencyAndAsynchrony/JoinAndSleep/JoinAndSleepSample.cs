using ConcurrencyAndAsynchrony.CreateAndStartThread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.JoinAndSleep
{
    internal class JoinAndSleepSample
    {
        //public static void Start()
        //{
        //    JoinAndSleepSample joinAndSleepSample = new();
        //    //joinAndSleepSample.JoinTest();
        //    joinAndSleepSample.SleepTest();
        //}
        public void JoinTest()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinter = new Thread(charPrinter.PrintDash);
            dashPrinter.Start();
            var result = dashPrinter.Join(1);
            Console.WriteLine(result);
            charPrinter.PrintStar();
            Console.ReadLine();
        }

        public void SleepTest()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinter = new Thread(charPrinter.PrintDash);
            dashPrinter.Start();
            charPrinter.PrintStar();
            //Thread.Sleep(500);
            Console.ReadLine();
        }
    }
}
