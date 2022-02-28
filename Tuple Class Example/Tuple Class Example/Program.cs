using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_Class_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //one method
            //var book = new Tuple<string, string, double>("C#.NET", "John", 100.50);
            
            //another method
            var book = Tuple.Create("C#.NET", "John", 100.50);
            Console.WriteLine("--------------------Books Record------------------");
            Console.WriteLine("Title: " + book.Item1);
            Console.WriteLine("Author: " + book.Item2);
            Console.WriteLine("Price: " + book.Item3);
            Console.Read();
        }
    }
}
