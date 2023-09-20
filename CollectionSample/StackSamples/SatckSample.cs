using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample.StackSamples
{
    public class SatckSample
    {
        Stack<string> stack = new Stack<string>();
        public static void Start()
        {
            var stack = new SatckSample();
            stack.Add("1");
            stack.Add("2");
            stack.Add("3");

            Console.WriteLine(stack.Get());
            Console.WriteLine(stack.Get());
            Console.WriteLine(stack.Get());

            Console.ReadLine();

        }
        public void Add (string s)
        {
            stack.Push (s);
        }
        public string Get()
        {
            return stack.Pop();
        }
    }
}
