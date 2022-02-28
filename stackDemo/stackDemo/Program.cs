using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> names = new Stack<string>();
            names.Push("ram");
            names.Push("suresh");
            names.Push("anil");
            names.Push("Suraj");
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("peek elements: " + names.Peek());
            Console.WriteLine("Pop: " + names.Pop());
            Console.WriteLine("After Pop. Peek element: " + names.Peek());
            Console.Read();
        }
    }
}
