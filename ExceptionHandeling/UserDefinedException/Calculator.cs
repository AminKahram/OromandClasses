using ExceptionHandeling.UserDefinedException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandeling.UserDefinedException
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
            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex) when (DateTime.Now.Hour == 1)
            {
                Console.WriteLine(ex.ToString());

            }
            catch (Exception ex) when (ex.InnerException != null) 
            {
                Console.WriteLine(ex.ToString());
                CustomeExceptionSample exceptionSample = new CustomeExceptionSample("My exception", ex);
                throw exceptionSample;
            }
            finally
            {
                Console.WriteLine("finally called");
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
