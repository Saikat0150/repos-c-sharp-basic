using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverlodingMaxValue
{
    class Max
    {
        public int maxv(int a,int b,int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if(b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public float maxv(float a,float b,float c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
        public double maxv(double a,double b,double c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Max m = new Max();
            Console.WriteLine("The maximum value is: " + m.maxv(5, 9, 6));
            Console.WriteLine("The maximum value is: " + m.maxv(10.5f, 9.4f, 6.8f));
            Console.WriteLine("The maximum value is: " + m.maxv(20.55, 25.11, 18.55));
            Console.Read();
        }
    }
}
