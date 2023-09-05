using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp.HiddenMethod
{
    public class Parent
    {
        public string HiddenMethod() 
            => nameof(HiddenMethod);
    }
    public class FirstChild:Parent
    {
        public new string HiddenMethod()
            => nameof(HiddenMethod);
    }
}
