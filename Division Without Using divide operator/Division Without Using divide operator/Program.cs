using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_Without_Using_divide_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c,d,quotient=0;
            if (a < 0 && b>0)
            {
                c = -a;
                while (c >= b)
                {
                    c = c - b;
                    quotient++;
                }
                quotient = -quotient;
                Console.WriteLine("Questient is: " + quotient);
            }
            else if (a > 0 && b < 0)
            {
                c = a;
                d = -b;
                while (c >= d)
                {
                    c = c - d;
                    quotient++;
                }
                quotient = -quotient;
                Console.WriteLine("Questient is: " + quotient);

            }
            else if (a == 0)
            {
                Console.WriteLine("Questient is: " + 0);
            }
            else if (b == 0)
            {
                Console.WriteLine("Can't devide by 0");
            }
            else
            {
                c = a;
                d = b;
                while (c >= d)
                {
                    c = c - d;
                    quotient++;
                }
                Console.WriteLine("Questient is: " + quotient);
            }
            Console.ReadLine();
        }
    }
}
