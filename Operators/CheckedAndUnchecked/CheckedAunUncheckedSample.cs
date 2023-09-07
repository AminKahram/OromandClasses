using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.CheckedAndUnchecked
{
    public class CheckedAunUncheckedSample
    {
        public void Checked()
        {
            //checked
            //{
            //    byte b = byte.MaxValue;
            //    Console.WriteLine(b);
            //    b += 2;
            //    Console.WriteLine(b);
            //}
            unchecked
            {
                byte b = byte.MaxValue;
                Console.WriteLine(b);
                b += 2;
                Console.WriteLine(b);
            }

        }
        public void Checked2()
        {
            byte b = byte.MaxValue;
            Console.WriteLine(b);
            //b = checked(b++);
            b = unchecked(b++);
            Console.WriteLine(b);
        }
    }
}
