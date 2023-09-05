using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypes.RefInOut
{
    public class Sample
    {
        public void caller01()
        {
            int myValue = 1;
            caller01(ref myValue);
            Console.WriteLine(myValue);
        }
        public void caller01(ref int input)
        {
            input++;
        }

        public void caller02()
        {
            int myValue ;
            caller02(out myValue);
            Console.WriteLine(myValue);
        }
        public void caller02(out int input)
        {
            input = 3;
        }

        public void caller03()
        {
            int myValue = 1;
            caller03(in myValue);
            Console.WriteLine(myValue);
        }
        public void caller03(in int input)
        {
        }
    }
}
