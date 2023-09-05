// See https://aka.ms/new-console-template for more information
using OOPInCSharp.Inheritance;

Console.WriteLine("Hello, World!");

Parent parent = new();
parent.GetHashCode();
Console.WriteLine(parent.GetClassName());

FirstChild firstChild = new();

Console.WriteLine(firstChild.GetClassName());
Console.WriteLine(firstChild.GetChildClassName());