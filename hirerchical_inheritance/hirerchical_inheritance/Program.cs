using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hirerchical_inheritance
{
    class Base
    {
        public void Show()
        {
            Console.WriteLine("This is base class...");
        }
    }
    class Child1 : Base
    {
        public void display()
        {
            Console.WriteLine("This is one Sub class...");
        }
    }
    class Child2 : Base
    {
        public void Dis()
        {
            Console.WriteLine("This is another Sub class...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            b.Show();
            Console.WriteLine("--------------------------");
            Child1 c1 = new Child1();
            c1.display();
            Console.WriteLine("--------------------------");
            Child2 c2 = new Child2();
            c2.Dis();
            Console.Read();
        }
    }
}
