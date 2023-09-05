using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp.Inheritance
{
    public class FirstChild:Parent
    {
        public string GetChildClassName()
            => nameof(FirstChild);
    }
}
