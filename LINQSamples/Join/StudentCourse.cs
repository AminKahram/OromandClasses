using LINQSampels.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSampels.Join
{
    public class StudentCourse
    {
        public int Id { get; set; }
        public  int  StudentId { get; set; }
        public string Name { get; set; }
        public int Score { get; set; }
        public static List<StudentCourse> getStudentCourse() => 
            new List<StudentCourse>
            {
                new StudentCourse{Id = 1, StudentId = 1, Name = "ASP.NET", Score = 20},
                new StudentCourse{Id = 2, StudentId = 1, Name = "SQL Server", Score = 20},
                new StudentCourse{Id = 3, StudentId = 2, Name = "ASP.NET Core", Score = 20},
                new StudentCourse{Id = 4, StudentId = 2, Name = "EF Core", Score = 20},
                new StudentCourse{Id = 5, StudentId = 3, Name = "ASP.NET", Score = 20},
                new StudentCourse{Id = 6, StudentId = 3, Name = "SQL Server", Score = 20},
            };

        public static void InnerJoin()
        {
            var students = Student.GetStudents();
            var course = getStudentCourse();

            var result = students
                        .Join(course,
                         s => s.Id,
                         s => s.StudentId,
                         (s, c) =>
                         new
                         {
                             StudentId = s.Id,
                             CourseId = c.Id,
                             s.FirstName,
                             s.LastName,
                             c.Name,
                             c.Score
                         });
            foreach (var item in result)
            {
                 Console.WriteLine($"{item.StudentId} {item.FirstName} {item.LastName} {item.Name} {item.Score}");
            }
        }

        public static void GroupJoin()
        {
            var students = Student.GetStudents();
            var course = getStudentCourse();

            var groupJoin = students
                            .GroupJoin(course,
                            s => s.Id,
                            c => c.StudentId,
                            (s, c) =>
                            new
                            {
                                s.Id,
                                s.FirstName,
                                s.LastName,
                                studentCourses = c ?? new List<StudentCourse>()
                            }).ToList();
            foreach (var item in groupJoin)
            {
                 Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName} {item.studentCourses?.Count()} ");
            }

        }

        public static void LeftJoin()
        {
            var students = Student.GetStudents();
            var course = getStudentCourse();

            var groupJoin = students
                            .GroupJoin(course,
                            s => s.Id,
                            c => c.StudentId,
                            (s, c) =>
                            new
                            {
                                s.Id,
                                s.FirstName,
                                s.LastName,
                                studentCourses = c ?? new List<StudentCourse>()
                            }).SelectMany(c => 
                                          c.studentCourses.DefaultIfEmpty(),
                                          (s, c) =>
                                          {
                                              return new
                                              {
                                                  s.Id,
                                                  s.FirstName,
                                                  s.LastName,
                                                  course = c?.Name ?? "---"
                                              };
                                          }).ToList();
            foreach (var item in groupJoin)
            {
                Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName} {item.course} ");
            }

        }

    }
}
