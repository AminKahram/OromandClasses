using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample.SortedListSamples
{
    public class SortedListSample
    {
        SortedList<int,string> list = new SortedList<int,string>();
        public static void Start()
        {
            SortedListSample sortedListSample = new SortedListSample();
            sortedListSample.Add(1, "1");
            sortedListSample.Add(2, "2");
            sortedListSample.Add(3, "3");
            sortedListSample.Add(4, "4");

            foreach (var item in sortedListSample.list)
            {
                Console.WriteLine(item.Value);
            }
        }
        public void Add(int key, string value)
        {
            list.Add(key, value);
        }
    }
}
