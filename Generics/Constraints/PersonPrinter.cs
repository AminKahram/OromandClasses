namespace Generics.Constraints
{
    public class PersonPrinter<Tinput> where Tinput : Person , new() 
    {
        public void Print(Tinput input)
        {

            //var person = input as Person ?? new Person();

            //Console.WriteLine($"{person.FirstName} {person.LastName}");
            if (input == null)
                input = new Tinput();
            
            Console.WriteLine($"{input.FirstName} {input.LastName}");
        }
    }
}
