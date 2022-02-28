using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace get_set
{
    class Employee
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "Saikat Mondal";
            Console.WriteLine("Employee name: " + e.Name);
            Console.Read();
        }
    }
}
