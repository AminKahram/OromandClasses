using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySample.ArrayClass
{
    public class ArrayClassSample
    {
        Array myArray;

        public ArrayClassSample()
        {
            myArray = Array.CreateInstance(typeof(int), 10);
        }
        public void ArrayClass()
        {
            
            for (int i = 0; i < 10; i++)
            {
                myArray.SetValue(i, i);
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray.GetValue(i));
            }
        }
        public void CopyArray()
        { 
            var secondArray = myArray.Clone();


            Array thirdArray = Array.CreateInstance(typeof(int), 12);
            myArray.CopyTo(thirdArray,2);

            for (int i = 0; i < thirdArray.Length; i++)
            {
                Console.WriteLine($"CopyTo {i}: {thirdArray.GetValue(i)}");
            }

            int[] fourthArray = new int[3];
            Array.Copy(myArray, fourthArray, 3);

            for (int i = 0; i < fourthArray.Length; i++)
            {
                Console.WriteLine($"Copy {i}: {fourthArray.GetValue(i)}");
            }
        }

        public void SortArray()
        {
            int[] a = { 25, 87, 93, 156, 14, 10, 5, 44, 999, 3, 0, 7, 6 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Array.Sort(a);
            foreach (int i in a)
            {
                Console.WriteLine($"Sorted {i}");
            }
        }
    }
}
