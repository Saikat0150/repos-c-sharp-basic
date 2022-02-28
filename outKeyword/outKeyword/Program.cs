using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y;
            Multiplication(out x,out y);
            Console.WriteLine("Variable value are: " + x + " And "+ y);
            Console.WriteLine("....Press enter to exit....");

            Console.Read();
        }
        public static void Multiplication(out int a,out int b)
        {
            a = 10;
            b = 20;
            a = a * b;
            b = a / b;
        }
    }
}
