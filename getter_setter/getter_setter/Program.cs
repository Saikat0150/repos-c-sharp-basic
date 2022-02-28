using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter_setter
{
    class Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public void printData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.name = "Saikat";
            p.age = 21;
            p.printData();
            Console.Read();
        }
    }
}
