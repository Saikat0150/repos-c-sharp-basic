using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
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
    class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass m = new MyDerivedClass();
            m.FirstMethod();
            m.SecondMethod();
            Console.Read();
        }
    }
}
