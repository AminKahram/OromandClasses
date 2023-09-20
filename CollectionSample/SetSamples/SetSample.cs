using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample.SetSamples
{
    public class SetSample
    {
        HashSet<string> set = new HashSet<string>();
        public static void Start()
        {
            SetSample sample = new();

            sample.Add("1");
            sample.Add("2");
            sample.Add("3");

            sample.Print();

            sample.Add("2");
            sample.Add("3");

            sample.Print();
        }
        public void Add(string value)
        { 
            set.Add(value); 
        }

        public void Print()
        {
            foreach(string value in set)
            {
                Console.WriteLine(value);
            }
        }

        public void Operators()
        {
            HashSet<string> newSet = new HashSet<string>();
            newSet.Add("1");

            newSet.Except(set);

            newSet.Union(set);

            newSet.Intersect(set);

            newSet.IsSubsetOf(set);
        }
    }
}
