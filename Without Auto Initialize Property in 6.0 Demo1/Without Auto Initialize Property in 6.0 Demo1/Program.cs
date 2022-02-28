using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Without_Auto_Initialize_Property_in_6._0_Demo1
{
    class PropertyInitializer
    {
        public string Name { get; set; }
        PropertyInitializer()
        {
            Name = "Rahul Kumar";
        }
        static void Main(string[] args)
        {
            PropertyInitializer pin = new PropertyInitializer();
            Console.WriteLine(pin.Name);
            Console.Read();
        }
    }
}
