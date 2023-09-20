using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionSample.LinkedListSamples
{
    public class LinkedListSample
    {
        LinkedList<string> list = new LinkedList<string>();
        public void AddLast (string s)
        {
            list.AddLast(s);
        }
        public void AddSecondNode(string s)
        {
            LinkedListNode<string> node = new LinkedListNode<string>(s);
            var first = list.First;
            list.AddAfter(first, node);
        }
    }
}
