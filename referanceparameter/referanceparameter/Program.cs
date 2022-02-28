using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace referanceparameter
{
    class SampleClass
    {
        public void firstMethod(int x,int y)
        {
            x++;
            y++;
        }
        public void secondMethod(ref int x,ref int y)
        {
            x++;
            y++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sc = new SampleClass();
            int a = 10, b = 20;
            Console.WriteLine(a + " " + b);
            sc.firstMethod(a, b);
            Console.WriteLine(a + " " + b);
            sc.secondMethod(ref a, ref b);
            Console.WriteLine(a + " " + b);
            Console.Read();

        }
    }
}
