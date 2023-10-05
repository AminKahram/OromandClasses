using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrencyAndAsynchrony.ExceptionHandeling
{
    internal class ExceptionInThreads
    {
        public static void Start() 
        {
            ExceptionInThreads exceptionInThreads = new();

   //         try
			//{
                //Thread worker = new Thread(exceptionInThreads.BadMethod);

                Thread worker = new Thread(exceptionInThreads.ThreadStartPoint);
                worker.Start();
                Console.Read();
			//}
			//catch (Exception ex)
			//{
   //             Console.WriteLine("Exception");

			//}
        }
        public void ThreadStartPoint()
        {
            try
            {
                BadMethod();
            }
            catch (Exception)
            {

                Console.WriteLine("Exception"); 
            }
        }
        public void BadMethod()
        {
            throw new Exception("Bad Exception ");
        }
    }
}
