using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAddition
{
    interface Addition
    {
        int DoAdd(int a, int b);
    }
    interface Substruction
    {
        int DoSub(int a, int b);
    }
    interface Multiplication
    {
        int DoMulti(int a, int b);
    }
    interface Division
    {
        double DoDiv(double a, double b);
    }
    class Add : Addition
    {
        public int DoAdd(int a,int b)
        {
            return (a + b);
        }
    }
    class CalculateAll : Substruction, Multiplication, Division
    {
        public int DoSub(int c, int d)
        {
            return (c - d);
        }
        public int DoMulti(int x,int y)
        {
            return (x * y);
        }
        public double DoDiv(double x,double y)
        {
            return (x / y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Add a = new Add();
            CalculateAll cal = new CalculateAll();
            Console.WriteLine("Addition of the two numbers is: " + a.DoAdd(45, 35));
            Console.WriteLine("Substruction of two numbers is: " + cal.DoSub(65, 10));
            Console.WriteLine("Multiplication of the two numbers is: " + cal.DoMulti(6, 9));
            Console.WriteLine("Division of the numbers is: " + cal.DoDiv(50, 9));
            Console.Read();
        }
    }
}
