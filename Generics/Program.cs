// See https://aka.ms/new-console-template for more information
using Generics.Constraints;
using Generics.GenericClass;
using Generics.GenericMethod;
using Generics.StaticMembers;

//Console.WriteLine("Hello, World!");

//GenericConcat<int> genericConcat = new();

//var result = genericConcat.Concat(1, 2);

//Console.WriteLine($"{result}");

//GenericConcat<string> genericConcat1 = new();

//var result1 = genericConcat1.Concat("abbas", "Gholam");

//Console.WriteLine($"{result1}");

//GenericConcat<Person> genericConcat2 = new();

//var result2 = genericConcat2.Concat(new Person {FirstName = "Abbas", LastName = "Abbasi"}, new Person {FirstName = "Gholam", LastName = "Gholami"});
//Console.WriteLine(result2);

//Teacher teacher = new Teacher 
//{
//    FirstName = "Abbas",
//    LastName = "Abbasi"
//    ,TeacherNumber = "123"
//};

//Student student = new Student
//{
//    FirstName = "Asghar",
//    LastName = "asghari"
//    ,
//    StudentNumber = "1235"
//};

//var teacherprinter = new PersonPrinter<Teacher>();
//teacherprinter.Print(teacher);

//var studentPrinter = new PersonPrinter<Student>();
//studentPrinter.Print(student);

//var carPrinter = new PersonPrinter<Car>();
//carPrinter.Print(new Car { Id = 2});


//StaticParam<int>.Counter = 12;
//StaticParam<string>.Counter = 15;
//StaticParam<bool>.Counter = 1;

//Console.WriteLine(StaticParam<int>.Counter);
//Console.WriteLine(StaticParam<string>.Counter);
//Console.WriteLine(StaticParam<bool>.Counter);

//StaticParam<int>.Counter = 13;
//Console.WriteLine(StaticParam<int>.Counter);

Simple simple = new();
simple.Print<string>("This is string terst");
Console.ReadLine();
