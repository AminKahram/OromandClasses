using ConcurrencyAndAsynchrony.CreateAndStartThread;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.Blocking
{
    internal class BlockingSample
    {
        public void ThreadStateCheck()
        {
            CharPrinter charPrinter = new CharPrinter();
            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            dashPrinterWorker.Start();
            Console.WriteLine(dashPrinterWorker.ThreadState);
            var isBlock = (dashPrinterWorker.ThreadState & ThreadState.WaitSleepJoin) != 0;
            Console.WriteLine(isBlock);
        }
    }
}
