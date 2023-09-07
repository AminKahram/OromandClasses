using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.IsAs
{
    public class IsAsSample
    {
        public void CheckIs(object input)
        {
            Console.WriteLine(input is Person);
        }
        public void CheckAs(object input)
        {
            Console.WriteLine(input as Person != null ? "Is Person":"Is Not Person");
        }

    }
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class Student : Person
    {
        public string Text { get; set; }
    }

    public class Teacher
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


}
