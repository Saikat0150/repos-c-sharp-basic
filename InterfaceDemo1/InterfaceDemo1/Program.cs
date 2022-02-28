using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo1
{
    interface SimpleInterest
    {
        double GetSimpleInterest(double p, int n, double r);
    }
    class SimpleInterestImpl : SimpleInterest
    {
        public double GetSimpleInterest(double p,int n,double r)
        {
            return ((p * n * r) / 100);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleInterestImpl s = new SimpleInterestImpl();
            Console.WriteLine("Simple Interest is: " + s.GetSimpleInterest(5000, 3, 4.5));
            Console.ReadLine();
        }
    }
}
