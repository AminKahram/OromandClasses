using LINQSamples.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSamples.Sorting
{
    public class SortingSampel
    {
        public static void SortStudents()
        {
            var students = Student.GetStudents().ToList();
            var sortedStudents = students.OrderBy(x=> x.Grade).ThenBy(x => x.FirstName);

            Student.PrintStudents(sortedStudents.ToList());

        }

        public static void SortDescStudents()
        {
            var students = Student.GetStudents().ToList();
            var sortedStudents = students.OrderByDescending(x => x.FirstName);

            Student.PrintStudents(sortedStudents.ToList());

        }
    }
}
