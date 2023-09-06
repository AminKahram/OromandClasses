using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp.Sealed
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Abbas";
        public string LastName { get; set; } = "Abbasi";
            
    }
    public sealed class Child : Person 
    {

    }

}
