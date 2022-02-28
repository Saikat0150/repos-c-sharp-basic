using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            for(int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("The number " + n + " is prime..");
            }
            else
            {
                Console.WriteLine("The number " + n + " is not prime..");
            }
            Console.Read();
        }
    }
}
