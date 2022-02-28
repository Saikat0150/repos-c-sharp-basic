using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericClass
{
    class Sample<T>
    {
        T n;
        public void set(T n)
        {
            this.n = n;
        }
        public void Print()
        {
            Console.WriteLine(n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample<int> s1 = new Sample<int>();
            s1.set(10);
            s1.Print();
            Sample<string> s2 = new Sample<string>();
            s2.set("Hello");
            s2.Print();
            Console.Read();
        }
    }
}
