// See https://aka.ms/new-console-template for more information
using Operators.CheckedAndUnchecked;
using Operators.IsAs;

Console.WriteLine("Hello, World!");


//CheckedAunUncheckedSample sample = new();
//sample.Checked();
//sample.Checked2();
IsAsSample sample = new();
var student = new Student
{
    FirstName = "Abbas",
    LastName = "Anghezi",
    Text = "efmnekjnfkebfkebf"
};
var teacher = new Teacher
{
    FirstName = "Alireaz",
    LastName = "Oromand"
};

sample.CheckIs(student);
sample.CheckIs(teacher);

sample.CheckAs(student);
sample.CheckAs(teacher);

Console.ReadLine(); 