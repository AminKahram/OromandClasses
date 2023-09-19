using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample.QueueSample
{
    public class PriorityQueueSample
    {
        public PriorityQueue<string,int> PriorityQueue = new PriorityQueue<string,int>();
        public void AddWithSamePriority()
        {
            PriorityQueue.Enqueue("1", 1);
            PriorityQueue.Enqueue("2", 1);
            PriorityQueue.Enqueue("3", 1);

            Console.WriteLine(PriorityQueue.Dequeue());
            Console.WriteLine(PriorityQueue.Dequeue());
            Console.WriteLine(PriorityQueue.Dequeue());
        }

        public void AddWithDiffrentPriority()
        {
            PriorityQueue.Enqueue("1", 5);
            PriorityQueue.Enqueue("2", 9);
            PriorityQueue.Enqueue("3", 1);

            Console.WriteLine(PriorityQueue.Dequeue());
            Console.WriteLine(PriorityQueue.Dequeue());
            Console.WriteLine(PriorityQueue.Dequeue());
        }
    }
}
