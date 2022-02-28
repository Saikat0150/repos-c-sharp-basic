using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace ThreadingAsynchronous
{
    class Printer
    {
        public void PrintTable()
        {
            
            for(int i = 0; i <= 5; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2=new Thread(new ThreadStart(p.PrintTable));
            t1.Start();
            t2.Start();
            Console.Read();
        }
    }
}
