using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_perse
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            string s = "5000";
            int x = Convert.ToInt32("43");
            int y = Convert.ToInt32(null);
            z = Convert.ToInt32(s);
            Console.WriteLine(x + "," + y + "," + z);
            
            Console.Read();
        }
    }
}
