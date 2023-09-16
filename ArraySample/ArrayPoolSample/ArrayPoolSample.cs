using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample.ArrayPoolSample
{
    public class ArrayPoolSample
    {
        public void ArrayPoolTest()
        {
            ArrayPool<int> arrayPool = ArrayPool<int>.Create();
            var array = arrayPool.Rent(17);

            for (int i = 0; i < 17; i++)
            {
                array[i] = i * 2;
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            arrayPool.Return(array, true);
        }
    }
}
