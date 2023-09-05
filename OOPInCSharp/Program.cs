// See https://aka.ms/new-console-template for more information
using OOPInCSharp.Inheritance;
using OOPInCSharp.VirtualMethods;

//Console.WriteLine("Hello, World!");

//Parent parent = new();
//parent.GetHashCode();
//Console.WriteLine(parent.GetClassName());

//FirstChild firstChild = new();

//Console.WriteLine(firstChild.GetClassName());
//Console.WriteLine(firstChild.GetChildClassName());

Animal animal = new();
Console.WriteLine($"Animal Voice Is :");
animal.Voice();


Dog dog = new();
Console.WriteLine($"Animal Voice Is :");
dog.Voice();


Cat cat = new();
Console.WriteLine($"Animal Voice Is :");
cat.Voice();


Cow cow = new();
Console.WriteLine($"Animal Voice Is :");
cow.Voice();