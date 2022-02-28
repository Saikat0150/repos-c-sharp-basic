using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    delegate void visi();
    class abc
    {
        public void put()
        {
            Console.WriteLine("This is put method...");
        }
        public static void put1()
        {
            Console.WriteLine("This id put1 static methods....");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            visi x1;
            abc a = new abc();
            x1 = a.put;
            x1 += abc.put1;
            x1 += a.put;
            x1();
            Console.WriteLine("Removing methids from delegate: ");
            x1 -= a.put;
            x1();
            Console.Read();
        }
    }
}
