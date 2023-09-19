using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample.QueueSample
{
    public class QueueTestSample
    {
        Queue<string> strings = new Queue<string>();
        public void EnqueueTest(string s)
        {
            strings.Enqueue(s);
        }
        public string DequeueTest()
        {
            return strings.Dequeue();
        }
        public string PeakTest()
        {
            return strings.Peek();
        }
        public void Count()
        {
            Console.WriteLine($"Count is : {strings.Count}");
        }
    }
}
