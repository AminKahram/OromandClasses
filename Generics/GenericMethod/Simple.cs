using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericMethod
{
    public class Simple
    {
        public string Print<TInput>(TInput input)
        {
            return input.ToString();
        }
    }
}
