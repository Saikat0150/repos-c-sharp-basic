using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace this_method
{
    class Geometry
    {
        public void rectangle_area()
        {
            int height = 10, width = 20, ar;
            ar = height * width;
            Console.WriteLine("Area of rectangle is: " + ar);
        }
        public void square_area()
        {
            this.rectangle_area();
            int side = 10, ar;
            ar = side * side;
            Console.WriteLine("Area of square: " + ar);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Geometry g = new Geometry();
            g.square_area();
            Console.Read();
        }
    }
}
