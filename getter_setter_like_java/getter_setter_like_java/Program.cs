using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getter_setter_like_java
{
    class Person
    {
        private int age;
        public int getAge()
        {
            return age + 1;
        }
        public void setAge(int ageval)
        {
            age = ageval + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.setAge(18);
            Console.WriteLine(p.getAge());

            Console.Read();
        }
    }
}
