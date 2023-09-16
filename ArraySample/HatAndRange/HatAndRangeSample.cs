using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample.HatAndRange
{
    public class HatAndRangeSample
    {
        public void TestHat()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.WriteLine(a[0]);
            Console.WriteLine(a[^1]);

            Console.WriteLine(a[2]);
            Console.WriteLine(a[^2]);
        }
        public void TestRange()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var c = a[0..4];
            
            foreach ( var i in c)
            {
                Console.WriteLine(i);
            }
            
        }
        public void TestRangeAndHat()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            var c = a[^4..^1];

            foreach (var i in c)
            {
                Console.WriteLine(i);
            }

        }
    }
}
