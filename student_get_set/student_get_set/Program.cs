using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_get_set
{
    public class Student
    {
        private int studentId;
        private string studentname;
        public int StudentId 
        { 
            set
            {
                Console.WriteLine("This is set Accessor of Student id: ");
                studentId = value;
            }
            get
            {
                Console.WriteLine("This is get accessor of Student id: ");
                return studentId;
            }
        }
        public string studentName
        {
            set
            {
                Console.WriteLine("This is set Accessor of Student name: ");
                studentname = value;
            }
            get
            {
                Console.WriteLine("This is get accessor of Student name: ");
                return studentname;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu.StudentId = 101;
            stu.studentName = "saikat";
            Console.WriteLine(stu.StudentId);
            Console.WriteLine(stu.studentName);
            Console.Read();
        }
    }
}
