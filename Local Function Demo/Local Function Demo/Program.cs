using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Function_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = add(10, 20);
            Console.WriteLine("Sum of 10 and 20 is: " + result);

            int add(int a,int b)
            {
                return a + b;
            }
            Console.Read();
        }
    }
}
