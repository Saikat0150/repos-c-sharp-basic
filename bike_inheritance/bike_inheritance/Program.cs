using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bike_inheritance
{
    class Bike
    {
        public void DisplayBikeInsurance()
        {
            Console.WriteLine("The Insurance plan for bike is 1200 INR for 12 Months...");
        }
    }
    class Car : Bike
    {
        public void DisplayCarInsurance()
        {
            Console.WriteLine("The Insurance plan for the car is 5000 INR for 12 Months...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.DisplayCarInsurance();
            c.DisplayBikeInsurance();
            Console.Read();
        }
    }
}
