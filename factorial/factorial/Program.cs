using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Factorial
    {
        public int factCalculate(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            else
            {
                return num * factCalculate(num - 1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Factorial f = new Factorial();
            Console.WriteLine("The factorial of " + num + " is " + f.factCalculate(num));
            Console.ReadLine();
        }
    }
}
