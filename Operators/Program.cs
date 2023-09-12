// See https://aka.ms/new-console-template for more information
using Operators.BinaryOperators;
using Operators.CheckedAndUnchecked;
using Operators.Indexer;
using Operators.IsAs;
using Operators.NullOperator;
using Operators.OperatorOverloading;
using Operators.SizeOf;
using Operators.TypeOf;
using System.Linq.Expressions;

//Console.WriteLine("Hello, World!");


//CheckedAunUncheckedSample sample = new();
//sample.Checked();
////sample.Checked2();
//IsAsSample sample = new();
//var student = new Student
//{
//    FirstName = "Abbas",
//    LastName = "Anghezi",
//    Text = "efmnekjnfkebfkebf"
//};
//var teacher = new Teacher
//{
//    FirstName = "Alireaz",
//    LastName = "Oromand"
//};

//sample.CheckIs(student);
//sample.CheckIs(teacher);

//sample.CheckAs(student);
//sample.CheckAs(teacher);
//SampleSizeOf sz = new();
//sz.SizeOf();

//SampleTypeOf sample = new();
//sample.TypeOf();

//Console.WriteLine(nameof(Teacher));

//sampleNullOperator sample = new();
//sample.NullOperator02(null);

//BinaryOperatorSample sample = new();
//sample.Xor();

//money money01 = new money(2000);
//money money02 = new money(2000);

//money money = money01.Add(money02);
//money money1 = money01 + money02;

//Console.WriteLine(money.Value);
//Console.WriteLine(money1.Value);

//Console.WriteLine(money01 == money02);
//Console.WriteLine(object.ReferenceEquals(money01, money02));

Wallet wallet = new();
wallet[0] = new money(1000);
wallet[1] = new money(2000);
wallet[2] = new money(5000);
wallet[3] = new money(10000);

Console.WriteLine(wallet[2].Value);
wallet[2] = new money(50000);
Console.WriteLine(wallet[2].Value);

wallet[4] = 6000;

int value = wallet[2];

byte moneyValue = (byte)wallet[3];  

Console.ReadLine(); 