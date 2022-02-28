using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodoverriding2
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("This is class A...");
        }
    }
    class B : A
    {
        public override void Display()
        {
            Console.WriteLine("This is class B...");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("This is class C...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Display();
            Console.WriteLine("-------------------------------");
            B b = new B();
            b.Display();
            Console.WriteLine("-------------------------------");
            C c = new C();
            c.Display();
            Console.WriteLine("-------------------------------");
            Console.Read();
        }
    }
}
