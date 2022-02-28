using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rectangle_constructor
{
    class Rectangle
    {
        int height;
        int width;
        int area;
        public Rectangle(int h1,int w1)
        {
            height = h1;
            width = w1;
            area = height * width;
            
        }
        public void show()
        {
            Console.WriteLine("Area of Rectangle: " + area);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int h, w;
            Console.WriteLine("Enter height: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            w = Convert.ToInt32(Console.ReadLine());
            Rectangle obj = new Rectangle(h,w);
            Rectangle obj2 = obj;
            obj2.show();
            Console.Read();
        }
    }
}
