using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_rectangle
{
    class Shape
    {
        protected int height;
        protected int width;
        public void setHeight(int x)
        {
            height = x;
        }
        public void setWidth(int y)
        {
            width = y;
        }
        
    }
    class Rectangle : Shape
    {
        public int Area()
        {
            return height * width;
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.setHeight(15);
            r.setWidth(10);
            int a = r.Area();
            Console.WriteLine("Area is: " + a);
            
            Console.Read();
        }
    }
}
