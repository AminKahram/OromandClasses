using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.SharedAndLocalState
{
    internal class SharedAndLocalStateSample
    {
        int j = 0;
        bool allowRight = true;
        public void start()
        {
            Thread first = new Thread(CheckSharedState);
            Thread second = new Thread(CheckSharedState);

            first.Start();
            second.Start();
            Console.Read();
        }
        public void PrintStar()
        {
            int Counter = 10;
            for (int i = 0; i < Counter; i++) 
            {
                Console.Write("*");
            }
        }

        public void CheckSharedState()
        {
            if(allowRight)
            {
                Console.WriteLine("This is abbas");
                allowRight = false;
                 
            }
        }
    }
}
