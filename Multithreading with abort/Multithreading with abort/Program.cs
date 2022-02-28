using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithreading_with_abort
{
    
    public class NewThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }

        }
    }
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {

            NewThread mt = new NewThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
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
            
            

            
            
        }
    }
}
