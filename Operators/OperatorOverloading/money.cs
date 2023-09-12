using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.OperatorOverloading
{
    public class money
    {
        private readonly int value;
        public money(int value)
        {
            this.value = value;
        }

        public int Value { get { return value; } }
        
        public money Add(money input) 
            => new money(value + input.Value);
        public static money operator + (money right, money left)
            => new money(right.Value + left.Value);

        public static money operator - (money right, money left)
            => new money(right.value - left.value);

    }
}
