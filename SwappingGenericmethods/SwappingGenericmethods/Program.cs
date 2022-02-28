using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwappingGenericmethods
{
    class Sample
    {
        public void SwapAndPrint<T>(ref T a,ref T b)
        {
            Console.WriteLine("Before swapping the two numbers are: " + a + " and " + b);
            T temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping two numbers are: " + a + " and " + b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Sample s = new Sample();
            s.SwapAndPrint<int>(ref a, ref b);
            Console.Read();
        }
    }
}
