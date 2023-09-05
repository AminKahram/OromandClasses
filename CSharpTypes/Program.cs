// See https://aka.ms/new-console-template for more information
using CSharpTypes.Extentions.Domain;
using CSharpTypes.Feild;
using CSharpTypes.Extentions.Domain.Extentions;
using CSharpTypes.Record;
using CSharpTypes.Structs;
using CSharpTypes.Enums;
using Microsoft.VisualBasic;
using CSharpTypes.RefInOut;

//Console.WriteLine("Hello, World!");
//var person = new Person(12)
//{
//    FirstName = "Abbas",
//    LastName = "Abbasi",
//    FatherName = "FatherName"
//};

//person.FirstName = "Gholi";

//int count = Person.GetCount();
//Console.WriteLine(count);

//string getFullName = person.GetFullNameEXp();
//Console.WriteLine(count);

//person.Print("test");

//person.PrintNumbers(width:2, height: 3);
//person.OptionalSample(1, 2, b:7);
//person.ParamsTest(1,2,3,4,6,7,9,55);

//var teacher = new Teacher
//{
//    FirstName = "Abbaas",
//    LastName = "Abbasi"
//};
//Console.WriteLine(teacher.GetFullName());

//var student = new
//{
//    FirstName = "Abbas",
//    LastName = "Gholizadeh",
//    Number = 5454
//};

//var teachersumery = new
//{
//    teacher.FirstName
//};

//PersonRecord personRecord1 = new PersonRecord
//{
//    Id = 1,
//    FirstName = "Abbas",
//    LastName = "Gholi"
//};
//PersonRecord personRecord2 = new PersonRecord
//{
//    Id = 1,
//    FirstName = "Abbas",
//    LastName = "Gholi"
//};
//personRecord1.Id = 7;

//PersonClass personClass1 = new PersonClass
//{
//    Id = 1,
//    FirstName = "Abbas",
//    LastName = "Gholi"
//};
//PersonClass personClass2 = new PersonClass
//{
//    Id = 1,
//    FirstName = "Abbas",
//    LastName = "Gholi"
//};

//Console.WriteLine($"PersonRecord tostring is {personRecord2}");
//Console.WriteLine($"PersonClass tostring is {personClass2}");

//Console.WriteLine($"PersonRecord refrence equal is {object.ReferenceEquals(personRecord2, personRecord1)}");
//Console.WriteLine($"PersonClass refrence equal is {object.ReferenceEquals(personClass1, personClass2)}");

//Console.WriteLine($"PersonRecord  equal is {personRecord2 == personRecord1}");
//Console.WriteLine($"PersonClass equal is {personClass1 == personClass2}");

//PersonRecord2 personRecord = new PersonRecord2(1, "abbas", "Abbasi");
//PersonRecord2 personRecord3 = personRecord with { Id = 2 };

//Person8 person = new Person8
//{
//    Id = 1,
//    FirstName = "Gholi",
//};

//Person8 Person1 = person with { Id = 8 };

//var dayOfWeek = DayOfTheWeek.Tuesday;
//Enum.TryParse<DayOfTheWeek>("Saturday", out DayOfTheWeek saturday);
var sample = new Sample();
sample.caller01();

var person = new CSharpTypes.Partial.Person
{
    Id = 1,
    LastName = "Test",
    Name = "Test"  
};


