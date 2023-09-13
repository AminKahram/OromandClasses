using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample.SimpleArray
{
    public class SampleSimpleArray
    {
        int a = 1;
        int[] b = new int[10];
        int[] c = new int[] { 1, 2, 3 };
        int[] d = { 1, 2, 3 };

        public void Print()
        {
            Console.WriteLine(b[0]);

            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
        }
    }
}
