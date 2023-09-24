using LINQSamples.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples.Grouping
{
    public class GroupingSample
    {
        public static void GropupStudents()
        {
            var students = Student.GetStudents();

            var groupByGrade = students.GroupBy(x => x.Grade);

            foreach ( var grade in groupByGrade )
            {
                Console.WriteLine(grade.Key);
                foreach ( var student in grade )
                {
                    Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName} {student.Grade}");
                }

                Console.WriteLine("".PadLeft(100, '-'));
            }
        }
    }
}
