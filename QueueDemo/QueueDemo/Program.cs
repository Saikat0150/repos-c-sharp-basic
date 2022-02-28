using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("ram");
            q.Enqueue("suresh");
            q.Enqueue("Anil");
            q.Enqueue("Suraj");
            foreach(string i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Peek element: " + q.Peek());
            Console.WriteLine("Dqueue: " + q.Dequeue());
            Console.WriteLine("After dequeue: " + q.Peek());
            Console.ReadLine();
            
        }
    }
}
