using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Exception_Hendaling_Using_Multiple_Catch_Block
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter two numbers: ");
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C value: " + c);
            }
            catch(DivideByZeroException dbe)
            {
                Console.WriteLine("Second number should not be zero");
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Enter only integer numbers");
            }
            Console.Read();
        }
    }
}
