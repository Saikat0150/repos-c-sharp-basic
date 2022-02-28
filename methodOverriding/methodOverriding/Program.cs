using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverriding
{
    class US
    {
        public virtual void ShowCountry()
        {
            Console.WriteLine("This is US");
        }
    }
    class India : US
    {
        public override void ShowCountry()
        {
            Console.WriteLine("This is India");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            India i = new India();
            i.ShowCountry();
            Console.Read();
        }
    }
}
