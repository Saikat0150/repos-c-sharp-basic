using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization_And_Deserialization_Demo
{
    [Serializable]
    class Student
    {
        public  int rollno;
        public string name;
        public Student(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Serialization
            FileStream stream = new FileStream("D:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();
            Student s = new Student(101, "Saikat");
            formatter.Serialize(stream, s);
            stream.Close();

            //Deserialization
            FileStream stream1 = new FileStream("D:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter1 = new BinaryFormatter();
            Student s1 = (Student)formatter.Deserialize(stream1);
            Console.WriteLine("Roll No.: " + s1.rollno);
            Console.WriteLine("Name: " + s1.name);
            stream1.Close();

        }
    }
}
