using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.PassingDatatoAThread
{
    internal class PassDataSample
    {
        public void Start()
        {
            //Thread worker = new Thread(PrintObject);
            //string yo = "YO world";
            //worker.Start(yo);

            //Thread worker = new Thread(() => PrintFullName("Abbas","Abbasi"));
            //worker.Start();

            //CapturevariableProblem();
            PrintNumber();
            Console.Read();
        }
        public void PrintNumber()
        {
            for (int i = 0; i < 10; i++)
            {
                int temp = i;
                new Thread(() => Console.WriteLine(temp)).Start();
            }
        }
        public void CapturevariableProblem()
        {
            string FullName = "Holam Gholami";
            Thread first = new Thread(() => Console.WriteLine(FullName));
            FullName = "Abbas";
            Thread second = new Thread(() => Console.WriteLine(FullName));
            first.Start();
            second.Start();
            Console.Read();
        }
        public void PrintFullName(string firstName, string lastName)
           => Console.WriteLine($"{firstName}, {lastName}");
        public void PrintObject(object obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
