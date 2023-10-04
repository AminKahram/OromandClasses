using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.CreateAndStartThread
{
    internal class CharPrinter
    {
        public static void Start()
        {
            CharPrinter charPrinter = new CharPrinter();

            Thread dashPrinterWorker = new Thread(charPrinter.PrintDash);
            dashPrinterWorker.Name = "Abbas";

            Console.WriteLine($"{dashPrinterWorker.Name} is alive before start {dashPrinterWorker.IsAlive}");

            dashPrinterWorker.Start();
            Console.WriteLine($"{dashPrinterWorker.Name} is alive after start {dashPrinterWorker.IsAlive}");

            charPrinter.PrintStar();

            Console.WriteLine($"{dashPrinterWorker.Name} is alive after print star start {dashPrinterWorker.IsAlive}");

            Console.ReadLine();

            Console.WriteLine($"{dashPrinterWorker.Name} is alive after print star start {dashPrinterWorker.IsAlive}");

            Console.ReadLine();
        }
        public void PrintStar()
        {
            for(int i = 0; i < 1000; i++)
            {
                Console.Write("*");
            }
            Thread.Yield();

        }

        public void PrintDash()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("-");
            }
            Thread.Sleep(0);

        }
    }
}
