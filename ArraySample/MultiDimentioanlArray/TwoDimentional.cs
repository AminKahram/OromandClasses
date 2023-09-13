using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample.MultiDimentioanlArray
{
    public class TwoDimentional
    {
        public void TwoD() 
        {
            int[] a = new int[10];
            int[,,] c = new int[10,10,10];
            int[,] vs = new int[2, 2];
            vs[0, 0] = 1;
            vs[1, 0] = 2;
            vs[1, 1] = 4;
            foreach (var x in vs)
            {
                Console.WriteLine(x);
            }
            Console.WriteLine($"A Dimention is {a.Rank}");
            Console.WriteLine($"Vs Dimention is {vs.Rank}");
            Console.WriteLine($"C Dimention is {c.Rank}");

        }
         
    }
}
