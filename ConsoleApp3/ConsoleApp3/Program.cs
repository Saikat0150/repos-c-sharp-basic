using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Rahul", "john", "Mayak", "Raj" };
            //calling a method that returns a referance
            ref string student = ref FindStudent(students, "john");
            Console.WriteLine(student);
            Console.Read();
        }
        static ref string FindStudent(string[] students, string student)
        {
            for(int i = 0; i < student.Length; i++)
            {
                if(students[i].Equals(student))
                {
                    return ref students[i];
                }
            }
            throw new IndexOutOfRangeException("Student not found");
        }
    }
}
