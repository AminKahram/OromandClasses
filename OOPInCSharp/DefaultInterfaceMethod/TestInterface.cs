using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp.DefaultInterfaceMethod
{
    public interface TestInterface
    {
        void Log(string message);
        void info(string message) 
            => throw new NotImplementedException();
    }
    public class ImplementTestInterface : TestInterface  
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
        public void info(string message) { Console.WriteLine(); }
    }
}
