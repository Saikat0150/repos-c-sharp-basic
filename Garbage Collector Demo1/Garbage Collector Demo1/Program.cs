using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garbage_Collector_Demo1
{
    public class GarbageCheck
    {
        public GarbageCheck()
        {
            Console.WriteLine("Reserve the memory");
        }
        ~GarbageCheck()
        {
            Console.WriteLine("Free Memory");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            GarbageCheck g = new GarbageCheck();
            g = null;

            //free memory by calling collector
            GC.Collect();

            Console.Read();
        }
    }
}
