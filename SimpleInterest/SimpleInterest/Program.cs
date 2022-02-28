using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            int principle;
            double interest;
            int time;
            double rate;
            Console.WriteLine("Enter the principle: ");
            principle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the interest rate: ");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the time in year: ");
            time = Convert.ToInt32(Console.ReadLine());
            interest = (principle * rate * time) / 100;
            Console.WriteLine("The interest is: " + interest);
            Console.Read();
        }
    }
}
