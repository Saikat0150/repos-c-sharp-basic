using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var q = new LinkedList<string>();
            q.AddLast("ram");
            q.AddLast("suresh");
            q.AddLast("Anil");
            q.AddLast("Suraj");
            LinkedListNode<string> node = q.Find("suresh");
            q.AddBefore(node, "Sita");
            q.AddAfter(node, "Lucy");
            foreach (string i in q)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
