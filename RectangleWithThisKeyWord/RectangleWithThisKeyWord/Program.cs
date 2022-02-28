using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithThisKeyWord
{
    class Rectangle
    {
        private double length;
        private double width;
        public void setLength(double length)
        {
            this.length = length;
        }
        public void setWidth(double width)
        {
            this.width = width;
        }
        public double calArea()
        {
            return this.length * this.width;
        }
        public void Display()
        {
            Console.WriteLine("Length: " + this.length);
            Console.WriteLine("Width: " + this.width);
            Console.WriteLine("Area: " + calArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double l, w;
            Console.WriteLine("Enter the length: ");
            l = Convert.ToDouble(Console.ReadLine());
            w = Convert.ToDouble(Console.ReadLine());
            Rectangle r = new Rectangle();
            r.setLength(l);
            r.setWidth(w);
            r.Display();
            Console.Read();
        }
    }
}
