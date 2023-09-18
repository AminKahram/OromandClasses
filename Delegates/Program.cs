// See https://aka.ms/new-console-template for more information
using Delegates.DelegateSample;
using Delegates.Func_Action;

//Console.WriteLine("Hello, World!");

//Person person = new Person 
//{
//    FirstName = "Abbas",
//    LastName = "Abbasi"
//};
//PersonPrinter personPrinter = new();
//personPrinter.Print(PesronFullName.GetPersonFullName,person);
//personPrinter.Print(PesronFullNameReverse.GetPersonFullName, person);

//PersonToString Pts = PesronFullName.GetPersonFullName;
//var result = Pts.Invoke(person);
//Console.WriteLine(result); 

Func<int, int, int, string> func = FuncSample.MyIntTostring;
Console.WriteLine(func(1, 2, 3));

Person person = new Person
{
    FirstName = "Abbas",
    LastName = "Abbasi"
};
PersonPrintFunc printFunc = new();
printFunc.Print(PesronFullNameReverse.GetPersonFullName, person);