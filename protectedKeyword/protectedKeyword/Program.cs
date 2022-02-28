using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protectedKeyword
{
    class Employee
    {
        protected string name;
        protected int id;
        protected void Input()
        {
            Console.WriteLine("Enter the Employee Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the Employee Id: ");
            id = Convert.ToInt32(Console.ReadLine());
        }
        protected void Display()
        {
            Console.WriteLine("Name of the Employee is: " + name);
            Console.WriteLine("Employee id: " + id);
        }
    }
    class Analyst : Employee
    {
        public int Salary;
        public void Finput()
        {
            Input();
            Console.WriteLine("Enter the Salary: ");
            Salary = Convert.ToInt32(Console.ReadLine());
        }
        public void FDisplay()
        {
            
            Display();
            Console.WriteLine("Salary of the Analyst is: " + Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Analyst a = new Analyst();
            a.Finput();
            a.FDisplay();
            Console.Read();
        }
    }
}
