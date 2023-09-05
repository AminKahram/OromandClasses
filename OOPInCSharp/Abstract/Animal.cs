using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp.Abstract
{
    public abstract class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("My animal voice");
        }

        public abstract void Feed();
    }
    public class Cat : Animal
    {
        public override void Feed()
        {
            Console.WriteLine("Milk");
        }

        public override void Voice()
        {
            base.Voice();
            Console.WriteLine("Meow");
        }
    }

    public class Dog : Animal
    {
        public override void Feed()
        {
            Console.WriteLine("Meet");
        }

        public override void Voice()
        {
            Console.WriteLine("Hop");
            base.Voice();

        }
    }

    public class Cow : Animal
    {
        public override void Feed()
        {
            Console.WriteLine("Hay");
        }

        public override void Voice()
        {
  
        }
    }
}
