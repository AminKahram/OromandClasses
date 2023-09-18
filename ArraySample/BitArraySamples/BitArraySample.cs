using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample.BitArraySamples
{
    public class BitArraySample
    {
        public void TestBitArray()
        {
            BitArray bit01 = new(10);
            bit01.SetAll(true);
            bit01.Set(0,false);
            bit01.Set(9, false);
            bit01.Set(2, false);
            bit01.Set(5, false);
            foreach (var item in bit01)
            {
                Console.WriteLine(item);
            }
        }
    }
}
