using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_destructor
{
    class SimpleDemo
    {
        public SimpleDemo()
        {
            Console.WriteLine("This is constructor");
        }
        ~SimpleDemo()
        {
            Console.WriteLine("This is destructor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleDemo s = new SimpleDemo();
            Console.Read();
        }
    }
}
