using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;
            bool? boolval = new bool?();
            Console.WriteLine("Nillables at Show: {0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable Boolean value is: {0}", boolval);
            Console.Read();
        }
    }
}
