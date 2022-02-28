using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Matching_Switch_Statement
{
    class Student
    {
        public string Name { get; set; } = "Rahul Kumar";
    }
    class Teacher
    {
        public string Name { get; set; } = "Ram";
        public string Specialization { get; set; } = "Computer Science";
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Teacher t = new Teacher();
            PatternInSwitch(s);
            PatternInSwitch(t);
            Console.Read();
            
        }
        public static void PatternInSwitch(object obj) 
        {
            switch (obj)
            {
                case Student s:
                    Console.WriteLine(s.Name);
                    break;
                case Teacher t:
                    Console.WriteLine(t.Name);
                    Console.WriteLine(t.Specialization);
                    break;
                default:
                    throw new ArgumentException(message: "Object is not recognized", paramName: nameof(obj));
            }
        }
    }
}
