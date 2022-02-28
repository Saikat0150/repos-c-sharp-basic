using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_Propagator_Demo
{
    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //checking for null values without using null Propagator
            /*Student student = new Student() { Name = "Rahul Kumar" };
            if (student.Name != null)
            {
                Console.WriteLine(student.Name.ToUpper());
            }*/
            // With using null Propagator
            Student s = new Student() { Name = "Rahul Kumar" };
            Console.WriteLine(s?.Name?.ToUpper() ?? "Name is Empty");
            Console.WriteLine(s?.Email?.ToUpper() ?? "Email is Empty");
            Student s1 = new Student();
            Console.WriteLine(s1?.Name?.ToUpper() ?? "Name is Empty");
            Console.WriteLine(s1?.Email?.ToUpper() ?? "Email is Empty");
            Console.Read();
        }
    }
}
