using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample.Enumerators
{
    public class EnumeratorSample
    {
        public void TestEnumeration()
        {
            int[] a = { 1, 2, 3, 4 };
            //foreach (int i in a)
            //{

            //}
            var e = a.GetEnumerator();
            while (e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }

        }
    }
}
