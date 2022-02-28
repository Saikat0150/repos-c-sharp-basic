using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace default_value_getter_only_demo
{
    class Student
    {
        public string Name { get; } = "Rahul Kumar";
        public string Email { get; } = "rahul@gmail.com";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Email);
            Console.Read();
        }
    }
}
