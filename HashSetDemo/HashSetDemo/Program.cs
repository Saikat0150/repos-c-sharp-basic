using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new HashSet<string>();
            names.Add("Suresh");
            names.Add("Kiran");
            names.Add("sita");
            names.Add("Ram");
            names.Add("Anil");
            foreach(string i in names)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
