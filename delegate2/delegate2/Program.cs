using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate2
{
    //delegate int cal(int x, int y);
    class abc
    {
        /*public int add(int x,int y)
        {
            return x + y;
        }
        public static int multi(int x,int y)
        {
            return x * y;
        }*/
        public int getSum(int x,int y,int z)
        {
            return x + y + z;
        }
    }
    class Program
    {
        delegate int AnoDel(int x, int y, int z);
        static void Main(string[] args)
        {
            //cal c1,c2;
            abc a = new abc();
            /*c1 = a.add;
            c2 = abc.multi;
            int x = c1(8, 6);
            Console.WriteLine("Add methods from delegate: " + x);
            int y = c2(15, 6);
            Console.WriteLine("Multi methods from delegate: " + y);*/
            AnoDel n = new AnoDel(a.getSum);
            Console.WriteLine("Target method: " + n.Target);
            Console.WriteLine("Target method signature: " + n.Method);
            Console.WriteLine("Sum is: " + n.Invoke(10,26,34));
            Console.Read();
        }
    }
}
