using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypes.Structs
{
    public readonly record struct TestStructRecord(int Id, string FirstName, string LastName);
    public readonly struct Person7_2
    {
        public Person7_2()
        {
            Id = 1;
            FirstName = "Ali";
            LastName = "Mohamadi";
            Age = 20;
        }
        public int Id { get;  }
        public string FirstName { get; }
        public string LastName { get; }
        public int Age { get; }
    }
    public struct Person8 
    {
        public Person8()
        {
            FirstName = "Ali";
            LastName = "Mohamadi";
            Age = 20;
        }
        public int Id = 20; 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public readonly string GetFullName()
        {
            return FirstName;
        }
    }
}
