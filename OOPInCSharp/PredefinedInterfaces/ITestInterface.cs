using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInCSharp.PredefinedInterfaces
{
    public interface ITestInterface
    {
        public void Temp();
        void Test();
    }
    public class TestIntefaceImplemnet : ITestInterface
    {
        public void Temp()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
