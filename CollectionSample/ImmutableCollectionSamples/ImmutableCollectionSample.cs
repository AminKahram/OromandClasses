using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;
using System.Collections;

namespace CollectionSample.ImmutableCollectionSamples
{
    public class ImmutableCollectionSample
    {
        
        
        ImmutableList<string> values = ImmutableList.Create<string>();
        public static void start()
        {
            List<string> mylist = new List<string>();
            mylist.ToImmutableList();

            ImmutableCollectionSample sample = new();
            Console.WriteLine(sample.values.Count);

            sample.values.Add("A");
            Console.WriteLine(sample.values.Count);

            var result = sample.values.Add("A").Add("B").Add("C");
            Console.WriteLine($"{result.Count}");

        } 
    }
}
