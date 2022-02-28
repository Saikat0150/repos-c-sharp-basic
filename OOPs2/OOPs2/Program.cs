using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs2
{
    class Rectangle
    {
        private double length;
        private double width;

        public void setDetails()
        {
            Console.WriteLine("Enter the Length:");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Width:");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Length: " + length);
            Console.WriteLine("Width: " + width);
            Console.WriteLine("Area: " + GetArea());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.setDetails();
            r.Display();
            Console.Read();
            
        }
    }
}
