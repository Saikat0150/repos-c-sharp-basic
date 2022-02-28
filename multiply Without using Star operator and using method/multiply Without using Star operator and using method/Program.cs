using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiply_Without_using_Star_operator_and_using_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Multiplication is: " + multiply(a, b));
            Console.Read();
        }
        static int multiply(int a,int b)
        {
            int i, multi = 0;
            if (b < 0)
            {
                b = -b;
                a = -a;
            }
            for (i = 1; i <= b; i++)
            {
                multi += a;
            }
            return multi;
        }
    }
}
