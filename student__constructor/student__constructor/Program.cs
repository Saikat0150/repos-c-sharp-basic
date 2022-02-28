using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student__constructor
{
    class Student
    {
        int id;
        string name;
        public Student()
        {
            name = "unknown";
            id = 0;
        }
        public Student(string n,int Id)
        {
            name = n;
            id = Id;
        }
        public Student(Student s)
        {
            name = s.name;
            id = s.id;
        }
        ~Student()
        {
            Console.WriteLine("End of the constructor..");
        }
        public void show()
        {
            Console.WriteLine("Name is: " + name + " and id is: " + id);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.show();
            Console.WriteLine("Enter Student name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Student s1 = new Student(name,id);
            s1.show();
            //Student s2 = s1;
            Student s2 = new Student(s1);
            s2.show();
            
            Console.ReadLine();
        }
    }
}
