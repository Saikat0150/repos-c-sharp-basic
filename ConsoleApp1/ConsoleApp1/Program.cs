using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingStartSleepInteruptAbort
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            Thread thr = new Thread(Fun);
            thr.Start();
            Thread.Sleep(300);
            thr.Interrupt();
            thr.Abort();
            Console.WriteLine("Thread thr interrupted by main thread.");
        }
        static void Fun()
        {
            Console.WriteLine("Thread thr is working.");
            for (int i = 0; ; i++) 
            {
                try 
                {
                    Console.WriteLine(i);
                    Thread.Sleep(10);
                }
                catch 
                {
                }
            }
        }
}

}
