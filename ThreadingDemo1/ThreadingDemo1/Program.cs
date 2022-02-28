using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingSleepDemo1
{
    public class MyThread 
    {
        public void Thread1()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t2.Start();
            Console.Read();
        }
    }
}
