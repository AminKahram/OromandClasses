using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample.ListSamples
{
    public class ListSample
    {
        List<string> list = new List<string>(10);
        public void PrintCapacity()
        {
            Console.WriteLine($"List Capacity is : {list.Capacity}");
        }
        public void PrintCount()
        {
            Console.WriteLine($"List Count is : {list.Count}");
        }
        public void AddMember(string member)
        {
            list.Add(member);
        }
        public void AddRangeMember(string[] members)
        {
            list.AddRange(members);
        }
        public void Ensure()
        {
            list.EnsureCapacity(20);
        }

        public void Trim()
        {
            list.TrimExcess();
        }
        public void RemoveMember(string member)
        {
            list.Remove(member);
            list.RemoveAll(x => x.StartsWith("1"));
            list.RemoveAt(10);
            list.RemoveRange(5, 8);
            list.Clear();
        }
        public void Insert()
        {
            list.Insert(5, "Yo");
        }
        public void find()
        {
            var result1 = list.Find (x => x.StartsWith("1"));
            var result2 = list.FindAll(x => x.StartsWith("1"));
        }
        public IReadOnlyList<string> GetReadOnly()
        {
            return list.AsReadOnly();
        }
    }
}
