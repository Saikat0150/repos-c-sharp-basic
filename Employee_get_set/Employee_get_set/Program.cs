using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_get_set
{
    public class Employee
    {
        private static int counter;
        public Employee()
        {
            counter++;
        }
        public static int Counter
        {
            get
            {
                return counter;
            }
            set
            {
                counter = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();
            Employee e3 = new Employee();
            Console.WriteLine("No of employees are: " + Employee.Counter);
            Console.ReadLine();
        }
    }
}
