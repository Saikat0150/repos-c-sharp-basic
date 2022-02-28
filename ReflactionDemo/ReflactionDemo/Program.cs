using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflactionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 10;
            Type ty = a.GetType();
            Console.WriteLine(ty);*/
            Type t = typeof(System.String);
            Console.WriteLine(t.FullName);
            Console.WriteLine(t.BaseType);
            Console.WriteLine(t.IsClass);
            Console.WriteLine(t.IsEnum);
            Console.WriteLine(t.IsInterface);
            Console.ReadLine();
        }
    }
}
