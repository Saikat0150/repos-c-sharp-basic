using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealedClass
{
    sealed class rect
    {
        int length, bredth;
        public void get(int x,int y)
        {
            length = x;
            bredth = y;
        }
        public void put()
        {
            Console.WriteLine("Rectangle: " + (length * bredth));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            rect r = new rect();
            r.get(5,6);
            r.put();
            Console.Read();
        }
    }
}
