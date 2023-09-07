// See https://aka.ms/new-console-template for more information
using OOPInCSharp.Constroctors;
using OOPInCSharp.Implicit_vs_Explicit_Interface;
using OOPInCSharp.Inheritance;
using OOPInCSharp.PredefinedInterfaces;
using OOPInCSharp.VirtualMethods;
using System.Collections.Generic;

//Console.WriteLine("Hello, World!");

//Parent parent = new();
//parent.GetHashCode();
//Console.WriteLine(parent.GetClassName());

//FirstChild firstChild = new();

//Console.WriteLine(firstChild.GetClassName());
//Console.WriteLine(firstChild.GetChildClassName());

//Animal animal = new();
//Console.WriteLine($"Animal Voice Is :");
//animal.Voice();


//Dog dog = new();
//Console.WriteLine($"Animal Voice Is :");
//dog.Voice();


//Cat cat = new();
//Console.WriteLine($"Animal Voice Is :");
//cat.Voice();


//Cow cow = new();
//Console.WriteLine($"Animal Voice Is :");
//cow.Voice();
//List<OOPInCSharp.Abstract.Animal> animals = new List<OOPInCSharp.Abstract.Animal>();
//OOPInCSharp.Abstract.Animal cat = new OOPInCSharp.Abstract.Cat();
//OOPInCSharp.Abstract.Animal dog = new OOPInCSharp.Abstract.Dog();
//OOPInCSharp.Abstract.Animal cow = new OOPInCSharp.Abstract.Cow();
//animals.Add(cat);
//animals.Add(dog);   
//animals.Add(cow);

//foreach (var animal in animals)
//{
//    animal.Feed();
//}

Mobile mobile = new("Iphone");
Mobile mobile1 = new();

using(TestDisposable disposable = new())
{

}

TestImplicitIntefaceImplemnet testImplicitIntefaceImplemnet = new();
testImplicitIntefaceImplemnet.Test();
testImplicitIntefaceImplemnet.Temp();

TestExplicitIntefaceImplemnet testExplicitIntefaceImplemnet = new();
testExplicitIntefaceImplemnet.Test();

ITestImplicitInteface testImplicitInteface = testExplicitIntefaceImplemnet;

testImplicitInteface.Temp();
testImplicitInteface.Test();

ITestImplicitInteface2 testImplicitInteface2 = testExplicitIntefaceImplemnet;
  
testImplicitInteface2.Temp();