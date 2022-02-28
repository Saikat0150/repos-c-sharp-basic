using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    public static class MyMath
    {
        public static double PI = 3.1416;
        public static int Cube(int n)
        {
            return (n * n * n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The value of PI is: " + MyMath.PI);
            Console.WriteLine("The cube of 9 is: " + MyMath.Cube(9));
            Console.ReadLine();
        }
    }
}
