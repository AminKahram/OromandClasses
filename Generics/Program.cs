// See https://aka.ms/new-console-template for more information
using Generics.GenericClass;

//Console.WriteLine("Hello, World!");

GenericConcat<int> genericConcat = new();

var result = genericConcat.Concat(1, 2);

Console.WriteLine($"{result}");

GenericConcat<string> genericConcat1 = new();

var result1 = genericConcat1.Concat("abbas", "Gholam");

Console.WriteLine($"{result1}");

GenericConcat<Person> genericConcat2 = new();

var result2 = genericConcat2.Concat(new Person {FirstName = "Abbas", LastName = "Abbasi"}, new Person {FirstName = "Gholam", LastName = "Gholami"});
Console.WriteLine(result2);

Console.ReadLine();
