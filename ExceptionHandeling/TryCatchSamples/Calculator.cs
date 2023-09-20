using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling.TryCatchSamples
{
    public class Calculator
    {
        public static void Start()
        {
            try
            {
                Calculator calculator = new Calculator();

                calculator.Add(0, 3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //throw;
            }

        }
        public void Add(int number1, int number2) 
        {
            if (number1 < 1)
                throw new ArgumentException();
            if (number2 < 1)
                throw new InvalidOperationException();

            int result = number1 + number2;
            Console.WriteLine(result);

        }
    }
}
