using static System.Net.Mime.MediaTypeNames;

namespace CSharpTypes.Feild;
public class Person
{
    private readonly int age=1;
    private string _firstName;
    public string FirstName 
    {
        get
        {
            return _firstName;
        }
        set 
        { 
            _firstName = value;
        }
    }
    public  string LastName { get; set; }
    public string FatherName { get; init; }
    public Person(int age)
    {
        this.age = age;
    }
    public void PrintFullName()
    {
        Console.WriteLine($"{FirstName} {LastName}");
    }
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    public string GetFullNameEXp() => $"{FirstName} {LastName}";
    public int AddToNumbers(int number1, int number2)
    {
        return number1 + number2;
    }
    public static int GetCount()
    {
        return 0; 
    }
    public void Print(string text) 
    {
        Console.WriteLine($"{text}");
    }
    public void Print(string text1,string text2)
    {
        Console.WriteLine($"{text1} {text2}");
    }
    public void Print(int number)
    {
        Console.WriteLine($"{number}");
    }
    public void PrintNumbers(int width, int height)
    {
        Console.WriteLine($"x is {width}, y is {height}");
    }
    public void OptionalSample(int x, int y, int z = 2, int b = 5)
    {
        Console.WriteLine($"x is {x}, y is {y}, z is {z}, z is {b}");
    }
    public void ParamsTest(params int[] myNumber)
    {
        foreach(int number in myNumber)
        {
            Console.WriteLine(number);
        }
    }
    public void PrintFullName2()
    {

        string fullName = GetFullName(FirstName,LastName);
        Console.WriteLine(fullName);


        static string GetFullName(string firstName, string lastName)
        {
            return string.Format(firstName, lastName);
        }
    }
} 
