using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates.DelegateSample;
namespace Delegates.Multicast_Delegate
{
    public class TestMulticastDelegates
    {
        public void TestMulti()
        {
            MethodNamePrinter methodNamePrinter = new MethodNamePrinter();
            MethodNamePrinterHolder printerHolder = methodNamePrinter.Method01;
            printerHolder += methodNamePrinter.Method02;
            printerHolder -= methodNamePrinter.Method02;
            printerHolder += methodNamePrinter.Method03;
            printerHolder += methodNamePrinter.Method04;
            printerHolder += methodNamePrinter.Method05;
            printerHolder();
        }

        public void TestMultiExceptionHandel()
        {
            MethodNamePrinter methodNamePrinter = new MethodNamePrinter();
            MethodNamePrinterHolder printerHolder = methodNamePrinter.Method01;
            printerHolder += methodNamePrinter.Method02;
            printerHolder -= methodNamePrinter.Method02;
            printerHolder += methodNamePrinter.Method03;
            printerHolder += methodNamePrinter.Method04;
            printerHolder += methodNamePrinter.Method05;
            var list = printerHolder.GetInvocationList();
            foreach (var item in list)
            {
                try
                {
                    item.DynamicInvoke();
                }
                catch (Exception)
                {
                    continue;

                }
            }
        }
        public void TestMultiWithOutput()
        {
            Person person = new Person
            {
                FirstName = "Abbas",
                LastName = "Abbasi"
            };
            PersonToString Pts = PesronFullName.GetPersonFullName;
            Pts += PesronFullNameReverse.GetPersonFullName;
            PersonPrinter printer = new PersonPrinter();
            printer.Print(Pts, person);

        }
    }
}
