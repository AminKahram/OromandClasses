using Delegates.DelegateSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Func_Action
{
    internal class PersonPrintFunc
    {
        public void Print(Func<Person,string> personToString,Person person)
        {
            string s = personToString(person);
            Console.WriteLine(s);
        }
    }
}
