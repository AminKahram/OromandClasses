using Operators.IsAs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.TypeOf
{
    public class SampleTypeOf
    {
        
        public void TypeOf()
        {
            var type = typeof(Person);
            Console.WriteLine(type.AssemblyQualifiedName);
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Namespace);
            foreach (var item in type.GetProperties())
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
