using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Salary_bonous
{
    class Employee
    {
        public void Salary()
        {
            Console.WriteLine("The Salary is: 20000");
        }
    }
    class Programmer : Employee
    {
        public void Bonus()
        {
            Console.WriteLine("the Bonus is: 5000");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Programmer p = new Programmer();
            p.Salary();
            p.Bonus();
            Console.Read();
        }
    }
}
