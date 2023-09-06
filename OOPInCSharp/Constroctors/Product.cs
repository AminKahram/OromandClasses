using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp.Constroctors
{
    public class Product
    {
        //public Product()
        //{
        //    Console.WriteLine("New instance of product created");
        //}
        public Product(string name)
        {
            Console.WriteLine($"New instance of product {name} created");
        }
    }
    public class Mobile:Product
    { 
        public Mobile():base("Test")
        {
            Console.WriteLine("New instance of mobile created");
        }
        public Mobile(string name):base(name)
        {
            Console.WriteLine($"New instance of mobile {name} created");
        }
    }
}
