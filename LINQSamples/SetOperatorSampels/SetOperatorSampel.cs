using LINQSampels.Join;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQSampels.SetOperatorSampels
{
    public class SetOperatorSampel
    {
        public static void Distinct()
        {
            List<int> list = new List<int> {1, 2, 3, 4, 5, 4, 5, 1, 3, 7 };
            var distinct = list.Distinct();
            foreach (int i in distinct)
            {
                Console.WriteLine(i);   
            }
        }

        public static void Union()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 4, 5, 1, 3, 7 };
            List<int> list2 = new List<int> { 1, 8, 9, 10 };

            var union = list.Union(list2);
            foreach (int i in union)
            {
                Console.WriteLine(i);
            }
        }

        public static void Except()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 4, 5, 1, 3, 7 };
            List<int> list2 = new List<int> { 1, 8, 9, 10 };

            var except = list.Except(list2);
            foreach (int i in except)
            {
                Console.WriteLine(i);
            }
        }

        public static void Intersect()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 4, 5, 1, 3, 7 };
            List<int> list2 = new List<int> { 1, 8, 9, 10 };

            var intersect = list.Intersect(list2);
            foreach (int i in intersect)
            {
                Console.WriteLine(i);
            }
        }

        public static void UnionBY()
        {
            List<StudentCourse> list1 = new List<StudentCourse>
            {
                new StudentCourse {Id = 1},
                new StudentCourse {Id = 2},
                new StudentCourse {Id = 3},
                new StudentCourse {Id = 3},
            };

            List<StudentCourse> list2 = new List<StudentCourse>
            {
                new StudentCourse {Id = 4},
                new StudentCourse {Id = 2},
                new StudentCourse {Id = 5},
                new StudentCourse {Id = 6},
            };

            var result =list1
                        .UnionBy(list2,
                        c => c.Id);

            foreach(StudentCourse s in result)
            {
                Console.WriteLine(s.Id);
            }

        }

        public static void DistinctBY()
        {
            List<StudentCourse> list1 = new List<StudentCourse>
            {
                new StudentCourse {Id = 1},
                new StudentCourse {Id = 2},
                new StudentCourse {Id = 3},
                new StudentCourse {Id = 3},
            };

            List<StudentCourse> list2 = new List<StudentCourse>
            {
                new StudentCourse {Id = 4},
                new StudentCourse {Id = 2},
                new StudentCourse {Id = 5},
                new StudentCourse {Id = 6},
            };

            var result = list1
                        .DistinctBy(c => c.Id);

            foreach (StudentCourse s in result)
            {
                Console.WriteLine(s.Id);
            }

        }

        public static void IntersectBY()
        {
            List<StudentCourse> list1 = new List<StudentCourse>
            {
                new StudentCourse {Id = 1},
                new StudentCourse {Id = 2},
                new StudentCourse {Id = 3},
                new StudentCourse {Id = 3},
            };

            var result = list1
                        .IntersectBy(new int[] {1,2 } ,c => c.Id);

            foreach (StudentCourse s in result)
            {
                Console.WriteLine(s.Id);
            }

        }
        public static void ExceptBY()
        {
            List<StudentCourse> list1 = new List<StudentCourse>
            {
                new StudentCourse {Id = 1},
                new StudentCourse {Id = 2},
                new StudentCourse {Id = 3},
                new StudentCourse {Id = 3},
            };



            var result = list1
                        .ExceptBy(new int[] { 1, 2 }, c => c.Id);

            foreach (StudentCourse s in result)
            {
                Console.WriteLine(s.Id);
            }

        }

        public static void Zip()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 4, 5, 1, 3, 7 };
            List<int> list2 = new List<int> { 1, 8, 9, 10 };
            List<int> list3 = new List<int> { 11, 12, 13 };

            var result = list.Zip(list2 , list3);
        }

        public void Pagination(int pageIndex,int pageCount)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 4, 5, 1, 3, 7, 11, 12, 13 };
            var result = list.Skip(pageCount * pageIndex).Take(pageCount).ToList();
        }

        public void Chunk(int ChunkSize)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 4, 5, 1, 3, 7, 11, 12, 13 };
            var result = list.Chunk(ChunkSize);
        }
    }
} 
