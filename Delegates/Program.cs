// See https://aka.ms/new-console-template for more information
using Delegates.DelegateSample;

Console.WriteLine("Hello, World!");

Person person = new Person 
{
    FirstName = "Abbas",
    LastName = "Abbasi"
};
PersonPrinter personPrinter = new();
personPrinter.Print(PesronFullName.GetPersonFullName,person);
personPrinter.Print(PesronFullNameReverse.GetPersonFullName, person);

PersonToString Pts = PesronFullName.GetPersonFullName;
var result = Pts.Invoke(person);
Console.WriteLine(result);