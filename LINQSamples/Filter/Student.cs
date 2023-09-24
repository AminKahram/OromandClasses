using LINQSamples.LinqOperators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples.Filter
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }

        public static void PrintStudents(List<Student> students)
        {
            Console.WriteLine("".PadLeft(100, '-'));
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Grade}");
            }
            Console.WriteLine("".PadLeft(100, '-'));
             
        }
        public static List<Student> GetStudents()
            => new List<Student>
            { 
                new Student {Id = 10, FirstName = "Anghezi", LastName = "Abbasi", Grade = 20},   
                new Student {Id = 1, FirstName = "Abbas", LastName = "Abbasi", Grade = 20},
                new Student {Id = 2, FirstName = "AliReza", LastName = "Nori", Grade = 18},   
                new Student {Id = 3, FirstName = "Mohammad", LastName = "Gholizade", Grade = 7},   
                new Student {Id = 8, FirstName = "vahid", LastName = "Janati", Grade = 14},   
                new Student {Id = 4, FirstName = "Farid", LastName = "Janati", Grade = 14},
                new Student {Id = 5, FirstName = "Gholi", LastName = "Rohani", Grade = 16},   
                new Student {Id = 6, FirstName = "Azhdar", LastName = "Beukian", Grade = 19},   
                new Student {Id = 7, FirstName = "Navid", LastName = "Hatami", Grade = 15},
                new Student {Id = 9, FirstName = "Taher", LastName = "Hatami", Grade = 15},
            }; 

        public void FilterStudentsQuery()
        {
            var students = GetStudents();
            var result = from student in students
                         where student.Grade > 15
                         select student;
            PrintStudents(result.ToList());

        }

        public void FilterStudentsMethod()
        {
            var students = GetStudents();
            var result = students
                        .Where((s,index) => s.Grade > 15 || s.Grade > index);
            PrintStudents(result.ToList());
        }

        public void FilterByType()
        {
            List<object> list = new List<object> {"Ghoalm" , 1 , false ,new LinqOperatorsSampel() };
            var numbers = list.OfType<int>().ToList();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
