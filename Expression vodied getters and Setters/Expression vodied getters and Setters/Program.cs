using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_vodied_getters_and_Setters
{
    class Student
    {
        private string SName;
        public Student(string name) => SName = name;
        public string Name
        {
            get => SName;
            set => SName = value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Peter");
            Console.WriteLine(s1.Name);
            Console.Read();
        }
    }
}
