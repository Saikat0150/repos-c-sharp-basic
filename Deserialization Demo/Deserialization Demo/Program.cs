using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Deserialization_Demo
{
    [Serializable]
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = new FileStream("D:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = (Student)formatter.Deserialize(stream);
            Console.WriteLine("Roll No.: " + s.rollno);
            Console.WriteLine("Name: " + s.name);
            stream.Close();
        }
    }
}
