using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_Initialize_Property_in_6._0_Demo1
{
    class Program
    {
        public string Name { get; private set; } = "Rahul Kumar";
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.Name = "Saikat";
            Console.WriteLine(pro.Name);
            Console.Read();
        }
    }
}
