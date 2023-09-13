using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample.JaggedArray
{
    public class JaggedArraysample
    {
        public void JaggedArray()
        {
            int[][] jagged = new int[2][];
            jagged[0] = new int[] {1,2,3 };
            jagged[1] = new int[] {1,2,3 ,4,5,66,98};

            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.WriteLine($"jagged of{i} and {j} is: {jagged[i][j]}");
                }
            }
        }
    }
}
