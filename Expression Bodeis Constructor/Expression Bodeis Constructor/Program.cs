using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Bodeis_Constructor
{
    class Student
    {
        public string Name { get; set; }
        //Expression Constructor

        public Student(string name) => Name = name;
        ~Student() => Console.WriteLine("Finalizer Executing");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Rahul");
            Console.WriteLine($"Hello{s.Name}");
            Console.Read();
        }
    }
}
