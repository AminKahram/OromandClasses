using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Inheritance
{
    public class Parent<TInput01,TInput02>
    {
    }
    public class Child01:Parent<int,string>
    {

    }
    public class Child02<TInput02> : Parent<int, TInput02>
    {

    }
    public class Child02<TInput01, TInput02> : Parent<TInput01, TInput02>
    {

    }
}
