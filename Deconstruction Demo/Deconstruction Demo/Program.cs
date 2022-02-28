using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstruction_Demo
{
    public class Student
    {
        private string Name;
        private string Email;
        public Student(string name,string email)
        {
            this.Name = name;
            this.Email = email;
        }
        //creating Deconstruct
        public void Deconstruct(out string name, out string email)
        {
            name = this.Name;
            email = this.Email;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Ram", "ram@gmail.com");
            var (name, email) = student;
            Console.WriteLine(name + " " + email);
            Console.Read();
        }
    }
}
