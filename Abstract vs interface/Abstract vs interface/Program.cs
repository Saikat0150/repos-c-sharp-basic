using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_vs_interface
{
    abstract class MyBaseClass
    {
        public abstract void FirstMethod();
        public void SecondMethod()
        {
            Console.WriteLine("This is Non-Abstract Method..");
        }
    }
    class MyDerivedClass : MyBaseClass
    {
        public override void FirstMethod()
        {
            Console.WriteLine("This is abstract Method");
        }
    }
    //Starting of interface code
    interface Addition
    {
        int DoAdd(int a, int b);
    }
    class Add : Addition
    {
        public int DoAdd(int a, int b)
        {
            return (a + b);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------<Abstract Class Example>------------------------");
            MyDerivedClass m = new MyDerivedClass();
            m.FirstMethod();
            m.SecondMethod();

            Console.WriteLine("-----------------------<Interface>---------------------------");
            Add a = new Add();
            Console.WriteLine("Addition of the two numbers is: " + a.DoAdd(45, 35));
            Console.Read();
            Console.Read();
        }
    }
}
