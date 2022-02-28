using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Synchronise_threading_with_Suspend_Resume_Etc
{
    class Printer
    {
        public void PrintTable()
        {
            lock (this)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(i);
                }
            }
        }
    }
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Printer p = new Printer();
            Thread t1 = new Thread(new ThreadStart(p.PrintTable));
            Thread t2 = new Thread(new ThreadStart(p.PrintTable));
            Console.WriteLine("Executing 1st thread");
            t1.Start();
            Thread.Sleep(500);
            t1.Suspend();

            Console.WriteLine("Start Executing 2nd thread");
            t2.Start();
            Thread.Sleep(1000);
            t2.Suspend();

            Console.WriteLine("Restarting thread1..");
            t1.Resume();
            Thread.Sleep(100);
            t1.Suspend();

            Console.WriteLine("Restarting thread2..");
            t2.Resume();
            Thread.Sleep(1000);
            t2.Suspend();

            Console.WriteLine("Restarting thread1..");
            t1.Resume();
            t1.Join();

            Console.WriteLine("Restarting thread2..");
            t2.Resume();

            t2.Join();
            Console.Read();
        }
    }
}
