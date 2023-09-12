using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.OperatorOverloading
{
    public class money : IEquatable<money>
    {
        private readonly int value;
        public money(int value)
        {
            this.value = value;
        }

        public int Value { get { return value; } }
        
        public money Add(money input) 
            => new money(value + input.Value);

        public bool Equals(money? other)
        {
           return this == other;
        }
        public override bool Equals(object? obj)
        {
            return this.Equals(obj as money);
        }
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
        public static money operator + (money right, money left)
            => new money(right.Value + left.Value);

        public static money operator - (money right, money left)
            => new money(right.value - left.value);

        public static bool operator ==(money left, money right)
            => left.Value == right.Value;
        public static bool operator !=(money left, money right)
            => !(left == right); 

        public static implicit operator int (money left) => left.Value;

        public static implicit operator money (int left) => new money (left);

        public static explicit operator byte (money value) => (byte) value.Value;
    }
}
