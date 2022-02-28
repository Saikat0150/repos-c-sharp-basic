using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thisKeyword
{
    class Rectangle
    {
        int height = 5, width = 6, ar;
        public void area()
        {
            int height = 10, width = 20;
            ar = height * width;
            Console.WriteLine("Area1= " + ar);
            ar = this.height * this.width;
            Console.WriteLine("Area2= " + ar);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.area();
            Console.Read();
        }
    }
}
