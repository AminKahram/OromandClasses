using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.BinaryOperators
{
    public class BinaryOperatorSample
    {
        public void And()
        {
            int a = 0b011;
            int b = 0b010;

            var c = a & b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }

        public void or()
        {
            int a = 0b011;
            int b = 0b010;
             
            var c = a | b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        public void Xor()
        {
            int a = 0b011;
            int b = 0b010;

            var c = a ^ b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        public void Reverse()
        {
            int a = 0b011;
            int b = 0b010;

            var c = ~ b;
            var d = ~ a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
