using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_readonly
{
    class Sample
    {
        public readonly string CompanyName = "Sample";
        public static string Location = "Mumbai";
        public static void ShowAddress()
        {
            Console.WriteLine("City,Mumbai");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            Console.WriteLine(s.CompanyName);
            Sample.ShowAddress();
            Console.WriteLine(Sample.Location);
            Console.Read();
        }
    }
}
