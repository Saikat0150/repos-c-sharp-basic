using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandelingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                string[] cities = { "New Delhi", "Bangalore", "Hyderabad", "Mumbai" };
                Console.WriteLine(cities[4]);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            try
            {
                int n1, n2, n3;
                Console.Write("Enter first value: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second value: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = n1 / n2;
                Console.WriteLine("Result is: " + n3);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }
    }
}
