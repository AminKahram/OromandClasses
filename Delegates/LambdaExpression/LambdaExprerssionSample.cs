using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.LambdaExpression
{
    public class LambdaExprerssionSample
    {
        public void WithoutLambdaTest()
        {
            Func<int, string> func = delegate (int x)
            {
                return x.ToString();
            };
            string result = func(1);
            Console.WriteLine(result);
        }
        public void LambdaTest()
        {
            Func<int, string> func = x 
                => x.ToString();



            string result = func(1);
            Console.WriteLine(result);
        }
    }
}
