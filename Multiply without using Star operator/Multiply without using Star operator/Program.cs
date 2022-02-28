using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_without_using_Star_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,result=0;
            Console.WriteLine("Enter the first number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == 0 || b == 0)
            {
                Console.WriteLine("The multiplication of " + a + " and " + b + " is: " + 0);
                Console.Read();
            }
            else
            {
                for(int i = 1; i <= b; i++)
                {
                    result +=  a;
                }
                Console.WriteLine("The multiplication of " + a + " and " + b + " is: " + result);
                Console.Read();
            }
            
        }
    }
}
