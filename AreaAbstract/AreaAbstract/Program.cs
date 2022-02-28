using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAbstract
{
    abstract class Shape
    {
        public abstract void AreaRectangle();
        public abstract void AreaSquare();
        public abstract void AreaTriangle();
        public void AreaRectangle1()
        {
            Console.WriteLine("Enter the Height and Width: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Rectangle: " + height * width);
        }
        public void AreaSquare1()
        {
            Console.WriteLine("Enter the value of one Side of the square: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Square: " + side * side);

        }
        public void AreaTriangle1()
        {
            Console.WriteLine("Enter the value of Base and Height of the triangle: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Triangle: " + (0.5 * Base * height));

        }


    }
    /*class Area : Shape
    {
        
        public override void AreaRectangle()
        {
            Console.WriteLine("Enter the Height and Width: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Rectangle: " + height * width);
        }
        public override void AreaSquare()
        {
            Console.WriteLine("Enter the value of one Side of the square: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Square: " + side * side);

        }
        public override void AreaTriangle()
        {
            Console.WriteLine("Enter the value of Base and Height of the triangle: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Triangle: " + (0.5 * Base * height));

        }
    }
    class Program:
    {
        static void Main(string[] args)
        {
            Area r = new Area();
            r.AreaRectangle();
            r.AreaSquare();
            r.AreaTriangle();
            Console.Read();
        }
    }*/
    class Program : Shape
    {
        static void Main(string[] args)
        {
            Program r = new Program();
            r.AreaRectangle1();
            r.AreaSquare1();
            r.AreaTriangle1();
            Console.WriteLine("-------------------------------");
            Console.Read();
        }
        public override void AreaRectangle()
        {
            Console.WriteLine("Enter the Height and Width: ");
            int height = Convert.ToInt32(Console.ReadLine());
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Rectangle: " + height * width);
        }
        public override void AreaSquare()
        {
            Console.WriteLine("Enter the value of one Side of the square: ");
            int side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Square: " + side * side);

        }
        public override void AreaTriangle()
        {
            Console.WriteLine("Enter the value of Base and Height of the triangle: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The area of Triangle: " + (0.5 * Base * height));

        }
    }
}
