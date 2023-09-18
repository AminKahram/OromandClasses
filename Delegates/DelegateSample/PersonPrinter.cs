using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegateSample
{
    public class PersonPrinter
    {
        //public void Print(Person person) 
        //{
        //    string s = PesronFullName.GetPersonFullName(person);
        //    Console.WriteLine(s);
        //}
        public void Print(PersonToString personToString,Person person)
        {
            string s = personToString(person);
            Console.WriteLine(s);
        }
    }
}
