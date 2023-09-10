using Operators.IsAs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.NullOperator
{
    public class sampleNullOperator
    {
        public void NullOperator01()
        {
            int? a = null;
            int c = a ?? 0;
        }
        public void NullOperator02(Person person )
        {
            Console.WriteLine(person?.FirstName);
        }
    }
}
