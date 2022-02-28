using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using First;
using Second;

namespace nameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Hello h1 = new Hello();
            Wellcome w = new Wellcome();
            h1.sayHello();
            w.sayWellcome();
            Console.Read();
        }
    }
}
