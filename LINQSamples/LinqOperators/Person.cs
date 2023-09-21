using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples.LinqOperators
{
    public class LinqOperatorsSampel
    {
        List<string> names = new List<string>
            {
                "Abbas Abbasi",
                "Ajdar Ajdari",
                "Framarz Godarzi",
                "Mohammad Begir",
                "Amir Plus",
                "Gholam Gholami",
                "Soghra Kobari",
                "Kobra Soghrai"
            };
        public int Id { get; set; }
        public string Name { get; set; }


        public static void Satrt()
        {
            LinqOperatorsSampel linqOperatorsSampel = new LinqOperatorsSampel();
            linqOperatorsSampel.PrintNamesWithOutLinQ();
            Console.WriteLine("");

            linqOperatorsSampel.PrintNameWithLINQQuerySyntax();
            Console.WriteLine("");

            linqOperatorsSampel.PrintNameWithLINQMethodSyntax();
            Console.WriteLine("");

            linqOperatorsSampel.PrintNumbersDeferred();
            Console.WriteLine("");

            linqOperatorsSampel.PrintNumbersImmediate();
        }

        public void PrintNamesWithOutLinQ()
        {
            List<string> results = new List<string>();

            foreach (string name in names)
            {
                if (name.StartsWith("A"))
                    results.Add(name);
            }
            results.Sort();

            foreach (string name in results)
            {
                Console.WriteLine(name);
            }
        }

        public void PrintNameWithLINQQuerySyntax()
        {
            var result = from name in names 
                         where name.StartsWith("A") 
                         orderby name 
                         select name;
            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }

        public void PrintNameWithLINQMethodSyntax()
        {
            var result = names
                .Where(n => n.StartsWith("A"))
                .OrderBy(n => n)
                .Select(n => n);
            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }
        
        public void PrintNumbersDeferred()
        {
            List<int> numbers = new List<int> { 1, 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            var lessThanTen = from n in numbers
                              where n < 10
                              select n;

            foreach (int n in lessThanTen)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("************************");

            numbers.Add(3);
            numbers.Add(5);
            foreach (int n in lessThanTen)
            {
                Console.WriteLine(n);
            }

        }

        public void PrintNumbersImmediate()
        {
            List<int> numbers = new List<int> { 1, 2, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            var lessThanTen = (from n in numbers
                              where n < 10
                              select n).ToList();

            foreach (int n in lessThanTen)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("************************");

            numbers.Add(3);
            numbers.Add(5);
            foreach (int n in lessThanTen)
            {
                Console.WriteLine(n);
            }

        }
    }
}
