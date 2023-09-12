using Operators.OperatorOverloading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators.Indexer
{
    public class Wallet
    {
        private readonly List<money> moneys = new();
        public money this[int index]
        { 
            get
            {
                return moneys[index];
            }
            set
            {
                if(moneys.Count > index)
                    moneys[index] = value;
                else
                    moneys.Add(value);
            }
        }
    }
}
