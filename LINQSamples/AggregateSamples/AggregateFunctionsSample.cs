using LINQSampels.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSampels.AggregateSamples
{
    public class AggregateFunctionsSample
    {
        public void AggregateFunction()
        {
            var students = Student.GetStudents();

            var totalCount = students.Count();
            var minValue = students.Min(s => s.Grade);
            var maxValue = students.Max(s => s.Grade);
            var avg = students.Average(s => s.Grade);
            var sum = students.Sum(s => s.Grade);

            Console.WriteLine($"Total count : {totalCount} Min Grade : {minValue} Max Value : {maxValue} average : {avg}  Sum : {sum}");
        }
    }
}
