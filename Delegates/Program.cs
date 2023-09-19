// See https://aka.ms/new-console-template for more information
using Delegates.AnnonymousMethod;
using Delegates.ClosureSample;
using Delegates.DelegateSample;
using Delegates.Func_Action;
using Delegates.LambdaExpression;
using Delegates.Multicast_Delegate;

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

//Func<int, int, int, string> func = FuncSample.MyIntTostring;
//Console.WriteLine(func(1, 2, 3));

//Person person = new Person
//{
//    FirstName = "Abbas",
//    LastName = "Abbasi"
//};
//PersonPrintFunc printFunc = new();
//printFunc.Print(PesronFullNameReverse.GetPersonFullName, person);

//TestMulticastDelegates testMulticastDelegates = new TestMulticastDelegates();
////testMulticastDelegates.TestMulti();

//testMulticastDelegates.TestMultiWithOutput();

//testMulticastDelegates.TestMultiExceptionHandel();

//AnonymousMethodSample sample = new();
//sample.AnnonymousMethod();

//LambdaExprerssionSample sample = new LambdaExprerssionSample();
//sample.WithoutLambdaTest();
//sample.LambdaTest();

ClosureTestSample sample = new();
sample.TestClosure();