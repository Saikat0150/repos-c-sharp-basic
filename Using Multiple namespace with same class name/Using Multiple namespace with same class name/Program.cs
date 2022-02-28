using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Multiple_namespace_with_same_class_name
{
    namespace first_space
    {
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Using First Namespace");
            }
        }
    }
    namespace second_space
    {
        
        class namespace_cl
        {
            public void func()
            {
                Console.WriteLine("Using Second Namespace");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            first_space.namespace_cl f = new first_space.namespace_cl();
            second_space.namespace_cl s = new second_space.namespace_cl();
            f.func();
            s.func();
            Console.Read();
        }
    }
}
