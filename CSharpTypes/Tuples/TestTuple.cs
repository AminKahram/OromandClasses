using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypes.Tuples
{
    public class TestTuple
    {
        void Test()
        {
            (int x, int y) direction = (1, 2);
            Console.WriteLine(direction.x);
        }

        public (int x, int y) Direction()
        {
            return (1, 2); 
        }
         
        public void  CallDirection()
        {
            (int  x, int y) = Direction();
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
