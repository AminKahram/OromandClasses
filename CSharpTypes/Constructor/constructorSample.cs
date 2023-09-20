using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTypes.Constructor
{
    public class constructorSample
    {
        private readonly int age;
        private readonly string name;
        public static int Counter;
        public constructorSample():this(5)
        {
            this.name = "abbas";
        }
        public constructorSample(int age)
        {
            this.age = age;
        }
        static constructorSample()
        {
            Counter = 20;        
        }
    }
}
