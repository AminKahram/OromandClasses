using Delegates.DelegateSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.AnnonymousMethod
{
    
    public class AnonymousMethodSample
    {
        Person person = new Person
        {
            FirstName = "Abbas",
            LastName = "Abbasi"
        };
        public void AnnonymousMethod()
        {
            PersonToString mydel = delegate (Person person)
            {
                return $"{person.FirstName}-{person.LastName}";
            };
            var result = mydel(person);
            Console.WriteLine(result);
        }
    }
}
 