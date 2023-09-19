using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.ClosureSample
{
    public class ClosureTestSample
    {
        public void TestClosure()
        {
            int Localvariable = 1;

            Func<int, int> AddWithLocal = x 
                => x + Localvariable;

            Localvariable = 200;

            Console.WriteLine (AddWithLocal(1));
        }
    }
}
