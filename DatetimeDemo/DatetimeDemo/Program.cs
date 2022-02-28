using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatetimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create DateTime obj
            DateTime dt1;
            dt1 = Convert.ToDateTime("14/02/2022 12:19AM");
            DateTime dt2 = DateTime.Now;
            Console.WriteLine("dt1 is: " + dt1.ToString());
            Console.WriteLine("dt2 is: " + dt2.ToString());
            Console.Read();
        }
    }
}
