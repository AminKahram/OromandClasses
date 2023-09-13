using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.GenericClass
{
    public class GenericConcat<TiInput>
    {
        public string Concat(TiInput right, TiInput left)
        {
            if (right == null)
                right = default(TiInput);
            if (left == null)
                left = default(TiInput);
            string stringRight = right.ToString(); 
            string stringLeft = left.ToString();
            return stringRight + stringLeft;
        }
    }
}
