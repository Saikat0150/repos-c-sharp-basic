using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkedUnchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }
            Console.ReadLine();
        }
    }
}
