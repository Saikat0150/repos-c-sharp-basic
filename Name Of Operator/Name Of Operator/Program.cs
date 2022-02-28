using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Of_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string name= "hello";
            //Accessing name of variable and method
            Console.WriteLine("Variable name is: " + nameof(name));
            Console.WriteLine("Method name is: " + nameof(show));
            Console.Read();
        }
        static void show()
        {
            //code statements
        }
    }
}
