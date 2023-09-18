using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.DelegateSample
{
    public delegate string PersonToString(Person person);
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class PesronFullName
    {
        
        public static string GetPersonFullName(Person person)
        {
            Console.WriteLine("PesronFullName executed");
           return $"{person.FirstName} {person.LastName}";
        }
            
    }
    public class PesronFullNameReverse
    {
        public static string GetPersonFullName(Person person)
        {
            Console.WriteLine("PesronFullNameReverse executed");
            return $"{person.LastName} {person.FirstName}";
        }
        
    }
}
