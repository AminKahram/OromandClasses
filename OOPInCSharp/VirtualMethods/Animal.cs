using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp.VirtualMethods
{
    public class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("My animal voice");
        }
    }
    public class Cat : Animal
    {
        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Meow");
        }
    }

    public class Dog : Animal
    {
        public override void Voice()
        {
            Console.WriteLine("Hop");
            base.Voice();

        }
    }

    public class Cow : Animal
    {
        public override void Voice()
        {
  
        }
    }
}
