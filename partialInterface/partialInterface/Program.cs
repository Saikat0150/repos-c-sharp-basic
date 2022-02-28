using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialInterface
{
    partial interface Sub
    {
        int DoSub(int x, int y);
    }
    partial interface Add
    {
        int DoAdd(int x, int y);
    }
    class Claculate : Add, Sub
    {
        public int DoAdd(int x,int y)
        {
            return x + y;
        }
        public int DoSub(int x,int y)
        {
            return x - y;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Claculate cal = new Claculate();
            Console.WriteLine("The Addition of the two numbers: " + cal.DoAdd(55, 21));
            Console.WriteLine("The substruction of the two number: " + cal.DoSub(45, 21));
            Console.ReadLine();
        }
    }
}
