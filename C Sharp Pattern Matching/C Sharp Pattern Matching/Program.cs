using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Pattern_Matching
{
    class Student
    {
        public string Name { get; set; } = "Rahul Kumar";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            if(s is Student)
            {
                Console.WriteLine(s.Name);
            }
            Console.Read();
        }
    }
}
